using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girls_FrontierLine_Supporter
{
    public partial class DollImageView : Form
    {
        enum ImageMode { Normal, Injury }

        private int DicNumber = 0;
        private int CostumeNum = 0;
        private int Mod_Index = 0;
        private ImageMode mode = ImageMode.Normal;
        private DataRow DollData = null;

        public DollImageView(string DollNum, int mod_index)
        {
            InitializeComponent();

            DicNumber = Convert.ToInt32(DollNum);
            Mod_Index = mod_index;
            InitProcess();
        }

        private async void InitProcess()
        {
            await Task.Delay(100);

            DollImageSelector.Items.Clear();

            try
            {
                DollData = ETC.FindDataRow(ETC.DollList, "DicNumber", DicNumber);

                DollImageSelector.Items.Add("기본 복장");
                DollImageSelector.SelectedIndex = 0;

                if (DollData["Costume"] != DBNull.Value)
                {
                    if ((string)DollData["Costume"] != "")
                    {
                        string[] DollCostume = ((string)DollData["Costume"]).Split(';');

                        for (int i = 0; i < DollCostume.Length; ++i)
                        {
                            DollImageSelector.Items.Add(DollCostume[i]);
                        }
                    }
                }

                DollImageModeLabel.Text = "정상";

                LoadImage();
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void LoadImage()
        {
            await Task.Delay(100);

            try
            {
                string ImageName = DicNumber.ToString();
                string censor_type = "";

                if (CostumeNum >= 1)
                {
                    ImageName += "_" + (CostumeNum + 1);
                    censor_type = "C" + CostumeNum;
                }
                else censor_type = "N";

                if ((CostumeNum == 0) && (Mod_Index == 3))
                {
                    ImageName += "_M";
                    censor_type = "MN";
                }

                if (mode == ImageMode.Injury)
                {
                    ImageName += "_D";
                    if (CostumeNum == 0) censor_type = "D";
                    else censor_type += "D";
                }
                
                if (ETC.IsShowCensorImage == true)
                {
                    if ((bool)DollData["HasCensor"] == true)
                    {
                        string[] type = ((string)DollData["CensorType"]).Split(';');

                        foreach (string s in type)
                        {
                            if (censor_type == s)
                            {
                                ImageName += "_C";
                                break;
                            }
                        }
                    }
                }

                ImageName += ".png";

                DollImageLargeBox.ImageLocation = Path.Combine(ETC.ImageServer, "Guns", "Normal", ImageName);
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void DollImageLargeBox_Click(object sender, EventArgs e)
        {
            try
            {
                switch (mode)
                {
                    case ImageMode.Normal:
                        mode = ImageMode.Injury;
                        DollImageModeLabel.Text = "중상";
                        break;
                    case ImageMode.Injury:
                        mode = ImageMode.Normal;
                        DollImageModeLabel.Text = "정상";
                        break;
                }

                /*if (CostumeNum == 0)
                {
                    string ImageName = "";

                    switch (mode)
                    {
                        case ImageMode.Normal:
                            switch (Mod_Index)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    ImageName = DicNumber + "_D.png";
                                    break;
                                case 3:
                                    ImageName = DicNumber + "_M_D.png";
                                    break;
                            }
                            DollImageLargeBox.ImageLocation = Path.Combine(ETC.ImageServer, "Guns", "Normal", ImageName);
                            mode = ImageMode.Injury;
                            DollImageModeLabel.Text = "중상";
                            break;
                        case ImageMode.Injury:
                            switch (Mod_Index)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    ImageName = DicNumber + ".png";
                                    break;
                                case 3:
                                    ImageName = DicNumber + "_M.png";
                                    break;
                            }
                            DollImageLargeBox.ImageLocation = Path.Combine(ETC.ImageServer, "Guns", "Normal", ImageName);
                            mode = ImageMode.Normal;
                            DollImageModeLabel.Text = "정상";
                            break;
                    }
                }
                else if (CostumeNum > 0)
                {
                    switch (mode)
                    {
                        case ImageMode.Normal:
                            DollImageLargeBox.ImageLocation = Path.Combine(ETC.ImageServer, "Guns", "Normal", DicNumber + "_" + (CostumeNum + 1) + "_D.png");
                            mode = ImageMode.Injury;
                            DollImageModeLabel.Text = "중상";
                            break;
                        case ImageMode.Injury:
                            DollImageLargeBox.ImageLocation = Path.Combine(ETC.ImageServer, "Guns", "Normal", DicNumber + "_" + (CostumeNum + 1) + ".png");
                            mode = ImageMode.Normal;
                            DollImageModeLabel.Text = "정상";
                            break;
                    }
                }*/

                LoadImage();
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void DollImageLargeBox_LoadProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (DollImageLargeBox.Enabled == true) DollImageLargeBox.Enabled = false;
            DollImageLoadProgress.Visible = true;
            DollImageLoadProgress.Value = e.ProgressPercentage;
        }

        private void DollImageLargeBox_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            DollImageLoadProgress.Visible = false;
            if (DollImageLargeBox.Enabled == false) DollImageLargeBox.Enabled = true;
        }

        private void DollImageSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            CostumeNum = ((ComboBox)sender).SelectedIndex;
            mode = ImageMode.Normal;
            DollImageModeLabel.Text = "정상";
            LoadImage();
        }
    }
}
