using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Drawing;

namespace Girls_FrontierLine_Supporter
{
    public partial class Notification : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();

        public Notification()
        {
            InitializeComponent();

            ConfirmFonts();
            LoadNotification();
        }

        private async void LoadNotification()
        {
            await Task.Delay(100);

            try
            {
                WebClient wc = new WebClient();
                string tResult = await wc.DownloadStringTaskAsync(new Uri("http://chlwlsgur96.ipdisk.co.kr:80/publist/HDD1/Data/Project/GFS/Notification.txt"));

                NotificationBox.Text = tResult;
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
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
                            NotificationBox.Font = new Font(pfc.Families[i], 16);
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

        private void NotificationCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
