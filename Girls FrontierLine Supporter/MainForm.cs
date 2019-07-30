using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;
using System.Collections;
using System.Media;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;

using SHDocVw;

namespace Girls_FrontierLine_Supporter
{
    public partial class MainForm : Form
	{
        Stopwatch sw = new Stopwatch();

        enum DollRefreshMode { Normal, Grade, Type }
        enum DollImageLoadMode { Normal, SD }
        enum ProductMode { Doll_Normal, Doll_Advance, Equip_Normal, Equip_Advance }

        int FairyImageIndex = 1;

        PrivateFontCollection pfc = new PrivateFontCollection();

        const string ImagePath = @"Data\Image";


        internal DataRow[] SelectedEquipmentDataRow = { null, null, null };
        internal DataRow SelectedEnemyDataRow = null;
        internal DataRow SelectedDollDataRow = null;

        RegistryKey DicSetting = ETC.GFSRegistry.CreateSubKey(@"Setting\Dic");
        RegistryKey DicGeneralSetting = ETC.GFSRegistry.CreateSubKey(@"Setting\Dic\General");

        /*PictureBox[] FormationSimulDollBox = new PictureBox[9];
        PictureBox FormationSimulSelectedDollBox = null;
        PictureBox FormationSimulEnterDollBox = null;
        DollBox[,] FormationSimulDollBoxes = new DollBox[3, 3];*/

        //ArrayList FormationIconControls = new ArrayList();

        ArrayList Tiles = new ArrayList();

        bool IsDollAdvanceProduct = false;
        int DollAdvanceProductTypeNum = 1;
        bool IsEquipAdvanceProduct = false;
        int EquipAdvanceProductTypeNum = 1;

        bool IsListing = false;

        SplashScreen ss;

        public MainForm()
		{
			InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.Visible = false;
            ss = new SplashScreen(this);
            ss.Show();

            if (ETC.ClearTempFile() == false) ETC.LogError("임시 파일 제거 실패");

            if (Environment.Is64BitProcess) Text += " - 64Bit";
            else Text += " - 32Bit";

            InitProcess();
		}

		private async void InitProcess()
		{
            try
            {
                ProgramStatusLabel.Text = "Initializing...";
                ss.StatusMessage.Text = "초기화 중...";
                CheckServerChecking();
                ConfirmFonts();
                CheckExtraSetting();
                await Task.Delay(1000);

                ProgramStatusLabel.Text = "Checking DB...";
                ss.StatusMessage.Text = "DB 확인 중...";
                await Task.Delay(500);
                await CheckDB();

                ss.StatusMessage.Text = "업데이트 확인 중...";
                RegistryKey UpdateSetting = ETC.GFSRegistry.CreateSubKey(@"Setting\General\Update");

                try
                {
                    
                    if (((int)UpdateSetting.GetValue("AutoUpdate", 1) == 1) && ((int)UpdateSetting.GetValue("StartCheckUpdate", 1) == 1))
                    {
                        await CheckUpdate();
                        if (CheckUpdateTimer.Enabled == false)
                        {
                            RegistryKey IntervalSetting = ETC.GFSRegistry.CreateSubKey(@"Setting\General\Update");
                            CheckUpdateTimer.Interval = (int)IntervalSetting.GetValue("AutoUpdateInterval", 1) * 60 * 60 * 1000;
                            CheckUpdateTimer.Start();
                            IntervalSetting.Dispose();
                        }
                    }
                }
                catch (Exception)
                {
                    ss.StatusMessage.ForeColor = Color.Red;
                    ss.StatusMessage.Text = "업데이트 서버 확인 불가";
                }
                finally
                {
                    UpdateSetting.Dispose();
                }

                await Task.Delay(1000);

                ProgramStatusLabel.Text = "Loading DB...";
                ss.StatusMessage.ForeColor = Color.CornflowerBlue;
                ss.StatusMessage.Text = "DB 불러오는 중...";
                await Task.Delay(100);
                await ReadDB();

                ProgramLoadProgress.Visible = true;

                ProgramStatusLabel.Text = "List MD...";
                await Task.Delay(100);
                await ListMD();

                ProgramStatusLabel.Text = "List Doll...";
                await Task.Delay(100);
                await ListDoll("");

                ProgramStatusLabel.Text = "List Enemy...";
                await Task.Delay(100);
                await ListEnemy("");

                ProgramStatusLabel.Text = "List Equipment...";
                await Task.Delay(100);
                await ListEquipment("");

                ProgramStatusLabel.Text = "List FreeOperation...";
                await Task.Delay(100);
                await ListFreeOP();

                ProgramStatusLabel.Text = "List Fairy...";
                await Task.Delay(100);
                await ListFairy("");

                RegistryKey DicImageSetting = ETC.GFSRegistry.CreateSubKey(@"Setting\Dic\General");
                if ((int)DicImageSetting.GetValue("ImagePreLoad", 1) == 1)
                {
                    ProgramStatusLabel.Text = "Load Image for ImageList...";
                    ss.StatusMessage.Text = "구성된 이미지 리스트 생성 중...";
                    await Task.Delay(100);
                    await LoadImage();
                }
                DicImageSetting.Dispose();

                MainTab.Enabled = true;
                ProgramStatusLabel.Text = "";
                ss.StatusMessage.Text = "프로그램을 시작합니다.";
                ProgramLoadProgress.Visible = false;

                RegistryKey GeneralSetting = ETC.GFSRegistry.CreateSubKey(@"Setting\General\General");
                if ((int)GeneralSetting.GetValue("StartUpNotification", 1) == 1)
                {
                    Notification n = new Notification();
                    n.Show();
                }
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
                Close();
            }
            finally
            {
                await Task.Delay(500);
                await ss.InVisibleSplash();
                await Task.Delay(500);

                this.ShowInTaskbar = true;

                for (int i = 0; i <= 25; ++i)
                {
                    this.Opacity = i * 0.04;
                    await Task.Delay(1);
                }
            }
        }

