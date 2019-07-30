using System.Windows.Forms;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Drawing;

namespace Girls_FrontierLine_Supporter
{
    public partial class SplashScreen : Form
    {
        Form parent = null;
        internal Label StatusMessage;

        public SplashScreen(Form parentForm)
        {
            InitializeComponent();

            StatusMessage = StatusLabel;
            parent = parentForm;
            LoadSplashImage();
            VisibleSplash();
        }

        private void LoadSplashImage()
        {
            try
            {
                string[] ImagePath = Directory.GetFiles(@"Data/Image/SplashBG");
                Random R = new Random();

                this.BackgroundImage = Image.FromFile(ImagePath[R.Next() % ImagePath.Length]);
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
                parent.Close();
            }
        }

        private async void VisibleSplash()
        {
            try
            {
                for (int i = 0; i <= 50; ++i)
                {
                    this.Opacity = i * 0.02;
                    await Task.Delay(1);
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
                parent.Close();
            }
        }

        internal async Task InVisibleSplash()
        {
            try
            {
                for (int i = 50; i >= 0; --i)
                {
                    this.Opacity = i * 0.02;
                    await Task.Delay(1);
                }

                Close();
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
                parent.Close();
            }
        }

        private void SplashCloseButton_Click(object sender, EventArgs e)
        {
            parent.Close();
        }
    }
}
