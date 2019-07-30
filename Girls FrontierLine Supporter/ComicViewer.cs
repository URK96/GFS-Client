using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girls_FrontierLine_Supporter
{
    public partial class ComicViewer : Form
    {
        private string ViewerMode = "";
        private string ServerImagePath = Path.Combine(ETC.ImageServer, "Comics");

        public ComicViewer(string mode)
        {
            InitializeComponent();

            ViewerMode = mode;

            InitializeViewer();
        }

        private void InitializeViewer()
        {
            try
            {
                ArrayList list = new ArrayList();

                switch (ViewerMode)
                {
                    case "LoadingComic":
                        this.Size = new Size(960, 540);

                        using (StreamReader sr = new StreamReader(new FileStream(Path.Combine(ETC.DBPath, "LoadingComicList.gfspt"), FileMode.Open, FileAccess.Read)))
                        {
                            while (sr.EndOfStream == false)
                            {
                                list.Add(sr.ReadLine());
                            }
                        }
                        break;
                    case "GriffinInformationComic":
                        this.Size = new Size(530, 960);

                        using (StreamReader sr = new StreamReader(new FileStream(Path.Combine(ETC.DBPath, "GriffinInformationComicList.gfspt"), FileMode.Open, FileAccess.Read)))
                        {
                            while (sr.EndOfStream == false)
                            {
                                list.Add(sr.ReadLine());
                            }
                        }
                        break;
                    case "GriffinDailyLifeComic":
                        this.Size = new Size(350, 960);

                        using (StreamReader sr = new StreamReader(new FileStream(Path.Combine(ETC.DBPath, "GriffinDailyLifeComicList.gfspt"), FileMode.Open, FileAccess.Read)))
                        {
                            while (sr.EndOfStream == false)
                            {
                                list.Add(sr.ReadLine());
                            }
                        }
                        break;
                    default:
                        break;
                }

                list.TrimToSize();

                ComicViewerComicList.Items.AddRange(list.ToArray());
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void ComicViewerComicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cb = sender as ComboBox;

                LoadImage(cb.Text);
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async Task LoadImage(string filename)
        {
            await Task.Delay(100);

            string imageurl = "";

            try
            {
                switch (ViewerMode)
                {
                    case "LoadingComic":
                        imageurl = Path.Combine(ServerImagePath, "LoadingComic", filename + ".png");
                        break;
                    case "GriffinInformationComic":
                        imageurl = Path.Combine(ServerImagePath, "GriffinInformationComic", filename + ".png");
                        break;
                    case "GriffinDailyLifeComic":
                        imageurl = Path.Combine(ServerImagePath, "GriffinDailyLifeComic", filename + ".png");
                        break;
                }

                ComicViewerComicBox.ImageLocation = imageurl;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void ComicViewerComicBox_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                ComicImageLoadProgress.Visible = true;
                ComicImageLoadProgress.Value = e.ProgressPercentage;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void ComicViewerComicBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                ComicImageLoadProgress.Visible = false;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }
    }
}
