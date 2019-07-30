using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Compression;

namespace Girls_FrontierLine_Client_Updater
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
	{
        int totalFileCount = 0;

		public MainForm()
        {
			InitializeComponent();
			
			UpdateProcess();
		}
		
		private async void UpdateProcess()
		{
			ArrayList FileList = new ArrayList(5);
			const string UpdateFilePath = @"Temp\ClientUpdate";
			
			try
			{
				UpdateStatusLabel.Text = "초기화 중";

                DirectoryInfo di = new DirectoryInfo(UpdateFilePath);
                DirectoryInfo di2 = new DirectoryInfo(@"Data\Voice");
                if (di.Exists == true)
                {
                    di.Delete(true);
                    di.Create();
                }
                if (di.Exists == true)
                {
                    di.Delete(true);
                }
				
				await Task.Delay(1000);
				
				UpdateStatusLabel.Text = "업데이트 파일 검증 중";

                await Task.Delay(500);

				if (File.Exists("Update.zip") == false)
                {
                    MessageBox.Show("업데이트 파일이 존재하지 않습니다. 업데이트를 다시 실행해 주세요.", "업데이트 파일 확인 불가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
				
				UpdateStatusLabel.Text = "업데이트 압축파일 해제 중";
				UpdateStatusProgress.Visible = true;
                UpdateStatusProgress.Style = ProgressBarStyle.Marquee;

                await UnzipProcess("Update.zip", UpdateFilePath);

                await Task.Delay(1000);

                UpdateStatusLabel.Text = "압축 해제 파일 검증 중...";
                totalFileCount = 0;
                await CheckFiles(UpdateFilePath, Application.StartupPath);

                await Task.Delay(1000);

                UpdateStatusLabel.Text = "업데이트 적용 중";
                UpdateStatusProgress.Style = ProgressBarStyle.Continuous;
                UpdateStatusProgress.Value = 0;
                UpdateStatusProgress.Maximum = totalFileCount;

                UpdateStatusLabel.Text = totalFileCount.ToString();
                await CopyFolder(UpdateFilePath, Application.StartupPath);

                await Task.Delay(1000);

                UpdateStatusLabel.Text = "추가 작업 중";
                UpdateStatusProgress.Style = ProgressBarStyle.Marquee;
                await Task.Delay(1000);
                await ExtraWork();

                await Task.Delay(500);

                UpdateStatusLabel.Text = "업데이트 파일 정리 중";
                UpdateStatusProgress.Visible = false;

                File.Delete("Update.zip");

                await Task.Delay(1000);

                UpdateStatusProgress.Visible = false;

                UpdateStatusLabel.Text = "클라이언트 실행 중";

                await Task.Delay(1000);

                Process.Start("GFS.exe");
                Close();
			}
			catch(Exception ex)
			{
                ErrorMessage(ex.Message);
            }
		}

        private async Task UnzipProcess(string sourceZipFile, string targetFolder)
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

        private async Task CopyFolder(string sourceFolder, string destFolder)
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
                UpdateStatusProgress.PerformStep();
                //UpdateStatusLabel.Text = UpdateStatusProgress.Value.ToString() + " / " + totalFileCount.ToString();
            }

            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                await CopyFolder(folder, dest);
            }
        }

        private async Task CheckFiles(string sourceFolder, string destFolder)
        {
            await Task.Delay(100);

            if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder);

            string[] files = Directory.GetFiles(sourceFolder);
            string[] folders = Directory.GetDirectories(sourceFolder);

            foreach (string file in files)
            {
                totalFileCount += 1;
            }

            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                await CheckFiles(folder, dest);
            }
        }

        private async Task ExtraWork()
        {
            await Task.Delay(100);

            try
            {
                DirectoryInfo di = new DirectoryInfo(@"Data\Image\SDAnimation");
                if (di.Exists == true) di.Delete(true);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }

        internal static void ErrorMessage<T>(T ErrorDetail)
        {
            MessageBox.Show("오류가 발생했습니다. 발생한 오류는 다음과 같습니다.\n\n" + ErrorDetail + "\n\n지속적으로 이 오류가 발생하면 제작자에게 문의하시기 바랍니다.", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
