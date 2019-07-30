using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girls_FrontierLine_Updater
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();

            InitProcess();

            UpdateProcess();
        }

        private async void InitProcess()
        {
            await Task.Delay(100);

            UpdaterVersionLabel.Text = "Ver. " + ETC.UpdaterVersion[0] + "." + ETC.UpdaterVersion[1];
            if (Directory.Exists("Temp") == false) Directory.CreateDirectory("Temp");

            switch (ETC.Mode)
            {
                case ETC.UpdateMode.None:
                    UpdaterStatusLabel.Text = "테스트 모드";
                    UpdaterSubStatusLabel.Text = "";
                    break;
                case ETC.UpdateMode.Client:
                    UpdaterStatusLabel.Text = "업데이트 모드 : Client";
                    UpdaterSubStatusLabel.Text = "초기화 중...";
                    break;
                case ETC.UpdateMode.DB:
                    UpdaterStatusLabel.Text = "업데이트 모드 : DB";
                    UpdaterSubStatusLabel.Text = "초기화 중...";
                    break;
            }
        }

        private async void UpdateProcess()
        {
            await Task.Delay(1000);

            try
            {
                switch (ETC.Mode)
                {
                    case ETC.UpdateMode.Client:
                        await UpdateClient();
                        break;
                    case ETC.UpdateMode.DB:
                        await UpdateDB(ETC.UpdateMode.DB);
                        break;
                }
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
            }
        }

        [Obsolete]
        private async Task UpdateClientOld()
        {
            string ServerFile = "GFS_Update_Installer.exe";
            WebClient wc = new WebClient();

            try
            {
                await Task.Delay(1000);

                UpdaterStatusLabel.Text += "\n다운로드 서버 체크 중...";

                if (ETC.CheckServer(ETC.UpdateServer + ServerFile) == false)
                {
                    UpdaterSubStatusLabel.Text = "\n서버가 응답하지 않습니다.";
                    UpdaterStatusLabel.Text += "실패";
                }
                else UpdaterStatusLabel.Text += "성공";

                CloseButton.Enabled = false;

                await Task.Delay(1000);

                UpdaterStatusLabel.Text += "\n업데이트 설치 파일 다운로드 중...";
                UpdaterSubStatusLabel.Text = "다운로드 초기화 중...";

                await Task.Delay(1000);

                UpdaterSubStatusLabel.Text += "성공";
                UpdaterSubStatusLabel.Text += "\n업데이트 다운로드 중...";

                DownloadProgressBar.Visible = true;

                await Task.Delay(100);

                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;

                await wc.DownloadFileTaskAsync(ETC.UpdateServer + ServerFile, @"Temp\GFS Update Installer.exe");

                await Task.Delay(500);

                UpdaterSubStatusLabel.Text += "완료";
                UpdaterStatusLabel.Text += "성공";

                await Task.Delay(1000);

                DownloadProgressBar.Visible = false;

                UpdaterStatusLabel.Text += "\nDB 업데이트 확인 중...";
                await ETC.CheckDBVersion(ETC.CheckMode.DB);
                if (ETC.HasDBUpdate)
                {
                    UpdaterStatusLabel.Text += "있음";

                    await Task.Delay(500);

                    UpdaterStatusLabel.Text = "업데이트 모드 : Client -> DB";
                    UpdaterSubStatusLabel.Text = "초기화 중...";
                    await UpdateDB(ETC.UpdateMode.Client_DB);
                    await Task.Delay(500);
                    UpdaterStatusLabel.Text = "업데이트 모드 : Client";
                }
                else UpdaterStatusLabel.Text += "없음";

                await Task.Delay(500);

                UpdaterStatusLabel.Text += "\n클라이언트 종료 중...";
                UpdaterSubStatusLabel.Text = "종료 중...";

                await Task.Delay(1000);

                try
                {
                    Process[] plist = Process.GetProcessesByName("GFS");
                    foreach (Process p in plist)
                    {
                        p.Kill();
                    }
                }
                catch(Exception)
                {
                	UpdaterSubStatusLabel.Text += "실패";
                	UpdaterStatusLabel.Text += "실패";

                	CloseButton.Enabled = true;

                	return;
                }

                await Task.Delay(100);

                UpdaterSubStatusLabel.Text += "성공";
                UpdaterStatusLabel.Text += "성공";

                await Task.Delay(1000);

                UpdaterSubStatusLabel.Text = "";
                UpdaterStatusLabel.Text += "\n인스톨러를 실행합니다.";

                await Task.Delay(500);

                try
                {
                    Process p = new Process();
                    Process.Start(@"Temp\GFS Update Installer.exe");
                }
                catch (Exception)
                {
                    UpdaterStatusLabel.Text += "실패";
                    CloseButton.Enabled = true;

                    return;
                }

                await Task.Delay(1000);

                Close();
            }
            /*catch(WebException)
            {
                UpdaterSubStatusLabel.Text += "실패";
                UpdaterStatusLabel.Text += "실패";
                CloseButton.Enabled = true;
            }*/
            catch(Exception ex)
            {
                UpdaterSubStatusLabel.Text += "실패";
                UpdaterStatusLabel.Text += "실패";

                UpdaterStatusLabel.Text += "\n오류 로그 생성 중...";

                if (ETC.LogError(ex.Message + "\n\n" + ex.StackTrace) == false)
                {
                    UpdaterStatusLabel.Text += "실패";
                }
                else UpdaterStatusLabel.Text += "성공";
            }
        }

        private async Task UpdateDB(ETC.UpdateMode mode)
        {
            string Server = Path.Combine(ETC.UpdateServer, "Update");
            WebClient wc = new WebClient();

            try
            {
                await Task.Delay(1000);

                UpdaterStatusLabel.Text += "\n다운로드 서버 체크 중...";

                UpdaterSubStatusLabel.Text = "서버 체크 중...";

                if (ETC.CheckServer(Path.Combine(Server, "DBUpdate.zip")) == false)
                {
                    UpdaterSubStatusLabel.Text = "\n서버가 응답하지 않습니다.";

                    await Task.Delay(10);

                    UpdaterStatusLabel.Text += "실패";

                    CloseButton.Enabled = true;
                    return;
                }

                UpdaterSubStatusLabel.Text += "성공";
                UpdaterStatusLabel.Text += "성공";

                CloseButton.Enabled = false;

                await Task.Delay(1000);

                UpdaterStatusLabel.Text += "\n업데이트 파일 다운로드 중...";
                UpdaterSubStatusLabel.Text = "다운로드 초기화 중...";

                await Task.Delay(1000);

                UpdaterSubStatusLabel.Text += "성공";
                
                DownloadProgressBar.Visible = true;

                await Task.Delay(100);

                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;

                UpdaterSubStatusLabel.Text = "업데이트 다운로드 중...";

                await Task.Delay(500);

                await wc.DownloadFileTaskAsync(Path.Combine(Server, "DBUpdate.zip"), Path.Combine("Temp", "DBUpdate.zip"));

                await Task.Delay(100);

                UpdaterSubStatusLabel.Text += "완료";
                UpdaterStatusLabel.Text += "성공";

                await Task.Delay(500);

                DownloadProgressBar.Visible = false;

                UpdaterStatusLabel.Text += "\n클라이언트 종료 중...";
                UpdaterSubStatusLabel.Text = "종료 중...";

                await Task.Delay(1000);

                Process[] plist = Process.GetProcessesByName("GFS");
                foreach (Process p in plist)
                {
                	p.Kill();
                }

                await Task.Delay(100);

                UpdaterSubStatusLabel.Text += "성공";
                UpdaterStatusLabel.Text += "성공";

                await Task.Delay(500);

                UpdaterStatusLabel.Text += "\nDB 업데이트 압축해제 중...";
                UpdaterSubStatusLabel.Text = "압축해제 중...";

                await Task.Delay(500);

                if (Directory.Exists(Path.Combine("Temp", "DBTemp")) == false) Directory.CreateDirectory(Path.Combine("Temp", "DBTemp"));

                await ETC.UnzipProcess(Path.Combine("Temp", "DBUpdate.zip"), Path.Combine("Temp", "DBTemp"));

                await Task.Delay(100);

                UpdaterSubStatusLabel.Text += "완료";
                UpdaterStatusLabel.Text += "성공";

                if (Directory.Exists(Path.Combine("Data", "DB")) == false) Directory.CreateDirectory(Path.Combine("Data", "DB"));

                await Task.Delay(500);

                UpdaterStatusLabel.Text += "\nDB 업데이트 적용 중...";
                UpdaterSubStatusLabel.Text = "적용 중...";

                await Task.Delay(500);

                await ETC.CopyFolder(Path.Combine("Temp", "DBTemp"), Path.Combine("Data", "DB"));

                await Task.Delay(100);

                UpdaterSubStatusLabel.Text += "완료";
                UpdaterStatusLabel.Text += "성공";

                await Task.Delay(500);

                UpdaterSubStatusLabel.Text = "버전 갱신 중...";
                
                if (Directory.Exists(@"Data\System\") == false) Directory.CreateDirectory(@"Data\System\");

                await wc.DownloadFileTaskAsync(ETC.UpdateServer + "DBVer.txt", @"Temp\DBVer.txt");
                File.Copy(@"Temp\DBVer.txt", @"Data\System\DBVer.txt", true);

                await Task.Delay(500);

                UpdaterSubStatusLabel.Text += "완료";

                UpdaterStatusLabel.Text += "완료";

                await Task.Delay(500);

                if (mode == ETC.UpdateMode.Client_DB) return;

                UpdaterSubStatusLabel.Text = "";
                UpdaterStatusLabel.Text += "\n클라이언트 재실행. 업데이트를 종료합니다.";

                await Task.Delay(1000);

                Process.Start("GFS");

                Close();
            }
            catch (Exception ex)
            {
                UpdaterSubStatusLabel.Text += "실패";
                UpdaterStatusLabel.Text += "실패";

                UpdaterStatusLabel.Text += "\n오류 로그 생성 중...";

                if (ETC.LogError(ex.Message + "\n\n" + ex.StackTrace) == false)
                {
                    UpdaterStatusLabel.Text += "실패";
                }
                else UpdaterStatusLabel.Text += "성공";

                CloseButton.Enabled = true;
            }
        }
        
        private async Task UpdateClient()
        {
        	const string UpdateTempPath = @"Temp\ClientUpdate";
            WebClient wc = new WebClient();

            try
            {
                await Task.Delay(500);

                UpdaterStatusLabel.Text += "\n다운로드 서버 체크 중...";

                if (ETC.CheckServer(Path.Combine(ETC.UpdateServer, "Update", "Update.zip")) == false)
                {
                    UpdaterSubStatusLabel.Text = "\n서버가 응답하지 않습니다.";
                    UpdaterStatusLabel.Text += "실패";
                }
                else UpdaterStatusLabel.Text += "성공";

                CloseButton.Enabled = false;

                await Task.Delay(500);

                UpdaterStatusLabel.Text += "\n업데이트 파일 다운로드 중...";
                UpdaterSubStatusLabel.Text = "다운로드 초기화 중...";
                
                await Task.Delay(100);
                
                UpdaterSubStatusLabel.Text += "성공";
                
                await Task.Delay(500);

                DownloadProgressBar.Visible = true;

                await Task.Delay(100);

                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                
                DirectoryInfo di = new DirectoryInfo(UpdateTempPath);
                if (di.Exists == false) di.Create();

                UpdaterSubStatusLabel.Text = "업데이트 파일 다운로드 중...";

                await wc.DownloadFileTaskAsync(Path.Combine(ETC.UpdateServer, "Update", "Update.zip"), "Update.zip");

                UpdaterSubStatusLabel.Text += "완료";

                await Task.Delay(500);

                UpdaterStatusLabel.Text += "성공";

                await Task.Delay(500);

                DownloadProgressBar.Visible = false;

                UpdaterStatusLabel.Text += "\nDB 업데이트 확인 중...";
                await ETC.CheckDBVersion(ETC.CheckMode.DB);
                if (ETC.HasDBUpdate)
                {
                    UpdaterStatusLabel.Text += "있음";

                    await Task.Delay(500);

                    UpdaterStatusLabel.Text = "업데이트 모드 : Client -> DB";
                    UpdaterSubStatusLabel.Text = "초기화 중...";
                    await UpdateDB(ETC.UpdateMode.Client_DB);
                    await Task.Delay(500);
                    UpdaterStatusLabel.Text = "업데이트 모드 : Client";
                }
                else UpdaterStatusLabel.Text += "없음";

                await Task.Delay(500);

                UpdaterStatusLabel.Text += "\n클라이언트 종료 중...";
                UpdaterSubStatusLabel.Text = "종료 중...";

                await Task.Delay(500);

                Process[] plist = Process.GetProcessesByName("GFS");
                foreach (Process p in plist)
                {
                	p.Kill();
                }

                await Task.Delay(100);

                UpdaterSubStatusLabel.Text += "성공";
                UpdaterStatusLabel.Text += "성공";

                await Task.Delay(500);

                UpdaterStatusLabel.Text = "업데이트 갱신 프로그램 다운로드 중...";
                await Task.Delay(100);
                UpdaterSubStatusLabel.Text = "다운로드 중...";
                await wc.DownloadFileTaskAsync(Path.Combine(ETC.UpdateServer, "GFS Updater_C.exe"), "GFS Updater_C.exe");

                UpdaterSubStatusLabel.Text += "성공";
                UpdaterStatusLabel.Text += "성공";

                UpdaterSubStatusLabel.Text = "";
                UpdaterStatusLabel.Text += "\n업데이트 갱신 프로그램을 실행합니다.";

                await Task.Delay(500);

                Process.Start(@"GFS Updater_C.exe");

                await Task.Delay(100);

                Close();
            }
            catch(Exception ex)
            {
                UpdaterSubStatusLabel.Text += "실패";
                UpdaterStatusLabel.Text += "실패";

                UpdaterStatusLabel.Text += "\n오류 로그 생성 중...";

                if (ETC.LogError(ex.Message + "\n\n" + ex.StackTrace) == false)
                {
                    UpdaterStatusLabel.Text += "실패";
                }
                else UpdaterStatusLabel.Text += "성공";
                
                CloseButton.Enabled = true;
            }
        }


        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgressBar.Value = e.ProgressPercentage;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