        private void CheckServerChecking()
        {
            try
            {
                string s = "";

                using (WebClient wc = new WebClient())
                {
                    s = wc.DownloadString(Path.Combine(ETC.Server, "ServerCheck.txt"));
                }

                if (s.Split(';')[0] == "Y") MessageBox.Show(s.Split(';')[1], "서버 점검 공지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void CheckExtraSetting()
        {
            try
            {
                if (Directory.Exists(Path.Combine("System", "Extra")) == false) Directory.CreateDirectory(Path.Combine("System", "Extra"));

                if (File.Exists(Path.Combine("System", "Extra", "Censor.extra")) == false) ETC.IsShowCensorImage = true;
                else ETC.IsShowCensorImage = false;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
                return;
            }
        }

        private void ConfirmFonts()
        {
            string[] FontFiles = { "H2MKPB.TTF", "H2PORL.TTF", "H2SA1M.TTF", "NanumSquareRoundL.ttf" };
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
                        case "나눔스퀘어라운드 Light":
                            DollProductTimeLabel.Font = new Font(pfc.Families[i], 15);
                            FairyDicFairySkillExplain.Font = new Font(pfc.Families[i], 11);
                            break;
                        case "HY목각파임B":
                            DollNameLabel.Font = new Font(pfc.Families[i], 15);
                            DollNumLabel.Font = new Font(pfc.Families[i], 12);
                            DollModelLabel.Font = new Font(pfc.Families[i], 12);
                            DollModStatus.Font = new Font(pfc.Families[i], 16);
                            DollEffectTypeLabel.Font = new Font(pfc.Families[i], 11);

                            EnemyDicEnemyName.Font = new Font(pfc.Families[i], 15);

                            EquipmentDicName.Font = new Font(pfc.Families[i], 15);
                            label6.Font = new Font(pfc.Families[i], 9);
                            label8.Font = new Font(pfc.Families[i], 9);
                            label9.Font = new Font(pfc.Families[i], 9);
                            EquipmentAbility1.Font = new Font(pfc.Families[i], 14);
                            EquipmentAbility2.Font = new Font(pfc.Families[i], 14);
                            EquipmentAbility3.Font = new Font(pfc.Families[i], 14);
                            EquipmentAbility4.Font = new Font(pfc.Families[i], 14);
                            EquipmentInitialMagnification1.Font = new Font(pfc.Families[i], 14);
                            EquipmentInitialMagnification2.Font = new Font(pfc.Families[i], 14);
                            EquipmentInitialMagnification3.Font = new Font(pfc.Families[i], 14);
                            EquipmentInitialMagnification4.Font = new Font(pfc.Families[i], 14);
                            EquipmentMaxMagnification1.Font = new Font(pfc.Families[i], 14);
                            EquipmentMaxMagnification2.Font = new Font(pfc.Families[i], 14);
                            EquipmentMaxMagnification3.Font = new Font(pfc.Families[i], 14);
                            EquipmentMaxMagnification4.Font = new Font(pfc.Families[i], 14);

                            FairyDicFairyName.Font = new Font(pfc.Families[i], 15);
                            FairyDicFairySkillName.Font = new Font(pfc.Families[i], 18);
                            break;
                        case "HY엽서L":
                            DollEffectLabel.Font = new Font(pfc.Families[i], 10);

                            EnemyDicEnemyType.Font = new Font(pfc.Families[i], 15);

                            EquipmentDicNote.Font = new Font(pfc.Families[i], 11);

                            FairyDicFairySkillEffect.Font = new Font(pfc.Families[i], 16);
                            break;
                        case "HY얕은샘물M":
                            DollHPLabel.Font = new Font(pfc.Families[i], 12);
                            DollHPCountLabel.Font = new Font(pfc.Families[i], 12);
                            DollFRLabel.Font = new Font(pfc.Families[i], 12);
                            DollFRCountLabel.Font = new Font(pfc.Families[i], 12);
                            DollEVLabel.Font = new Font(pfc.Families[i], 12);
                            DollEVCountLabel.Font = new Font(pfc.Families[i], 12);
                            DollACLabel.Font = new Font(pfc.Families[i], 12);
                            DollACCountLabel.Font = new Font(pfc.Families[i], 12);
                            DollASLabel.Font = new Font(pfc.Families[i], 12);
                            DollASCountLabel.Font = new Font(pfc.Families[i], 12);
                            DollBulletLabel.Font = new Font(pfc.Families[i], 12);
                            DollBulletCountLabel.Font = new Font(pfc.Families[i], 12);
                            DollArmorLabel.Font = new Font(pfc.Families[i], 12);
                            DollArmorCountLabel.Font = new Font(pfc.Families[i], 12);

                            EnemyDicEnemyHPLabel.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyHPCount.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyFRLabel.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyFRCount.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyEVLabel.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyEVCount.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyACLabel.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyACCount.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyASLabel.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyASCount.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyPTLabel.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyPTCount.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyAMLabel.Font = new Font(pfc.Families[i], 12);
                            EnemyDicEnemyAMCount.Font = new Font(pfc.Families[i], 12);

                            FairyDicFairyFRLabel.Font = new Font(pfc.Families[i], 12);
                            FairyDicFairyFRCountLabel.Font = new Font(pfc.Families[i], 12);
                            FairyDicFairyACLabel.Font = new Font(pfc.Families[i], 12);
                            FairyDicFairyACCountLabel.Font = new Font(pfc.Families[i], 12);
                            FairyDicFairyEVLabel.Font = new Font(pfc.Families[i], 12);
                            FairyDicFairyEVCountLabel.Font = new Font(pfc.Families[i], 12);
                            FairyDicFairyAMLabel.Font = new Font(pfc.Families[i], 12);
                            FairyDicFairyAMCountLabel.Font = new Font(pfc.Families[i], 12);
                            FairyDicFairyCRLabel.Font = new Font(pfc.Families[i], 12);
                            FairyDicFairyCRCountLabel.Font = new Font(pfc.Families[i], 12);
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

        private async Task LoadImage()
        {
            await Task.Delay(100);

            try
            {
                string[] TypeIcons = Directory.GetFiles(Path.Combine(ImagePath, "TypeIcon"));
                string[] Equipments = Directory.GetFiles(Path.Combine(ImagePath, "Equipment"));
                string[] Fairies = Directory.GetFiles(Path.Combine(ImagePath, "Fairy"));
                string[] FairySkills = Directory.GetFiles(Path.Combine(ImagePath, "FairySkill"));
                string[] Enemies = Directory.GetFiles(Path.Combine(ImagePath, "Enemy"));
                string[] GradeImages = Directory.GetFiles(Path.Combine(ImagePath, "GradeImage"));

                ProgramLoadProgress.Value = 0;
                ProgramLoadProgress.Maximum = TypeIcons.Length + Equipments.Length + Fairies.Length + FairySkills.Length + Enemies.Length + GradeImages.Length;
                
                foreach (string s in TypeIcons)
                {
                    TypeIconImageList.Images.Add(Path.GetFileName(s), Image.FromFile(s));
                    ProgramLoadProgress.PerformStep();
                }
                foreach (string s in Equipments)
                {
                    EquipmentImageList.Images.Add(Path.GetFileName(s), Image.FromFile(s));
                    ProgramLoadProgress.PerformStep();
                }
                foreach (string s in Fairies)
                {
                    FairyImageList.Images.Add(Path.GetFileName(s), Image.FromFile(s));
                    ProgramLoadProgress.PerformStep();
                }
                foreach (string s in FairySkills)
                {
                    FairySkillIconImageList.Images.Add(Path.GetFileName(s), Image.FromFile(s));
                    ProgramLoadProgress.PerformStep();
                }
                foreach (string s in Enemies)
                {
                    EnemyImageList.Images.Add(Path.GetFileName(s), Image.FromFile(s));
                    ProgramLoadProgress.PerformStep();
                }
                foreach (string s in GradeImages)
                {
                    GradeImageList.Images.Add(Path.GetFileName(s), Image.FromFile(s));
                    ProgramLoadProgress.PerformStep();
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async Task CheckDB()
        {
            string[] DBFiles = { "Doll.gfs", "MDSupportList.gfs", "FreeOP.gfs", "SkillTraining.gfs", "Equipment.gfs", "Fairy.gfs", "Enemy.gfs", "FairyAttribution.gfs", "LoadingComicList.gfspt", "GriffinInformationComicList.gfspt", "GriffinDailyLifeComicList.gfspt" };

            try
            { 
                foreach (string file in DBFiles)
                {
                    if (File.Exists(Path.Combine(@"Data\DB", file)) == false)
                    {
                        if (MessageBox.Show("일부 DB파일이 발견되지 않았습니다. DB를 재설정 하시겠습니까?\n(재설정을 권장합니다.)", "DB파일 없음", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            await Task.Delay(1000);

                            ProgramStatusLabel.Text = "Reset DB....";
                            Process.Start("GFS Updater.exe", "DB").WaitForExit();
                        }
                        else
                        {
                            MessageBox.Show("DB파일을 읽지 못하므로 프로그램을 종료합니다.", "프로그램 종료 안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }
		
		private async Task ReadDB()
		{
			await Task.Delay(100);
            try
            {
                /*DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                DataTable dt5 = new DataTable();
                DataTable dt6 = new DataTable();
                DataTable dt7 = new DataTable();
                DataTable dt8 = new DataTable();

                dt.ReadXml(Path.Combine(ETC.DBPath, "MDSupportList.gfs"));
                ETC.MDSupportDT = dt;
                dt2.ReadXml(Path.Combine(ETC.DBPath, "Doll.gfs"));
                ETC.DollList = dt2;
                dt3.ReadXml(Path.Combine(ETC.DBPath, "FreeOP.gfs"));
                ETC.FreeOPList = dt3;
                dt4.ReadXml(Path.Combine(ETC.DBPath, "SkillTraining.gfs"));
                ETC.SkillTrainingList = dt4;
                dt5.ReadXml(Path.Combine(ETC.DBPath, "Equipment.gfs"));
                ETC.EquipmentList = dt5;
                dt6.ReadXml(Path.Combine(ETC.DBPath, "Fairy.gfs"));
                ETC.FairyList = dt6;
                dt7.ReadXml(Path.Combine(ETC.DBPath, "Enemy.gfs"));
                ETC.EnemyList = dt7;
                dt8.ReadXml(Path.Combine(ETC.DBPath, "FairyAttribution.gfs"));
                ETC.FairyAttribution = dt8;*/

                ETC.MDSupportDT.ReadXml(Path.Combine(ETC.DBPath, "MDSupportList.gfs"));
                ETC.DollList.ReadXml(Path.Combine(ETC.DBPath, "Doll.gfs"));
                ETC.FreeOPList.ReadXml(Path.Combine(ETC.DBPath, "FreeOP.gfs"));
                ETC.SkillTrainingList.ReadXml(Path.Combine(ETC.DBPath, "SkillTraining.gfs"));
                ETC.EquipmentList.ReadXml(Path.Combine(ETC.DBPath, "Equipment.gfs"));
                ETC.FairyList.ReadXml(Path.Combine(ETC.DBPath, "Fairy.gfs"));
                ETC.EnemyList.ReadXml(Path.Combine(ETC.DBPath, "Enemy.gfs"));
                ETC.FairyAttribution.ReadXml(Path.Combine(ETC.DBPath, "FairyAttribution.gfs"));

                /*dt.Dispose();
                dt2.Dispose();
                dt3.Dispose();
                dt4.Dispose();
                dt5.Dispose();
                dt6.Dispose();
                dt7.Dispose();
                dt8.Dispose();*/

                for (int i = 0; i < ETC.MDSupportDT.Rows.Count; ++i)
                {
                    DataRow dr = ETC.MDSupportDT.Rows[i];
                    ETC.MDLocation.Add(dr["Location"]);
                }

                ETC.MDLocation.TrimToSize();
                ETC.MDLocation.Sort();
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
		}

        private async Task ListMD()
        {
            await Task.Delay(100);

            try
            {
                ProgramLoadProgress.Value = 0;
                ProgramLoadProgress.Maximum = ETC.MDSupportDT.Rows.Count;
                
            	for (int i = 0; i < ETC.MDLocation.Count; ++i)
            	{
                    DataRow dr = ETC.MDSupportDT.Rows[i];
                    string Extra = "";

                    if (dr["Ticket"] != DBNull.Value) Extra = (string)dr["Ticket"];

                    string ManPowerByTime = ((int)dr["ManPower"] / Convert.ToDouble((int)dr["Time"]) * 60).ToString("F1");
                    string AmmoByTime = ((int)dr["Ammo"] / Convert.ToDouble((int)dr["Time"]) * 60).ToString("F1");
                    string FoodByTime = ((int)dr["Food"] / Convert.ToDouble((int)dr["Time"]) * 60).ToString("F1");
                    string PartsByTime = ((int)dr["Parts"] / Convert.ToDouble((int)dr["Time"]) * 60).ToString("F1");

                    MDListView.Items.Add(new ListViewItem(new string[] { (string)dr["Location"], dr["Min Level"].ToString(), ETC.CalcTime((int)dr["Time"]), dr["ManPower"].ToString(), dr["Ammo"].ToString(), dr["Food"].ToString(), dr["Parts"].ToString(), ManPowerByTime, AmmoByTime, FoodByTime, PartsByTime, Extra}));

                    ProgramLoadProgress.PerformStep();
                }

                Sorter sorter = new Sorter
                {
                    Order = SortOrder.Descending,
                    ColumnIndex = 0
                };
                MDListView.ListViewItemSorter = sorter;
                MDListView.Sort();

                await Task.Delay(100);

                Location1.Items.Add("없음");
                Location2.Items.Add("없음");
                Location3.Items.Add("없음");
                Location4.Items.Add("없음");

                Location1.Items.AddRange(ETC.MDLocation.ToArray());
                Location2.Items.AddRange(ETC.MDLocation.ToArray());
                Location3.Items.AddRange(ETC.MDLocation.ToArray());
                Location4.Items.AddRange(ETC.MDLocation.ToArray());

                Location1.SelectedIndex = 0;
                Location2.SelectedIndex = 0;
                Location3.SelectedIndex = 0;
                Location4.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }
        
        private async Task ListDoll(string name)
        {
        	await Task.Delay(100);
        	
        	try
        	{
                ProgramLoadProgress.Value = 0;
                ProgramLoadProgress.Maximum = ETC.DollList.Rows.Count;

                DollListView.Items.Clear();

                ArrayList al = new ArrayList(5);

                for (int i = 0; i < ETC.DollList.Rows.Count; ++i)
                {
                    DataRow dr = ETC.DollList.Rows[i];

                    if (CheckDollSettingType((string)dr["Type"]) && CheckDollSettingGrade((int)dr["Grade"]) && CheckDollSettingVoice((bool)dr["HasVoice"]) && CheckDollSettingMod((bool)dr["HasMod"]))
                    {
                        name = name.ToUpper();
                        string DollName = ((string)dr["Name"]).ToUpper();

                        if ((DollName.Contains(name)) || (name == ""))
                        {
                            string g = "";
                            string c = "X";
                            string m = "X";

                            switch ((int)dr["Grade"])
                            {
                                case 2:
                                    g = "☆☆";
                                    break;
                                case 3:
                                    g = "☆☆☆";
                                    break;
                                case 4:
                                    g = "☆☆☆☆";
                                    break;
                                case 5:
                                    g = "☆☆☆☆☆";
                                    break;
                                case 0:
                                    g = "★";
                                    break;
                            }
                            
                            if ((dr["Costume"] != DBNull.Value) && ((string)dr["Costume"] != "")) c = "O";
                            if ((bool)dr["HasMod"] == true) m = "O";

                            DollListView.Items.Add(new ListViewItem(new string[] { (string)dr["Name"], (string)dr["Type"], g, ETC.CalcTime((int)dr["ProductTime"]), c, m }));
                            al.Add((string)dr["Name"]);
                        }
                    }
                    ProgramLoadProgress.PerformStep();
                }

                al.TrimToSize();
                al.Sort();
                /*FormationSimulDollSelector.Items.AddRange(al.ToArray());

                for (int i = 0; i < 9; ++i)
                {
                    string key = "FormationSimulDollSDImage" + (i + 1);
                    FormationSimulDollBox[i] = (PictureBox)(Controls.Find(key, true)[0]);
                }

                //FormationSimulDollBox = { FormationSimulDollSDImage1, FormationSimulDollSDImage2, FormationSimulDollSDImage3, FormationSimulDollSDImage4, FormationSimulDollSDImage5, FormationSimulDollSDImage6, FormationSimulDollSDImage7, FormationSimulDollSDImage8, FormationSimulDollSDImage9 };

                foreach (PictureBox pb in FormationSimulDollBox)
                {
                    int i = Convert.ToInt32(pb.Tag) - 1;
                    DollBox db = FormationSimulDollBoxes[(i / 3), (i % 3)];
                    db.PB = pb;
                    db.Row = i / 3;
                    db.Column = i % 3;
                    db.d_Name = "";
                    db.d_Num = 0;
                    db.EffectList = new ArrayList();
                    db.EquipmentList = new string[3];
                    for (int k = 0; k < 3; ++k) db.EquipmentList[k] = ""; 
                    FormationSimulDollBoxes[(i / 3), (i % 3)] = db;
                }*/
        	}
        	catch(Exception ex)
        	{
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
        	}
        }

        private async Task ListFreeOP()
        {
            await Task.Delay(100);

            try
            {
                ProgramLoadProgress.Value = 0;
                ProgramLoadProgress.Maximum = ETC.FreeOPList.Rows.Count;

                FreeOPListView.Items.Clear();

                for (int i = 0; i < ETC.FreeOPList.Rows.Count; ++i)
                {
                    DataRow dr = ETC.FreeOPList.Rows[i];

                    if (!((Convert.ToInt32(FreeOPMinLevelUpDown.Value) <= (int)dr["PaneltyLevel"]) && (Convert.ToInt32(FreeOPMaxLevelUpDown.Value) >= (int)dr["PaneltyLevel"]))) continue;
                    if (!((Convert.ToInt32(FreeOPMinTimeUpDown.Value) <= (int)dr["OPTime"]) && (Convert.ToInt32(FreeOPMaxTimeUpDown.Value) >= (int)dr["OPTime"]))) continue;
                    if (!((Convert.ToInt32(FreeOPMinMUUpDown.Value) <= (int)dr["RequireMU"]) && (Convert.ToInt32(FreeOPMaxMUUpDown.Value) >= (int)dr["RequireMU"]))) continue;

                    char type = ((string)dr["Location"])[((string)dr["Location"]).Length - 1];

                    switch (type)
                    {
                        case 'N':
                            if (FreeOPLocationNight.Checked != true) continue;
                            break;
                        case 'E':
                            if (FreeOPLocationEmergency.Checked != true) continue;
                            break;
                        default:
                            if (FreeOPLocationNormal.Checked != true) continue;
                            break;
                    }

                    if ((dr["SpecialDrop"] == DBNull.Value) || ((string)dr["SpecialDrop"] == ""))
                    {
                        if (FreeOPSpecialDropNoExist.Checked == false) continue;
                    }
                    if ((dr["SpecialDrop"] != DBNull.Value) && ((string)dr["SpecialDrop"] != ""))
                    {
                        if (FreeOPSpecialDropExist.Checked == false) continue;
                    }


                    int b_exp = (int)dr["BaseEXP"];
                    int doll_exp = (b_exp * 10) / (int)dr["RequireMU"];
                    double doll_exp_bytime = doll_exp / ((int)dr["OPTime"] / 60.0);


                    string sp_drop = "";

                    if (dr["SpecialDrop"] == DBNull.Value) sp_drop = "";
                    else sp_drop = (string)dr["SpecialDrop"];

                    FreeOPListView.Items.Add(new ListViewItem(new string[] { (string)dr["Location"], ((int)dr["PaneltyLevel"]).ToString(), ((int)dr["RequireMU"]).ToString(), ETC.CalcTime((int)dr["OPTime"]), ((int)dr["RequireFP"]).ToString(), (int)dr["RequireMAF"] + " / " + (int)dr["RequireParts"], b_exp.ToString(), doll_exp.ToString(), doll_exp_bytime.ToString("F2"),((int)dr["DropCount"]).ToString(), sp_drop }));

                    ProgramLoadProgress.PerformStep();
                }
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async Task ListEquipment(string name)
        {
            await Task.Delay(100);

            try
            {
                ProgramLoadProgress.Value = 0;
                ProgramLoadProgress.Maximum = ETC.EquipmentList.Rows.Count;

                EquipmentDicListView.Items.Clear();

                for (int i = 0; i < ETC.EquipmentList.Rows.Count; ++i)
                {
                    DataRow dr = ETC.EquipmentList.Rows[i];

                    if (CheckEquipmentSettingCategory((string)dr["Category"]) && CheckEquipmentSettingGrade((int)dr["Grade"]))
                    {
                        name = name.ToUpper();
                        string EquipName = ((string)dr["Name"]).ToUpper();
                        if ((EquipName.Contains(name)) || (name == ""))
                        {
                            string g = "";

                            switch ((int)dr["Grade"])
                            {
                                case 2:
                                    g = "☆☆";
                                    break;
                                case 3:
                                    g = "☆☆☆";
                                    break;
                                case 4:
                                    g = "☆☆☆☆";
                                    break;
                                case 5:
                                    g = "☆☆☆☆☆";
                                    break;
                                case 0:
                                    g = "★";
                                    break;
                            }

                            EquipmentDicListView.Items.Add(new ListViewItem(new string[] { (string)dr["Name"], (string)dr["Type"], (string)dr["Category"], g, ETC.CalcTime((int)dr["ProductTime"]) }));
                        }
                    }
                    ProgramLoadProgress.PerformStep();
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async Task ListFairy(string name)
        {
            await Task.Delay(100);

            try
            {
                ProgramLoadProgress.Value = 0;
                ProgramLoadProgress.Maximum = ETC.FairyList.Rows.Count;

                FairyDicFairyList.Items.Clear();

                for (int i = 0; i < ETC.FairyList.Rows.Count; ++i)
                {
                    DataRow dr = ETC.FairyList.Rows[i];

                    if (CheckFairySettingType((string)dr["Type"]))
                    {
                        if ((((string)dr["Name"]).Contains(name) == true) || (name == ""))
                        {
                            FairyDicFairyList.Items.Add(new ListViewItem(new string[] { (string)dr["Name"], (string)dr["Type"], ETC.CalcTime((int)dr["ProductTime"]) }));
                        }
                    }
                    ProgramLoadProgress.PerformStep();
                }
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async Task ListEnemy(string name)
        {
            await Task.Delay(100);

            try
            {
                ProgramLoadProgress.Value = 0;
                ProgramLoadProgress.Maximum = ETC.EnemyList.Rows.Count;

                EnemyDicEnemyListView.Items.Clear();

                for (int i = 0; i < ETC.EnemyList.Rows.Count; ++i)
                {
                    DataRow dr = ETC.EnemyList.Rows[i];

                    name = name.ToUpper();
                    string EnemyName = ((string)dr["Name"]).ToUpper();

                    if ((EnemyName.Contains(name)) || (name == ""))
                    {
                        string note = "";

                        if (dr["Note"] == DBNull.Value) note = "";
                        else note = (string)dr["Note"];

                        EnemyDicEnemyListView.Items.Add(new ListViewItem(new string[] { (string)dr["Name"], (string)dr["Type"], note }));
                    }
                    ProgramLoadProgress.PerformStep();
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private bool CheckDollSettingType(string type)
        {
            CheckBox[] TypeSettingList = { TypeHG, TypeSMG, TypeAR, TypeMG, TypeRF, TypeSG };

            try
            {
                foreach (CheckBox cb in TypeSettingList)
                {
                    if ((cb.Checked == true) && (type == cb.Text)) return true;
                }

                /*if ((TypeHG.Checked == true) && (type == TypeHG.Text)) return true;
                if ((TypeSMG.Checked == true) && ((string)dr["Type"] == "SMG")) return true;
                if ((TypeAR.Checked == true) && ((string)dr["Type"] == "AR")) return true;
                if ((TypeMG.Checked == true) && ((string)dr["Type"] == "MG")) return true;
                if ((TypeRF.Checked == true) && ((string)dr["Type"] == "RF")) return true;
                if ((TypeSG.Checked == true) && ((string)dr["Type"] == "SG")) return true;*/
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return false;
        }

        private bool CheckDollSettingGrade(int grade)
        {
            CheckBox[] GradeSettingList = { Grade2, Grade3, Grade4, Grade5, GradeExtra };

            try
            {
                foreach (CheckBox cb in GradeSettingList)
                {
                    if ((cb.Checked == true) && (grade == Convert.ToInt32(cb.Tag))) return true;
                }

                /*if ((Grade2.Checked == true) && ((int)dr["Grade"] == 2)) return true;
                if ((Grade3.Checked == true) && ((int)dr["Grade"] == 3)) return true;
                if ((Grade4.Checked == true) && ((int)dr["Grade"] == 4)) return true;
                if ((Grade5.Checked == true) && ((int)dr["Grade"] == 5)) return true;
                if ((GradeExtra.Checked == true) && ((int)dr["Grade"] == 0)) return true;*/
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return false;
        }

        private bool CheckDollSettingVoice(bool HasVoice)
        {
            try
            {
                if ((VoiceYes.Checked == true) && (HasVoice == true)) return true;
                if ((VoiceNo.Checked == true) && (HasVoice == false)) return true;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return false;
        }

        private bool CheckDollSettingMod(bool HasMod)
        {
            try
            {
                if ((ModYes.Checked == true) && (HasMod == true)) return true;
                if ((ModNo.Checked == true) && (HasMod == false)) return true;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return false;
        }

        private bool CheckEquipmentSettingCategory(string category)
        {
            CheckBox[] EquipCategorySettingList = { EquipmentDicCategoryAttachment, EquipmentDicCategoryBullet, EquipmentDicCategoryDoll };

            try
            {
                foreach (CheckBox cb in EquipCategorySettingList)
                {
                    if ((cb.Checked == true) && (category == cb.Text)) return true;
                }

                /*if ((EquipmentDicCategoryAttachment.Checked == true) && ((string)dr["Category"] == "부속")) return true;
                if ((EquipmentDicCategoryBullet.Checked == true) && ((string)dr["Category"] == "탄환")) return true;
                if ((EquipmentDicCategoryDoll.Checked == true) && ((string)dr["Category"] == "인형")) return true;*/
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return false;
        }

        private bool CheckEquipmentSettingGrade(int grade)
        {
            CheckBox[] EquipGradeSettingList = { EquipmentDicGrade2, EquipmentDicGrade3, EquipmentDicGrade4, EquipmentDicGrade5, EquipmentDicGradeExtra };

            try
            {
                foreach (CheckBox cb in EquipGradeSettingList)
                {
                    if ((cb.Checked == true) && (grade == Convert.ToInt32(cb.Tag))) return true;
                }

                /*if ((EquipmentDicGrade2.Checked == true) && ((int)dr["Grade"] == 2)) return true;
                if ((EquipmentDicGrade3.Checked == true) && ((int)dr["Grade"] == 3)) return true;
                if ((EquipmentDicGrade4.Checked == true) && ((int)dr["Grade"] == 4)) return true;
                if ((EquipmentDicGrade5.Checked == true) && ((int)dr["Grade"] == 5)) return true;
                if ((EquipmentDicGradeExtra.Checked == true) && ((int)dr["Grade"] == 0)) return true;*/
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return false;
        }

        private bool CheckFairySettingType(string type)
        {
            CheckBox[] FairyTypeSettingList = { FairyDicTypeCombat, FairyDicTypeStrategy };

            try
            {
                foreach (CheckBox cb in FairyTypeSettingList)
                {
                    if ((cb.Checked == true) && (type == cb.Text)) return true;
                }

                /*if ((FairyDicTypeStrategy.Checked == true) && ((string)dr["Type"] == FairyDicTypeStrategy.Text)) return true;
                if ((FairyDicTypeCombat.Checked == true) && ((string)dr["Type"] == FairyDicTypeCombat.Text)) return true;*/
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return false;
        }

        private void ExpCalc_ValueChanged(object sender, EventArgs e)
        {
            Control c = sender as Control;

            switch ((string)c.Tag)
            {
                case "StartLevel":
                    NumericUpDown nud = c as NumericUpDown;
                    NowExpCount.Value = ETC.LevelExp[Convert.ToInt32(nud.Value) - 1];
                    ExpEndLevel.Minimum = nud.Value;
                    break;
                case "EndLevel":
                    NumericUpDown nud2 = c as NumericUpDown;
                    ExpStartLevel.Maximum = nud2.Value;
                    break;
            }

            CalcExp(ExpItemCalcApplyVow.Checked);
        } 

        private void CalcExp(bool IsVow)
        {
            const int ExpItem = 3000;

            try
            {
                int StartLevel = Convert.ToInt32(ExpStartLevel.Value);
                int EndLevel = Convert.ToInt32(ExpEndLevel.Value);
                int NowExp = Convert.ToInt32(NowExpCount.Value);

                int RequireExp = ETC.LevelExp[EndLevel - 1] - NowExp;
                int RequireExpItem = 0;
                int SurplusExp = 0;

                switch (IsVow)
                {
                    case false:
                        RequireExpItem = Convert.ToInt32(Math.Ceiling(RequireExp / Convert.ToDouble(ExpItem)));
                        SurplusExp = (ExpItem * RequireExpItem) - RequireExp;
                        break;
                    case true:
                        RequireExpItem = Convert.ToInt32(Math.Ceiling(RequireExp / Convert.ToDouble(ExpItem * 2)));
                        SurplusExp = (ExpItem * RequireExpItem * 2) - RequireExp;
                        break;
                }

                RequireExpItemCount.Text = RequireExpItem.ToString();
                SurplusExpCount.Text = SurplusExp.ToString();
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void CalcLinkCore()
        {
            try
            {
                int StartLink = Convert.ToInt32(StartLinkCount.Value);
                int EndLink = Convert.ToInt32(EndLinkCount.Value);

                int RequireDollCount = 0;

                for (int i = 0; i < (EndLink - StartLink); ++i)
                {
                    RequireDollCount += ETC.LevelLink_DollCount[StartLink + i];
                }

                RequireCoreCount.Text = (RequireDollCount * ETC.GradeLinkCore[LinkCalcGradeSelector.SelectedIndex]).ToString();
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void LinkCalc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == (object)StartLinkCount)
            {
                if (StartLinkCount.Value > EndLinkCount.Value) return;
            }

            CalcLinkCore();
        }

        private void CalcFR()
        {
            try
            {
                int DefaultFR = Convert.ToInt32(FRCalcDefaultFRCount.Value);
                int ItemFR = Convert.ToInt32(FRCalcItemFRCount.Value);
                double FormationEffectRate = Convert.ToDouble(FRCalcFormationEffectFRCountLabel.Text) / 100.0;
                double SkillEffectRate = Convert.ToDouble(FRCalcSkillEffectFRCountLabel.Text) / 100.0;


                FRCalcTotalFRCountLabel.Text = ((DefaultFR + ItemFR) * FormationEffectRate * SkillEffectRate).ToString();
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void FRCalcFormationEffectFRCount_ValueChanged(object sender, EventArgs e)
        {
            FRCalcFormationEffectFRCountLabel.Text = (100 + (Convert.ToInt32(FRCalcFormationEffectFRCount1.Value + FRCalcFormationEffectFRCount2.Value + FRCalcFormationEffectFRCount3.Value + FRCalcFormationEffectFRCount4.Value))).ToString();
        }

        private void FRCalcSkillEffectFRCount_ValueChanged(object sender, EventArgs e)
        {
            FRCalcSkillEffectFRCountLabel.Text = (100 + (Convert.ToInt32(FRCalcSkillEffectFRCount1.Value + FRCalcSkillEffectFRCount2.Value + FRCalcSkillEffectFRCount3.Value + FRCalcSkillEffectFRCount4.Value))).ToString();
        }

        private void FRCalcCount_ValueChanged(object sender, EventArgs e)
        {
            CalcFR();
        }

        private async void CheckUpdateTimer_Tick(object sender, EventArgs e)
        {
            RegistryKey IntervalSetting = ETC.GFSRegistry.CreateSubKey(@"Setting\General\Update");

            CheckUpdateTimer.Stop();

            CheckUpdateTimer.Interval = (int)IntervalSetting.GetValue("AutoUpdateInterval", 1) * 60 * 60 * 1000;

            ProgramStatusLabel.Text = "";

            await CheckUpdate();

            CheckUpdateTimer.Start();
        }

        private async Task CheckUpdate()
        {
            try
            {
                await Task.Delay(100);

                ProgramStatusLabel.Text = "Checking Client Update...";

                await ETC.CheckVersion(ETC.CheckMode.Client);

                if (ETC.HasClientUpdate)
                {
                    ETC.HasClientUpdate = false;

                    if (MessageBox.Show("클라이언트 업데이트가 있습니다. 업데이터를 실행할까요?", "클라이언트 업데이트 발견", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string Id = Process.GetCurrentProcess().Id.ToString();
                        await Task.Delay(1000);
                        Process.Start("GFS Updater.exe", "Client").WaitForExit();

                        ProgramStatusLabel.Text = "Executing Updater... (Mode : Client)";

                        await Task.Delay(1000);

                        ProgramStatusLabel.Text = "";

                        return;
                    }
                }

                await Task.Delay(500);

                ProgramStatusLabel.Text = "Checking DB Update...";

                await ETC.CheckVersion(ETC.CheckMode.DB);

                if (ETC.HasDBUpdate)
                {
                    ETC.HasDBUpdate = false;

                    if (MessageBox.Show("DB 업데이트가 있습니다. 업데이터를 실행할까요?", "DB 업데이트 발견", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string Id = Process.GetCurrentProcess().Id.ToString();
                        await Task.Delay(1000);
                        Process.Start("GFS Updater.exe", "DB").WaitForExit();

                        ProgramStatusLabel.Text = "Executing Updater... (Mode : DB)";

                        await Task.Delay(1000);

                        ProgramStatusLabel.Text = "";

                        return;
                    }
                }

                ProgramStatusLabel.Text = "";
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return;
        }
        
		private void MDCalcPrintButton_Click(object sender, EventArgs e)
		{
			ComboBox[] Locations = { Location1, Location2, Location3, Location4 };
			double tManPower = 0;
			double tAmmo = 0;
			double tFood = 0;
			double tParts = 0;
			
			string CalcMode = "";
			
			if (MDCalcSettingSum.Checked == true) CalcMode = (string)MDCalcSettingSum.Tag;
			if (MDCalcSettingByTime.Checked == true) CalcMode = (string)MDCalcSettingByTime.Tag;
			
			foreach (ComboBox cb in Locations)
			{
                if (cb.SelectedIndex == 0) continue;

				string location = (string)cb.Items[cb.SelectedIndex];
                DataRow md = ETC.FindDataRow(ETC.MDSupportDT, "Location", location);

                /*for (int i = 0; i < ETC.MDSupportDT.Rows.Count; ++i)
                {
                    md = ETC.MDSupportDT.Rows[i];
                    if ((string)md["Location"] == location) break;
                }*/

                switch (CalcMode)
                {
                    case "Sum":
                        tManPower += (int)md["ManPower"];
                        tAmmo += (int)md["Ammo"];
                        tFood += (int)md["Food"];
                        tParts += (int)md["Parts"];
                        break;
                    case "ByTime":
                        double tTime = (int)md["Time"] / 60.0;
                        tManPower += (int)md["ManPower"] / tTime;
                        tAmmo += (int)md["Ammo"] / tTime;
                        tFood += (int)md["Food"] / tTime;
                        tParts += (int)md["Parts"] / tTime;
                        break;
                }
			}

            ManPowerResult.Text = tManPower.ToString("F1");
            AmmoResult.Text = tAmmo.ToString("F1");
            FoodResult.Text = tFood.ToString("F1");
            PartsResult.Text = tParts.ToString("F1");
		}

        private void DollImageBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (DollImageBox.Image != DollImageBox.InitialImage)
                {
                    DollImageView div = new DollImageView((DollNumLabel.Text.Split(' '))[1], (int)DollModStatus.Tag);
                    div.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
            
        }

        private void DollListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((ListView)sender).SelectedItems.Count > 0)
                {
                    string dollName = ((ListView)sender).SelectedItems[0].SubItems[0].Text;
                    PrintDollInfo(dollName, 0);
                }
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void PrintDollInfo(string name, int index)
        {
            await Task.Delay(100);

            try
            {
                DataRow dr = ETC.FindDataRow(ETC.DollList, "Name", name);
                if (dr != null)
                {
                    string DollTypeImageName = (string)dr["Type"] + "_Icon" + ".png";
                    string DollGradeImageName = "";

                    switch (index)
                    {
                        case 0:
                            DollGradeImageName = "Grade_" + (int)dr["Grade"] + ".png";
                            break;
                        case 1:
                        case 2:
                        case 3:
                            DollGradeImageName = "Grade_" + (int)dr["ModGrade"] + ".png";
                            break;
                    }

                    DollNameLabel.Text = (string)dr["Name"];
                    DollModelCountryIcon.Image = ModelCountryIcons.Images[(string)dr["Country"] + ".png"];
                    CountryToolTip.SetToolTip(DollModelCountryIcon, (string)dr["Country"]);
                    if (dr["Model"] != DBNull.Value) DollModelLabel.Text = (string)dr["Model"];
                    else DollModelLabel.Text = "";

                    Control[] DollModControls = { DollModSelectorNext, DollModSelectorPrevious };

                    if ((bool)dr["HasMod"] == true)
                    {
                        foreach (Control c in DollModControls)
                        {
                            c.Enabled = true;
                            c.Visible = true;
                        }
                    }
                    else
                    {
                        foreach (Control c in DollModControls)
                        {
                            c.Enabled = false;
                            c.Visible = false;
                        }
                    }
                    DollModStatus.Tag = index;
                    if (index == 0) DollModStatus.Text = "Normal";

                    string DollImageName = "";
                    string DollSDImageName = "";

                    switch (index)
                    {
                        case 0:
                        case 1:
                        case 2:
                            DollImageName = ((int)dr["DicNumber"]).ToString();
                            DollSDImageName = ((int)dr["DicNumber"]).ToString();
                            break;
                        case 3:
                            DollImageName = (int)dr["DicNumber"] + "_M";
                            DollSDImageName = (int)dr["DicNumber"] + "_M";
                            break;
                    }

                    if (ETC.IsShowCensorImage == true)
                    {
                        if ((bool)dr["HasCensor"] == true)
                        {
                            if (((string)dr["CensorType"]).Split(';')[0] == "N") DollImageName += "_C";
                        }
                    }

                    DollImageName += ".png";
                    DollSDImageName += ".png";

                    DollImageBox.ImageLocation = Path.Combine(ETC.ImageServer, "Guns", "Normal", DollImageName);
                    DollImageSDBox.ImageLocation = Path.Combine(ETC.ImageServer, "Guns", "SD", DollSDImageName);
                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1)
                    {
                        DollTypeImageBox.Image = TypeIconImageList.Images[DollTypeImageName];
                        DollImageBox.BackgroundImage = GradeImageList.Images[DollGradeImageName];
                    }
                    else
                    {
                        DollTypeImageBox.ImageLocation = Path.Combine(ImagePath, "TypeIcon", DollTypeImageName);
                        DollImageBox.BackgroundImage = Image.FromFile(Path.Combine(ImagePath, "GradeImage", DollGradeImageName));
                    }
                    DollNumLabel.Text = "No. " + (int)dr["DicNumber"];

                    string[] BaseAbilityList = { "HP", "FireRate", "Evasion", "Accuracy", "AttackSpeed" };
                    Label[] BaseAbilityLabels = { DollHPCountLabel, DollFRCountLabel, DollEVCountLabel, DollACCountLabel, DollASCountLabel };
                    ProgressBar[] BaseAbilityPBs = { DollHPProgress, DollFRProgress, DollEVProgress, DollACProgress, DollASProgress };

                    for (int i = 0; i < BaseAbilityList.Length; ++i)
                    {
                        string ability = BaseAbilityList[i];

                        StringBuilder t_sb = new StringBuilder();
                        t_sb.Append(((string)dr[ability]).Split(';')[0].Split('/')[0]);
                        t_sb.Append("/");

                        string t_max = "";

                        switch (index)
                        {
                            case 0:
                                t_max = ((string)dr[ability]).Split(';')[0].Split('/')[1];
                                break;
                            case 1:
                            case 2:
                            case 3:
                                t_max = ((string)dr[ability]).Split(';')[index];
                                break;
                        }
                        BaseAbilityPBs[i].Value = Int32.Parse(t_max);
                        t_sb.Append(t_max);

                        string rank = " (" + ETC.CalcAbilityRank(dr, ability, index) + ")";
                        t_sb.Append(rank);

                        BaseAbilityLabels[i].Text = t_sb.ToString();

                        if (ability == "FireRate")
                        {
                            double[] Damage = CalcBaseDamage(Int32.Parse(t_max), 0, 0, new int[] { 0 });
                            DollBaseDamage.Text = "기본 대미지 : " + Math.Ceiling(Damage[0]) + "~" + Math.Ceiling(Damage[1]);
                        }
                    }
                    /*DollHPCountLabel.Text = (string)dr["HP"] + " (" + ETC.CalcAbilityRank(dr, "HP", index) + ")";
                    DollFRCountLabel.Text = (string)dr["FireRate"] + " (" + ETC.CalcAbilityRank(dr, "FireRate", index) + ")";
                    DollEVCountLabel.Text = (string)dr["Evasion"] + " (" + ETC.CalcAbilityRank(dr, "Evasion", index) + ")";
                    DollACCountLabel.Text = (string)dr["Accuracy"] + " (" + ETC.CalcAbilityRank(dr, "Accuracy", index) + ")";
                    DollASCountLabel.Text = (string)dr["AttackSpeed"] + " (" + ETC.CalcAbilityRank(dr, "AttackSpeed", index) + ")";*/

                    if ((int)dr["ProductTime"] == 0) DollProductTimeLabel.Text = "제조불가";
                    else
                    {
                        DollProductTimeLabel.Text = "제조시간 : " + ETC.CalcTime((int)dr["ProductTime"]);

                        if ((((string)dr["DropEvent"]).Split(','))[0] == "중형제조") DollProductTimeLabel.Text += " (중형)";
                    }

                    /*DollHPProgress.Value = Convert.ToInt32((((string)dr["HP"]).Split('/'))[1]);
                    DollFRProgress.Value = Convert.ToInt32((((string)dr["FireRate"]).Split('/'))[1]);
                    DollEVProgress.Value = Convert.ToInt32((((string)dr["Evasion"]).Split('/'))[1]);
                    DollACProgress.Value = Convert.ToInt32((((string)dr["Accuracy"]).Split('/'))[1]);
                    DollASProgress.Value = Convert.ToInt32((((string)dr["AttackSpeed"]).Split('/'))[1]);*/

                    Control[] BulletControl = { DollBulletLabel, DollBulletProgress, DollBulletCountLabel };
                    Control[] ArmorControl = { DollArmorLabel, DollArmorProgress, DollArmorCountLabel };

                    switch ((string)dr["Type"])
                    {
                        case "MG":
                            foreach (Control c in BulletControl) c.Visible = true;
                            foreach (Control c in ArmorControl) c.Visible = false;
                            DollReloadTimeLabel.Text = "MG 최소 재장전 시간 : " + CalcReloadTime(dr, (string)dr["Type"]);
                            DollBulletCountLabel.Text = ((int)dr["Bullet"]).ToString() + " (" + ETC.CalcAbilityRank(dr, "Bullet", index) + ")";
                            DollBulletProgress.Value = (int)dr["Bullet"];
                            break;
                        case "SG":
                            foreach (Control c in BulletControl) c.Visible = true;
                            foreach (Control c in ArmorControl) c.Visible = true;
                            DollReloadTimeLabel.Text = "SG 재장전 시간 : " + CalcReloadTime(dr, (string)dr["Type"]);
                            DollBulletCountLabel.Text = ((int)dr["Bullet"]).ToString() + " (" + ETC.CalcAbilityRank(dr, "Bullet", index) + ")";
                            DollBulletProgress.Value = (int)dr["Bullet"];
                            DollArmorCountLabel.Text = (string)dr["Armor"] + " (" + ETC.CalcAbilityRank(dr, "Armor", index) + ")";
                            DollArmorProgress.Value = Convert.ToInt32((((string)dr["Armor"]).Split('/'))[1]);
                            break;
                        default:
                            foreach (Control c in BulletControl) c.Visible = false;
                            foreach (Control c in ArmorControl) c.Visible = false;
                            DollReloadTimeLabel.Text = "";
                            break;
                    }

                    string eType = (string)dr["EffectType"];
                    switch (eType)
                    {
                        case "ALL":
                            DollEffectTypeLabel.Text = "모든 인형";
                            break;
                        default:
                            DollEffectTypeLabel.Text = eType + " 한정";
                            break;
                    }

                    string[] effect_form = ((string)dr["EffectFormation"]).Split(',');

                    for (int i = 0; i < DollEffectFormationTable.Controls.Count; ++i)
                    {
                        string key = "DollEffectFormation" + (i + 1);

                        switch (effect_form[i])
                        {
                            case "1":
                                DollEffectFormationTable.Controls[key].BackColor = Color.Green;
                                break;
                            case "2":
                                DollEffectFormationTable.Controls[key].BackColor = Color.Gray;
                                break;
                            case "0":
                                DollEffectFormationTable.Controls[key].BackColor = Color.White;
                                break;
                        }
                    }

                    string[] effect = null;

                    switch (index)
                    {
                        case 0:
                            effect = (((string)dr["Effect"]).Split(';'))[0].Split(',');
                            break;
                        case 1:
                        case 2:
                        case 3:
                            effect = (((string)dr["ModEffect"]).Split(';'))[0].Split(',');
                            break;
                    }

                    DollEffectLabel.Text = "";

                    for (int i = 0; i < effect.Length; ++i)
                    {
                        string s = "";

                        switch (effect[i])
                        {
                            case "FR":
                                s = "화력↑";
                                break;
                            case "AS":
                                s = "사속↑";
                                break;
                            case "CR":
                                s = "크리티컬↑";
                                break;
                            case "CL":
                                s = "쿨타임↓";
                                break;
                            case "EV":
                                s = "회피↑";
                                break;
                            case "AC":
                                s = "명중↑";
                                break;
                            case "AM":
                                s = "장갑↑";
                                break;
                        }

                        DollEffectLabel.Text += s;

                        if (i < (effect.Length - 1)) DollEffectLabel.Text += " ";
                    }

                    string[] s_temp = null;

                    switch (index)
                    {
                        case 0:
                            s_temp = ((string)dr["Effect"]).Split(';');
                            break;
                        case 1:
                        case 2:
                        case 3:
                            s_temp = ((string)dr["ModEffect"]).Split(';');
                            break;
                    }

                    StringBuilder sb = new StringBuilder();

                    for (int i = 1; i < s_temp.Length; ++i)
                    {
                        string[] s2 = s_temp[i].Split(',');
                        
                        for (int j = 0; j < s2.Length; ++j)
                        {
                            sb.Append(s2[j]);
                            sb.Append("%");
                            if (j < (s2.Length - 1)) sb.Append(", ");
                        }

                        if (i < (s_temp.Length - 1)) sb.Append(" | ");
                    }

                    EffectToolTip.RemoveAll();
                    EffectToolTip.SetToolTip(DollEffectLabel, sb.ToString());

                    if (DollInfoGroup.Visible == false) DollInfoGroup.Visible = true;
                    if (DollDetailInfoWebDDB.Visible == false) DollDetailInfoWebDDB.Visible = true;
                    if (DollDetailInfoWebNamuWiki.Visible == false) DollDetailInfoWebNamuWiki.Visible = true;
                    if ((bool)dr["HasVoice"] == true)
                    {
                        string[] list = ((string)dr["Voices"]).Split(';');
                        DollVoiceList.Items.Clear();
                        DollVoiceList.Items.AddRange(list);
                        DollVoicePlayButton.Visible = true;
                        DollVoiceList.Visible = true;
                    }
                    else
                    {
                        DollVoiceList.Items.Clear();
                        DollVoicePlayButton.Visible = false;
                        DollVoiceList.Visible = false;
                    }

                    //CalcChart(DollAbilityChart, dr, index);
                }
                else throw new Exception("DB내에 해당하는 데이터가 없습니다.");
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private double[] CalcBaseDamage(int FR, int EquipBuff, int FormationBuff, int[] SkillBuff)
        {
            try
            {
                double tSkillBuff = 1;
                foreach (int s_buff in SkillBuff) tSkillBuff *= (1 + (s_buff / 100.0));

                double tDamage = (FR + EquipBuff) * (1 + (FormationBuff / 100.0)) * tSkillBuff;
                double[] fDamage = { (tDamage * 0.85), (tDamage + 1.15) };

                return fDamage;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return new double[] { 0, 0 };
        }

        private double CalcReloadTime(DataRow dr, string type)
        {
            try
            {
                switch (type)
                {
                    case "MG":
                        int tAS = int.Parse(((string)dr["AttackSpeed"]).Split('/')[1]);
                        return (4 + (200 / tAS));
                    case "SG":
                        int tB = (int)dr["Bullet"];
                        return (1.5 + (0.5 * tB));
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return 0;
        }

        private async void 업데이트확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUpdateTimer.Stop();

            await CheckUpdate();

            CheckUpdateTimer.Start();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DollImageBox_LoadProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            DollImageLoadProcess.Visible = true;
            DollImageLoadProcess.Value = e.ProgressPercentage;
        }

        private void DollImageBox_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            DollImageLoadProcess.Visible = false;
        }

        private void DollImageSDBox_LoadProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            DollSDImageLoadProgress.Visible = true;
            DollSDImageLoadProgress.Value = e.ProgressPercentage;
        }

        private void DollImageSDBox_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            DollSDImageLoadProgress.Visible = false;
        }

        private void 소녀전선서포터정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GFSInfo info = new GFSInfo();
            info.ShowDialog();
        }

        private void 공지사항ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Notification n = new Notification();
                n.ShowDialog();
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void DollProductTimeTableButton_Click(object sender, EventArgs e)
        {
            ProductTimeTable ptt = new ProductTimeTable((int)ETC.TimeTableMode.Doll);
            ptt.ShowDialog();
        }

        private void FreeOPMaxLevelUpDown_ValueChanged(object sender, EventArgs e)
        {
            FreeOPMinLevelUpDown.Maximum = ((NumericUpDown)sender).Value;
        }

        private void FreeOPMaxMUUpDown_ValueChanged(object sender, EventArgs e)
        {
            FreeOPMinMUUpDown.Maximum = ((NumericUpDown)sender).Value;
        }

        private void FreeOPMaxTimeUpDown_ValueChanged(object sender, EventArgs e)
        {
            FreeOPMinTimeUpDown.Maximum = ((NumericUpDown)sender).Value;

            FreeOPMaxTimeLabel.Text = "(" + ETC.CalcTime(Convert.ToInt32(((NumericUpDown)sender).Value)) + ")";
        }

        private void FreeOPMinTimeUpDown_ValueChanged(object sender, EventArgs e)
        {
            FreeOPMinTimeLabel.Text = "(" + ETC.CalcTime(Convert.ToInt32(((NumericUpDown)sender).Value)) + ")";
            if (FreeOPMaxTimeUpDown.Value < ((NumericUpDown)sender).Value) FreeOPMaxTimeUpDown.Value = ((NumericUpDown)sender).Value;
        }

        private async void FreeOPSearchButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(100);

            ListFreeOP();
        }

        private void FreeOPSearchResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                FreeOPMinMUUpDown.Value = FreeOPMinMUUpDown.Minimum;
                FreeOPMaxMUUpDown.Value = FreeOPMaxMUUpDown.Maximum;

                FreeOPMinLevelUpDown.Value = FreeOPMinLevelUpDown.Minimum;
                FreeOPMaxLevelUpDown.Value = FreeOPMaxLevelUpDown.Maximum;

                FreeOPMinTimeUpDown.Value = FreeOPMinTimeUpDown.Minimum;
                FreeOPMaxTimeUpDown.Value = FreeOPMaxTimeUpDown.Maximum;

                FreeOPLocationNormal.Checked = true;
                FreeOPLocationEmergency.Checked = true;
                FreeOPLocationNight.Checked = true;

                FreeOPSpecialDropExist.Checked = true;
                FreeOPSpecialDropNoExist.Checked = true;

                ListFreeOP();
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void SkillTrainingTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Task.Delay(100);

            try
            {
                DataRow dr = null;

                for (int i = 0; i < ETC.SkillTrainingList.Rows.Count; ++i)
                {
                    if ((string)(ETC.SkillTrainingList.Rows[i])["Type"] == SkillTrainingTypeSelector.Text)
                    {
                        dr = ETC.SkillTrainingList.Rows[i];
                        break;
                    }
                }

                string[] tDataType = ((string)dr["DataType"]).Split(';');
                string[] tConsumption = ((string)dr["Consumption"]).Split(';');
                string[] tTime = ((string)dr["Time"]).Split(';');

                for (int i = 1; i <= 9; ++i)
                {
                    string t_dt = "";
                    
                    switch (tDataType[i - 1])
                    {
                        case "B":
                            t_dt = "초급";
                            break;
                        case "A":
                            t_dt = "중급";
                            break;
                        case "M":
                            t_dt = "고급";
                            break;
                    }
                    (SkillTrainingTable.Controls["STDataType" + i]).Text = t_dt;
                    (SkillTrainingTable.Controls["STConsumption" + i]).Text = tConsumption[i - 1];
                    (SkillTrainingTable.Controls["STTime" + i]).Text = tTime[i - 1];
                }
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                ListView lv = (ListView)sender;

                if ((lv.Sorting == SortOrder.Ascending) || (lv.Sorting == SortOrder.None)) lv.Sorting = SortOrder.Descending;
                else lv.Sorting = SortOrder.Ascending;

                Sorter sorter = new Sorter();
                sorter.Order = lv.Sorting;
                sorter.ColumnIndex = e.Column;
                lv.ListViewItemSorter = sorter;
                lv.Sort();
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void EquipmentDicListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((ListView)sender).SelectedItems.Count > 0)
                {
                    string equipmentName = ((ListView)sender).SelectedItems[0].SubItems[0].Text;
                    PrintEquipmentInfo(equipmentName);
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void PrintEquipmentInfo(string name)
        {
            await Task.Delay(100);

            try
            {
                Control[] DollTypeImageBoxes = { EquipmentDollTypeHG, EquipmentDollTypeAR, EquipmentDollTypeSMG, EquipmentDollTypeMG, EquipmentDollTypeRF, EquipmentDollTypeSG };

                DataRow dr = ETC.FindDataRow(ETC.EquipmentList, "Name", name);
                if (dr != null)
                {
                    EquipmentDicName.Text = (string)dr["Name"];

                    string EquipmentImageName = (string)dr["Icon"] + ".png";
                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) EquipmentDicEquipmentImage.Image = EquipmentImageList.Images[EquipmentImageName];
                    else EquipmentDicEquipmentImage.ImageLocation = Path.Combine(ImagePath, "Equipment", EquipmentImageName);

                    if ((int)dr["Grade"] == 0) EquipmentDicEquipmentImage.BackgroundImage = Image.FromFile(Path.Combine(ImagePath, "BG", "5starE.png"));
                    else EquipmentDicEquipmentImage.BackgroundImage = Image.FromFile(Path.Combine(ImagePath, "BG", (int)dr["Grade"] + "starE.png"));

                    if (dr["Note"] != DBNull.Value) EquipmentDicNote.Text = (string)dr["Note"];
                    else EquipmentDicNote.Text = "";

                    if ((int)dr["ProductTime"] == 0) DollProductTimeLabel.Text = "제조불가";
                    else DollProductTimeLabel.Text = "제조시간 => " + ETC.CalcTime((int)dr["ProductTime"]);

                    if ((dr["OnlyUse"] == DBNull.Value) || ((string)dr["OnlyUse"] == ""))
                    {
                        EquipmentDollTypeOnlyUse.Visible = false;
                        foreach (Control c in DollTypeImageBoxes) c.Visible = true;

                        string[] dTypes = ((string)dr["DollType"]).Split(';');

                        for (int i = 0; i < dTypes.Length; ++i)
                        {
                            string[] dType = dTypes[i].Split(',');
                            string IsAvailable = "";

                            switch (dType[1])
                            {
                                case "N":
                                    IsAvailable = "N_";
                                    break;
                                case "F":
                                    IsAvailable = "F_";
                                    break;
                                default:
                                    IsAvailable = "";
                                    break;
                            }

                            string TypeIconName = dType[0] + "_" + IsAvailable + "icon" + ".png";

                            switch (dType[0])
                            {
                                case "HG":
                                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) EquipmentDollTypeHG.Image = TypeIconImageList.Images[TypeIconName];
                                    else EquipmentDollTypeHG.ImageLocation = Path.Combine(ImagePath, "TypeIcon", TypeIconName);
                                    break;
                                case "SMG":
                                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) EquipmentDollTypeSMG.Image = TypeIconImageList.Images[TypeIconName];
                                    else EquipmentDollTypeSMG.ImageLocation = Path.Combine(ImagePath, "TypeIcon", TypeIconName);
                                    break;
                                case "AR":
                                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) EquipmentDollTypeAR.Image = TypeIconImageList.Images[TypeIconName];
                                    else EquipmentDollTypeAR.ImageLocation = Path.Combine(ImagePath, "TypeIcon", TypeIconName);
                                    break;
                                case "RF":
                                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) EquipmentDollTypeRF.Image = TypeIconImageList.Images[TypeIconName];
                                    else EquipmentDollTypeRF.ImageLocation = Path.Combine(ImagePath, "TypeIcon", TypeIconName);
                                    break;
                                case "MG":
                                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) EquipmentDollTypeMG.Image = TypeIconImageList.Images[TypeIconName];
                                    else EquipmentDollTypeMG.ImageLocation = Path.Combine(ImagePath, "TypeIcon", TypeIconName);
                                    break;
                                case "SG":
                                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) EquipmentDollTypeSG.Image = TypeIconImageList.Images[TypeIconName];
                                    else EquipmentDollTypeSG.ImageLocation = Path.Combine(ImagePath, "TypeIcon", TypeIconName);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        EquipmentDollTypeOnlyUse.Visible = true;
                        foreach (Control c in DollTypeImageBoxes) c.Visible = false;

                        string[] OnlyDoll = ((string)dr["OnlyUse"]).Split(';');
                        EquipmentDollTypeOnlyUse.Text = "";

                        for (int i = 0; i < OnlyDoll.Length; ++i)
                        {
                            EquipmentDollTypeOnlyUse.Text += OnlyDoll[i];
                            if (i < (OnlyDoll.Length - 1)) EquipmentDollTypeOnlyUse.Text += ",";
                        }

                        EquipmentDollTypeOnlyUse.Text += " 전용";
                    }


                    Control[] cAbility = { EquipmentAbility1, EquipmentAbility2, EquipmentAbility3, EquipmentAbility4 };
                    Control[] cInitMag = { EquipmentInitialMagnification1, EquipmentInitialMagnification2, EquipmentInitialMagnification3, EquipmentInitialMagnification4 };
                    Control[] cMaxMag = { EquipmentMaxMagnification1, EquipmentMaxMagnification2, EquipmentMaxMagnification3, EquipmentMaxMagnification4 };

                    string[] tAbility = ((string)dr["Ability"]).Split(';');
                    string[] tInitMag = ((string)dr["InitialMagnification"]).Split(';');
                    string[] tMaxMag = ((string)dr["MaxMagnification"]).Split(';');

                    foreach (Control c in cAbility) c.Text = "";
                    foreach (Control c in cInitMag) c.Text = "";
                    foreach (Control c in cMaxMag) c.Text = "";

                    for (int i = 0; i < tAbility.Length; ++i)
                    {
                        cAbility[i].Text = tAbility[i];

                        cInitMag[i].Text = tInitMag[i];
                        if ((tAbility[i] == "치명타율") || (tAbility[i] == "야시능력") || (tAbility[i] == "치명피해")) cInitMag[i].Text += "%";

                        if (tMaxMag[0] == "강화 불가") cMaxMag[i].Text = tMaxMag[0];
                        else
                        {
                            cMaxMag[i].Text = tMaxMag[i];
                            if ((tAbility[i] == "치명타율") || (tAbility[i] == "야시능력") || (tAbility[i] == "치명피해")) cMaxMag[i].Text += "%";
                        }
                    }
                }
                else throw new Exception("DB내에 해당하는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void StartProduct(ProductMode mode)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://ddb.kirsi.moe/");
        }

        private void 사용도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GFSHelp help = new GFSHelp();
            help.ShowDialog();
        }

        private void FairyDicFairyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((ListView)sender).SelectedItems.Count > 0)
                {
                    string fairyName = ((ListView)sender).SelectedItems[0].SubItems[0].Text;
                    PrintFairyInfo(fairyName);
                    FairyDicFairyDetailInfoWeb.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void PrintFairyInfo(string name)
        {
            await Task.Delay(100);
            
            try
            {
                DataRow dr = ETC.FindDataRow(ETC.FairyList, "Name", name);
                if (dr != null)
                {
                    FairyDicFairyName.Text = (string)dr["Name"];

                    FairyImageIndex = 1;
                    string FairyImageName = (string)dr["Name"] + "_" + FairyImageIndex + ".png";
                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) FairyDicFairyImage.Image = FairyImageList.Images[FairyImageName];
                    else FairyDicFairyImage.ImageLocation = Path.Combine(ImagePath, "Fairy", FairyImageName);

                    FairyDicFairyFRCountLabel.Text = (string)dr["FireRate"];
                    FairyDicFairyACCountLabel.Text = (string)dr["Accuracy"];
                    FairyDicFairyEVCountLabel.Text = (string)dr["Evasion"];
                    FairyDicFairyAMCountLabel.Text = (string)dr["Armor"];
                    FairyDicFairyCRCountLabel.Text = (string)dr["Critical"];

                    FairyDicFairyFRProgress.Value = int.Parse(((string)dr["FireRate"]).Split('/')[1]);
                    FairyDicFairyACProgress.Value = int.Parse(((string)dr["Accuracy"]).Split('/')[1]);
                    FairyDicFairyEVProgress.Value = int.Parse(((string)dr["Evasion"]).Split('/')[1]);
                    FairyDicFairyAMProgress.Value = int.Parse(((string)dr["Armor"]).Split('/')[1]);
                    FairyDicFairyCRProgress.Value = int.Parse(((string)dr["Critical"]).Split('/')[1]);

                    string FairySkillIconName = (string)dr["SkillName"] + ".png";
                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) FairyDicFairySkillIcon.Image = FairySkillIconImageList.Images[FairySkillIconName];
                    else FairyDicFairySkillIcon.ImageLocation = Path.Combine(ImagePath, "FairySkill", FairySkillIconName);

                    FairyDicFairySkillName.Text = (string)dr["SkillName"];
                    FairyDicFairySkillExplain.Text = (string)dr["SkillExplain"];

                    FairyDicFairySkillEffect.Text = "";
                    string[] tSkillEffect = ((string)dr["SkillEffect"]).Split(';');
                    for (int i = 0; i < tSkillEffect.Length; ++i)
                    {
                        FairyDicFairySkillEffect.Text += tSkillEffect[i];
                        if (i < (tSkillEffect.Length - 1)) FairyDicFairySkillEffect.Text += ", ";
                    }

                    StringBuilder sb = new StringBuilder();
                    string[] tSkillRate = ((string)dr["SkillRate"]).Split(';');
                    for (int i = 0; i < tSkillRate.Length; ++i)
                    {
                        sb.Append(tSkillRate[i]);
                        if (i < (tSkillRate.Length - 1)) sb.AppendLine();
                    }

                    EffectToolTip.SetToolTip(FairyDicFairySkillEffect, sb.ToString());
                }
                else throw new Exception("DB내에 해당하는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void FairyDicFairyImage_Click(object sender, EventArgs e)
        {
            try
            {
                switch (FairyImageIndex)
                {
                    case 1:
                        FairyImageIndex = 2;
                        break;
                    case 2:
                        FairyImageIndex = 3;
                        break;
                    case 3:
                        FairyImageIndex = 1;
                        break;
                    default:
                        FairyImageIndex = 1;
                        break;
                }

                string FairyImageName = FairyDicFairyName.Text + "_" + FairyImageIndex + ".png";
                if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) FairyDicFairyImage.Image = FairyImageList.Images[FairyImageName];
                else FairyDicFairyImage.ImageLocation = Path.Combine(ImagePath, "Fairy", FairyImageName);
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void 설정SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();
            s.ShowDialog();

            ImageList[] iList = { EquipmentImageList, FairyImageList, FairySkillIconImageList, TypeIconImageList };

            if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1)
            {
                foreach (ImageList list in iList)
                {
                    if (list.Images.Empty == true)
                    {
                        ProgramStatusLabel.Text = "Load Image to List...";
                        ProgramLoadProgress.Visible = true;
                        await LoadImage();
                        ProgramStatusLabel.Text = "";
                        ProgramLoadProgress.Visible = false;
                        break;
                    }
                }
            }
        }

        private void FairyProductTimeTableButton_Click(object sender, EventArgs e)
        {
            ProductTimeTable ptt = new ProductTimeTable((int)ETC.TimeTableMode.Fairy);
            ptt.ShowDialog();
        }

        private void EquipmentProductTimeTableButton_Click(object sender, EventArgs e)
        {
            ProductTimeTable ptt = new ProductTimeTable((int)ETC.TimeTableMode.Equipment);
            ptt.ShowDialog();
        }

        /*private void PrintDamage(DataRow DollData, DataRow EnemyData)
        {
            const int DefaultDollPenetration = 10;

            try
            {
            	double[] BaseDamage = CalcBaseDamage(DollData, Convert.ToInt32(SumEquipmentBuff("FR")), 0, new int[] { 0 });
                double[] FinalDamage = new double[2];
                double[] CriticalDamage = new double[2];

                int fDollPenetration = DefaultDollPenetration + Convert.ToInt32(SumEquipmentBuff("PT"));

                for (int i = 0; i < BaseDamage.Length; ++i)
                {
                    FinalDamage[i] = CalcPenetrationDamage(BaseDamage[i], fDollPenetration, (int)EnemyData["Penetration"]);
                    CriticalDamage[i] = FinalDamage[i] * (1 + 0.5 + SumEquipmentBuff("CM"));
                }

                string[] DamageString = new string[2];

                for (int i = 0; i < DamageString.Length; ++i)
                {
                    DamageString[i] = Math.Ceiling(FinalDamage[i]) + "(" + Math.Ceiling(CriticalDamage[i]) + ")";
                }

                //DamageTest.Text = DamageString[0] + " ~ " + DamageString[1];
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }*/

        private double SumEquipmentBuff(string type)
        {
            try
            {
                int Buff = 0;

                foreach (DataRow dr in SelectedEquipmentDataRow)
                {
                    if (dr == null) continue;

                    string[] BuffType = ((string)dr["Ability"]).Split(';');
                    string[] BuffMag = null;

                    if ((string)dr["MaxMagnification"] == "강화 불가") 
                    {
                    	BuffMag = ((string)dr["InitialMagnification"]).Split(';');
                    	for (int i = 0; i < BuffMag.Length; ++i)
                    	{
                    		string[] sMag = BuffMag[i].Split('~');
                    		if (sMag.Length > 1)
                    		{
                    			if (sMag[0][0] == '-') sMag[1] = '-' + sMag[1];
                    			BuffMag[i] = sMag[1];
                    		}
                    	}
                    }
                    else BuffMag = ((string)dr["MaxMagnification"]).Split(';');

                    for (int i = 0; i < BuffType.Length; ++i)
                    {
                        switch (type)
                        {
                            case "FR":
                                if (BuffType[i] == "화력") Buff += int.Parse(BuffMag[i]);
                                break;
                            case "PT":
                                if (BuffType[i] == "관통") Buff += int.Parse(BuffMag[i]);
                                break;
                            case "CM":
                                if (BuffType[i] == "치명피해") Buff += int.Parse(BuffMag[i]);
                                break;
                        }
                    }
                }

                return Buff;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return 0;
        }

        private double CalcPenetrationDamage(double BaseDMG, int DollPenetration, int EnemyArmor)
        {
            try
            {
                int gap = DollPenetration - EnemyArmor;

                if (gap <= 2)
                {
                    if ((BaseDMG + gap) <= Math.Ceiling(BaseDMG / 10)) return Math.Round(BaseDMG / 10);
                    else return (BaseDMG + gap);
                }
                else
                {
                    if ((BaseDMG + 2) <= Math.Ceiling(BaseDMG / 10)) return Math.Ceiling(BaseDMG / 10);
                    else return (BaseDMG + 2);
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return 0;
        }

        private void EnemyDicEnemyListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            try
            {
                if ((lv.SelectedItems.Count > 0))
                {
                    string enemyName = (lv.SelectedItems[0].SubItems[0].Text);
                    string enemyType = (lv.SelectedItems[0].SubItems[1].Text);
                    PrintEnemyInfo(enemyName, enemyType);
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void PrintEnemyInfo(string name, string type)
        {
            await Task.Delay(100);

            try
            {
                DataRow dr = ETC.FindDataRow(ETC.EnemyList, "Name", "Type", name, type);
                if (dr != null)
                {
                    string EnemyImageName = (string)dr["Name"] + ".png";
                    if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) EnemyDicEnemyImage.Image = EnemyImageList.Images[EnemyImageName];
                    else EnemyDicEnemyImage.ImageLocation = Path.Combine(ImagePath, "Enemy", EnemyImageName);

                    EnemyDicEnemyName.Text = (string)dr["Name"];
                    EnemyDicEnemyType.Text = (string)dr["Type"];
                    EnemyDicEnemyHPCount.Text = ((int)dr["HP"]).ToString();
                    EnemyDicEnemyFRCount.Text = ((int)dr["FireRate"]).ToString();
                    EnemyDicEnemyEVCount.Text = ((int)dr["Evasion"]).ToString();
                    EnemyDicEnemyACCount.Text = ((int)dr["Accuracy"]).ToString();
                    EnemyDicEnemyASCount.Text = ((int)dr["AttackSpeed"]).ToString();
                    EnemyDicEnemyPTCount.Text = ((int)dr["Penetration"]).ToString();
                    EnemyDicEnemyAMCount.Text = ((int)dr["Armor"]).ToString();

                    EnemyDicEnemyHPProgress.Value = (int)dr["HP"];
                    EnemyDicEnemyFRProgress.Value = (int)dr["FireRate"];
                    EnemyDicEnemyEVProgress.Value = (int)dr["Evasion"];
                    EnemyDicEnemyACProgress.Value = (int)dr["Accuracy"];
                    EnemyDicEnemyASProgress.Value = (int)dr["AttackSpeed"];
                    EnemyDicEnemyPTProgress.Value = (int)dr["Penetration"];
                    EnemyDicEnemyAMProgress.Value = (int)dr["Armor"];

                    if (EnemyDicEnemyInfoGroup.Visible == false) EnemyDicEnemyInfoGroup.Visible = true;
                }
                else throw new Exception("DB내에 해당하는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        /*private void FormationSimulDollEquipmentSelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button EquipmentButton = (Button)sender;

                EquipmentSelector es = new EquipmentSelector(Convert.ToInt32(EquipmentButton.Tag));

                if (es.ShowDialog(this) == DialogResult.OK)
                {
                    DataRow dr = SelectedEquipmentDataRow[Convert.ToInt32(EquipmentButton.Tag) - 1];
                    if (dr == null) return;
                    else
                    {
                        EquipmentButton.Text = (string)dr["Name"];

                        int count = Convert.ToInt32(FormationSimulSelectedDollBox.Tag) - 1;
                        DollBox db = FormationSimulDollBoxes[count / 3, count % 3];
                        db.EquipmentList[Convert.ToInt32(EquipmentButton.Tag) - 1] = (string)dr["Name"];
                        FormationSimulDollBoxes[count / 3, count % 3] = db;
                    }
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }*/

        private void 로그폴더열기ToolStripMenuItemClick(object sender, EventArgs e)
		{
			string LogPath = Path.Combine(Application.StartupPath, "System", "Log");
			if (Directory.Exists(LogPath) == true) Process.Start(LogPath);
		}

        /*private void FormationSimulDollSDImage_MouseLeave(object sender, EventArgs e)
        {
            FormationSimulDollSelector.Visible = false;
            FormationSimulEnterDollBox = null;
        }*/

        /*private void FormationSimulDollSDImage_MouseClick(object sender, MouseEventArgs e)
        {
        	PictureBox[] FormationSimulDollBox = { FormationSimulDollSDImage7, FormationSimulDollSDImage8, FormationSimulDollSDImage9, FormationSimulDollSDImage4, FormationSimulDollSDImage5, FormationSimulDollSDImage6, FormationSimulDollSDImage1, FormationSimulDollSDImage2, FormationSimulDollSDImage3 };
            Button[] FormationSimulDollEquipButtons = { FormationSimulDollEquipment1, FormationSimulDollEquipment2, FormationSimulDollEquipment3 };

            try
            {
        		PictureBox PB = (PictureBox)sender;
                int i = Convert.ToInt32(PB.Tag) - 1;
                DollBox db = FormationSimulDollBoxes[(i / 3), (i % 3)];

                if (e.Button == MouseButtons.Left)
        		{
        			foreach (PictureBox pb in FormationSimulDollBox) pb.BackColor = Color.Transparent;

                    if (!string.IsNullOrEmpty(db.PB.ImageLocation))
                    {
                        db.PB.BackColor = Color.LightPink;
                        PrintEffectPlace(db);
                    }
        			FormationSimulSelectedDollBox = PB;
        		}
                if (e.Button == MouseButtons.Right)
                {
                    if (db.PB == FormationSimulSelectedDollBox)
                    {
                        foreach (PictureBox pb in FormationSimulDollBox) pb.BackColor = Color.Transparent;
                        FormationSimulSelectedDollBox = null;
                    }
                    else db.PB.BackColor = Color.Transparent;

                	db.PB.ImageLocation = null;
                    db.d_Name = "";
                    db.d_Num = 0;
                    for (int k = 0; k < 3; ++k) db.EquipmentList[k] = "";
                    FormationSimulDollBoxes[(i / 3), (i % 3)] = db;

                    CalcEffect();
                }

                if (!string.IsNullOrEmpty(db.PB.ImageLocation))
                {
                    if (FormationSimulSelectedDollBox == null) foreach (Button b in FormationSimulDollEquipButtons) b.Visible = false;
                    else
                    {
                        for (int k = 0; k < 3; ++k)
                        {
                            FormationSimulDollEquipButtons[k].Text = db.EquipmentList[k];
                            FormationSimulDollEquipButtons[k].Visible = true;
                        }
                    }
                }
                else foreach (Button b in FormationSimulDollEquipButtons) b.Visible = false;
            }
        	catch (Exception ex)
        	{
        		ETC.ErrorMessage(ex.Message);
        		ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
        	}
        }*/

        /*private void PrintEffectPlace(DollBox DB)
        {
            try
            {
                DataRow dr = ETC.FindDataRow(ETC.DollList, "Name", DB.d_Name);

                int[,] Formation = new int[3, 3];
                string[] sFormation = ((string)dr["EffectFormation"]).Split(',');

                for (int i = 0; i < sFormation.Length; ++i)
                {
                    Formation[(i / 3), (i % 3)] = int.Parse(sFormation[i]);
                }

                int x = 0, y = 0;

                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if (Formation[i, j] == 2)
                        {
                            x = i;
                            y = j;
                        }
                    }
                }

                int nx = DB.Row;
                int ny = DB.Column;
                int cx = nx - x;
                int cy = ny - y;

                for (int i = 0; i < 9; ++i)
                {
                    int rx = i / 3;
                    int ry = i % 3;

                    if (Formation[rx, ry] == 1)
                    {
                        if (((rx + cx) < 3) && ((rx + cx) >= 0) && ((ry + cy) < 3) && ((ry + cy) >= 0))
                        {
                            FormationSimulDollBoxes[rx + cx, ry + cy].PB.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }*/
        
        /*private void CheckEffectPlace(DollBox DB)
        {
        	try
            {
                DataRow dr = ETC.FindDataRow(ETC.DollList, "Name", DB.d_Name);

                if (dr == null) return;

                int[,] Formation = new int[3, 3];
                string[] sFormation = ((string)dr["EffectFormation"]).Split(',');

                for (int i = 0; i < sFormation.Length; ++i)
                {
                    Formation[(i / 3), (i % 3)] = int.Parse(sFormation[i]);
                }

                int x = 0, y = 0;

                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if (Formation[i, j] == 2)
                        {
                            x = i;
                            y = j;
                        }
                    }
                }

                int nx = DB.Row;
                int ny = DB.Column;
                int cx = nx - x;
                int cy = ny - y;

                for (int i = 0; i < 9; ++i)
                {
                    int rx = i / 3;
                    int ry = i % 3;

                    if (Formation[rx, ry] == 1)
                    {
                        if (((rx + cx) < 3) && ((rx + cx) >= 0) && ((ry + cy) < 3) && ((ry + cy) >= 0))
                        {
                            string[] E_Sort = (((string)dr["Effect"]).Split(';'))[0].Split(',');
                            string[] tE_Mag = ((string)dr["Effect"]).Split(';');

                            /*foreach (string sort in E_Sort)
                            {
                                string[] E_Mag = tE_Mag[tE_Mag.Length - 1].Split(',');

                                foreach (string mag in E_Mag)
                                {
                                    EffectInfo ei = new EffectInfo();
                                    ei.EffectSourcePlace = (nx * 3) + ny;
                                    ei.EffectType = (string)dr["EffectType"];
                                    ei.EffectSort = sort;
                                    ei.EffectMag = int.Parse(mag);
                                    FormationSimulDollBoxes[(rx + cx), (ry + cy)].EffectList.Add(ei);
                                }
                            }

                            for (int s = 0; s < E_Sort.Length; ++s)
                            {
                                string[] E_Mag = tE_Mag[tE_Mag.Length - 1].Split(',');

                                EffectInfo ei = new EffectInfo();
                                ei.EffectSourcePlace = (nx * 3) + ny;
                                ei.EffectType = (string)dr["EffectType"];
                                ei.EffectSort = E_Sort[s];
                                ei.EffectMag = int.Parse(E_Mag[s]);
                                FormationSimulDollBoxes[(rx + cx), (ry + cy)].EffectList.Add(ei);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }*/

        /*private void FormationSimulDollSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBox[] FormationSimulDollBox = { FormationSimulDollSDImage7, FormationSimulDollSDImage8, FormationSimulDollSDImage9, FormationSimulDollSDImage4, FormationSimulDollSDImage5, FormationSimulDollSDImage6, FormationSimulDollSDImage1, FormationSimulDollSDImage2, FormationSimulDollSDImage3 };

            try
            {
                ComboBox CB = (ComboBox)sender;

                if (FormationSimulEnterDollBox != null)
                {
                    DataRow DollDR = ETC.FindDataRow(ETC.DollList, "Name", CB.Text);
                    string ImageURL = ETC.ImageServer + "/SD/" + (int)DollDR["DicNumber"] + ".png";

                    foreach (PictureBox pb in FormationSimulDollBox)
                    if (ImageURL == pb.ImageLocation)
                    {
                        MessageBox.Show("진형에 동일한 인형 2개 이상 배치할 수 없습니다.", "동일 인형 배치 방지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    for (int i = 0; i < 3; ++i)
                    {
                        for (int j = 0; j < 3; ++j)
                        {
                            if (FormationSimulDollBoxes[i, j].PB == FormationSimulEnterDollBox)
                            {
                                DollBox db = FormationSimulDollBoxes[i, j];
                                db.d_Name = (string)DollDR["Name"];
                                db.d_Num = (int)DollDR["DicNumber"];
                                db.PB.ImageLocation = ImageURL;
                                FormationSimulDollBoxes[i, j] = db;
                                CalcEffect();
                            }
                        }
                    }
                }

                FormationSimulEnterDollBox = null;
                FormationSimulDollSelector.Visible = false;
                FormationSimulDollSelector.SelectedItem = null;
                
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }*/
        
        /*private void CalcEffect()
        {
        	try
        	{
                foreach (Control c in FormationIconControls)
                {
                    FormationSimulator.Controls.Remove(c);
                }

                for (int i = 0; i < 9; ++i)
                {
                    int x = i / 3;
                    int y = i % 3;

                    FormationSimulDollBoxes[x, y].EffectList.Clear();
                }

                for (int i = 0; i < 9; ++i)
                {
                    int x = i / 3;
                    int y = i % 3;

                    CheckEffectPlace(FormationSimulDollBoxes[x, y]);
                }

                PrintEffect();
            }
        	catch (Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }*/

        /*private void PrintEffect()
        {
            try
            {
                for (int i = 0; i < 9; ++i)
                {
                    int x = i / 3;
                    int y = i % 3;

                    DollBox db = FormationSimulDollBoxes[x, y];
                    DataRow dr = null;
                    if (!string.IsNullOrEmpty(db.d_Name)) dr = ETC.FindDataRow(ETC.DollList, "Name", db.d_Name);
                    else continue;

                    Hashtable ht = new Hashtable(7);
                    ht.Add("FR", 0);
                    ht.Add("AC", 0);
                    ht.Add("EV", 0);
                    ht.Add("AS", 0);
                    ht.Add("CL", 0);
                    ht.Add("AM", 0);
                    ht.Add("CR", 0);

                    foreach (EffectInfo ei in db.EffectList)
                    {
                        if ((ei.EffectType == "ALL") || (ei.EffectType == (string)dr["Type"]))
                        {
                            int o_mag = (int)ht[ei.EffectSort];
                            ht[ei.EffectSort] = ei.EffectMag + o_mag;
                        }
                    }

                    int count = 0;

                    foreach (string key in ht.Keys)
                    {
                        if ((int)ht[key] == 0) continue;

                        SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

                        Panel p = new Panel();
                        PictureBox pb = new PictureBox();
                        Label lb = new Label();

                        FormationIconControls.Add(p);
                        FormationIconControls.Add(pb);
                        FormationIconControls.Add(lb);

                        this.FormationSimulator.Controls.Add(p);
                        this.FormationSimulator.Controls.Add(pb);
                        this.FormationSimulator.Controls.Add(lb);
                        
                        p.Size = new Size(50, 20);
                        p.BackColor = Color.Transparent;
                        p.Controls.Add(pb);
                        p.Controls.Add(lb);

                        pb.Size = new Size(20, 20);
                        pb.Dock = DockStyle.Left;
                        pb.BackgroundImageLayout = ImageLayout.Zoom;
                        if (key != "CL") pb.BackgroundImage = EffectIconList.Images[key + "_Icon.png"];
                        lb.Dock = DockStyle.Right;
                        lb.Size = new Size(p.Size.Width - pb.Size.Width, 20);
                        lb.BackColor = Color.Transparent;
                        lb.TextAlign = ContentAlignment.MiddleCenter;
                        lb.Text = (int)ht[key] + "%";

                        p.Location = new Point((db.PB.Location.X), (db.PB.Location.Y + (20 * count)));
                        p.BringToFront();

                        count += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }*/
        
		private void MDCalcResetButton_Click(object sender, EventArgs e)
		{
			try
			{
				Label[] ResultLabels = { ManPowerResult, AmmoResult, FoodResult, PartsResult };
				ComboBox[] MDSelectCB = { Location1, Location2, Location3, Location4 };
				
				foreach (Label lb in ResultLabels) lb.Text = "0";
				foreach (ComboBox cb in MDSelectCB) cb.SelectedIndex = 0;
			}
			catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
		}
		
		private void MDCalcLocation_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				ComboBox[] MDSelectCB = { Location1, Location2, Location3, Location4 };
				
				for (int i = 0; i < MDSelectCB.Length; ++i)
				{
					if (MDSelectCB[i].SelectedIndex == 0) continue;
					
					for (int j = i + 1; j < MDSelectCB.Length; ++j)
					{
						if (MDSelectCB[j].SelectedIndex == 0) continue;
						if (MDSelectCB[i].SelectedIndex == MDSelectCB[j].SelectedIndex)
						{
							MDCalcPrintButton.Enabled = false;
							goto EXIT;
						}
					}
				}
				
				if (MDCalcPrintButton.Enabled == false) MDCalcPrintButton.Enabled = true;
				
			EXIT:
				return;
			}
			catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
		}

        private void DollDetailInfoWebDDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if ((DollNumLabel.Text != null) || (DollNumLabel.Text != ""))
                {
                    int num = int.Parse(((DollNumLabel.Text).Split(' '))[1]);
                    string url = "http://ddb.kirsi.moe/main.html#gun-info&" + num;
                    Process.Start(url);
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void DollDetailInfoWebNamuWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if ((DollNumLabel.Text != null) || (DollNumLabel.Text != ""))
                {
                    string Name = DollNameLabel.Text;
                    string url = "https://namu.wiki/w/" + Name + "(소녀전선)";
                    Process.Start(url);
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        /*private void FormationSimulDollSDImage_MouseEnter(object sender, EventArgs e)
		{
			PictureBox[] FormationSimulDollBox = { FormationSimulDollSDImage7, FormationSimulDollSDImage8, FormationSimulDollSDImage9, FormationSimulDollSDImage4, FormationSimulDollSDImage5, FormationSimulDollSDImage6, FormationSimulDollSDImage1, FormationSimulDollSDImage2, FormationSimulDollSDImage3 };

            try
            {
        		PictureBox PB = (PictureBox)sender;

        		int i = 0;
        		
				if (string.IsNullOrEmpty(PB.ImageLocation)) 
				{
					foreach (PictureBox pb in FormationSimulDollBox) 
					{
						if (pb.ImageLocation != null) i++;
					}

					if (i >= 5) 
					{
						FormationSimulDollSelector.Visible = false;
					}
					else
					{
						FormationSimulEnterDollBox = PB;
						FormationSimulDollSelector.Location = new Point((PB.Location.X), (PB.Location.Y));
						FormationSimulDollSelector.Visible = true;
					}
				}
				else
				{
					FormationSimulEnterDollBox = PB;
					FormationSimulDollSelector.Location = new Point((PB.Location.X), (PB.Location.Y));
					FormationSimulDollSelector.Visible = true;
				}
        	}
        	catch (Exception ex)
        	{
        		ETC.ErrorMessage(ex.Message);
        		ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
        	}
		}*/

        private void DollVoicePlayButton_Click(object sender, EventArgs e)
        {
            string VoicePath = Path.Combine(ETC.Server, "Data", "Voice");

            try
            {
                if (!string.IsNullOrEmpty(DollVoiceList.Text))
                {
                    string name = DollNameLabel.Text;
                    string voicename = DollVoiceList.Text;
                    string VoiceURL = Path.Combine(VoicePath, name, name + "_" + voicename + "_JP.wav");

                    SoundPlayer sp = new SoundPlayer(VoiceURL);
                    sp.Play();
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void ProductSimulDollProductButton_Click(object sender, EventArgs e)
        {
            sw.Reset();
            sw.Start();
            Control[] ResultControls = { ProductDollResultGradeStar1, ProductDollResultGradeStar2, ProductDollResultGradeStar3, ProductDollResultGradeStar4, ProductDollResultGradeStar5, ProductDollResultDollTypeIcon, ProductDollResultBackgroundPanel };

            try
            {
                ((Button)sender).Enabled = false;

                foreach (Control c in ResultControls)
                {
                    c.Visible = false;
                    if (c is PictureBox) ((PictureBox)c).Image = null;
                    if (c is Label) ((Label)c).Text = "";
                }

                ArrayList AvailableType = new ArrayList();
                ArrayList AvailableDoll = new ArrayList();

                int pManPower = Convert.ToInt32(ProductSimulDollManpowerCount.Value);
                int pAmmo = Convert.ToInt32(ProductSimulDollAmmoCount.Value);
                int pFood = Convert.ToInt32(ProductSimulDollFoodCount.Value);
                int pParts = Convert.ToInt32(ProductSimulDollPartsCount.Value);

                if (ETC.IsShowCensorImage == true)
                {
                    if ((pManPower == 666) && (pAmmo == 666) && (pFood == 666) && (pParts == 666)) File.Create(Path.Combine("System", "Extra", "Censor.extra"));
                }

                DollSimulationUseManPower.Text = (Int32.Parse(DollSimulationUseManPower.Text) + pManPower).ToString();
                DollSimulationUseAmmo.Text = (Int32.Parse(DollSimulationUseAmmo.Text) + pAmmo).ToString();
                DollSimulationUseFood.Text = (Int32.Parse(DollSimulationUseFood.Text) + pFood).ToString();
                DollSimulationUseParts.Text = (Int32.Parse(DollSimulationUseParts.Text) + pParts).ToString();

                AvailableType.Add("SMG");
                switch (IsDollAdvanceProduct)
                {
                    case false:
                        if ((pManPower + pAmmo + pFood + pParts) <= 920) AvailableType.Add("HG");
                        if ((pManPower + pAmmo + pFood + pParts) >= 800) AvailableType.Add("AR");
                        if ((pManPower >= 300) && (pFood >= 300)) AvailableType.Add("RF");
                        if ((pManPower >= 400) && (pAmmo >= 600) && (pParts > 300)) AvailableType.Add("MG");
                        break;
                    case true:
                        if ((pManPower + pAmmo + pFood + pParts) >= 800) AvailableType.Add("AR");
                        if ((pManPower >= 3000) && (pFood >= 3000)) AvailableType.Add("RF");
                        if ((pManPower >= 4000) && (pAmmo >= 6000) && (pParts >= 3000)) AvailableType.Add("MG");
                        if ((pManPower >= 4000) && (pFood >= 6000) && (pParts >= 3000)) AvailableType.Add("SG");
                        break;
                }
                

                AvailableType.TrimToSize();

                for (int i = 0; i < ETC.DollList.Rows.Count; ++i)
                {
                    DataRow dr = ETC.DollList.Rows[i];
                    bool Found = false;
                    bool TypeMatch = false;

                    foreach (string s in AvailableType)
                    {
                        if ((string)dr["Type"] == s)
                        {
                            TypeMatch = true;
                            break;
                        }
                    }

                    if (TypeMatch == false) continue;

                    string[] drop = ((string)dr["DropEvent"]).Split(',');
                    if ((IsDollAdvanceProduct == false) && (drop[0] == "중형제조")) continue;
                    if ((int)dr["ProductTime"] == 0) continue;

                    switch ((string)dr["Type"])
                    {
                        case "SMG":
                            string[] list_smg = { "G36C", "벡터", "79식", "수오미", "SR-3MP", "UMP9", "UMP45", "PP-90", "시프카", "스텐 Mk.II" };
                            foreach (string s in list_smg)
                            {
                                if (s == (string)dr["Name"])
                                {
                                    if (((IsDollAdvanceProduct == false) && (pManPower >= 400) && (pAmmo >= 400) && (pFood >= 30) && (pParts >= 30)) || ((IsDollAdvanceProduct == true) && (pManPower >= 4000) && (pAmmo >= 4000) && (pFood >= 1000) && (pParts >= 1000)))
                                    {
                                        AvailableDoll.Add(dr);
                                        Found = true;
                                        break;
                                    }
                                }
                            }

                            if (Found == false) AvailableDoll.Add(dr);
                            break;
                        case "HG":
                            if (IsDollAdvanceProduct == false)
                            {
                                string[] list_hg = { "M950A", "웰로드 Mk.II", "스테츠킨", "P7", "Spitfire" };
                                foreach (string s in list_hg)
                                {
                                    if (s == (string)dr["Name"])
                                    {
                                        if ((pManPower >= 130) && (pAmmo >= 130) && (pFood >= 130) && (pParts >= 30))
                                        {
                                            AvailableDoll.Add(dr);
                                            Found = true;
                                            break;
                                        }
                                    }

                                }

                                if (Found == false) AvailableDoll.Add(dr);
                            }
                            break;
                        case "AR":
                            string[] list_ar = { "G41", "FAL", "95식", "97식", "RFB", "TAR-21", "G36", "리베롤" };
                            foreach (string s in list_ar)
                            {
                                if (s == (string)dr["Name"])
                                {
                                    if (((IsDollAdvanceProduct == false) && (pManPower >= 30) && (pAmmo >= 400) && (pFood >= 400) && (pParts >= 30)) || ((IsDollAdvanceProduct == true) && (pManPower >= 1000) && (pAmmo >= 4000) && (pFood >= 4000) && (pParts >= 1000)))
                                    {
                                        AvailableDoll.Add(dr);
                                        Found = true;
                                        break;
                                    }
                                }

                            }

                            if (Found == false) AvailableDoll.Add(dr);
                            break;
                        case "RF":
                            string[] list_rf = { "Kar98k", "리엔필드", "M99", "IWS2000", "SVD", "한양조88식" };
                            foreach (string s in list_rf)
                            {
                                if (s == (string)dr["Name"])
                                {
                                    if (((IsDollAdvanceProduct == false) && (pManPower >= 400) && (pAmmo >= 30) && (pFood >= 400) && (pParts >= 30)) || ((IsDollAdvanceProduct == false) && (pManPower >= 4000) && (pAmmo >= 1000) && (pFood >= 4000) && (pParts >= 1000)))
                                    {
                                        AvailableDoll.Add(dr);
                                        Found = true;
                                        break;
                                    }
                                }

                            }

                            if (Found == false) AvailableDoll.Add(dr);
                            break;
                        case "MG":
                            string[] list_mg = { "네게브", "MG4", "PKP", "PK" };
                            foreach (string s in list_mg)
                            {
                                if (s == (string)dr["Name"])
                                {
                                    if (((IsDollAdvanceProduct == false) && (pManPower >= 600) && (pAmmo >= 600) && (pFood >= 100) && (pParts >= 400)) || ((IsDollAdvanceProduct == true) && (pManPower >= 6000) && (pAmmo >= 6000) && (pFood >= 1000) && (pParts >= 4000)))
                                    {
                                        AvailableDoll.Add(dr);
                                        Found = true;
                                        break;
                                    }
                                }

                            }

                            if (Found == false) AvailableDoll.Add(dr);
                            break;
                        case "SG":
                            if (IsDollAdvanceProduct == true)
                            {
                                string[] list_sg = { "Saiga", "M37", "Super-Shorty", "RMB" };
                                foreach (string s in list_sg)
                                {
                                    if (s == (string)dr["Name"])
                                    {
                                        if ((pManPower >= 6000) && (pAmmo >= 1000) && (pFood >= 6000) && (pParts >= 4000))
                                        {
                                            AvailableDoll.Add(dr);
                                            Found = true;
                                            break;
                                        }
                                    }
                                }


                                if (Found == false) AvailableDoll.Add(dr);
                            }
                            break;
                    }
                }
                
                AvailableDoll.TrimToSize();
                DataRow ResultDR = await ProductProcess_Doll(AvailableDoll, pManPower, pAmmo, pFood, pParts);

                if (ResultDR == null)
                {
                    ProductSimulDollProductButton.Text = "제조 불가";
                    await Task.Delay(1000);
                    ProductSimulDollProductButton.Text = "제조 시작";
                }

                await PrintProductDollResult(ResultDR);

                ((Button)sender).Enabled = true;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }
        
        private async Task<DataRow> ProductProcess_Doll(ArrayList AvailableDoll, int num1, int num2, int num3, int num4)
        {
            await Task.Delay(100);

        	try
        	{
        		Random R = new Random();
        		int seed_num1 = (num1 + num2 + num3 + num4) / (AvailableDoll.Count / 10);
                int seed_num2 = (num1 + num2 + num3 + num4);

                int[] tP = { 60, 27, 10, 3 };
                int[] tAP1 = { 40, 45, 15 };
                int[] tAP2 = { 20, 60, 20 };
                int[] tAP3 = { 0, 75, 25 };
        		int ConfirmGrade = 0;

                int mag = 1;
                int[] P = null;

                switch (IsDollAdvanceProduct)
                {
                    case false:
                        P = new int[4];
                        for (int k = 0; k < tP.Length; ++k)
                        {
                            P[k] = tP[k] * mag;
                        }
                        break;
                    case true:
                        P = new int[3];
                        switch (DollAdvanceProductTypeNum)
                        {
                            case 1:
                                for (int k = 0; k < tAP1.Length; ++k) P[k] = tAP1[k] * mag;
                                break;
                            case 2:
                                for (int k = 0; k < tAP2.Length; ++k) P[k] = tAP2[k] * mag;
                                break;
                            case 3:
                                for (int k = 0; k < tAP3.Length; ++k) P[k] = tAP3[k] * mag;
                                break;
                        }
                        break;
                }
                
        		int num = R.Next(seed_num1, seed_num2 * mag) % (100 * mag);
        		
                switch (IsDollAdvanceProduct)
                {
                    case false:
                        if ((num >= 0) && (num < P[0])) ConfirmGrade = 2;
                        else if ((num >= P[0]) && (num < (P[0] + P[1]))) ConfirmGrade = 3;
                        else if ((num >= (P[0] + P[1])) && (num >= (P[0] + P[1] + P[2]))) ConfirmGrade = 4;
                        else ConfirmGrade = 5;
                        break;
                    case true:
                        if ((num >= 0) && (num < P[0])) ConfirmGrade = 3;
                        else if ((num >= P[0]) && (num < (P[0] + P[1]))) ConfirmGrade = 4;
                        else ConfirmGrade = 5;
                        break;
                }


                if (ConfirmGrade == 0)
                {
                    if (IsDollAdvanceProduct == false) ConfirmGrade = 2;
                    else if (DollAdvanceProductTypeNum == 3) ConfirmGrade = 4;
                    else ConfirmGrade = 3;
                }
        		
        		ArrayList FinalDoll = new ArrayList();
                int tArrange = 0;
        		
        		foreach (DataRow dr in AvailableDoll)
        		{
                    if ((int)dr["Grade"] == ConfirmGrade)
                    {
                        FinalDoll.Add(dr);
                        
                        int tcount = 0;
                        if ((dr["ProductionPercent"] == DBNull.Value) || (dr["AdvanceProductionPercent"] == DBNull.Value)) tcount = 100;
                        else
                        {
                        	if (IsDollAdvanceProduct == false) tcount += (int)dr["ProductionPercent"];
                        	else tcount += (int)dr["AdvanceProductionPercent"];
                        }
                        
                        tArrange += tcount;
                    }
        		}

                FinalDoll.TrimToSize();

                int fnum = R.Next(1, tArrange);
                int count = 0;
                DataRow ResultDoll = null;

                foreach (DataRow dr in FinalDoll)
                {
                    int count2 = count;

                    if ((dr["ProductionPercent"] == DBNull.Value) || (dr["AdvanceProductionPercent"] == DBNull.Value)) count2 += 100;
                    else
                    {
                    	if (IsDollAdvanceProduct == false) count2 += (int)dr["ProductionPercent"];
                    	else count2 += (int)dr["AdvanceProductionPercent"];
                    }

                    if ((fnum > count) && (fnum <= count2))
                    {
                        ResultDoll = dr;
                        break;
                    }

                    count = count2;
                }

                sw.Stop();
                Trace.WriteLine(sw.Elapsed);
                return ResultDoll;
        	}
        	catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return null;
        }

        private async Task PrintProductDollResult(DataRow dr)
        {
            await Task.Delay(100);

            PictureBox[] GradeStars = { ProductDollResultGradeStar1, ProductDollResultGradeStar2, ProductDollResultGradeStar3, ProductDollResultGradeStar4, ProductDollResultGradeStar5 };
            Label[] GradeStatus = { DollSimulation2StarStatus, DollSimulation3StarStatus, DollSimulation4StarStatus, DollSimulation5StarStatus };

            try
            {
                Image grade_image = null;

                if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) grade_image = GradeImageList.Images["Grade_Star.png"];
                else grade_image = Image.FromFile(Path.Combine(ImagePath, "GradeImage", "Grade_Star.png"));

                string rName = (string)dr["Name"];
                string rType = (string)dr["Type"];
                int rGrade = (int)dr["Grade"];

                for (int i = 0; i < rGrade; ++i)
                {
                    if (i == 5) break;
                    GradeStars[i].Visible = true;

                    int x = 70;
                    int y = 70;

                    GradeStars[i].Size = new Size(x, y);
                    GradeStars[i].Image = grade_image;

                    for (int j = 1; j <= 40; ++j)
                    {
                        GradeStars[i].Size = new Size(x - j, y - j);
                        await Task.Delay(1);
                    }

                    /*for (int j = 0; j < 8; ++j)
                    {
                        grade_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        GradeStars[i].Image = grade_image;

                        await Task.Delay(50);
                    }*/
                }

                GradeStatus[rGrade - 2].Text = (Int32.Parse(GradeStatus[rGrade - 2].Text) + 1).ToString();

                await Task.Delay(500);

                string DollTypeImageName = (string)dr["Type"] + "_Icon" + ".png";
                string DollGradeImageName = "Grade_" + (int)dr["Grade"] + ".png";
                string DollBG = "BG_Grade_" + (int)dr["Grade"] + ".png";

                ProductDollResultDollName.Text = rName;
                ProductDollResultDollDialog.Visible = true;
                ProductDollResultDollName.Visible = true;
                ProductDollResultDollGradeImageBox.Visible = true;

                ProductDollResultBackgroundPanel.BackgroundImage = Image.FromFile(Path.Combine(ImagePath, "BG", DollBG));
                ProductDollResultDollImageBox.ImageLocation = Path.Combine(ETC.ImageServer, "Guns", "Normal", (int)dr["DicNumber"] + ".png");

                if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1)
                {
                    ProductDollResultDollTypeIcon.Image = TypeIconImageList.Images[DollTypeImageName];
                    //ProductDollResultDollImageBox.BackgroundImage = GradeImageList.Images[DollGradeImageName];
                    ProductDollResultDollGradeImageBox.Image = GradeImageList.Images[DollGradeImageName];
                }
                else
                {
                    ProductDollResultDollTypeIcon.ImageLocation = Path.Combine(ImagePath, "TypeIcon", DollTypeImageName);
                    //ProductDollResultDollImageBox.BackgroundImage = Image.FromFile(Path.Combine(ImagePath, "GradeImage", DollGradeImageName));
                    ProductDollResultDollGradeImageBox.Image = Image.FromFile(Path.Combine(ImagePath, "GradeImage", DollGradeImageName));
                }

                ProductDollResultDollTypeIcon.Visible = true;
                ProductDollResultBackgroundPanel.Visible = true;


                await Task.Delay(500);

                ProductDollResultDollImageBox.Visible = true;
                if ((ProductSimulDollVoiceEnableSetting.Checked == true) && ((bool)dr["HasVoice"] == true))
                {
                    string VoicePath = Path.Combine(ETC.Server, "Data", "Voice");
                    string name = (string)dr["Name"];
                    string voicename = "GAIN";
                    string VoiceURL = Path.Combine(VoicePath, name, name + "_" + voicename + "_JP.wav");

                    SoundPlayer sp = new SoundPlayer(VoiceURL);
                    sp.Play();
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void ProductSimulDollProductType_CheckedChanged(object sender, EventArgs e)
        {
            NumericUpDown[] ProductResourceList = { ProductSimulDollManpowerCount, ProductSimulDollAmmoCount, ProductSimulDollFoodCount, ProductSimulDollPartsCount };

            try
            {
                RadioButton rb = (RadioButton)sender;

                if (rb.Checked == false) return;
                
                switch ((string)rb.Tag)
                {
                    case "Normal":
                        IsDollAdvanceProduct = false;
                        foreach (NumericUpDown nud in ProductResourceList)
                        {
                            nud.Minimum = 30;
                            nud.Maximum = 999;
                            nud.Value = nud.Minimum;
                        }
                        ProductSimulDollAdvanceProductTypeGroup.Visible = false;
                        break;
                    case "Advance":
                        IsDollAdvanceProduct = true;
                        foreach (NumericUpDown nud in ProductResourceList)
                        {
                            nud.Minimum = 1000;
                            nud.Maximum = 9999;
                            nud.Value = nud.Minimum;
                        }
                        ProductSimulDollAdvanceProductTypeGroup.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void ProductSimulDollAdvanceProductType_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = (RadioButton)sender;
                if (rb.Checked == false) return;
                DollAdvanceProductTypeNum = Convert.ToInt32(rb.Tag);
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void DollDropEventInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = ETC.FindDataRow(ETC.DollList, "Name", DollNameLabel.Text);

                if (dr != null)
                {
                    string s = (string)dr["DropEvent"];
                    MessageBox.Show(s, "인형 획득 방법", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void FairyDicFairyDetailInfoWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DataRow dr = ETC.FindDataRow(ETC.FairyList, "Name", FairyDicFairyName.Text);

                if (dr != null)
                {
                    int num = (int)dr["DicNumber"];
                    string url = "http://ddb.kirsi.moe/main.html#fairy_info&" + num;
                    Process.Start(url);
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void LevelingCalcTypeSelector_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox[] Selectors = { SimulationTypeSelector, RealWarTypeSelector };

            try
            {
                RadioButton rb = (RadioButton)sender;
                bool IsVisible = false;

                if (rb.Checked == true) IsVisible = true;
                else IsVisible = false;

                foreach (ComboBox cb in Selectors)
                {
                    if ((string)cb.Tag == (string)rb.Tag) cb.Visible = IsVisible;
                }

                if (IsVisible == true)
                {
                    switch ((string)rb.Tag)
                    {
                        case "Simulation":
                            RequireCountPerOnce.Enabled = false;
                            break;
                        case "RealWar":
                            RequireCountPerOnce.Enabled = true;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void RealWarTypeSelector_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox cb = (ComboBox)sender;

                if (cb.Items.Count < 1)
                {
                    for (int i = 0; i < ETC.FreeOPList.Rows.Count; ++i)
                    {
                        DataRow dr = ETC.FreeOPList.Rows[i];
                        cb.Items.Add((string)dr["Location"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void DollEnabler_CheckedChange(object sender, EventArgs e)
        {
            Panel[] DollSetPanels = { Doll1, Doll2, Doll3, Doll4, Doll5 };

            try
            {
                CheckBox cb = (CheckBox)sender;

                if (cb.Checked == true) DollSetPanels[Convert.ToInt32(cb.Tag) - 1].Enabled = true;
                else DollSetPanels[Convert.ToInt32(cb.Tag) - 1].Enabled = false;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void LevelingCalcNowLevel_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown[] TargetLevelLists = { LevelingCalcTargetLevel1, LevelingCalcTargetLevel2, LevelingCalcTargetLevel3, LevelingCalcTargetLevel4, LevelingCalcTargetLevel5 };
            NumericUpDown[] NowExpLists = { LevelingCalcNowExp1, LevelingCalcNowExp2, LevelingCalcNowExp3, LevelingCalcNowExp4, LevelingCalcNowExp5 };

            try
            {
                NumericUpDown mud = (NumericUpDown)sender;
                int tag_num = Convert.ToInt32(mud.Tag);

                TargetLevelLists[tag_num - 1].Minimum = mud.Value;
                NowExpLists[tag_num - 1].Minimum = ETC.LevelExp[Convert.ToInt32(mud.Value - 1)];
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void LevelingCalcCalcButton_Click(object sender, EventArgs e)
        {
            Panel[] DollPanels = { Doll1, Doll2, Doll3, Doll4, Doll5 };
            RadioButton[] WarTypeSelectors = { SimulationType, RealWarType };
            Label[,] ExpCountOutputs = { { ExpCount_1_Normal, ExpCount_1_Leader, ExpCount_1_MVP, ExpCount_1_Leader_MVP },
                                         { ExpCount_2_Normal, ExpCount_2_Leader, ExpCount_2_MVP, ExpCount_2_Leader_MVP },
                                         { ExpCount_3_Normal, ExpCount_3_Leader, ExpCount_3_MVP, ExpCount_3_Leader_MVP },
                                         { ExpCount_4_Normal, ExpCount_4_Leader, ExpCount_4_MVP, ExpCount_4_Leader_MVP },
                                         { ExpCount_5_Normal, ExpCount_5_Leader, ExpCount_5_MVP, ExpCount_5_Leader_MVP } };
            NumericUpDown[] TargetLevelList = { LevelingCalcTargetLevel1, LevelingCalcTargetLevel2, LevelingCalcTargetLevel3, LevelingCalcTargetLevel4, LevelingCalcTargetLevel5 };
            NumericUpDown[] NowExpList = { LevelingCalcNowExp1, LevelingCalcNowExp2, LevelingCalcNowExp3, LevelingCalcNowExp4, LevelingCalcNowExp5 };
            NumericUpDown[] DummyCountList = { DummyCount1, DummyCount2, DummyCount3, DummyCount4, DummyCount5 };
            int[] SimulationExp = { 20000, 80000, 240000 };

            try
            {

                string WarType = "";
                int[,] ExpCount = new int[5, 4];

                foreach (RadioButton rb in WarTypeSelectors)
                {
                    if (rb.Checked == true) WarType = (string)rb.Tag;
                }

                if ((((SimulationTypeSelector.Text == null) || (SimulationTypeSelector.Text == "")) && (WarType == "Simulation")) || (((RealWarTypeSelector.Text == null) || (RealWarTypeSelector.Text == "")) && (WarType == "RealWar"))) return;

                int[] RequireExp = new int[5];

                for (int i = 0; i < 5; ++i) RequireExp[i] = ETC.LevelExp[Convert.ToInt32(TargetLevelList[i].Value) - 1] - Convert.ToInt32(NowExpList[i].Value);

                int enabled_count = 0;
                foreach (Panel p in DollPanels) if (p.Enabled == true) enabled_count += 1;

                switch (WarType)
                {
                    case "Simulation":
                        int DollExp = Convert.ToInt32(Math.Ceiling(SimulationExp[SimulationTypeSelector.SelectedIndex] / (double)enabled_count));
                        for (int i = 0; i < 5; ++i)
                        {
                            for (int j = 0; j < 4; ++j)
                            {
                                if (DollPanels[i].Enabled == false) ExpCountOutputs[i, j].Text = "x";
                                else ExpCountOutputs[i, j].Text = (Math.Ceiling(RequireExp[i] / (double)DollExp)).ToString();
                            }
                        }
                        break;
                    case "RealWar":
                        DataRow dr = ETC.FindDataRow(ETC.FreeOPList, "Location", RealWarTypeSelector.Text);
                        int warCount = Convert.ToInt32(RequireCountPerOnce.Value);

                        for (int i = 0; i < enabled_count; ++i)
                        {
                            int TargetLv = Convert.ToInt32(TargetLevelList[i].Value);
                            int nowExp = Convert.ToInt32(NowExpList[i].Value);
                            int DummyCount = Convert.ToInt32(DummyCountList[i].Value);

                            ExpCountOutputs[i, 0].Text = CalcTotalCount(dr, TargetLv, nowExp, DummyCount, warCount, false, false).ToString();
                            ExpCountOutputs[i, 1].Text = CalcTotalCount(dr, TargetLv, nowExp, DummyCount, warCount, true, false).ToString();
                            ExpCountOutputs[i, 2].Text = CalcTotalCount(dr, TargetLv, nowExp, DummyCount, warCount, false, true).ToString();
                            ExpCountOutputs[i, 3].Text = CalcTotalCount(dr, TargetLv, nowExp, DummyCount, warCount, true, true).ToString();
                        }
                        for (int j = enabled_count; j < DollPanels.Length; ++j)
                        {
                            ExpCountOutputs[j, 0].Text = "x";
                            ExpCountOutputs[j, 1].Text = "x";
                            ExpCountOutputs[j, 2].Text = "x";
                            ExpCountOutputs[j, 3].Text = "x";
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private int CalcTotalCount(DataRow OPLocation, int TargetLevel, int nowExp, int Dummy, int WarCount, bool IsLeader, bool IsMVP)
        {
            try
            {
                const double LeaderRate = 1.2;
                const double MVPRate = 1.3;
                int PaneltyLevel = (int)OPLocation["PaneltyLevel"];
                int targetExp = ETC.LevelExp[TargetLevel - 1];
                int EarnExp = 0;
                int TotalCount = 0;

                while (nowExp < targetExp)
                {
                    int NowLevel = 0;

                    for (int i = 0; i < ETC.LevelExp.Length; ++i)
                    {
                        int exp = ETC.LevelExp[i];

                        if ((exp - nowExp) == 0)
                        {
                            NowLevel = i + 1;
                            break;
                        }
                        else if ((exp - nowExp) > 0)
                        {
                            NowLevel = i;
                            break;
                        }
                    }

                    if (AutoAddDummySet.Checked == true)
                    {
                        if ((NowLevel >= 1) && (NowLevel < 10)) Dummy = 1;
                        else if ((NowLevel >= 10) && (NowLevel < 30)) Dummy = 2;
                        else if ((NowLevel >= 30) && (NowLevel < 70)) Dummy = 3;
                        else if ((NowLevel >= 70) && (NowLevel < 90)) Dummy = 4;
                        else if (NowLevel >= 90) Dummy = 5;
                        else Dummy = 1;
                    }

                    if (NowLevel >= (PaneltyLevel + 40)) EarnExp = 5;
                    else
                    {
                        EarnExp = (int)OPLocation["EXP"];

                        EarnExp = Convert.ToInt32(Math.Ceiling(EarnExp * (1 + (0.5 * (Dummy - 1)))));

                        double PaneltyRate = 1;

                        if ((NowLevel >= (PaneltyLevel + 1)) && (NowLevel < (PaneltyLevel + 10))) PaneltyRate = 0.8;
                        else if ((NowLevel >= (PaneltyLevel + 10)) && (NowLevel < (PaneltyLevel + 20))) PaneltyRate = 0.6;
                        else if ((NowLevel >= (PaneltyLevel + 20)) && (NowLevel < (PaneltyLevel + 30))) PaneltyRate = 0.4;
                        else if ((NowLevel >= (PaneltyLevel + 30)) && (NowLevel < (PaneltyLevel + 40))) PaneltyRate = 0.2;

                        EarnExp = Convert.ToInt32(Math.Ceiling(EarnExp * PaneltyRate));

                        if (IsLeader == true) EarnExp = Convert.ToInt32(Math.Ceiling(EarnExp * LeaderRate));
                        if (IsMVP == true) EarnExp = Convert.ToInt32(Math.Ceiling(EarnExp * MVPRate));
                    }

                    nowExp += (EarnExp * WarCount);
                    TotalCount += 1;
                }

                return TotalCount;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return -1;
        }

        private void DollSimulationResetUseButton_Click(object sender, EventArgs e)
        {
            Label[] UseStatus = { DollSimulationUseManPower, DollSimulationUseAmmo, DollSimulationUseFood, DollSimulationUseParts };
            Label[] ProductStatus = { DollSimulation2StarStatus, DollSimulation3StarStatus, DollSimulation4StarStatus, DollSimulation5StarStatus };

            try
            {
                foreach (Label lb in UseStatus) lb.Text = "0";
                foreach (Label lb in ProductStatus) lb.Text = "0";
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void ProductSimulEquipmentProductType_CheckedChanged(object sender, EventArgs e)
        {
            NumericUpDown[] ProductResourceList = { ProductSimulEquipmentManpowerCount, ProductSimulEquipmentAmmoCount, ProductSimulEquipmentFoodCount, ProductSimulEquipmentPartsCount };

            try
            {
                RadioButton rb = (RadioButton)sender;

                if (rb.Checked == false) return;

                switch ((string)rb.Tag)
                {
                    case "Normal":
                        IsEquipAdvanceProduct = false;
                        foreach (NumericUpDown nud in ProductResourceList)
                        {
                            nud.Minimum = 10;
                            nud.Maximum = 300;
                            nud.Value = nud.Minimum;
                        }
                        ProductSimulEquipmentAdvanceProductTypeGroup.Visible = false;
                        break;
                    case "Advance":
                        IsEquipAdvanceProduct = true;
                        foreach (NumericUpDown nud in ProductResourceList)
                        {
                            nud.Minimum = 500;
                            nud.Maximum = 5000;
                            nud.Value = nud.Minimum;
                        }
                        ProductSimulEquipmentAdvanceProductTypeGroup.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void ProductSimulEquipmentProductButton_Click(object sender, EventArgs e)
        {
            Control[] ResultControls = { ProductEquipmentResultGradeStar1, ProductEquipmentResultGradeStar2, ProductEquipmentResultGradeStar3, ProductEquipmentResultGradeStar4, ProductEquipmentResultGradeStar5, ProductEquipmentResultBackgroundPanel };

            try
            {
                ((Button)sender).Enabled = false;

                foreach (Control c in ResultControls)
                {
                    c.Visible = false;
                    if (c is PictureBox) ((PictureBox)c).Image = null;
                    if (c is Label) ((Label)c).Text = "";
                }

                ArrayList AvailableType = new ArrayList();
                ArrayList AvailableEquipment = new ArrayList();
                ArrayList AvailableFairyType = new ArrayList();
                ArrayList AvailableFairy = new ArrayList();

                int pManPower = Convert.ToInt32(ProductSimulEquipmentManpowerCount.Value);
                int pAmmo = Convert.ToInt32(ProductSimulEquipmentAmmoCount.Value);
                int pFood = Convert.ToInt32(ProductSimulEquipmentFoodCount.Value);
                int pParts = Convert.ToInt32(ProductSimulEquipmentPartsCount.Value);

                EquipmentSimulationUseManPower.Text = (Int32.Parse(EquipmentSimulationUseManPower.Text) + pManPower).ToString();
                EquipmentSimulationUseAmmo.Text = (Int32.Parse(EquipmentSimulationUseAmmo.Text) + pAmmo).ToString();
                EquipmentSimulationUseFood.Text = (Int32.Parse(EquipmentSimulationUseFood.Text) + pFood).ToString();
                EquipmentSimulationUseParts.Text = (Int32.Parse(EquipmentSimulationUseParts.Text) + pParts).ToString();

                
                switch (IsEquipAdvanceProduct)
                {
                    case false:
                        if ((pAmmo <= 150) && (pParts <= 150)) AvailableType.AddRange(new string[] { "옵티컬(광학조준경)", "이오텍(홀로그래픽 조준기)", "레드 닷 조준기" });
                        if ((pManPower >= 50) && (pFood >= 100)) AvailableType.Add("야시장비");
                        if (pManPower >= 50) AvailableType.Add("소음기");
                        if ((pAmmo >= 150) && (pParts >= 50)) AvailableType.AddRange(new string[] { "고속탄", "철갑탄", "HP탄", "벅샷", "슬러그" });
                        if ((pManPower >= 50) && (pParts >= 50)) AvailableType.AddRange(new string[] { "외골격T", "외골격X" });
                        if ((pManPower >= 50) && (pFood >= 50) && (pParts >= 50)) AvailableType.Add("방탄판");
                        if (pParts >= 150) AvailableType.Add("탄약통");
                        if ((pManPower >= 100) && (pFood >= 100)) AvailableType.Add("슈트");
                        break;
                    case true:
                        AvailableType.AddRange(new string[] { "옵티컬(광학조준경)", "이오텍(홀로그래픽 조준기)", "레드 닷 조준기", "야시장비", "소음기", "외골격T", "외골격X", "방탄판", "슈트" });
                        if ((pAmmo >= 2500) || (pParts >= 2500)) AvailableType.AddRange(new string[] { "고속탄", "철갑탄", "HP탄", "벅샷", "슬러그", "탄약통" });
                        AvailableFairyType.AddRange(new string[] { "용사요정", "격노요정", "방패요정", "수호요정", "도발요정", "저격요정", "포격요정", "공습요정", "지휘요정", "수색요정", "조명요정" });
                        if ((pManPower >= 2000) && (pFood >= 2000) && (pParts >= 1000)) AvailableFairyType.AddRange(new string[] { "증원요정", "공수요정", "방어요정" });
                        if ((pAmmo >= 2000) && (pFood >= 2000) && (pParts >= 1000)) AvailableFairyType.AddRange(new string[] { "매설요정", "로켓요정", "공사요정" });
                        break;
                }

                AvailableType.TrimToSize();
                AvailableFairyType.TrimToSize();

                foreach (string s in AvailableType)
                {
                    for (int i = 2; i <= 5; ++i)
                    {
                        DataRow dr = ETC.FindDataRow(ETC.EquipmentList, "Type", "Grade", s, i);
                        if (dr == null) continue;
                        if (dr["OnlyUse"] != DBNull.Value)
                        {
                            if ((string)dr["OnlyUse"] != "") continue;
                        }
                        AvailableEquipment.Add(dr);
                    }
                }

                foreach (string s in AvailableFairyType)
                {
                    DataRow dr = ETC.FindDataRow(ETC.FairyList, "Name", s);
                    if (dr == null) continue;
                    AvailableFairy.Add(dr);
                }

                AvailableEquipment.TrimToSize();
                AvailableFairy.TrimToSize();

                object[] Result = await ProductProcess_Equipment(AvailableEquipment, AvailableFairy, pManPower, pAmmo, pFood, pParts);
                DataRow ResultDR = (DataRow)Result[0];

                if (ResultDR == null)
                {
                    ProductSimulDollProductButton.Text = "제조 불가";
                    await Task.Delay(1000);
                    ProductSimulDollProductButton.Text = "제조 시작";
                    return;
                }

                await PrintProductEquipmentResult(ResultDR, (bool)Result[1]);

                ((Button)sender).Enabled = true;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async Task<object[]> ProductProcess_Equipment(ArrayList AvailableEquipment, ArrayList AvailableFairy, int num1, int num2, int num3, int num4)
        {
            await Task.Delay(100);

            try
            {
                Random R = new Random();
                int seed_num1 = (num1 + num2 + num3 + num4) / ((AvailableEquipment.Count + AvailableFairy.Count));
                int seed_num2 = (num1 + num2 + num3 + num4);

                int[] tP = { 49, 30, 15, 6 };
                int[] tAP1 = { 40, 22, 11, 27 };
                int[] tAP2 = { 0, 45, 18, 37 };
                int[] tAP3 = { 0, 27, 26, 47 };
                int ConfirmGrade = 0;

                int mag = 1;
                int[] P = null;

                switch (IsEquipAdvanceProduct)
                {
                    case false:
                        P = new int[4];
                        for (int k = 0; k < tP.Length; ++k)
                        {
                            P[k] = tP[k] * mag;
                        }
                        break;
                    case true:
                        P = new int[4];
                        switch (EquipAdvanceProductTypeNum)
                        {
                            case 1:
                                for (int k = 0; k < tAP1.Length; ++k) P[k] = tAP1[k] * mag;
                                break;
                            case 2:
                                for (int k = 0; k < tAP2.Length; ++k) P[k] = tAP2[k] * mag;
                                break;
                            case 3:
                                for (int k = 0; k < tAP3.Length; ++k) P[k] = tAP3[k] * mag;
                                break;
                        }
                        break;
                }

                int num = R.Next(seed_num1, seed_num2 * mag) % (100 * mag);

                switch (IsEquipAdvanceProduct)
                {
                    case false:
                        if ((num >= 0) && (num < P[0])) ConfirmGrade = 2;
                        else if ((num >= P[0]) && (num < (P[0] + P[1]))) ConfirmGrade = 3;
                        else if ((num >= (P[0] + P[1])) && (num >= (P[0] + P[1] + P[2]))) ConfirmGrade = 4;
                        else ConfirmGrade = 5;
                        break;
                    case true:
                        if ((num >= 0) && (num < P[0])) ConfirmGrade = 3;
                        else if ((num >= P[0]) && (num < (P[0] + P[1]))) ConfirmGrade = 4;
                        else if ((num >= (P[0] + P[1])) && (num >= (P[0] + P[1] + P[2]))) ConfirmGrade = 5;
                        else ConfirmGrade = 6;
                        break;
                }


                if (ConfirmGrade == 0)
                {
                    if (IsEquipAdvanceProduct == false) ConfirmGrade = 2;
                    else if ((EquipAdvanceProductTypeNum == 2) || (EquipAdvanceProductTypeNum == 3)) ConfirmGrade = 4;
                    else ConfirmGrade = 3;
                }

                ArrayList FinalResult = new ArrayList();
                int tArrange = 0;

                if (ConfirmGrade == 6)
                {
                    foreach (DataRow dr in AvailableFairy)
                    {
                        FinalResult.Add(dr);

                        int tcount = 0;
                        if ((dr["ProductionPercent"] == DBNull.Value) || (dr["AdvanceProductionPercent"] == DBNull.Value)) tcount = 100;
                        else
                        {
                            if (IsEquipAdvanceProduct == false) tcount += (int)dr["ProductionPercent"];
                            else tcount += (int)dr["AdvanceProductionPercent"];
                        }

                        tArrange += tcount;
                    }
                }
                else
                {
                    foreach (DataRow dr in AvailableEquipment)
                    {
                        if ((int)dr["Grade"] == ConfirmGrade)
                        {
                            FinalResult.Add(dr);

                            int tcount = 0;
                            if ((dr["ProductionPercent"] == DBNull.Value) || (dr["AdvanceProductionPercent"] == DBNull.Value)) tcount = 100;
                            else
                            {
                                if (IsEquipAdvanceProduct == false) tcount += (int)dr["ProductionPercent"];
                                else tcount += (int)dr["AdvanceProductionPercent"];
                            }

                            tArrange += tcount;
                        }
                    }
                }
                
                FinalResult.TrimToSize();

                int fnum = R.Next(1, tArrange);
                int count = 0;
                DataRow Result = null;

                foreach (DataRow dr in FinalResult)
                {
                    int count2 = count;

                    if ((dr["ProductionPercent"] == DBNull.Value) || (dr["AdvanceProductionPercent"] == DBNull.Value)) count2 += 100;
                    else
                    {
                        if (IsEquipAdvanceProduct == false) count2 += (int)dr["ProductionPercent"];
                        else count2 += (int)dr["AdvanceProductionPercent"];
                    }

                    if ((fnum > count) && (fnum <= count2))
                    {
                        Result = dr;
                        break;
                    }

                    count = count2;
                }

                bool IsFairy = false;

                if (ConfirmGrade == 6) IsFairy = true;
                else IsFairy = false;

                return new object[] { Result, IsFairy };
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }

            return null;
        }

        private async Task PrintProductEquipmentResult(DataRow dr, bool IsFairy)
        {
            await Task.Delay(100);

            PictureBox[] GradeStars = { ProductEquipmentResultGradeStar1, ProductEquipmentResultGradeStar2, ProductEquipmentResultGradeStar3, ProductEquipmentResultGradeStar4, ProductEquipmentResultGradeStar5 };
            Label[] GradeStatus = { EquipmentSimulation2StarStatus, EquipmentSimulation3StarStatus, EquipmentSimulation4StarStatus, EquipmentSimulation5StarStatus, EquipmentSimulationFairyStatus };

            try
            {
                Image grade_image = null;

                if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1) grade_image = GradeImageList.Images["Grade_Star.png"];
                else grade_image = Image.FromFile(Path.Combine(ImagePath, "GradeImage", "Grade_Star.png"));

                string rName = (string)dr["Name"];
                string rType = (string)dr["Type"];
                int rGrade = 0;

                if (IsFairy == true) rGrade = 6;
                else rGrade = (int)dr["Grade"];

                for (int i = 0; i < rGrade; ++i)
                {
                    if (i == 5) break;
                    GradeStars[i].Visible = true;

                    int x = 70;
                    int y = 70;

                    GradeStars[i].Size = new Size(x, y);
                    GradeStars[i].Image = grade_image;

                    for (int j = 1; j <= 40; ++j)
                    {
                        GradeStars[i].Size = new Size(x - j, y - j);
                        await Task.Delay(1);
                    }

                    /*for (int j = 0; j < 8; ++j)
                    {
                        grade_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        GradeStars[i].Image = grade_image;

                        await Task.Delay(50);
                    }*/
                }

                GradeStatus[rGrade - 2].Text = (Int32.Parse(GradeStatus[rGrade - 2].Text) + 1).ToString();
                
                await Task.Delay(500);

                string ResultImage = "";
                if (rGrade == 6) ResultImage = rName + "_1.png";
                else ResultImage = (string)dr["Icon"] + ".png";

                string ResultBG = "";
                if (rGrade == 6) ResultBG = "BG_Grade_5.png";
                else ResultBG = "BG_Grade_" + rGrade+ ".png";

                ProductEquipmentResultName.Text = rName;
                if (dr["ProductDialog"] == DBNull.Value) ProductEquipmentResultDialogText.Text = "";
                else ProductEquipmentResultDialogText.Text = (string)dr["ProductDialog"];
                ProductEquipmentResultDialog.Visible = true;
                ProductEquipmentResultName.Visible = true;

                ProductEquipmentResultBackgroundPanel.BackgroundImage = Image.FromFile(Path.Combine(ImagePath, "BG", ResultBG));
                if ((int)DicGeneralSetting.GetValue("ImagePreLoad", 1) == 1)
                {
                    ProductEquipmentResultImageBox.Image = EquipmentImageList.Images[ResultImage];
                }
                else
                {
                    if (rGrade == 6) ProductEquipmentResultImageBox.Image = Image.FromFile(Path.Combine(ImagePath, "Fairy", ResultImage));
                    else ProductEquipmentResultImageBox.Image = Image.FromFile(Path.Combine(ImagePath, "Equipment", ResultImage));
                }

                ProductEquipmentResultBackgroundPanel.Visible = true;

                await Task.Delay(500);

                ProductEquipmentResultImageBox.Visible = true;
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void EquipmentSimulationResetUseButton_Click(object sender, EventArgs e)
        {
            Label[] UseStatus = { EquipmentSimulationUseManPower, EquipmentSimulationUseAmmo, EquipmentSimulationUseFood, EquipmentSimulationUseParts };
            Label[] ProductStatus = { EquipmentSimulation2StarStatus, EquipmentSimulation3StarStatus, EquipmentSimulation4StarStatus, EquipmentSimulation5StarStatus, EquipmentSimulationFairyStatus };

            try
            {
                foreach (Label lb in UseStatus) lb.Text = "0";
                foreach (Label lb in ProductStatus) lb.Text = "0";
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void ProductSimulEquipmentAdvanceProductType_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = (RadioButton)sender;
                if (rb.Checked == false) return;
                EquipAdvanceProductTypeNum = Convert.ToInt32(rb.Tag);
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async void DollSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            while (IsListing) await Task.Delay(1);

            try
            {
                IsListing = true;
                if (DollSearchTextBox.Text != null) await ListDoll(DollSearchTextBox.Text);
            }
            finally
            {
                IsListing = false;
            }
        }

        private async void EquipmentDicSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            while (IsListing) await Task.Delay(1);

            try
            {
                IsListing = true;
                if (EquipmentDicSearchTextBox.Text != null) await ListEquipment(EquipmentDicSearchTextBox.Text);
            }
            finally
            {
                IsListing = false;
            }
        }

        private async void FairyDicSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            while (IsListing) await Task.Delay(1);

            try
            {
                IsListing = true;
                if (FairyDicSearchTextBox.Text != null) await ListFairy(FairyDicSearchTextBox.Text);
            }
            finally
            {
                IsListing = false;
            }
        }

        private async void ImageLoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                await PlaceLoadingAnimation(0);

                if (String.IsNullOrEmpty(PlaceSelector.Text) == true) return;

                string place = PlaceSelector.Text;
                string imagePath = Path.Combine(ETC.ImageServer, "Maps", "Original", place + ".png");

                PlaceViewerBox.ImageLocation = imagePath;
                if (ImageSettingGroup.Enabled == false) ImageSettingGroup.Enabled = true;
                ImageModeSelector.SelectedIndex = 4;

                await Task.Delay(500);

                await PlaceLoadingAnimation(1);
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async Task PlaceLoadingAnimation(int mode)
        {
            PlaceLoadImageBox1.Image = Image.FromFile(Path.Combine(ImagePath, "ETC", "Loading_Up.png"));
            PlaceLoadImageBox2.Image = Image.FromFile(Path.Combine(ImagePath, "ETC", "Loading_Down.png"));

            switch (mode)
            {
                case 0:
                    PlaceLoadPanel.Visible = true;
                    for (int i = 1; i <= 56; ++i)
                    {
                        PlaceLoadImageBox1.Height = i * 4;
                        PlaceLoadImageBox2.Height = i * 4;
                        await Task.Delay(1);
                    }
                    break;
                case 1:
                    for (int i = 56; i >= 0; --i)
                    {
                        PlaceLoadImageBox1.Height = i * 4;
                        PlaceLoadImageBox2.Height = i * 4;
                        await Task.Delay(1);
                    }
                    //PlaceLoadPanel.Visible = false;
                    break;
            }
        }

        private void ImageModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (((ComboBox)sender).Text)
                {
                    case "일반":
                        PlaceViewerBox.SizeMode = PictureBoxSizeMode.Normal;
                        break;
                    case "늘이기":
                        PlaceViewerBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case "자동":
                        PlaceViewerBox.SizeMode = PictureBoxSizeMode.AutoSize;
                        break;
                    case "가운데":
                        PlaceViewerBox.SizeMode = PictureBoxSizeMode.CenterImage;
                        break;
                    case "확대":
                        PlaceViewerBox.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    default:
                        PlaceViewerBox.SizeMode = PictureBoxSizeMode.Normal;
                        break;
                }

            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void PrintRecommendMDButton_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList RankMDList = RankProcess();

                ListRankMD(RankMDList);
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void ListRankMD(ArrayList list)
        {
            RankMDListView.Items.Clear();

            int rank = 0;

            foreach (string s in list)
            {
                rank += 1;

                string location = s.Split(';')[0];
                string score = s.Split(';')[1];

                DataRow dr = ETC.FindDataRow(ETC.MDSupportDT, "Location", location);

                string level = ((int)dr["Min Level"]).ToString();
                string time = ETC.CalcTime((int)dr["Time"]);
                string resources = (int)dr["ManPower"] + "/" + (int)dr["Ammo"] + "/" + (int)dr["Food"] + "/" + (int)dr["Parts"];
                string extras = "";

                if (dr["Ticket"] != DBNull.Value) extras = (string)dr["Ticket"];

                RankMDListView.Items.Add(new ListViewItem(new string[] { rank.ToString(), location, level, time, resources, extras}));
            }
        }

        private ArrayList RankProcess()
        {
            ArrayList TotalScoreList = new ArrayList(10);

            double[] InitMag = ETC.CalcWeight(Convert.ToInt32(ManPowerNowCount.Value), Convert.ToInt32(AmmoNowCount.Value), Convert.ToInt32(FoodNowCount.Value), Convert.ToInt32(PartsNowCount.Value));

            double ManPowerMag = InitMag[0] + Convert.ToDouble(ManPowerWeight.Value);
            double AmmoMag = InitMag[1] + Convert.ToDouble(AmmoWeight.Value);
            double FoodMag = InitMag[2] + Convert.ToDouble(FoodWeight.Value);
            double PartsMag = InitMag[3] + Convert.ToDouble(PartsWeight.Value);

            for (int i = 0; i < ETC.MDSupportDT.Rows.Count; ++i)
            {
                DataRow dr = ETC.MDSupportDT.Rows[i];

                ArrayList Extra = new ArrayList();

                if (dr["Ticket"] != DBNull.Value) Extra.AddRange(((string)dr["Ticket"]).Split(',', ' '));

                bool IsSkip = false;

                foreach (string s in Extra)
                {
                    switch (s)
                    {
                        case "쾌속수복계약":
                            if (RecoveryTicketSetting.Checked == false) IsSkip = true;
                            break;
                        case "쾌속제조계약":
                            if (ProductTicketSetting.Checked == false) IsSkip = true;
                            break;
                        case "인형제조계약":
                            if (DollTicketSetting.Checked == false) IsSkip = true;
                            break;
                        case "장비제조계약":
                            if (EquipTicketSetting.Checked == false) IsSkip = true;
                            break;
                        case "구매토큰":
                            if (TokenSetting.Checked == false) IsSkip = true;
                            break;
                        default:
                            IsSkip = false;
                            break;
                    }
                }

                int h_time = ((int)dr["Time"]) / 60;
                if ((Convert.ToInt32(TimeRestrictOutputMin.Value) > h_time) || (Convert.ToInt32(TimeRestrictOutputMax.Value) < h_time)) IsSkip = true;

                int t_level = (int)dr["Min Level"];
                if ((Convert.ToInt32(LevelRestrictOutputMin.Value) > t_level) || (Convert.ToInt32(LevelRestrictOutputMax.Value) < t_level)) IsSkip = true;


                if (IsSkip == true) continue;

                StringBuilder sb = new StringBuilder();

                sb.Append((string)dr["Location"]);
                sb.Append(';');

                double tManPower = 0;
                double tAmmo = 0;
                double tFood = 0;
                double tParts = 0;

                if (PerTimeNo.Checked)
                {
                    tManPower = (int)dr["ManPower"];
                    tAmmo = (int)dr["Ammo"];
                    tFood = (int)dr["Food"];
                    tParts = (int)dr["Parts"];
                }
                else if (PerTimeYes.Checked)
                {
                    double MDTime = (int)dr["Time"];

                    tManPower = (int)dr["ManPower"] / MDTime;
                    tAmmo = (int)dr["Ammo"] / MDTime;
                    tFood = (int)dr["Food"] / MDTime;
                    tParts = (int)dr["Parts"] / MDTime;
                }

                double fManPower = tManPower * (1 + ManPowerMag);
                double fAmmo = tAmmo * (1 + AmmoMag);
                double fFood = tFood * (1 + FoodMag);
                double fParts = tParts * (1 + PartsMag);

                double Score = 0;

                if (ExceptManPowerSetting.Checked == false) Score += fManPower;
                if (ExceptAmmoSetting.Checked == false) Score += fAmmo;
                if (ExceptFoodSetting.Checked == false) Score += fFood;
                if (ExceptPartsSetting.Checked == false) Score += fParts;

                sb.Append(Score.ToString("F2"));
                TotalScoreList.Add(sb.ToString());
            }

            TotalScoreList.TrimToSize();

            ArrayList RankList = new ArrayList();
            RankList.TrimToSize();

            foreach (string s in TotalScoreList)
            {
                string place = s.Split(';')[0];
                double score = double.Parse(s.Split(';')[1]);

                if (RankList.Count == 0) RankList.Add(s);
                else
                {
                    for (int i = 0; i < RankList.Count; ++i)
                    {
                        string tplace = ((string)RankList[i]).Split(';')[0];
                        double tscore = double.Parse(((string)RankList[i]).Split(';')[1]);

                        if (tscore < score)
                        {
                            RankList.Insert(i, s);
                            break;
                        }
                        else if (tscore == score)
                        {
                            DataRow tdr = ETC.FindDataRow(ETC.MDSupportDT, "Location", tplace);
                            DataRow dr = ETC.FindDataRow(ETC.MDSupportDT, "Location", place);
                            
                            if ((int)dr["Time"] >= (int)tdr["Time"])
                            {
                                RankList.Insert(i, s);
                                break;
                            }
                        }

                        if (i == (RankList.Count - 1))
                        {
                            RankList.Add(s);
                            break;
                        }
                    }
                }

                RankList.TrimToSize();
            }

            return RankList;
        }

        private void 피드백보내기FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSdlAqftvESIAemyMg9mPBAS2NcuF732K-5us50w0SGJQR6o9g/viewform?usp=pp_url&entry.1054939332&entry.705356667");
        }

        private void FreeOPMinMUUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (FreeOPMaxMUUpDown.Value < ((NumericUpDown)sender).Value) FreeOPMaxMUUpDown.Value = ((NumericUpDown)sender).Value;
        }

        private void FreeOPMinLevelUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (FreeOPMaxLevelUpDown.Value < ((NumericUpDown)sender).Value) FreeOPMaxLevelUpDown.Value = ((NumericUpDown)sender).Value;
        }

        private void DollSkillInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                SkillViewer sv = new SkillViewer(DollNameLabel.Text, Convert.ToInt32(DollModStatus.Tag));
                sv.ShowDialog();
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void DollSearchSetting_CheckedChanged(object sender, EventArgs e)
        {
            DollSearchTextBox_TextChanged(sender, e);
        }

        private void EquipmentDicSearchSetting_CheckedChanged(object sender, EventArgs e)
        {
            EquipmentDicSearchTextBox_TextChanged(sender, e);
        }

        private void FairyDicSearchSetting_CheckedChanged(object sender, EventArgs e)
        {
            FairyDicSearchTextBox_TextChanged(sender, e);
        }

        private async void EnemyDicEnemySearchTextBox_TextChanged(object sender, EventArgs e)
        {
            while (IsListing) await Task.Delay(1);

            try
            {
                IsListing = true;
                if (EnemyDicEnemySearchTextBox.Text != null) await ListEnemy(EnemyDicEnemySearchTextBox.Text);
            }
            finally
            {
                IsListing = false;
            }
        }

        private void Weight_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown[] CustomWeightControls = { ManPowerWeight, AmmoWeight, FoodWeight, PartsWeight };
            Label[] WeightCountControls = { ManPowerWeightNow, AmmoWeightNow, FoodWeightNow, PartsWeightNow };

            try
            {
                double[] InitMag = ETC.CalcWeight(Convert.ToInt32(ManPowerNowCount.Value), Convert.ToInt32(AmmoNowCount.Value), Convert.ToInt32(FoodNowCount.Value), Convert.ToInt32(PartsNowCount.Value));

                for (int i = 0; i < WeightCountControls.Length; ++i)
                {
                    double value = InitMag[i] + Convert.ToDouble(CustomWeightControls[i].Value);
                    WeightCountControls[i].Text = value.ToString("F2");

                    if (value > 0) WeightCountControls[i].ForeColor = Color.Blue;
                    else if (value == 0) WeightCountControls[i].ForeColor = Color.Gray;
                    else WeightCountControls[i].ForeColor = Color.Crimson;
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void DollModSelector_Click(object sender, EventArgs e)
        {
            string[] ModList = { "Normal", "Mod1", "Mod2", "Mod3" };
            Button bt = sender as Button;

            int index = (int)DollModStatus.Tag;

            if (bt == DollModSelectorNext)
            {
                switch (index)
                {
                    case 0:
                    case 1:
                    case 2:
                        index += 1;
                        break;
                    case 3:
                        index = 0;
                        break;
                }
            }
            else if (bt == DollModSelectorPrevious)
            {
                switch (index)
                {
                    case 0:
                        index = 3;
                        break;
                    case 1:
                    case 2:
                    case 3:
                        index -= 1;
                        break;
                }
            }

            DollModStatus.Tag = index;
            DollModStatus.Text = ModList[index];

            PrintDollInfo(DollNameLabel.Text, index);
        }

        private void ExpItemCalcApplyVow_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            CalcExp(cb.Checked);
        }

        private void ExpItemCalcModSwitch_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            switch (cb.Checked)
            {
                case false:
                    ExpItemCalcApplyVow.Checked = false;
                    ExpItemCalcApplyVow.Enabled = false;
                    ExpItemCalcApplyVow.Visible = false;

                    ExpStartLevel.Minimum = 1;
                    ExpEndLevel.Minimum = 1;
                    ExpStartLevel.Maximum = ExpEndLevel.Minimum;
                    ExpEndLevel.Maximum = 100;
                    break;
                case true:
                    ExpItemCalcApplyVow.Enabled = true;
                    ExpItemCalcApplyVow.Visible = true;

                    ExpStartLevel.Minimum = 100;
                    ExpEndLevel.Minimum = 100;
                    ExpStartLevel.Maximum = ExpEndLevel.Minimum;
                    ExpEndLevel.Maximum = 120;
                    break;
            }

            CalcExp(ExpItemCalcApplyVow.Checked);
        }

        private void CalcChart(Chart AbilityChart, DataRow dr, int mode_index)
        {
            string[] Abilities = { "HP", "화력", "회피", "명중", "공속" };
            string[] Index_Abilities = { "HP", "FireRate", "Evasion", "Accuracy", "AttackSpeed" };

            try
            {
                string type = (string)dr["Type"];
                int[] D_Ability = new int[Index_Abilities.Length];

                for (int i = 0; i < Index_Abilities.Length; ++i)
                {
                    switch (mode_index)
                    {
                        case 0:
                            D_Ability[i] = int.Parse(((string)dr[Index_Abilities[i]]).Split(';')[mode_index].Split('/')[1]);
                            break;
                        case 1:
                        case 2:
                        case 3:
                            D_Ability[i] = int.Parse(((string)dr[Index_Abilities[i]]).Split(';')[mode_index]);
                            break;
                    }
                }

                int[] Avg_Ability = new int[Index_Abilities.Length];
                int DollCount = 0;

                foreach (DataRow t_dr in ETC.DollList.Rows)
                {
                    if ((string)t_dr["Type"] != type) continue;

                    for (int i = 0; i < Index_Abilities.Length; ++i)
                    {
                        switch ((bool)t_dr["HasMod"])
                        {
                            case true:
                                Avg_Ability[i] += int.Parse(((string)t_dr[Index_Abilities[i]]).Split(';')[0].Split('/')[1]);
                                break;
                            case false:
                                Avg_Ability[i] += int.Parse(((string)t_dr[Index_Abilities[i]]).Split('/')[1]);
                                break;
                        }
                    }

                    DollCount += 1;
                }

                for (int i = 0; i < Index_Abilities.Length; ++i)
                {
                    Avg_Ability[i] = Convert.ToInt32(Math.Round((Double)Avg_Ability[i] / DollCount));
                }

                AbilityChart.Series["인형"].Points.DataBindXY(Abilities, D_Ability);
                AbilityChart.Series["평균"].Points.DataBindXY(Abilities, Avg_Ability);
            }
            catch (Exception ex)
            {
                ETC.LogError(ex.ToString());
                ETC.ErrorMessage(ex.Message);
            }
        }

        private void DollAbilityChartButton_Click(object sender, EventArgs e)
        {
            DollAbilityChartViewer cv = new DollAbilityChartViewer(ETC.FindDataRow(ETC.DollList, "Name", DollNameLabel.Text), Convert.ToInt32(DollModStatus.Tag));
            cv.Show();
        }

        private void ReinstallFSimulatorButton_Click(object sender, EventArgs e)
        {
            UpdateFSimulator();
        }

        private async void RunFSimulatorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((File.Exists(Path.Combine("GF_JdSimulator", "Version.txt")) == false) || (Directory.Exists("GF_JdSimulator") == false))
                {
                    if (MessageBox.Show("시뮬레이터 파일이 존재하지 않습니다. 다운로드 하시겠습니까?", "시뮬레이터 다운로드 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await UpdateFSimulator();
                    }
                }
                else
                {
                    int local_ver = 0;
                    int server_ver = 0;

                    using (StreamReader sr = new StreamReader(new FileStream(Path.Combine("GF_JdSimulator", "Version.txt"), FileMode.Open, FileAccess.Read)))
                    {
                        local_ver = int.Parse(sr.ReadToEnd());
                    }

                    using (WebClient wc = new WebClient())
                    {
                        server_ver = int.Parse(wc.DownloadString(Path.Combine(ETC.Server, "GFSimulVer.txt")));
                    }

                    if (local_ver < server_ver)
                    {
                        if (MessageBox.Show("시뮬레이터 파일 업데이트가 존재합니다. 업데이트 하시겠습니까?", "시뮬레이터 업데이트 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) await DownloadFSimulator();

                        await UpdateFSimulator();
                    }
                }

                /*if (Directory.Exists("GF_JdSimulator") == false)
                {
                    if (MessageBox.Show("시뮬레이터 파일이 존재하지 않습니다. 다운로드 하시겠습니까?", "시뮬레이터 다운로드 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) await DownloadFSimulator();
                    else return;

                    await UpdateFSimulator();
                }*/

                await Task.Delay(1000);

                FSimulatorDownloadStatus.Text = "시뮬레이터 실행 중";

                Process.Start(@"GF_JdSimulator\소전편성시뮬.exe");

                await Task.Delay(2000);

                FSimulatorDownloadStatus.Text = "";
            }
            catch (Exception ex)
            {
                ETC.LogError(ex.ToString());
                ETC.ErrorMessage(ex.Message);
            }
        }

        private async Task UpdateFSimulator()
        {
            await Task.Delay(500);

            FSimulatorDownloadProgressBar.Style = ProgressBarStyle.Marquee;
            FSimulatorDownloadProgressBar.MarqueeAnimationSpeed = 10;

            try
            {
                RunFSimulatorButton.Enabled = false;
                ReinstallFSimulatorButton.Enabled = false;

                await DownloadFSimulator();

                FSimulatorDownloadStatus.Text = "압축 해제 중";

                if (Directory.Exists("GF_JdSimulator_Temp") == false) Directory.CreateDirectory("GF_JdSimulator_Temp");

                await ETC.UnzipProcess("FSimulator.zip", "GF_JdSimulator_Temp");

                await Task.Delay(500);

                FSimulatorDownloadStatus.Text = "설치 중";

                FSimulatorDownloadProgressBar.Style = ProgressBarStyle.Marquee;
                await ETC.CopyFolder("GF_JdSimulator_Temp", "GF_JdSimulator");

                await Task.Delay(1000);
                FSimulatorDownloadProgressBar.Visible = false;
                FSimulatorDownloadStatus.Text = "설치 완료";
            }
            catch (Exception ex)
            {
                ETC.LogError(ex.ToString());
                ETC.ErrorMessage(ex.Message);
            }
            finally
            {
                RunFSimulatorButton.Enabled = true;
                ReinstallFSimulatorButton.Enabled = true;
                Directory.Delete("GF_JdSimulator_Temp", true);
                File.Delete("FSimulator.zip");
            }
        }

        private async Task DownloadFSimulator()
        {
            string FileURL = Path.Combine(ETC.Server, "Update", "GF_JdSimulator_PC.zip");

            FSimulatorDownloadStatus.Text = "다운로드 준비중";
            FSimulatorDownloadStatus.Visible = true;

            /*var ie = new InternetExplorer();
            var webBrowser = (IWebBrowserApp)ie;
            webBrowser.Visible = false;

            webBrowser.Navigate("https://girlsfrontline.kr/db/jdsimulator");
            await Task.Delay(5000);
            webBrowser.Quit();*/

            await Task.Delay(2000);

            using (WebClient wc = new WebClient())
            {
                await Task.Delay(500);
                FSimulatorDownloadProgressBar.Maximum = 100;
                FSimulatorDownloadProgressBar.Value = 0;
                FSimulatorDownloadProgressBar.Style = ProgressBarStyle.Continuous;
                FSimulatorDownloadProgressBar.Visible = true;

                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                await Task.Delay(100);

                await wc.DownloadFileTaskAsync(FileURL, "FSimulator.zip");

                if (Directory.Exists(Path.Combine("GF_JdSimulator")) == false) Directory.CreateDirectory(Path.Combine("GF_JdSimulator"));

                wc.DownloadFile(Path.Combine(ETC.Server, "GFSimulVer.txt"), Path.Combine("GF_JdSimulator", "Version.txt"));
            }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            FSimulatorDownloadStatus.Text = "다운로드 중...(" + e.BytesReceived + " / " + e.TotalBytesToReceive + ")";
            FSimulatorDownloadProgressBar.Value = e.ProgressPercentage;
        }

        private void ComicViewerButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            ComicViewer cv = new ComicViewer(b.Tag.ToString());
            cv.Show();
        }
        /*private void FormationSimulDollSDImage_MouseMove(object sender, MouseEventArgs e)
{
try
{
if (FormationSDBoxSelected == true)
{
PictureBox PB = (PictureBox)sender;
PB.Location = e.Location;
DoubleBuffered = true;
}
}
catch (Exception ex)
{
ETC.ErrorMessage(ex.Message);
ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
}
}

private void FormationSimulDollSDImage_MouseDown(object sender, MouseEventArgs e)
{
try
{
PictureBox PB = (PictureBox)sender;
OriginalLocation = PB.Location;
FormationSDBoxSelected = true;
}
catch (Exception ex)
{
ETC.ErrorMessage(ex.StackTrace);
ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
}
}

private void FormationSimulDollSDImage_MouseUp(object sender, MouseEventArgs e)
{
try
{
PictureBox PB = (PictureBox)sender;
PB.Location = OriginalLocation;
OriginalLocation = new Point(0, 0);
FormationSDBoxSelected = false;
}
catch (Exception ex)
{
ETC.ErrorMessage(ex.StackTrace);
ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
}
}*/
    }

    /*internal struct DollBox
    {
        internal PictureBox PB;
        internal string d_Name;
        internal int d_Num;
        internal int Row;
        internal int Column;
        internal ArrayList EffectList;
        internal string[] EquipmentList;
    }*/
    
    /*internal struct EffectInfo
    {
    	internal int EffectSourcePlace;
    	internal string EffectType;
        internal string EffectSort;
    	internal int EffectMag;
    }*/
}