using Microsoft.Win32;
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girls_FrontierLine_Supporter
{
    internal static class ETC
    {
        internal enum CheckMode { Client, DB }
        internal enum TimeTableMode { Doll, Equipment, Fairy }

        internal static int[] LevelExp = { 0, 100, 300, 600, 1000, 1500, 2100, 2800, 3600, 4500, 5500, 6600, 7800, 9100, 10500, 12000, 13600, 15300, 17100, 19000, 21000, 23100, 25300, 27600, 30000, 32500, 35100, 37900, 41000, 44400, 48600, 53200, 58200, 63600, 69400, 75700, 82400, 89600, 97300, 105500, 114300, 123600, 133500, 144000, 155100, 166900, 179400, 192500, 206400, 221000, 236400, 252500, 269400, 287100, 305700, 325200, 345600, 366900, 389200, 412500, 436800, 462100, 488400, 515800, 544300, 573900, 604700, 636700, 669900, 704300, 749400, 796200, 844800, 895200, 947400, 1001400, 1057300, 1115200, 1175000, 1236800, 1300700, 1366700, 1434800, 1505100, 1577700, 1652500, 1729600, 1809100, 1891000, 1975300, 2087900, 2204000, 2323500, 2446600, 2573300, 2703700, 2837800, 2975700, 3117500, 3263200, 3363200, 3483200, 3623200, 3783200, 3963200, 4163200, 4383200, 4623200, 4903200, 5263200, 5743200, 6383200, 7283200, 8483200, 10083200, 12283200, 15283200, 19283200, 24283200, 30283200};
        internal static int[] LevelLink_DollCount = { 0, 1, 1, 2, 3 };
        internal static int[] GradeLinkCore = { 1, 3, 9, 15 };

        internal static int[] ClientVer = { 2, 9, 4 };
        
        internal static ArrayList MDLocation = new ArrayList(4);

        internal static bool HasClientUpdate = false;
        internal static bool HasDBUpdate = false;
        internal static bool IsShowCensorImage = true;

        internal static DataTable MDSupportDT = new DataTable();
        internal static DataTable DollList = new DataTable();
        internal static DataTable EquipmentList = new DataTable();
        internal static DataTable FairyList = new DataTable();
        internal static DataTable FreeOPList = new DataTable();
        internal static DataTable SkillTrainingList = new DataTable();
        internal static DataTable EnemyList = new DataTable();
        internal static DataTable FairyAttribution = new DataTable();

        internal static string Server = "http://chlwlsgur96.ipdisk.co.kr:80/publist/HDD1/Data/Project/GFS/";
        internal static string ImageServer = Path.Combine(Server + "Data", "Images");
        internal static string DBPath = @"Data\DB";

        internal static RegistryKey GFSRegistry = Registry.CurrentUser.CreateSubKey(@"Software\GFS");

        internal static void ErrorMessage<T>(T ErrorDetail)
        {
            MessageBox.Show("오류가 발생했습니다. 발생한 오류는 다음과 같습니다.\n\n" + ErrorDetail + "\n\n지속적으로 이 오류가 발생하면 제작자에게 문의하시기 바랍니다.", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static bool ClearTempFile()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo("Temp");
                if (di.Exists == true) di.Delete(true);
                
                if (File.Exists("GFS Updater_C.exe") == true) File.Delete("GFS Updater_C.exe");
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        internal static async Task CheckVersion(CheckMode mode)
        {
            StreamReader sr = null;

            string ver_file = "";

            try
            {
                await Task.Delay(100);

                if (Directory.Exists("Temp") == false) Directory.CreateDirectory("Temp");

                switch (mode)
                {
                    case CheckMode.Client:
                        ver_file = @"Temp\ClientVer.txt";
                        await DownloadFile(Server + "ClientVer.txt", ver_file);
                        sr = new StreamReader(new FileStream(@"Temp\ClientVer.txt", FileMode.Open, FileAccess.Read));
                        string[] server_ver = (sr.ReadToEnd()).Split('.');
                        for(int i = 0; i < server_ver.Length; ++i)
                        {
                            if (ClientVer[i] == Convert.ToInt32(server_ver[i])) { }
                            else if (ClientVer[i] > Convert.ToInt32(server_ver[i]))
                            {
                                break;
                            }
                            else if (ClientVer[i] < Convert.ToInt32(server_ver[i]))
                            {
                                HasClientUpdate = true;
                                break;
                            }
                        }
                        break;
                    case CheckMode.DB:
                        if (File.Exists(@"Data\System\DBVer.txt") == true)
                        {
                            ver_file = @"Temp\DBVer.txt";
                            await DownloadFile(Server + "DBVer.txt", ver_file);
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
            catch(IOException ex)
            {

            }
            catch(Exception ex)
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

        internal static async Task DownloadFile(string address, string target)
        {
            WebClient wc = new WebClient();

            try
            {
                await Task.Delay(100);

                wc.DownloadFile(address, target);

            }
            catch(Exception ex)
            {

            }
        }

        internal static DataRow FindDataRow<T>(DataTable table, string index, T value)
        {
            try
            {
                for (int i = 0; i < table.Rows.Count; ++i)
                {
                    DataRow dr = table.Rows[i];
                    if (((T)dr[index]).Equals(value)) return dr;
                }
            }
            catch(Exception ex)
            {
                ErrorMessage(ex.StackTrace);
                LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return null;
        }

        internal static DataRow FindDataRow<T1, T2>(DataTable table, string index1, string index2, T1 value1, T2 value2)
        {
            try
            {
                for (int i = 0; i < table.Rows.Count; ++i)
                {
                    DataRow dr = table.Rows[i];
                    if ((((T1)dr[index1]).Equals(value1)) && (((T2)dr[index2]).Equals(value2))) return dr;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
                LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return null;
        }

        internal static bool LogError(string message)
        {
            string LogPath = @"System\Log";
            StreamWriter sw = null;

            try
            {
                if (Directory.Exists(LogPath) == false) Directory.CreateDirectory(LogPath);
                if (Directory.Exists(Path.Combine(LogPath, "Client")) == false) Directory.CreateDirectory(Path.Combine(LogPath, "Client"));

                DateTime dt = DateTime.Now;
                string fileName = dt.Year + "." + dt.Month + "." + dt.Day + "." + dt.Hour + "." + dt.Minute + "." + dt.Second + "--" + "Client Error Log.txt";

                sw = new StreamWriter(new FileStream(Path.Combine(LogPath, "Client", fileName), FileMode.Create, FileAccess.Write));
                sw.Write(message);
                sw.Flush();
            }
            catch (Exception ex)
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

        internal static string CalcTime(int minute)
        {
            return (minute / 60) + " : " + (minute % 60).ToString("D2");
        }

        internal static int CalcAbilityRank(DataRow DollDR, string type, int index)
        {
            string DollType = (string)DollDR["Type"];
            int rank = 1;
            int DollAbility = 0;

            if (type == "Bullet") DollAbility = (int)DollDR[type];
            else if (type == "Armor") DollAbility = Int32.Parse(((string)DollDR[type]).Split('/')[1]);
            else
            {
                string temp = ((string)DollDR[type]).Split(';')[index];

                switch (index)
                {
                    case 0:
                        DollAbility = Int32.Parse(temp.Split('/')[1]);
                        break;
                    case 1:
                    case 2:
                    case 3:
                        DollAbility = Int32.Parse(temp);
                        break;
                }
                
            }
            
            for (int i = 0; i < DollList.Rows.Count; ++i)
            {
                DataRow dr = DollList.Rows[i];
                if (DollType != (string)dr["Type"]) continue;

                int tAbility = 0;

                if (type == "Bullet") tAbility = (int)dr[type];
                else if (type == "Armor") tAbility = Int32.Parse(((string)DollDR[type]).Split('/')[1]);
                else tAbility = Int32.Parse((((string)dr[type]).Split(';')[0]).Split('/')[1]);

                if (DollAbility < tAbility) rank += 1;
            }

            return rank;
        }

        internal static double[] CalcWeight(params int[] source)
        {
            double sum = 0;
            foreach (int i in source) sum += i;

            double average = sum / source.Length;

            double[] result = new double[source.Length];

            for (int i = 0; i < source.Length; ++i)
            {
                if (source[i] == 0) result[i] = (average - 1) / 1;
                else result[i] = (average - source[i]) / source[i];
            }
            return result;
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
    }

    internal class Sorter : IComparer
    {
        internal int ColumnIndex = 0;
        internal SortOrder Order = SortOrder.None;

        public int Compare(object x, object y)
        {
            if ((!(x is ListViewItem)) || (!(y is ListViewItem))) return 0;

            ListViewItem lvi1 = (ListViewItem)x;
            ListViewItem lvi2 = (ListViewItem)y;

            if ((lvi1.ListView.Columns[ColumnIndex].Tag == null) || ((string)lvi1.ListView.Columns[ColumnIndex].Tag == "")) lvi1.ListView.Columns[ColumnIndex].Tag = "Text";

            string str1 = lvi1.SubItems[ColumnIndex].Text;
            string str2 = lvi2.SubItems[ColumnIndex].Text;

            if ((string)lvi1.ListView.Columns[ColumnIndex].Tag == "Numeric")
            {
                float f1 = float.Parse(str1);
                float f2 = float.Parse(str2);

                if (Order == SortOrder.Ascending) return f1.CompareTo(f2);
                else return f2.CompareTo(f1);
            }
            else if ((string)lvi1.ListView.Columns[ColumnIndex].Tag == "Time")
            {
                int t_hour1 = int.Parse(str1.Split(':')[0]);
                int t_hour2 = int.Parse(str2.Split(':')[0]);
                int t_minute1 = int.Parse(str1.Split(':')[1]);
                int t_minute2 = int.Parse(str2.Split(':')[1]);

                int t1 = (t_hour1 * 60) + t_minute1;
                int t2 = (t_hour2 * 60) + t_minute2;

                if (Order == SortOrder.Ascending) return t1.CompareTo(t2);
                else return t2.CompareTo(t1);
            }
            else if ((string)lvi1.ListView.Columns[ColumnIndex].Tag == "MDLocation")
            {
                string t_s1 = str1.Split('-')[0];
                string t_s2 = str2.Split('-')[0];

                int p1 = Int32.Parse(t_s1);
                int p2 = Int32.Parse(t_s2);

                if (Order == SortOrder.Ascending) return p1.CompareTo(p2);
                else return p2.CompareTo(p1);
            }
            else
            {
                if (Order == SortOrder.Ascending) return str1.CompareTo(str2);
                else return str2.CompareTo(str1);
            }
        }
    }
}
