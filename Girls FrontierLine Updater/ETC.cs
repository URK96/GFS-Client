using System;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Girls_FrontierLine_Updater
{
    internal static class ETC
    {
        internal enum UpdateMode { Client, DB, Client_DB,  None }
        internal enum CheckMode { Client, DB }

        internal static UpdateMode Mode = UpdateMode.Client;
        internal static int[] UpdaterVersion = { 3, 0 };

        internal static bool HasDBUpdate = false;

        internal static string UpdateServer = "http://chlwlsgur96.ipdisk.co.kr:80/publist/HDD1/Data/Project/GFS/";
        internal static int ClientProcessId = 1;

        internal static void ErrorMessage<T>(T ErrorDetail)
        {
            MessageBox.Show("오류가 발생했습니다. 발생한 오류는 다음과 같습니다.\n\n" + ErrorDetail + "\n\n지속적으로 이 오류가 발생하면 제작자에게 문의하시기 바랍니다.", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static bool CheckServer(string address)
        {
            WebRequest request = null;
            WebResponse response = null;

            try
            {
                request = WebRequest.Create(address);
                request.Timeout = 10000;
                response = request.GetResponse();
            }
            catch(Exception)
            {
                return false;
            }
            finally
            {
                response.Close();
                response.Dispose();
            }

            return true;
        }

        internal static bool LogError(string message)
        {
            string LogPath = @"System/Log";
            StreamWriter sw = null;

            try
            {
                if (Directory.Exists(LogPath) == false) Directory.CreateDirectory(@"Data\Log");
                if (Directory.Exists(Path.Combine(LogPath, "Updater")) == false) Directory.CreateDirectory(Path.Combine(LogPath, "Updater"));

                DateTime dt = DateTime.Now;
                string fileName = dt.Year + "." + dt.Month + "." + dt.Day + "." + dt.Hour + "." + dt.Minute + "." + dt.Second + "--" + "Updater Error Log.txt";

                sw = new StreamWriter(new FileStream(Path.Combine(LogPath, "Updater", fileName), FileMode.Create, FileAccess.Write));
                sw.Write(message);
                sw.Flush();
            }
            catch(Exception ex)
            {
                ErrorMessage(ex.Message);
                return false;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }

            return true;
        }

        internal static async Task CheckDBVersion(CheckMode mode)
        {
            StreamReader sr = null;

            string ver_file = "";

            try
            {
                await Task.Delay(100);

                if (Directory.Exists("Temp") == false) Directory.CreateDirectory("Temp");

                switch (mode)
                {
                    case CheckMode.DB:
                        if (File.Exists(@"Data\System\DBVer.txt") == true)
                        {
                            ver_file = @"Temp\DBVer.txt";
                            await DownloadFile(UpdateServer + "DBVer.txt", ver_file);
                            sr = new StreamReader(new FileStream(ver_file, FileMode.Open, FileAccess.Read));
                            string server_dbver = sr.ReadToEnd();
                            sr.Close();
                            sr = new StreamReader(new FileStream(@"Data\System\DBVer.txt", FileMode.Open, FileAccess.Read));
                            string local_dbver = sr.ReadToEnd();
                            if (Convert.ToInt32(local_dbver) < Convert.ToInt32(server_dbver)) HasDBUpdate = true;
                        }
                        else HasDBUpdate = true;
                        break;
                }
            }
            catch (IOException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
        }

        internal static async Task CopyFolder(string sourceFolder, string destFolder)
        {
            await Task.Delay(100);

            if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder);

            string[] files = Directory.GetFiles(sourceFolder);
            string[] folders = Directory.GetDirectories(sourceFolder);

            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest, true);
            }

            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                await CopyFolder(folder, dest);
            }
        }

        internal static async Task UnzipProcess(string sourceZipFile, string targetFolder)
        {
            await Task.Delay(100);

            try
            {
                using (ZipArchive archive = ZipFile.OpenRead(sourceZipFile))
                {
                    await Task.Run(delegate { archive.ExtractToDirectory(targetFolder); });
                }
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }

        internal static async Task DownloadFile(string address, string target)
        {
            WebClient wc = new WebClient();

            try
            {
                await Task.Delay(100);

                wc.DownloadFile(address, target);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
