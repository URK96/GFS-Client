using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Text;

namespace Girls_FrontierLine_Supporter
{
    public partial class GFSInfo : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();

        public GFSInfo()
        {
            InitializeComponent();

            InitProcess();
        }

        private void InitProcess()
        {
        	LoadBackgroundImage();
            VersionLabel.Text = "ver. " + ETC.ClientVer[0] + "." + ETC.ClientVer[1] + "." + ETC.ClientVer[2];
            ConfirmFonts();
        }

        private void ConfirmFonts()
        {
            string[] FontFiles = { "H2MKPB.TTF", "H2PORL.TTF", "H2SA1M.TTF" };
            const string FontPath = @"Data\System\Fonts";

            try
            {
                foreach (string s in FontFiles)
                {
                    string path = Path.Combine(FontPath, s);
                    if (File.Exists(path) == true) pfc.AddFontFile(path);
                }

                for (int i = 0; i < pfc.Families.Length; ++i)
                {
                    switch (pfc.Families[i].Name)
                    {
                        case "HY목각파임B":
                            InfoTitle.Font = new Font(pfc.Families[i], 15);
                            VersionLabel.Font = new Font(pfc.Families[i], 10);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
                return;
            }
        }

        private void LoadBackgroundImage()
        {
        	try
        	{
        		string[] ImagePath = Directory.GetFiles(@"Data/Image/InfoBG");
        		Random R = new Random();
        		
        		this.BackgroundImage = Image.FromFile(ImagePath[R.Next() % ImagePath.Length]);
        	}
        	catch(Exception ex)
            {
        		ETC.ErrorMessage("배경 이미지 불러오기 실패");
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://blog.naver.com/chlwlsgur963");
        }

        private async void DBResetButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DB를 재설정 하시겠습니까?", "DB파일 재설정 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await Task.Delay(1000);

                    Process.Start("GFS Updater.exe", "DB").WaitForExit();
                }
            }
            catch(Exception ex)
            {
            	
            }
        }

        private void GFSInfoClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            string url = "";

            string business = "chlwlsgur96@hotmail.com";  // your paypal email
            string description = "Donation";            // '%20' represents a space. remember HTML!
            string country = "KR";                  // AU, US, etc.
            string currency = "USD";                 // AUD, USD, etc.

            url += "https://www.paypal.com/cgi-bin/webscr" +
                "?cmd=" + "_donations" +
                "&business=" + business +
                "&lc=" + country +
                "&item_name=" + description +
                "&currency_code=" + currency +
                "&bn=" + "PP%2dDonationsBF";

            Process.Start(url);
        }
    }
}
