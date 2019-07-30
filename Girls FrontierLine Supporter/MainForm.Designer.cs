/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2017-09-22
 * Time: 오후 8:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Girls_FrontierLine_Supporter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl MainTab;
		private System.Windows.Forms.TabPage MD;
		private System.Windows.Forms.GroupBox MDCalculator;
		private System.Windows.Forms.GroupBox MDListGroup;
		private System.Windows.Forms.TabPage Product;
		private System.Windows.Forms.TabPage FreeOperation;
		private System.Windows.Forms.TabPage ETCTab;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button MDCalcResetButton;
		private System.Windows.Forms.Button MDCalcPrintButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox Location4;
		private System.Windows.Forms.ComboBox Location3;
		private System.Windows.Forms.ComboBox Location2;
		private System.Windows.Forms.ComboBox Location1;
		private System.Windows.Forms.GroupBox ResourceResultGroup;
		private System.Windows.Forms.Label TokenResult;
		private System.Windows.Forms.Label EquipTicketResult;
		private System.Windows.Forms.Label DollTicketResult;
		private System.Windows.Forms.Label ProductionTicketResult;
		private System.Windows.Forms.Label RecoveryTicketResult;
		private System.Windows.Forms.Label TokenLabel;
		private System.Windows.Forms.Label RecoveryTicketLabel;
		private System.Windows.Forms.Label EquipTicketLabel;
		private System.Windows.Forms.Label ProductionTicketLabel;
		private System.Windows.Forms.Label DollTicketLabel;
		private System.Windows.Forms.Label TotalResult;
		private System.Windows.Forms.Label PartsResult;
		private System.Windows.Forms.Label FoodResult;
		private System.Windows.Forms.Label AmmoResult;
		private System.Windows.Forms.Label ManPowerResult;
		private System.Windows.Forms.Label TotalResourceLabel;
		private System.Windows.Forms.Label ManPowerLabel;
		private System.Windows.Forms.Label PartsLabel;
		private System.Windows.Forms.Label AmmoLabel;
		private System.Windows.Forms.Label FoodLabel;
		private System.Windows.Forms.GroupBox ExpItemCalcGroup;
		private System.Windows.Forms.Label SurplusExpCount;
		private System.Windows.Forms.Label RequireExpItemCount;
		private System.Windows.Forms.Label SurplusExpLabel;
		private System.Windows.Forms.Label RequireExpItemLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown NowExpCount;
		private System.Windows.Forms.Label NowExpLabel;
		private System.Windows.Forms.NumericUpDown ExpEndLevel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown ExpStartLevel;
		private System.Windows.Forms.Label ExpLevelLabel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTab = new System.Windows.Forms.TabControl();
            this.MD = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RankMDListView = new System.Windows.Forms.ListView();
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recommend_Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recommend_MinLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recommend_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recommend_Resource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recommend_Extra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.OutputSettingGroup = new System.Windows.Forms.GroupBox();
            this.label86 = new System.Windows.Forms.Label();
            this.LevelRestrictOutputMax = new System.Windows.Forms.NumericUpDown();
            this.LevelRestrictOutputMin = new System.Windows.Forms.NumericUpDown();
            this.label88 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TimeRestrictOutputMax = new System.Windows.Forms.NumericUpDown();
            this.TimeRestrictOutputMin = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.NowResourceSettingGroup = new System.Windows.Forms.GroupBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.PartsNowCount = new System.Windows.Forms.NumericUpDown();
            this.FoodNowCount = new System.Windows.Forms.NumericUpDown();
            this.AmmoNowCount = new System.Windows.Forms.NumericUpDown();
            this.ManPowerNowCount = new System.Windows.Forms.NumericUpDown();
            this.MDCalcModeSettingGroup = new System.Windows.Forms.GroupBox();
            this.PerTimeNo = new System.Windows.Forms.RadioButton();
            this.PerTimeYes = new System.Windows.Forms.RadioButton();
            this.PrintRecommendMDButton = new System.Windows.Forms.Button();
            this.ExceptResourceSettingGroup = new System.Windows.Forms.GroupBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.ExceptPartsSetting = new System.Windows.Forms.CheckBox();
            this.ExceptFoodSetting = new System.Windows.Forms.CheckBox();
            this.ExceptAmmoSetting = new System.Windows.Forms.CheckBox();
            this.ExceptManPowerSetting = new System.Windows.Forms.CheckBox();
            this.ExtraSettingGroup = new System.Windows.Forms.GroupBox();
            this.TokenSetting = new System.Windows.Forms.CheckBox();
            this.DollTicketSetting = new System.Windows.Forms.CheckBox();
            this.EquipTicketSetting = new System.Windows.Forms.CheckBox();
            this.ProductTicketSetting = new System.Windows.Forms.CheckBox();
            this.RecoveryTicketSetting = new System.Windows.Forms.CheckBox();
            this.ResourceWeightSettingGroup = new System.Windows.Forms.GroupBox();
            this.AmmoWeightNow = new System.Windows.Forms.Label();
            this.FoodWeightNow = new System.Windows.Forms.Label();
            this.PartsWeightNow = new System.Windows.Forms.Label();
            this.ManPowerWeightNow = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.PartsWeight = new System.Windows.Forms.NumericUpDown();
            this.FoodWeight = new System.Windows.Forms.NumericUpDown();
            this.AmmoWeight = new System.Windows.Forms.NumericUpDown();
            this.ManPowerWeight = new System.Windows.Forms.NumericUpDown();
            this.MDCalculator = new System.Windows.Forms.GroupBox();
            this.MDCalcSettingGroup = new System.Windows.Forms.GroupBox();
            this.MDCalcSettingByTime = new System.Windows.Forms.RadioButton();
            this.MDCalcSettingSum = new System.Windows.Forms.RadioButton();
            this.MDCalcResetButton = new System.Windows.Forms.Button();
            this.MDCalcPrintButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Location4 = new System.Windows.Forms.ComboBox();
            this.Location3 = new System.Windows.Forms.ComboBox();
            this.Location2 = new System.Windows.Forms.ComboBox();
            this.Location1 = new System.Windows.Forms.ComboBox();
            this.ResourceResultGroup = new System.Windows.Forms.GroupBox();
            this.TokenResult = new System.Windows.Forms.Label();
            this.EquipTicketResult = new System.Windows.Forms.Label();
            this.DollTicketResult = new System.Windows.Forms.Label();
            this.ProductionTicketResult = new System.Windows.Forms.Label();
            this.RecoveryTicketResult = new System.Windows.Forms.Label();
            this.TokenLabel = new System.Windows.Forms.Label();
            this.RecoveryTicketLabel = new System.Windows.Forms.Label();
            this.EquipTicketLabel = new System.Windows.Forms.Label();
            this.ProductionTicketLabel = new System.Windows.Forms.Label();
            this.DollTicketLabel = new System.Windows.Forms.Label();
            this.TotalResult = new System.Windows.Forms.Label();
            this.PartsResult = new System.Windows.Forms.Label();
            this.FoodResult = new System.Windows.Forms.Label();
            this.AmmoResult = new System.Windows.Forms.Label();
            this.ManPowerResult = new System.Windows.Forms.Label();
            this.TotalResourceLabel = new System.Windows.Forms.Label();
            this.ManPowerLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.AmmoLabel = new System.Windows.Forms.Label();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.MDListGroup = new System.Windows.Forms.GroupBox();
            this.MDList = new System.Windows.Forms.TableLayoutPanel();
            this.MDListView = new System.Windows.Forms.ListView();
            this.MDLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MDManPower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MDAmmo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MDFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MDParts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MDManPowerByTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MDAmmoByTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MDFoodByTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MDPartsByTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MDAdditional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Doll = new System.Windows.Forms.TabPage();
            this.DollSubTab = new System.Windows.Forms.TabControl();
            this.DollDIc = new System.Windows.Forms.TabPage();
            this.DollSearchGroup = new System.Windows.Forms.GroupBox();
            this.ModSelectorGroup = new System.Windows.Forms.GroupBox();
            this.ModYes = new System.Windows.Forms.CheckBox();
            this.ModNo = new System.Windows.Forms.CheckBox();
            this.label66 = new System.Windows.Forms.Label();
            this.DollDetailInfoWebNamuWiki = new System.Windows.Forms.LinkLabel();
            this.VoiceSelectorGroup = new System.Windows.Forms.GroupBox();
            this.VoiceYes = new System.Windows.Forms.CheckBox();
            this.VoiceNo = new System.Windows.Forms.CheckBox();
            this.DollDetailInfoWebDDB = new System.Windows.Forms.LinkLabel();
            this.DollProductTimeTableButton = new System.Windows.Forms.Button();
            this.GradeSelectorGroup = new System.Windows.Forms.GroupBox();
            this.GradeExtra = new System.Windows.Forms.CheckBox();
            this.Grade5 = new System.Windows.Forms.CheckBox();
            this.Grade4 = new System.Windows.Forms.CheckBox();
            this.Grade3 = new System.Windows.Forms.CheckBox();
            this.Grade2 = new System.Windows.Forms.CheckBox();
            this.TypeSelectorGroup = new System.Windows.Forms.GroupBox();
            this.TypeRF = new System.Windows.Forms.CheckBox();
            this.TypeSG = new System.Windows.Forms.CheckBox();
            this.TypeMG = new System.Windows.Forms.CheckBox();
            this.TypeHG = new System.Windows.Forms.CheckBox();
            this.TypeAR = new System.Windows.Forms.CheckBox();
            this.TypeSMG = new System.Windows.Forms.CheckBox();
            this.DollListView = new System.Windows.Forms.ListView();
            this.DollName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HasCostume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HasMod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DollSearchTextBox = new System.Windows.Forms.TextBox();
            this.DollInfoGroup = new System.Windows.Forms.GroupBox();
            this.DollAbilityChartButton = new System.Windows.Forms.Button();
            this.DollModStatus = new System.Windows.Forms.Label();
            this.DollModSelectorNext = new System.Windows.Forms.Button();
            this.DollModSelectorPrevious = new System.Windows.Forms.Button();
            this.DollModelCountryIcon = new System.Windows.Forms.PictureBox();
            this.DollSDImageLoadProgress = new System.Windows.Forms.ProgressBar();
            this.DollImageLoadProcess = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DollModelLabel = new System.Windows.Forms.Label();
            this.DollSkillInfoButton = new System.Windows.Forms.Button();
            this.DollDropEventInfoButton = new System.Windows.Forms.Button();
            this.DollVoiceList = new System.Windows.Forms.ComboBox();
            this.DollVoicePlayButton = new System.Windows.Forms.Button();
            this.DollBaseDamage = new System.Windows.Forms.Label();
            this.DollReloadTimeLabel = new System.Windows.Forms.Label();
            this.DollTypeImageBox = new System.Windows.Forms.PictureBox();
            this.DollBulletCountLabel = new System.Windows.Forms.Label();
            this.DollBulletProgress = new System.Windows.Forms.ProgressBar();
            this.DollBulletLabel = new System.Windows.Forms.Label();
            this.DollArmorCountLabel = new System.Windows.Forms.Label();
            this.DollArmorProgress = new System.Windows.Forms.ProgressBar();
            this.DollArmorLabel = new System.Windows.Forms.Label();
            this.DollEffectGroup = new System.Windows.Forms.GroupBox();
            this.DollEffectLabel = new System.Windows.Forms.Label();
            this.DollEffectTypeLabel = new System.Windows.Forms.Label();
            this.DollEffectFormationTable = new System.Windows.Forms.TableLayoutPanel();
            this.DollEffectFormation9 = new System.Windows.Forms.PictureBox();
            this.DollEffectFormation8 = new System.Windows.Forms.PictureBox();
            this.DollEffectFormation7 = new System.Windows.Forms.PictureBox();
            this.DollEffectFormation6 = new System.Windows.Forms.PictureBox();
            this.DollEffectFormation5 = new System.Windows.Forms.PictureBox();
            this.DollEffectFormation4 = new System.Windows.Forms.PictureBox();
            this.DollEffectFormation3 = new System.Windows.Forms.PictureBox();
            this.DollEffectFormation2 = new System.Windows.Forms.PictureBox();
            this.DollEffectFormation1 = new System.Windows.Forms.PictureBox();
            this.DollProductTimeLabel = new System.Windows.Forms.Label();
            this.DollImageSDBox = new System.Windows.Forms.PictureBox();
            this.DollFRCountLabel = new System.Windows.Forms.Label();
            this.DollEVCountLabel = new System.Windows.Forms.Label();
            this.DollACCountLabel = new System.Windows.Forms.Label();
            this.DollASCountLabel = new System.Windows.Forms.Label();
            this.DollHPCountLabel = new System.Windows.Forms.Label();
            this.DollASProgress = new System.Windows.Forms.ProgressBar();
            this.DollACProgress = new System.Windows.Forms.ProgressBar();
            this.DollEVProgress = new System.Windows.Forms.ProgressBar();
            this.DollFRProgress = new System.Windows.Forms.ProgressBar();
            this.DollHPProgress = new System.Windows.Forms.ProgressBar();
            this.DollASLabel = new System.Windows.Forms.Label();
            this.DollACLabel = new System.Windows.Forms.Label();
            this.DollEVLabel = new System.Windows.Forms.Label();
            this.DollFRLabel = new System.Windows.Forms.Label();
            this.DollHPLabel = new System.Windows.Forms.Label();
            this.DollNumLabel = new System.Windows.Forms.Label();
            this.DollNameLabel = new System.Windows.Forms.Label();
            this.DollImageBox = new System.Windows.Forms.PictureBox();
            this.EnemyDic = new System.Windows.Forms.TabPage();
            this.EnemyDicEnemySearchGroup = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.EnemyDicEnemyListView = new System.Windows.Forms.ListView();
            this.EnemyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnemyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnemyETC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnemyDicEnemySearchTextBox = new System.Windows.Forms.TextBox();
            this.EnemyDicEnemyInfoGroup = new System.Windows.Forms.GroupBox();
            this.EnemyDicEnemyType = new System.Windows.Forms.Label();
            this.EnemyDicEnemyPTCount = new System.Windows.Forms.Label();
            this.EnemyDicEnemyPTProgress = new System.Windows.Forms.ProgressBar();
            this.EnemyDicEnemyPTLabel = new System.Windows.Forms.Label();
            this.EnemyDicEnemyAMCount = new System.Windows.Forms.Label();
            this.EnemyDicEnemyAMProgress = new System.Windows.Forms.ProgressBar();
            this.EnemyDicEnemyAMLabel = new System.Windows.Forms.Label();
            this.EnemyDicEnemyFRCount = new System.Windows.Forms.Label();
            this.EnemyDicEnemyEVCount = new System.Windows.Forms.Label();
            this.EnemyDicEnemyACCount = new System.Windows.Forms.Label();
            this.EnemyDicEnemyASCount = new System.Windows.Forms.Label();
            this.EnemyDicEnemyHPCount = new System.Windows.Forms.Label();
            this.EnemyDicEnemyASProgress = new System.Windows.Forms.ProgressBar();
            this.EnemyDicEnemyACProgress = new System.Windows.Forms.ProgressBar();
            this.EnemyDicEnemyEVProgress = new System.Windows.Forms.ProgressBar();
            this.EnemyDicEnemyFRProgress = new System.Windows.Forms.ProgressBar();
            this.EnemyDicEnemyHPProgress = new System.Windows.Forms.ProgressBar();
            this.EnemyDicEnemyASLabel = new System.Windows.Forms.Label();
            this.EnemyDicEnemyACLabel = new System.Windows.Forms.Label();
            this.EnemyDicEnemyEVLabel = new System.Windows.Forms.Label();
            this.EnemyDicEnemyFRLabel = new System.Windows.Forms.Label();
            this.EnemyDicEnemyHPLabel = new System.Windows.Forms.Label();
            this.EnemyDicEnemyName = new System.Windows.Forms.Label();
            this.EnemyDicEnemyImage = new System.Windows.Forms.PictureBox();
            this.FormationSimulator = new System.Windows.Forms.TabPage();
            this.ReinstallFSimulatorButton = new System.Windows.Forms.Button();
            this.label89 = new System.Windows.Forms.Label();
            this.FSimulatorDownloadStatus = new System.Windows.Forms.Label();
            this.FSimulatorDownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.RunFSimulatorButton = new System.Windows.Forms.Button();
            this.LevelingCalc = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ExpCount_5_Leader_MVP = new System.Windows.Forms.Label();
            this.ExpCount_4_Leader_MVP = new System.Windows.Forms.Label();
            this.ExpCount_3_Leader_MVP = new System.Windows.Forms.Label();
            this.ExpCount_2_Leader_MVP = new System.Windows.Forms.Label();
            this.ExpCount_1_Leader_MVP = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.ExpCount_5_MVP = new System.Windows.Forms.Label();
            this.ExpCount_4_MVP = new System.Windows.Forms.Label();
            this.ExpCount_3_MVP = new System.Windows.Forms.Label();
            this.ExpCount_2_MVP = new System.Windows.Forms.Label();
            this.ExpCount_1_MVP = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.ExpCount_5_Leader = new System.Windows.Forms.Label();
            this.ExpCount_4_Leader = new System.Windows.Forms.Label();
            this.ExpCount_3_Leader = new System.Windows.Forms.Label();
            this.ExpCount_2_Leader = new System.Windows.Forms.Label();
            this.ExpCount_1_Leader = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.ExpCount_5_Normal = new System.Windows.Forms.Label();
            this.ExpCount_4_Normal = new System.Windows.Forms.Label();
            this.ExpCount_3_Normal = new System.Windows.Forms.Label();
            this.ExpCount_2_Normal = new System.Windows.Forms.Label();
            this.ExpCount_1_Normal = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.LevelingCalcSetMUGroup = new System.Windows.Forms.GroupBox();
            this.LevelingCalcCalcButton = new System.Windows.Forms.Button();
            this.LevelingCalcETCSetGroup = new System.Windows.Forms.GroupBox();
            this.AutoAddDummySet = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.RequireCountPerOnce = new System.Windows.Forms.NumericUpDown();
            this.label82 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.RequireTimePerOnce = new System.Windows.Forms.NumericUpDown();
            this.label79 = new System.Windows.Forms.Label();
            this.LevelingCalcTypeSelectorGroup = new System.Windows.Forms.GroupBox();
            this.RealWarTypeSelector = new System.Windows.Forms.ComboBox();
            this.SimulationTypeSelector = new System.Windows.Forms.ComboBox();
            this.RealWarType = new System.Windows.Forms.RadioButton();
            this.SimulationType = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.Doll5 = new System.Windows.Forms.Panel();
            this.DummyCount5 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.LevelingCalcNowLevel5 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcNowExp5 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcTargetLevel5 = new System.Windows.Forms.NumericUpDown();
            this.Doll4 = new System.Windows.Forms.Panel();
            this.DummyCount4 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.LevelingCalcNowLevel4 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcNowExp4 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcTargetLevel4 = new System.Windows.Forms.NumericUpDown();
            this.Doll3 = new System.Windows.Forms.Panel();
            this.DummyCount3 = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.LevelingCalcNowLevel3 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcNowExp3 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcTargetLevel3 = new System.Windows.Forms.NumericUpDown();
            this.Doll2 = new System.Windows.Forms.Panel();
            this.DummyCount2 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.LevelingCalcNowLevel2 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcNowExp2 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcTargetLevel2 = new System.Windows.Forms.NumericUpDown();
            this.Doll1 = new System.Windows.Forms.Panel();
            this.DummyCount1 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.LevelingCalcNowLevel1 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcNowExp1 = new System.Windows.Forms.NumericUpDown();
            this.LevelingCalcTargetLevel1 = new System.Windows.Forms.NumericUpDown();
            this.DollEnabler5 = new System.Windows.Forms.CheckBox();
            this.DollEnabler2 = new System.Windows.Forms.CheckBox();
            this.DollEnabler3 = new System.Windows.Forms.CheckBox();
            this.DollEnabler4 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EquipmentTab = new System.Windows.Forms.TabPage();
            this.EquipmentSubTab = new System.Windows.Forms.TabControl();
            this.EquipmentDic = new System.Windows.Forms.TabPage();
            this.EquipmentDicInfoGroup = new System.Windows.Forms.GroupBox();
            this.EquipmentDicNote = new System.Windows.Forms.Label();
            this.EquipmentDicProductTime = new System.Windows.Forms.Label();
            this.EquipmentDicName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EquipmentAbility4 = new System.Windows.Forms.Label();
            this.EquipmentInitialMagnification4 = new System.Windows.Forms.Label();
            this.EquipmentMaxMagnification4 = new System.Windows.Forms.Label();
            this.EquipmentAbility3 = new System.Windows.Forms.Label();
            this.EquipmentInitialMagnification3 = new System.Windows.Forms.Label();
            this.EquipmentMaxMagnification3 = new System.Windows.Forms.Label();
            this.EquipmentMaxMagnification2 = new System.Windows.Forms.Label();
            this.EquipmentInitialMagnification2 = new System.Windows.Forms.Label();
            this.EquipmentAbility2 = new System.Windows.Forms.Label();
            this.EquipmentMaxMagnification1 = new System.Windows.Forms.Label();
            this.EquipmentInitialMagnification1 = new System.Windows.Forms.Label();
            this.EquipmentAbility1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EquipmentDicDollTypeGroup = new System.Windows.Forms.GroupBox();
            this.EquipmentDollTypeOnlyUse = new System.Windows.Forms.Label();
            this.EquipmentDollTypeAR = new System.Windows.Forms.PictureBox();
            this.EquipmentDollTypeSG = new System.Windows.Forms.PictureBox();
            this.EquipmentDollTypeRF = new System.Windows.Forms.PictureBox();
            this.EquipmentDollTypeMG = new System.Windows.Forms.PictureBox();
            this.EquipmentDollTypeSMG = new System.Windows.Forms.PictureBox();
            this.EquipmentDollTypeHG = new System.Windows.Forms.PictureBox();
            this.EquipmentDicEquipmentImage = new System.Windows.Forms.PictureBox();
            this.EquipmentDicSearchGroup = new System.Windows.Forms.GroupBox();
            this.label71 = new System.Windows.Forms.Label();
            this.EquipmentProductTimeTableButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.EquipmentDicCategoryAttachment = new System.Windows.Forms.CheckBox();
            this.EquipmentDicCategoryDoll = new System.Windows.Forms.CheckBox();
            this.EquipmentDicCategoryBullet = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.EquipmentDicGradeExtra = new System.Windows.Forms.CheckBox();
            this.EquipmentDicGrade5 = new System.Windows.Forms.CheckBox();
            this.EquipmentDicGrade4 = new System.Windows.Forms.CheckBox();
            this.EquipmentDicGrade3 = new System.Windows.Forms.CheckBox();
            this.EquipmentDicGrade2 = new System.Windows.Forms.CheckBox();
            this.EquipmentDicSearchTextBox = new System.Windows.Forms.TextBox();
            this.EquipmentDicListGroup = new System.Windows.Forms.GroupBox();
            this.EquipmentDicListView = new System.Windows.Forms.ListView();
            this.EquipmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipmentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipmentCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipmentGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipmentProductTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOperation = new System.Windows.Forms.TabPage();
            this.FreeOPSettingGroup = new System.Windows.Forms.GroupBox();
            this.FreeOPSpecialDropSettingGroup = new System.Windows.Forms.GroupBox();
            this.FreeOPSpecialDropNoExist = new System.Windows.Forms.CheckBox();
            this.FreeOPSpecialDropExist = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.FreeOPMinLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.FreeOPMaxLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.FreeOPMinMUUpDown = new System.Windows.Forms.NumericUpDown();
            this.FreeOPMaxTimeLabel = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.FreeOPMinTimeLabel = new System.Windows.Forms.Label();
            this.FreeOPMaxMUUpDown = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.FreeOPMinTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.FreeOPMaxTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label57 = new System.Windows.Forms.Label();
            this.FreeOPLocationTypeGroup = new System.Windows.Forms.GroupBox();
            this.FreeOPLocationEmergency = new System.Windows.Forms.CheckBox();
            this.FreeOPLocationNight = new System.Windows.Forms.CheckBox();
            this.FreeOPLocationNormal = new System.Windows.Forms.CheckBox();
            this.FreeOPSearchResetButton = new System.Windows.Forms.Button();
            this.FreeOPSearchButton = new System.Windows.Forms.Button();
            this.FreeOPListGroup = new System.Windows.Forms.GroupBox();
            this.FreeOPListView = new System.Windows.Forms.ListView();
            this.FreeOPLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPPaneltyLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPRequireMU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPRequireFP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPRequireResource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPBaseEXP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPDollEXP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPDollEXPByTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPDropCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeOPSpecialDrop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fairy = new System.Windows.Forms.TabPage();
            this.FairySubTab = new System.Windows.Forms.TabControl();
            this.FairyDic = new System.Windows.Forms.TabPage();
            this.FairyInfoGroup = new System.Windows.Forms.GroupBox();
            this.FairySkillInfoGroup = new System.Windows.Forms.GroupBox();
            this.FairyDicFairySkillExplain = new System.Windows.Forms.Label();
            this.FairyDicFairySkillEffect = new System.Windows.Forms.Label();
            this.FairyDicFairySkillName = new System.Windows.Forms.Label();
            this.FairyDicFairySkillIcon = new System.Windows.Forms.PictureBox();
            this.FairyDicFairyACCountLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyEVCountLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyAMCountLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyCRCountLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyFRCountLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyCRProgress = new System.Windows.Forms.ProgressBar();
            this.FairyDicFairyAMProgress = new System.Windows.Forms.ProgressBar();
            this.FairyDicFairyEVProgress = new System.Windows.Forms.ProgressBar();
            this.FairyDicFairyACProgress = new System.Windows.Forms.ProgressBar();
            this.FairyDicFairyFRProgress = new System.Windows.Forms.ProgressBar();
            this.FairyDicFairyCRLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyAMLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyEVLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyACLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyFRLabel = new System.Windows.Forms.Label();
            this.FairyDicFairyName = new System.Windows.Forms.Label();
            this.FairyDicFairyImage = new System.Windows.Forms.PictureBox();
            this.FairySearchGroup = new System.Windows.Forms.GroupBox();
            this.label74 = new System.Windows.Forms.Label();
            this.FairyDicFairyDetailInfoWeb = new System.Windows.Forms.LinkLabel();
            this.FairyProductTimeTableButton = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.FairyDicTypeCombat = new System.Windows.Forms.CheckBox();
            this.FairyDicTypeStrategy = new System.Windows.Forms.CheckBox();
            this.FairyDicSearchTextBox = new System.Windows.Forms.TextBox();
            this.FairyListGroup = new System.Windows.Forms.GroupBox();
            this.FairyDicFairyList = new System.Windows.Forms.ListView();
            this.FairyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FairyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FairyProductTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = new System.Windows.Forms.TabPage();
            this.ProductSimulationSubTab = new System.Windows.Forms.TabControl();
            this.ProductSimulDoll = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DollSimulation5StarStatus = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.DollSimulation4StarStatus = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.DollSimulation3StarStatus = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.DollSimulation2StarStatus = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.DollSimulationResetUseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DollSimulationUseParts = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.DollSimulationUseFood = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.DollSimulationUseAmmo = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.DollSimulationUseManPower = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.ProductSimulDollAdvanceProductTypeGroup = new System.Windows.Forms.GroupBox();
            this.ProductSimulDollAdvanceProductType3 = new System.Windows.Forms.RadioButton();
            this.ProductSimulDollAdvanceProductType2 = new System.Windows.Forms.RadioButton();
            this.ProductSimulDollAdvanceProductType1 = new System.Windows.Forms.RadioButton();
            this.ProductSimulDollProductTypeGroup = new System.Windows.Forms.GroupBox();
            this.ProductSimulDollProductTypeAdvance = new System.Windows.Forms.RadioButton();
            this.ProductSimulDollProductTypeNormal = new System.Windows.Forms.RadioButton();
            this.ProductSimulDollVoiceEnableSetting = new System.Windows.Forms.CheckBox();
            this.ProductDollResultBackgroundPanel = new System.Windows.Forms.Panel();
            this.ProductDollResultDollGradeImageBox = new System.Windows.Forms.PictureBox();
            this.ProductDollResultDollTypeIcon = new System.Windows.Forms.PictureBox();
            this.ProductDollResultDollDialog = new System.Windows.Forms.Panel();
            this.ProductDollResultDollName = new System.Windows.Forms.Label();
            this.ProductDollResultDollImageBox = new System.Windows.Forms.PictureBox();
            this.ProductDollResultGradeStar5 = new System.Windows.Forms.PictureBox();
            this.ProductDollResultGradeStar4 = new System.Windows.Forms.PictureBox();
            this.ProductDollResultGradeStar3 = new System.Windows.Forms.PictureBox();
            this.ProductDollResultGradeStar2 = new System.Windows.Forms.PictureBox();
            this.ProductDollResultGradeStar1 = new System.Windows.Forms.PictureBox();
            this.ProductSimulDollProductButton = new System.Windows.Forms.Button();
            this.ProductSimulDollPartsCount = new System.Windows.Forms.NumericUpDown();
            this.ProductSimulDollAmmoCount = new System.Windows.Forms.NumericUpDown();
            this.ProductSimulDollFoodCount = new System.Windows.Forms.NumericUpDown();
            this.ProductSimulDollManpowerCount = new System.Windows.Forms.NumericUpDown();
            this.ProductSimulEquipment = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label37 = new System.Windows.Forms.Label();
            this.EquipmentSimulationFairyStatus = new System.Windows.Forms.Label();
            this.EquipmentSimulation5StarStatus = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.EquipmentSimulation4StarStatus = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.EquipmentSimulation3StarStatus = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.EquipmentSimulation2StarStatus = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.EquipmentSimulationResetUseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.EquipmentSimulationUseParts = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.EquipmentSimulationUseFood = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.EquipmentSimulationUseAmmo = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.EquipmentSimulationUseManPower = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.ProductSimulEquipmentAdvanceProductTypeGroup = new System.Windows.Forms.GroupBox();
            this.ProductSimulEquipmentAdvanceProductType3 = new System.Windows.Forms.RadioButton();
            this.ProductSimulEquipmentAdvanceProductType2 = new System.Windows.Forms.RadioButton();
            this.ProductSimulEquipmentAdvanceProductType1 = new System.Windows.Forms.RadioButton();
            this.ProductSimulEquipmentProductTypeGroup = new System.Windows.Forms.GroupBox();
            this.ProductSimulEquipmentProductTypeAdvance = new System.Windows.Forms.RadioButton();
            this.ProductSimulEquipmentProductTypeNormal = new System.Windows.Forms.RadioButton();
            this.ProductEquipmentResultBackgroundPanel = new System.Windows.Forms.Panel();
            this.ProductEquipmentResultDialog = new System.Windows.Forms.Panel();
            this.ProductEquipmentResultDialogText = new System.Windows.Forms.Label();
            this.ProductEquipmentResultName = new System.Windows.Forms.Label();
            this.ProductEquipmentResultImageBox = new System.Windows.Forms.PictureBox();
            this.ProductSimulEquipmentProductButton = new System.Windows.Forms.Button();
            this.ProductSimulEquipmentPartsCount = new System.Windows.Forms.NumericUpDown();
            this.ProductSimulEquipmentAmmoCount = new System.Windows.Forms.NumericUpDown();
            this.ProductSimulEquipmentFoodCount = new System.Windows.Forms.NumericUpDown();
            this.ProductSimulEquipmentManpowerCount = new System.Windows.Forms.NumericUpDown();
            this.ProductEquipmentResultGradeStar5 = new System.Windows.Forms.PictureBox();
            this.ProductEquipmentResultGradeStar4 = new System.Windows.Forms.PictureBox();
            this.ProductEquipmentResultGradeStar3 = new System.Windows.Forms.PictureBox();
            this.ProductEquipmentResultGradeStar2 = new System.Windows.Forms.PictureBox();
            this.ProductEquipmentResultGradeStar1 = new System.Windows.Forms.PictureBox();
            this.MDInfoTab = new System.Windows.Forms.TabPage();
            this.PlaceLoadPanel = new System.Windows.Forms.Panel();
            this.PlaceLoadImageBox1 = new System.Windows.Forms.PictureBox();
            this.PlaceLoadImageBox2 = new System.Windows.Forms.PictureBox();
            this.PlaceViewerBox = new System.Windows.Forms.PictureBox();
            this.PlaceViewerSettingGroup = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.ImageSettingGroup = new System.Windows.Forms.GroupBox();
            this.label78 = new System.Windows.Forms.Label();
            this.ImageModeSelector = new System.Windows.Forms.ComboBox();
            this.ImageLoadButton = new System.Windows.Forms.Button();
            this.PlaceSettingGroup = new System.Windows.Forms.GroupBox();
            this.label76 = new System.Windows.Forms.Label();
            this.PlaceSelector = new System.Windows.Forms.ComboBox();
            this.ETCTab = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.GriffinDailyLifeComicButton = new System.Windows.Forms.Button();
            this.GriffinInformationComicButton = new System.Windows.Forms.Button();
            this.LoadingComicButton = new System.Windows.Forms.Button();
            this.FRCalcGroup = new System.Windows.Forms.GroupBox();
            this.CalcFRCaution = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.FRCalcTotalFRCountLabel = new System.Windows.Forms.Label();
            this.FRCalcTotalFRLabel = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.FRCalcSkillEffectFRCount4 = new System.Windows.Forms.NumericUpDown();
            this.FRCalcSkillEffectFRCount3 = new System.Windows.Forms.NumericUpDown();
            this.FRCalcSkillEffectFRCount2 = new System.Windows.Forms.NumericUpDown();
            this.FRCalcSkillEffectFRCount1 = new System.Windows.Forms.NumericUpDown();
            this.FRCalcSkillEffectFRCountLabel = new System.Windows.Forms.Label();
            this.FRCalcSkillEffectFRLabel = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.FRCalcFormationEffectFRCount4 = new System.Windows.Forms.NumericUpDown();
            this.FRCalcFormationEffectFRCount3 = new System.Windows.Forms.NumericUpDown();
            this.FRCalcFormationEffectFRCount2 = new System.Windows.Forms.NumericUpDown();
            this.FRCalcFormationEffectFRCount1 = new System.Windows.Forms.NumericUpDown();
            this.FRCalcFormationEffectFRCountLabel = new System.Windows.Forms.Label();
            this.FRCalcFormationEffectFRLabel = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.FRCalcItemFRCount = new System.Windows.Forms.NumericUpDown();
            this.FRCalcItemFRLabel = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.FRCalcDefaultFRCount = new System.Windows.Forms.NumericUpDown();
            this.FRCalcDefaultFRLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RequireCoreCount = new System.Windows.Forms.Label();
            this.RequireCoreLabel = new System.Windows.Forms.Label();
            this.LinkCalcGradeSelector = new System.Windows.Forms.ComboBox();
            this.LinkCalcGradeSelectorLabel = new System.Windows.Forms.Label();
            this.EndLinkCount = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.StartLinkCount = new System.Windows.Forms.NumericUpDown();
            this.LinkCalcLinkLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SkillTrainingTypeSelector = new System.Windows.Forms.ComboBox();
            this.SkillTrainingTable = new System.Windows.Forms.TableLayoutPanel();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.STTime9 = new System.Windows.Forms.Label();
            this.STConsumption9 = new System.Windows.Forms.Label();
            this.STDataType9 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.STTime8 = new System.Windows.Forms.Label();
            this.STConsumption8 = new System.Windows.Forms.Label();
            this.STDataType8 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.STTime7 = new System.Windows.Forms.Label();
            this.STConsumption7 = new System.Windows.Forms.Label();
            this.STDataType7 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.STTime6 = new System.Windows.Forms.Label();
            this.STConsumption6 = new System.Windows.Forms.Label();
            this.STDataType6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.STTime5 = new System.Windows.Forms.Label();
            this.STConsumption5 = new System.Windows.Forms.Label();
            this.STDataType5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.STTime4 = new System.Windows.Forms.Label();
            this.STConsumption4 = new System.Windows.Forms.Label();
            this.STDataType4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.STTime3 = new System.Windows.Forms.Label();
            this.STConsumption3 = new System.Windows.Forms.Label();
            this.STDataType3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.STTime2 = new System.Windows.Forms.Label();
            this.STConsumption2 = new System.Windows.Forms.Label();
            this.STDataType2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.STTime1 = new System.Windows.Forms.Label();
            this.STConsumption1 = new System.Windows.Forms.Label();
            this.STDataType1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.ExpItemCalcGroup = new System.Windows.Forms.GroupBox();
            this.ExpItemCalcModSwitch = new System.Windows.Forms.CheckBox();
            this.ExpItemCalcApplyVow = new System.Windows.Forms.CheckBox();
            this.SurplusExpCount = new System.Windows.Forms.Label();
            this.RequireExpItemCount = new System.Windows.Forms.Label();
            this.SurplusExpLabel = new System.Windows.Forms.Label();
            this.RequireExpItemLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NowExpCount = new System.Windows.Forms.NumericUpDown();
            this.NowExpLabel = new System.Windows.Forms.Label();
            this.ExpEndLevel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpStartLevel = new System.Windows.Forms.NumericUpDown();
            this.ExpLevelLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgramStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DollInfoLoadProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.DollInfoLoadSubProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgramLoadProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.CheckUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.프로그램ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공지사항ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.업데이트확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.로그폴더열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.피드백보내기FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.소녀전선서포터정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EffectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TypeIconImageList = new System.Windows.Forms.ImageList(this.components);
            this.EquipmentImageList = new System.Windows.Forms.ImageList(this.components);
            this.FairyImageList = new System.Windows.Forms.ImageList(this.components);
            this.FairySkillIconImageList = new System.Windows.Forms.ImageList(this.components);
            this.EnemyImageList = new System.Windows.Forms.ImageList(this.components);
            this.EffectIconList = new System.Windows.Forms.ImageList(this.components);
            this.GradeImageList = new System.Windows.Forms.ImageList(this.components);
            this.ModelCountryIcons = new System.Windows.Forms.ImageList(this.components);
            this.CountryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainTab.SuspendLayout();
            this.MD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.OutputSettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelRestrictOutputMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelRestrictOutputMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeRestrictOutputMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeRestrictOutputMin)).BeginInit();
            this.NowResourceSettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsNowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodNowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoNowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManPowerNowCount)).BeginInit();
            this.MDCalcModeSettingGroup.SuspendLayout();
            this.ExceptResourceSettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.ExtraSettingGroup.SuspendLayout();
            this.ResourceWeightSettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManPowerWeight)).BeginInit();
            this.MDCalculator.SuspendLayout();
            this.MDCalcSettingGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ResourceResultGroup.SuspendLayout();
            this.MDListGroup.SuspendLayout();
            this.MDList.SuspendLayout();
            this.Doll.SuspendLayout();
            this.DollSubTab.SuspendLayout();
            this.DollDIc.SuspendLayout();
            this.DollSearchGroup.SuspendLayout();
            this.ModSelectorGroup.SuspendLayout();
            this.VoiceSelectorGroup.SuspendLayout();
            this.GradeSelectorGroup.SuspendLayout();
            this.TypeSelectorGroup.SuspendLayout();
            this.DollInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DollModelCountryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollTypeImageBox)).BeginInit();
            this.DollEffectGroup.SuspendLayout();
            this.DollEffectFormationTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollImageSDBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollImageBox)).BeginInit();
            this.EnemyDic.SuspendLayout();
            this.EnemyDicEnemySearchGroup.SuspendLayout();
            this.EnemyDicEnemyInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyDicEnemyImage)).BeginInit();
            this.FormationSimulator.SuspendLayout();
            this.LevelingCalc.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.LevelingCalcSetMUGroup.SuspendLayout();
            this.LevelingCalcETCSetGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequireCountPerOnce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequireTimePerOnce)).BeginInit();
            this.LevelingCalcTypeSelectorGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Doll5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel5)).BeginInit();
            this.Doll4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel4)).BeginInit();
            this.Doll3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel3)).BeginInit();
            this.Doll2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel2)).BeginInit();
            this.Doll1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel1)).BeginInit();
            this.EquipmentTab.SuspendLayout();
            this.EquipmentSubTab.SuspendLayout();
            this.EquipmentDic.SuspendLayout();
            this.EquipmentDicInfoGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.EquipmentDicDollTypeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeSG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeSMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeHG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDicEquipmentImage)).BeginInit();
            this.EquipmentDicSearchGroup.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.EquipmentDicListGroup.SuspendLayout();
            this.FreeOperation.SuspendLayout();
            this.FreeOPSettingGroup.SuspendLayout();
            this.FreeOPSpecialDropSettingGroup.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMinLevelUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMaxLevelUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMinMUUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMaxMUUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMinTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMaxTimeUpDown)).BeginInit();
            this.FreeOPLocationTypeGroup.SuspendLayout();
            this.FreeOPListGroup.SuspendLayout();
            this.Fairy.SuspendLayout();
            this.FairySubTab.SuspendLayout();
            this.FairyDic.SuspendLayout();
            this.FairyInfoGroup.SuspendLayout();
            this.FairySkillInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FairyDicFairySkillIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FairyDicFairyImage)).BeginInit();
            this.FairySearchGroup.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.FairyListGroup.SuspendLayout();
            this.Product.SuspendLayout();
            this.ProductSimulationSubTab.SuspendLayout();
            this.ProductSimulDoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.ProductSimulDollAdvanceProductTypeGroup.SuspendLayout();
            this.ProductSimulDollProductTypeGroup.SuspendLayout();
            this.ProductDollResultBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultDollGradeImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultDollTypeIcon)).BeginInit();
            this.ProductDollResultDollDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultDollImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulDollPartsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulDollAmmoCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulDollFoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulDollManpowerCount)).BeginInit();
            this.ProductSimulEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.ProductSimulEquipmentAdvanceProductTypeGroup.SuspendLayout();
            this.ProductSimulEquipmentProductTypeGroup.SuspendLayout();
            this.ProductEquipmentResultBackgroundPanel.SuspendLayout();
            this.ProductEquipmentResultDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulEquipmentPartsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulEquipmentAmmoCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulEquipmentFoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulEquipmentManpowerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar1)).BeginInit();
            this.MDInfoTab.SuspendLayout();
            this.PlaceLoadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceLoadImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceLoadImageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceViewerBox)).BeginInit();
            this.PlaceViewerSettingGroup.SuspendLayout();
            this.ImageSettingGroup.SuspendLayout();
            this.PlaceSettingGroup.SuspendLayout();
            this.ETCTab.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.FRCalcGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcSkillEffectFRCount4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcSkillEffectFRCount3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcSkillEffectFRCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcSkillEffectFRCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcFormationEffectFRCount4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcFormationEffectFRCount3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcFormationEffectFRCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcFormationEffectFRCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcItemFRCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcDefaultFRCount)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndLinkCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartLinkCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SkillTrainingTable.SuspendLayout();
            this.ExpItemCalcGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NowExpCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpEndLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpStartLevel)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.MD);
            this.MainTab.Controls.Add(this.Doll);
            this.MainTab.Controls.Add(this.EquipmentTab);
            this.MainTab.Controls.Add(this.FreeOperation);
            this.MainTab.Controls.Add(this.Fairy);
            this.MainTab.Controls.Add(this.Product);
            this.MainTab.Controls.Add(this.MDInfoTab);
            this.MainTab.Controls.Add(this.ETCTab);
            this.MainTab.Enabled = false;
            this.MainTab.Location = new System.Drawing.Point(0, 27);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(881, 605);
            this.MainTab.TabIndex = 0;
            // 
            // MD
            // 
            this.MD.Controls.Add(this.groupBox2);
            this.MD.Controls.Add(this.MDCalculator);
            this.MD.Controls.Add(this.MDListGroup);
            this.MD.Location = new System.Drawing.Point(4, 22);
            this.MD.Name = "MD";
            this.MD.Padding = new System.Windows.Forms.Padding(3);
            this.MD.Size = new System.Drawing.Size(873, 579);
            this.MD.TabIndex = 0;
            this.MD.Text = "군수지원";
            this.MD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RankMDListView);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(487, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 567);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "추천 군수지원";
            // 
            // RankMDListView
            // 
            this.RankMDListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rank,
            this.Recommend_Place,
            this.Recommend_MinLevel,
            this.Recommend_Time,
            this.Recommend_Resource,
            this.Recommend_Extra});
            this.RankMDListView.FullRowSelect = true;
            this.RankMDListView.HideSelection = false;
            this.RankMDListView.Location = new System.Drawing.Point(6, 371);
            this.RankMDListView.Name = "RankMDListView";
            this.RankMDListView.Size = new System.Drawing.Size(366, 189);
            this.RankMDListView.TabIndex = 1;
            this.RankMDListView.UseCompatibleStateImageBehavior = false;
            this.RankMDListView.View = System.Windows.Forms.View.Details;
            // 
            // Rank
            // 
            this.Rank.Text = "순위";
            this.Rank.Width = 40;
            // 
            // Recommend_Place
            // 
            this.Recommend_Place.Text = "장소";
            this.Recommend_Place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Recommend_MinLevel
            // 
            this.Recommend_MinLevel.Text = "최소 레벨";
            this.Recommend_MinLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Recommend_MinLevel.Width = 70;
            // 
            // Recommend_Time
            // 
            this.Recommend_Time.Text = "소요 시간";
            this.Recommend_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Recommend_Time.Width = 70;
            // 
            // Recommend_Resource
            // 
            this.Recommend_Resource.Text = "인/탄/식/부";
            this.Recommend_Resource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Recommend_Resource.Width = 90;
            // 
            // Recommend_Extra
            // 
            this.Recommend_Extra.Text = "추가 획득";
            this.Recommend_Extra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Recommend_Extra.Width = 200;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.OutputSettingGroup);
            this.groupBox5.Controls.Add(this.NowResourceSettingGroup);
            this.groupBox5.Controls.Add(this.MDCalcModeSettingGroup);
            this.groupBox5.Controls.Add(this.PrintRecommendMDButton);
            this.groupBox5.Controls.Add(this.ExceptResourceSettingGroup);
            this.groupBox5.Controls.Add(this.ExtraSettingGroup);
            this.groupBox5.Controls.Add(this.ResourceWeightSettingGroup);
            this.groupBox5.Location = new System.Drawing.Point(6, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(366, 348);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "조건 설정";
            // 
            // OutputSettingGroup
            // 
            this.OutputSettingGroup.Controls.Add(this.label86);
            this.OutputSettingGroup.Controls.Add(this.LevelRestrictOutputMax);
            this.OutputSettingGroup.Controls.Add(this.LevelRestrictOutputMin);
            this.OutputSettingGroup.Controls.Add(this.label88);
            this.OutputSettingGroup.Controls.Add(this.label20);
            this.OutputSettingGroup.Controls.Add(this.TimeRestrictOutputMax);
            this.OutputSettingGroup.Controls.Add(this.TimeRestrictOutputMin);
            this.OutputSettingGroup.Controls.Add(this.label18);
            this.OutputSettingGroup.Location = new System.Drawing.Point(6, 219);
            this.OutputSettingGroup.Name = "OutputSettingGroup";
            this.OutputSettingGroup.Size = new System.Drawing.Size(354, 70);
            this.OutputSettingGroup.TabIndex = 30;
            this.OutputSettingGroup.TabStop = false;
            this.OutputSettingGroup.Text = "출력 설정";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(124, 46);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(14, 12);
            this.label86.TabIndex = 7;
            this.label86.Text = "~";
            // 
            // LevelRestrictOutputMax
            // 
            this.LevelRestrictOutputMax.Location = new System.Drawing.Point(140, 41);
            this.LevelRestrictOutputMax.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.LevelRestrictOutputMax.Name = "LevelRestrictOutputMax";
            this.LevelRestrictOutputMax.Size = new System.Drawing.Size(46, 21);
            this.LevelRestrictOutputMax.TabIndex = 6;
            this.LevelRestrictOutputMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LevelRestrictOutputMax.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // LevelRestrictOutputMin
            // 
            this.LevelRestrictOutputMin.Location = new System.Drawing.Point(76, 41);
            this.LevelRestrictOutputMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.LevelRestrictOutputMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelRestrictOutputMin.Name = "LevelRestrictOutputMin";
            this.LevelRestrictOutputMin.Size = new System.Drawing.Size(46, 21);
            this.LevelRestrictOutputMin.TabIndex = 5;
            this.LevelRestrictOutputMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LevelRestrictOutputMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(5, 46);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(65, 12);
            this.label88.TabIndex = 4;
            this.label88.Text = "레벨 제한 :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(124, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 12);
            this.label20.TabIndex = 3;
            this.label20.Text = "~";
            // 
            // TimeRestrictOutputMax
            // 
            this.TimeRestrictOutputMax.Location = new System.Drawing.Point(140, 15);
            this.TimeRestrictOutputMax.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.TimeRestrictOutputMax.Name = "TimeRestrictOutputMax";
            this.TimeRestrictOutputMax.Size = new System.Drawing.Size(46, 21);
            this.TimeRestrictOutputMax.TabIndex = 2;
            this.TimeRestrictOutputMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeRestrictOutputMax.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // TimeRestrictOutputMin
            // 
            this.TimeRestrictOutputMin.Location = new System.Drawing.Point(76, 15);
            this.TimeRestrictOutputMin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.TimeRestrictOutputMin.Name = "TimeRestrictOutputMin";
            this.TimeRestrictOutputMin.Size = new System.Drawing.Size(46, 21);
            this.TimeRestrictOutputMin.TabIndex = 1;
            this.TimeRestrictOutputMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "시간 제한 :";
            // 
            // NowResourceSettingGroup
            // 
            this.NowResourceSettingGroup.Controls.Add(this.pictureBox13);
            this.NowResourceSettingGroup.Controls.Add(this.pictureBox14);
            this.NowResourceSettingGroup.Controls.Add(this.pictureBox15);
            this.NowResourceSettingGroup.Controls.Add(this.pictureBox16);
            this.NowResourceSettingGroup.Controls.Add(this.PartsNowCount);
            this.NowResourceSettingGroup.Controls.Add(this.FoodNowCount);
            this.NowResourceSettingGroup.Controls.Add(this.AmmoNowCount);
            this.NowResourceSettingGroup.Controls.Add(this.ManPowerNowCount);
            this.NowResourceSettingGroup.Location = new System.Drawing.Point(6, 14);
            this.NowResourceSettingGroup.Name = "NowResourceSettingGroup";
            this.NowResourceSettingGroup.Size = new System.Drawing.Size(108, 136);
            this.NowResourceSettingGroup.TabIndex = 29;
            this.NowResourceSettingGroup.TabStop = false;
            this.NowResourceSettingGroup.Text = "현재 보유 자원";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Parts_Icon;
            this.pictureBox13.Location = new System.Drawing.Point(12, 103);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(25, 25);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 28;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Food_Icon;
            this.pictureBox14.Location = new System.Drawing.Point(12, 73);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(25, 25);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 27;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Ammo_Icon;
            this.pictureBox15.Location = new System.Drawing.Point(12, 44);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(25, 25);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 26;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Manpower_Icon;
            this.pictureBox16.Location = new System.Drawing.Point(12, 16);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(25, 25);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 25;
            this.pictureBox16.TabStop = false;
            // 
            // PartsNowCount
            // 
            this.PartsNowCount.Location = new System.Drawing.Point(43, 104);
            this.PartsNowCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PartsNowCount.Name = "PartsNowCount";
            this.PartsNowCount.Size = new System.Drawing.Size(59, 21);
            this.PartsNowCount.TabIndex = 10;
            this.PartsNowCount.Tag = "3";
            this.PartsNowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PartsNowCount.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // FoodNowCount
            // 
            this.FoodNowCount.Location = new System.Drawing.Point(43, 75);
            this.FoodNowCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.FoodNowCount.Name = "FoodNowCount";
            this.FoodNowCount.Size = new System.Drawing.Size(59, 21);
            this.FoodNowCount.TabIndex = 7;
            this.FoodNowCount.Tag = "2";
            this.FoodNowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FoodNowCount.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // AmmoNowCount
            // 
            this.AmmoNowCount.Location = new System.Drawing.Point(43, 47);
            this.AmmoNowCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.AmmoNowCount.Name = "AmmoNowCount";
            this.AmmoNowCount.Size = new System.Drawing.Size(59, 21);
            this.AmmoNowCount.TabIndex = 4;
            this.AmmoNowCount.Tag = "1";
            this.AmmoNowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmmoNowCount.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // ManPowerNowCount
            // 
            this.ManPowerNowCount.Location = new System.Drawing.Point(43, 19);
            this.ManPowerNowCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ManPowerNowCount.Name = "ManPowerNowCount";
            this.ManPowerNowCount.Size = new System.Drawing.Size(59, 21);
            this.ManPowerNowCount.TabIndex = 1;
            this.ManPowerNowCount.Tag = "0";
            this.ManPowerNowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ManPowerNowCount.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // MDCalcModeSettingGroup
            // 
            this.MDCalcModeSettingGroup.Controls.Add(this.PerTimeNo);
            this.MDCalcModeSettingGroup.Controls.Add(this.PerTimeYes);
            this.MDCalcModeSettingGroup.Location = new System.Drawing.Point(223, 155);
            this.MDCalcModeSettingGroup.Name = "MDCalcModeSettingGroup";
            this.MDCalcModeSettingGroup.Size = new System.Drawing.Size(137, 62);
            this.MDCalcModeSettingGroup.TabIndex = 4;
            this.MDCalcModeSettingGroup.TabStop = false;
            this.MDCalcModeSettingGroup.Text = "계산방식 설정";
            // 
            // PerTimeNo
            // 
            this.PerTimeNo.AutoSize = true;
            this.PerTimeNo.Checked = true;
            this.PerTimeNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PerTimeNo.Location = new System.Drawing.Point(18, 38);
            this.PerTimeNo.Name = "PerTimeNo";
            this.PerTimeNo.Size = new System.Drawing.Size(87, 16);
            this.PerTimeNo.TabIndex = 1;
            this.PerTimeNo.TabStop = true;
            this.PerTimeNo.Text = "획득 자원량";
            this.PerTimeNo.UseVisualStyleBackColor = true;
            // 
            // PerTimeYes
            // 
            this.PerTimeYes.AutoSize = true;
            this.PerTimeYes.Location = new System.Drawing.Point(18, 19);
            this.PerTimeYes.Name = "PerTimeYes";
            this.PerTimeYes.Size = new System.Drawing.Size(97, 16);
            this.PerTimeYes.TabIndex = 0;
            this.PerTimeYes.Text = "자원량 / 시간";
            this.PerTimeYes.UseVisualStyleBackColor = true;
            // 
            // PrintRecommendMDButton
            // 
            this.PrintRecommendMDButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintRecommendMDButton.Location = new System.Drawing.Point(6, 310);
            this.PrintRecommendMDButton.Name = "PrintRecommendMDButton";
            this.PrintRecommendMDButton.Size = new System.Drawing.Size(354, 32);
            this.PrintRecommendMDButton.TabIndex = 3;
            this.PrintRecommendMDButton.Text = "출력";
            this.PrintRecommendMDButton.UseVisualStyleBackColor = true;
            this.PrintRecommendMDButton.Click += new System.EventHandler(this.PrintRecommendMDButton_Click);
            // 
            // ExceptResourceSettingGroup
            // 
            this.ExceptResourceSettingGroup.Controls.Add(this.pictureBox20);
            this.ExceptResourceSettingGroup.Controls.Add(this.pictureBox19);
            this.ExceptResourceSettingGroup.Controls.Add(this.pictureBox18);
            this.ExceptResourceSettingGroup.Controls.Add(this.pictureBox17);
            this.ExceptResourceSettingGroup.Controls.Add(this.ExceptPartsSetting);
            this.ExceptResourceSettingGroup.Controls.Add(this.ExceptFoodSetting);
            this.ExceptResourceSettingGroup.Controls.Add(this.ExceptAmmoSetting);
            this.ExceptResourceSettingGroup.Controls.Add(this.ExceptManPowerSetting);
            this.ExceptResourceSettingGroup.Location = new System.Drawing.Point(6, 155);
            this.ExceptResourceSettingGroup.Name = "ExceptResourceSettingGroup";
            this.ExceptResourceSettingGroup.Size = new System.Drawing.Size(215, 62);
            this.ExceptResourceSettingGroup.TabIndex = 2;
            this.ExceptResourceSettingGroup.TabStop = false;
            this.ExceptResourceSettingGroup.Text = "제외시킬 자원";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Parts_Icon;
            this.pictureBox20.Location = new System.Drawing.Point(181, 23);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(25, 25);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 29;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Food_Icon;
            this.pictureBox19.Location = new System.Drawing.Point(128, 23);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(25, 25);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 29;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Ammo_Icon;
            this.pictureBox18.Location = new System.Drawing.Point(76, 23);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(25, 25);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 29;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Manpower_Icon;
            this.pictureBox17.Location = new System.Drawing.Point(24, 23);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(25, 25);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 29;
            this.pictureBox17.TabStop = false;
            // 
            // ExceptPartsSetting
            // 
            this.ExceptPartsSetting.AutoSize = true;
            this.ExceptPartsSetting.Location = new System.Drawing.Point(159, 29);
            this.ExceptPartsSetting.Name = "ExceptPartsSetting";
            this.ExceptPartsSetting.Size = new System.Drawing.Size(15, 14);
            this.ExceptPartsSetting.TabIndex = 3;
            this.ExceptPartsSetting.Tag = "Parts";
            this.ExceptPartsSetting.UseVisualStyleBackColor = true;
            // 
            // ExceptFoodSetting
            // 
            this.ExceptFoodSetting.AutoSize = true;
            this.ExceptFoodSetting.Location = new System.Drawing.Point(107, 29);
            this.ExceptFoodSetting.Name = "ExceptFoodSetting";
            this.ExceptFoodSetting.Size = new System.Drawing.Size(15, 14);
            this.ExceptFoodSetting.TabIndex = 2;
            this.ExceptFoodSetting.Tag = "Food";
            this.ExceptFoodSetting.UseVisualStyleBackColor = true;
            // 
            // ExceptAmmoSetting
            // 
            this.ExceptAmmoSetting.AutoSize = true;
            this.ExceptAmmoSetting.Location = new System.Drawing.Point(55, 29);
            this.ExceptAmmoSetting.Name = "ExceptAmmoSetting";
            this.ExceptAmmoSetting.Size = new System.Drawing.Size(15, 14);
            this.ExceptAmmoSetting.TabIndex = 1;
            this.ExceptAmmoSetting.Tag = "Ammo";
            this.ExceptAmmoSetting.UseVisualStyleBackColor = true;
            // 
            // ExceptManPowerSetting
            // 
            this.ExceptManPowerSetting.AutoSize = true;
            this.ExceptManPowerSetting.Location = new System.Drawing.Point(6, 29);
            this.ExceptManPowerSetting.Name = "ExceptManPowerSetting";
            this.ExceptManPowerSetting.Size = new System.Drawing.Size(15, 14);
            this.ExceptManPowerSetting.TabIndex = 0;
            this.ExceptManPowerSetting.Tag = "ManPower";
            this.ExceptManPowerSetting.UseVisualStyleBackColor = true;
            // 
            // ExtraSettingGroup
            // 
            this.ExtraSettingGroup.Controls.Add(this.TokenSetting);
            this.ExtraSettingGroup.Controls.Add(this.DollTicketSetting);
            this.ExtraSettingGroup.Controls.Add(this.EquipTicketSetting);
            this.ExtraSettingGroup.Controls.Add(this.ProductTicketSetting);
            this.ExtraSettingGroup.Controls.Add(this.RecoveryTicketSetting);
            this.ExtraSettingGroup.Location = new System.Drawing.Point(257, 15);
            this.ExtraSettingGroup.Name = "ExtraSettingGroup";
            this.ExtraSettingGroup.Size = new System.Drawing.Size(103, 135);
            this.ExtraSettingGroup.TabIndex = 1;
            this.ExtraSettingGroup.TabStop = false;
            this.ExtraSettingGroup.Text = "추가 획득 설정";
            // 
            // TokenSetting
            // 
            this.TokenSetting.AutoSize = true;
            this.TokenSetting.Checked = true;
            this.TokenSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TokenSetting.Location = new System.Drawing.Point(16, 110);
            this.TokenSetting.Name = "TokenSetting";
            this.TokenSetting.Size = new System.Drawing.Size(72, 16);
            this.TokenSetting.TabIndex = 4;
            this.TokenSetting.Tag = "Token";
            this.TokenSetting.Text = "구매토큰";
            this.TokenSetting.UseVisualStyleBackColor = true;
            // 
            // DollTicketSetting
            // 
            this.DollTicketSetting.AutoSize = true;
            this.DollTicketSetting.Checked = true;
            this.DollTicketSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DollTicketSetting.Location = new System.Drawing.Point(16, 67);
            this.DollTicketSetting.Name = "DollTicketSetting";
            this.DollTicketSetting.Size = new System.Drawing.Size(84, 16);
            this.DollTicketSetting.TabIndex = 3;
            this.DollTicketSetting.Tag = "Doll Ticket";
            this.DollTicketSetting.Text = "인형제조권";
            this.DollTicketSetting.UseVisualStyleBackColor = true;
            // 
            // EquipTicketSetting
            // 
            this.EquipTicketSetting.AutoSize = true;
            this.EquipTicketSetting.Checked = true;
            this.EquipTicketSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EquipTicketSetting.Location = new System.Drawing.Point(16, 88);
            this.EquipTicketSetting.Name = "EquipTicketSetting";
            this.EquipTicketSetting.Size = new System.Drawing.Size(84, 16);
            this.EquipTicketSetting.TabIndex = 2;
            this.EquipTicketSetting.Tag = "Equip Ticket";
            this.EquipTicketSetting.Text = "장비제조권";
            this.EquipTicketSetting.UseVisualStyleBackColor = true;
            // 
            // ProductTicketSetting
            // 
            this.ProductTicketSetting.AutoSize = true;
            this.ProductTicketSetting.Checked = true;
            this.ProductTicketSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProductTicketSetting.Location = new System.Drawing.Point(16, 45);
            this.ProductTicketSetting.Name = "ProductTicketSetting";
            this.ProductTicketSetting.Size = new System.Drawing.Size(84, 16);
            this.ProductTicketSetting.TabIndex = 1;
            this.ProductTicketSetting.Tag = "Product Ticket";
            this.ProductTicketSetting.Text = "쾌속제조권";
            this.ProductTicketSetting.UseVisualStyleBackColor = true;
            // 
            // RecoveryTicketSetting
            // 
            this.RecoveryTicketSetting.AutoSize = true;
            this.RecoveryTicketSetting.Checked = true;
            this.RecoveryTicketSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecoveryTicketSetting.Location = new System.Drawing.Point(16, 24);
            this.RecoveryTicketSetting.Name = "RecoveryTicketSetting";
            this.RecoveryTicketSetting.Size = new System.Drawing.Size(84, 16);
            this.RecoveryTicketSetting.TabIndex = 0;
            this.RecoveryTicketSetting.Tag = "Recovery Ticket";
            this.RecoveryTicketSetting.Text = "쾌속수복권";
            this.RecoveryTicketSetting.UseVisualStyleBackColor = true;
            // 
            // ResourceWeightSettingGroup
            // 
            this.ResourceWeightSettingGroup.Controls.Add(this.AmmoWeightNow);
            this.ResourceWeightSettingGroup.Controls.Add(this.FoodWeightNow);
            this.ResourceWeightSettingGroup.Controls.Add(this.PartsWeightNow);
            this.ResourceWeightSettingGroup.Controls.Add(this.ManPowerWeightNow);
            this.ResourceWeightSettingGroup.Controls.Add(this.pictureBox12);
            this.ResourceWeightSettingGroup.Controls.Add(this.pictureBox11);
            this.ResourceWeightSettingGroup.Controls.Add(this.pictureBox10);
            this.ResourceWeightSettingGroup.Controls.Add(this.pictureBox9);
            this.ResourceWeightSettingGroup.Controls.Add(this.PartsWeight);
            this.ResourceWeightSettingGroup.Controls.Add(this.FoodWeight);
            this.ResourceWeightSettingGroup.Controls.Add(this.AmmoWeight);
            this.ResourceWeightSettingGroup.Controls.Add(this.ManPowerWeight);
            this.ResourceWeightSettingGroup.Location = new System.Drawing.Point(120, 15);
            this.ResourceWeightSettingGroup.Name = "ResourceWeightSettingGroup";
            this.ResourceWeightSettingGroup.Size = new System.Drawing.Size(131, 135);
            this.ResourceWeightSettingGroup.TabIndex = 0;
            this.ResourceWeightSettingGroup.TabStop = false;
            this.ResourceWeightSettingGroup.Text = "가중치 추가 설정";
            // 
            // AmmoWeightNow
            // 
            this.AmmoWeightNow.AutoSize = true;
            this.AmmoWeightNow.Font = new System.Drawing.Font("굴림", 8F);
            this.AmmoWeightNow.ForeColor = System.Drawing.Color.Gray;
            this.AmmoWeightNow.Location = new System.Drawing.Point(92, 50);
            this.AmmoWeightNow.Name = "AmmoWeightNow";
            this.AmmoWeightNow.Size = new System.Drawing.Size(26, 11);
            this.AmmoWeightNow.TabIndex = 32;
            this.AmmoWeightNow.Text = "0.00";
            // 
            // FoodWeightNow
            // 
            this.FoodWeightNow.AutoSize = true;
            this.FoodWeightNow.Font = new System.Drawing.Font("굴림", 8F);
            this.FoodWeightNow.ForeColor = System.Drawing.Color.Gray;
            this.FoodWeightNow.Location = new System.Drawing.Point(92, 78);
            this.FoodWeightNow.Name = "FoodWeightNow";
            this.FoodWeightNow.Size = new System.Drawing.Size(26, 11);
            this.FoodWeightNow.TabIndex = 31;
            this.FoodWeightNow.Text = "0.00";
            // 
            // PartsWeightNow
            // 
            this.PartsWeightNow.AutoSize = true;
            this.PartsWeightNow.Font = new System.Drawing.Font("굴림", 8F);
            this.PartsWeightNow.ForeColor = System.Drawing.Color.Gray;
            this.PartsWeightNow.Location = new System.Drawing.Point(92, 107);
            this.PartsWeightNow.Name = "PartsWeightNow";
            this.PartsWeightNow.Size = new System.Drawing.Size(26, 11);
            this.PartsWeightNow.TabIndex = 30;
            this.PartsWeightNow.Text = "0.00";
            // 
            // ManPowerWeightNow
            // 
            this.ManPowerWeightNow.AutoSize = true;
            this.ManPowerWeightNow.Font = new System.Drawing.Font("굴림", 8F);
            this.ManPowerWeightNow.ForeColor = System.Drawing.Color.Gray;
            this.ManPowerWeightNow.Location = new System.Drawing.Point(92, 22);
            this.ManPowerWeightNow.Name = "ManPowerWeightNow";
            this.ManPowerWeightNow.Size = new System.Drawing.Size(26, 11);
            this.ManPowerWeightNow.TabIndex = 29;
            this.ManPowerWeightNow.Text = "0.00";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Parts_Icon;
            this.pictureBox12.Location = new System.Drawing.Point(7, 103);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(25, 25);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 28;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Food_Icon;
            this.pictureBox11.Location = new System.Drawing.Point(7, 73);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 27;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Ammo_Icon;
            this.pictureBox10.Location = new System.Drawing.Point(7, 44);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 26;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Manpower_Icon;
            this.pictureBox9.Location = new System.Drawing.Point(7, 16);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            // 
            // PartsWeight
            // 
            this.PartsWeight.DecimalPlaces = 2;
            this.PartsWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PartsWeight.Location = new System.Drawing.Point(38, 104);
            this.PartsWeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PartsWeight.Name = "PartsWeight";
            this.PartsWeight.Size = new System.Drawing.Size(48, 21);
            this.PartsWeight.TabIndex = 10;
            this.PartsWeight.Tag = "3";
            this.PartsWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartsWeight.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // FoodWeight
            // 
            this.FoodWeight.DecimalPlaces = 2;
            this.FoodWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.FoodWeight.Location = new System.Drawing.Point(38, 75);
            this.FoodWeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FoodWeight.Name = "FoodWeight";
            this.FoodWeight.Size = new System.Drawing.Size(48, 21);
            this.FoodWeight.TabIndex = 7;
            this.FoodWeight.Tag = "2";
            this.FoodWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FoodWeight.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // AmmoWeight
            // 
            this.AmmoWeight.DecimalPlaces = 2;
            this.AmmoWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.AmmoWeight.Location = new System.Drawing.Point(38, 47);
            this.AmmoWeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AmmoWeight.Name = "AmmoWeight";
            this.AmmoWeight.Size = new System.Drawing.Size(48, 21);
            this.AmmoWeight.TabIndex = 4;
            this.AmmoWeight.Tag = "1";
            this.AmmoWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmmoWeight.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // ManPowerWeight
            // 
            this.ManPowerWeight.DecimalPlaces = 2;
            this.ManPowerWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ManPowerWeight.Location = new System.Drawing.Point(38, 19);
            this.ManPowerWeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ManPowerWeight.Name = "ManPowerWeight";
            this.ManPowerWeight.Size = new System.Drawing.Size(48, 21);
            this.ManPowerWeight.TabIndex = 1;
            this.ManPowerWeight.Tag = "0";
            this.ManPowerWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ManPowerWeight.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // MDCalculator
            // 
            this.MDCalculator.Controls.Add(this.MDCalcSettingGroup);
            this.MDCalculator.Controls.Add(this.MDCalcResetButton);
            this.MDCalculator.Controls.Add(this.MDCalcPrintButton);
            this.MDCalculator.Controls.Add(this.groupBox1);
            this.MDCalculator.Controls.Add(this.ResourceResultGroup);
            this.MDCalculator.Location = new System.Drawing.Point(6, 407);
            this.MDCalculator.Name = "MDCalculator";
            this.MDCalculator.Size = new System.Drawing.Size(475, 166);
            this.MDCalculator.TabIndex = 1;
            this.MDCalculator.TabStop = false;
            this.MDCalculator.Text = "군수지원 계산기";
            // 
            // MDCalcSettingGroup
            // 
            this.MDCalcSettingGroup.Controls.Add(this.MDCalcSettingByTime);
            this.MDCalcSettingGroup.Controls.Add(this.MDCalcSettingSum);
            this.MDCalcSettingGroup.Location = new System.Drawing.Point(248, 92);
            this.MDCalcSettingGroup.Name = "MDCalcSettingGroup";
            this.MDCalcSettingGroup.Size = new System.Drawing.Size(146, 67);
            this.MDCalcSettingGroup.TabIndex = 8;
            this.MDCalcSettingGroup.TabStop = false;
            this.MDCalcSettingGroup.Text = "계산 설정";
            // 
            // MDCalcSettingByTime
            // 
            this.MDCalcSettingByTime.AutoSize = true;
            this.MDCalcSettingByTime.Location = new System.Drawing.Point(7, 42);
            this.MDCalcSettingByTime.Name = "MDCalcSettingByTime";
            this.MDCalcSettingByTime.Size = new System.Drawing.Size(99, 16);
            this.MDCalcSettingByTime.TabIndex = 2;
            this.MDCalcSettingByTime.Tag = "ByTime";
            this.MDCalcSettingByTime.Text = "시간당 획득량";
            this.MDCalcSettingByTime.UseVisualStyleBackColor = true;
            // 
            // MDCalcSettingSum
            // 
            this.MDCalcSettingSum.AutoSize = true;
            this.MDCalcSettingSum.Checked = true;
            this.MDCalcSettingSum.Location = new System.Drawing.Point(7, 18);
            this.MDCalcSettingSum.Name = "MDCalcSettingSum";
            this.MDCalcSettingSum.Size = new System.Drawing.Size(75, 16);
            this.MDCalcSettingSum.TabIndex = 0;
            this.MDCalcSettingSum.TabStop = true;
            this.MDCalcSettingSum.Tag = "Sum";
            this.MDCalcSettingSum.Text = "총 획득량";
            this.MDCalcSettingSum.UseVisualStyleBackColor = true;
            // 
            // MDCalcResetButton
            // 
            this.MDCalcResetButton.BackgroundImage = global::Girls_FrontierLine_Supporter.Properties.Resources.iconrec1;
            this.MDCalcResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MDCalcResetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MDCalcResetButton.Location = new System.Drawing.Point(400, 136);
            this.MDCalcResetButton.Name = "MDCalcResetButton";
            this.MDCalcResetButton.Size = new System.Drawing.Size(63, 23);
            this.MDCalcResetButton.TabIndex = 7;
            this.MDCalcResetButton.Text = "초기화";
            this.MDCalcResetButton.UseVisualStyleBackColor = true;
            this.MDCalcResetButton.Click += new System.EventHandler(this.MDCalcResetButton_Click);
            // 
            // MDCalcPrintButton
            // 
            this.MDCalcPrintButton.BackgroundImage = global::Girls_FrontierLine_Supporter.Properties.Resources.iconrec1;
            this.MDCalcPrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MDCalcPrintButton.Location = new System.Drawing.Point(400, 102);
            this.MDCalcPrintButton.Name = "MDCalcPrintButton";
            this.MDCalcPrintButton.Size = new System.Drawing.Size(63, 28);
            this.MDCalcPrintButton.TabIndex = 6;
            this.MDCalcPrintButton.Text = "계산";
            this.MDCalcPrintButton.UseVisualStyleBackColor = true;
            this.MDCalcPrintButton.Click += new System.EventHandler(this.MDCalcPrintButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Location4);
            this.groupBox1.Controls.Add(this.Location3);
            this.groupBox1.Controls.Add(this.Location2);
            this.groupBox1.Controls.Add(this.Location1);
            this.groupBox1.Location = new System.Drawing.Point(248, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "지원장소 선택";
            // 
            // Location4
            // 
            this.Location4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location4.FormattingEnabled = true;
            this.Location4.Location = new System.Drawing.Point(167, 20);
            this.Location4.Name = "Location4";
            this.Location4.Size = new System.Drawing.Size(48, 20);
            this.Location4.TabIndex = 3;
            this.Location4.SelectedIndexChanged += new System.EventHandler(this.MDCalcLocation_SelectedIndexChanged);
            // 
            // Location3
            // 
            this.Location3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location3.FormattingEnabled = true;
            this.Location3.Location = new System.Drawing.Point(114, 20);
            this.Location3.Name = "Location3";
            this.Location3.Size = new System.Drawing.Size(48, 20);
            this.Location3.TabIndex = 2;
            this.Location3.SelectedIndexChanged += new System.EventHandler(this.MDCalcLocation_SelectedIndexChanged);
            // 
            // Location2
            // 
            this.Location2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location2.FormattingEnabled = true;
            this.Location2.Location = new System.Drawing.Point(60, 20);
            this.Location2.Name = "Location2";
            this.Location2.Size = new System.Drawing.Size(48, 20);
            this.Location2.TabIndex = 1;
            this.Location2.SelectedIndexChanged += new System.EventHandler(this.MDCalcLocation_SelectedIndexChanged);
            // 
            // Location1
            // 
            this.Location1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location1.FormattingEnabled = true;
            this.Location1.Location = new System.Drawing.Point(6, 20);
            this.Location1.Name = "Location1";
            this.Location1.Size = new System.Drawing.Size(48, 20);
            this.Location1.TabIndex = 0;
            this.Location1.SelectedIndexChanged += new System.EventHandler(this.MDCalcLocation_SelectedIndexChanged);
            // 
            // ResourceResultGroup
            // 
            this.ResourceResultGroup.Controls.Add(this.TokenResult);
            this.ResourceResultGroup.Controls.Add(this.EquipTicketResult);
            this.ResourceResultGroup.Controls.Add(this.DollTicketResult);
            this.ResourceResultGroup.Controls.Add(this.ProductionTicketResult);
            this.ResourceResultGroup.Controls.Add(this.RecoveryTicketResult);
            this.ResourceResultGroup.Controls.Add(this.TokenLabel);
            this.ResourceResultGroup.Controls.Add(this.RecoveryTicketLabel);
            this.ResourceResultGroup.Controls.Add(this.EquipTicketLabel);
            this.ResourceResultGroup.Controls.Add(this.ProductionTicketLabel);
            this.ResourceResultGroup.Controls.Add(this.DollTicketLabel);
            this.ResourceResultGroup.Controls.Add(this.TotalResult);
            this.ResourceResultGroup.Controls.Add(this.PartsResult);
            this.ResourceResultGroup.Controls.Add(this.FoodResult);
            this.ResourceResultGroup.Controls.Add(this.AmmoResult);
            this.ResourceResultGroup.Controls.Add(this.ManPowerResult);
            this.ResourceResultGroup.Controls.Add(this.TotalResourceLabel);
            this.ResourceResultGroup.Controls.Add(this.ManPowerLabel);
            this.ResourceResultGroup.Controls.Add(this.PartsLabel);
            this.ResourceResultGroup.Controls.Add(this.AmmoLabel);
            this.ResourceResultGroup.Controls.Add(this.FoodLabel);
            this.ResourceResultGroup.Location = new System.Drawing.Point(6, 20);
            this.ResourceResultGroup.Name = "ResourceResultGroup";
            this.ResourceResultGroup.Size = new System.Drawing.Size(235, 139);
            this.ResourceResultGroup.TabIndex = 4;
            this.ResourceResultGroup.TabStop = false;
            this.ResourceResultGroup.Text = "자원 획득량";
            // 
            // TokenResult
            // 
            this.TokenResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TokenResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TokenResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TokenResult.Location = new System.Drawing.Point(186, 109);
            this.TokenResult.Name = "TokenResult";
            this.TokenResult.Size = new System.Drawing.Size(41, 22);
            this.TokenResult.TabIndex = 19;
            this.TokenResult.Text = "0";
            this.TokenResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TokenResult.Visible = false;
            // 
            // EquipTicketResult
            // 
            this.EquipTicketResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EquipTicketResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EquipTicketResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipTicketResult.Location = new System.Drawing.Point(141, 109);
            this.EquipTicketResult.Name = "EquipTicketResult";
            this.EquipTicketResult.Size = new System.Drawing.Size(41, 22);
            this.EquipTicketResult.TabIndex = 18;
            this.EquipTicketResult.Text = "0";
            this.EquipTicketResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EquipTicketResult.Visible = false;
            // 
            // DollTicketResult
            // 
            this.DollTicketResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DollTicketResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DollTicketResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollTicketResult.Location = new System.Drawing.Point(96, 109);
            this.DollTicketResult.Name = "DollTicketResult";
            this.DollTicketResult.Size = new System.Drawing.Size(41, 22);
            this.DollTicketResult.TabIndex = 17;
            this.DollTicketResult.Text = "0";
            this.DollTicketResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DollTicketResult.Visible = false;
            // 
            // ProductionTicketResult
            // 
            this.ProductionTicketResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ProductionTicketResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductionTicketResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductionTicketResult.Location = new System.Drawing.Point(51, 109);
            this.ProductionTicketResult.Name = "ProductionTicketResult";
            this.ProductionTicketResult.Size = new System.Drawing.Size(41, 22);
            this.ProductionTicketResult.TabIndex = 16;
            this.ProductionTicketResult.Text = "0";
            this.ProductionTicketResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductionTicketResult.Visible = false;
            // 
            // RecoveryTicketResult
            // 
            this.RecoveryTicketResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RecoveryTicketResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecoveryTicketResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RecoveryTicketResult.Location = new System.Drawing.Point(6, 109);
            this.RecoveryTicketResult.Name = "RecoveryTicketResult";
            this.RecoveryTicketResult.Size = new System.Drawing.Size(41, 22);
            this.RecoveryTicketResult.TabIndex = 15;
            this.RecoveryTicketResult.Text = "0";
            this.RecoveryTicketResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecoveryTicketResult.Visible = false;
            // 
            // TokenLabel
            // 
            this.TokenLabel.AutoSize = true;
            this.TokenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TokenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TokenLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TokenLabel.ForeColor = System.Drawing.Color.Black;
            this.TokenLabel.Location = new System.Drawing.Point(186, 83);
            this.TokenLabel.Name = "TokenLabel";
            this.TokenLabel.Size = new System.Drawing.Size(41, 17);
            this.TokenLabel.TabIndex = 14;
            this.TokenLabel.Text = "토큰";
            this.TokenLabel.Visible = false;
            // 
            // RecoveryTicketLabel
            // 
            this.RecoveryTicketLabel.AutoSize = true;
            this.RecoveryTicketLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RecoveryTicketLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecoveryTicketLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RecoveryTicketLabel.Location = new System.Drawing.Point(6, 83);
            this.RecoveryTicketLabel.Name = "RecoveryTicketLabel";
            this.RecoveryTicketLabel.Size = new System.Drawing.Size(41, 17);
            this.RecoveryTicketLabel.TabIndex = 10;
            this.RecoveryTicketLabel.Text = "수복";
            this.RecoveryTicketLabel.Visible = false;
            // 
            // EquipTicketLabel
            // 
            this.EquipTicketLabel.AutoSize = true;
            this.EquipTicketLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EquipTicketLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EquipTicketLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipTicketLabel.ForeColor = System.Drawing.Color.Black;
            this.EquipTicketLabel.Location = new System.Drawing.Point(141, 83);
            this.EquipTicketLabel.Name = "EquipTicketLabel";
            this.EquipTicketLabel.Size = new System.Drawing.Size(41, 17);
            this.EquipTicketLabel.TabIndex = 13;
            this.EquipTicketLabel.Text = "장비";
            this.EquipTicketLabel.Visible = false;
            // 
            // ProductionTicketLabel
            // 
            this.ProductionTicketLabel.AutoSize = true;
            this.ProductionTicketLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ProductionTicketLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductionTicketLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductionTicketLabel.Location = new System.Drawing.Point(51, 83);
            this.ProductionTicketLabel.Name = "ProductionTicketLabel";
            this.ProductionTicketLabel.Size = new System.Drawing.Size(41, 17);
            this.ProductionTicketLabel.TabIndex = 11;
            this.ProductionTicketLabel.Text = "제조";
            this.ProductionTicketLabel.Visible = false;
            // 
            // DollTicketLabel
            // 
            this.DollTicketLabel.AutoSize = true;
            this.DollTicketLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DollTicketLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DollTicketLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollTicketLabel.ForeColor = System.Drawing.Color.Black;
            this.DollTicketLabel.Location = new System.Drawing.Point(96, 83);
            this.DollTicketLabel.Name = "DollTicketLabel";
            this.DollTicketLabel.Size = new System.Drawing.Size(41, 17);
            this.DollTicketLabel.TabIndex = 12;
            this.DollTicketLabel.Text = "인형";
            this.DollTicketLabel.Visible = false;
            // 
            // TotalResult
            // 
            this.TotalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TotalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalResult.Location = new System.Drawing.Point(186, 43);
            this.TotalResult.Name = "TotalResult";
            this.TotalResult.Size = new System.Drawing.Size(41, 22);
            this.TotalResult.TabIndex = 9;
            this.TotalResult.Text = "0";
            this.TotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalResult.Visible = false;
            // 
            // PartsResult
            // 
            this.PartsResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PartsResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartsResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PartsResult.Location = new System.Drawing.Point(141, 43);
            this.PartsResult.Name = "PartsResult";
            this.PartsResult.Size = new System.Drawing.Size(41, 22);
            this.PartsResult.TabIndex = 8;
            this.PartsResult.Text = "0";
            this.PartsResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodResult
            // 
            this.FoodResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FoodResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoodResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FoodResult.Location = new System.Drawing.Point(96, 43);
            this.FoodResult.Name = "FoodResult";
            this.FoodResult.Size = new System.Drawing.Size(41, 22);
            this.FoodResult.TabIndex = 7;
            this.FoodResult.Text = "0";
            this.FoodResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmmoResult
            // 
            this.AmmoResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AmmoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmmoResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AmmoResult.Location = new System.Drawing.Point(51, 43);
            this.AmmoResult.Name = "AmmoResult";
            this.AmmoResult.Size = new System.Drawing.Size(41, 22);
            this.AmmoResult.TabIndex = 6;
            this.AmmoResult.Text = "0";
            this.AmmoResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManPowerResult
            // 
            this.ManPowerResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ManPowerResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManPowerResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ManPowerResult.Location = new System.Drawing.Point(6, 43);
            this.ManPowerResult.Name = "ManPowerResult";
            this.ManPowerResult.Size = new System.Drawing.Size(41, 22);
            this.ManPowerResult.TabIndex = 5;
            this.ManPowerResult.Text = "0";
            this.ManPowerResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalResourceLabel
            // 
            this.TotalResourceLabel.AutoSize = true;
            this.TotalResourceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TotalResourceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalResourceLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalResourceLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalResourceLabel.Location = new System.Drawing.Point(186, 17);
            this.TotalResourceLabel.Name = "TotalResourceLabel";
            this.TotalResourceLabel.Size = new System.Drawing.Size(41, 17);
            this.TotalResourceLabel.TabIndex = 4;
            this.TotalResourceLabel.Text = "총합";
            this.TotalResourceLabel.Visible = false;
            // 
            // ManPowerLabel
            // 
            this.ManPowerLabel.AutoSize = true;
            this.ManPowerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ManPowerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManPowerLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ManPowerLabel.Location = new System.Drawing.Point(6, 17);
            this.ManPowerLabel.Name = "ManPowerLabel";
            this.ManPowerLabel.Size = new System.Drawing.Size(41, 17);
            this.ManPowerLabel.TabIndex = 0;
            this.ManPowerLabel.Text = "인력";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PartsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartsLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PartsLabel.ForeColor = System.Drawing.Color.Black;
            this.PartsLabel.Location = new System.Drawing.Point(141, 17);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(41, 17);
            this.PartsLabel.TabIndex = 3;
            this.PartsLabel.Text = "부품";
            // 
            // AmmoLabel
            // 
            this.AmmoLabel.AutoSize = true;
            this.AmmoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AmmoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmmoLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AmmoLabel.Location = new System.Drawing.Point(51, 17);
            this.AmmoLabel.Name = "AmmoLabel";
            this.AmmoLabel.Size = new System.Drawing.Size(41, 17);
            this.AmmoLabel.TabIndex = 1;
            this.AmmoLabel.Text = "탄약";
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FoodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoodLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FoodLabel.ForeColor = System.Drawing.Color.Black;
            this.FoodLabel.Location = new System.Drawing.Point(96, 17);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(41, 17);
            this.FoodLabel.TabIndex = 2;
            this.FoodLabel.Text = "식량";
            // 
            // MDListGroup
            // 
            this.MDListGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MDListGroup.Controls.Add(this.MDList);
            this.MDListGroup.Location = new System.Drawing.Point(6, 6);
            this.MDListGroup.Name = "MDListGroup";
            this.MDListGroup.Size = new System.Drawing.Size(475, 395);
            this.MDListGroup.TabIndex = 0;
            this.MDListGroup.TabStop = false;
            this.MDListGroup.Text = "군수 지원 리스트";
            // 
            // MDList
            // 
            this.MDList.ColumnCount = 8;
            this.MDList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MDList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MDList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MDList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MDList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MDList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MDList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MDList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MDList.Controls.Add(this.MDListView, 7, 0);
            this.MDList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MDList.Location = new System.Drawing.Point(3, 17);
            this.MDList.Name = "MDList";
            this.MDList.RowCount = 1;
            this.MDList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MDList.Size = new System.Drawing.Size(469, 375);
            this.MDList.TabIndex = 0;
            // 
            // MDListView
            // 
            this.MDListView.AllowColumnReorder = true;
            this.MDListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MDLocation,
            this.MinLevel,
            this.Time,
            this.MDManPower,
            this.MDAmmo,
            this.MDFood,
            this.MDParts,
            this.MDManPowerByTime,
            this.MDAmmoByTime,
            this.MDFoodByTime,
            this.MDPartsByTime,
            this.MDAdditional});
            this.MDListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MDListView.FullRowSelect = true;
            this.MDListView.HideSelection = false;
            this.MDListView.Location = new System.Drawing.Point(3, 3);
            this.MDListView.MultiSelect = false;
            this.MDListView.Name = "MDListView";
            this.MDListView.Size = new System.Drawing.Size(463, 369);
            this.MDListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.MDListView.TabIndex = 0;
            this.MDListView.UseCompatibleStateImageBehavior = false;
            this.MDListView.View = System.Windows.Forms.View.Details;
            this.MDListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            // 
            // MDLocation
            // 
            this.MDLocation.Tag = "MDLocation";
            this.MDLocation.Text = "장소";
            this.MDLocation.Width = 46;
            // 
            // MinLevel
            // 
            this.MinLevel.Tag = "Numeric";
            this.MinLevel.Text = "최소 레벨";
            this.MinLevel.Width = 70;
            // 
            // Time
            // 
            this.Time.Tag = "Time";
            this.Time.Text = "소요 시간";
            this.Time.Width = 70;
            // 
            // MDManPower
            // 
            this.MDManPower.Tag = "Numeric";
            this.MDManPower.Text = "인력";
            // 
            // MDAmmo
            // 
            this.MDAmmo.Tag = "Numeric";
            this.MDAmmo.Text = "탄약";
            // 
            // MDFood
            // 
            this.MDFood.Tag = "Numeric";
            this.MDFood.Text = "식량";
            // 
            // MDParts
            // 
            this.MDParts.Tag = "Numeric";
            this.MDParts.Text = "부품";
            this.MDParts.Width = 54;
            // 
            // MDManPowerByTime
            // 
            this.MDManPowerByTime.Tag = "Numeric";
            this.MDManPowerByTime.Text = "인력(시간당)";
            this.MDManPowerByTime.Width = 70;
            // 
            // MDAmmoByTime
            // 
            this.MDAmmoByTime.Tag = "Numeric";
            this.MDAmmoByTime.Text = "탄약(시간당)";
            this.MDAmmoByTime.Width = 70;
            // 
            // MDFoodByTime
            // 
            this.MDFoodByTime.Tag = "Numeric";
            this.MDFoodByTime.Text = "식량(시간당)";
            this.MDFoodByTime.Width = 70;
            // 
            // MDPartsByTime
            // 
            this.MDPartsByTime.Tag = "Numeric";
            this.MDPartsByTime.Text = "부품(시간당)";
            this.MDPartsByTime.Width = 70;
            // 
            // MDAdditional
            // 
            this.MDAdditional.Text = "추가 획득";
            this.MDAdditional.Width = 200;
            // 
            // Doll
            // 
            this.Doll.Controls.Add(this.DollSubTab);
            this.Doll.Location = new System.Drawing.Point(4, 22);
            this.Doll.Name = "Doll";
            this.Doll.Padding = new System.Windows.Forms.Padding(3);
            this.Doll.Size = new System.Drawing.Size(873, 579);
            this.Doll.TabIndex = 4;
            this.Doll.Text = "인형";
            this.Doll.UseVisualStyleBackColor = true;
            // 
            // DollSubTab
            // 
            this.DollSubTab.Controls.Add(this.DollDIc);
            this.DollSubTab.Controls.Add(this.EnemyDic);
            this.DollSubTab.Controls.Add(this.FormationSimulator);
            this.DollSubTab.Controls.Add(this.LevelingCalc);
            this.DollSubTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DollSubTab.Location = new System.Drawing.Point(3, 3);
            this.DollSubTab.Name = "DollSubTab";
            this.DollSubTab.SelectedIndex = 0;
            this.DollSubTab.Size = new System.Drawing.Size(867, 573);
            this.DollSubTab.TabIndex = 0;
            // 
            // DollDIc
            // 
            this.DollDIc.Controls.Add(this.DollSearchGroup);
            this.DollDIc.Controls.Add(this.DollInfoGroup);
            this.DollDIc.Location = new System.Drawing.Point(4, 22);
            this.DollDIc.Name = "DollDIc";
            this.DollDIc.Padding = new System.Windows.Forms.Padding(3);
            this.DollDIc.Size = new System.Drawing.Size(859, 547);
            this.DollDIc.TabIndex = 0;
            this.DollDIc.Text = "인형 도감";
            this.DollDIc.UseVisualStyleBackColor = true;
            // 
            // DollSearchGroup
            // 
            this.DollSearchGroup.Controls.Add(this.ModSelectorGroup);
            this.DollSearchGroup.Controls.Add(this.label66);
            this.DollSearchGroup.Controls.Add(this.DollDetailInfoWebNamuWiki);
            this.DollSearchGroup.Controls.Add(this.VoiceSelectorGroup);
            this.DollSearchGroup.Controls.Add(this.DollDetailInfoWebDDB);
            this.DollSearchGroup.Controls.Add(this.DollProductTimeTableButton);
            this.DollSearchGroup.Controls.Add(this.GradeSelectorGroup);
            this.DollSearchGroup.Controls.Add(this.TypeSelectorGroup);
            this.DollSearchGroup.Controls.Add(this.DollListView);
            this.DollSearchGroup.Controls.Add(this.DollSearchTextBox);
            this.DollSearchGroup.Location = new System.Drawing.Point(449, 2);
            this.DollSearchGroup.Name = "DollSearchGroup";
            this.DollSearchGroup.Size = new System.Drawing.Size(407, 542);
            this.DollSearchGroup.TabIndex = 3;
            this.DollSearchGroup.TabStop = false;
            this.DollSearchGroup.Text = "검색";
            // 
            // ModSelectorGroup
            // 
            this.ModSelectorGroup.Controls.Add(this.ModYes);
            this.ModSelectorGroup.Controls.Add(this.ModNo);
            this.ModSelectorGroup.Location = new System.Drawing.Point(163, 48);
            this.ModSelectorGroup.Name = "ModSelectorGroup";
            this.ModSelectorGroup.Size = new System.Drawing.Size(107, 39);
            this.ModSelectorGroup.TabIndex = 7;
            this.ModSelectorGroup.TabStop = false;
            this.ModSelectorGroup.Text = "보이스 유무";
            // 
            // ModYes
            // 
            this.ModYes.AutoSize = true;
            this.ModYes.Checked = true;
            this.ModYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ModYes.Location = new System.Drawing.Point(9, 17);
            this.ModYes.Name = "ModYes";
            this.ModYes.Size = new System.Drawing.Size(48, 16);
            this.ModYes.TabIndex = 3;
            this.ModYes.Tag = "2";
            this.ModYes.Text = "있음";
            this.ModYes.UseVisualStyleBackColor = true;
            this.ModYes.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // ModNo
            // 
            this.ModNo.AutoSize = true;
            this.ModNo.Checked = true;
            this.ModNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ModNo.Location = new System.Drawing.Point(59, 17);
            this.ModNo.Name = "ModNo";
            this.ModNo.Size = new System.Drawing.Size(48, 16);
            this.ModNo.TabIndex = 1;
            this.ModNo.Tag = "2";
            this.ModNo.Text = "없음";
            this.ModNo.UseVisualStyleBackColor = true;
            this.ModNo.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 25);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(77, 12);
            this.label66.TabIndex = 11;
            this.label66.Text = "검색할 인형 :";
            // 
            // DollDetailInfoWebNamuWiki
            // 
            this.DollDetailInfoWebNamuWiki.AutoSize = true;
            this.DollDetailInfoWebNamuWiki.Location = new System.Drawing.Point(135, 230);
            this.DollDetailInfoWebNamuWiki.Name = "DollDetailInfoWebNamuWiki";
            this.DollDetailInfoWebNamuWiki.Size = new System.Drawing.Size(259, 12);
            this.DollDetailInfoWebNamuWiki.TabIndex = 10;
            this.DollDetailInfoWebNamuWiki.TabStop = true;
            this.DollDetailInfoWebNamuWiki.Text = "해당 인형의 더 많은 정보 보러 가기 (나무위키)";
            this.DollDetailInfoWebNamuWiki.Visible = false;
            this.DollDetailInfoWebNamuWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DollDetailInfoWebNamuWiki_LinkClicked);
            // 
            // VoiceSelectorGroup
            // 
            this.VoiceSelectorGroup.Controls.Add(this.VoiceYes);
            this.VoiceSelectorGroup.Controls.Add(this.VoiceNo);
            this.VoiceSelectorGroup.Location = new System.Drawing.Point(283, 48);
            this.VoiceSelectorGroup.Name = "VoiceSelectorGroup";
            this.VoiceSelectorGroup.Size = new System.Drawing.Size(107, 39);
            this.VoiceSelectorGroup.TabIndex = 6;
            this.VoiceSelectorGroup.TabStop = false;
            this.VoiceSelectorGroup.Text = "보이스 유무";
            // 
            // VoiceYes
            // 
            this.VoiceYes.AutoSize = true;
            this.VoiceYes.Checked = true;
            this.VoiceYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VoiceYes.Location = new System.Drawing.Point(9, 17);
            this.VoiceYes.Name = "VoiceYes";
            this.VoiceYes.Size = new System.Drawing.Size(48, 16);
            this.VoiceYes.TabIndex = 3;
            this.VoiceYes.Tag = "2";
            this.VoiceYes.Text = "있음";
            this.VoiceYes.UseVisualStyleBackColor = true;
            this.VoiceYes.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // VoiceNo
            // 
            this.VoiceNo.AutoSize = true;
            this.VoiceNo.Checked = true;
            this.VoiceNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VoiceNo.Location = new System.Drawing.Point(59, 17);
            this.VoiceNo.Name = "VoiceNo";
            this.VoiceNo.Size = new System.Drawing.Size(48, 16);
            this.VoiceNo.TabIndex = 1;
            this.VoiceNo.Tag = "2";
            this.VoiceNo.Text = "없음";
            this.VoiceNo.UseVisualStyleBackColor = true;
            this.VoiceNo.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // DollDetailInfoWebDDB
            // 
            this.DollDetailInfoWebDDB.AutoSize = true;
            this.DollDetailInfoWebDDB.Enabled = false;
            this.DollDetailInfoWebDDB.Location = new System.Drawing.Point(119, 204);
            this.DollDetailInfoWebDDB.Name = "DollDetailInfoWebDDB";
            this.DollDetailInfoWebDDB.Size = new System.Drawing.Size(275, 12);
            this.DollDetailInfoWebDDB.TabIndex = 9;
            this.DollDetailInfoWebDDB.TabStop = true;
            this.DollDetailInfoWebDDB.Text = "해당 인형의 더 많은 정보 보러 가기 (댕댕 베이스)";
            this.DollDetailInfoWebDDB.Visible = false;
            this.DollDetailInfoWebDDB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DollDetailInfoWebDDB_LinkClicked);
            // 
            // DollProductTimeTableButton
            // 
            this.DollProductTimeTableButton.Location = new System.Drawing.Point(126, 253);
            this.DollProductTimeTableButton.Name = "DollProductTimeTableButton";
            this.DollProductTimeTableButton.Size = new System.Drawing.Size(268, 30);
            this.DollProductTimeTableButton.TabIndex = 8;
            this.DollProductTimeTableButton.Text = "제조 시간표 열람";
            this.DollProductTimeTableButton.UseVisualStyleBackColor = true;
            this.DollProductTimeTableButton.Click += new System.EventHandler(this.DollProductTimeTableButton_Click);
            // 
            // GradeSelectorGroup
            // 
            this.GradeSelectorGroup.Controls.Add(this.GradeExtra);
            this.GradeSelectorGroup.Controls.Add(this.Grade5);
            this.GradeSelectorGroup.Controls.Add(this.Grade4);
            this.GradeSelectorGroup.Controls.Add(this.Grade3);
            this.GradeSelectorGroup.Controls.Add(this.Grade2);
            this.GradeSelectorGroup.Location = new System.Drawing.Point(6, 124);
            this.GradeSelectorGroup.Name = "GradeSelectorGroup";
            this.GradeSelectorGroup.Size = new System.Drawing.Size(99, 160);
            this.GradeSelectorGroup.TabIndex = 6;
            this.GradeSelectorGroup.TabStop = false;
            this.GradeSelectorGroup.Text = "등급";
            // 
            // GradeExtra
            // 
            this.GradeExtra.AutoSize = true;
            this.GradeExtra.Checked = true;
            this.GradeExtra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GradeExtra.Location = new System.Drawing.Point(6, 137);
            this.GradeExtra.Name = "GradeExtra";
            this.GradeExtra.Size = new System.Drawing.Size(36, 16);
            this.GradeExtra.TabIndex = 4;
            this.GradeExtra.Tag = "0";
            this.GradeExtra.Text = "★";
            this.GradeExtra.UseVisualStyleBackColor = true;
            this.GradeExtra.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // Grade5
            // 
            this.Grade5.AutoSize = true;
            this.Grade5.Checked = true;
            this.Grade5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Grade5.Location = new System.Drawing.Point(6, 106);
            this.Grade5.Name = "Grade5";
            this.Grade5.Size = new System.Drawing.Size(84, 16);
            this.Grade5.TabIndex = 3;
            this.Grade5.Tag = "5";
            this.Grade5.Text = "☆☆☆☆☆";
            this.Grade5.UseVisualStyleBackColor = true;
            this.Grade5.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // Grade4
            // 
            this.Grade4.AutoSize = true;
            this.Grade4.Checked = true;
            this.Grade4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Grade4.Location = new System.Drawing.Point(6, 76);
            this.Grade4.Name = "Grade4";
            this.Grade4.Size = new System.Drawing.Size(72, 16);
            this.Grade4.TabIndex = 2;
            this.Grade4.Tag = "4";
            this.Grade4.Text = "☆☆☆☆";
            this.Grade4.UseVisualStyleBackColor = true;
            this.Grade4.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // Grade3
            // 
            this.Grade3.AutoSize = true;
            this.Grade3.Checked = true;
            this.Grade3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Grade3.Location = new System.Drawing.Point(6, 46);
            this.Grade3.Name = "Grade3";
            this.Grade3.Size = new System.Drawing.Size(60, 16);
            this.Grade3.TabIndex = 1;
            this.Grade3.Tag = "3";
            this.Grade3.Text = "☆☆☆";
            this.Grade3.UseVisualStyleBackColor = true;
            this.Grade3.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // Grade2
            // 
            this.Grade2.AutoSize = true;
            this.Grade2.Checked = true;
            this.Grade2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Grade2.Location = new System.Drawing.Point(6, 16);
            this.Grade2.Name = "Grade2";
            this.Grade2.Size = new System.Drawing.Size(48, 16);
            this.Grade2.TabIndex = 0;
            this.Grade2.Tag = "2";
            this.Grade2.Text = "☆☆";
            this.Grade2.UseVisualStyleBackColor = true;
            this.Grade2.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // TypeSelectorGroup
            // 
            this.TypeSelectorGroup.Controls.Add(this.TypeRF);
            this.TypeSelectorGroup.Controls.Add(this.TypeSG);
            this.TypeSelectorGroup.Controls.Add(this.TypeMG);
            this.TypeSelectorGroup.Controls.Add(this.TypeHG);
            this.TypeSelectorGroup.Controls.Add(this.TypeAR);
            this.TypeSelectorGroup.Controls.Add(this.TypeSMG);
            this.TypeSelectorGroup.Location = new System.Drawing.Point(6, 47);
            this.TypeSelectorGroup.Name = "TypeSelectorGroup";
            this.TypeSelectorGroup.Size = new System.Drawing.Size(151, 71);
            this.TypeSelectorGroup.TabIndex = 5;
            this.TypeSelectorGroup.TabStop = false;
            this.TypeSelectorGroup.Text = "타입";
            // 
            // TypeRF
            // 
            this.TypeRF.AutoSize = true;
            this.TypeRF.Checked = true;
            this.TypeRF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeRF.Location = new System.Drawing.Point(104, 39);
            this.TypeRF.Name = "TypeRF";
            this.TypeRF.Size = new System.Drawing.Size(39, 16);
            this.TypeRF.TabIndex = 5;
            this.TypeRF.Tag = "2";
            this.TypeRF.Text = "RF";
            this.TypeRF.UseVisualStyleBackColor = true;
            this.TypeRF.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // TypeSG
            // 
            this.TypeSG.AutoSize = true;
            this.TypeSG.Checked = true;
            this.TypeSG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeSG.Location = new System.Drawing.Point(59, 39);
            this.TypeSG.Name = "TypeSG";
            this.TypeSG.Size = new System.Drawing.Size(41, 16);
            this.TypeSG.TabIndex = 4;
            this.TypeSG.Tag = "2";
            this.TypeSG.Text = "SG";
            this.TypeSG.UseVisualStyleBackColor = true;
            this.TypeSG.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // TypeMG
            // 
            this.TypeMG.AutoSize = true;
            this.TypeMG.Checked = true;
            this.TypeMG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeMG.Location = new System.Drawing.Point(9, 17);
            this.TypeMG.Name = "TypeMG";
            this.TypeMG.Size = new System.Drawing.Size(44, 16);
            this.TypeMG.TabIndex = 3;
            this.TypeMG.Tag = "2";
            this.TypeMG.Text = "MG";
            this.TypeMG.UseVisualStyleBackColor = true;
            this.TypeMG.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // TypeHG
            // 
            this.TypeHG.AutoSize = true;
            this.TypeHG.Checked = true;
            this.TypeHG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeHG.Location = new System.Drawing.Point(105, 17);
            this.TypeHG.Name = "TypeHG";
            this.TypeHG.Size = new System.Drawing.Size(41, 16);
            this.TypeHG.TabIndex = 2;
            this.TypeHG.Tag = "2";
            this.TypeHG.Text = "HG";
            this.TypeHG.UseVisualStyleBackColor = true;
            this.TypeHG.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // TypeAR
            // 
            this.TypeAR.AutoSize = true;
            this.TypeAR.Checked = true;
            this.TypeAR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeAR.Location = new System.Drawing.Point(59, 17);
            this.TypeAR.Name = "TypeAR";
            this.TypeAR.Size = new System.Drawing.Size(40, 16);
            this.TypeAR.TabIndex = 1;
            this.TypeAR.Tag = "2";
            this.TypeAR.Text = "AR";
            this.TypeAR.UseVisualStyleBackColor = true;
            this.TypeAR.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // TypeSMG
            // 
            this.TypeSMG.AutoSize = true;
            this.TypeSMG.Checked = true;
            this.TypeSMG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeSMG.Location = new System.Drawing.Point(9, 39);
            this.TypeSMG.Name = "TypeSMG";
            this.TypeSMG.Size = new System.Drawing.Size(52, 16);
            this.TypeSMG.TabIndex = 0;
            this.TypeSMG.Tag = "2";
            this.TypeSMG.Text = "SMG";
            this.TypeSMG.UseVisualStyleBackColor = true;
            this.TypeSMG.CheckedChanged += new System.EventHandler(this.DollSearchSetting_CheckedChanged);
            // 
            // DollListView
            // 
            this.DollListView.AllowColumnReorder = true;
            this.DollListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DollName,
            this.Type,
            this.Grade,
            this.ProductTime,
            this.HasCostume,
            this.HasMod});
            this.DollListView.FullRowSelect = true;
            this.DollListView.GridLines = true;
            this.DollListView.HideSelection = false;
            this.DollListView.Location = new System.Drawing.Point(7, 297);
            this.DollListView.MultiSelect = false;
            this.DollListView.Name = "DollListView";
            this.DollListView.Size = new System.Drawing.Size(398, 239);
            this.DollListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.DollListView.TabIndex = 4;
            this.DollListView.UseCompatibleStateImageBehavior = false;
            this.DollListView.View = System.Windows.Forms.View.Details;
            this.DollListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            this.DollListView.SelectedIndexChanged += new System.EventHandler(this.DollListView_SelectedIndexChanged);
            // 
            // DollName
            // 
            this.DollName.Text = "이름";
            this.DollName.Width = 150;
            // 
            // Type
            // 
            this.Type.Text = "타입";
            // 
            // Grade
            // 
            this.Grade.Tag = "";
            this.Grade.Text = "등급";
            this.Grade.Width = 100;
            // 
            // ProductTime
            // 
            this.ProductTime.Tag = "Time";
            this.ProductTime.Text = "제조 시간";
            this.ProductTime.Width = 70;
            // 
            // HasCostume
            // 
            this.HasCostume.Text = "코스튬 유무";
            // 
            // HasMod
            // 
            this.HasMod.Text = "모드 유무";
            // 
            // DollSearchTextBox
            // 
            this.DollSearchTextBox.Location = new System.Drawing.Point(91, 20);
            this.DollSearchTextBox.Name = "DollSearchTextBox";
            this.DollSearchTextBox.Size = new System.Drawing.Size(310, 21);
            this.DollSearchTextBox.TabIndex = 3;
            this.DollSearchTextBox.TextChanged += new System.EventHandler(this.DollSearchTextBox_TextChanged);
            // 
            // DollInfoGroup
            // 
            this.DollInfoGroup.Controls.Add(this.DollAbilityChartButton);
            this.DollInfoGroup.Controls.Add(this.DollModStatus);
            this.DollInfoGroup.Controls.Add(this.DollModSelectorNext);
            this.DollInfoGroup.Controls.Add(this.DollModSelectorPrevious);
            this.DollInfoGroup.Controls.Add(this.DollModelCountryIcon);
            this.DollInfoGroup.Controls.Add(this.DollSDImageLoadProgress);
            this.DollInfoGroup.Controls.Add(this.DollImageLoadProcess);
            this.DollInfoGroup.Controls.Add(this.label12);
            this.DollInfoGroup.Controls.Add(this.label5);
            this.DollInfoGroup.Controls.Add(this.DollModelLabel);
            this.DollInfoGroup.Controls.Add(this.DollSkillInfoButton);
            this.DollInfoGroup.Controls.Add(this.DollDropEventInfoButton);
            this.DollInfoGroup.Controls.Add(this.DollVoiceList);
            this.DollInfoGroup.Controls.Add(this.DollVoicePlayButton);
            this.DollInfoGroup.Controls.Add(this.DollBaseDamage);
            this.DollInfoGroup.Controls.Add(this.DollReloadTimeLabel);
            this.DollInfoGroup.Controls.Add(this.DollTypeImageBox);
            this.DollInfoGroup.Controls.Add(this.DollBulletCountLabel);
            this.DollInfoGroup.Controls.Add(this.DollBulletProgress);
            this.DollInfoGroup.Controls.Add(this.DollBulletLabel);
            this.DollInfoGroup.Controls.Add(this.DollArmorCountLabel);
            this.DollInfoGroup.Controls.Add(this.DollArmorProgress);
            this.DollInfoGroup.Controls.Add(this.DollArmorLabel);
            this.DollInfoGroup.Controls.Add(this.DollEffectGroup);
            this.DollInfoGroup.Controls.Add(this.DollProductTimeLabel);
            this.DollInfoGroup.Controls.Add(this.DollImageSDBox);
            this.DollInfoGroup.Controls.Add(this.DollFRCountLabel);
            this.DollInfoGroup.Controls.Add(this.DollEVCountLabel);
            this.DollInfoGroup.Controls.Add(this.DollACCountLabel);
            this.DollInfoGroup.Controls.Add(this.DollASCountLabel);
            this.DollInfoGroup.Controls.Add(this.DollHPCountLabel);
            this.DollInfoGroup.Controls.Add(this.DollASProgress);
            this.DollInfoGroup.Controls.Add(this.DollACProgress);
            this.DollInfoGroup.Controls.Add(this.DollEVProgress);
            this.DollInfoGroup.Controls.Add(this.DollFRProgress);
            this.DollInfoGroup.Controls.Add(this.DollHPProgress);
            this.DollInfoGroup.Controls.Add(this.DollASLabel);
            this.DollInfoGroup.Controls.Add(this.DollACLabel);
            this.DollInfoGroup.Controls.Add(this.DollEVLabel);
            this.DollInfoGroup.Controls.Add(this.DollFRLabel);
            this.DollInfoGroup.Controls.Add(this.DollHPLabel);
            this.DollInfoGroup.Controls.Add(this.DollNumLabel);
            this.DollInfoGroup.Controls.Add(this.DollNameLabel);
            this.DollInfoGroup.Controls.Add(this.DollImageBox);
            this.DollInfoGroup.Location = new System.Drawing.Point(0, 2);
            this.DollInfoGroup.Name = "DollInfoGroup";
            this.DollInfoGroup.Size = new System.Drawing.Size(446, 545);
            this.DollInfoGroup.TabIndex = 2;
            this.DollInfoGroup.TabStop = false;
            this.DollInfoGroup.Text = "정보";
            this.DollInfoGroup.Visible = false;
            // 
            // DollAbilityChartButton
            // 
            this.DollAbilityChartButton.BackgroundImage = global::Girls_FrontierLine_Supporter.Properties.Resources.RadarChart_Icon;
            this.DollAbilityChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DollAbilityChartButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollAbilityChartButton.Location = new System.Drawing.Point(233, 361);
            this.DollAbilityChartButton.Name = "DollAbilityChartButton";
            this.DollAbilityChartButton.Size = new System.Drawing.Size(60, 58);
            this.DollAbilityChartButton.TabIndex = 45;
            this.DollAbilityChartButton.UseVisualStyleBackColor = true;
            this.DollAbilityChartButton.Click += new System.EventHandler(this.DollAbilityChartButton_Click);
            // 
            // DollModStatus
            // 
            this.DollModStatus.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollModStatus.Location = new System.Drawing.Point(46, 61);
            this.DollModStatus.Name = "DollModStatus";
            this.DollModStatus.Size = new System.Drawing.Size(108, 23);
            this.DollModStatus.TabIndex = 43;
            this.DollModStatus.Tag = "0";
            this.DollModStatus.Text = "Normal";
            this.DollModStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollModSelectorNext
            // 
            this.DollModSelectorNext.Location = new System.Drawing.Point(161, 55);
            this.DollModSelectorNext.Name = "DollModSelectorNext";
            this.DollModSelectorNext.Size = new System.Drawing.Size(33, 32);
            this.DollModSelectorNext.TabIndex = 42;
            this.DollModSelectorNext.Text = ">";
            this.DollModSelectorNext.UseVisualStyleBackColor = true;
            this.DollModSelectorNext.Click += new System.EventHandler(this.DollModSelector_Click);
            // 
            // DollModSelectorPrevious
            // 
            this.DollModSelectorPrevious.Location = new System.Drawing.Point(6, 55);
            this.DollModSelectorPrevious.Name = "DollModSelectorPrevious";
            this.DollModSelectorPrevious.Size = new System.Drawing.Size(33, 32);
            this.DollModSelectorPrevious.TabIndex = 41;
            this.DollModSelectorPrevious.Text = "<";
            this.DollModSelectorPrevious.UseVisualStyleBackColor = true;
            this.DollModSelectorPrevious.Click += new System.EventHandler(this.DollModSelector_Click);
            // 
            // DollModelCountryIcon
            // 
            this.DollModelCountryIcon.Location = new System.Drawing.Point(200, 55);
            this.DollModelCountryIcon.Name = "DollModelCountryIcon";
            this.DollModelCountryIcon.Size = new System.Drawing.Size(54, 36);
            this.DollModelCountryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DollModelCountryIcon.TabIndex = 40;
            this.DollModelCountryIcon.TabStop = false;
            // 
            // DollSDImageLoadProgress
            // 
            this.DollSDImageLoadProgress.Location = new System.Drawing.Point(232, 252);
            this.DollSDImageLoadProgress.Name = "DollSDImageLoadProgress";
            this.DollSDImageLoadProgress.Size = new System.Drawing.Size(206, 5);
            this.DollSDImageLoadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DollSDImageLoadProgress.TabIndex = 39;
            this.DollSDImageLoadProgress.Visible = false;
            // 
            // DollImageLoadProcess
            // 
            this.DollImageLoadProcess.Location = new System.Drawing.Point(6, 350);
            this.DollImageLoadProcess.Name = "DollImageLoadProcess";
            this.DollImageLoadProcess.Size = new System.Drawing.Size(219, 5);
            this.DollImageLoadProcess.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DollImageLoadProcess.TabIndex = 38;
            this.DollImageLoadProcess.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(298, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 11);
            this.label12.TabIndex = 37;
            this.label12.Text = "실제 총기 모델";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(83, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 11);
            this.label5.TabIndex = 36;
            this.label5.Text = "인형 이름";
            // 
            // DollModelLabel
            // 
            this.DollModelLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DollModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollModelLabel.Location = new System.Drawing.Point(232, 25);
            this.DollModelLabel.Name = "DollModelLabel";
            this.DollModelLabel.Size = new System.Drawing.Size(208, 27);
            this.DollModelLabel.TabIndex = 35;
            this.DollModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollSkillInfoButton
            // 
            this.DollSkillInfoButton.Location = new System.Drawing.Point(376, 396);
            this.DollSkillInfoButton.Name = "DollSkillInfoButton";
            this.DollSkillInfoButton.Size = new System.Drawing.Size(67, 23);
            this.DollSkillInfoButton.TabIndex = 34;
            this.DollSkillInfoButton.Text = "스킬 정보";
            this.DollSkillInfoButton.UseVisualStyleBackColor = true;
            this.DollSkillInfoButton.Click += new System.EventHandler(this.DollSkillInfoButton_Click);
            // 
            // DollDropEventInfoButton
            // 
            this.DollDropEventInfoButton.Location = new System.Drawing.Point(299, 396);
            this.DollDropEventInfoButton.Name = "DollDropEventInfoButton";
            this.DollDropEventInfoButton.Size = new System.Drawing.Size(67, 23);
            this.DollDropEventInfoButton.TabIndex = 33;
            this.DollDropEventInfoButton.Text = "획득 방법";
            this.DollDropEventInfoButton.UseVisualStyleBackColor = true;
            this.DollDropEventInfoButton.Click += new System.EventHandler(this.DollDropEventInfoButton_Click);
            // 
            // DollVoiceList
            // 
            this.DollVoiceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DollVoiceList.FormattingEnabled = true;
            this.DollVoiceList.Location = new System.Drawing.Point(300, 361);
            this.DollVoiceList.Name = "DollVoiceList";
            this.DollVoiceList.Size = new System.Drawing.Size(98, 20);
            this.DollVoiceList.TabIndex = 32;
            // 
            // DollVoicePlayButton
            // 
            this.DollVoicePlayButton.BackgroundImage = global::Girls_FrontierLine_Supporter.Properties.Resources.play;
            this.DollVoicePlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DollVoicePlayButton.Location = new System.Drawing.Point(404, 361);
            this.DollVoicePlayButton.Name = "DollVoicePlayButton";
            this.DollVoicePlayButton.Size = new System.Drawing.Size(36, 20);
            this.DollVoicePlayButton.TabIndex = 31;
            this.DollVoicePlayButton.UseVisualStyleBackColor = true;
            this.DollVoicePlayButton.Visible = false;
            this.DollVoicePlayButton.Click += new System.EventHandler(this.DollVoicePlayButton_Click);
            // 
            // DollBaseDamage
            // 
            this.DollBaseDamage.AutoSize = true;
            this.DollBaseDamage.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollBaseDamage.ForeColor = System.Drawing.Color.Teal;
            this.DollBaseDamage.Location = new System.Drawing.Point(273, 449);
            this.DollBaseDamage.Name = "DollBaseDamage";
            this.DollBaseDamage.Size = new System.Drawing.Size(21, 11);
            this.DollBaseDamage.TabIndex = 30;
            this.DollBaseDamage.Text = "    ";
            // 
            // DollReloadTimeLabel
            // 
            this.DollReloadTimeLabel.AutoSize = true;
            this.DollReloadTimeLabel.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollReloadTimeLabel.ForeColor = System.Drawing.Color.Teal;
            this.DollReloadTimeLabel.Location = new System.Drawing.Point(273, 471);
            this.DollReloadTimeLabel.Name = "DollReloadTimeLabel";
            this.DollReloadTimeLabel.Size = new System.Drawing.Size(21, 11);
            this.DollReloadTimeLabel.TabIndex = 29;
            this.DollReloadTimeLabel.Text = "    ";
            // 
            // DollTypeImageBox
            // 
            this.DollTypeImageBox.Location = new System.Drawing.Point(266, 52);
            this.DollTypeImageBox.Name = "DollTypeImageBox";
            this.DollTypeImageBox.Size = new System.Drawing.Size(80, 40);
            this.DollTypeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DollTypeImageBox.TabIndex = 28;
            this.DollTypeImageBox.TabStop = false;
            // 
            // DollBulletCountLabel
            // 
            this.DollBulletCountLabel.AutoSize = true;
            this.DollBulletCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollBulletCountLabel.Location = new System.Drawing.Point(356, 491);
            this.DollBulletCountLabel.Name = "DollBulletCountLabel";
            this.DollBulletCountLabel.Size = new System.Drawing.Size(21, 20);
            this.DollBulletCountLabel.TabIndex = 27;
            this.DollBulletCountLabel.Text = "   ";
            this.DollBulletCountLabel.Visible = false;
            // 
            // DollBulletProgress
            // 
            this.DollBulletProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DollBulletProgress.ForeColor = System.Drawing.Color.Red;
            this.DollBulletProgress.Location = new System.Drawing.Point(275, 493);
            this.DollBulletProgress.Maximum = 15;
            this.DollBulletProgress.Name = "DollBulletProgress";
            this.DollBulletProgress.Size = new System.Drawing.Size(72, 12);
            this.DollBulletProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DollBulletProgress.TabIndex = 26;
            this.DollBulletProgress.Visible = false;
            // 
            // DollBulletLabel
            // 
            this.DollBulletLabel.AutoSize = true;
            this.DollBulletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollBulletLabel.Location = new System.Drawing.Point(229, 493);
            this.DollBulletLabel.Name = "DollBulletLabel";
            this.DollBulletLabel.Size = new System.Drawing.Size(33, 20);
            this.DollBulletLabel.TabIndex = 25;
            this.DollBulletLabel.Text = "탄창";
            this.DollBulletLabel.Visible = false;
            // 
            // DollArmorCountLabel
            // 
            this.DollArmorCountLabel.AutoSize = true;
            this.DollArmorCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollArmorCountLabel.Location = new System.Drawing.Point(356, 512);
            this.DollArmorCountLabel.Name = "DollArmorCountLabel";
            this.DollArmorCountLabel.Size = new System.Drawing.Size(21, 20);
            this.DollArmorCountLabel.TabIndex = 24;
            this.DollArmorCountLabel.Text = "   ";
            this.DollArmorCountLabel.Visible = false;
            // 
            // DollArmorProgress
            // 
            this.DollArmorProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DollArmorProgress.ForeColor = System.Drawing.Color.Red;
            this.DollArmorProgress.Location = new System.Drawing.Point(275, 514);
            this.DollArmorProgress.Maximum = 50;
            this.DollArmorProgress.Name = "DollArmorProgress";
            this.DollArmorProgress.Size = new System.Drawing.Size(72, 12);
            this.DollArmorProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DollArmorProgress.TabIndex = 23;
            this.DollArmorProgress.Visible = false;
            // 
            // DollArmorLabel
            // 
            this.DollArmorLabel.AutoSize = true;
            this.DollArmorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollArmorLabel.Location = new System.Drawing.Point(229, 514);
            this.DollArmorLabel.Name = "DollArmorLabel";
            this.DollArmorLabel.Size = new System.Drawing.Size(33, 20);
            this.DollArmorLabel.TabIndex = 22;
            this.DollArmorLabel.Text = "장갑";
            this.DollArmorLabel.Visible = false;
            // 
            // DollEffectGroup
            // 
            this.DollEffectGroup.Controls.Add(this.DollEffectLabel);
            this.DollEffectGroup.Controls.Add(this.DollEffectTypeLabel);
            this.DollEffectGroup.Controls.Add(this.DollEffectFormationTable);
            this.DollEffectGroup.Location = new System.Drawing.Point(232, 263);
            this.DollEffectGroup.Name = "DollEffectGroup";
            this.DollEffectGroup.Size = new System.Drawing.Size(208, 92);
            this.DollEffectGroup.TabIndex = 21;
            this.DollEffectGroup.TabStop = false;
            this.DollEffectGroup.Text = "인형 버프";
            // 
            // DollEffectLabel
            // 
            this.DollEffectLabel.AutoSize = true;
            this.DollEffectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollEffectLabel.Location = new System.Drawing.Point(89, 60);
            this.DollEffectLabel.Name = "DollEffectLabel";
            this.DollEffectLabel.Size = new System.Drawing.Size(29, 20);
            this.DollEffectLabel.TabIndex = 22;
            this.DollEffectLabel.Text = "     ";
            // 
            // DollEffectTypeLabel
            // 
            this.DollEffectTypeLabel.AutoSize = true;
            this.DollEffectTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollEffectTypeLabel.Location = new System.Drawing.Point(91, 29);
            this.DollEffectTypeLabel.Name = "DollEffectTypeLabel";
            this.DollEffectTypeLabel.Size = new System.Drawing.Size(20, 18);
            this.DollEffectTypeLabel.TabIndex = 21;
            this.DollEffectTypeLabel.Text = "   ";
            // 
            // DollEffectFormationTable
            // 
            this.DollEffectFormationTable.ColumnCount = 3;
            this.DollEffectFormationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DollEffectFormationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DollEffectFormationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DollEffectFormationTable.Controls.Add(this.DollEffectFormation9, 2, 2);
            this.DollEffectFormationTable.Controls.Add(this.DollEffectFormation8, 1, 2);
            this.DollEffectFormationTable.Controls.Add(this.DollEffectFormation7, 0, 2);
            this.DollEffectFormationTable.Controls.Add(this.DollEffectFormation6, 2, 1);
            this.DollEffectFormationTable.Controls.Add(this.DollEffectFormation5, 1, 1);
            this.DollEffectFormationTable.Controls.Add(this.DollEffectFormation4, 0, 1);
            this.DollEffectFormationTable.Controls.Add(this.DollEffectFormation3, 2, 0);
            this.DollEffectFormationTable.Controls.Add(this.DollEffectFormation2, 1, 0);
            this.DollEffectFormationTable.Controls.Add(this.DollEffectFormation1, 0, 0);
            this.DollEffectFormationTable.Location = new System.Drawing.Point(9, 23);
            this.DollEffectFormationTable.Name = "DollEffectFormationTable";
            this.DollEffectFormationTable.RowCount = 3;
            this.DollEffectFormationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DollEffectFormationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DollEffectFormationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DollEffectFormationTable.Size = new System.Drawing.Size(74, 58);
            this.DollEffectFormationTable.TabIndex = 20;
            // 
            // DollEffectFormation9
            // 
            this.DollEffectFormation9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollEffectFormation9.Location = new System.Drawing.Point(51, 41);
            this.DollEffectFormation9.Name = "DollEffectFormation9";
            this.DollEffectFormation9.Size = new System.Drawing.Size(18, 13);
            this.DollEffectFormation9.TabIndex = 8;
            this.DollEffectFormation9.TabStop = false;
            // 
            // DollEffectFormation8
            // 
            this.DollEffectFormation8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollEffectFormation8.Location = new System.Drawing.Point(27, 41);
            this.DollEffectFormation8.Name = "DollEffectFormation8";
            this.DollEffectFormation8.Size = new System.Drawing.Size(18, 13);
            this.DollEffectFormation8.TabIndex = 7;
            this.DollEffectFormation8.TabStop = false;
            // 
            // DollEffectFormation7
            // 
            this.DollEffectFormation7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollEffectFormation7.Location = new System.Drawing.Point(3, 41);
            this.DollEffectFormation7.Name = "DollEffectFormation7";
            this.DollEffectFormation7.Size = new System.Drawing.Size(18, 13);
            this.DollEffectFormation7.TabIndex = 6;
            this.DollEffectFormation7.TabStop = false;
            // 
            // DollEffectFormation6
            // 
            this.DollEffectFormation6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollEffectFormation6.Location = new System.Drawing.Point(51, 22);
            this.DollEffectFormation6.Name = "DollEffectFormation6";
            this.DollEffectFormation6.Size = new System.Drawing.Size(18, 13);
            this.DollEffectFormation6.TabIndex = 5;
            this.DollEffectFormation6.TabStop = false;
            // 
            // DollEffectFormation5
            // 
            this.DollEffectFormation5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollEffectFormation5.Location = new System.Drawing.Point(27, 22);
            this.DollEffectFormation5.Name = "DollEffectFormation5";
            this.DollEffectFormation5.Size = new System.Drawing.Size(18, 13);
            this.DollEffectFormation5.TabIndex = 4;
            this.DollEffectFormation5.TabStop = false;
            // 
            // DollEffectFormation4
            // 
            this.DollEffectFormation4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollEffectFormation4.Location = new System.Drawing.Point(3, 22);
            this.DollEffectFormation4.Name = "DollEffectFormation4";
            this.DollEffectFormation4.Size = new System.Drawing.Size(18, 13);
            this.DollEffectFormation4.TabIndex = 3;
            this.DollEffectFormation4.TabStop = false;
            // 
            // DollEffectFormation3
            // 
            this.DollEffectFormation3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollEffectFormation3.Location = new System.Drawing.Point(51, 3);
            this.DollEffectFormation3.Name = "DollEffectFormation3";
            this.DollEffectFormation3.Size = new System.Drawing.Size(18, 13);
            this.DollEffectFormation3.TabIndex = 2;
            this.DollEffectFormation3.TabStop = false;
            // 
            // DollEffectFormation2
            // 
            this.DollEffectFormation2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollEffectFormation2.Location = new System.Drawing.Point(27, 3);
            this.DollEffectFormation2.Name = "DollEffectFormation2";
            this.DollEffectFormation2.Size = new System.Drawing.Size(18, 13);
            this.DollEffectFormation2.TabIndex = 1;
            this.DollEffectFormation2.TabStop = false;
            // 
            // DollEffectFormation1
            // 
            this.DollEffectFormation1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollEffectFormation1.Location = new System.Drawing.Point(3, 3);
            this.DollEffectFormation1.Name = "DollEffectFormation1";
            this.DollEffectFormation1.Size = new System.Drawing.Size(18, 13);
            this.DollEffectFormation1.TabIndex = 0;
            this.DollEffectFormation1.TabStop = false;
            // 
            // DollProductTimeLabel
            // 
            this.DollProductTimeLabel.AutoSize = true;
            this.DollProductTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollProductTimeLabel.Location = new System.Drawing.Point(5, 361);
            this.DollProductTimeLabel.Name = "DollProductTimeLabel";
            this.DollProductTimeLabel.Size = new System.Drawing.Size(30, 25);
            this.DollProductTimeLabel.TabIndex = 19;
            this.DollProductTimeLabel.Text = "   ";
            // 
            // DollImageSDBox
            // 
            this.DollImageSDBox.Location = new System.Drawing.Point(232, 93);
            this.DollImageSDBox.Name = "DollImageSDBox";
            this.DollImageSDBox.Size = new System.Drawing.Size(208, 164);
            this.DollImageSDBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DollImageSDBox.TabIndex = 18;
            this.DollImageSDBox.TabStop = false;
            this.DollImageSDBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.DollImageSDBox_LoadCompleted);
            this.DollImageSDBox.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DollImageSDBox_LoadProgressChanged);
            // 
            // DollFRCountLabel
            // 
            this.DollFRCountLabel.AutoSize = true;
            this.DollFRCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollFRCountLabel.Location = new System.Drawing.Point(133, 449);
            this.DollFRCountLabel.Name = "DollFRCountLabel";
            this.DollFRCountLabel.Size = new System.Drawing.Size(21, 20);
            this.DollFRCountLabel.TabIndex = 17;
            this.DollFRCountLabel.Text = "   ";
            // 
            // DollEVCountLabel
            // 
            this.DollEVCountLabel.AutoSize = true;
            this.DollEVCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollEVCountLabel.Location = new System.Drawing.Point(133, 471);
            this.DollEVCountLabel.Name = "DollEVCountLabel";
            this.DollEVCountLabel.Size = new System.Drawing.Size(21, 20);
            this.DollEVCountLabel.TabIndex = 16;
            this.DollEVCountLabel.Text = "   ";
            // 
            // DollACCountLabel
            // 
            this.DollACCountLabel.AutoSize = true;
            this.DollACCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollACCountLabel.Location = new System.Drawing.Point(133, 493);
            this.DollACCountLabel.Name = "DollACCountLabel";
            this.DollACCountLabel.Size = new System.Drawing.Size(21, 20);
            this.DollACCountLabel.TabIndex = 15;
            this.DollACCountLabel.Text = "   ";
            // 
            // DollASCountLabel
            // 
            this.DollASCountLabel.AutoSize = true;
            this.DollASCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollASCountLabel.Location = new System.Drawing.Point(133, 514);
            this.DollASCountLabel.Name = "DollASCountLabel";
            this.DollASCountLabel.Size = new System.Drawing.Size(17, 20);
            this.DollASCountLabel.TabIndex = 14;
            this.DollASCountLabel.Text = "  ";
            // 
            // DollHPCountLabel
            // 
            this.DollHPCountLabel.AutoSize = true;
            this.DollHPCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollHPCountLabel.Location = new System.Drawing.Point(133, 428);
            this.DollHPCountLabel.Name = "DollHPCountLabel";
            this.DollHPCountLabel.Size = new System.Drawing.Size(21, 20);
            this.DollHPCountLabel.TabIndex = 13;
            this.DollHPCountLabel.Text = "   ";
            // 
            // DollASProgress
            // 
            this.DollASProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DollASProgress.ForeColor = System.Drawing.Color.DarkBlue;
            this.DollASProgress.Location = new System.Drawing.Point(53, 514);
            this.DollASProgress.Maximum = 400;
            this.DollASProgress.Name = "DollASProgress";
            this.DollASProgress.Size = new System.Drawing.Size(71, 12);
            this.DollASProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DollASProgress.TabIndex = 12;
            // 
            // DollACProgress
            // 
            this.DollACProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DollACProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DollACProgress.Location = new System.Drawing.Point(53, 493);
            this.DollACProgress.Maximum = 400;
            this.DollACProgress.Name = "DollACProgress";
            this.DollACProgress.Size = new System.Drawing.Size(71, 12);
            this.DollACProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DollACProgress.TabIndex = 11;
            // 
            // DollEVProgress
            // 
            this.DollEVProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DollEVProgress.ForeColor = System.Drawing.Color.LightGreen;
            this.DollEVProgress.Location = new System.Drawing.Point(53, 471);
            this.DollEVProgress.Maximum = 400;
            this.DollEVProgress.Name = "DollEVProgress";
            this.DollEVProgress.Size = new System.Drawing.Size(71, 12);
            this.DollEVProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DollEVProgress.TabIndex = 10;
            // 
            // DollFRProgress
            // 
            this.DollFRProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DollFRProgress.ForeColor = System.Drawing.Color.Crimson;
            this.DollFRProgress.Location = new System.Drawing.Point(53, 449);
            this.DollFRProgress.Maximum = 400;
            this.DollFRProgress.Name = "DollFRProgress";
            this.DollFRProgress.Size = new System.Drawing.Size(71, 12);
            this.DollFRProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DollFRProgress.TabIndex = 9;
            // 
            // DollHPProgress
            // 
            this.DollHPProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DollHPProgress.ForeColor = System.Drawing.Color.Red;
            this.DollHPProgress.Location = new System.Drawing.Point(53, 428);
            this.DollHPProgress.Maximum = 400;
            this.DollHPProgress.Name = "DollHPProgress";
            this.DollHPProgress.Size = new System.Drawing.Size(71, 12);
            this.DollHPProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DollHPProgress.TabIndex = 8;
            // 
            // DollASLabel
            // 
            this.DollASLabel.AutoSize = true;
            this.DollASLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollASLabel.Location = new System.Drawing.Point(6, 514);
            this.DollASLabel.Name = "DollASLabel";
            this.DollASLabel.Size = new System.Drawing.Size(33, 20);
            this.DollASLabel.TabIndex = 7;
            this.DollASLabel.Text = "공속";
            // 
            // DollACLabel
            // 
            this.DollACLabel.AutoSize = true;
            this.DollACLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollACLabel.Location = new System.Drawing.Point(6, 493);
            this.DollACLabel.Name = "DollACLabel";
            this.DollACLabel.Size = new System.Drawing.Size(33, 20);
            this.DollACLabel.TabIndex = 6;
            this.DollACLabel.Text = "명중";
            // 
            // DollEVLabel
            // 
            this.DollEVLabel.AutoSize = true;
            this.DollEVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollEVLabel.Location = new System.Drawing.Point(6, 471);
            this.DollEVLabel.Name = "DollEVLabel";
            this.DollEVLabel.Size = new System.Drawing.Size(33, 20);
            this.DollEVLabel.TabIndex = 5;
            this.DollEVLabel.Text = "회피";
            // 
            // DollFRLabel
            // 
            this.DollFRLabel.AutoSize = true;
            this.DollFRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollFRLabel.Location = new System.Drawing.Point(6, 449);
            this.DollFRLabel.Name = "DollFRLabel";
            this.DollFRLabel.Size = new System.Drawing.Size(33, 20);
            this.DollFRLabel.TabIndex = 4;
            this.DollFRLabel.Text = "화력";
            // 
            // DollHPLabel
            // 
            this.DollHPLabel.AutoSize = true;
            this.DollHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollHPLabel.Location = new System.Drawing.Point(7, 428);
            this.DollHPLabel.Name = "DollHPLabel";
            this.DollHPLabel.Size = new System.Drawing.Size(31, 20);
            this.DollHPLabel.TabIndex = 3;
            this.DollHPLabel.Text = "HP";
            // 
            // DollNumLabel
            // 
            this.DollNumLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DollNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollNumLabel.Location = new System.Drawing.Point(352, 54);
            this.DollNumLabel.Name = "DollNumLabel";
            this.DollNumLabel.Size = new System.Drawing.Size(88, 37);
            this.DollNumLabel.TabIndex = 2;
            this.DollNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollNameLabel
            // 
            this.DollNameLabel.BackColor = System.Drawing.Color.Plum;
            this.DollNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DollNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DollNameLabel.Location = new System.Drawing.Point(6, 25);
            this.DollNameLabel.Name = "DollNameLabel";
            this.DollNameLabel.Size = new System.Drawing.Size(220, 27);
            this.DollNameLabel.TabIndex = 1;
            this.DollNameLabel.Text = "  ";
            this.DollNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollImageBox
            // 
            this.DollImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DollImageBox.Location = new System.Drawing.Point(6, 93);
            this.DollImageBox.Name = "DollImageBox";
            this.DollImageBox.Size = new System.Drawing.Size(220, 262);
            this.DollImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DollImageBox.TabIndex = 0;
            this.DollImageBox.TabStop = false;
            this.DollImageBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.DollImageBox_LoadCompleted);
            this.DollImageBox.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DollImageBox_LoadProgressChanged);
            this.DollImageBox.DoubleClick += new System.EventHandler(this.DollImageBox_Click);
            // 
            // EnemyDic
            // 
            this.EnemyDic.Controls.Add(this.EnemyDicEnemySearchGroup);
            this.EnemyDic.Controls.Add(this.EnemyDicEnemyInfoGroup);
            this.EnemyDic.Location = new System.Drawing.Point(4, 22);
            this.EnemyDic.Name = "EnemyDic";
            this.EnemyDic.Size = new System.Drawing.Size(859, 547);
            this.EnemyDic.TabIndex = 2;
            this.EnemyDic.Text = "철혈 도감";
            this.EnemyDic.UseVisualStyleBackColor = true;
            // 
            // EnemyDicEnemySearchGroup
            // 
            this.EnemyDicEnemySearchGroup.Controls.Add(this.label13);
            this.EnemyDicEnemySearchGroup.Controls.Add(this.EnemyDicEnemyListView);
            this.EnemyDicEnemySearchGroup.Controls.Add(this.EnemyDicEnemySearchTextBox);
            this.EnemyDicEnemySearchGroup.Location = new System.Drawing.Point(450, 3);
            this.EnemyDicEnemySearchGroup.Name = "EnemyDicEnemySearchGroup";
            this.EnemyDicEnemySearchGroup.Size = new System.Drawing.Size(407, 542);
            this.EnemyDicEnemySearchGroup.TabIndex = 4;
            this.EnemyDicEnemySearchGroup.TabStop = false;
            this.EnemyDicEnemySearchGroup.Text = "검색";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "검색할 적 :";
            // 
            // EnemyDicEnemyListView
            // 
            this.EnemyDicEnemyListView.AllowColumnReorder = true;
            this.EnemyDicEnemyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EnemyName,
            this.EnemyType,
            this.EnemyETC});
            this.EnemyDicEnemyListView.FullRowSelect = true;
            this.EnemyDicEnemyListView.GridLines = true;
            this.EnemyDicEnemyListView.HideSelection = false;
            this.EnemyDicEnemyListView.Location = new System.Drawing.Point(7, 64);
            this.EnemyDicEnemyListView.MultiSelect = false;
            this.EnemyDicEnemyListView.Name = "EnemyDicEnemyListView";
            this.EnemyDicEnemyListView.Size = new System.Drawing.Size(398, 472);
            this.EnemyDicEnemyListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.EnemyDicEnemyListView.TabIndex = 4;
            this.EnemyDicEnemyListView.UseCompatibleStateImageBehavior = false;
            this.EnemyDicEnemyListView.View = System.Windows.Forms.View.Details;
            this.EnemyDicEnemyListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            this.EnemyDicEnemyListView.SelectedIndexChanged += new System.EventHandler(this.EnemyDicEnemyListView_SelectedIndexChanged);
            // 
            // EnemyName
            // 
            this.EnemyName.Text = "이름";
            this.EnemyName.Width = 150;
            // 
            // EnemyType
            // 
            this.EnemyType.Text = "타입";
            this.EnemyType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnemyType.Width = 70;
            // 
            // EnemyETC
            // 
            this.EnemyETC.Text = "기타";
            this.EnemyETC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnemyETC.Width = 140;
            // 
            // EnemyDicEnemySearchTextBox
            // 
            this.EnemyDicEnemySearchTextBox.Location = new System.Drawing.Point(78, 20);
            this.EnemyDicEnemySearchTextBox.Name = "EnemyDicEnemySearchTextBox";
            this.EnemyDicEnemySearchTextBox.Size = new System.Drawing.Size(323, 21);
            this.EnemyDicEnemySearchTextBox.TabIndex = 3;
            this.EnemyDicEnemySearchTextBox.TextChanged += new System.EventHandler(this.EnemyDicEnemySearchTextBox_TextChanged);
            // 
            // EnemyDicEnemyInfoGroup
            // 
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyType);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyPTCount);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyPTProgress);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyPTLabel);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyAMCount);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyAMProgress);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyAMLabel);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyFRCount);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyEVCount);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyACCount);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyASCount);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyHPCount);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyASProgress);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyACProgress);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyEVProgress);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyFRProgress);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyHPProgress);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyASLabel);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyACLabel);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyEVLabel);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyFRLabel);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyHPLabel);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyName);
            this.EnemyDicEnemyInfoGroup.Controls.Add(this.EnemyDicEnemyImage);
            this.EnemyDicEnemyInfoGroup.Location = new System.Drawing.Point(1, 3);
            this.EnemyDicEnemyInfoGroup.Name = "EnemyDicEnemyInfoGroup";
            this.EnemyDicEnemyInfoGroup.Size = new System.Drawing.Size(446, 545);
            this.EnemyDicEnemyInfoGroup.TabIndex = 3;
            this.EnemyDicEnemyInfoGroup.TabStop = false;
            this.EnemyDicEnemyInfoGroup.Text = "정보";
            this.EnemyDicEnemyInfoGroup.Visible = false;
            // 
            // EnemyDicEnemyType
            // 
            this.EnemyDicEnemyType.AutoSize = true;
            this.EnemyDicEnemyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyDicEnemyType.Location = new System.Drawing.Point(49, 368);
            this.EnemyDicEnemyType.Name = "EnemyDicEnemyType";
            this.EnemyDicEnemyType.Size = new System.Drawing.Size(25, 24);
            this.EnemyDicEnemyType.TabIndex = 31;
            this.EnemyDicEnemyType.Text = "   ";
            // 
            // EnemyDicEnemyPTCount
            // 
            this.EnemyDicEnemyPTCount.AutoSize = true;
            this.EnemyDicEnemyPTCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyPTCount.Location = new System.Drawing.Point(411, 493);
            this.EnemyDicEnemyPTCount.Name = "EnemyDicEnemyPTCount";
            this.EnemyDicEnemyPTCount.Size = new System.Drawing.Size(21, 20);
            this.EnemyDicEnemyPTCount.TabIndex = 27;
            this.EnemyDicEnemyPTCount.Text = "   ";
            // 
            // EnemyDicEnemyPTProgress
            // 
            this.EnemyDicEnemyPTProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EnemyDicEnemyPTProgress.ForeColor = System.Drawing.Color.Red;
            this.EnemyDicEnemyPTProgress.Location = new System.Drawing.Point(275, 493);
            this.EnemyDicEnemyPTProgress.Name = "EnemyDicEnemyPTProgress";
            this.EnemyDicEnemyPTProgress.Size = new System.Drawing.Size(123, 12);
            this.EnemyDicEnemyPTProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyDicEnemyPTProgress.TabIndex = 26;
            // 
            // EnemyDicEnemyPTLabel
            // 
            this.EnemyDicEnemyPTLabel.AutoSize = true;
            this.EnemyDicEnemyPTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyPTLabel.Location = new System.Drawing.Point(229, 493);
            this.EnemyDicEnemyPTLabel.Name = "EnemyDicEnemyPTLabel";
            this.EnemyDicEnemyPTLabel.Size = new System.Drawing.Size(33, 20);
            this.EnemyDicEnemyPTLabel.TabIndex = 25;
            this.EnemyDicEnemyPTLabel.Text = "관통";
            // 
            // EnemyDicEnemyAMCount
            // 
            this.EnemyDicEnemyAMCount.AutoSize = true;
            this.EnemyDicEnemyAMCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyAMCount.Location = new System.Drawing.Point(411, 514);
            this.EnemyDicEnemyAMCount.Name = "EnemyDicEnemyAMCount";
            this.EnemyDicEnemyAMCount.Size = new System.Drawing.Size(21, 20);
            this.EnemyDicEnemyAMCount.TabIndex = 24;
            this.EnemyDicEnemyAMCount.Text = "   ";
            // 
            // EnemyDicEnemyAMProgress
            // 
            this.EnemyDicEnemyAMProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EnemyDicEnemyAMProgress.ForeColor = System.Drawing.Color.Red;
            this.EnemyDicEnemyAMProgress.Location = new System.Drawing.Point(275, 514);
            this.EnemyDicEnemyAMProgress.Name = "EnemyDicEnemyAMProgress";
            this.EnemyDicEnemyAMProgress.Size = new System.Drawing.Size(123, 12);
            this.EnemyDicEnemyAMProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyDicEnemyAMProgress.TabIndex = 23;
            // 
            // EnemyDicEnemyAMLabel
            // 
            this.EnemyDicEnemyAMLabel.AutoSize = true;
            this.EnemyDicEnemyAMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyAMLabel.Location = new System.Drawing.Point(229, 514);
            this.EnemyDicEnemyAMLabel.Name = "EnemyDicEnemyAMLabel";
            this.EnemyDicEnemyAMLabel.Size = new System.Drawing.Size(33, 20);
            this.EnemyDicEnemyAMLabel.TabIndex = 22;
            this.EnemyDicEnemyAMLabel.Text = "장갑";
            // 
            // EnemyDicEnemyFRCount
            // 
            this.EnemyDicEnemyFRCount.AutoSize = true;
            this.EnemyDicEnemyFRCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyFRCount.Location = new System.Drawing.Point(189, 449);
            this.EnemyDicEnemyFRCount.Name = "EnemyDicEnemyFRCount";
            this.EnemyDicEnemyFRCount.Size = new System.Drawing.Size(21, 20);
            this.EnemyDicEnemyFRCount.TabIndex = 17;
            this.EnemyDicEnemyFRCount.Text = "   ";
            // 
            // EnemyDicEnemyEVCount
            // 
            this.EnemyDicEnemyEVCount.AutoSize = true;
            this.EnemyDicEnemyEVCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyEVCount.Location = new System.Drawing.Point(189, 471);
            this.EnemyDicEnemyEVCount.Name = "EnemyDicEnemyEVCount";
            this.EnemyDicEnemyEVCount.Size = new System.Drawing.Size(21, 20);
            this.EnemyDicEnemyEVCount.TabIndex = 16;
            this.EnemyDicEnemyEVCount.Text = "   ";
            // 
            // EnemyDicEnemyACCount
            // 
            this.EnemyDicEnemyACCount.AutoSize = true;
            this.EnemyDicEnemyACCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyACCount.Location = new System.Drawing.Point(189, 493);
            this.EnemyDicEnemyACCount.Name = "EnemyDicEnemyACCount";
            this.EnemyDicEnemyACCount.Size = new System.Drawing.Size(21, 20);
            this.EnemyDicEnemyACCount.TabIndex = 15;
            this.EnemyDicEnemyACCount.Text = "   ";
            // 
            // EnemyDicEnemyASCount
            // 
            this.EnemyDicEnemyASCount.AutoSize = true;
            this.EnemyDicEnemyASCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyASCount.Location = new System.Drawing.Point(189, 514);
            this.EnemyDicEnemyASCount.Name = "EnemyDicEnemyASCount";
            this.EnemyDicEnemyASCount.Size = new System.Drawing.Size(17, 20);
            this.EnemyDicEnemyASCount.TabIndex = 14;
            this.EnemyDicEnemyASCount.Text = "  ";
            // 
            // EnemyDicEnemyHPCount
            // 
            this.EnemyDicEnemyHPCount.AutoSize = true;
            this.EnemyDicEnemyHPCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyHPCount.Location = new System.Drawing.Point(189, 428);
            this.EnemyDicEnemyHPCount.Name = "EnemyDicEnemyHPCount";
            this.EnemyDicEnemyHPCount.Size = new System.Drawing.Size(21, 20);
            this.EnemyDicEnemyHPCount.TabIndex = 13;
            this.EnemyDicEnemyHPCount.Text = "   ";
            // 
            // EnemyDicEnemyASProgress
            // 
            this.EnemyDicEnemyASProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EnemyDicEnemyASProgress.ForeColor = System.Drawing.Color.DarkBlue;
            this.EnemyDicEnemyASProgress.Location = new System.Drawing.Point(53, 514);
            this.EnemyDicEnemyASProgress.Maximum = 400;
            this.EnemyDicEnemyASProgress.Name = "EnemyDicEnemyASProgress";
            this.EnemyDicEnemyASProgress.Size = new System.Drawing.Size(123, 12);
            this.EnemyDicEnemyASProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyDicEnemyASProgress.TabIndex = 12;
            // 
            // EnemyDicEnemyACProgress
            // 
            this.EnemyDicEnemyACProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EnemyDicEnemyACProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EnemyDicEnemyACProgress.Location = new System.Drawing.Point(53, 493);
            this.EnemyDicEnemyACProgress.Maximum = 10000;
            this.EnemyDicEnemyACProgress.Name = "EnemyDicEnemyACProgress";
            this.EnemyDicEnemyACProgress.Size = new System.Drawing.Size(123, 12);
            this.EnemyDicEnemyACProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyDicEnemyACProgress.TabIndex = 11;
            // 
            // EnemyDicEnemyEVProgress
            // 
            this.EnemyDicEnemyEVProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EnemyDicEnemyEVProgress.ForeColor = System.Drawing.Color.LightGreen;
            this.EnemyDicEnemyEVProgress.Location = new System.Drawing.Point(53, 471);
            this.EnemyDicEnemyEVProgress.Name = "EnemyDicEnemyEVProgress";
            this.EnemyDicEnemyEVProgress.Size = new System.Drawing.Size(123, 12);
            this.EnemyDicEnemyEVProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyDicEnemyEVProgress.TabIndex = 10;
            // 
            // EnemyDicEnemyFRProgress
            // 
            this.EnemyDicEnemyFRProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EnemyDicEnemyFRProgress.ForeColor = System.Drawing.Color.Crimson;
            this.EnemyDicEnemyFRProgress.Location = new System.Drawing.Point(53, 449);
            this.EnemyDicEnemyFRProgress.Maximum = 2000;
            this.EnemyDicEnemyFRProgress.Name = "EnemyDicEnemyFRProgress";
            this.EnemyDicEnemyFRProgress.Size = new System.Drawing.Size(123, 12);
            this.EnemyDicEnemyFRProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyDicEnemyFRProgress.TabIndex = 9;
            // 
            // EnemyDicEnemyHPProgress
            // 
            this.EnemyDicEnemyHPProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EnemyDicEnemyHPProgress.ForeColor = System.Drawing.Color.Red;
            this.EnemyDicEnemyHPProgress.Location = new System.Drawing.Point(53, 428);
            this.EnemyDicEnemyHPProgress.Maximum = 300000;
            this.EnemyDicEnemyHPProgress.Name = "EnemyDicEnemyHPProgress";
            this.EnemyDicEnemyHPProgress.Size = new System.Drawing.Size(123, 12);
            this.EnemyDicEnemyHPProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyDicEnemyHPProgress.TabIndex = 8;
            // 
            // EnemyDicEnemyASLabel
            // 
            this.EnemyDicEnemyASLabel.AutoSize = true;
            this.EnemyDicEnemyASLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyASLabel.Location = new System.Drawing.Point(6, 514);
            this.EnemyDicEnemyASLabel.Name = "EnemyDicEnemyASLabel";
            this.EnemyDicEnemyASLabel.Size = new System.Drawing.Size(33, 20);
            this.EnemyDicEnemyASLabel.TabIndex = 7;
            this.EnemyDicEnemyASLabel.Text = "공속";
            // 
            // EnemyDicEnemyACLabel
            // 
            this.EnemyDicEnemyACLabel.AutoSize = true;
            this.EnemyDicEnemyACLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyACLabel.Location = new System.Drawing.Point(6, 493);
            this.EnemyDicEnemyACLabel.Name = "EnemyDicEnemyACLabel";
            this.EnemyDicEnemyACLabel.Size = new System.Drawing.Size(33, 20);
            this.EnemyDicEnemyACLabel.TabIndex = 6;
            this.EnemyDicEnemyACLabel.Text = "명중";
            // 
            // EnemyDicEnemyEVLabel
            // 
            this.EnemyDicEnemyEVLabel.AutoSize = true;
            this.EnemyDicEnemyEVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyEVLabel.Location = new System.Drawing.Point(6, 471);
            this.EnemyDicEnemyEVLabel.Name = "EnemyDicEnemyEVLabel";
            this.EnemyDicEnemyEVLabel.Size = new System.Drawing.Size(33, 20);
            this.EnemyDicEnemyEVLabel.TabIndex = 5;
            this.EnemyDicEnemyEVLabel.Text = "회피";
            // 
            // EnemyDicEnemyFRLabel
            // 
            this.EnemyDicEnemyFRLabel.AutoSize = true;
            this.EnemyDicEnemyFRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyFRLabel.Location = new System.Drawing.Point(6, 449);
            this.EnemyDicEnemyFRLabel.Name = "EnemyDicEnemyFRLabel";
            this.EnemyDicEnemyFRLabel.Size = new System.Drawing.Size(33, 20);
            this.EnemyDicEnemyFRLabel.TabIndex = 4;
            this.EnemyDicEnemyFRLabel.Text = "화력";
            // 
            // EnemyDicEnemyHPLabel
            // 
            this.EnemyDicEnemyHPLabel.AutoSize = true;
            this.EnemyDicEnemyHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyHPLabel.Location = new System.Drawing.Point(7, 428);
            this.EnemyDicEnemyHPLabel.Name = "EnemyDicEnemyHPLabel";
            this.EnemyDicEnemyHPLabel.Size = new System.Drawing.Size(31, 20);
            this.EnemyDicEnemyHPLabel.TabIndex = 3;
            this.EnemyDicEnemyHPLabel.Text = "HP";
            // 
            // EnemyDicEnemyName
            // 
            this.EnemyDicEnemyName.BackColor = System.Drawing.Color.DarkViolet;
            this.EnemyDicEnemyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnemyDicEnemyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnemyDicEnemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnemyDicEnemyName.Location = new System.Drawing.Point(3, 17);
            this.EnemyDicEnemyName.Name = "EnemyDicEnemyName";
            this.EnemyDicEnemyName.Size = new System.Drawing.Size(440, 35);
            this.EnemyDicEnemyName.TabIndex = 1;
            this.EnemyDicEnemyName.Text = "  ";
            this.EnemyDicEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyDicEnemyImage
            // 
            this.EnemyDicEnemyImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnemyDicEnemyImage.Location = new System.Drawing.Point(9, 64);
            this.EnemyDicEnemyImage.Name = "EnemyDicEnemyImage";
            this.EnemyDicEnemyImage.Size = new System.Drawing.Size(350, 240);
            this.EnemyDicEnemyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyDicEnemyImage.TabIndex = 0;
            this.EnemyDicEnemyImage.TabStop = false;
            // 
            // FormationSimulator
            // 
            this.FormationSimulator.Controls.Add(this.ReinstallFSimulatorButton);
            this.FormationSimulator.Controls.Add(this.label89);
            this.FormationSimulator.Controls.Add(this.FSimulatorDownloadStatus);
            this.FormationSimulator.Controls.Add(this.FSimulatorDownloadProgressBar);
            this.FormationSimulator.Controls.Add(this.RunFSimulatorButton);
            this.FormationSimulator.Location = new System.Drawing.Point(4, 22);
            this.FormationSimulator.Name = "FormationSimulator";
            this.FormationSimulator.Size = new System.Drawing.Size(859, 547);
            this.FormationSimulator.TabIndex = 3;
            this.FormationSimulator.Text = "진형 시뮬레이터 (외부 링크)";
            this.FormationSimulator.UseVisualStyleBackColor = true;
            // 
            // ReinstallFSimulatorButton
            // 
            this.ReinstallFSimulatorButton.Location = new System.Drawing.Point(390, 478);
            this.ReinstallFSimulatorButton.Name = "ReinstallFSimulatorButton";
            this.ReinstallFSimulatorButton.Size = new System.Drawing.Size(75, 23);
            this.ReinstallFSimulatorButton.TabIndex = 4;
            this.ReinstallFSimulatorButton.Text = "재설치";
            this.ReinstallFSimulatorButton.UseVisualStyleBackColor = true;
            this.ReinstallFSimulatorButton.Click += new System.EventHandler(this.ReinstallFSimulatorButton_Click);
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(319, 383);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(220, 24);
            this.label89.TabIndex = 3;
            this.label89.Text = "Thanks : Cosmos0\r\nSpecial Thanks : 36베이스 Developers";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FSimulatorDownloadStatus
            // 
            this.FSimulatorDownloadStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FSimulatorDownloadStatus.Location = new System.Drawing.Point(0, 510);
            this.FSimulatorDownloadStatus.Name = "FSimulatorDownloadStatus";
            this.FSimulatorDownloadStatus.Size = new System.Drawing.Size(859, 27);
            this.FSimulatorDownloadStatus.TabIndex = 2;
            this.FSimulatorDownloadStatus.Text = "Status";
            this.FSimulatorDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FSimulatorDownloadStatus.Visible = false;
            // 
            // FSimulatorDownloadProgressBar
            // 
            this.FSimulatorDownloadProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FSimulatorDownloadProgressBar.Location = new System.Drawing.Point(0, 537);
            this.FSimulatorDownloadProgressBar.Name = "FSimulatorDownloadProgressBar";
            this.FSimulatorDownloadProgressBar.Size = new System.Drawing.Size(859, 10);
            this.FSimulatorDownloadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FSimulatorDownloadProgressBar.TabIndex = 1;
            this.FSimulatorDownloadProgressBar.Visible = false;
            // 
            // RunFSimulatorButton
            // 
            this.RunFSimulatorButton.Location = new System.Drawing.Point(335, 410);
            this.RunFSimulatorButton.Name = "RunFSimulatorButton";
            this.RunFSimulatorButton.Size = new System.Drawing.Size(192, 62);
            this.RunFSimulatorButton.TabIndex = 0;
            this.RunFSimulatorButton.Text = "시뮬레이터 실행하기";
            this.RunFSimulatorButton.UseVisualStyleBackColor = true;
            this.RunFSimulatorButton.Click += new System.EventHandler(this.RunFSimulatorButton_Click);
            // 
            // LevelingCalc
            // 
            this.LevelingCalc.Controls.Add(this.tableLayoutPanel2);
            this.LevelingCalc.Controls.Add(this.LevelingCalcSetMUGroup);
            this.LevelingCalc.Location = new System.Drawing.Point(4, 22);
            this.LevelingCalc.Name = "LevelingCalc";
            this.LevelingCalc.Size = new System.Drawing.Size(859, 547);
            this.LevelingCalc.TabIndex = 4;
            this.LevelingCalc.Text = "레벨링 계산기";
            this.LevelingCalc.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_5_Leader_MVP, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_4_Leader_MVP, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_3_Leader_MVP, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_2_Leader_MVP, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_1_Leader_MVP, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label73, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_5_MVP, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_4_MVP, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_3_MVP, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_2_MVP, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_1_MVP, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label67, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_5_Leader, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_4_Leader, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_3_Leader, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_2_Leader, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_1_Leader, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label61, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_5_Normal, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_4_Normal, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_3_Normal, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_2_Normal, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ExpCount_1_Normal, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label33, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label32, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label30, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label29, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label28, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label25, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(73, 256);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(662, 288);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ExpCount_5_Leader_MVP
            // 
            this.ExpCount_5_Leader_MVP.BackColor = System.Drawing.Color.Thistle;
            this.ExpCount_5_Leader_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_5_Leader_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_5_Leader_MVP.Location = new System.Drawing.Point(553, 180);
            this.ExpCount_5_Leader_MVP.Name = "ExpCount_5_Leader_MVP";
            this.ExpCount_5_Leader_MVP.Size = new System.Drawing.Size(106, 53);
            this.ExpCount_5_Leader_MVP.TabIndex = 30;
            this.ExpCount_5_Leader_MVP.Text = "0";
            this.ExpCount_5_Leader_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_4_Leader_MVP
            // 
            this.ExpCount_4_Leader_MVP.BackColor = System.Drawing.Color.PaleGreen;
            this.ExpCount_4_Leader_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_4_Leader_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_4_Leader_MVP.Location = new System.Drawing.Point(443, 180);
            this.ExpCount_4_Leader_MVP.Name = "ExpCount_4_Leader_MVP";
            this.ExpCount_4_Leader_MVP.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_4_Leader_MVP.TabIndex = 29;
            this.ExpCount_4_Leader_MVP.Text = "0";
            this.ExpCount_4_Leader_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_3_Leader_MVP
            // 
            this.ExpCount_3_Leader_MVP.BackColor = System.Drawing.Color.Chocolate;
            this.ExpCount_3_Leader_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_3_Leader_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_3_Leader_MVP.Location = new System.Drawing.Point(333, 180);
            this.ExpCount_3_Leader_MVP.Name = "ExpCount_3_Leader_MVP";
            this.ExpCount_3_Leader_MVP.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_3_Leader_MVP.TabIndex = 28;
            this.ExpCount_3_Leader_MVP.Text = "0";
            this.ExpCount_3_Leader_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_2_Leader_MVP
            // 
            this.ExpCount_2_Leader_MVP.BackColor = System.Drawing.Color.RosyBrown;
            this.ExpCount_2_Leader_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_2_Leader_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_2_Leader_MVP.Location = new System.Drawing.Point(223, 180);
            this.ExpCount_2_Leader_MVP.Name = "ExpCount_2_Leader_MVP";
            this.ExpCount_2_Leader_MVP.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_2_Leader_MVP.TabIndex = 27;
            this.ExpCount_2_Leader_MVP.Text = "0";
            this.ExpCount_2_Leader_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_1_Leader_MVP
            // 
            this.ExpCount_1_Leader_MVP.BackColor = System.Drawing.Color.Turquoise;
            this.ExpCount_1_Leader_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_1_Leader_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_1_Leader_MVP.Location = new System.Drawing.Point(113, 180);
            this.ExpCount_1_Leader_MVP.Name = "ExpCount_1_Leader_MVP";
            this.ExpCount_1_Leader_MVP.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_1_Leader_MVP.TabIndex = 26;
            this.ExpCount_1_Leader_MVP.Text = "0";
            this.ExpCount_1_Leader_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            this.label73.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label73.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label73.Location = new System.Drawing.Point(3, 180);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(104, 53);
            this.label73.TabIndex = 25;
            this.label73.Text = "총 필요횟수 (리더, MVP)";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_5_MVP
            // 
            this.ExpCount_5_MVP.BackColor = System.Drawing.Color.Thistle;
            this.ExpCount_5_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_5_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_5_MVP.Location = new System.Drawing.Point(553, 127);
            this.ExpCount_5_MVP.Name = "ExpCount_5_MVP";
            this.ExpCount_5_MVP.Size = new System.Drawing.Size(106, 53);
            this.ExpCount_5_MVP.TabIndex = 24;
            this.ExpCount_5_MVP.Text = "0";
            this.ExpCount_5_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_4_MVP
            // 
            this.ExpCount_4_MVP.BackColor = System.Drawing.Color.PaleGreen;
            this.ExpCount_4_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_4_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_4_MVP.Location = new System.Drawing.Point(443, 127);
            this.ExpCount_4_MVP.Name = "ExpCount_4_MVP";
            this.ExpCount_4_MVP.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_4_MVP.TabIndex = 23;
            this.ExpCount_4_MVP.Text = "0";
            this.ExpCount_4_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_3_MVP
            // 
            this.ExpCount_3_MVP.BackColor = System.Drawing.Color.Chocolate;
            this.ExpCount_3_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_3_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_3_MVP.Location = new System.Drawing.Point(333, 127);
            this.ExpCount_3_MVP.Name = "ExpCount_3_MVP";
            this.ExpCount_3_MVP.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_3_MVP.TabIndex = 22;
            this.ExpCount_3_MVP.Text = "0";
            this.ExpCount_3_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_2_MVP
            // 
            this.ExpCount_2_MVP.BackColor = System.Drawing.Color.RosyBrown;
            this.ExpCount_2_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_2_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_2_MVP.Location = new System.Drawing.Point(223, 127);
            this.ExpCount_2_MVP.Name = "ExpCount_2_MVP";
            this.ExpCount_2_MVP.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_2_MVP.TabIndex = 21;
            this.ExpCount_2_MVP.Text = "0";
            this.ExpCount_2_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_1_MVP
            // 
            this.ExpCount_1_MVP.BackColor = System.Drawing.Color.Turquoise;
            this.ExpCount_1_MVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_1_MVP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_1_MVP.Location = new System.Drawing.Point(113, 127);
            this.ExpCount_1_MVP.Name = "ExpCount_1_MVP";
            this.ExpCount_1_MVP.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_1_MVP.TabIndex = 20;
            this.ExpCount_1_MVP.Text = "0";
            this.ExpCount_1_MVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label67
            // 
            this.label67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label67.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label67.Location = new System.Drawing.Point(3, 127);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(104, 53);
            this.label67.TabIndex = 19;
            this.label67.Text = "총 필요횟수 (MVP)";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_5_Leader
            // 
            this.ExpCount_5_Leader.BackColor = System.Drawing.Color.Thistle;
            this.ExpCount_5_Leader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_5_Leader.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_5_Leader.Location = new System.Drawing.Point(553, 74);
            this.ExpCount_5_Leader.Name = "ExpCount_5_Leader";
            this.ExpCount_5_Leader.Size = new System.Drawing.Size(106, 53);
            this.ExpCount_5_Leader.TabIndex = 18;
            this.ExpCount_5_Leader.Text = "0";
            this.ExpCount_5_Leader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_4_Leader
            // 
            this.ExpCount_4_Leader.BackColor = System.Drawing.Color.PaleGreen;
            this.ExpCount_4_Leader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_4_Leader.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_4_Leader.Location = new System.Drawing.Point(443, 74);
            this.ExpCount_4_Leader.Name = "ExpCount_4_Leader";
            this.ExpCount_4_Leader.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_4_Leader.TabIndex = 17;
            this.ExpCount_4_Leader.Text = "0";
            this.ExpCount_4_Leader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_3_Leader
            // 
            this.ExpCount_3_Leader.BackColor = System.Drawing.Color.Chocolate;
            this.ExpCount_3_Leader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_3_Leader.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_3_Leader.Location = new System.Drawing.Point(333, 74);
            this.ExpCount_3_Leader.Name = "ExpCount_3_Leader";
            this.ExpCount_3_Leader.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_3_Leader.TabIndex = 16;
            this.ExpCount_3_Leader.Text = "0";
            this.ExpCount_3_Leader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_2_Leader
            // 
            this.ExpCount_2_Leader.BackColor = System.Drawing.Color.RosyBrown;
            this.ExpCount_2_Leader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_2_Leader.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_2_Leader.Location = new System.Drawing.Point(223, 74);
            this.ExpCount_2_Leader.Name = "ExpCount_2_Leader";
            this.ExpCount_2_Leader.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_2_Leader.TabIndex = 15;
            this.ExpCount_2_Leader.Text = "0";
            this.ExpCount_2_Leader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_1_Leader
            // 
            this.ExpCount_1_Leader.BackColor = System.Drawing.Color.Turquoise;
            this.ExpCount_1_Leader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_1_Leader.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_1_Leader.Location = new System.Drawing.Point(113, 74);
            this.ExpCount_1_Leader.Name = "ExpCount_1_Leader";
            this.ExpCount_1_Leader.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_1_Leader.TabIndex = 14;
            this.ExpCount_1_Leader.Text = "0";
            this.ExpCount_1_Leader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label61.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label61.Location = new System.Drawing.Point(3, 74);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(104, 53);
            this.label61.TabIndex = 13;
            this.label61.Text = "총 필요횟수 (리더)";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_5_Normal
            // 
            this.ExpCount_5_Normal.BackColor = System.Drawing.Color.Thistle;
            this.ExpCount_5_Normal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_5_Normal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_5_Normal.Location = new System.Drawing.Point(553, 21);
            this.ExpCount_5_Normal.Name = "ExpCount_5_Normal";
            this.ExpCount_5_Normal.Size = new System.Drawing.Size(106, 53);
            this.ExpCount_5_Normal.TabIndex = 12;
            this.ExpCount_5_Normal.Text = "0";
            this.ExpCount_5_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_4_Normal
            // 
            this.ExpCount_4_Normal.BackColor = System.Drawing.Color.PaleGreen;
            this.ExpCount_4_Normal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_4_Normal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_4_Normal.Location = new System.Drawing.Point(443, 21);
            this.ExpCount_4_Normal.Name = "ExpCount_4_Normal";
            this.ExpCount_4_Normal.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_4_Normal.TabIndex = 11;
            this.ExpCount_4_Normal.Text = "0";
            this.ExpCount_4_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_3_Normal
            // 
            this.ExpCount_3_Normal.BackColor = System.Drawing.Color.Chocolate;
            this.ExpCount_3_Normal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_3_Normal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_3_Normal.Location = new System.Drawing.Point(333, 21);
            this.ExpCount_3_Normal.Name = "ExpCount_3_Normal";
            this.ExpCount_3_Normal.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_3_Normal.TabIndex = 10;
            this.ExpCount_3_Normal.Text = "0";
            this.ExpCount_3_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_2_Normal
            // 
            this.ExpCount_2_Normal.BackColor = System.Drawing.Color.RosyBrown;
            this.ExpCount_2_Normal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_2_Normal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_2_Normal.Location = new System.Drawing.Point(223, 21);
            this.ExpCount_2_Normal.Name = "ExpCount_2_Normal";
            this.ExpCount_2_Normal.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_2_Normal.TabIndex = 9;
            this.ExpCount_2_Normal.Text = "0";
            this.ExpCount_2_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpCount_1_Normal
            // 
            this.ExpCount_1_Normal.BackColor = System.Drawing.Color.Turquoise;
            this.ExpCount_1_Normal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpCount_1_Normal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpCount_1_Normal.Location = new System.Drawing.Point(113, 21);
            this.ExpCount_1_Normal.Name = "ExpCount_1_Normal";
            this.ExpCount_1_Normal.Size = new System.Drawing.Size(104, 53);
            this.ExpCount_1_Normal.TabIndex = 8;
            this.ExpCount_1_Normal.Text = "0";
            this.ExpCount_1_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.Location = new System.Drawing.Point(3, 21);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 53);
            this.label33.TabIndex = 7;
            this.label33.Text = "총 필요횟수";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Thistle;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.Location = new System.Drawing.Point(553, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(106, 21);
            this.label32.TabIndex = 5;
            this.label32.Text = "5";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.PaleGreen;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.Location = new System.Drawing.Point(443, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 21);
            this.label30.TabIndex = 4;
            this.label30.Text = "4";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Chocolate;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.Location = new System.Drawing.Point(333, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(104, 21);
            this.label29.TabIndex = 3;
            this.label29.Text = "3";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.RosyBrown;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.Location = new System.Drawing.Point(223, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(104, 21);
            this.label28.TabIndex = 2;
            this.label28.Text = "2";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Turquoise;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(113, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 21);
            this.label25.TabIndex = 0;
            this.label25.Text = "1";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelingCalcSetMUGroup
            // 
            this.LevelingCalcSetMUGroup.Controls.Add(this.LevelingCalcCalcButton);
            this.LevelingCalcSetMUGroup.Controls.Add(this.LevelingCalcETCSetGroup);
            this.LevelingCalcSetMUGroup.Controls.Add(this.LevelingCalcTypeSelectorGroup);
            this.LevelingCalcSetMUGroup.Controls.Add(this.panel1);
            this.LevelingCalcSetMUGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.LevelingCalcSetMUGroup.Location = new System.Drawing.Point(0, 0);
            this.LevelingCalcSetMUGroup.Name = "LevelingCalcSetMUGroup";
            this.LevelingCalcSetMUGroup.Size = new System.Drawing.Size(859, 250);
            this.LevelingCalcSetMUGroup.TabIndex = 0;
            this.LevelingCalcSetMUGroup.TabStop = false;
            this.LevelingCalcSetMUGroup.Text = "제대 설정";
            // 
            // LevelingCalcCalcButton
            // 
            this.LevelingCalcCalcButton.Location = new System.Drawing.Point(586, 218);
            this.LevelingCalcCalcButton.Name = "LevelingCalcCalcButton";
            this.LevelingCalcCalcButton.Size = new System.Drawing.Size(270, 27);
            this.LevelingCalcCalcButton.TabIndex = 3;
            this.LevelingCalcCalcButton.Text = "계산하기";
            this.LevelingCalcCalcButton.UseVisualStyleBackColor = true;
            this.LevelingCalcCalcButton.Click += new System.EventHandler(this.LevelingCalcCalcButton_Click);
            // 
            // LevelingCalcETCSetGroup
            // 
            this.LevelingCalcETCSetGroup.Controls.Add(this.AutoAddDummySet);
            this.LevelingCalcETCSetGroup.Controls.Add(this.label34);
            this.LevelingCalcETCSetGroup.Controls.Add(this.label81);
            this.LevelingCalcETCSetGroup.Controls.Add(this.RequireCountPerOnce);
            this.LevelingCalcETCSetGroup.Controls.Add(this.label82);
            this.LevelingCalcETCSetGroup.Controls.Add(this.label80);
            this.LevelingCalcETCSetGroup.Controls.Add(this.RequireTimePerOnce);
            this.LevelingCalcETCSetGroup.Controls.Add(this.label79);
            this.LevelingCalcETCSetGroup.Location = new System.Drawing.Point(586, 97);
            this.LevelingCalcETCSetGroup.Name = "LevelingCalcETCSetGroup";
            this.LevelingCalcETCSetGroup.Size = new System.Drawing.Size(267, 95);
            this.LevelingCalcETCSetGroup.TabIndex = 2;
            this.LevelingCalcETCSetGroup.TabStop = false;
            this.LevelingCalcETCSetGroup.Text = "기타 설정";
            // 
            // AutoAddDummySet
            // 
            this.AutoAddDummySet.AutoSize = true;
            this.AutoAddDummySet.Location = new System.Drawing.Point(187, 72);
            this.AutoAddDummySet.Name = "AutoAddDummySet";
            this.AutoAddDummySet.Size = new System.Drawing.Size(15, 14);
            this.AutoAddDummySet.TabIndex = 7;
            this.AutoAddDummySet.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 72);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(81, 12);
            this.label34.TabIndex = 6;
            this.label34.Text = "자동 편제확대";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(235, 48);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(17, 12);
            this.label81.TabIndex = 5;
            this.label81.Text = "회";
            // 
            // RequireCountPerOnce
            // 
            this.RequireCountPerOnce.Enabled = false;
            this.RequireCountPerOnce.Location = new System.Drawing.Point(158, 42);
            this.RequireCountPerOnce.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.RequireCountPerOnce.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RequireCountPerOnce.Name = "RequireCountPerOnce";
            this.RequireCountPerOnce.Size = new System.Drawing.Size(71, 21);
            this.RequireCountPerOnce.TabIndex = 4;
            this.RequireCountPerOnce.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(9, 48);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(87, 12);
            this.label82.TabIndex = 3;
            this.label82.Text = "1회당 전투횟수";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(235, 23);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(17, 12);
            this.label80.TabIndex = 2;
            this.label80.Text = "초";
            // 
            // RequireTimePerOnce
            // 
            this.RequireTimePerOnce.Location = new System.Drawing.Point(158, 17);
            this.RequireTimePerOnce.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.RequireTimePerOnce.Name = "RequireTimePerOnce";
            this.RequireTimePerOnce.Size = new System.Drawing.Size(71, 21);
            this.RequireTimePerOnce.TabIndex = 1;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(9, 23);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(87, 12);
            this.label79.TabIndex = 0;
            this.label79.Text = "1회당 소요시간";
            // 
            // LevelingCalcTypeSelectorGroup
            // 
            this.LevelingCalcTypeSelectorGroup.Controls.Add(this.RealWarTypeSelector);
            this.LevelingCalcTypeSelectorGroup.Controls.Add(this.SimulationTypeSelector);
            this.LevelingCalcTypeSelectorGroup.Controls.Add(this.RealWarType);
            this.LevelingCalcTypeSelectorGroup.Controls.Add(this.SimulationType);
            this.LevelingCalcTypeSelectorGroup.Location = new System.Drawing.Point(586, 20);
            this.LevelingCalcTypeSelectorGroup.Name = "LevelingCalcTypeSelectorGroup";
            this.LevelingCalcTypeSelectorGroup.Size = new System.Drawing.Size(267, 71);
            this.LevelingCalcTypeSelectorGroup.TabIndex = 1;
            this.LevelingCalcTypeSelectorGroup.TabStop = false;
            this.LevelingCalcTypeSelectorGroup.Text = "레벨링 타입 선택";
            // 
            // RealWarTypeSelector
            // 
            this.RealWarTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RealWarTypeSelector.FormattingEnabled = true;
            this.RealWarTypeSelector.Location = new System.Drawing.Point(111, 44);
            this.RealWarTypeSelector.Name = "RealWarTypeSelector";
            this.RealWarTypeSelector.Size = new System.Drawing.Size(150, 20);
            this.RealWarTypeSelector.TabIndex = 3;
            this.RealWarTypeSelector.Tag = "RealWar";
            this.RealWarTypeSelector.Visible = false;
            this.RealWarTypeSelector.Click += new System.EventHandler(this.RealWarTypeSelector_Click);
            // 
            // SimulationTypeSelector
            // 
            this.SimulationTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SimulationTypeSelector.FormattingEnabled = true;
            this.SimulationTypeSelector.Items.AddRange(new object[] {
            "초급",
            "중급",
            "고급"});
            this.SimulationTypeSelector.Location = new System.Drawing.Point(111, 20);
            this.SimulationTypeSelector.Name = "SimulationTypeSelector";
            this.SimulationTypeSelector.Size = new System.Drawing.Size(150, 20);
            this.SimulationTypeSelector.TabIndex = 2;
            this.SimulationTypeSelector.Tag = "Simulation";
            // 
            // RealWarType
            // 
            this.RealWarType.AutoSize = true;
            this.RealWarType.Location = new System.Drawing.Point(6, 47);
            this.RealWarType.Name = "RealWarType";
            this.RealWarType.Size = new System.Drawing.Size(47, 16);
            this.RealWarType.TabIndex = 1;
            this.RealWarType.Tag = "RealWar";
            this.RealWarType.Text = "전역";
            this.RealWarType.UseVisualStyleBackColor = true;
            this.RealWarType.CheckedChanged += new System.EventHandler(this.LevelingCalcTypeSelector_CheckedChanged);
            // 
            // SimulationType
            // 
            this.SimulationType.AutoSize = true;
            this.SimulationType.Checked = true;
            this.SimulationType.Location = new System.Drawing.Point(6, 25);
            this.SimulationType.Name = "SimulationType";
            this.SimulationType.Size = new System.Drawing.Size(99, 16);
            this.SimulationType.TabIndex = 0;
            this.SimulationType.TabStop = true;
            this.SimulationType.Tag = "Simulation";
            this.SimulationType.Text = "경험 모의전투";
            this.SimulationType.UseVisualStyleBackColor = true;
            this.SimulationType.CheckedChanged += new System.EventHandler(this.LevelingCalcTypeSelector_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.Doll5);
            this.panel1.Controls.Add(this.Doll4);
            this.panel1.Controls.Add(this.Doll3);
            this.panel1.Controls.Add(this.Doll2);
            this.panel1.Controls.Add(this.Doll1);
            this.panel1.Controls.Add(this.DollEnabler5);
            this.panel1.Controls.Add(this.DollEnabler2);
            this.panel1.Controls.Add(this.DollEnabler3);
            this.panel1.Controls.Add(this.DollEnabler4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 225);
            this.panel1.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 202);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 12);
            this.label26.TabIndex = 33;
            this.label26.Text = "편제 수";
            // 
            // Doll5
            // 
            this.Doll5.Controls.Add(this.DummyCount5);
            this.Doll5.Controls.Add(this.label21);
            this.Doll5.Controls.Add(this.LevelingCalcNowLevel5);
            this.Doll5.Controls.Add(this.LevelingCalcNowExp5);
            this.Doll5.Controls.Add(this.LevelingCalcTargetLevel5);
            this.Doll5.Enabled = false;
            this.Doll5.Location = new System.Drawing.Point(466, 47);
            this.Doll5.Name = "Doll5";
            this.Doll5.Size = new System.Drawing.Size(84, 174);
            this.Doll5.TabIndex = 32;
            this.Doll5.Tag = "5";
            // 
            // DummyCount5
            // 
            this.DummyCount5.Location = new System.Drawing.Point(14, 151);
            this.DummyCount5.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DummyCount5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DummyCount5.Name = "DummyCount5";
            this.DummyCount5.Size = new System.Drawing.Size(50, 21);
            this.DummyCount5.TabIndex = 21;
            this.DummyCount5.Tag = "1";
            this.DummyCount5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 10;
            this.label21.Text = "5";
            // 
            // LevelingCalcNowLevel5
            // 
            this.LevelingCalcNowLevel5.Location = new System.Drawing.Point(14, 39);
            this.LevelingCalcNowLevel5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel5.Name = "LevelingCalcNowLevel5";
            this.LevelingCalcNowLevel5.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcNowLevel5.TabIndex = 4;
            this.LevelingCalcNowLevel5.Tag = "5";
            this.LevelingCalcNowLevel5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel5.ValueChanged += new System.EventHandler(this.LevelingCalcNowLevel_ValueChanged);
            // 
            // LevelingCalcNowExp5
            // 
            this.LevelingCalcNowExp5.Location = new System.Drawing.Point(5, 78);
            this.LevelingCalcNowExp5.Maximum = new decimal(new int[] {
            3263200,
            0,
            0,
            0});
            this.LevelingCalcNowExp5.Name = "LevelingCalcNowExp5";
            this.LevelingCalcNowExp5.Size = new System.Drawing.Size(74, 21);
            this.LevelingCalcNowExp5.TabIndex = 17;
            this.LevelingCalcNowExp5.Tag = "5";
            // 
            // LevelingCalcTargetLevel5
            // 
            this.LevelingCalcTargetLevel5.Location = new System.Drawing.Point(14, 117);
            this.LevelingCalcTargetLevel5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcTargetLevel5.Name = "LevelingCalcTargetLevel5";
            this.LevelingCalcTargetLevel5.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcTargetLevel5.TabIndex = 19;
            this.LevelingCalcTargetLevel5.Tag = "5";
            this.LevelingCalcTargetLevel5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Doll4
            // 
            this.Doll4.Controls.Add(this.DummyCount4);
            this.Doll4.Controls.Add(this.label22);
            this.Doll4.Controls.Add(this.LevelingCalcNowLevel4);
            this.Doll4.Controls.Add(this.LevelingCalcNowExp4);
            this.Doll4.Controls.Add(this.LevelingCalcTargetLevel4);
            this.Doll4.Enabled = false;
            this.Doll4.Location = new System.Drawing.Point(378, 47);
            this.Doll4.Name = "Doll4";
            this.Doll4.Size = new System.Drawing.Size(82, 175);
            this.Doll4.TabIndex = 31;
            this.Doll4.Tag = "4";
            // 
            // DummyCount4
            // 
            this.DummyCount4.Location = new System.Drawing.Point(12, 152);
            this.DummyCount4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DummyCount4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DummyCount4.Name = "DummyCount4";
            this.DummyCount4.Size = new System.Drawing.Size(50, 21);
            this.DummyCount4.TabIndex = 20;
            this.DummyCount4.Tag = "1";
            this.DummyCount4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 12);
            this.label22.TabIndex = 11;
            this.label22.Text = "4";
            // 
            // LevelingCalcNowLevel4
            // 
            this.LevelingCalcNowLevel4.Location = new System.Drawing.Point(12, 41);
            this.LevelingCalcNowLevel4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel4.Name = "LevelingCalcNowLevel4";
            this.LevelingCalcNowLevel4.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcNowLevel4.TabIndex = 5;
            this.LevelingCalcNowLevel4.Tag = "4";
            this.LevelingCalcNowLevel4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel4.ValueChanged += new System.EventHandler(this.LevelingCalcNowLevel_ValueChanged);
            // 
            // LevelingCalcNowExp4
            // 
            this.LevelingCalcNowExp4.Location = new System.Drawing.Point(3, 80);
            this.LevelingCalcNowExp4.Maximum = new decimal(new int[] {
            3263200,
            0,
            0,
            0});
            this.LevelingCalcNowExp4.Name = "LevelingCalcNowExp4";
            this.LevelingCalcNowExp4.Size = new System.Drawing.Size(74, 21);
            this.LevelingCalcNowExp4.TabIndex = 16;
            this.LevelingCalcNowExp4.Tag = "4";
            // 
            // LevelingCalcTargetLevel4
            // 
            this.LevelingCalcTargetLevel4.Location = new System.Drawing.Point(12, 119);
            this.LevelingCalcTargetLevel4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcTargetLevel4.Name = "LevelingCalcTargetLevel4";
            this.LevelingCalcTargetLevel4.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcTargetLevel4.TabIndex = 20;
            this.LevelingCalcTargetLevel4.Tag = "4";
            this.LevelingCalcTargetLevel4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Doll3
            // 
            this.Doll3.Controls.Add(this.DummyCount3);
            this.Doll3.Controls.Add(this.label24);
            this.Doll3.Controls.Add(this.LevelingCalcNowLevel3);
            this.Doll3.Controls.Add(this.LevelingCalcNowExp3);
            this.Doll3.Controls.Add(this.LevelingCalcTargetLevel3);
            this.Doll3.Enabled = false;
            this.Doll3.Location = new System.Drawing.Point(291, 47);
            this.Doll3.Name = "Doll3";
            this.Doll3.Size = new System.Drawing.Size(81, 175);
            this.Doll3.TabIndex = 30;
            this.Doll3.Tag = "3";
            // 
            // DummyCount3
            // 
            this.DummyCount3.Location = new System.Drawing.Point(16, 152);
            this.DummyCount3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DummyCount3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DummyCount3.Name = "DummyCount3";
            this.DummyCount3.Size = new System.Drawing.Size(50, 21);
            this.DummyCount3.TabIndex = 21;
            this.DummyCount3.Tag = "1";
            this.DummyCount3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(32, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(11, 12);
            this.label24.TabIndex = 12;
            this.label24.Text = "3";
            // 
            // LevelingCalcNowLevel3
            // 
            this.LevelingCalcNowLevel3.Location = new System.Drawing.Point(16, 41);
            this.LevelingCalcNowLevel3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel3.Name = "LevelingCalcNowLevel3";
            this.LevelingCalcNowLevel3.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcNowLevel3.TabIndex = 6;
            this.LevelingCalcNowLevel3.Tag = "3";
            this.LevelingCalcNowLevel3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel3.ValueChanged += new System.EventHandler(this.LevelingCalcNowLevel_ValueChanged);
            // 
            // LevelingCalcNowExp3
            // 
            this.LevelingCalcNowExp3.Location = new System.Drawing.Point(4, 80);
            this.LevelingCalcNowExp3.Maximum = new decimal(new int[] {
            3263200,
            0,
            0,
            0});
            this.LevelingCalcNowExp3.Name = "LevelingCalcNowExp3";
            this.LevelingCalcNowExp3.Size = new System.Drawing.Size(74, 21);
            this.LevelingCalcNowExp3.TabIndex = 15;
            this.LevelingCalcNowExp3.Tag = "3";
            // 
            // LevelingCalcTargetLevel3
            // 
            this.LevelingCalcTargetLevel3.Location = new System.Drawing.Point(16, 119);
            this.LevelingCalcTargetLevel3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcTargetLevel3.Name = "LevelingCalcTargetLevel3";
            this.LevelingCalcTargetLevel3.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcTargetLevel3.TabIndex = 21;
            this.LevelingCalcTargetLevel3.Tag = "3";
            this.LevelingCalcTargetLevel3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Doll2
            // 
            this.Doll2.Controls.Add(this.DummyCount2);
            this.Doll2.Controls.Add(this.label17);
            this.Doll2.Controls.Add(this.LevelingCalcNowLevel2);
            this.Doll2.Controls.Add(this.LevelingCalcNowExp2);
            this.Doll2.Controls.Add(this.LevelingCalcTargetLevel2);
            this.Doll2.Enabled = false;
            this.Doll2.Location = new System.Drawing.Point(195, 47);
            this.Doll2.Name = "Doll2";
            this.Doll2.Size = new System.Drawing.Size(85, 174);
            this.Doll2.TabIndex = 29;
            this.Doll2.Tag = "2";
            // 
            // DummyCount2
            // 
            this.DummyCount2.Location = new System.Drawing.Point(17, 151);
            this.DummyCount2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DummyCount2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DummyCount2.Name = "DummyCount2";
            this.DummyCount2.Size = new System.Drawing.Size(50, 21);
            this.DummyCount2.TabIndex = 22;
            this.DummyCount2.Tag = "1";
            this.DummyCount2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 9;
            this.label17.Text = "2";
            // 
            // LevelingCalcNowLevel2
            // 
            this.LevelingCalcNowLevel2.Location = new System.Drawing.Point(17, 41);
            this.LevelingCalcNowLevel2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel2.Name = "LevelingCalcNowLevel2";
            this.LevelingCalcNowLevel2.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcNowLevel2.TabIndex = 7;
            this.LevelingCalcNowLevel2.Tag = "2";
            this.LevelingCalcNowLevel2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel2.ValueChanged += new System.EventHandler(this.LevelingCalcNowLevel_ValueChanged);
            // 
            // LevelingCalcNowExp2
            // 
            this.LevelingCalcNowExp2.Location = new System.Drawing.Point(5, 80);
            this.LevelingCalcNowExp2.Maximum = new decimal(new int[] {
            3263200,
            0,
            0,
            0});
            this.LevelingCalcNowExp2.Name = "LevelingCalcNowExp2";
            this.LevelingCalcNowExp2.Size = new System.Drawing.Size(74, 21);
            this.LevelingCalcNowExp2.TabIndex = 14;
            this.LevelingCalcNowExp2.Tag = "2";
            // 
            // LevelingCalcTargetLevel2
            // 
            this.LevelingCalcTargetLevel2.Location = new System.Drawing.Point(17, 119);
            this.LevelingCalcTargetLevel2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcTargetLevel2.Name = "LevelingCalcTargetLevel2";
            this.LevelingCalcTargetLevel2.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcTargetLevel2.TabIndex = 22;
            this.LevelingCalcTargetLevel2.Tag = "2";
            this.LevelingCalcTargetLevel2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Doll1
            // 
            this.Doll1.Controls.Add(this.DummyCount1);
            this.Doll1.Controls.Add(this.label16);
            this.Doll1.Controls.Add(this.LevelingCalcNowLevel1);
            this.Doll1.Controls.Add(this.LevelingCalcNowExp1);
            this.Doll1.Controls.Add(this.LevelingCalcTargetLevel1);
            this.Doll1.Location = new System.Drawing.Point(99, 47);
            this.Doll1.Name = "Doll1";
            this.Doll1.Size = new System.Drawing.Size(84, 175);
            this.Doll1.TabIndex = 28;
            this.Doll1.Tag = "1";
            // 
            // DummyCount1
            // 
            this.DummyCount1.Location = new System.Drawing.Point(14, 152);
            this.DummyCount1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DummyCount1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DummyCount1.Name = "DummyCount1";
            this.DummyCount1.Size = new System.Drawing.Size(50, 21);
            this.DummyCount1.TabIndex = 19;
            this.DummyCount1.Tag = "1";
            this.DummyCount1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 8;
            this.label16.Text = "1";
            // 
            // LevelingCalcNowLevel1
            // 
            this.LevelingCalcNowLevel1.Location = new System.Drawing.Point(14, 41);
            this.LevelingCalcNowLevel1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel1.Name = "LevelingCalcNowLevel1";
            this.LevelingCalcNowLevel1.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcNowLevel1.TabIndex = 3;
            this.LevelingCalcNowLevel1.Tag = "1";
            this.LevelingCalcNowLevel1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcNowLevel1.ValueChanged += new System.EventHandler(this.LevelingCalcNowLevel_ValueChanged);
            // 
            // LevelingCalcNowExp1
            // 
            this.LevelingCalcNowExp1.Location = new System.Drawing.Point(5, 80);
            this.LevelingCalcNowExp1.Maximum = new decimal(new int[] {
            3263200,
            0,
            0,
            0});
            this.LevelingCalcNowExp1.Name = "LevelingCalcNowExp1";
            this.LevelingCalcNowExp1.Size = new System.Drawing.Size(74, 21);
            this.LevelingCalcNowExp1.TabIndex = 13;
            this.LevelingCalcNowExp1.Tag = "1";
            // 
            // LevelingCalcTargetLevel1
            // 
            this.LevelingCalcTargetLevel1.Location = new System.Drawing.Point(14, 119);
            this.LevelingCalcTargetLevel1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelingCalcTargetLevel1.Name = "LevelingCalcTargetLevel1";
            this.LevelingCalcTargetLevel1.Size = new System.Drawing.Size(50, 21);
            this.LevelingCalcTargetLevel1.TabIndex = 18;
            this.LevelingCalcTargetLevel1.Tag = "1";
            this.LevelingCalcTargetLevel1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DollEnabler5
            // 
            this.DollEnabler5.AutoSize = true;
            this.DollEnabler5.Location = new System.Drawing.Point(497, 20);
            this.DollEnabler5.Name = "DollEnabler5";
            this.DollEnabler5.Size = new System.Drawing.Size(15, 14);
            this.DollEnabler5.TabIndex = 27;
            this.DollEnabler5.Tag = "5";
            this.DollEnabler5.UseVisualStyleBackColor = true;
            this.DollEnabler5.CheckedChanged += new System.EventHandler(this.DollEnabler_CheckedChange);
            // 
            // DollEnabler2
            // 
            this.DollEnabler2.AutoSize = true;
            this.DollEnabler2.Location = new System.Drawing.Point(231, 20);
            this.DollEnabler2.Name = "DollEnabler2";
            this.DollEnabler2.Size = new System.Drawing.Size(15, 14);
            this.DollEnabler2.TabIndex = 26;
            this.DollEnabler2.Tag = "2";
            this.DollEnabler2.UseVisualStyleBackColor = true;
            this.DollEnabler2.CheckedChanged += new System.EventHandler(this.DollEnabler_CheckedChange);
            // 
            // DollEnabler3
            // 
            this.DollEnabler3.AutoSize = true;
            this.DollEnabler3.Location = new System.Drawing.Point(325, 20);
            this.DollEnabler3.Name = "DollEnabler3";
            this.DollEnabler3.Size = new System.Drawing.Size(15, 14);
            this.DollEnabler3.TabIndex = 25;
            this.DollEnabler3.Tag = "3";
            this.DollEnabler3.UseVisualStyleBackColor = true;
            this.DollEnabler3.CheckedChanged += new System.EventHandler(this.DollEnabler_CheckedChange);
            // 
            // DollEnabler4
            // 
            this.DollEnabler4.AutoSize = true;
            this.DollEnabler4.Location = new System.Drawing.Point(409, 20);
            this.DollEnabler4.Name = "DollEnabler4";
            this.DollEnabler4.Size = new System.Drawing.Size(15, 14);
            this.DollEnabler4.TabIndex = 24;
            this.DollEnabler4.Tag = "4";
            this.DollEnabler4.UseVisualStyleBackColor = true;
            this.DollEnabler4.CheckedChanged += new System.EventHandler(this.DollEnabler_CheckedChange);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "현재 경험치";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "목표 레벨";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "현재 레벨";
            // 
            // EquipmentTab
            // 
            this.EquipmentTab.Controls.Add(this.EquipmentSubTab);
            this.EquipmentTab.Location = new System.Drawing.Point(4, 22);
            this.EquipmentTab.Name = "EquipmentTab";
            this.EquipmentTab.Size = new System.Drawing.Size(873, 579);
            this.EquipmentTab.TabIndex = 5;
            this.EquipmentTab.Text = "장비";
            this.EquipmentTab.UseVisualStyleBackColor = true;
            // 
            // EquipmentSubTab
            // 
            this.EquipmentSubTab.Controls.Add(this.EquipmentDic);
            this.EquipmentSubTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSubTab.Location = new System.Drawing.Point(0, 0);
            this.EquipmentSubTab.Name = "EquipmentSubTab";
            this.EquipmentSubTab.SelectedIndex = 0;
            this.EquipmentSubTab.Size = new System.Drawing.Size(873, 579);
            this.EquipmentSubTab.TabIndex = 0;
            // 
            // EquipmentDic
            // 
            this.EquipmentDic.Controls.Add(this.EquipmentDicInfoGroup);
            this.EquipmentDic.Controls.Add(this.EquipmentDicSearchGroup);
            this.EquipmentDic.Controls.Add(this.EquipmentDicListGroup);
            this.EquipmentDic.Location = new System.Drawing.Point(4, 22);
            this.EquipmentDic.Name = "EquipmentDic";
            this.EquipmentDic.Size = new System.Drawing.Size(865, 553);
            this.EquipmentDic.TabIndex = 0;
            this.EquipmentDic.Text = "장비도감";
            this.EquipmentDic.UseVisualStyleBackColor = true;
            // 
            // EquipmentDicInfoGroup
            // 
            this.EquipmentDicInfoGroup.Controls.Add(this.EquipmentDicNote);
            this.EquipmentDicInfoGroup.Controls.Add(this.EquipmentDicProductTime);
            this.EquipmentDicInfoGroup.Controls.Add(this.EquipmentDicName);
            this.EquipmentDicInfoGroup.Controls.Add(this.tableLayoutPanel1);
            this.EquipmentDicInfoGroup.Controls.Add(this.EquipmentDicDollTypeGroup);
            this.EquipmentDicInfoGroup.Controls.Add(this.EquipmentDicEquipmentImage);
            this.EquipmentDicInfoGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.EquipmentDicInfoGroup.Location = new System.Drawing.Point(0, 0);
            this.EquipmentDicInfoGroup.Name = "EquipmentDicInfoGroup";
            this.EquipmentDicInfoGroup.Size = new System.Drawing.Size(865, 318);
            this.EquipmentDicInfoGroup.TabIndex = 2;
            this.EquipmentDicInfoGroup.TabStop = false;
            this.EquipmentDicInfoGroup.Text = "장비 정보";
            // 
            // EquipmentDicNote
            // 
            this.EquipmentDicNote.AutoEllipsis = true;
            this.EquipmentDicNote.AutoSize = true;
            this.EquipmentDicNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentDicNote.Location = new System.Drawing.Point(159, 91);
            this.EquipmentDicNote.Name = "EquipmentDicNote";
            this.EquipmentDicNote.Size = new System.Drawing.Size(32, 18);
            this.EquipmentDicNote.TabIndex = 5;
            this.EquipmentDicNote.Text = "      ";
            // 
            // EquipmentDicProductTime
            // 
            this.EquipmentDicProductTime.AutoSize = true;
            this.EquipmentDicProductTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentDicProductTime.Location = new System.Drawing.Point(394, 20);
            this.EquipmentDicProductTime.Name = "EquipmentDicProductTime";
            this.EquipmentDicProductTime.Size = new System.Drawing.Size(30, 24);
            this.EquipmentDicProductTime.TabIndex = 4;
            this.EquipmentDicProductTime.Text = "    ";
            this.EquipmentDicProductTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentDicName
            // 
            this.EquipmentDicName.BackColor = System.Drawing.Color.Beige;
            this.EquipmentDicName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EquipmentDicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentDicName.Location = new System.Drawing.Point(162, 20);
            this.EquipmentDicName.Name = "EquipmentDicName";
            this.EquipmentDicName.Size = new System.Drawing.Size(226, 28);
            this.EquipmentDicName.TabIndex = 3;
            this.EquipmentDicName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.EquipmentAbility4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentInitialMagnification4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentMaxMagnification4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentAbility3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentInitialMagnification3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentMaxMagnification3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentMaxMagnification2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentInitialMagnification2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentAbility2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentMaxMagnification1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentInitialMagnification1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentAbility1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(277, 189);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.64286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.78572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.78572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.78572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 123);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // EquipmentAbility4
            // 
            this.EquipmentAbility4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentAbility4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentAbility4.Location = new System.Drawing.Point(3, 101);
            this.EquipmentAbility4.Name = "EquipmentAbility4";
            this.EquipmentAbility4.Size = new System.Drawing.Size(108, 22);
            this.EquipmentAbility4.TabIndex = 14;
            this.EquipmentAbility4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentInitialMagnification4
            // 
            this.EquipmentInitialMagnification4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentInitialMagnification4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentInitialMagnification4.Location = new System.Drawing.Point(117, 101);
            this.EquipmentInitialMagnification4.Name = "EquipmentInitialMagnification4";
            this.EquipmentInitialMagnification4.Size = new System.Drawing.Size(108, 22);
            this.EquipmentInitialMagnification4.TabIndex = 13;
            this.EquipmentInitialMagnification4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentMaxMagnification4
            // 
            this.EquipmentMaxMagnification4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentMaxMagnification4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentMaxMagnification4.Location = new System.Drawing.Point(231, 101);
            this.EquipmentMaxMagnification4.Name = "EquipmentMaxMagnification4";
            this.EquipmentMaxMagnification4.Size = new System.Drawing.Size(109, 22);
            this.EquipmentMaxMagnification4.TabIndex = 12;
            this.EquipmentMaxMagnification4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentAbility3
            // 
            this.EquipmentAbility3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentAbility3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentAbility3.Location = new System.Drawing.Point(3, 74);
            this.EquipmentAbility3.Name = "EquipmentAbility3";
            this.EquipmentAbility3.Size = new System.Drawing.Size(108, 27);
            this.EquipmentAbility3.TabIndex = 11;
            this.EquipmentAbility3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentInitialMagnification3
            // 
            this.EquipmentInitialMagnification3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentInitialMagnification3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentInitialMagnification3.Location = new System.Drawing.Point(117, 74);
            this.EquipmentInitialMagnification3.Name = "EquipmentInitialMagnification3";
            this.EquipmentInitialMagnification3.Size = new System.Drawing.Size(108, 27);
            this.EquipmentInitialMagnification3.TabIndex = 10;
            this.EquipmentInitialMagnification3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentMaxMagnification3
            // 
            this.EquipmentMaxMagnification3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentMaxMagnification3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentMaxMagnification3.Location = new System.Drawing.Point(231, 74);
            this.EquipmentMaxMagnification3.Name = "EquipmentMaxMagnification3";
            this.EquipmentMaxMagnification3.Size = new System.Drawing.Size(109, 27);
            this.EquipmentMaxMagnification3.TabIndex = 9;
            this.EquipmentMaxMagnification3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentMaxMagnification2
            // 
            this.EquipmentMaxMagnification2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentMaxMagnification2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentMaxMagnification2.Location = new System.Drawing.Point(231, 47);
            this.EquipmentMaxMagnification2.Name = "EquipmentMaxMagnification2";
            this.EquipmentMaxMagnification2.Size = new System.Drawing.Size(109, 27);
            this.EquipmentMaxMagnification2.TabIndex = 8;
            this.EquipmentMaxMagnification2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentInitialMagnification2
            // 
            this.EquipmentInitialMagnification2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentInitialMagnification2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentInitialMagnification2.Location = new System.Drawing.Point(117, 47);
            this.EquipmentInitialMagnification2.Name = "EquipmentInitialMagnification2";
            this.EquipmentInitialMagnification2.Size = new System.Drawing.Size(108, 27);
            this.EquipmentInitialMagnification2.TabIndex = 7;
            this.EquipmentInitialMagnification2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentAbility2
            // 
            this.EquipmentAbility2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentAbility2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentAbility2.Location = new System.Drawing.Point(3, 47);
            this.EquipmentAbility2.Name = "EquipmentAbility2";
            this.EquipmentAbility2.Size = new System.Drawing.Size(108, 27);
            this.EquipmentAbility2.TabIndex = 6;
            this.EquipmentAbility2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentMaxMagnification1
            // 
            this.EquipmentMaxMagnification1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentMaxMagnification1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentMaxMagnification1.Location = new System.Drawing.Point(231, 20);
            this.EquipmentMaxMagnification1.Name = "EquipmentMaxMagnification1";
            this.EquipmentMaxMagnification1.Size = new System.Drawing.Size(109, 27);
            this.EquipmentMaxMagnification1.TabIndex = 5;
            this.EquipmentMaxMagnification1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentInitialMagnification1
            // 
            this.EquipmentInitialMagnification1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentInitialMagnification1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentInitialMagnification1.Location = new System.Drawing.Point(117, 20);
            this.EquipmentInitialMagnification1.Name = "EquipmentInitialMagnification1";
            this.EquipmentInitialMagnification1.Size = new System.Drawing.Size(108, 27);
            this.EquipmentInitialMagnification1.TabIndex = 4;
            this.EquipmentInitialMagnification1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentAbility1
            // 
            this.EquipmentAbility1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentAbility1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentAbility1.Location = new System.Drawing.Point(3, 20);
            this.EquipmentAbility1.Name = "EquipmentAbility1";
            this.EquipmentAbility1.Size = new System.Drawing.Size(108, 27);
            this.EquipmentAbility1.TabIndex = 3;
            this.EquipmentAbility1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(231, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "최대";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(117, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "기본";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkKhaki;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "능력치";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentDicDollTypeGroup
            // 
            this.EquipmentDicDollTypeGroup.Controls.Add(this.EquipmentDollTypeOnlyUse);
            this.EquipmentDicDollTypeGroup.Controls.Add(this.EquipmentDollTypeAR);
            this.EquipmentDicDollTypeGroup.Controls.Add(this.EquipmentDollTypeSG);
            this.EquipmentDicDollTypeGroup.Controls.Add(this.EquipmentDollTypeRF);
            this.EquipmentDicDollTypeGroup.Controls.Add(this.EquipmentDollTypeMG);
            this.EquipmentDicDollTypeGroup.Controls.Add(this.EquipmentDollTypeSMG);
            this.EquipmentDicDollTypeGroup.Controls.Add(this.EquipmentDollTypeHG);
            this.EquipmentDicDollTypeGroup.Location = new System.Drawing.Point(6, 196);
            this.EquipmentDicDollTypeGroup.Name = "EquipmentDicDollTypeGroup";
            this.EquipmentDicDollTypeGroup.Size = new System.Drawing.Size(265, 116);
            this.EquipmentDicDollTypeGroup.TabIndex = 1;
            this.EquipmentDicDollTypeGroup.TabStop = false;
            this.EquipmentDicDollTypeGroup.Text = "인형 타입";
            // 
            // EquipmentDollTypeOnlyUse
            // 
            this.EquipmentDollTypeOnlyUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentDollTypeOnlyUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EquipmentDollTypeOnlyUse.Location = new System.Drawing.Point(3, 17);
            this.EquipmentDollTypeOnlyUse.Name = "EquipmentDollTypeOnlyUse";
            this.EquipmentDollTypeOnlyUse.Size = new System.Drawing.Size(259, 96);
            this.EquipmentDollTypeOnlyUse.TabIndex = 6;
            this.EquipmentDollTypeOnlyUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EquipmentDollTypeOnlyUse.Visible = false;
            // 
            // EquipmentDollTypeAR
            // 
            this.EquipmentDollTypeAR.Location = new System.Drawing.Point(178, 20);
            this.EquipmentDollTypeAR.Name = "EquipmentDollTypeAR";
            this.EquipmentDollTypeAR.Size = new System.Drawing.Size(80, 40);
            this.EquipmentDollTypeAR.TabIndex = 5;
            this.EquipmentDollTypeAR.TabStop = false;
            // 
            // EquipmentDollTypeSG
            // 
            this.EquipmentDollTypeSG.Location = new System.Drawing.Point(178, 66);
            this.EquipmentDollTypeSG.Name = "EquipmentDollTypeSG";
            this.EquipmentDollTypeSG.Size = new System.Drawing.Size(80, 40);
            this.EquipmentDollTypeSG.TabIndex = 4;
            this.EquipmentDollTypeSG.TabStop = false;
            // 
            // EquipmentDollTypeRF
            // 
            this.EquipmentDollTypeRF.Location = new System.Drawing.Point(6, 66);
            this.EquipmentDollTypeRF.Name = "EquipmentDollTypeRF";
            this.EquipmentDollTypeRF.Size = new System.Drawing.Size(80, 40);
            this.EquipmentDollTypeRF.TabIndex = 3;
            this.EquipmentDollTypeRF.TabStop = false;
            // 
            // EquipmentDollTypeMG
            // 
            this.EquipmentDollTypeMG.Location = new System.Drawing.Point(92, 66);
            this.EquipmentDollTypeMG.Name = "EquipmentDollTypeMG";
            this.EquipmentDollTypeMG.Size = new System.Drawing.Size(80, 40);
            this.EquipmentDollTypeMG.TabIndex = 2;
            this.EquipmentDollTypeMG.TabStop = false;
            // 
            // EquipmentDollTypeSMG
            // 
            this.EquipmentDollTypeSMG.Location = new System.Drawing.Point(92, 20);
            this.EquipmentDollTypeSMG.Name = "EquipmentDollTypeSMG";
            this.EquipmentDollTypeSMG.Size = new System.Drawing.Size(80, 40);
            this.EquipmentDollTypeSMG.TabIndex = 1;
            this.EquipmentDollTypeSMG.TabStop = false;
            // 
            // EquipmentDollTypeHG
            // 
            this.EquipmentDollTypeHG.Location = new System.Drawing.Point(6, 20);
            this.EquipmentDollTypeHG.Name = "EquipmentDollTypeHG";
            this.EquipmentDollTypeHG.Size = new System.Drawing.Size(80, 40);
            this.EquipmentDollTypeHG.TabIndex = 0;
            this.EquipmentDollTypeHG.TabStop = false;
            // 
            // EquipmentDicEquipmentImage
            // 
            this.EquipmentDicEquipmentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EquipmentDicEquipmentImage.Location = new System.Drawing.Point(6, 20);
            this.EquipmentDicEquipmentImage.Name = "EquipmentDicEquipmentImage";
            this.EquipmentDicEquipmentImage.Size = new System.Drawing.Size(140, 140);
            this.EquipmentDicEquipmentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EquipmentDicEquipmentImage.TabIndex = 0;
            this.EquipmentDicEquipmentImage.TabStop = false;
            // 
            // EquipmentDicSearchGroup
            // 
            this.EquipmentDicSearchGroup.Controls.Add(this.label71);
            this.EquipmentDicSearchGroup.Controls.Add(this.EquipmentProductTimeTableButton);
            this.EquipmentDicSearchGroup.Controls.Add(this.groupBox8);
            this.EquipmentDicSearchGroup.Controls.Add(this.groupBox7);
            this.EquipmentDicSearchGroup.Controls.Add(this.EquipmentDicSearchTextBox);
            this.EquipmentDicSearchGroup.Location = new System.Drawing.Point(431, 324);
            this.EquipmentDicSearchGroup.Name = "EquipmentDicSearchGroup";
            this.EquipmentDicSearchGroup.Size = new System.Drawing.Size(406, 223);
            this.EquipmentDicSearchGroup.TabIndex = 1;
            this.EquipmentDicSearchGroup.TabStop = false;
            this.EquipmentDicSearchGroup.Text = "장비 검색";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(11, 32);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(77, 12);
            this.label71.TabIndex = 19;
            this.label71.Text = "검색할 장비 :";
            // 
            // EquipmentProductTimeTableButton
            // 
            this.EquipmentProductTimeTableButton.Location = new System.Drawing.Point(132, 185);
            this.EquipmentProductTimeTableButton.Name = "EquipmentProductTimeTableButton";
            this.EquipmentProductTimeTableButton.Size = new System.Drawing.Size(268, 30);
            this.EquipmentProductTimeTableButton.TabIndex = 18;
            this.EquipmentProductTimeTableButton.Text = "제조 시간표 열람";
            this.EquipmentProductTimeTableButton.UseVisualStyleBackColor = true;
            this.EquipmentProductTimeTableButton.Click += new System.EventHandler(this.EquipmentProductTimeTableButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.EquipmentDicCategoryAttachment);
            this.groupBox8.Controls.Add(this.EquipmentDicCategoryDoll);
            this.groupBox8.Controls.Add(this.EquipmentDicCategoryBullet);
            this.groupBox8.Location = new System.Drawing.Point(111, 56);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(67, 93);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "분류";
            // 
            // EquipmentDicCategoryAttachment
            // 
            this.EquipmentDicCategoryAttachment.AutoSize = true;
            this.EquipmentDicCategoryAttachment.Checked = true;
            this.EquipmentDicCategoryAttachment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EquipmentDicCategoryAttachment.Location = new System.Drawing.Point(9, 17);
            this.EquipmentDicCategoryAttachment.Name = "EquipmentDicCategoryAttachment";
            this.EquipmentDicCategoryAttachment.Size = new System.Drawing.Size(48, 16);
            this.EquipmentDicCategoryAttachment.TabIndex = 3;
            this.EquipmentDicCategoryAttachment.Tag = "2";
            this.EquipmentDicCategoryAttachment.Text = "부속";
            this.EquipmentDicCategoryAttachment.UseVisualStyleBackColor = true;
            this.EquipmentDicCategoryAttachment.CheckedChanged += new System.EventHandler(this.EquipmentDicSearchSetting_CheckedChanged);
            // 
            // EquipmentDicCategoryDoll
            // 
            this.EquipmentDicCategoryDoll.AutoSize = true;
            this.EquipmentDicCategoryDoll.Checked = true;
            this.EquipmentDicCategoryDoll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EquipmentDicCategoryDoll.Location = new System.Drawing.Point(9, 63);
            this.EquipmentDicCategoryDoll.Name = "EquipmentDicCategoryDoll";
            this.EquipmentDicCategoryDoll.Size = new System.Drawing.Size(48, 16);
            this.EquipmentDicCategoryDoll.TabIndex = 2;
            this.EquipmentDicCategoryDoll.Tag = "2";
            this.EquipmentDicCategoryDoll.Text = "인형";
            this.EquipmentDicCategoryDoll.UseVisualStyleBackColor = true;
            this.EquipmentDicCategoryDoll.CheckedChanged += new System.EventHandler(this.EquipmentDicSearchSetting_CheckedChanged);
            // 
            // EquipmentDicCategoryBullet
            // 
            this.EquipmentDicCategoryBullet.AutoSize = true;
            this.EquipmentDicCategoryBullet.Checked = true;
            this.EquipmentDicCategoryBullet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EquipmentDicCategoryBullet.Location = new System.Drawing.Point(9, 39);
            this.EquipmentDicCategoryBullet.Name = "EquipmentDicCategoryBullet";
            this.EquipmentDicCategoryBullet.Size = new System.Drawing.Size(48, 16);
            this.EquipmentDicCategoryBullet.TabIndex = 1;
            this.EquipmentDicCategoryBullet.Tag = "2";
            this.EquipmentDicCategoryBullet.Text = "탄환";
            this.EquipmentDicCategoryBullet.UseVisualStyleBackColor = true;
            this.EquipmentDicCategoryBullet.CheckedChanged += new System.EventHandler(this.EquipmentDicSearchSetting_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.EquipmentDicGradeExtra);
            this.groupBox7.Controls.Add(this.EquipmentDicGrade5);
            this.groupBox7.Controls.Add(this.EquipmentDicGrade4);
            this.groupBox7.Controls.Add(this.EquipmentDicGrade3);
            this.groupBox7.Controls.Add(this.EquipmentDicGrade2);
            this.groupBox7.Location = new System.Drawing.Point(6, 56);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(99, 160);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "등급";
            // 
            // EquipmentDicGradeExtra
            // 
            this.EquipmentDicGradeExtra.AutoSize = true;
            this.EquipmentDicGradeExtra.Checked = true;
            this.EquipmentDicGradeExtra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EquipmentDicGradeExtra.Location = new System.Drawing.Point(6, 137);
            this.EquipmentDicGradeExtra.Name = "EquipmentDicGradeExtra";
            this.EquipmentDicGradeExtra.Size = new System.Drawing.Size(36, 16);
            this.EquipmentDicGradeExtra.TabIndex = 4;
            this.EquipmentDicGradeExtra.Tag = "0";
            this.EquipmentDicGradeExtra.Text = "★";
            this.EquipmentDicGradeExtra.UseVisualStyleBackColor = true;
            this.EquipmentDicGradeExtra.CheckedChanged += new System.EventHandler(this.EquipmentDicSearchSetting_CheckedChanged);
            // 
            // EquipmentDicGrade5
            // 
            this.EquipmentDicGrade5.AutoSize = true;
            this.EquipmentDicGrade5.Checked = true;
            this.EquipmentDicGrade5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EquipmentDicGrade5.Location = new System.Drawing.Point(6, 106);
            this.EquipmentDicGrade5.Name = "EquipmentDicGrade5";
            this.EquipmentDicGrade5.Size = new System.Drawing.Size(84, 16);
            this.EquipmentDicGrade5.TabIndex = 3;
            this.EquipmentDicGrade5.Tag = "5";
            this.EquipmentDicGrade5.Text = "☆☆☆☆☆";
            this.EquipmentDicGrade5.UseVisualStyleBackColor = true;
            this.EquipmentDicGrade5.CheckedChanged += new System.EventHandler(this.EquipmentDicSearchSetting_CheckedChanged);
            // 
            // EquipmentDicGrade4
            // 
            this.EquipmentDicGrade4.AutoSize = true;
            this.EquipmentDicGrade4.Checked = true;
            this.EquipmentDicGrade4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EquipmentDicGrade4.Location = new System.Drawing.Point(6, 76);
            this.EquipmentDicGrade4.Name = "EquipmentDicGrade4";
            this.EquipmentDicGrade4.Size = new System.Drawing.Size(72, 16);
            this.EquipmentDicGrade4.TabIndex = 2;
            this.EquipmentDicGrade4.Tag = "4";
            this.EquipmentDicGrade4.Text = "☆☆☆☆";
            this.EquipmentDicGrade4.UseVisualStyleBackColor = true;
            this.EquipmentDicGrade4.CheckedChanged += new System.EventHandler(this.EquipmentDicSearchSetting_CheckedChanged);
            // 
            // EquipmentDicGrade3
            // 
            this.EquipmentDicGrade3.AutoSize = true;
            this.EquipmentDicGrade3.Checked = true;
            this.EquipmentDicGrade3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EquipmentDicGrade3.Location = new System.Drawing.Point(6, 46);
            this.EquipmentDicGrade3.Name = "EquipmentDicGrade3";
            this.EquipmentDicGrade3.Size = new System.Drawing.Size(60, 16);
            this.EquipmentDicGrade3.TabIndex = 1;
            this.EquipmentDicGrade3.Tag = "3";
            this.EquipmentDicGrade3.Text = "☆☆☆";
            this.EquipmentDicGrade3.UseVisualStyleBackColor = true;
            this.EquipmentDicGrade3.CheckedChanged += new System.EventHandler(this.EquipmentDicSearchSetting_CheckedChanged);
            // 
            // EquipmentDicGrade2
            // 
            this.EquipmentDicGrade2.AutoSize = true;
            this.EquipmentDicGrade2.Checked = true;
            this.EquipmentDicGrade2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EquipmentDicGrade2.Location = new System.Drawing.Point(6, 16);
            this.EquipmentDicGrade2.Name = "EquipmentDicGrade2";
            this.EquipmentDicGrade2.Size = new System.Drawing.Size(48, 16);
            this.EquipmentDicGrade2.TabIndex = 0;
            this.EquipmentDicGrade2.Tag = "2";
            this.EquipmentDicGrade2.Text = "☆☆";
            this.EquipmentDicGrade2.UseVisualStyleBackColor = true;
            this.EquipmentDicGrade2.CheckedChanged += new System.EventHandler(this.EquipmentDicSearchSetting_CheckedChanged);
            // 
            // EquipmentDicSearchTextBox
            // 
            this.EquipmentDicSearchTextBox.Location = new System.Drawing.Point(94, 29);
            this.EquipmentDicSearchTextBox.Name = "EquipmentDicSearchTextBox";
            this.EquipmentDicSearchTextBox.Size = new System.Drawing.Size(306, 21);
            this.EquipmentDicSearchTextBox.TabIndex = 8;
            this.EquipmentDicSearchTextBox.TextChanged += new System.EventHandler(this.EquipmentDicSearchTextBox_TextChanged);
            // 
            // EquipmentDicListGroup
            // 
            this.EquipmentDicListGroup.Controls.Add(this.EquipmentDicListView);
            this.EquipmentDicListGroup.Location = new System.Drawing.Point(3, 327);
            this.EquipmentDicListGroup.Name = "EquipmentDicListGroup";
            this.EquipmentDicListGroup.Size = new System.Drawing.Size(422, 223);
            this.EquipmentDicListGroup.TabIndex = 0;
            this.EquipmentDicListGroup.TabStop = false;
            this.EquipmentDicListGroup.Text = "장비 목록";
            // 
            // EquipmentDicListView
            // 
            this.EquipmentDicListView.AllowColumnReorder = true;
            this.EquipmentDicListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EquipmentName,
            this.EquipmentType,
            this.EquipmentCategory,
            this.EquipmentGrade,
            this.EquipmentProductTime});
            this.EquipmentDicListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentDicListView.FullRowSelect = true;
            this.EquipmentDicListView.GridLines = true;
            this.EquipmentDicListView.HideSelection = false;
            this.EquipmentDicListView.Location = new System.Drawing.Point(3, 17);
            this.EquipmentDicListView.Name = "EquipmentDicListView";
            this.EquipmentDicListView.Size = new System.Drawing.Size(416, 203);
            this.EquipmentDicListView.TabIndex = 0;
            this.EquipmentDicListView.UseCompatibleStateImageBehavior = false;
            this.EquipmentDicListView.View = System.Windows.Forms.View.Details;
            this.EquipmentDicListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            this.EquipmentDicListView.SelectedIndexChanged += new System.EventHandler(this.EquipmentDicListView_SelectedIndexChanged);
            // 
            // EquipmentName
            // 
            this.EquipmentName.Text = "장비 이름";
            this.EquipmentName.Width = 110;
            // 
            // EquipmentType
            // 
            this.EquipmentType.Text = "장비 종류";
            this.EquipmentType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipmentType.Width = 100;
            // 
            // EquipmentCategory
            // 
            this.EquipmentCategory.Text = "분류";
            this.EquipmentCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipmentCategory.Width = 50;
            // 
            // EquipmentGrade
            // 
            this.EquipmentGrade.Tag = "Grade";
            this.EquipmentGrade.Text = "등급";
            this.EquipmentGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipmentGrade.Width = 75;
            // 
            // EquipmentProductTime
            // 
            this.EquipmentProductTime.Tag = "Time";
            this.EquipmentProductTime.Text = "제조 시간";
            this.EquipmentProductTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipmentProductTime.Width = 70;
            // 
            // FreeOperation
            // 
            this.FreeOperation.Controls.Add(this.FreeOPSettingGroup);
            this.FreeOperation.Controls.Add(this.FreeOPListGroup);
            this.FreeOperation.Location = new System.Drawing.Point(4, 22);
            this.FreeOperation.Name = "FreeOperation";
            this.FreeOperation.Size = new System.Drawing.Size(873, 579);
            this.FreeOperation.TabIndex = 2;
            this.FreeOperation.Text = "자율작전";
            this.FreeOperation.UseVisualStyleBackColor = true;
            // 
            // FreeOPSettingGroup
            // 
            this.FreeOPSettingGroup.Controls.Add(this.FreeOPSpecialDropSettingGroup);
            this.FreeOPSettingGroup.Controls.Add(this.groupBox6);
            this.FreeOPSettingGroup.Controls.Add(this.FreeOPLocationTypeGroup);
            this.FreeOPSettingGroup.Controls.Add(this.FreeOPSearchResetButton);
            this.FreeOPSettingGroup.Controls.Add(this.FreeOPSearchButton);
            this.FreeOPSettingGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FreeOPSettingGroup.Location = new System.Drawing.Point(0, 367);
            this.FreeOPSettingGroup.Name = "FreeOPSettingGroup";
            this.FreeOPSettingGroup.Size = new System.Drawing.Size(873, 212);
            this.FreeOPSettingGroup.TabIndex = 2;
            this.FreeOPSettingGroup.TabStop = false;
            this.FreeOPSettingGroup.Text = "자율작전 설정";
            // 
            // FreeOPSpecialDropSettingGroup
            // 
            this.FreeOPSpecialDropSettingGroup.Controls.Add(this.FreeOPSpecialDropNoExist);
            this.FreeOPSpecialDropSettingGroup.Controls.Add(this.FreeOPSpecialDropExist);
            this.FreeOPSpecialDropSettingGroup.Location = new System.Drawing.Point(336, 124);
            this.FreeOPSpecialDropSettingGroup.Name = "FreeOPSpecialDropSettingGroup";
            this.FreeOPSpecialDropSettingGroup.Size = new System.Drawing.Size(126, 40);
            this.FreeOPSpecialDropSettingGroup.TabIndex = 20;
            this.FreeOPSpecialDropSettingGroup.TabStop = false;
            this.FreeOPSpecialDropSettingGroup.Text = "한정 드롭여부";
            // 
            // FreeOPSpecialDropNoExist
            // 
            this.FreeOPSpecialDropNoExist.AutoSize = true;
            this.FreeOPSpecialDropNoExist.Checked = true;
            this.FreeOPSpecialDropNoExist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FreeOPSpecialDropNoExist.Location = new System.Drawing.Point(60, 19);
            this.FreeOPSpecialDropNoExist.Name = "FreeOPSpecialDropNoExist";
            this.FreeOPSpecialDropNoExist.Size = new System.Drawing.Size(48, 16);
            this.FreeOPSpecialDropNoExist.TabIndex = 1;
            this.FreeOPSpecialDropNoExist.Text = "없음";
            this.FreeOPSpecialDropNoExist.UseVisualStyleBackColor = true;
            // 
            // FreeOPSpecialDropExist
            // 
            this.FreeOPSpecialDropExist.AutoSize = true;
            this.FreeOPSpecialDropExist.Checked = true;
            this.FreeOPSpecialDropExist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FreeOPSpecialDropExist.Location = new System.Drawing.Point(6, 19);
            this.FreeOPSpecialDropExist.Name = "FreeOPSpecialDropExist";
            this.FreeOPSpecialDropExist.Size = new System.Drawing.Size(48, 16);
            this.FreeOPSpecialDropExist.TabIndex = 0;
            this.FreeOPSpecialDropExist.Text = "있음";
            this.FreeOPSpecialDropExist.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label54);
            this.groupBox6.Controls.Add(this.FreeOPMinLevelUpDown);
            this.groupBox6.Controls.Add(this.label51);
            this.groupBox6.Controls.Add(this.FreeOPMaxLevelUpDown);
            this.groupBox6.Controls.Add(this.label60);
            this.groupBox6.Controls.Add(this.label53);
            this.groupBox6.Controls.Add(this.label59);
            this.groupBox6.Controls.Add(this.FreeOPMinMUUpDown);
            this.groupBox6.Controls.Add(this.FreeOPMaxTimeLabel);
            this.groupBox6.Controls.Add(this.label56);
            this.groupBox6.Controls.Add(this.FreeOPMinTimeLabel);
            this.groupBox6.Controls.Add(this.FreeOPMaxMUUpDown);
            this.groupBox6.Controls.Add(this.label58);
            this.groupBox6.Controls.Add(this.FreeOPMinTimeUpDown);
            this.groupBox6.Controls.Add(this.FreeOPMaxTimeUpDown);
            this.groupBox6.Controls.Add(this.label57);
            this.groupBox6.Location = new System.Drawing.Point(6, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(324, 144);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "작전 조건";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 23);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(73, 12);
            this.label54.TabIndex = 5;
            this.label54.Text = "필요 제대 수";
            // 
            // FreeOPMinLevelUpDown
            // 
            this.FreeOPMinLevelUpDown.Location = new System.Drawing.Point(81, 59);
            this.FreeOPMinLevelUpDown.Name = "FreeOPMinLevelUpDown";
            this.FreeOPMinLevelUpDown.Size = new System.Drawing.Size(63, 21);
            this.FreeOPMinLevelUpDown.TabIndex = 0;
            this.FreeOPMinLevelUpDown.ValueChanged += new System.EventHandler(this.FreeOPMinLevelUpDown_ValueChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(146, 63);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(46, 12);
            this.label51.TabIndex = 1;
            this.label51.Text = "Lv 부터";
            // 
            // FreeOPMaxLevelUpDown
            // 
            this.FreeOPMaxLevelUpDown.Location = new System.Drawing.Point(198, 59);
            this.FreeOPMaxLevelUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FreeOPMaxLevelUpDown.Name = "FreeOPMaxLevelUpDown";
            this.FreeOPMaxLevelUpDown.Size = new System.Drawing.Size(60, 21);
            this.FreeOPMaxLevelUpDown.TabIndex = 2;
            this.FreeOPMaxLevelUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.FreeOPMaxLevelUpDown.ValueChanged += new System.EventHandler(this.FreeOPMaxLevelUpDown_ValueChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(6, 63);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(69, 12);
            this.label60.TabIndex = 15;
            this.label60.Text = "페널티 레벨";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(260, 63);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(46, 12);
            this.label53.TabIndex = 3;
            this.label53.Text = "Lv 까지";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(6, 108);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(81, 12);
            this.label59.TabIndex = 14;
            this.label59.Text = "작전 수행시간";
            // 
            // FreeOPMinMUUpDown
            // 
            this.FreeOPMinMUUpDown.Location = new System.Drawing.Point(81, 19);
            this.FreeOPMinMUUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.FreeOPMinMUUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FreeOPMinMUUpDown.Name = "FreeOPMinMUUpDown";
            this.FreeOPMinMUUpDown.Size = new System.Drawing.Size(37, 21);
            this.FreeOPMinMUUpDown.TabIndex = 4;
            this.FreeOPMinMUUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FreeOPMinMUUpDown.ValueChanged += new System.EventHandler(this.FreeOPMinMUUpDown_ValueChanged);
            // 
            // FreeOPMaxTimeLabel
            // 
            this.FreeOPMaxTimeLabel.AutoSize = true;
            this.FreeOPMaxTimeLabel.Location = new System.Drawing.Point(211, 127);
            this.FreeOPMaxTimeLabel.Name = "FreeOPMaxTimeLabel";
            this.FreeOPMaxTimeLabel.Size = new System.Drawing.Size(39, 12);
            this.FreeOPMaxTimeLabel.TabIndex = 13;
            this.FreeOPMaxTimeLabel.Text = "(0 : 0)";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(121, 24);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(14, 12);
            this.label56.TabIndex = 6;
            this.label56.Text = "~";
            // 
            // FreeOPMinTimeLabel
            // 
            this.FreeOPMinTimeLabel.AutoSize = true;
            this.FreeOPMinTimeLabel.Location = new System.Drawing.Point(96, 127);
            this.FreeOPMinTimeLabel.Name = "FreeOPMinTimeLabel";
            this.FreeOPMinTimeLabel.Size = new System.Drawing.Size(39, 12);
            this.FreeOPMinTimeLabel.TabIndex = 12;
            this.FreeOPMinTimeLabel.Text = "(0 : 0)";
            // 
            // FreeOPMaxMUUpDown
            // 
            this.FreeOPMaxMUUpDown.Location = new System.Drawing.Point(138, 19);
            this.FreeOPMaxMUUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.FreeOPMaxMUUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FreeOPMaxMUUpDown.Name = "FreeOPMaxMUUpDown";
            this.FreeOPMaxMUUpDown.Size = new System.Drawing.Size(37, 21);
            this.FreeOPMaxMUUpDown.TabIndex = 7;
            this.FreeOPMaxMUUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.FreeOPMaxMUUpDown.ValueChanged += new System.EventHandler(this.FreeOPMaxMUUpDown_ValueChanged);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(267, 108);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(45, 12);
            this.label58.TabIndex = 11;
            this.label58.Text = "분 까지";
            // 
            // FreeOPMinTimeUpDown
            // 
            this.FreeOPMinTimeUpDown.Location = new System.Drawing.Point(88, 103);
            this.FreeOPMinTimeUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FreeOPMinTimeUpDown.Name = "FreeOPMinTimeUpDown";
            this.FreeOPMinTimeUpDown.Size = new System.Drawing.Size(65, 21);
            this.FreeOPMinTimeUpDown.TabIndex = 8;
            this.FreeOPMinTimeUpDown.ValueChanged += new System.EventHandler(this.FreeOPMinTimeUpDown_ValueChanged);
            // 
            // FreeOPMaxTimeUpDown
            // 
            this.FreeOPMaxTimeUpDown.Location = new System.Drawing.Point(200, 103);
            this.FreeOPMaxTimeUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FreeOPMaxTimeUpDown.Name = "FreeOPMaxTimeUpDown";
            this.FreeOPMaxTimeUpDown.Size = new System.Drawing.Size(65, 21);
            this.FreeOPMaxTimeUpDown.TabIndex = 10;
            this.FreeOPMaxTimeUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FreeOPMaxTimeUpDown.ValueChanged += new System.EventHandler(this.FreeOPMaxTimeUpDown_ValueChanged);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(153, 108);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(45, 12);
            this.label57.TabIndex = 9;
            this.label57.Text = "분 부터";
            // 
            // FreeOPLocationTypeGroup
            // 
            this.FreeOPLocationTypeGroup.Controls.Add(this.FreeOPLocationEmergency);
            this.FreeOPLocationTypeGroup.Controls.Add(this.FreeOPLocationNight);
            this.FreeOPLocationTypeGroup.Controls.Add(this.FreeOPLocationNormal);
            this.FreeOPLocationTypeGroup.Location = new System.Drawing.Point(336, 20);
            this.FreeOPLocationTypeGroup.Name = "FreeOPLocationTypeGroup";
            this.FreeOPLocationTypeGroup.Size = new System.Drawing.Size(76, 100);
            this.FreeOPLocationTypeGroup.TabIndex = 18;
            this.FreeOPLocationTypeGroup.TabStop = false;
            this.FreeOPLocationTypeGroup.Text = "지역 타입";
            // 
            // FreeOPLocationEmergency
            // 
            this.FreeOPLocationEmergency.AutoSize = true;
            this.FreeOPLocationEmergency.Checked = true;
            this.FreeOPLocationEmergency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FreeOPLocationEmergency.Location = new System.Drawing.Point(6, 42);
            this.FreeOPLocationEmergency.Name = "FreeOPLocationEmergency";
            this.FreeOPLocationEmergency.Size = new System.Drawing.Size(48, 16);
            this.FreeOPLocationEmergency.TabIndex = 2;
            this.FreeOPLocationEmergency.Tag = "Emergency";
            this.FreeOPLocationEmergency.Text = "긴급";
            this.FreeOPLocationEmergency.UseVisualStyleBackColor = true;
            // 
            // FreeOPLocationNight
            // 
            this.FreeOPLocationNight.AutoSize = true;
            this.FreeOPLocationNight.Checked = true;
            this.FreeOPLocationNight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FreeOPLocationNight.Location = new System.Drawing.Point(6, 64);
            this.FreeOPLocationNight.Name = "FreeOPLocationNight";
            this.FreeOPLocationNight.Size = new System.Drawing.Size(48, 16);
            this.FreeOPLocationNight.TabIndex = 1;
            this.FreeOPLocationNight.Tag = "Night";
            this.FreeOPLocationNight.Text = "야간";
            this.FreeOPLocationNight.UseVisualStyleBackColor = true;
            // 
            // FreeOPLocationNormal
            // 
            this.FreeOPLocationNormal.AutoSize = true;
            this.FreeOPLocationNormal.Checked = true;
            this.FreeOPLocationNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FreeOPLocationNormal.Location = new System.Drawing.Point(6, 21);
            this.FreeOPLocationNormal.Name = "FreeOPLocationNormal";
            this.FreeOPLocationNormal.Size = new System.Drawing.Size(48, 16);
            this.FreeOPLocationNormal.TabIndex = 0;
            this.FreeOPLocationNormal.Tag = "Normal";
            this.FreeOPLocationNormal.Text = "일반";
            this.FreeOPLocationNormal.UseVisualStyleBackColor = true;
            // 
            // FreeOPSearchResetButton
            // 
            this.FreeOPSearchResetButton.BackgroundImage = global::Girls_FrontierLine_Supporter.Properties.Resources.iconrec1;
            this.FreeOPSearchResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FreeOPSearchResetButton.Location = new System.Drawing.Point(418, 84);
            this.FreeOPSearchResetButton.Name = "FreeOPSearchResetButton";
            this.FreeOPSearchResetButton.Size = new System.Drawing.Size(75, 31);
            this.FreeOPSearchResetButton.TabIndex = 17;
            this.FreeOPSearchResetButton.Text = "초기화";
            this.FreeOPSearchResetButton.UseVisualStyleBackColor = true;
            this.FreeOPSearchResetButton.Click += new System.EventHandler(this.FreeOPSearchResetButton_Click);
            // 
            // FreeOPSearchButton
            // 
            this.FreeOPSearchButton.BackgroundImage = global::Girls_FrontierLine_Supporter.Properties.Resources.iconrec1;
            this.FreeOPSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FreeOPSearchButton.Location = new System.Drawing.Point(418, 49);
            this.FreeOPSearchButton.Name = "FreeOPSearchButton";
            this.FreeOPSearchButton.Size = new System.Drawing.Size(75, 29);
            this.FreeOPSearchButton.TabIndex = 16;
            this.FreeOPSearchButton.Text = "검색";
            this.FreeOPSearchButton.UseVisualStyleBackColor = true;
            this.FreeOPSearchButton.Click += new System.EventHandler(this.FreeOPSearchButton_Click);
            // 
            // FreeOPListGroup
            // 
            this.FreeOPListGroup.Controls.Add(this.FreeOPListView);
            this.FreeOPListGroup.Location = new System.Drawing.Point(0, 6);
            this.FreeOPListGroup.Name = "FreeOPListGroup";
            this.FreeOPListGroup.Size = new System.Drawing.Size(848, 355);
            this.FreeOPListGroup.TabIndex = 0;
            this.FreeOPListGroup.TabStop = false;
            this.FreeOPListGroup.Text = "자율작전 목록";
            // 
            // FreeOPListView
            // 
            this.FreeOPListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FreeOPLocation,
            this.FreeOPPaneltyLevel,
            this.FreeOPRequireMU,
            this.FreeOPTime,
            this.FreeOPRequireFP,
            this.FreeOPRequireResource,
            this.FreeOPBaseEXP,
            this.FreeOPDollEXP,
            this.FreeOPDollEXPByTime,
            this.FreeOPDropCount,
            this.FreeOPSpecialDrop});
            this.FreeOPListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreeOPListView.FullRowSelect = true;
            this.FreeOPListView.GridLines = true;
            this.FreeOPListView.HideSelection = false;
            this.FreeOPListView.Location = new System.Drawing.Point(3, 17);
            this.FreeOPListView.Name = "FreeOPListView";
            this.FreeOPListView.Size = new System.Drawing.Size(842, 335);
            this.FreeOPListView.TabIndex = 0;
            this.FreeOPListView.UseCompatibleStateImageBehavior = false;
            this.FreeOPListView.View = System.Windows.Forms.View.Details;
            this.FreeOPListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            // 
            // FreeOPLocation
            // 
            this.FreeOPLocation.Text = "장소";
            // 
            // FreeOPPaneltyLevel
            // 
            this.FreeOPPaneltyLevel.Tag = "Numeric";
            this.FreeOPPaneltyLevel.Text = "페널티 Lv";
            this.FreeOPPaneltyLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeOPPaneltyLevel.Width = 80;
            // 
            // FreeOPRequireMU
            // 
            this.FreeOPRequireMU.Tag = "Numeric";
            this.FreeOPRequireMU.Text = "필요 제대수";
            this.FreeOPRequireMU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeOPRequireMU.Width = 80;
            // 
            // FreeOPTime
            // 
            this.FreeOPTime.Tag = "Time";
            this.FreeOPTime.Text = "소요시간";
            this.FreeOPTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FreeOPRequireFP
            // 
            this.FreeOPRequireFP.Tag = "Numeric";
            this.FreeOPRequireFP.Text = "필요 전투력";
            this.FreeOPRequireFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeOPRequireFP.Width = 80;
            // 
            // FreeOPRequireResource
            // 
            this.FreeOPRequireResource.Text = "필요 자원량";
            this.FreeOPRequireResource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeOPRequireResource.Width = 80;
            // 
            // FreeOPBaseEXP
            // 
            this.FreeOPBaseEXP.Tag = "Numeric";
            this.FreeOPBaseEXP.Text = "기본 경험치";
            this.FreeOPBaseEXP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeOPBaseEXP.Width = 80;
            // 
            // FreeOPDollEXP
            // 
            this.FreeOPDollEXP.Tag = "Numeric";
            this.FreeOPDollEXP.Text = "인형 경험치";
            this.FreeOPDollEXP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeOPDollEXP.Width = 80;
            // 
            // FreeOPDollEXPByTime
            // 
            this.FreeOPDollEXPByTime.Tag = "Numeric";
            this.FreeOPDollEXPByTime.Text = "인형 경험치(시간당)";
            this.FreeOPDollEXPByTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeOPDollEXPByTime.Width = 125;
            // 
            // FreeOPDropCount
            // 
            this.FreeOPDropCount.Tag = "Numeric";
            this.FreeOPDropCount.Text = "드롭 개수";
            this.FreeOPDropCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeOPDropCount.Width = 70;
            // 
            // FreeOPSpecialDrop
            // 
            this.FreeOPSpecialDrop.Text = "한정 드롭";
            this.FreeOPSpecialDrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeOPSpecialDrop.Width = 85;
            // 
            // Fairy
            // 
            this.Fairy.Controls.Add(this.FairySubTab);
            this.Fairy.Location = new System.Drawing.Point(4, 22);
            this.Fairy.Name = "Fairy";
            this.Fairy.Padding = new System.Windows.Forms.Padding(3);
            this.Fairy.Size = new System.Drawing.Size(873, 579);
            this.Fairy.TabIndex = 6;
            this.Fairy.Text = "요정";
            this.Fairy.UseVisualStyleBackColor = true;
            // 
            // FairySubTab
            // 
            this.FairySubTab.Controls.Add(this.FairyDic);
            this.FairySubTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FairySubTab.Location = new System.Drawing.Point(3, 3);
            this.FairySubTab.Name = "FairySubTab";
            this.FairySubTab.SelectedIndex = 0;
            this.FairySubTab.Size = new System.Drawing.Size(867, 573);
            this.FairySubTab.TabIndex = 1;
            // 
            // FairyDic
            // 
            this.FairyDic.Controls.Add(this.FairyInfoGroup);
            this.FairyDic.Controls.Add(this.FairySearchGroup);
            this.FairyDic.Controls.Add(this.FairyListGroup);
            this.FairyDic.Location = new System.Drawing.Point(4, 22);
            this.FairyDic.Name = "FairyDic";
            this.FairyDic.Padding = new System.Windows.Forms.Padding(3);
            this.FairyDic.Size = new System.Drawing.Size(859, 547);
            this.FairyDic.TabIndex = 0;
            this.FairyDic.Text = "요정도감";
            this.FairyDic.UseVisualStyleBackColor = true;
            // 
            // FairyInfoGroup
            // 
            this.FairyInfoGroup.Controls.Add(this.FairySkillInfoGroup);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyACCountLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyEVCountLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyAMCountLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyCRCountLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyFRCountLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyCRProgress);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyAMProgress);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyEVProgress);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyACProgress);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyFRProgress);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyCRLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyAMLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyEVLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyACLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyFRLabel);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyName);
            this.FairyInfoGroup.Controls.Add(this.FairyDicFairyImage);
            this.FairyInfoGroup.Location = new System.Drawing.Point(6, 3);
            this.FairyInfoGroup.Name = "FairyInfoGroup";
            this.FairyInfoGroup.Size = new System.Drawing.Size(847, 331);
            this.FairyInfoGroup.TabIndex = 2;
            this.FairyInfoGroup.TabStop = false;
            this.FairyInfoGroup.Text = "요정 정보";
            // 
            // FairySkillInfoGroup
            // 
            this.FairySkillInfoGroup.Controls.Add(this.FairyDicFairySkillExplain);
            this.FairySkillInfoGroup.Controls.Add(this.FairyDicFairySkillEffect);
            this.FairySkillInfoGroup.Controls.Add(this.FairyDicFairySkillName);
            this.FairySkillInfoGroup.Controls.Add(this.FairyDicFairySkillIcon);
            this.FairySkillInfoGroup.Location = new System.Drawing.Point(245, 17);
            this.FairySkillInfoGroup.Name = "FairySkillInfoGroup";
            this.FairySkillInfoGroup.Size = new System.Drawing.Size(422, 196);
            this.FairySkillInfoGroup.TabIndex = 33;
            this.FairySkillInfoGroup.TabStop = false;
            this.FairySkillInfoGroup.Text = "스킬 정보";
            // 
            // FairyDicFairySkillExplain
            // 
            this.FairyDicFairySkillExplain.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairySkillExplain.Location = new System.Drawing.Point(6, 98);
            this.FairyDicFairySkillExplain.Name = "FairyDicFairySkillExplain";
            this.FairyDicFairySkillExplain.Size = new System.Drawing.Size(410, 95);
            this.FairyDicFairySkillExplain.TabIndex = 24;
            this.FairyDicFairySkillExplain.Text = "     ";
            // 
            // FairyDicFairySkillEffect
            // 
            this.FairyDicFairySkillEffect.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairySkillEffect.Location = new System.Drawing.Point(76, 63);
            this.FairyDicFairySkillEffect.Name = "FairyDicFairySkillEffect";
            this.FairyDicFairySkillEffect.Size = new System.Drawing.Size(340, 21);
            this.FairyDicFairySkillEffect.TabIndex = 23;
            this.FairyDicFairySkillEffect.Text = "     ";
            this.FairyDicFairySkillEffect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FairyDicFairySkillName
            // 
            this.FairyDicFairySkillName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairySkillName.Location = new System.Drawing.Point(76, 20);
            this.FairyDicFairySkillName.Name = "FairyDicFairySkillName";
            this.FairyDicFairySkillName.Size = new System.Drawing.Size(340, 32);
            this.FairyDicFairySkillName.TabIndex = 22;
            this.FairyDicFairySkillName.Text = "   ";
            this.FairyDicFairySkillName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FairyDicFairySkillIcon
            // 
            this.FairyDicFairySkillIcon.Location = new System.Drawing.Point(6, 20);
            this.FairyDicFairySkillIcon.Name = "FairyDicFairySkillIcon";
            this.FairyDicFairySkillIcon.Size = new System.Drawing.Size(64, 64);
            this.FairyDicFairySkillIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FairyDicFairySkillIcon.TabIndex = 0;
            this.FairyDicFairySkillIcon.TabStop = false;
            // 
            // FairyDicFairyACCountLabel
            // 
            this.FairyDicFairyACCountLabel.AutoSize = true;
            this.FairyDicFairyACCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyACCountLabel.Location = new System.Drawing.Point(448, 240);
            this.FairyDicFairyACCountLabel.Name = "FairyDicFairyACCountLabel";
            this.FairyDicFairyACCountLabel.Size = new System.Drawing.Size(21, 20);
            this.FairyDicFairyACCountLabel.TabIndex = 32;
            this.FairyDicFairyACCountLabel.Text = "   ";
            // 
            // FairyDicFairyEVCountLabel
            // 
            this.FairyDicFairyEVCountLabel.AutoSize = true;
            this.FairyDicFairyEVCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyEVCountLabel.Location = new System.Drawing.Point(448, 262);
            this.FairyDicFairyEVCountLabel.Name = "FairyDicFairyEVCountLabel";
            this.FairyDicFairyEVCountLabel.Size = new System.Drawing.Size(21, 20);
            this.FairyDicFairyEVCountLabel.TabIndex = 31;
            this.FairyDicFairyEVCountLabel.Text = "   ";
            // 
            // FairyDicFairyAMCountLabel
            // 
            this.FairyDicFairyAMCountLabel.AutoSize = true;
            this.FairyDicFairyAMCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyAMCountLabel.Location = new System.Drawing.Point(448, 284);
            this.FairyDicFairyAMCountLabel.Name = "FairyDicFairyAMCountLabel";
            this.FairyDicFairyAMCountLabel.Size = new System.Drawing.Size(21, 20);
            this.FairyDicFairyAMCountLabel.TabIndex = 30;
            this.FairyDicFairyAMCountLabel.Text = "   ";
            // 
            // FairyDicFairyCRCountLabel
            // 
            this.FairyDicFairyCRCountLabel.AutoSize = true;
            this.FairyDicFairyCRCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyCRCountLabel.Location = new System.Drawing.Point(448, 305);
            this.FairyDicFairyCRCountLabel.Name = "FairyDicFairyCRCountLabel";
            this.FairyDicFairyCRCountLabel.Size = new System.Drawing.Size(17, 20);
            this.FairyDicFairyCRCountLabel.TabIndex = 29;
            this.FairyDicFairyCRCountLabel.Text = "  ";
            // 
            // FairyDicFairyFRCountLabel
            // 
            this.FairyDicFairyFRCountLabel.AutoSize = true;
            this.FairyDicFairyFRCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyFRCountLabel.Location = new System.Drawing.Point(448, 219);
            this.FairyDicFairyFRCountLabel.Name = "FairyDicFairyFRCountLabel";
            this.FairyDicFairyFRCountLabel.Size = new System.Drawing.Size(21, 20);
            this.FairyDicFairyFRCountLabel.TabIndex = 28;
            this.FairyDicFairyFRCountLabel.Text = "   ";
            // 
            // FairyDicFairyCRProgress
            // 
            this.FairyDicFairyCRProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FairyDicFairyCRProgress.ForeColor = System.Drawing.Color.DarkBlue;
            this.FairyDicFairyCRProgress.Location = new System.Drawing.Point(312, 305);
            this.FairyDicFairyCRProgress.Name = "FairyDicFairyCRProgress";
            this.FairyDicFairyCRProgress.Size = new System.Drawing.Size(123, 12);
            this.FairyDicFairyCRProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FairyDicFairyCRProgress.TabIndex = 27;
            // 
            // FairyDicFairyAMProgress
            // 
            this.FairyDicFairyAMProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FairyDicFairyAMProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FairyDicFairyAMProgress.Location = new System.Drawing.Point(312, 284);
            this.FairyDicFairyAMProgress.Name = "FairyDicFairyAMProgress";
            this.FairyDicFairyAMProgress.Size = new System.Drawing.Size(123, 12);
            this.FairyDicFairyAMProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FairyDicFairyAMProgress.TabIndex = 26;
            // 
            // FairyDicFairyEVProgress
            // 
            this.FairyDicFairyEVProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FairyDicFairyEVProgress.ForeColor = System.Drawing.Color.LightGreen;
            this.FairyDicFairyEVProgress.Location = new System.Drawing.Point(312, 262);
            this.FairyDicFairyEVProgress.Name = "FairyDicFairyEVProgress";
            this.FairyDicFairyEVProgress.Size = new System.Drawing.Size(123, 12);
            this.FairyDicFairyEVProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FairyDicFairyEVProgress.TabIndex = 25;
            // 
            // FairyDicFairyACProgress
            // 
            this.FairyDicFairyACProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FairyDicFairyACProgress.ForeColor = System.Drawing.Color.Crimson;
            this.FairyDicFairyACProgress.Location = new System.Drawing.Point(312, 240);
            this.FairyDicFairyACProgress.Name = "FairyDicFairyACProgress";
            this.FairyDicFairyACProgress.Size = new System.Drawing.Size(123, 12);
            this.FairyDicFairyACProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FairyDicFairyACProgress.TabIndex = 24;
            // 
            // FairyDicFairyFRProgress
            // 
            this.FairyDicFairyFRProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FairyDicFairyFRProgress.ForeColor = System.Drawing.Color.Red;
            this.FairyDicFairyFRProgress.Location = new System.Drawing.Point(312, 219);
            this.FairyDicFairyFRProgress.Name = "FairyDicFairyFRProgress";
            this.FairyDicFairyFRProgress.Size = new System.Drawing.Size(123, 12);
            this.FairyDicFairyFRProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FairyDicFairyFRProgress.TabIndex = 23;
            // 
            // FairyDicFairyCRLabel
            // 
            this.FairyDicFairyCRLabel.AutoSize = true;
            this.FairyDicFairyCRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyCRLabel.Location = new System.Drawing.Point(249, 305);
            this.FairyDicFairyCRLabel.Name = "FairyDicFairyCRLabel";
            this.FairyDicFairyCRLabel.Size = new System.Drawing.Size(45, 20);
            this.FairyDicFairyCRLabel.TabIndex = 22;
            this.FairyDicFairyCRLabel.Text = "치명타";
            // 
            // FairyDicFairyAMLabel
            // 
            this.FairyDicFairyAMLabel.AutoSize = true;
            this.FairyDicFairyAMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyAMLabel.Location = new System.Drawing.Point(249, 284);
            this.FairyDicFairyAMLabel.Name = "FairyDicFairyAMLabel";
            this.FairyDicFairyAMLabel.Size = new System.Drawing.Size(33, 20);
            this.FairyDicFairyAMLabel.TabIndex = 21;
            this.FairyDicFairyAMLabel.Text = "장갑";
            // 
            // FairyDicFairyEVLabel
            // 
            this.FairyDicFairyEVLabel.AutoSize = true;
            this.FairyDicFairyEVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyEVLabel.Location = new System.Drawing.Point(249, 262);
            this.FairyDicFairyEVLabel.Name = "FairyDicFairyEVLabel";
            this.FairyDicFairyEVLabel.Size = new System.Drawing.Size(33, 20);
            this.FairyDicFairyEVLabel.TabIndex = 20;
            this.FairyDicFairyEVLabel.Text = "회피";
            // 
            // FairyDicFairyACLabel
            // 
            this.FairyDicFairyACLabel.AutoSize = true;
            this.FairyDicFairyACLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyACLabel.Location = new System.Drawing.Point(249, 240);
            this.FairyDicFairyACLabel.Name = "FairyDicFairyACLabel";
            this.FairyDicFairyACLabel.Size = new System.Drawing.Size(33, 20);
            this.FairyDicFairyACLabel.TabIndex = 19;
            this.FairyDicFairyACLabel.Text = "명중";
            // 
            // FairyDicFairyFRLabel
            // 
            this.FairyDicFairyFRLabel.AutoSize = true;
            this.FairyDicFairyFRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyFRLabel.Location = new System.Drawing.Point(250, 219);
            this.FairyDicFairyFRLabel.Name = "FairyDicFairyFRLabel";
            this.FairyDicFairyFRLabel.Size = new System.Drawing.Size(33, 20);
            this.FairyDicFairyFRLabel.TabIndex = 18;
            this.FairyDicFairyFRLabel.Text = "화력";
            // 
            // FairyDicFairyName
            // 
            this.FairyDicFairyName.BackColor = System.Drawing.Color.Beige;
            this.FairyDicFairyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FairyDicFairyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FairyDicFairyName.Location = new System.Drawing.Point(6, 17);
            this.FairyDicFairyName.Name = "FairyDicFairyName";
            this.FairyDicFairyName.Size = new System.Drawing.Size(230, 35);
            this.FairyDicFairyName.TabIndex = 4;
            this.FairyDicFairyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FairyDicFairyImage
            // 
            this.FairyDicFairyImage.Location = new System.Drawing.Point(6, 55);
            this.FairyDicFairyImage.Name = "FairyDicFairyImage";
            this.FairyDicFairyImage.Size = new System.Drawing.Size(230, 230);
            this.FairyDicFairyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FairyDicFairyImage.TabIndex = 0;
            this.FairyDicFairyImage.TabStop = false;
            this.FairyDicFairyImage.Click += new System.EventHandler(this.FairyDicFairyImage_Click);
            // 
            // FairySearchGroup
            // 
            this.FairySearchGroup.Controls.Add(this.label74);
            this.FairySearchGroup.Controls.Add(this.FairyDicFairyDetailInfoWeb);
            this.FairySearchGroup.Controls.Add(this.FairyProductTimeTableButton);
            this.FairySearchGroup.Controls.Add(this.groupBox9);
            this.FairySearchGroup.Controls.Add(this.FairyDicSearchTextBox);
            this.FairySearchGroup.Location = new System.Drawing.Point(334, 337);
            this.FairySearchGroup.Name = "FairySearchGroup";
            this.FairySearchGroup.Size = new System.Drawing.Size(519, 207);
            this.FairySearchGroup.TabIndex = 1;
            this.FairySearchGroup.TabStop = false;
            this.FairySearchGroup.Text = "요정 검색";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(15, 22);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(77, 12);
            this.label74.TabIndex = 35;
            this.label74.Text = "검색할 요정 :";
            // 
            // FairyDicFairyDetailInfoWeb
            // 
            this.FairyDicFairyDetailInfoWeb.AutoSize = true;
            this.FairyDicFairyDetailInfoWeb.Location = new System.Drawing.Point(280, 189);
            this.FairyDicFairyDetailInfoWeb.Name = "FairyDicFairyDetailInfoWeb";
            this.FairyDicFairyDetailInfoWeb.Size = new System.Drawing.Size(197, 12);
            this.FairyDicFairyDetailInfoWeb.TabIndex = 34;
            this.FairyDicFairyDetailInfoWeb.TabStop = true;
            this.FairyDicFairyDetailInfoWeb.Text = "해당 요정의 더 많은 정보 보러 가기";
            this.FairyDicFairyDetailInfoWeb.Visible = false;
            this.FairyDicFairyDetailInfoWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FairyDicFairyDetailInfoWeb_LinkClicked);
            // 
            // FairyProductTimeTableButton
            // 
            this.FairyProductTimeTableButton.Location = new System.Drawing.Point(6, 171);
            this.FairyProductTimeTableButton.Name = "FairyProductTimeTableButton";
            this.FairyProductTimeTableButton.Size = new System.Drawing.Size(268, 30);
            this.FairyProductTimeTableButton.TabIndex = 17;
            this.FairyProductTimeTableButton.Text = "제조 시간표 열람";
            this.FairyProductTimeTableButton.UseVisualStyleBackColor = true;
            this.FairyProductTimeTableButton.Click += new System.EventHandler(this.FairyProductTimeTableButton_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.FairyDicTypeCombat);
            this.groupBox9.Controls.Add(this.FairyDicTypeStrategy);
            this.groupBox9.Location = new System.Drawing.Point(6, 44);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(112, 43);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "분류";
            // 
            // FairyDicTypeCombat
            // 
            this.FairyDicTypeCombat.AutoSize = true;
            this.FairyDicTypeCombat.Checked = true;
            this.FairyDicTypeCombat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FairyDicTypeCombat.Location = new System.Drawing.Point(9, 17);
            this.FairyDicTypeCombat.Name = "FairyDicTypeCombat";
            this.FairyDicTypeCombat.Size = new System.Drawing.Size(48, 16);
            this.FairyDicTypeCombat.TabIndex = 3;
            this.FairyDicTypeCombat.Tag = "2";
            this.FairyDicTypeCombat.Text = "전투";
            this.FairyDicTypeCombat.UseVisualStyleBackColor = true;
            this.FairyDicTypeCombat.CheckedChanged += new System.EventHandler(this.FairyDicSearchSetting_CheckedChanged);
            // 
            // FairyDicTypeStrategy
            // 
            this.FairyDicTypeStrategy.AutoSize = true;
            this.FairyDicTypeStrategy.Checked = true;
            this.FairyDicTypeStrategy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FairyDicTypeStrategy.Location = new System.Drawing.Point(63, 17);
            this.FairyDicTypeStrategy.Name = "FairyDicTypeStrategy";
            this.FairyDicTypeStrategy.Size = new System.Drawing.Size(48, 16);
            this.FairyDicTypeStrategy.TabIndex = 1;
            this.FairyDicTypeStrategy.Tag = "2";
            this.FairyDicTypeStrategy.Text = "책략";
            this.FairyDicTypeStrategy.UseVisualStyleBackColor = true;
            this.FairyDicTypeStrategy.CheckedChanged += new System.EventHandler(this.FairyDicSearchSetting_CheckedChanged);
            // 
            // FairyDicSearchTextBox
            // 
            this.FairyDicSearchTextBox.Location = new System.Drawing.Point(98, 17);
            this.FairyDicSearchTextBox.Name = "FairyDicSearchTextBox";
            this.FairyDicSearchTextBox.Size = new System.Drawing.Size(415, 21);
            this.FairyDicSearchTextBox.TabIndex = 13;
            this.FairyDicSearchTextBox.TextChanged += new System.EventHandler(this.FairyDicSearchTextBox_TextChanged);
            // 
            // FairyListGroup
            // 
            this.FairyListGroup.Controls.Add(this.FairyDicFairyList);
            this.FairyListGroup.Location = new System.Drawing.Point(3, 340);
            this.FairyListGroup.Name = "FairyListGroup";
            this.FairyListGroup.Size = new System.Drawing.Size(322, 207);
            this.FairyListGroup.TabIndex = 0;
            this.FairyListGroup.TabStop = false;
            this.FairyListGroup.Text = "요정목록";
            // 
            // FairyDicFairyList
            // 
            this.FairyDicFairyList.AllowColumnReorder = true;
            this.FairyDicFairyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FairyName,
            this.FairyType,
            this.FairyProductTime});
            this.FairyDicFairyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FairyDicFairyList.FullRowSelect = true;
            this.FairyDicFairyList.GridLines = true;
            this.FairyDicFairyList.HideSelection = false;
            this.FairyDicFairyList.Location = new System.Drawing.Point(3, 17);
            this.FairyDicFairyList.Name = "FairyDicFairyList";
            this.FairyDicFairyList.Size = new System.Drawing.Size(316, 187);
            this.FairyDicFairyList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.FairyDicFairyList.TabIndex = 0;
            this.FairyDicFairyList.UseCompatibleStateImageBehavior = false;
            this.FairyDicFairyList.View = System.Windows.Forms.View.Details;
            this.FairyDicFairyList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            this.FairyDicFairyList.SelectedIndexChanged += new System.EventHandler(this.FairyDicFairyList_SelectedIndexChanged);
            // 
            // FairyName
            // 
            this.FairyName.Text = "이름";
            this.FairyName.Width = 90;
            // 
            // FairyType
            // 
            this.FairyType.Text = "타입";
            this.FairyType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FairyProductTime
            // 
            this.FairyProductTime.Tag = "Time";
            this.FairyProductTime.Text = "제조시간";
            this.FairyProductTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FairyProductTime.Width = 80;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.ProductSimulationSubTab);
            this.Product.Location = new System.Drawing.Point(4, 22);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(873, 579);
            this.Product.TabIndex = 1;
            this.Product.Text = "제조";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // ProductSimulationSubTab
            // 
            this.ProductSimulationSubTab.Controls.Add(this.ProductSimulDoll);
            this.ProductSimulationSubTab.Controls.Add(this.ProductSimulEquipment);
            this.ProductSimulationSubTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductSimulationSubTab.Location = new System.Drawing.Point(3, 3);
            this.ProductSimulationSubTab.Name = "ProductSimulationSubTab";
            this.ProductSimulationSubTab.SelectedIndex = 0;
            this.ProductSimulationSubTab.Size = new System.Drawing.Size(867, 573);
            this.ProductSimulationSubTab.TabIndex = 0;
            // 
            // ProductSimulDoll
            // 
            this.ProductSimulDoll.Controls.Add(this.pictureBox4);
            this.ProductSimulDoll.Controls.Add(this.pictureBox3);
            this.ProductSimulDoll.Controls.Add(this.pictureBox2);
            this.ProductSimulDoll.Controls.Add(this.pictureBox1);
            this.ProductSimulDoll.Controls.Add(this.tableLayoutPanel4);
            this.ProductSimulDoll.Controls.Add(this.DollSimulationResetUseButton);
            this.ProductSimulDoll.Controls.Add(this.tableLayoutPanel3);
            this.ProductSimulDoll.Controls.Add(this.ProductSimulDollAdvanceProductTypeGroup);
            this.ProductSimulDoll.Controls.Add(this.ProductSimulDollProductTypeGroup);
            this.ProductSimulDoll.Controls.Add(this.ProductSimulDollVoiceEnableSetting);
            this.ProductSimulDoll.Controls.Add(this.ProductDollResultBackgroundPanel);
            this.ProductSimulDoll.Controls.Add(this.ProductDollResultGradeStar5);
            this.ProductSimulDoll.Controls.Add(this.ProductDollResultGradeStar4);
            this.ProductSimulDoll.Controls.Add(this.ProductDollResultGradeStar3);
            this.ProductSimulDoll.Controls.Add(this.ProductDollResultGradeStar2);
            this.ProductSimulDoll.Controls.Add(this.ProductDollResultGradeStar1);
            this.ProductSimulDoll.Controls.Add(this.ProductSimulDollProductButton);
            this.ProductSimulDoll.Controls.Add(this.ProductSimulDollPartsCount);
            this.ProductSimulDoll.Controls.Add(this.ProductSimulDollAmmoCount);
            this.ProductSimulDoll.Controls.Add(this.ProductSimulDollFoodCount);
            this.ProductSimulDoll.Controls.Add(this.ProductSimulDollManpowerCount);
            this.ProductSimulDoll.Location = new System.Drawing.Point(4, 22);
            this.ProductSimulDoll.Name = "ProductSimulDoll";
            this.ProductSimulDoll.Padding = new System.Windows.Forms.Padding(3);
            this.ProductSimulDoll.Size = new System.Drawing.Size(859, 547);
            this.ProductSimulDoll.TabIndex = 0;
            this.ProductSimulDoll.Text = "인형제조";
            this.ProductSimulDoll.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Parts_Icon;
            this.pictureBox4.Location = new System.Drawing.Point(447, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Ammo_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(447, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Food_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(305, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Manpower_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(305, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.DollSimulation5StarStatus, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label50, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.DollSimulation4StarStatus, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label65, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.DollSimulation3StarStatus, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label68, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.DollSimulation2StarStatus, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label70, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 246);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(106, 248);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // DollSimulation5StarStatus
            // 
            this.DollSimulation5StarStatus.BackColor = System.Drawing.Color.Thistle;
            this.DollSimulation5StarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DollSimulation5StarStatus.Location = new System.Drawing.Point(3, 217);
            this.DollSimulation5StarStatus.Name = "DollSimulation5StarStatus";
            this.DollSimulation5StarStatus.Size = new System.Drawing.Size(100, 31);
            this.DollSimulation5StarStatus.TabIndex = 7;
            this.DollSimulation5StarStatus.Text = "0";
            this.DollSimulation5StarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.Thistle;
            this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label50.Location = new System.Drawing.Point(3, 186);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(100, 31);
            this.label50.TabIndex = 6;
            this.label50.Text = "☆☆☆☆☆";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollSimulation4StarStatus
            // 
            this.DollSimulation4StarStatus.BackColor = System.Drawing.Color.SeaShell;
            this.DollSimulation4StarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DollSimulation4StarStatus.Location = new System.Drawing.Point(3, 155);
            this.DollSimulation4StarStatus.Name = "DollSimulation4StarStatus";
            this.DollSimulation4StarStatus.Size = new System.Drawing.Size(100, 31);
            this.DollSimulation4StarStatus.TabIndex = 5;
            this.DollSimulation4StarStatus.Text = "0";
            this.DollSimulation4StarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            this.label65.BackColor = System.Drawing.Color.SeaShell;
            this.label65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label65.Location = new System.Drawing.Point(3, 124);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(100, 31);
            this.label65.TabIndex = 4;
            this.label65.Text = "☆☆☆☆";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollSimulation3StarStatus
            // 
            this.DollSimulation3StarStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.DollSimulation3StarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DollSimulation3StarStatus.Location = new System.Drawing.Point(3, 93);
            this.DollSimulation3StarStatus.Name = "DollSimulation3StarStatus";
            this.DollSimulation3StarStatus.Size = new System.Drawing.Size(100, 31);
            this.DollSimulation3StarStatus.TabIndex = 3;
            this.DollSimulation3StarStatus.Text = "0";
            this.DollSimulation3StarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.BackColor = System.Drawing.Color.Gainsboro;
            this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label68.Location = new System.Drawing.Point(3, 62);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(100, 31);
            this.label68.TabIndex = 2;
            this.label68.Text = "☆☆☆";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollSimulation2StarStatus
            // 
            this.DollSimulation2StarStatus.BackColor = System.Drawing.Color.LightCyan;
            this.DollSimulation2StarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DollSimulation2StarStatus.Location = new System.Drawing.Point(3, 31);
            this.DollSimulation2StarStatus.Name = "DollSimulation2StarStatus";
            this.DollSimulation2StarStatus.Size = new System.Drawing.Size(100, 31);
            this.DollSimulation2StarStatus.TabIndex = 1;
            this.DollSimulation2StarStatus.Text = "0";
            this.DollSimulation2StarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.BackColor = System.Drawing.Color.LightCyan;
            this.label70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label70.Location = new System.Drawing.Point(3, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(100, 31);
            this.label70.TabIndex = 0;
            this.label70.Text = "☆☆";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollSimulationResetUseButton
            // 
            this.DollSimulationResetUseButton.Location = new System.Drawing.Point(726, 101);
            this.DollSimulationResetUseButton.Name = "DollSimulationResetUseButton";
            this.DollSimulationResetUseButton.Size = new System.Drawing.Size(124, 23);
            this.DollSimulationResetUseButton.TabIndex = 23;
            this.DollSimulationResetUseButton.Text = "기록 초기화";
            this.DollSimulationResetUseButton.UseVisualStyleBackColor = true;
            this.DollSimulationResetUseButton.Click += new System.EventHandler(this.DollSimulationResetUseButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.DollSimulationUseParts, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label64, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.DollSimulationUseFood, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label62, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.DollSimulationUseAmmo, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label38, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.DollSimulationUseManPower, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(729, 246);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(124, 248);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // DollSimulationUseParts
            // 
            this.DollSimulationUseParts.BackColor = System.Drawing.Color.Thistle;
            this.DollSimulationUseParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DollSimulationUseParts.Location = new System.Drawing.Point(3, 217);
            this.DollSimulationUseParts.Name = "DollSimulationUseParts";
            this.DollSimulationUseParts.Size = new System.Drawing.Size(118, 31);
            this.DollSimulationUseParts.TabIndex = 7;
            this.DollSimulationUseParts.Text = "0";
            this.DollSimulationUseParts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.BackColor = System.Drawing.Color.Thistle;
            this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label64.Location = new System.Drawing.Point(3, 186);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(118, 31);
            this.label64.TabIndex = 6;
            this.label64.Text = "부품";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollSimulationUseFood
            // 
            this.DollSimulationUseFood.BackColor = System.Drawing.Color.SeaShell;
            this.DollSimulationUseFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DollSimulationUseFood.Location = new System.Drawing.Point(3, 155);
            this.DollSimulationUseFood.Name = "DollSimulationUseFood";
            this.DollSimulationUseFood.Size = new System.Drawing.Size(118, 31);
            this.DollSimulationUseFood.TabIndex = 5;
            this.DollSimulationUseFood.Text = "0";
            this.DollSimulationUseFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.BackColor = System.Drawing.Color.SeaShell;
            this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label62.Location = new System.Drawing.Point(3, 124);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(118, 31);
            this.label62.TabIndex = 4;
            this.label62.Text = "식량";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollSimulationUseAmmo
            // 
            this.DollSimulationUseAmmo.BackColor = System.Drawing.Color.Gainsboro;
            this.DollSimulationUseAmmo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DollSimulationUseAmmo.Location = new System.Drawing.Point(3, 93);
            this.DollSimulationUseAmmo.Name = "DollSimulationUseAmmo";
            this.DollSimulationUseAmmo.Size = new System.Drawing.Size(118, 31);
            this.DollSimulationUseAmmo.TabIndex = 3;
            this.DollSimulationUseAmmo.Text = "0";
            this.DollSimulationUseAmmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Gainsboro;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Location = new System.Drawing.Point(3, 62);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(118, 31);
            this.label38.TabIndex = 2;
            this.label38.Text = "탄약";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollSimulationUseManPower
            // 
            this.DollSimulationUseManPower.BackColor = System.Drawing.Color.LightCyan;
            this.DollSimulationUseManPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DollSimulationUseManPower.Location = new System.Drawing.Point(3, 31);
            this.DollSimulationUseManPower.Name = "DollSimulationUseManPower";
            this.DollSimulationUseManPower.Size = new System.Drawing.Size(118, 31);
            this.DollSimulationUseManPower.TabIndex = 1;
            this.DollSimulationUseManPower.Text = "0";
            this.DollSimulationUseManPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.LightCyan;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Location = new System.Drawing.Point(3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(118, 31);
            this.label36.TabIndex = 0;
            this.label36.Text = "인력";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductSimulDollAdvanceProductTypeGroup
            // 
            this.ProductSimulDollAdvanceProductTypeGroup.Controls.Add(this.ProductSimulDollAdvanceProductType3);
            this.ProductSimulDollAdvanceProductTypeGroup.Controls.Add(this.ProductSimulDollAdvanceProductType2);
            this.ProductSimulDollAdvanceProductTypeGroup.Controls.Add(this.ProductSimulDollAdvanceProductType1);
            this.ProductSimulDollAdvanceProductTypeGroup.Location = new System.Drawing.Point(118, 24);
            this.ProductSimulDollAdvanceProductTypeGroup.Name = "ProductSimulDollAdvanceProductTypeGroup";
            this.ProductSimulDollAdvanceProductTypeGroup.Size = new System.Drawing.Size(81, 90);
            this.ProductSimulDollAdvanceProductTypeGroup.TabIndex = 21;
            this.ProductSimulDollAdvanceProductTypeGroup.TabStop = false;
            this.ProductSimulDollAdvanceProductTypeGroup.Text = "중형 타입";
            this.ProductSimulDollAdvanceProductTypeGroup.Visible = false;
            // 
            // ProductSimulDollAdvanceProductType3
            // 
            this.ProductSimulDollAdvanceProductType3.AutoSize = true;
            this.ProductSimulDollAdvanceProductType3.Location = new System.Drawing.Point(6, 63);
            this.ProductSimulDollAdvanceProductType3.Name = "ProductSimulDollAdvanceProductType3";
            this.ProductSimulDollAdvanceProductType3.Size = new System.Drawing.Size(41, 16);
            this.ProductSimulDollAdvanceProductType3.TabIndex = 2;
            this.ProductSimulDollAdvanceProductType3.Tag = "3";
            this.ProductSimulDollAdvanceProductType3.Text = "3형";
            this.ProductSimulDollAdvanceProductType3.UseVisualStyleBackColor = true;
            this.ProductSimulDollAdvanceProductType3.CheckedChanged += new System.EventHandler(this.ProductSimulDollAdvanceProductType_CheckedChanged);
            // 
            // ProductSimulDollAdvanceProductType2
            // 
            this.ProductSimulDollAdvanceProductType2.AutoSize = true;
            this.ProductSimulDollAdvanceProductType2.Location = new System.Drawing.Point(7, 43);
            this.ProductSimulDollAdvanceProductType2.Name = "ProductSimulDollAdvanceProductType2";
            this.ProductSimulDollAdvanceProductType2.Size = new System.Drawing.Size(41, 16);
            this.ProductSimulDollAdvanceProductType2.TabIndex = 1;
            this.ProductSimulDollAdvanceProductType2.Tag = "2";
            this.ProductSimulDollAdvanceProductType2.Text = "2형";
            this.ProductSimulDollAdvanceProductType2.UseVisualStyleBackColor = true;
            this.ProductSimulDollAdvanceProductType2.CheckedChanged += new System.EventHandler(this.ProductSimulDollAdvanceProductType_CheckedChanged);
            // 
            // ProductSimulDollAdvanceProductType1
            // 
            this.ProductSimulDollAdvanceProductType1.AutoSize = true;
            this.ProductSimulDollAdvanceProductType1.Checked = true;
            this.ProductSimulDollAdvanceProductType1.Location = new System.Drawing.Point(7, 21);
            this.ProductSimulDollAdvanceProductType1.Name = "ProductSimulDollAdvanceProductType1";
            this.ProductSimulDollAdvanceProductType1.Size = new System.Drawing.Size(41, 16);
            this.ProductSimulDollAdvanceProductType1.TabIndex = 0;
            this.ProductSimulDollAdvanceProductType1.TabStop = true;
            this.ProductSimulDollAdvanceProductType1.Tag = "1";
            this.ProductSimulDollAdvanceProductType1.Text = "1형";
            this.ProductSimulDollAdvanceProductType1.UseVisualStyleBackColor = true;
            this.ProductSimulDollAdvanceProductType1.CheckedChanged += new System.EventHandler(this.ProductSimulDollAdvanceProductType_CheckedChanged);
            // 
            // ProductSimulDollProductTypeGroup
            // 
            this.ProductSimulDollProductTypeGroup.Controls.Add(this.ProductSimulDollProductTypeAdvance);
            this.ProductSimulDollProductTypeGroup.Controls.Add(this.ProductSimulDollProductTypeNormal);
            this.ProductSimulDollProductTypeGroup.Location = new System.Drawing.Point(32, 24);
            this.ProductSimulDollProductTypeGroup.Name = "ProductSimulDollProductTypeGroup";
            this.ProductSimulDollProductTypeGroup.Size = new System.Drawing.Size(77, 71);
            this.ProductSimulDollProductTypeGroup.TabIndex = 20;
            this.ProductSimulDollProductTypeGroup.TabStop = false;
            this.ProductSimulDollProductTypeGroup.Text = "제조 타입";
            // 
            // ProductSimulDollProductTypeAdvance
            // 
            this.ProductSimulDollProductTypeAdvance.AutoSize = true;
            this.ProductSimulDollProductTypeAdvance.Location = new System.Drawing.Point(7, 43);
            this.ProductSimulDollProductTypeAdvance.Name = "ProductSimulDollProductTypeAdvance";
            this.ProductSimulDollProductTypeAdvance.Size = new System.Drawing.Size(47, 16);
            this.ProductSimulDollProductTypeAdvance.TabIndex = 1;
            this.ProductSimulDollProductTypeAdvance.Tag = "Advance";
            this.ProductSimulDollProductTypeAdvance.Text = "중형";
            this.ProductSimulDollProductTypeAdvance.UseVisualStyleBackColor = true;
            this.ProductSimulDollProductTypeAdvance.CheckedChanged += new System.EventHandler(this.ProductSimulDollProductType_CheckedChanged);
            // 
            // ProductSimulDollProductTypeNormal
            // 
            this.ProductSimulDollProductTypeNormal.AutoSize = true;
            this.ProductSimulDollProductTypeNormal.Checked = true;
            this.ProductSimulDollProductTypeNormal.Location = new System.Drawing.Point(7, 21);
            this.ProductSimulDollProductTypeNormal.Name = "ProductSimulDollProductTypeNormal";
            this.ProductSimulDollProductTypeNormal.Size = new System.Drawing.Size(47, 16);
            this.ProductSimulDollProductTypeNormal.TabIndex = 0;
            this.ProductSimulDollProductTypeNormal.TabStop = true;
            this.ProductSimulDollProductTypeNormal.Tag = "Normal";
            this.ProductSimulDollProductTypeNormal.Text = "일반";
            this.ProductSimulDollProductTypeNormal.UseVisualStyleBackColor = true;
            this.ProductSimulDollProductTypeNormal.CheckedChanged += new System.EventHandler(this.ProductSimulDollProductType_CheckedChanged);
            // 
            // ProductSimulDollVoiceEnableSetting
            // 
            this.ProductSimulDollVoiceEnableSetting.AutoSize = true;
            this.ProductSimulDollVoiceEnableSetting.Checked = true;
            this.ProductSimulDollVoiceEnableSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProductSimulDollVoiceEnableSetting.Location = new System.Drawing.Point(556, 130);
            this.ProductSimulDollVoiceEnableSetting.Name = "ProductSimulDollVoiceEnableSetting";
            this.ProductSimulDollVoiceEnableSetting.Size = new System.Drawing.Size(100, 16);
            this.ProductSimulDollVoiceEnableSetting.TabIndex = 19;
            this.ProductSimulDollVoiceEnableSetting.Text = "보이스 활성화";
            this.ProductSimulDollVoiceEnableSetting.UseVisualStyleBackColor = true;
            // 
            // ProductDollResultBackgroundPanel
            // 
            this.ProductDollResultBackgroundPanel.Controls.Add(this.ProductDollResultDollGradeImageBox);
            this.ProductDollResultBackgroundPanel.Controls.Add(this.ProductDollResultDollTypeIcon);
            this.ProductDollResultBackgroundPanel.Controls.Add(this.ProductDollResultDollDialog);
            this.ProductDollResultBackgroundPanel.Controls.Add(this.ProductDollResultDollImageBox);
            this.ProductDollResultBackgroundPanel.Location = new System.Drawing.Point(118, 177);
            this.ProductDollResultBackgroundPanel.Name = "ProductDollResultBackgroundPanel";
            this.ProductDollResultBackgroundPanel.Size = new System.Drawing.Size(600, 352);
            this.ProductDollResultBackgroundPanel.TabIndex = 18;
            // 
            // ProductDollResultDollGradeImageBox
            // 
            this.ProductDollResultDollGradeImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProductDollResultDollGradeImageBox.Location = new System.Drawing.Point(398, 26);
            this.ProductDollResultDollGradeImageBox.Name = "ProductDollResultDollGradeImageBox";
            this.ProductDollResultDollGradeImageBox.Size = new System.Drawing.Size(169, 156);
            this.ProductDollResultDollGradeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductDollResultDollGradeImageBox.TabIndex = 18;
            this.ProductDollResultDollGradeImageBox.TabStop = false;
            this.ProductDollResultDollGradeImageBox.Visible = false;
            // 
            // ProductDollResultDollTypeIcon
            // 
            this.ProductDollResultDollTypeIcon.Location = new System.Drawing.Point(17, 104);
            this.ProductDollResultDollTypeIcon.Name = "ProductDollResultDollTypeIcon";
            this.ProductDollResultDollTypeIcon.Size = new System.Drawing.Size(80, 40);
            this.ProductDollResultDollTypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductDollResultDollTypeIcon.TabIndex = 14;
            this.ProductDollResultDollTypeIcon.TabStop = false;
            this.ProductDollResultDollTypeIcon.Visible = false;
            // 
            // ProductDollResultDollDialog
            // 
            this.ProductDollResultDollDialog.BackgroundImage = global::Girls_FrontierLine_Supporter.Properties.Resources.dial;
            this.ProductDollResultDollDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductDollResultDollDialog.Controls.Add(this.ProductDollResultDollName);
            this.ProductDollResultDollDialog.Location = new System.Drawing.Point(44, 277);
            this.ProductDollResultDollDialog.Name = "ProductDollResultDollDialog";
            this.ProductDollResultDollDialog.Size = new System.Drawing.Size(506, 72);
            this.ProductDollResultDollDialog.TabIndex = 17;
            this.ProductDollResultDollDialog.Visible = false;
            // 
            // ProductDollResultDollName
            // 
            this.ProductDollResultDollName.BackColor = System.Drawing.Color.Transparent;
            this.ProductDollResultDollName.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductDollResultDollName.ForeColor = System.Drawing.Color.White;
            this.ProductDollResultDollName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductDollResultDollName.Location = new System.Drawing.Point(8, 6);
            this.ProductDollResultDollName.Name = "ProductDollResultDollName";
            this.ProductDollResultDollName.Size = new System.Drawing.Size(152, 19);
            this.ProductDollResultDollName.TabIndex = 16;
            this.ProductDollResultDollName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductDollResultDollName.Visible = false;
            // 
            // ProductDollResultDollImageBox
            // 
            this.ProductDollResultDollImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductDollResultDollImageBox.Location = new System.Drawing.Point(116, 26);
            this.ProductDollResultDollImageBox.Name = "ProductDollResultDollImageBox";
            this.ProductDollResultDollImageBox.Size = new System.Drawing.Size(190, 245);
            this.ProductDollResultDollImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductDollResultDollImageBox.TabIndex = 15;
            this.ProductDollResultDollImageBox.TabStop = false;
            this.ProductDollResultDollImageBox.Visible = false;
            // 
            // ProductDollResultGradeStar5
            // 
            this.ProductDollResultGradeStar5.Location = new System.Drawing.Point(466, 141);
            this.ProductDollResultGradeStar5.Name = "ProductDollResultGradeStar5";
            this.ProductDollResultGradeStar5.Size = new System.Drawing.Size(30, 30);
            this.ProductDollResultGradeStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductDollResultGradeStar5.TabIndex = 13;
            this.ProductDollResultGradeStar5.TabStop = false;
            this.ProductDollResultGradeStar5.Visible = false;
            // 
            // ProductDollResultGradeStar4
            // 
            this.ProductDollResultGradeStar4.Location = new System.Drawing.Point(430, 141);
            this.ProductDollResultGradeStar4.Name = "ProductDollResultGradeStar4";
            this.ProductDollResultGradeStar4.Size = new System.Drawing.Size(30, 30);
            this.ProductDollResultGradeStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductDollResultGradeStar4.TabIndex = 12;
            this.ProductDollResultGradeStar4.TabStop = false;
            this.ProductDollResultGradeStar4.Visible = false;
            // 
            // ProductDollResultGradeStar3
            // 
            this.ProductDollResultGradeStar3.Location = new System.Drawing.Point(394, 141);
            this.ProductDollResultGradeStar3.Name = "ProductDollResultGradeStar3";
            this.ProductDollResultGradeStar3.Size = new System.Drawing.Size(30, 30);
            this.ProductDollResultGradeStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductDollResultGradeStar3.TabIndex = 11;
            this.ProductDollResultGradeStar3.TabStop = false;
            this.ProductDollResultGradeStar3.Visible = false;
            // 
            // ProductDollResultGradeStar2
            // 
            this.ProductDollResultGradeStar2.Location = new System.Drawing.Point(358, 141);
            this.ProductDollResultGradeStar2.Name = "ProductDollResultGradeStar2";
            this.ProductDollResultGradeStar2.Size = new System.Drawing.Size(30, 30);
            this.ProductDollResultGradeStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductDollResultGradeStar2.TabIndex = 10;
            this.ProductDollResultGradeStar2.TabStop = false;
            this.ProductDollResultGradeStar2.Visible = false;
            // 
            // ProductDollResultGradeStar1
            // 
            this.ProductDollResultGradeStar1.Location = new System.Drawing.Point(322, 141);
            this.ProductDollResultGradeStar1.Name = "ProductDollResultGradeStar1";
            this.ProductDollResultGradeStar1.Size = new System.Drawing.Size(30, 30);
            this.ProductDollResultGradeStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductDollResultGradeStar1.TabIndex = 9;
            this.ProductDollResultGradeStar1.TabStop = false;
            this.ProductDollResultGradeStar1.Visible = false;
            // 
            // ProductSimulDollProductButton
            // 
            this.ProductSimulDollProductButton.Location = new System.Drawing.Point(233, 87);
            this.ProductSimulDollProductButton.Name = "ProductSimulDollProductButton";
            this.ProductSimulDollProductButton.Size = new System.Drawing.Size(356, 37);
            this.ProductSimulDollProductButton.TabIndex = 8;
            this.ProductSimulDollProductButton.Text = "제조 시작";
            this.ProductSimulDollProductButton.UseVisualStyleBackColor = true;
            this.ProductSimulDollProductButton.Click += new System.EventHandler(this.ProductSimulDollProductButton_Click);
            // 
            // ProductSimulDollPartsCount
            // 
            this.ProductSimulDollPartsCount.Location = new System.Drawing.Point(480, 60);
            this.ProductSimulDollPartsCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ProductSimulDollPartsCount.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ProductSimulDollPartsCount.Name = "ProductSimulDollPartsCount";
            this.ProductSimulDollPartsCount.Size = new System.Drawing.Size(51, 21);
            this.ProductSimulDollPartsCount.TabIndex = 3;
            this.ProductSimulDollPartsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductSimulDollPartsCount.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ProductSimulDollAmmoCount
            // 
            this.ProductSimulDollAmmoCount.Location = new System.Drawing.Point(480, 22);
            this.ProductSimulDollAmmoCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ProductSimulDollAmmoCount.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ProductSimulDollAmmoCount.Name = "ProductSimulDollAmmoCount";
            this.ProductSimulDollAmmoCount.Size = new System.Drawing.Size(51, 21);
            this.ProductSimulDollAmmoCount.TabIndex = 2;
            this.ProductSimulDollAmmoCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductSimulDollAmmoCount.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ProductSimulDollFoodCount
            // 
            this.ProductSimulDollFoodCount.Location = new System.Drawing.Point(336, 60);
            this.ProductSimulDollFoodCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ProductSimulDollFoodCount.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ProductSimulDollFoodCount.Name = "ProductSimulDollFoodCount";
            this.ProductSimulDollFoodCount.Size = new System.Drawing.Size(52, 21);
            this.ProductSimulDollFoodCount.TabIndex = 1;
            this.ProductSimulDollFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductSimulDollFoodCount.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ProductSimulDollManpowerCount
            // 
            this.ProductSimulDollManpowerCount.Location = new System.Drawing.Point(336, 22);
            this.ProductSimulDollManpowerCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ProductSimulDollManpowerCount.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ProductSimulDollManpowerCount.Name = "ProductSimulDollManpowerCount";
            this.ProductSimulDollManpowerCount.Size = new System.Drawing.Size(52, 21);
            this.ProductSimulDollManpowerCount.TabIndex = 0;
            this.ProductSimulDollManpowerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductSimulDollManpowerCount.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ProductSimulEquipment
            // 
            this.ProductSimulEquipment.Controls.Add(this.pictureBox5);
            this.ProductSimulEquipment.Controls.Add(this.pictureBox6);
            this.ProductSimulEquipment.Controls.Add(this.pictureBox7);
            this.ProductSimulEquipment.Controls.Add(this.pictureBox8);
            this.ProductSimulEquipment.Controls.Add(this.tableLayoutPanel5);
            this.ProductSimulEquipment.Controls.Add(this.EquipmentSimulationResetUseButton);
            this.ProductSimulEquipment.Controls.Add(this.tableLayoutPanel6);
            this.ProductSimulEquipment.Controls.Add(this.ProductSimulEquipmentAdvanceProductTypeGroup);
            this.ProductSimulEquipment.Controls.Add(this.ProductSimulEquipmentProductTypeGroup);
            this.ProductSimulEquipment.Controls.Add(this.ProductEquipmentResultBackgroundPanel);
            this.ProductSimulEquipment.Controls.Add(this.ProductSimulEquipmentProductButton);
            this.ProductSimulEquipment.Controls.Add(this.ProductSimulEquipmentPartsCount);
            this.ProductSimulEquipment.Controls.Add(this.ProductSimulEquipmentAmmoCount);
            this.ProductSimulEquipment.Controls.Add(this.ProductSimulEquipmentFoodCount);
            this.ProductSimulEquipment.Controls.Add(this.ProductSimulEquipmentManpowerCount);
            this.ProductSimulEquipment.Controls.Add(this.ProductEquipmentResultGradeStar5);
            this.ProductSimulEquipment.Controls.Add(this.ProductEquipmentResultGradeStar4);
            this.ProductSimulEquipment.Controls.Add(this.ProductEquipmentResultGradeStar3);
            this.ProductSimulEquipment.Controls.Add(this.ProductEquipmentResultGradeStar2);
            this.ProductSimulEquipment.Controls.Add(this.ProductEquipmentResultGradeStar1);
            this.ProductSimulEquipment.Location = new System.Drawing.Point(4, 22);
            this.ProductSimulEquipment.Name = "ProductSimulEquipment";
            this.ProductSimulEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.ProductSimulEquipment.Size = new System.Drawing.Size(859, 547);
            this.ProductSimulEquipment.TabIndex = 1;
            this.ProductSimulEquipment.Text = "장비제조";
            this.ProductSimulEquipment.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Parts_Icon;
            this.pictureBox5.Location = new System.Drawing.Point(432, 55);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Ammo_Icon;
            this.pictureBox6.Location = new System.Drawing.Point(432, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 47;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Food_Icon;
            this.pictureBox7.Location = new System.Drawing.Point(290, 55);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 46;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.Manpower_Icon;
            this.pictureBox8.Location = new System.Drawing.Point(290, 16);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 45;
            this.pictureBox8.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label37, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.EquipmentSimulationFairyStatus, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.EquipmentSimulation5StarStatus, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.label63, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.EquipmentSimulation4StarStatus, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label69, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.EquipmentSimulation3StarStatus, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label72, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.EquipmentSimulation2StarStatus, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label75, 0, 0);
            this.tableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 201);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 10;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(106, 301);
            this.tableLayoutPanel5.TabIndex = 44;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.LightPink;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Location = new System.Drawing.Point(3, 240);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(100, 30);
            this.label37.TabIndex = 9;
            this.label37.Text = "요정";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentSimulationFairyStatus
            // 
            this.EquipmentSimulationFairyStatus.BackColor = System.Drawing.Color.LightPink;
            this.EquipmentSimulationFairyStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSimulationFairyStatus.Location = new System.Drawing.Point(3, 270);
            this.EquipmentSimulationFairyStatus.Name = "EquipmentSimulationFairyStatus";
            this.EquipmentSimulationFairyStatus.Size = new System.Drawing.Size(100, 31);
            this.EquipmentSimulationFairyStatus.TabIndex = 8;
            this.EquipmentSimulationFairyStatus.Text = "0";
            this.EquipmentSimulationFairyStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentSimulation5StarStatus
            // 
            this.EquipmentSimulation5StarStatus.BackColor = System.Drawing.Color.Thistle;
            this.EquipmentSimulation5StarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSimulation5StarStatus.Location = new System.Drawing.Point(3, 210);
            this.EquipmentSimulation5StarStatus.Name = "EquipmentSimulation5StarStatus";
            this.EquipmentSimulation5StarStatus.Size = new System.Drawing.Size(100, 30);
            this.EquipmentSimulation5StarStatus.TabIndex = 7;
            this.EquipmentSimulation5StarStatus.Text = "0";
            this.EquipmentSimulation5StarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Thistle;
            this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label63.Location = new System.Drawing.Point(3, 180);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(100, 30);
            this.label63.TabIndex = 6;
            this.label63.Text = "☆☆☆☆☆";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentSimulation4StarStatus
            // 
            this.EquipmentSimulation4StarStatus.BackColor = System.Drawing.Color.SeaShell;
            this.EquipmentSimulation4StarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSimulation4StarStatus.Location = new System.Drawing.Point(3, 150);
            this.EquipmentSimulation4StarStatus.Name = "EquipmentSimulation4StarStatus";
            this.EquipmentSimulation4StarStatus.Size = new System.Drawing.Size(100, 30);
            this.EquipmentSimulation4StarStatus.TabIndex = 5;
            this.EquipmentSimulation4StarStatus.Text = "0";
            this.EquipmentSimulation4StarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            this.label69.BackColor = System.Drawing.Color.SeaShell;
            this.label69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label69.Location = new System.Drawing.Point(3, 120);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(100, 30);
            this.label69.TabIndex = 4;
            this.label69.Text = "☆☆☆☆";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentSimulation3StarStatus
            // 
            this.EquipmentSimulation3StarStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.EquipmentSimulation3StarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSimulation3StarStatus.Location = new System.Drawing.Point(3, 90);
            this.EquipmentSimulation3StarStatus.Name = "EquipmentSimulation3StarStatus";
            this.EquipmentSimulation3StarStatus.Size = new System.Drawing.Size(100, 30);
            this.EquipmentSimulation3StarStatus.TabIndex = 3;
            this.EquipmentSimulation3StarStatus.Text = "0";
            this.EquipmentSimulation3StarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.BackColor = System.Drawing.Color.Gainsboro;
            this.label72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label72.Location = new System.Drawing.Point(3, 60);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(100, 30);
            this.label72.TabIndex = 2;
            this.label72.Text = "☆☆☆";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentSimulation2StarStatus
            // 
            this.EquipmentSimulation2StarStatus.BackColor = System.Drawing.Color.LightCyan;
            this.EquipmentSimulation2StarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSimulation2StarStatus.Location = new System.Drawing.Point(3, 30);
            this.EquipmentSimulation2StarStatus.Name = "EquipmentSimulation2StarStatus";
            this.EquipmentSimulation2StarStatus.Size = new System.Drawing.Size(100, 30);
            this.EquipmentSimulation2StarStatus.TabIndex = 1;
            this.EquipmentSimulation2StarStatus.Text = "0";
            this.EquipmentSimulation2StarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label75
            // 
            this.label75.BackColor = System.Drawing.Color.LightCyan;
            this.label75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label75.Location = new System.Drawing.Point(3, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(100, 30);
            this.label75.TabIndex = 0;
            this.label75.Text = "☆☆";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentSimulationResetUseButton
            // 
            this.EquipmentSimulationResetUseButton.Location = new System.Drawing.Point(725, 99);
            this.EquipmentSimulationResetUseButton.Name = "EquipmentSimulationResetUseButton";
            this.EquipmentSimulationResetUseButton.Size = new System.Drawing.Size(124, 23);
            this.EquipmentSimulationResetUseButton.TabIndex = 43;
            this.EquipmentSimulationResetUseButton.Text = "기록 초기화";
            this.EquipmentSimulationResetUseButton.UseVisualStyleBackColor = true;
            this.EquipmentSimulationResetUseButton.Click += new System.EventHandler(this.EquipmentSimulationResetUseButton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.EquipmentSimulationUseParts, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.label77, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.EquipmentSimulationUseFood, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label83, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.EquipmentSimulationUseAmmo, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label85, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.EquipmentSimulationUseManPower, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label87, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(728, 244);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 8;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(124, 248);
            this.tableLayoutPanel6.TabIndex = 42;
            // 
            // EquipmentSimulationUseParts
            // 
            this.EquipmentSimulationUseParts.BackColor = System.Drawing.Color.Thistle;
            this.EquipmentSimulationUseParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSimulationUseParts.Location = new System.Drawing.Point(3, 217);
            this.EquipmentSimulationUseParts.Name = "EquipmentSimulationUseParts";
            this.EquipmentSimulationUseParts.Size = new System.Drawing.Size(118, 31);
            this.EquipmentSimulationUseParts.TabIndex = 7;
            this.EquipmentSimulationUseParts.Text = "0";
            this.EquipmentSimulationUseParts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            this.label77.BackColor = System.Drawing.Color.Thistle;
            this.label77.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label77.Location = new System.Drawing.Point(3, 186);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(118, 31);
            this.label77.TabIndex = 6;
            this.label77.Text = "부품";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentSimulationUseFood
            // 
            this.EquipmentSimulationUseFood.BackColor = System.Drawing.Color.SeaShell;
            this.EquipmentSimulationUseFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSimulationUseFood.Location = new System.Drawing.Point(3, 155);
            this.EquipmentSimulationUseFood.Name = "EquipmentSimulationUseFood";
            this.EquipmentSimulationUseFood.Size = new System.Drawing.Size(118, 31);
            this.EquipmentSimulationUseFood.TabIndex = 5;
            this.EquipmentSimulationUseFood.Text = "0";
            this.EquipmentSimulationUseFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label83
            // 
            this.label83.BackColor = System.Drawing.Color.SeaShell;
            this.label83.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label83.Location = new System.Drawing.Point(3, 124);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(118, 31);
            this.label83.TabIndex = 4;
            this.label83.Text = "식량";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentSimulationUseAmmo
            // 
            this.EquipmentSimulationUseAmmo.BackColor = System.Drawing.Color.Gainsboro;
            this.EquipmentSimulationUseAmmo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSimulationUseAmmo.Location = new System.Drawing.Point(3, 93);
            this.EquipmentSimulationUseAmmo.Name = "EquipmentSimulationUseAmmo";
            this.EquipmentSimulationUseAmmo.Size = new System.Drawing.Size(118, 31);
            this.EquipmentSimulationUseAmmo.TabIndex = 3;
            this.EquipmentSimulationUseAmmo.Text = "0";
            this.EquipmentSimulationUseAmmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label85
            // 
            this.label85.BackColor = System.Drawing.Color.Gainsboro;
            this.label85.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label85.Location = new System.Drawing.Point(3, 62);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(118, 31);
            this.label85.TabIndex = 2;
            this.label85.Text = "탄약";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentSimulationUseManPower
            // 
            this.EquipmentSimulationUseManPower.BackColor = System.Drawing.Color.LightCyan;
            this.EquipmentSimulationUseManPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentSimulationUseManPower.Location = new System.Drawing.Point(3, 31);
            this.EquipmentSimulationUseManPower.Name = "EquipmentSimulationUseManPower";
            this.EquipmentSimulationUseManPower.Size = new System.Drawing.Size(118, 31);
            this.EquipmentSimulationUseManPower.TabIndex = 1;
            this.EquipmentSimulationUseManPower.Text = "0";
            this.EquipmentSimulationUseManPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.BackColor = System.Drawing.Color.LightCyan;
            this.label87.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label87.Location = new System.Drawing.Point(3, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(118, 31);
            this.label87.TabIndex = 0;
            this.label87.Text = "인력";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductSimulEquipmentAdvanceProductTypeGroup
            // 
            this.ProductSimulEquipmentAdvanceProductTypeGroup.Controls.Add(this.ProductSimulEquipmentAdvanceProductType3);
            this.ProductSimulEquipmentAdvanceProductTypeGroup.Controls.Add(this.ProductSimulEquipmentAdvanceProductType2);
            this.ProductSimulEquipmentAdvanceProductTypeGroup.Controls.Add(this.ProductSimulEquipmentAdvanceProductType1);
            this.ProductSimulEquipmentAdvanceProductTypeGroup.Location = new System.Drawing.Point(117, 22);
            this.ProductSimulEquipmentAdvanceProductTypeGroup.Name = "ProductSimulEquipmentAdvanceProductTypeGroup";
            this.ProductSimulEquipmentAdvanceProductTypeGroup.Size = new System.Drawing.Size(81, 90);
            this.ProductSimulEquipmentAdvanceProductTypeGroup.TabIndex = 41;
            this.ProductSimulEquipmentAdvanceProductTypeGroup.TabStop = false;
            this.ProductSimulEquipmentAdvanceProductTypeGroup.Text = "중형 타입";
            this.ProductSimulEquipmentAdvanceProductTypeGroup.Visible = false;
            // 
            // ProductSimulEquipmentAdvanceProductType3
            // 
            this.ProductSimulEquipmentAdvanceProductType3.AutoSize = true;
            this.ProductSimulEquipmentAdvanceProductType3.Location = new System.Drawing.Point(6, 63);
            this.ProductSimulEquipmentAdvanceProductType3.Name = "ProductSimulEquipmentAdvanceProductType3";
            this.ProductSimulEquipmentAdvanceProductType3.Size = new System.Drawing.Size(41, 16);
            this.ProductSimulEquipmentAdvanceProductType3.TabIndex = 2;
            this.ProductSimulEquipmentAdvanceProductType3.Tag = "3";
            this.ProductSimulEquipmentAdvanceProductType3.Text = "3형";
            this.ProductSimulEquipmentAdvanceProductType3.UseVisualStyleBackColor = true;
            this.ProductSimulEquipmentAdvanceProductType3.CheckedChanged += new System.EventHandler(this.ProductSimulEquipmentAdvanceProductType_CheckedChanged);
            // 
            // ProductSimulEquipmentAdvanceProductType2
            // 
            this.ProductSimulEquipmentAdvanceProductType2.AutoSize = true;
            this.ProductSimulEquipmentAdvanceProductType2.Location = new System.Drawing.Point(7, 43);
            this.ProductSimulEquipmentAdvanceProductType2.Name = "ProductSimulEquipmentAdvanceProductType2";
            this.ProductSimulEquipmentAdvanceProductType2.Size = new System.Drawing.Size(41, 16);
            this.ProductSimulEquipmentAdvanceProductType2.TabIndex = 1;
            this.ProductSimulEquipmentAdvanceProductType2.Tag = "2";
            this.ProductSimulEquipmentAdvanceProductType2.Text = "2형";
            this.ProductSimulEquipmentAdvanceProductType2.UseVisualStyleBackColor = true;
            this.ProductSimulEquipmentAdvanceProductType2.CheckedChanged += new System.EventHandler(this.ProductSimulEquipmentAdvanceProductType_CheckedChanged);
            // 
            // ProductSimulEquipmentAdvanceProductType1
            // 
            this.ProductSimulEquipmentAdvanceProductType1.AutoSize = true;
            this.ProductSimulEquipmentAdvanceProductType1.Checked = true;
            this.ProductSimulEquipmentAdvanceProductType1.Location = new System.Drawing.Point(7, 21);
            this.ProductSimulEquipmentAdvanceProductType1.Name = "ProductSimulEquipmentAdvanceProductType1";
            this.ProductSimulEquipmentAdvanceProductType1.Size = new System.Drawing.Size(41, 16);
            this.ProductSimulEquipmentAdvanceProductType1.TabIndex = 0;
            this.ProductSimulEquipmentAdvanceProductType1.TabStop = true;
            this.ProductSimulEquipmentAdvanceProductType1.Tag = "1";
            this.ProductSimulEquipmentAdvanceProductType1.Text = "1형";
            this.ProductSimulEquipmentAdvanceProductType1.UseVisualStyleBackColor = true;
            this.ProductSimulEquipmentAdvanceProductType1.CheckedChanged += new System.EventHandler(this.ProductSimulEquipmentAdvanceProductType_CheckedChanged);
            // 
            // ProductSimulEquipmentProductTypeGroup
            // 
            this.ProductSimulEquipmentProductTypeGroup.Controls.Add(this.ProductSimulEquipmentProductTypeAdvance);
            this.ProductSimulEquipmentProductTypeGroup.Controls.Add(this.ProductSimulEquipmentProductTypeNormal);
            this.ProductSimulEquipmentProductTypeGroup.Location = new System.Drawing.Point(31, 22);
            this.ProductSimulEquipmentProductTypeGroup.Name = "ProductSimulEquipmentProductTypeGroup";
            this.ProductSimulEquipmentProductTypeGroup.Size = new System.Drawing.Size(77, 71);
            this.ProductSimulEquipmentProductTypeGroup.TabIndex = 40;
            this.ProductSimulEquipmentProductTypeGroup.TabStop = false;
            this.ProductSimulEquipmentProductTypeGroup.Text = "제조 타입";
            // 
            // ProductSimulEquipmentProductTypeAdvance
            // 
            this.ProductSimulEquipmentProductTypeAdvance.AutoSize = true;
            this.ProductSimulEquipmentProductTypeAdvance.Location = new System.Drawing.Point(7, 43);
            this.ProductSimulEquipmentProductTypeAdvance.Name = "ProductSimulEquipmentProductTypeAdvance";
            this.ProductSimulEquipmentProductTypeAdvance.Size = new System.Drawing.Size(47, 16);
            this.ProductSimulEquipmentProductTypeAdvance.TabIndex = 1;
            this.ProductSimulEquipmentProductTypeAdvance.Tag = "Advance";
            this.ProductSimulEquipmentProductTypeAdvance.Text = "중형";
            this.ProductSimulEquipmentProductTypeAdvance.UseVisualStyleBackColor = true;
            this.ProductSimulEquipmentProductTypeAdvance.CheckedChanged += new System.EventHandler(this.ProductSimulEquipmentProductType_CheckedChanged);
            // 
            // ProductSimulEquipmentProductTypeNormal
            // 
            this.ProductSimulEquipmentProductTypeNormal.AutoSize = true;
            this.ProductSimulEquipmentProductTypeNormal.Checked = true;
            this.ProductSimulEquipmentProductTypeNormal.Location = new System.Drawing.Point(7, 21);
            this.ProductSimulEquipmentProductTypeNormal.Name = "ProductSimulEquipmentProductTypeNormal";
            this.ProductSimulEquipmentProductTypeNormal.Size = new System.Drawing.Size(47, 16);
            this.ProductSimulEquipmentProductTypeNormal.TabIndex = 0;
            this.ProductSimulEquipmentProductTypeNormal.TabStop = true;
            this.ProductSimulEquipmentProductTypeNormal.Tag = "Normal";
            this.ProductSimulEquipmentProductTypeNormal.Text = "일반";
            this.ProductSimulEquipmentProductTypeNormal.UseVisualStyleBackColor = true;
            this.ProductSimulEquipmentProductTypeNormal.CheckedChanged += new System.EventHandler(this.ProductSimulEquipmentProductType_CheckedChanged);
            // 
            // ProductEquipmentResultBackgroundPanel
            // 
            this.ProductEquipmentResultBackgroundPanel.Controls.Add(this.ProductEquipmentResultDialog);
            this.ProductEquipmentResultBackgroundPanel.Controls.Add(this.ProductEquipmentResultImageBox);
            this.ProductEquipmentResultBackgroundPanel.Location = new System.Drawing.Point(117, 175);
            this.ProductEquipmentResultBackgroundPanel.Name = "ProductEquipmentResultBackgroundPanel";
            this.ProductEquipmentResultBackgroundPanel.Size = new System.Drawing.Size(600, 352);
            this.ProductEquipmentResultBackgroundPanel.TabIndex = 38;
            // 
            // ProductEquipmentResultDialog
            // 
            this.ProductEquipmentResultDialog.BackgroundImage = global::Girls_FrontierLine_Supporter.Properties.Resources.dial;
            this.ProductEquipmentResultDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductEquipmentResultDialog.Controls.Add(this.ProductEquipmentResultDialogText);
            this.ProductEquipmentResultDialog.Controls.Add(this.ProductEquipmentResultName);
            this.ProductEquipmentResultDialog.Location = new System.Drawing.Point(44, 277);
            this.ProductEquipmentResultDialog.Name = "ProductEquipmentResultDialog";
            this.ProductEquipmentResultDialog.Size = new System.Drawing.Size(506, 72);
            this.ProductEquipmentResultDialog.TabIndex = 17;
            this.ProductEquipmentResultDialog.Visible = false;
            // 
            // ProductEquipmentResultDialogText
            // 
            this.ProductEquipmentResultDialogText.ForeColor = System.Drawing.Color.White;
            this.ProductEquipmentResultDialogText.Location = new System.Drawing.Point(9, 28);
            this.ProductEquipmentResultDialogText.Name = "ProductEquipmentResultDialogText";
            this.ProductEquipmentResultDialogText.Size = new System.Drawing.Size(449, 44);
            this.ProductEquipmentResultDialogText.TabIndex = 17;
            // 
            // ProductEquipmentResultName
            // 
            this.ProductEquipmentResultName.BackColor = System.Drawing.Color.Transparent;
            this.ProductEquipmentResultName.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductEquipmentResultName.ForeColor = System.Drawing.Color.White;
            this.ProductEquipmentResultName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductEquipmentResultName.Location = new System.Drawing.Point(8, 6);
            this.ProductEquipmentResultName.Name = "ProductEquipmentResultName";
            this.ProductEquipmentResultName.Size = new System.Drawing.Size(152, 19);
            this.ProductEquipmentResultName.TabIndex = 16;
            this.ProductEquipmentResultName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductEquipmentResultName.Visible = false;
            // 
            // ProductEquipmentResultImageBox
            // 
            this.ProductEquipmentResultImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductEquipmentResultImageBox.Location = new System.Drawing.Point(201, 26);
            this.ProductEquipmentResultImageBox.Name = "ProductEquipmentResultImageBox";
            this.ProductEquipmentResultImageBox.Size = new System.Drawing.Size(177, 245);
            this.ProductEquipmentResultImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductEquipmentResultImageBox.TabIndex = 15;
            this.ProductEquipmentResultImageBox.TabStop = false;
            this.ProductEquipmentResultImageBox.Visible = false;
            // 
            // ProductSimulEquipmentProductButton
            // 
            this.ProductSimulEquipmentProductButton.Location = new System.Drawing.Point(232, 85);
            this.ProductSimulEquipmentProductButton.Name = "ProductSimulEquipmentProductButton";
            this.ProductSimulEquipmentProductButton.Size = new System.Drawing.Size(356, 37);
            this.ProductSimulEquipmentProductButton.TabIndex = 32;
            this.ProductSimulEquipmentProductButton.Text = "제조 시작";
            this.ProductSimulEquipmentProductButton.UseVisualStyleBackColor = true;
            this.ProductSimulEquipmentProductButton.Click += new System.EventHandler(this.ProductSimulEquipmentProductButton_Click);
            // 
            // ProductSimulEquipmentPartsCount
            // 
            this.ProductSimulEquipmentPartsCount.Location = new System.Drawing.Point(465, 58);
            this.ProductSimulEquipmentPartsCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ProductSimulEquipmentPartsCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ProductSimulEquipmentPartsCount.Name = "ProductSimulEquipmentPartsCount";
            this.ProductSimulEquipmentPartsCount.Size = new System.Drawing.Size(52, 21);
            this.ProductSimulEquipmentPartsCount.TabIndex = 27;
            this.ProductSimulEquipmentPartsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductSimulEquipmentPartsCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ProductSimulEquipmentAmmoCount
            // 
            this.ProductSimulEquipmentAmmoCount.Location = new System.Drawing.Point(465, 20);
            this.ProductSimulEquipmentAmmoCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ProductSimulEquipmentAmmoCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ProductSimulEquipmentAmmoCount.Name = "ProductSimulEquipmentAmmoCount";
            this.ProductSimulEquipmentAmmoCount.Size = new System.Drawing.Size(52, 21);
            this.ProductSimulEquipmentAmmoCount.TabIndex = 26;
            this.ProductSimulEquipmentAmmoCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductSimulEquipmentAmmoCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ProductSimulEquipmentFoodCount
            // 
            this.ProductSimulEquipmentFoodCount.Location = new System.Drawing.Point(321, 58);
            this.ProductSimulEquipmentFoodCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ProductSimulEquipmentFoodCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ProductSimulEquipmentFoodCount.Name = "ProductSimulEquipmentFoodCount";
            this.ProductSimulEquipmentFoodCount.Size = new System.Drawing.Size(52, 21);
            this.ProductSimulEquipmentFoodCount.TabIndex = 25;
            this.ProductSimulEquipmentFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductSimulEquipmentFoodCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ProductSimulEquipmentManpowerCount
            // 
            this.ProductSimulEquipmentManpowerCount.Location = new System.Drawing.Point(321, 20);
            this.ProductSimulEquipmentManpowerCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ProductSimulEquipmentManpowerCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ProductSimulEquipmentManpowerCount.Name = "ProductSimulEquipmentManpowerCount";
            this.ProductSimulEquipmentManpowerCount.Size = new System.Drawing.Size(52, 21);
            this.ProductSimulEquipmentManpowerCount.TabIndex = 24;
            this.ProductSimulEquipmentManpowerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductSimulEquipmentManpowerCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ProductEquipmentResultGradeStar5
            // 
            this.ProductEquipmentResultGradeStar5.Location = new System.Drawing.Point(465, 139);
            this.ProductEquipmentResultGradeStar5.Name = "ProductEquipmentResultGradeStar5";
            this.ProductEquipmentResultGradeStar5.Size = new System.Drawing.Size(30, 30);
            this.ProductEquipmentResultGradeStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductEquipmentResultGradeStar5.TabIndex = 37;
            this.ProductEquipmentResultGradeStar5.TabStop = false;
            this.ProductEquipmentResultGradeStar5.Visible = false;
            // 
            // ProductEquipmentResultGradeStar4
            // 
            this.ProductEquipmentResultGradeStar4.Location = new System.Drawing.Point(429, 139);
            this.ProductEquipmentResultGradeStar4.Name = "ProductEquipmentResultGradeStar4";
            this.ProductEquipmentResultGradeStar4.Size = new System.Drawing.Size(30, 30);
            this.ProductEquipmentResultGradeStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductEquipmentResultGradeStar4.TabIndex = 36;
            this.ProductEquipmentResultGradeStar4.TabStop = false;
            this.ProductEquipmentResultGradeStar4.Visible = false;
            // 
            // ProductEquipmentResultGradeStar3
            // 
            this.ProductEquipmentResultGradeStar3.Location = new System.Drawing.Point(393, 139);
            this.ProductEquipmentResultGradeStar3.Name = "ProductEquipmentResultGradeStar3";
            this.ProductEquipmentResultGradeStar3.Size = new System.Drawing.Size(30, 30);
            this.ProductEquipmentResultGradeStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductEquipmentResultGradeStar3.TabIndex = 35;
            this.ProductEquipmentResultGradeStar3.TabStop = false;
            this.ProductEquipmentResultGradeStar3.Visible = false;
            // 
            // ProductEquipmentResultGradeStar2
            // 
            this.ProductEquipmentResultGradeStar2.Location = new System.Drawing.Point(357, 139);
            this.ProductEquipmentResultGradeStar2.Name = "ProductEquipmentResultGradeStar2";
            this.ProductEquipmentResultGradeStar2.Size = new System.Drawing.Size(30, 30);
            this.ProductEquipmentResultGradeStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductEquipmentResultGradeStar2.TabIndex = 34;
            this.ProductEquipmentResultGradeStar2.TabStop = false;
            this.ProductEquipmentResultGradeStar2.Visible = false;
            // 
            // ProductEquipmentResultGradeStar1
            // 
            this.ProductEquipmentResultGradeStar1.Location = new System.Drawing.Point(321, 139);
            this.ProductEquipmentResultGradeStar1.Name = "ProductEquipmentResultGradeStar1";
            this.ProductEquipmentResultGradeStar1.Size = new System.Drawing.Size(30, 30);
            this.ProductEquipmentResultGradeStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductEquipmentResultGradeStar1.TabIndex = 33;
            this.ProductEquipmentResultGradeStar1.TabStop = false;
            this.ProductEquipmentResultGradeStar1.Visible = false;
            // 
            // MDInfoTab
            // 
            this.MDInfoTab.Controls.Add(this.PlaceLoadPanel);
            this.MDInfoTab.Controls.Add(this.PlaceViewerSettingGroup);
            this.MDInfoTab.Location = new System.Drawing.Point(4, 22);
            this.MDInfoTab.Name = "MDInfoTab";
            this.MDInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.MDInfoTab.Size = new System.Drawing.Size(873, 579);
            this.MDInfoTab.TabIndex = 7;
            this.MDInfoTab.Text = "전역";
            this.MDInfoTab.UseVisualStyleBackColor = true;
            // 
            // PlaceLoadPanel
            // 
            this.PlaceLoadPanel.Controls.Add(this.PlaceLoadImageBox1);
            this.PlaceLoadPanel.Controls.Add(this.PlaceLoadImageBox2);
            this.PlaceLoadPanel.Controls.Add(this.PlaceViewerBox);
            this.PlaceLoadPanel.Location = new System.Drawing.Point(3, 137);
            this.PlaceLoadPanel.Name = "PlaceLoadPanel";
            this.PlaceLoadPanel.Size = new System.Drawing.Size(867, 439);
            this.PlaceLoadPanel.TabIndex = 4;
            // 
            // PlaceLoadImageBox1
            // 
            this.PlaceLoadImageBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaceLoadImageBox1.Location = new System.Drawing.Point(0, 0);
            this.PlaceLoadImageBox1.Name = "PlaceLoadImageBox1";
            this.PlaceLoadImageBox1.Size = new System.Drawing.Size(867, 0);
            this.PlaceLoadImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlaceLoadImageBox1.TabIndex = 2;
            this.PlaceLoadImageBox1.TabStop = false;
            // 
            // PlaceLoadImageBox2
            // 
            this.PlaceLoadImageBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlaceLoadImageBox2.Location = new System.Drawing.Point(0, 439);
            this.PlaceLoadImageBox2.Name = "PlaceLoadImageBox2";
            this.PlaceLoadImageBox2.Size = new System.Drawing.Size(867, 0);
            this.PlaceLoadImageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlaceLoadImageBox2.TabIndex = 3;
            this.PlaceLoadImageBox2.TabStop = false;
            // 
            // PlaceViewerBox
            // 
            this.PlaceViewerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaceViewerBox.Location = new System.Drawing.Point(0, 0);
            this.PlaceViewerBox.Name = "PlaceViewerBox";
            this.PlaceViewerBox.Size = new System.Drawing.Size(867, 439);
            this.PlaceViewerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlaceViewerBox.TabIndex = 1;
            this.PlaceViewerBox.TabStop = false;
            // 
            // PlaceViewerSettingGroup
            // 
            this.PlaceViewerSettingGroup.Controls.Add(this.label84);
            this.PlaceViewerSettingGroup.Controls.Add(this.ImageSettingGroup);
            this.PlaceViewerSettingGroup.Controls.Add(this.ImageLoadButton);
            this.PlaceViewerSettingGroup.Controls.Add(this.PlaceSettingGroup);
            this.PlaceViewerSettingGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaceViewerSettingGroup.Location = new System.Drawing.Point(3, 3);
            this.PlaceViewerSettingGroup.Name = "PlaceViewerSettingGroup";
            this.PlaceViewerSettingGroup.Size = new System.Drawing.Size(867, 131);
            this.PlaceViewerSettingGroup.TabIndex = 0;
            this.PlaceViewerSettingGroup.TabStop = false;
            this.PlaceViewerSettingGroup.Text = "설정";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(795, 17);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(66, 12);
            this.label84.TabIndex = 4;
            this.label84.Text = "Test Mode";
            // 
            // ImageSettingGroup
            // 
            this.ImageSettingGroup.Controls.Add(this.label78);
            this.ImageSettingGroup.Controls.Add(this.ImageModeSelector);
            this.ImageSettingGroup.Enabled = false;
            this.ImageSettingGroup.Location = new System.Drawing.Point(186, 20);
            this.ImageSettingGroup.Name = "ImageSettingGroup";
            this.ImageSettingGroup.Size = new System.Drawing.Size(167, 105);
            this.ImageSettingGroup.TabIndex = 3;
            this.ImageSettingGroup.TabStop = false;
            this.ImageSettingGroup.Text = "이미지";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(1, 28);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(65, 12);
            this.label78.TabIndex = 1;
            this.label78.Text = "표시 모드 :";
            // 
            // ImageModeSelector
            // 
            this.ImageModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageModeSelector.FormattingEnabled = true;
            this.ImageModeSelector.Items.AddRange(new object[] {
            "일반",
            "늘이기",
            "자동",
            "가운데",
            "확대"});
            this.ImageModeSelector.Location = new System.Drawing.Point(69, 24);
            this.ImageModeSelector.Name = "ImageModeSelector";
            this.ImageModeSelector.Size = new System.Drawing.Size(92, 20);
            this.ImageModeSelector.TabIndex = 0;
            this.ImageModeSelector.SelectedIndexChanged += new System.EventHandler(this.ImageModeSelector_SelectedIndexChanged);
            // 
            // ImageLoadButton
            // 
            this.ImageLoadButton.Location = new System.Drawing.Point(769, 102);
            this.ImageLoadButton.Name = "ImageLoadButton";
            this.ImageLoadButton.Size = new System.Drawing.Size(92, 23);
            this.ImageLoadButton.TabIndex = 2;
            this.ImageLoadButton.Text = "이미지 로드";
            this.ImageLoadButton.UseVisualStyleBackColor = true;
            this.ImageLoadButton.Click += new System.EventHandler(this.ImageLoadButton_Click);
            // 
            // PlaceSettingGroup
            // 
            this.PlaceSettingGroup.Controls.Add(this.label76);
            this.PlaceSettingGroup.Controls.Add(this.PlaceSelector);
            this.PlaceSettingGroup.Location = new System.Drawing.Point(3, 20);
            this.PlaceSettingGroup.Name = "PlaceSettingGroup";
            this.PlaceSettingGroup.Size = new System.Drawing.Size(177, 105);
            this.PlaceSettingGroup.TabIndex = 1;
            this.PlaceSettingGroup.TabStop = false;
            this.PlaceSettingGroup.Text = "지역";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(8, 24);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(65, 12);
            this.label76.TabIndex = 1;
            this.label76.Text = "지역 선택 :";
            // 
            // PlaceSelector
            // 
            this.PlaceSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaceSelector.FormattingEnabled = true;
            this.PlaceSelector.Items.AddRange(new object[] {
            "1-1",
            "1-2",
            "1-3",
            "1-4",
            "1-5",
            "1-6",
            "1-1E",
            "1-2E",
            "1-3E",
            "1-4E",
            "1-1N",
            "1-2N",
            "1-3N",
            "1-4N",
            "2-1",
            "2-2",
            "2-3",
            "2-4",
            "2-5",
            "2-6",
            "2-1E",
            "2-2E",
            "2-3E",
            "2-4E",
            "2-1N",
            "2-2N",
            "2-3N",
            "2-4N"});
            this.PlaceSelector.Location = new System.Drawing.Point(80, 20);
            this.PlaceSelector.Name = "PlaceSelector";
            this.PlaceSelector.Size = new System.Drawing.Size(85, 20);
            this.PlaceSelector.TabIndex = 0;
            // 
            // ETCTab
            // 
            this.ETCTab.Controls.Add(this.groupBox10);
            this.ETCTab.Controls.Add(this.FRCalcGroup);
            this.ETCTab.Controls.Add(this.groupBox4);
            this.ETCTab.Controls.Add(this.groupBox3);
            this.ETCTab.Controls.Add(this.ExpItemCalcGroup);
            this.ETCTab.Location = new System.Drawing.Point(4, 22);
            this.ETCTab.Name = "ETCTab";
            this.ETCTab.Size = new System.Drawing.Size(873, 579);
            this.ETCTab.TabIndex = 3;
            this.ETCTab.Text = "기타";
            this.ETCTab.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.GriffinDailyLifeComicButton);
            this.groupBox10.Controls.Add(this.GriffinInformationComicButton);
            this.groupBox10.Controls.Add(this.LoadingComicButton);
            this.groupBox10.Location = new System.Drawing.Point(421, 204);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 372);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "인게임 4컷";
            // 
            // GriffinDailyLifeComicButton
            // 
            this.GriffinDailyLifeComicButton.Location = new System.Drawing.Point(6, 122);
            this.GriffinDailyLifeComicButton.Name = "GriffinDailyLifeComicButton";
            this.GriffinDailyLifeComicButton.Size = new System.Drawing.Size(188, 44);
            this.GriffinDailyLifeComicButton.TabIndex = 2;
            this.GriffinDailyLifeComicButton.Tag = "GriffinDailyLifeComic";
            this.GriffinDailyLifeComicButton.Text = "그리폰 일상만화";
            this.GriffinDailyLifeComicButton.UseVisualStyleBackColor = true;
            this.GriffinDailyLifeComicButton.Click += new System.EventHandler(this.ComicViewerButton_Click);
            // 
            // GriffinInformationComicButton
            // 
            this.GriffinInformationComicButton.Location = new System.Drawing.Point(6, 71);
            this.GriffinInformationComicButton.Name = "GriffinInformationComicButton";
            this.GriffinInformationComicButton.Size = new System.Drawing.Size(188, 44);
            this.GriffinInformationComicButton.TabIndex = 1;
            this.GriffinInformationComicButton.Tag = "GriffinInformationComic";
            this.GriffinInformationComicButton.Text = "그리폰 안내서";
            this.GriffinInformationComicButton.UseVisualStyleBackColor = true;
            this.GriffinInformationComicButton.Click += new System.EventHandler(this.ComicViewerButton_Click);
            // 
            // LoadingComicButton
            // 
            this.LoadingComicButton.Location = new System.Drawing.Point(6, 21);
            this.LoadingComicButton.Name = "LoadingComicButton";
            this.LoadingComicButton.Size = new System.Drawing.Size(188, 44);
            this.LoadingComicButton.TabIndex = 0;
            this.LoadingComicButton.Tag = "LoadingComic";
            this.LoadingComicButton.Text = "다운로드 화면 4컷";
            this.LoadingComicButton.UseVisualStyleBackColor = true;
            this.LoadingComicButton.Click += new System.EventHandler(this.ComicViewerButton_Click);
            // 
            // FRCalcGroup
            // 
            this.FRCalcGroup.Controls.Add(this.CalcFRCaution);
            this.FRCalcGroup.Controls.Add(this.label55);
            this.FRCalcGroup.Controls.Add(this.FRCalcTotalFRCountLabel);
            this.FRCalcGroup.Controls.Add(this.FRCalcTotalFRLabel);
            this.FRCalcGroup.Controls.Add(this.label52);
            this.FRCalcGroup.Controls.Add(this.label49);
            this.FRCalcGroup.Controls.Add(this.FRCalcSkillEffectFRCount4);
            this.FRCalcGroup.Controls.Add(this.FRCalcSkillEffectFRCount3);
            this.FRCalcGroup.Controls.Add(this.FRCalcSkillEffectFRCount2);
            this.FRCalcGroup.Controls.Add(this.FRCalcSkillEffectFRCount1);
            this.FRCalcGroup.Controls.Add(this.FRCalcSkillEffectFRCountLabel);
            this.FRCalcGroup.Controls.Add(this.FRCalcSkillEffectFRLabel);
            this.FRCalcGroup.Controls.Add(this.label48);
            this.FRCalcGroup.Controls.Add(this.label47);
            this.FRCalcGroup.Controls.Add(this.FRCalcFormationEffectFRCount4);
            this.FRCalcGroup.Controls.Add(this.FRCalcFormationEffectFRCount3);
            this.FRCalcGroup.Controls.Add(this.FRCalcFormationEffectFRCount2);
            this.FRCalcGroup.Controls.Add(this.FRCalcFormationEffectFRCount1);
            this.FRCalcGroup.Controls.Add(this.FRCalcFormationEffectFRCountLabel);
            this.FRCalcGroup.Controls.Add(this.FRCalcFormationEffectFRLabel);
            this.FRCalcGroup.Controls.Add(this.label46);
            this.FRCalcGroup.Controls.Add(this.label45);
            this.FRCalcGroup.Controls.Add(this.FRCalcItemFRCount);
            this.FRCalcGroup.Controls.Add(this.FRCalcItemFRLabel);
            this.FRCalcGroup.Controls.Add(this.label44);
            this.FRCalcGroup.Controls.Add(this.FRCalcDefaultFRCount);
            this.FRCalcGroup.Controls.Add(this.FRCalcDefaultFRLabel);
            this.FRCalcGroup.Location = new System.Drawing.Point(298, 3);
            this.FRCalcGroup.Name = "FRCalcGroup";
            this.FRCalcGroup.Size = new System.Drawing.Size(547, 195);
            this.FRCalcGroup.TabIndex = 3;
            this.FRCalcGroup.TabStop = false;
            this.FRCalcGroup.Text = "사속 계산기";
            // 
            // CalcFRCaution
            // 
            this.CalcFRCaution.AutoSize = true;
            this.CalcFRCaution.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalcFRCaution.ForeColor = System.Drawing.Color.Red;
            this.CalcFRCaution.Location = new System.Drawing.Point(18, 95);
            this.CalcFRCaution.Name = "CalcFRCaution";
            this.CalcFRCaution.Size = new System.Drawing.Size(117, 72);
            this.CalcFRCaution.TabIndex = 32;
            this.CalcFRCaution.Text = "* 총기별 최대 사속 *\r\n\r\nHG, SMG : 116\r\nAR, RF : 108\r\nSG : 60\r\nMG : 고정";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label55.Location = new System.Drawing.Point(385, 51);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(15, 15);
            this.label55.TabIndex = 31;
            this.label55.Text = "=";
            // 
            // FRCalcTotalFRCountLabel
            // 
            this.FRCalcTotalFRCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FRCalcTotalFRCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRCalcTotalFRCountLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FRCalcTotalFRCountLabel.Location = new System.Drawing.Point(420, 47);
            this.FRCalcTotalFRCountLabel.Name = "FRCalcTotalFRCountLabel";
            this.FRCalcTotalFRCountLabel.Size = new System.Drawing.Size(67, 22);
            this.FRCalcTotalFRCountLabel.TabIndex = 29;
            this.FRCalcTotalFRCountLabel.Text = "0";
            this.FRCalcTotalFRCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRCalcTotalFRLabel
            // 
            this.FRCalcTotalFRLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FRCalcTotalFRLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRCalcTotalFRLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FRCalcTotalFRLabel.Location = new System.Drawing.Point(420, 17);
            this.FRCalcTotalFRLabel.Name = "FRCalcTotalFRLabel";
            this.FRCalcTotalFRLabel.Size = new System.Drawing.Size(67, 25);
            this.FRCalcTotalFRLabel.TabIndex = 30;
            this.FRCalcTotalFRLabel.Text = "사속";
            this.FRCalcTotalFRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label52.Location = new System.Drawing.Point(319, 69);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(21, 15);
            this.label52.TabIndex = 28;
            this.label52.Text = "∥";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label49.Location = new System.Drawing.Point(233, 69);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(21, 15);
            this.label49.TabIndex = 27;
            this.label49.Text = "∥";
            // 
            // FRCalcSkillEffectFRCount4
            // 
            this.FRCalcSkillEffectFRCount4.Location = new System.Drawing.Point(297, 168);
            this.FRCalcSkillEffectFRCount4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcSkillEffectFRCount4.Name = "FRCalcSkillEffectFRCount4";
            this.FRCalcSkillEffectFRCount4.Size = new System.Drawing.Size(67, 21);
            this.FRCalcSkillEffectFRCount4.TabIndex = 26;
            this.FRCalcSkillEffectFRCount4.ValueChanged += new System.EventHandler(this.FRCalcSkillEffectFRCount_ValueChanged);
            // 
            // FRCalcSkillEffectFRCount3
            // 
            this.FRCalcSkillEffectFRCount3.Location = new System.Drawing.Point(297, 141);
            this.FRCalcSkillEffectFRCount3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcSkillEffectFRCount3.Name = "FRCalcSkillEffectFRCount3";
            this.FRCalcSkillEffectFRCount3.Size = new System.Drawing.Size(67, 21);
            this.FRCalcSkillEffectFRCount3.TabIndex = 25;
            this.FRCalcSkillEffectFRCount3.ValueChanged += new System.EventHandler(this.FRCalcSkillEffectFRCount_ValueChanged);
            // 
            // FRCalcSkillEffectFRCount2
            // 
            this.FRCalcSkillEffectFRCount2.Location = new System.Drawing.Point(297, 114);
            this.FRCalcSkillEffectFRCount2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcSkillEffectFRCount2.Name = "FRCalcSkillEffectFRCount2";
            this.FRCalcSkillEffectFRCount2.Size = new System.Drawing.Size(67, 21);
            this.FRCalcSkillEffectFRCount2.TabIndex = 24;
            this.FRCalcSkillEffectFRCount2.ValueChanged += new System.EventHandler(this.FRCalcSkillEffectFRCount_ValueChanged);
            // 
            // FRCalcSkillEffectFRCount1
            // 
            this.FRCalcSkillEffectFRCount1.Location = new System.Drawing.Point(297, 87);
            this.FRCalcSkillEffectFRCount1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcSkillEffectFRCount1.Name = "FRCalcSkillEffectFRCount1";
            this.FRCalcSkillEffectFRCount1.Size = new System.Drawing.Size(67, 21);
            this.FRCalcSkillEffectFRCount1.TabIndex = 23;
            this.FRCalcSkillEffectFRCount1.ValueChanged += new System.EventHandler(this.FRCalcSkillEffectFRCount_ValueChanged);
            // 
            // FRCalcSkillEffectFRCountLabel
            // 
            this.FRCalcSkillEffectFRCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FRCalcSkillEffectFRCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRCalcSkillEffectFRCountLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FRCalcSkillEffectFRCountLabel.Location = new System.Drawing.Point(297, 47);
            this.FRCalcSkillEffectFRCountLabel.Name = "FRCalcSkillEffectFRCountLabel";
            this.FRCalcSkillEffectFRCountLabel.Size = new System.Drawing.Size(67, 22);
            this.FRCalcSkillEffectFRCountLabel.TabIndex = 21;
            this.FRCalcSkillEffectFRCountLabel.Text = "100";
            this.FRCalcSkillEffectFRCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FRCalcSkillEffectFRCountLabel.TextChanged += new System.EventHandler(this.FRCalcCount_ValueChanged);
            // 
            // FRCalcSkillEffectFRLabel
            // 
            this.FRCalcSkillEffectFRLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FRCalcSkillEffectFRLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRCalcSkillEffectFRLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FRCalcSkillEffectFRLabel.Location = new System.Drawing.Point(297, 17);
            this.FRCalcSkillEffectFRLabel.Name = "FRCalcSkillEffectFRLabel";
            this.FRCalcSkillEffectFRLabel.Size = new System.Drawing.Size(67, 25);
            this.FRCalcSkillEffectFRLabel.TabIndex = 22;
            this.FRCalcSkillEffectFRLabel.Text = "스킬 버프";
            this.FRCalcSkillEffectFRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label48.Location = new System.Drawing.Point(281, 50);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(16, 15);
            this.label48.TabIndex = 20;
            this.label48.Text = "X";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label47.Location = new System.Drawing.Point(193, 51);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(16, 15);
            this.label47.TabIndex = 19;
            this.label47.Text = "X";
            // 
            // FRCalcFormationEffectFRCount4
            // 
            this.FRCalcFormationEffectFRCount4.Location = new System.Drawing.Point(212, 168);
            this.FRCalcFormationEffectFRCount4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcFormationEffectFRCount4.Name = "FRCalcFormationEffectFRCount4";
            this.FRCalcFormationEffectFRCount4.Size = new System.Drawing.Size(67, 21);
            this.FRCalcFormationEffectFRCount4.TabIndex = 18;
            this.FRCalcFormationEffectFRCount4.ValueChanged += new System.EventHandler(this.FRCalcFormationEffectFRCount_ValueChanged);
            // 
            // FRCalcFormationEffectFRCount3
            // 
            this.FRCalcFormationEffectFRCount3.Location = new System.Drawing.Point(212, 141);
            this.FRCalcFormationEffectFRCount3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcFormationEffectFRCount3.Name = "FRCalcFormationEffectFRCount3";
            this.FRCalcFormationEffectFRCount3.Size = new System.Drawing.Size(67, 21);
            this.FRCalcFormationEffectFRCount3.TabIndex = 17;
            this.FRCalcFormationEffectFRCount3.ValueChanged += new System.EventHandler(this.FRCalcFormationEffectFRCount_ValueChanged);
            // 
            // FRCalcFormationEffectFRCount2
            // 
            this.FRCalcFormationEffectFRCount2.Location = new System.Drawing.Point(212, 114);
            this.FRCalcFormationEffectFRCount2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcFormationEffectFRCount2.Name = "FRCalcFormationEffectFRCount2";
            this.FRCalcFormationEffectFRCount2.Size = new System.Drawing.Size(67, 21);
            this.FRCalcFormationEffectFRCount2.TabIndex = 16;
            this.FRCalcFormationEffectFRCount2.ValueChanged += new System.EventHandler(this.FRCalcFormationEffectFRCount_ValueChanged);
            // 
            // FRCalcFormationEffectFRCount1
            // 
            this.FRCalcFormationEffectFRCount1.Location = new System.Drawing.Point(212, 87);
            this.FRCalcFormationEffectFRCount1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcFormationEffectFRCount1.Name = "FRCalcFormationEffectFRCount1";
            this.FRCalcFormationEffectFRCount1.Size = new System.Drawing.Size(67, 21);
            this.FRCalcFormationEffectFRCount1.TabIndex = 15;
            this.FRCalcFormationEffectFRCount1.ValueChanged += new System.EventHandler(this.FRCalcFormationEffectFRCount_ValueChanged);
            // 
            // FRCalcFormationEffectFRCountLabel
            // 
            this.FRCalcFormationEffectFRCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FRCalcFormationEffectFRCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRCalcFormationEffectFRCountLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FRCalcFormationEffectFRCountLabel.Location = new System.Drawing.Point(212, 47);
            this.FRCalcFormationEffectFRCountLabel.Name = "FRCalcFormationEffectFRCountLabel";
            this.FRCalcFormationEffectFRCountLabel.Size = new System.Drawing.Size(67, 22);
            this.FRCalcFormationEffectFRCountLabel.TabIndex = 12;
            this.FRCalcFormationEffectFRCountLabel.Text = "100";
            this.FRCalcFormationEffectFRCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FRCalcFormationEffectFRCountLabel.TextChanged += new System.EventHandler(this.FRCalcCount_ValueChanged);
            // 
            // FRCalcFormationEffectFRLabel
            // 
            this.FRCalcFormationEffectFRLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FRCalcFormationEffectFRLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRCalcFormationEffectFRLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FRCalcFormationEffectFRLabel.Location = new System.Drawing.Point(212, 17);
            this.FRCalcFormationEffectFRLabel.Name = "FRCalcFormationEffectFRLabel";
            this.FRCalcFormationEffectFRLabel.Size = new System.Drawing.Size(67, 25);
            this.FRCalcFormationEffectFRLabel.TabIndex = 14;
            this.FRCalcFormationEffectFRLabel.Text = "진형 버프";
            this.FRCalcFormationEffectFRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label46.Location = new System.Drawing.Point(181, 51);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(13, 15);
            this.label46.TabIndex = 13;
            this.label46.Text = ")";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label45.Location = new System.Drawing.Point(91, 50);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(15, 15);
            this.label45.TabIndex = 12;
            this.label45.Text = "+";
            // 
            // FRCalcItemFRCount
            // 
            this.FRCalcItemFRCount.Location = new System.Drawing.Point(111, 48);
            this.FRCalcItemFRCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcItemFRCount.Name = "FRCalcItemFRCount";
            this.FRCalcItemFRCount.Size = new System.Drawing.Size(67, 21);
            this.FRCalcItemFRCount.TabIndex = 11;
            this.FRCalcItemFRCount.ValueChanged += new System.EventHandler(this.FRCalcCount_ValueChanged);
            // 
            // FRCalcItemFRLabel
            // 
            this.FRCalcItemFRLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FRCalcItemFRLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRCalcItemFRLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FRCalcItemFRLabel.Location = new System.Drawing.Point(111, 17);
            this.FRCalcItemFRLabel.Name = "FRCalcItemFRLabel";
            this.FRCalcItemFRLabel.Size = new System.Drawing.Size(67, 25);
            this.FRCalcItemFRLabel.TabIndex = 10;
            this.FRCalcItemFRLabel.Text = "아이템";
            this.FRCalcItemFRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label44.Location = new System.Drawing.Point(6, 50);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(13, 15);
            this.label44.TabIndex = 9;
            this.label44.Text = "(";
            // 
            // FRCalcDefaultFRCount
            // 
            this.FRCalcDefaultFRCount.Location = new System.Drawing.Point(20, 48);
            this.FRCalcDefaultFRCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FRCalcDefaultFRCount.Name = "FRCalcDefaultFRCount";
            this.FRCalcDefaultFRCount.Size = new System.Drawing.Size(67, 21);
            this.FRCalcDefaultFRCount.TabIndex = 8;
            this.FRCalcDefaultFRCount.ValueChanged += new System.EventHandler(this.FRCalcCount_ValueChanged);
            // 
            // FRCalcDefaultFRLabel
            // 
            this.FRCalcDefaultFRLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FRCalcDefaultFRLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRCalcDefaultFRLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FRCalcDefaultFRLabel.Location = new System.Drawing.Point(20, 17);
            this.FRCalcDefaultFRLabel.Name = "FRCalcDefaultFRLabel";
            this.FRCalcDefaultFRLabel.Size = new System.Drawing.Size(67, 25);
            this.FRCalcDefaultFRLabel.TabIndex = 7;
            this.FRCalcDefaultFRLabel.Text = "기본 사속";
            this.FRCalcDefaultFRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RequireCoreCount);
            this.groupBox4.Controls.Add(this.RequireCoreLabel);
            this.groupBox4.Controls.Add(this.LinkCalcGradeSelector);
            this.groupBox4.Controls.Add(this.LinkCalcGradeSelectorLabel);
            this.groupBox4.Controls.Add(this.EndLinkCount);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.StartLinkCount);
            this.groupBox4.Controls.Add(this.LinkCalcLinkLabel);
            this.groupBox4.Location = new System.Drawing.Point(215, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 372);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "편제 확대 계산기";
            // 
            // RequireCoreCount
            // 
            this.RequireCoreCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RequireCoreCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RequireCoreCount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RequireCoreCount.Location = new System.Drawing.Point(6, 282);
            this.RequireCoreCount.Name = "RequireCoreCount";
            this.RequireCoreCount.Size = new System.Drawing.Size(188, 22);
            this.RequireCoreCount.TabIndex = 13;
            this.RequireCoreCount.Text = "0";
            this.RequireCoreCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RequireCoreLabel
            // 
            this.RequireCoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RequireCoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RequireCoreLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RequireCoreLabel.Location = new System.Drawing.Point(6, 248);
            this.RequireCoreLabel.Name = "RequireCoreLabel";
            this.RequireCoreLabel.Size = new System.Drawing.Size(188, 25);
            this.RequireCoreLabel.TabIndex = 12;
            this.RequireCoreLabel.Text = "필요한 코어 수량";
            this.RequireCoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinkCalcGradeSelector
            // 
            this.LinkCalcGradeSelector.DisplayMember = "ㅇ";
            this.LinkCalcGradeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LinkCalcGradeSelector.FormattingEnabled = true;
            this.LinkCalcGradeSelector.Items.AddRange(new object[] {
            "☆☆",
            "☆☆☆",
            "☆☆☆☆",
            "☆☆☆☆☆"});
            this.LinkCalcGradeSelector.Location = new System.Drawing.Point(6, 45);
            this.LinkCalcGradeSelector.MaxDropDownItems = 5;
            this.LinkCalcGradeSelector.Name = "LinkCalcGradeSelector";
            this.LinkCalcGradeSelector.Size = new System.Drawing.Size(188, 20);
            this.LinkCalcGradeSelector.TabIndex = 11;
            this.LinkCalcGradeSelector.SelectedIndexChanged += new System.EventHandler(this.LinkCalc_SelectedIndexChanged);
            // 
            // LinkCalcGradeSelectorLabel
            // 
            this.LinkCalcGradeSelectorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LinkCalcGradeSelectorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinkCalcGradeSelectorLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LinkCalcGradeSelectorLabel.Location = new System.Drawing.Point(6, 17);
            this.LinkCalcGradeSelectorLabel.Name = "LinkCalcGradeSelectorLabel";
            this.LinkCalcGradeSelectorLabel.Size = new System.Drawing.Size(188, 25);
            this.LinkCalcGradeSelectorLabel.TabIndex = 10;
            this.LinkCalcGradeSelectorLabel.Text = "인형 등급";
            this.LinkCalcGradeSelectorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndLinkCount
            // 
            this.EndLinkCount.Location = new System.Drawing.Point(115, 121);
            this.EndLinkCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.EndLinkCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndLinkCount.Name = "EndLinkCount";
            this.EndLinkCount.Size = new System.Drawing.Size(79, 21);
            this.EndLinkCount.TabIndex = 8;
            this.EndLinkCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndLinkCount.ValueChanged += new System.EventHandler(this.LinkCalc_SelectedIndexChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label43.Location = new System.Drawing.Point(83, 124);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(27, 15);
            this.label43.TabIndex = 7;
            this.label43.Text = "=>";
            // 
            // StartLinkCount
            // 
            this.StartLinkCount.Location = new System.Drawing.Point(6, 121);
            this.StartLinkCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.StartLinkCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartLinkCount.Name = "StartLinkCount";
            this.StartLinkCount.Size = new System.Drawing.Size(70, 21);
            this.StartLinkCount.TabIndex = 6;
            this.StartLinkCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartLinkCount.ValueChanged += new System.EventHandler(this.LinkCalc_SelectedIndexChanged);
            // 
            // LinkCalcLinkLabel
            // 
            this.LinkCalcLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LinkCalcLinkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinkCalcLinkLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LinkCalcLinkLabel.Location = new System.Drawing.Point(6, 90);
            this.LinkCalcLinkLabel.Name = "LinkCalcLinkLabel";
            this.LinkCalcLinkLabel.Size = new System.Drawing.Size(188, 25);
            this.LinkCalcLinkLabel.TabIndex = 5;
            this.LinkCalcLinkLabel.Text = "링크 수";
            this.LinkCalcLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SkillTrainingTypeSelector);
            this.groupBox3.Controls.Add(this.SkillTrainingTable);
            this.groupBox3.Location = new System.Drawing.Point(9, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 372);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "스킬 훈련";
            // 
            // SkillTrainingTypeSelector
            // 
            this.SkillTrainingTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkillTrainingTypeSelector.FormattingEnabled = true;
            this.SkillTrainingTypeSelector.Items.AddRange(new object[] {
            "인형",
            "전투요정",
            "전략요정"});
            this.SkillTrainingTypeSelector.Location = new System.Drawing.Point(6, 23);
            this.SkillTrainingTypeSelector.Name = "SkillTrainingTypeSelector";
            this.SkillTrainingTypeSelector.Size = new System.Drawing.Size(188, 20);
            this.SkillTrainingTypeSelector.TabIndex = 1;
            this.SkillTrainingTypeSelector.SelectedIndexChanged += new System.EventHandler(this.SkillTrainingTypeSelector_SelectedIndexChanged);
            // 
            // SkillTrainingTable
            // 
            this.SkillTrainingTable.ColumnCount = 4;
            this.SkillTrainingTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.SkillTrainingTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.SkillTrainingTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.SkillTrainingTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.SkillTrainingTable.Controls.Add(this.label42, 3, 0);
            this.SkillTrainingTable.Controls.Add(this.label41, 2, 0);
            this.SkillTrainingTable.Controls.Add(this.label40, 1, 0);
            this.SkillTrainingTable.Controls.Add(this.STTime9, 3, 9);
            this.SkillTrainingTable.Controls.Add(this.STConsumption9, 2, 9);
            this.SkillTrainingTable.Controls.Add(this.STDataType9, 1, 9);
            this.SkillTrainingTable.Controls.Add(this.label35, 0, 9);
            this.SkillTrainingTable.Controls.Add(this.STTime8, 3, 8);
            this.SkillTrainingTable.Controls.Add(this.STConsumption8, 2, 8);
            this.SkillTrainingTable.Controls.Add(this.STDataType8, 1, 8);
            this.SkillTrainingTable.Controls.Add(this.label31, 0, 8);
            this.SkillTrainingTable.Controls.Add(this.STTime7, 3, 7);
            this.SkillTrainingTable.Controls.Add(this.STConsumption7, 2, 7);
            this.SkillTrainingTable.Controls.Add(this.STDataType7, 1, 7);
            this.SkillTrainingTable.Controls.Add(this.label27, 0, 7);
            this.SkillTrainingTable.Controls.Add(this.STTime6, 3, 6);
            this.SkillTrainingTable.Controls.Add(this.STConsumption6, 2, 6);
            this.SkillTrainingTable.Controls.Add(this.STDataType6, 1, 6);
            this.SkillTrainingTable.Controls.Add(this.label23, 0, 6);
            this.SkillTrainingTable.Controls.Add(this.STTime5, 3, 5);
            this.SkillTrainingTable.Controls.Add(this.STConsumption5, 2, 5);
            this.SkillTrainingTable.Controls.Add(this.STDataType5, 1, 5);
            this.SkillTrainingTable.Controls.Add(this.label19, 0, 5);
            this.SkillTrainingTable.Controls.Add(this.STTime4, 3, 4);
            this.SkillTrainingTable.Controls.Add(this.STConsumption4, 2, 4);
            this.SkillTrainingTable.Controls.Add(this.STDataType4, 1, 4);
            this.SkillTrainingTable.Controls.Add(this.label15, 0, 4);
            this.SkillTrainingTable.Controls.Add(this.STTime3, 3, 3);
            this.SkillTrainingTable.Controls.Add(this.STConsumption3, 2, 3);
            this.SkillTrainingTable.Controls.Add(this.STDataType3, 1, 3);
            this.SkillTrainingTable.Controls.Add(this.label11, 0, 3);
            this.SkillTrainingTable.Controls.Add(this.STTime2, 3, 2);
            this.SkillTrainingTable.Controls.Add(this.STConsumption2, 2, 2);
            this.SkillTrainingTable.Controls.Add(this.STDataType2, 1, 2);
            this.SkillTrainingTable.Controls.Add(this.label7, 0, 2);
            this.SkillTrainingTable.Controls.Add(this.STTime1, 3, 1);
            this.SkillTrainingTable.Controls.Add(this.STConsumption1, 2, 1);
            this.SkillTrainingTable.Controls.Add(this.STDataType1, 1, 1);
            this.SkillTrainingTable.Controls.Add(this.label3, 0, 1);
            this.SkillTrainingTable.Controls.Add(this.label39, 0, 0);
            this.SkillTrainingTable.Location = new System.Drawing.Point(6, 60);
            this.SkillTrainingTable.Name = "SkillTrainingTable";
            this.SkillTrainingTable.RowCount = 10;
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00315F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999649F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999649F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999649F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999649F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999649F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999649F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999649F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999649F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999649F));
            this.SkillTrainingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SkillTrainingTable.Size = new System.Drawing.Size(188, 248);
            this.SkillTrainingTable.TabIndex = 0;
            // 
            // label42
            // 
            this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label42.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label42.Location = new System.Drawing.Point(150, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(35, 24);
            this.label42.TabIndex = 39;
            this.label42.Text = "시간";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.Location = new System.Drawing.Point(101, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(43, 24);
            this.label41.TabIndex = 38;
            this.label41.Text = "개수";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.Location = new System.Drawing.Point(62, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 24);
            this.label40.TabIndex = 37;
            this.label40.Text = "등급";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STTime9
            // 
            this.STTime9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STTime9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STTime9.Location = new System.Drawing.Point(150, 216);
            this.STTime9.Name = "STTime9";
            this.STTime9.Size = new System.Drawing.Size(35, 32);
            this.STTime9.TabIndex = 35;
            this.STTime9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STConsumption9
            // 
            this.STConsumption9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STConsumption9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STConsumption9.Location = new System.Drawing.Point(101, 216);
            this.STConsumption9.Name = "STConsumption9";
            this.STConsumption9.Size = new System.Drawing.Size(43, 32);
            this.STConsumption9.TabIndex = 34;
            this.STConsumption9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STDataType9
            // 
            this.STDataType9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STDataType9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STDataType9.Location = new System.Drawing.Point(62, 216);
            this.STDataType9.Name = "STDataType9";
            this.STDataType9.Size = new System.Drawing.Size(33, 32);
            this.STDataType9.TabIndex = 33;
            this.STDataType9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Location = new System.Drawing.Point(3, 216);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 32);
            this.label35.TabIndex = 32;
            this.label35.Text = "9 -> 10";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STTime8
            // 
            this.STTime8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STTime8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STTime8.Location = new System.Drawing.Point(150, 192);
            this.STTime8.Name = "STTime8";
            this.STTime8.Size = new System.Drawing.Size(35, 24);
            this.STTime8.TabIndex = 31;
            this.STTime8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STConsumption8
            // 
            this.STConsumption8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STConsumption8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STConsumption8.Location = new System.Drawing.Point(101, 192);
            this.STConsumption8.Name = "STConsumption8";
            this.STConsumption8.Size = new System.Drawing.Size(43, 24);
            this.STConsumption8.TabIndex = 30;
            this.STConsumption8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STDataType8
            // 
            this.STDataType8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STDataType8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STDataType8.Location = new System.Drawing.Point(62, 192);
            this.STDataType8.Name = "STDataType8";
            this.STDataType8.Size = new System.Drawing.Size(33, 24);
            this.STDataType8.TabIndex = 29;
            this.STDataType8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Location = new System.Drawing.Point(3, 192);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 24);
            this.label31.TabIndex = 28;
            this.label31.Text = "8 -> 9";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STTime7
            // 
            this.STTime7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STTime7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STTime7.Location = new System.Drawing.Point(150, 168);
            this.STTime7.Name = "STTime7";
            this.STTime7.Size = new System.Drawing.Size(35, 24);
            this.STTime7.TabIndex = 27;
            this.STTime7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STConsumption7
            // 
            this.STConsumption7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STConsumption7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STConsumption7.Location = new System.Drawing.Point(101, 168);
            this.STConsumption7.Name = "STConsumption7";
            this.STConsumption7.Size = new System.Drawing.Size(43, 24);
            this.STConsumption7.TabIndex = 26;
            this.STConsumption7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STDataType7
            // 
            this.STDataType7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STDataType7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STDataType7.Location = new System.Drawing.Point(62, 168);
            this.STDataType7.Name = "STDataType7";
            this.STDataType7.Size = new System.Drawing.Size(33, 24);
            this.STDataType7.TabIndex = 25;
            this.STDataType7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(3, 168);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 24);
            this.label27.TabIndex = 24;
            this.label27.Text = "7 -> 8";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STTime6
            // 
            this.STTime6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STTime6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STTime6.Location = new System.Drawing.Point(150, 144);
            this.STTime6.Name = "STTime6";
            this.STTime6.Size = new System.Drawing.Size(35, 24);
            this.STTime6.TabIndex = 23;
            this.STTime6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STConsumption6
            // 
            this.STConsumption6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STConsumption6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STConsumption6.Location = new System.Drawing.Point(101, 144);
            this.STConsumption6.Name = "STConsumption6";
            this.STConsumption6.Size = new System.Drawing.Size(43, 24);
            this.STConsumption6.TabIndex = 22;
            this.STConsumption6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STDataType6
            // 
            this.STDataType6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STDataType6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STDataType6.Location = new System.Drawing.Point(62, 144);
            this.STDataType6.Name = "STDataType6";
            this.STDataType6.Size = new System.Drawing.Size(33, 24);
            this.STDataType6.TabIndex = 21;
            this.STDataType6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(3, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 24);
            this.label23.TabIndex = 20;
            this.label23.Text = "6 -> 7";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STTime5
            // 
            this.STTime5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STTime5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STTime5.Location = new System.Drawing.Point(150, 120);
            this.STTime5.Name = "STTime5";
            this.STTime5.Size = new System.Drawing.Size(35, 24);
            this.STTime5.TabIndex = 19;
            this.STTime5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STConsumption5
            // 
            this.STConsumption5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STConsumption5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STConsumption5.Location = new System.Drawing.Point(101, 120);
            this.STConsumption5.Name = "STConsumption5";
            this.STConsumption5.Size = new System.Drawing.Size(43, 24);
            this.STConsumption5.TabIndex = 18;
            this.STConsumption5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STDataType5
            // 
            this.STDataType5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STDataType5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STDataType5.Location = new System.Drawing.Point(62, 120);
            this.STDataType5.Name = "STDataType5";
            this.STDataType5.Size = new System.Drawing.Size(33, 24);
            this.STDataType5.TabIndex = 17;
            this.STDataType5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 24);
            this.label19.TabIndex = 16;
            this.label19.Text = "5 -> 6";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STTime4
            // 
            this.STTime4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STTime4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STTime4.Location = new System.Drawing.Point(150, 96);
            this.STTime4.Name = "STTime4";
            this.STTime4.Size = new System.Drawing.Size(35, 24);
            this.STTime4.TabIndex = 15;
            this.STTime4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STConsumption4
            // 
            this.STConsumption4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STConsumption4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STConsumption4.Location = new System.Drawing.Point(101, 96);
            this.STConsumption4.Name = "STConsumption4";
            this.STConsumption4.Size = new System.Drawing.Size(43, 24);
            this.STConsumption4.TabIndex = 14;
            this.STConsumption4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STDataType4
            // 
            this.STDataType4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STDataType4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STDataType4.Location = new System.Drawing.Point(62, 96);
            this.STDataType4.Name = "STDataType4";
            this.STDataType4.Size = new System.Drawing.Size(33, 24);
            this.STDataType4.TabIndex = 13;
            this.STDataType4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "4 -> 5";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STTime3
            // 
            this.STTime3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STTime3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STTime3.Location = new System.Drawing.Point(150, 72);
            this.STTime3.Name = "STTime3";
            this.STTime3.Size = new System.Drawing.Size(35, 24);
            this.STTime3.TabIndex = 11;
            this.STTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STConsumption3
            // 
            this.STConsumption3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STConsumption3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STConsumption3.Location = new System.Drawing.Point(101, 72);
            this.STConsumption3.Name = "STConsumption3";
            this.STConsumption3.Size = new System.Drawing.Size(43, 24);
            this.STConsumption3.TabIndex = 10;
            this.STConsumption3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STDataType3
            // 
            this.STDataType3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STDataType3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STDataType3.Location = new System.Drawing.Point(62, 72);
            this.STDataType3.Name = "STDataType3";
            this.STDataType3.Size = new System.Drawing.Size(33, 24);
            this.STDataType3.TabIndex = 9;
            this.STDataType3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "3 -> 4";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STTime2
            // 
            this.STTime2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STTime2.Location = new System.Drawing.Point(150, 48);
            this.STTime2.Name = "STTime2";
            this.STTime2.Size = new System.Drawing.Size(35, 24);
            this.STTime2.TabIndex = 7;
            this.STTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STConsumption2
            // 
            this.STConsumption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STConsumption2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STConsumption2.Location = new System.Drawing.Point(101, 48);
            this.STConsumption2.Name = "STConsumption2";
            this.STConsumption2.Size = new System.Drawing.Size(43, 24);
            this.STConsumption2.TabIndex = 6;
            this.STConsumption2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STDataType2
            // 
            this.STDataType2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.STDataType2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STDataType2.Location = new System.Drawing.Point(62, 48);
            this.STDataType2.Name = "STDataType2";
            this.STDataType2.Size = new System.Drawing.Size(33, 24);
            this.STDataType2.TabIndex = 5;
            this.STDataType2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "2 -> 3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STTime1
            // 
            this.STTime1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STTime1.Location = new System.Drawing.Point(150, 24);
            this.STTime1.Name = "STTime1";
            this.STTime1.Size = new System.Drawing.Size(35, 24);
            this.STTime1.TabIndex = 3;
            this.STTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STConsumption1
            // 
            this.STConsumption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STConsumption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STConsumption1.Location = new System.Drawing.Point(101, 24);
            this.STConsumption1.Name = "STConsumption1";
            this.STConsumption1.Size = new System.Drawing.Size(43, 24);
            this.STConsumption1.TabIndex = 2;
            this.STConsumption1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STDataType1
            // 
            this.STDataType1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STDataType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STDataType1.Location = new System.Drawing.Point(62, 24);
            this.STDataType1.Name = "STDataType1";
            this.STDataType1.Size = new System.Drawing.Size(33, 24);
            this.STDataType1.TabIndex = 1;
            this.STDataType1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "1 -> 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.Location = new System.Drawing.Point(3, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 24);
            this.label39.TabIndex = 36;
            this.label39.Text = "레벨";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpItemCalcGroup
            // 
            this.ExpItemCalcGroup.Controls.Add(this.ExpItemCalcModSwitch);
            this.ExpItemCalcGroup.Controls.Add(this.ExpItemCalcApplyVow);
            this.ExpItemCalcGroup.Controls.Add(this.SurplusExpCount);
            this.ExpItemCalcGroup.Controls.Add(this.RequireExpItemCount);
            this.ExpItemCalcGroup.Controls.Add(this.SurplusExpLabel);
            this.ExpItemCalcGroup.Controls.Add(this.RequireExpItemLabel);
            this.ExpItemCalcGroup.Controls.Add(this.label1);
            this.ExpItemCalcGroup.Controls.Add(this.NowExpCount);
            this.ExpItemCalcGroup.Controls.Add(this.NowExpLabel);
            this.ExpItemCalcGroup.Controls.Add(this.ExpEndLevel);
            this.ExpItemCalcGroup.Controls.Add(this.label2);
            this.ExpItemCalcGroup.Controls.Add(this.ExpStartLevel);
            this.ExpItemCalcGroup.Controls.Add(this.ExpLevelLabel);
            this.ExpItemCalcGroup.Location = new System.Drawing.Point(3, 3);
            this.ExpItemCalcGroup.Name = "ExpItemCalcGroup";
            this.ExpItemCalcGroup.Size = new System.Drawing.Size(289, 195);
            this.ExpItemCalcGroup.TabIndex = 0;
            this.ExpItemCalcGroup.TabStop = false;
            this.ExpItemCalcGroup.Text = "작전보고서 계산기";
            // 
            // ExpItemCalcModSwitch
            // 
            this.ExpItemCalcModSwitch.AutoSize = true;
            this.ExpItemCalcModSwitch.Location = new System.Drawing.Point(21, 93);
            this.ExpItemCalcModSwitch.Name = "ExpItemCalcModSwitch";
            this.ExpItemCalcModSwitch.Size = new System.Drawing.Size(104, 16);
            this.ExpItemCalcModSwitch.TabIndex = 13;
            this.ExpItemCalcModSwitch.Text = "개조 모드 적용";
            this.ExpItemCalcModSwitch.UseVisualStyleBackColor = true;
            this.ExpItemCalcModSwitch.CheckedChanged += new System.EventHandler(this.ExpItemCalcModSwitch_CheckedChanged);
            // 
            // ExpItemCalcApplyVow
            // 
            this.ExpItemCalcApplyVow.AutoSize = true;
            this.ExpItemCalcApplyVow.Enabled = false;
            this.ExpItemCalcApplyVow.Location = new System.Drawing.Point(164, 92);
            this.ExpItemCalcApplyVow.Name = "ExpItemCalcApplyVow";
            this.ExpItemCalcApplyVow.Size = new System.Drawing.Size(88, 16);
            this.ExpItemCalcApplyVow.TabIndex = 12;
            this.ExpItemCalcApplyVow.Text = "서약 활성화";
            this.ExpItemCalcApplyVow.UseVisualStyleBackColor = true;
            this.ExpItemCalcApplyVow.Visible = false;
            this.ExpItemCalcApplyVow.CheckedChanged += new System.EventHandler(this.ExpItemCalcApplyVow_CheckedChanged);
            // 
            // SurplusExpCount
            // 
            this.SurplusExpCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SurplusExpCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurplusExpCount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SurplusExpCount.Location = new System.Drawing.Point(150, 164);
            this.SurplusExpCount.Name = "SurplusExpCount";
            this.SurplusExpCount.Size = new System.Drawing.Size(135, 22);
            this.SurplusExpCount.TabIndex = 11;
            this.SurplusExpCount.Text = "0";
            this.SurplusExpCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RequireExpItemCount
            // 
            this.RequireExpItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RequireExpItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RequireExpItemCount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RequireExpItemCount.Location = new System.Drawing.Point(6, 164);
            this.RequireExpItemCount.Name = "RequireExpItemCount";
            this.RequireExpItemCount.Size = new System.Drawing.Size(135, 22);
            this.RequireExpItemCount.TabIndex = 10;
            this.RequireExpItemCount.Text = "0";
            this.RequireExpItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurplusExpLabel
            // 
            this.SurplusExpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SurplusExpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurplusExpLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SurplusExpLabel.Location = new System.Drawing.Point(150, 130);
            this.SurplusExpLabel.Name = "SurplusExpLabel";
            this.SurplusExpLabel.Size = new System.Drawing.Size(135, 25);
            this.SurplusExpLabel.TabIndex = 9;
            this.SurplusExpLabel.Text = "버려지는 경험치";
            this.SurplusExpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RequireExpItemLabel
            // 
            this.RequireExpItemLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RequireExpItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RequireExpItemLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RequireExpItemLabel.Location = new System.Drawing.Point(6, 130);
            this.RequireExpItemLabel.Name = "RequireExpItemLabel";
            this.RequireExpItemLabel.Size = new System.Drawing.Size(135, 25);
            this.RequireExpItemLabel.TabIndex = 8;
            this.RequireExpItemLabel.Text = "필요한 수량";
            this.RequireExpItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(132, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "↓";
            // 
            // NowExpCount
            // 
            this.NowExpCount.Location = new System.Drawing.Point(147, 48);
            this.NowExpCount.Maximum = new decimal(new int[] {
            30283200,
            0,
            0,
            0});
            this.NowExpCount.Name = "NowExpCount";
            this.NowExpCount.Size = new System.Drawing.Size(135, 21);
            this.NowExpCount.TabIndex = 6;
            this.NowExpCount.ValueChanged += new System.EventHandler(this.ExpCalc_ValueChanged);
            // 
            // NowExpLabel
            // 
            this.NowExpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NowExpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NowExpLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowExpLabel.Location = new System.Drawing.Point(147, 17);
            this.NowExpLabel.Name = "NowExpLabel";
            this.NowExpLabel.Size = new System.Drawing.Size(135, 25);
            this.NowExpLabel.TabIndex = 5;
            this.NowExpLabel.Text = "현재 경험치";
            this.NowExpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpEndLevel
            // 
            this.ExpEndLevel.Location = new System.Drawing.Point(90, 48);
            this.ExpEndLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpEndLevel.Name = "ExpEndLevel";
            this.ExpEndLevel.Size = new System.Drawing.Size(51, 21);
            this.ExpEndLevel.TabIndex = 4;
            this.ExpEndLevel.Tag = "EndLevel";
            this.ExpEndLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpEndLevel.ValueChanged += new System.EventHandler(this.ExpCalc_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(63, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "=>";
            // 
            // ExpStartLevel
            // 
            this.ExpStartLevel.Location = new System.Drawing.Point(6, 48);
            this.ExpStartLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpStartLevel.Name = "ExpStartLevel";
            this.ExpStartLevel.Size = new System.Drawing.Size(51, 21);
            this.ExpStartLevel.TabIndex = 2;
            this.ExpStartLevel.Tag = "StartLevel";
            this.ExpStartLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpStartLevel.ValueChanged += new System.EventHandler(this.ExpCalc_ValueChanged);
            // 
            // ExpLevelLabel
            // 
            this.ExpLevelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ExpLevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpLevelLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpLevelLabel.Location = new System.Drawing.Point(6, 17);
            this.ExpLevelLabel.Name = "ExpLevelLabel";
            this.ExpLevelLabel.Size = new System.Drawing.Size(135, 25);
            this.ExpLevelLabel.TabIndex = 1;
            this.ExpLevelLabel.Text = "레벨";
            this.ExpLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramStatusLabel,
            this.DollInfoLoadProcess,
            this.DollInfoLoadSubProgress,
            this.ProgramLoadProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgramStatusLabel
            // 
            this.ProgramStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ProgramStatusLabel.Name = "ProgramStatusLabel";
            this.ProgramStatusLabel.Size = new System.Drawing.Size(78, 17);
            this.ProgramStatusLabel.Text = "GF Supporter";
            // 
            // DollInfoLoadProcess
            // 
            this.DollInfoLoadProcess.Name = "DollInfoLoadProcess";
            this.DollInfoLoadProcess.Size = new System.Drawing.Size(100, 16);
            this.DollInfoLoadProcess.Visible = false;
            // 
            // DollInfoLoadSubProgress
            // 
            this.DollInfoLoadSubProgress.Name = "DollInfoLoadSubProgress";
            this.DollInfoLoadSubProgress.Size = new System.Drawing.Size(100, 16);
            this.DollInfoLoadSubProgress.Visible = false;
            // 
            // ProgramLoadProgress
            // 
            this.ProgramLoadProgress.Name = "ProgramLoadProgress";
            this.ProgramLoadProgress.Size = new System.Drawing.Size(100, 16);
            this.ProgramLoadProgress.Step = 1;
            this.ProgramLoadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgramLoadProgress.Visible = false;
            // 
            // CheckUpdateTimer
            // 
            this.CheckUpdateTimer.Interval = 1000;
            this.CheckUpdateTimer.Tick += new System.EventHandler(this.CheckUpdateTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 프로그램ToolStripMenuItem
            // 
            this.프로그램ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.프로그램ToolStripMenuItem.Name = "프로그램ToolStripMenuItem";
            this.프로그램ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.프로그램ToolStripMenuItem.Text = "프로그램";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.종료ToolStripMenuItem.Text = "종료(&X)";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공지사항ToolStripMenuItem,
            this.사용도움말ToolStripMenuItem,
            this.toolStripSeparator1,
            this.업데이트확인ToolStripMenuItem,
            this.설정SToolStripMenuItem,
            this.toolStripSeparator2,
            this.로그폴더열기ToolStripMenuItem,
            this.피드백보내기FToolStripMenuItem,
            this.toolStripSeparator3,
            this.소녀전선서포터정보ToolStripMenuItem});
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 공지사항ToolStripMenuItem
            // 
            this.공지사항ToolStripMenuItem.Name = "공지사항ToolStripMenuItem";
            this.공지사항ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.공지사항ToolStripMenuItem.Text = "공지사항(&A)";
            this.공지사항ToolStripMenuItem.Click += new System.EventHandler(this.공지사항ToolStripMenuItem_Click);
            // 
            // 사용도움말ToolStripMenuItem
            // 
            this.사용도움말ToolStripMenuItem.Name = "사용도움말ToolStripMenuItem";
            this.사용도움말ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.사용도움말ToolStripMenuItem.Text = "도움말(&H)";
            this.사용도움말ToolStripMenuItem.Click += new System.EventHandler(this.사용도움말ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // 업데이트확인ToolStripMenuItem
            // 
            this.업데이트확인ToolStripMenuItem.Name = "업데이트확인ToolStripMenuItem";
            this.업데이트확인ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.업데이트확인ToolStripMenuItem.Text = "업데이트 확인(&C)";
            this.업데이트확인ToolStripMenuItem.Click += new System.EventHandler(this.업데이트확인ToolStripMenuItem_Click);
            // 
            // 설정SToolStripMenuItem
            // 
            this.설정SToolStripMenuItem.Name = "설정SToolStripMenuItem";
            this.설정SToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.설정SToolStripMenuItem.Text = "설정(&S)";
            this.설정SToolStripMenuItem.Click += new System.EventHandler(this.설정SToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // 로그폴더열기ToolStripMenuItem
            // 
            this.로그폴더열기ToolStripMenuItem.Name = "로그폴더열기ToolStripMenuItem";
            this.로그폴더열기ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.로그폴더열기ToolStripMenuItem.Text = "로그 폴더 열기(&L)";
            this.로그폴더열기ToolStripMenuItem.Click += new System.EventHandler(this.로그폴더열기ToolStripMenuItemClick);
            // 
            // 피드백보내기FToolStripMenuItem
            // 
            this.피드백보내기FToolStripMenuItem.Name = "피드백보내기FToolStripMenuItem";
            this.피드백보내기FToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.피드백보내기FToolStripMenuItem.Text = "피드백 보내기(&F)";
            this.피드백보내기FToolStripMenuItem.Click += new System.EventHandler(this.피드백보내기FToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // 소녀전선서포터정보ToolStripMenuItem
            // 
            this.소녀전선서포터정보ToolStripMenuItem.Name = "소녀전선서포터정보ToolStripMenuItem";
            this.소녀전선서포터정보ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.소녀전선서포터정보ToolStripMenuItem.Text = "소녀전선 서포터 정보(&I)";
            this.소녀전선서포터정보ToolStripMenuItem.Click += new System.EventHandler(this.소녀전선서포터정보ToolStripMenuItem_Click);
            // 
            // EffectToolTip
            // 
            this.EffectToolTip.AutoPopDelay = 10000;
            this.EffectToolTip.InitialDelay = 500;
            this.EffectToolTip.IsBalloon = true;
            this.EffectToolTip.ReshowDelay = 100;
            this.EffectToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.EffectToolTip.ToolTipTitle = "버프 배율";
            // 
            // TypeIconImageList
            // 
            this.TypeIconImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.TypeIconImageList.ImageSize = new System.Drawing.Size(80, 40);
            this.TypeIconImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // EquipmentImageList
            // 
            this.EquipmentImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.EquipmentImageList.ImageSize = new System.Drawing.Size(100, 100);
            this.EquipmentImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FairyImageList
            // 
            this.FairyImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.FairyImageList.ImageSize = new System.Drawing.Size(230, 230);
            this.FairyImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FairySkillIconImageList
            // 
            this.FairySkillIconImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.FairySkillIconImageList.ImageSize = new System.Drawing.Size(128, 128);
            this.FairySkillIconImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // EnemyImageList
            // 
            this.EnemyImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.EnemyImageList.ImageSize = new System.Drawing.Size(256, 256);
            this.EnemyImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // EffectIconList
            // 
            this.EffectIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("EffectIconList.ImageStream")));
            this.EffectIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.EffectIconList.Images.SetKeyName(0, "AC_Icon.png");
            this.EffectIconList.Images.SetKeyName(1, "AM_Icon.png");
            this.EffectIconList.Images.SetKeyName(2, "AS_Icon.png");
            this.EffectIconList.Images.SetKeyName(3, "CR_Icon.png");
            this.EffectIconList.Images.SetKeyName(4, "EV_Icon.png");
            this.EffectIconList.Images.SetKeyName(5, "FR_Icon.png");
            // 
            // GradeImageList
            // 
            this.GradeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.GradeImageList.ImageSize = new System.Drawing.Size(256, 256);
            this.GradeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ModelCountryIcons
            // 
            this.ModelCountryIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ModelCountryIcons.ImageStream")));
            this.ModelCountryIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ModelCountryIcons.Images.SetKeyName(0, "남아프리카 공화국.png");
            this.ModelCountryIcons.Images.SetKeyName(1, "대만.png");
            this.ModelCountryIcons.Images.SetKeyName(2, "독일.png");
            this.ModelCountryIcons.Images.SetKeyName(3, "러시아 제국.png");
            this.ModelCountryIcons.Images.SetKeyName(4, "러시아.png");
            this.ModelCountryIcons.Images.SetKeyName(5, "미국.png");
            this.ModelCountryIcons.Images.SetKeyName(6, "벨기에.png");
            this.ModelCountryIcons.Images.SetKeyName(7, "불가리아.png");
            this.ModelCountryIcons.Images.SetKeyName(8, "브라질.png");
            this.ModelCountryIcons.Images.SetKeyName(9, "세르비아.png");
            this.ModelCountryIcons.Images.SetKeyName(10, "소련.png");
            this.ModelCountryIcons.Images.SetKeyName(11, "스웨덴.png");
            this.ModelCountryIcons.Images.SetKeyName(12, "스위스.png");
            this.ModelCountryIcons.Images.SetKeyName(13, "스페인.png");
            this.ModelCountryIcons.Images.SetKeyName(14, "영국.png");
            this.ModelCountryIcons.Images.SetKeyName(15, "오스트리아.png");
            this.ModelCountryIcons.Images.SetKeyName(16, "이스라엘.png");
            this.ModelCountryIcons.Images.SetKeyName(17, "이탈리아.png");
            this.ModelCountryIcons.Images.SetKeyName(18, "중국.png");
            this.ModelCountryIcons.Images.SetKeyName(19, "체코.png");
            this.ModelCountryIcons.Images.SetKeyName(20, "체코슬로바키아.png");
            this.ModelCountryIcons.Images.SetKeyName(21, "폴란드.png");
            this.ModelCountryIcons.Images.SetKeyName(22, "프랑스.png");
            this.ModelCountryIcons.Images.SetKeyName(23, "핀란드.png");
            this.ModelCountryIcons.Images.SetKeyName(24, "한국.png");
            this.ModelCountryIcons.Images.SetKeyName(25, "헝가리.png");
            // 
            // CountryToolTip
            // 
            this.CountryToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CountryToolTip.ToolTipTitle = "국가 이름";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 657);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "소녀전선 서포터 (Girl\'s FrontierLine Supporter)";
            this.MainTab.ResumeLayout(false);
            this.MD.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.OutputSettingGroup.ResumeLayout(false);
            this.OutputSettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelRestrictOutputMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelRestrictOutputMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeRestrictOutputMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeRestrictOutputMin)).EndInit();
            this.NowResourceSettingGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsNowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodNowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoNowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManPowerNowCount)).EndInit();
            this.MDCalcModeSettingGroup.ResumeLayout(false);
            this.MDCalcModeSettingGroup.PerformLayout();
            this.ExceptResourceSettingGroup.ResumeLayout(false);
            this.ExceptResourceSettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ExtraSettingGroup.ResumeLayout(false);
            this.ExtraSettingGroup.PerformLayout();
            this.ResourceWeightSettingGroup.ResumeLayout(false);
            this.ResourceWeightSettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManPowerWeight)).EndInit();
            this.MDCalculator.ResumeLayout(false);
            this.MDCalcSettingGroup.ResumeLayout(false);
            this.MDCalcSettingGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResourceResultGroup.ResumeLayout(false);
            this.ResourceResultGroup.PerformLayout();
            this.MDListGroup.ResumeLayout(false);
            this.MDList.ResumeLayout(false);
            this.Doll.ResumeLayout(false);
            this.DollSubTab.ResumeLayout(false);
            this.DollDIc.ResumeLayout(false);
            this.DollSearchGroup.ResumeLayout(false);
            this.DollSearchGroup.PerformLayout();
            this.ModSelectorGroup.ResumeLayout(false);
            this.ModSelectorGroup.PerformLayout();
            this.VoiceSelectorGroup.ResumeLayout(false);
            this.VoiceSelectorGroup.PerformLayout();
            this.GradeSelectorGroup.ResumeLayout(false);
            this.GradeSelectorGroup.PerformLayout();
            this.TypeSelectorGroup.ResumeLayout(false);
            this.TypeSelectorGroup.PerformLayout();
            this.DollInfoGroup.ResumeLayout(false);
            this.DollInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DollModelCountryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollTypeImageBox)).EndInit();
            this.DollEffectGroup.ResumeLayout(false);
            this.DollEffectGroup.PerformLayout();
            this.DollEffectFormationTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollEffectFormation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollImageSDBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollImageBox)).EndInit();
            this.EnemyDic.ResumeLayout(false);
            this.EnemyDicEnemySearchGroup.ResumeLayout(false);
            this.EnemyDicEnemySearchGroup.PerformLayout();
            this.EnemyDicEnemyInfoGroup.ResumeLayout(false);
            this.EnemyDicEnemyInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyDicEnemyImage)).EndInit();
            this.FormationSimulator.ResumeLayout(false);
            this.FormationSimulator.PerformLayout();
            this.LevelingCalc.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.LevelingCalcSetMUGroup.ResumeLayout(false);
            this.LevelingCalcETCSetGroup.ResumeLayout(false);
            this.LevelingCalcETCSetGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequireCountPerOnce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequireTimePerOnce)).EndInit();
            this.LevelingCalcTypeSelectorGroup.ResumeLayout(false);
            this.LevelingCalcTypeSelectorGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Doll5.ResumeLayout(false);
            this.Doll5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel5)).EndInit();
            this.Doll4.ResumeLayout(false);
            this.Doll4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel4)).EndInit();
            this.Doll3.ResumeLayout(false);
            this.Doll3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel3)).EndInit();
            this.Doll2.ResumeLayout(false);
            this.Doll2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel2)).EndInit();
            this.Doll1.ResumeLayout(false);
            this.Doll1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DummyCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcNowExp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelingCalcTargetLevel1)).EndInit();
            this.EquipmentTab.ResumeLayout(false);
            this.EquipmentSubTab.ResumeLayout(false);
            this.EquipmentDic.ResumeLayout(false);
            this.EquipmentDicInfoGroup.ResumeLayout(false);
            this.EquipmentDicInfoGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EquipmentDicDollTypeGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeSG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeRF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeSMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDollTypeHG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDicEquipmentImage)).EndInit();
            this.EquipmentDicSearchGroup.ResumeLayout(false);
            this.EquipmentDicSearchGroup.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.EquipmentDicListGroup.ResumeLayout(false);
            this.FreeOperation.ResumeLayout(false);
            this.FreeOPSettingGroup.ResumeLayout(false);
            this.FreeOPSpecialDropSettingGroup.ResumeLayout(false);
            this.FreeOPSpecialDropSettingGroup.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMinLevelUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMaxLevelUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMinMUUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMaxMUUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMinTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeOPMaxTimeUpDown)).EndInit();
            this.FreeOPLocationTypeGroup.ResumeLayout(false);
            this.FreeOPLocationTypeGroup.PerformLayout();
            this.FreeOPListGroup.ResumeLayout(false);
            this.Fairy.ResumeLayout(false);
            this.FairySubTab.ResumeLayout(false);
            this.FairyDic.ResumeLayout(false);
            this.FairyInfoGroup.ResumeLayout(false);
            this.FairyInfoGroup.PerformLayout();
            this.FairySkillInfoGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FairyDicFairySkillIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FairyDicFairyImage)).EndInit();
            this.FairySearchGroup.ResumeLayout(false);
            this.FairySearchGroup.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.FairyListGroup.ResumeLayout(false);
            this.Product.ResumeLayout(false);
            this.ProductSimulationSubTab.ResumeLayout(false);
            this.ProductSimulDoll.ResumeLayout(false);
            this.ProductSimulDoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ProductSimulDollAdvanceProductTypeGroup.ResumeLayout(false);
            this.ProductSimulDollAdvanceProductTypeGroup.PerformLayout();
            this.ProductSimulDollProductTypeGroup.ResumeLayout(false);
            this.ProductSimulDollProductTypeGroup.PerformLayout();
            this.ProductDollResultBackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultDollGradeImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultDollTypeIcon)).EndInit();
            this.ProductDollResultDollDialog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultDollImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDollResultGradeStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulDollPartsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulDollAmmoCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulDollFoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulDollManpowerCount)).EndInit();
            this.ProductSimulEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ProductSimulEquipmentAdvanceProductTypeGroup.ResumeLayout(false);
            this.ProductSimulEquipmentAdvanceProductTypeGroup.PerformLayout();
            this.ProductSimulEquipmentProductTypeGroup.ResumeLayout(false);
            this.ProductSimulEquipmentProductTypeGroup.PerformLayout();
            this.ProductEquipmentResultBackgroundPanel.ResumeLayout(false);
            this.ProductEquipmentResultDialog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulEquipmentPartsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulEquipmentAmmoCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulEquipmentFoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSimulEquipmentManpowerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductEquipmentResultGradeStar1)).EndInit();
            this.MDInfoTab.ResumeLayout(false);
            this.PlaceLoadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlaceLoadImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceLoadImageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceViewerBox)).EndInit();
            this.PlaceViewerSettingGroup.ResumeLayout(false);
            this.PlaceViewerSettingGroup.PerformLayout();
            this.ImageSettingGroup.ResumeLayout(false);
            this.ImageSettingGroup.PerformLayout();
            this.PlaceSettingGroup.ResumeLayout(false);
            this.PlaceSettingGroup.PerformLayout();
            this.ETCTab.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.FRCalcGroup.ResumeLayout(false);
            this.FRCalcGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcSkillEffectFRCount4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcSkillEffectFRCount3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcSkillEffectFRCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcSkillEffectFRCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcFormationEffectFRCount4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcFormationEffectFRCount3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcFormationEffectFRCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcFormationEffectFRCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcItemFRCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCalcDefaultFRCount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndLinkCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartLinkCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.SkillTrainingTable.ResumeLayout(false);
            this.ExpItemCalcGroup.ResumeLayout(false);
            this.ExpItemCalcGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NowExpCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpEndLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpStartLevel)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel SkillTrainingTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label STTime9;
        private System.Windows.Forms.Label STConsumption9;
        private System.Windows.Forms.Label STDataType9;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label STTime8;
        private System.Windows.Forms.Label STConsumption8;
        private System.Windows.Forms.Label STDataType8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label STTime7;
        private System.Windows.Forms.Label STConsumption7;
        private System.Windows.Forms.Label STDataType7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label STTime6;
        private System.Windows.Forms.Label STConsumption6;
        private System.Windows.Forms.Label STDataType6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label STTime5;
        private System.Windows.Forms.Label STConsumption5;
        private System.Windows.Forms.Label STDataType5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label STTime4;
        private System.Windows.Forms.Label STConsumption4;
        private System.Windows.Forms.Label STDataType4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label STTime3;
        private System.Windows.Forms.Label STConsumption3;
        private System.Windows.Forms.Label STDataType3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label STTime2;
        private System.Windows.Forms.Label STConsumption2;
        private System.Windows.Forms.Label STDataType2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label STTime1;
        private System.Windows.Forms.Label STConsumption1;
        private System.Windows.Forms.Label STDataType1;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox LinkCalcGradeSelector;
        private System.Windows.Forms.Label LinkCalcGradeSelectorLabel;
        private System.Windows.Forms.NumericUpDown EndLinkCount;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown StartLinkCount;
        private System.Windows.Forms.Label LinkCalcLinkLabel;
        private System.Windows.Forms.Label RequireCoreCount;
        private System.Windows.Forms.Label RequireCoreLabel;
        private System.Windows.Forms.GroupBox FRCalcGroup;
        private System.Windows.Forms.Label CalcFRCaution;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label FRCalcTotalFRCountLabel;
        private System.Windows.Forms.Label FRCalcTotalFRLabel;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.NumericUpDown FRCalcSkillEffectFRCount4;
        private System.Windows.Forms.NumericUpDown FRCalcSkillEffectFRCount3;
        private System.Windows.Forms.NumericUpDown FRCalcSkillEffectFRCount2;
        private System.Windows.Forms.NumericUpDown FRCalcSkillEffectFRCount1;
        private System.Windows.Forms.Label FRCalcSkillEffectFRCountLabel;
        private System.Windows.Forms.Label FRCalcSkillEffectFRLabel;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown FRCalcFormationEffectFRCount4;
        private System.Windows.Forms.NumericUpDown FRCalcFormationEffectFRCount3;
        private System.Windows.Forms.NumericUpDown FRCalcFormationEffectFRCount2;
        private System.Windows.Forms.NumericUpDown FRCalcFormationEffectFRCount1;
        private System.Windows.Forms.Label FRCalcFormationEffectFRCountLabel;
        private System.Windows.Forms.Label FRCalcFormationEffectFRLabel;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown FRCalcItemFRCount;
        private System.Windows.Forms.Label FRCalcItemFRLabel;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown FRCalcDefaultFRCount;
        private System.Windows.Forms.Label FRCalcDefaultFRLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ProgramStatusLabel;
        private System.Windows.Forms.TableLayoutPanel MDList;
        private System.Windows.Forms.Timer CheckUpdateTimer;
        private System.Windows.Forms.ListView MDListView;
        private System.Windows.Forms.ColumnHeader MDLocation;
        private System.Windows.Forms.ColumnHeader MinLevel;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader MDManPower;
        private System.Windows.Forms.ColumnHeader MDAmmo;
        private System.Windows.Forms.ColumnHeader MDFood;
        private System.Windows.Forms.ColumnHeader MDParts;
        private System.Windows.Forms.ColumnHeader MDAdditional;
        private System.Windows.Forms.TabPage Doll;
        private System.Windows.Forms.GroupBox MDCalcSettingGroup;
        private System.Windows.Forms.RadioButton MDCalcSettingByTime;
        private System.Windows.Forms.RadioButton MDCalcSettingSum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 프로그램ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업데이트확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 소녀전선서포터정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar DollInfoLoadProcess;
        private System.Windows.Forms.ToolStripProgressBar DollInfoLoadSubProgress;
        private System.Windows.Forms.ToolStripMenuItem 공지사항ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip EffectToolTip;
        private System.Windows.Forms.GroupBox FreeOPListGroup;
        private System.Windows.Forms.ListView FreeOPListView;
        private System.Windows.Forms.ColumnHeader FreeOPLocation;
        private System.Windows.Forms.ColumnHeader FreeOPPaneltyLevel;
        private System.Windows.Forms.ColumnHeader FreeOPRequireMU;
        private System.Windows.Forms.ColumnHeader FreeOPTime;
        private System.Windows.Forms.ColumnHeader FreeOPRequireFP;
        private System.Windows.Forms.ColumnHeader FreeOPBaseEXP;
        private System.Windows.Forms.ColumnHeader FreeOPDropCount;
        private System.Windows.Forms.ToolStripProgressBar ProgramLoadProgress;
        private System.Windows.Forms.GroupBox FreeOPSettingGroup;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown FreeOPMaxLevelUpDown;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.NumericUpDown FreeOPMinLevelUpDown;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.NumericUpDown FreeOPMaxTimeUpDown;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.NumericUpDown FreeOPMinTimeUpDown;
        private System.Windows.Forms.NumericUpDown FreeOPMaxMUUpDown;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.NumericUpDown FreeOPMinMUUpDown;
        private System.Windows.Forms.Label FreeOPMaxTimeLabel;
        private System.Windows.Forms.Label FreeOPMinTimeLabel;
        private System.Windows.Forms.Button FreeOPSearchButton;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Button FreeOPSearchResetButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox FreeOPLocationTypeGroup;
        private System.Windows.Forms.CheckBox FreeOPLocationEmergency;
        private System.Windows.Forms.CheckBox FreeOPLocationNight;
        private System.Windows.Forms.CheckBox FreeOPLocationNormal;
        private System.Windows.Forms.ComboBox SkillTrainingTypeSelector;
        private System.Windows.Forms.ColumnHeader FreeOPDollEXP;
        private System.Windows.Forms.ColumnHeader FreeOPDollEXPByTime;
        private System.Windows.Forms.TabPage EquipmentTab;
        private System.Windows.Forms.TabControl EquipmentSubTab;
        private System.Windows.Forms.TabPage EquipmentDic;
        private System.Windows.Forms.GroupBox EquipmentDicListGroup;
        private System.Windows.Forms.ListView EquipmentDicListView;
        private System.Windows.Forms.ColumnHeader EquipmentName;
        private System.Windows.Forms.ColumnHeader EquipmentType;
        private System.Windows.Forms.ColumnHeader EquipmentCategory;
        private System.Windows.Forms.ColumnHeader EquipmentGrade;
        private System.Windows.Forms.ColumnHeader EquipmentProductTime;
        private System.Windows.Forms.GroupBox EquipmentDicSearchGroup;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox EquipmentDicGradeExtra;
        private System.Windows.Forms.CheckBox EquipmentDicGrade5;
        private System.Windows.Forms.CheckBox EquipmentDicGrade4;
        private System.Windows.Forms.CheckBox EquipmentDicGrade3;
        private System.Windows.Forms.CheckBox EquipmentDicGrade2;
        private System.Windows.Forms.TextBox EquipmentDicSearchTextBox;
        private System.Windows.Forms.GroupBox EquipmentDicInfoGroup;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox EquipmentDicCategoryAttachment;
        private System.Windows.Forms.CheckBox EquipmentDicCategoryDoll;
        private System.Windows.Forms.CheckBox EquipmentDicCategoryBullet;
        private System.Windows.Forms.GroupBox EquipmentDicDollTypeGroup;
        private System.Windows.Forms.PictureBox EquipmentDollTypeAR;
        private System.Windows.Forms.PictureBox EquipmentDollTypeSG;
        private System.Windows.Forms.PictureBox EquipmentDollTypeRF;
        private System.Windows.Forms.PictureBox EquipmentDollTypeMG;
        private System.Windows.Forms.PictureBox EquipmentDollTypeSMG;
        private System.Windows.Forms.PictureBox EquipmentDollTypeHG;
        private System.Windows.Forms.PictureBox EquipmentDicEquipmentImage;
        private System.Windows.Forms.Label EquipmentDicProductTime;
        private System.Windows.Forms.Label EquipmentDicName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EquipmentAbility3;
        private System.Windows.Forms.Label EquipmentInitialMagnification3;
        private System.Windows.Forms.Label EquipmentMaxMagnification3;
        private System.Windows.Forms.Label EquipmentMaxMagnification2;
        private System.Windows.Forms.Label EquipmentInitialMagnification2;
        private System.Windows.Forms.Label EquipmentAbility2;
        private System.Windows.Forms.Label EquipmentMaxMagnification1;
        private System.Windows.Forms.Label EquipmentInitialMagnification1;
        private System.Windows.Forms.Label EquipmentAbility1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EquipmentDollTypeOnlyUse;
        private System.Windows.Forms.Label EquipmentAbility4;
        private System.Windows.Forms.Label EquipmentInitialMagnification4;
        private System.Windows.Forms.Label EquipmentMaxMagnification4;
        private System.Windows.Forms.ColumnHeader FreeOPSpecialDrop;
        private System.Windows.Forms.GroupBox FreeOPSpecialDropSettingGroup;
        private System.Windows.Forms.CheckBox FreeOPSpecialDropNoExist;
        private System.Windows.Forms.CheckBox FreeOPSpecialDropExist;
        private System.Windows.Forms.ToolStripMenuItem 사용도움말ToolStripMenuItem;
        private System.Windows.Forms.ImageList EquipmentImageList;
        private System.Windows.Forms.ImageList TypeIconImageList;
        private System.Windows.Forms.Label EquipmentDicNote;
        private System.Windows.Forms.TabPage Fairy;
        private System.Windows.Forms.TabControl FairySubTab;
        private System.Windows.Forms.TabPage FairyDic;
        private System.Windows.Forms.GroupBox FairyListGroup;
        private System.Windows.Forms.ListView FairyDicFairyList;
        private System.Windows.Forms.ColumnHeader FairyName;
        private System.Windows.Forms.ColumnHeader FairyType;
        private System.Windows.Forms.ColumnHeader FairyProductTime;
        private System.Windows.Forms.GroupBox FairySearchGroup;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox FairyDicTypeCombat;
        private System.Windows.Forms.CheckBox FairyDicTypeStrategy;
        private System.Windows.Forms.TextBox FairyDicSearchTextBox;
        private System.Windows.Forms.GroupBox FairyInfoGroup;
        private System.Windows.Forms.ImageList FairyImageList;
        private System.Windows.Forms.PictureBox FairyDicFairyImage;
        private System.Windows.Forms.Label FairyDicFairyACCountLabel;
        private System.Windows.Forms.Label FairyDicFairyEVCountLabel;
        private System.Windows.Forms.Label FairyDicFairyAMCountLabel;
        private System.Windows.Forms.Label FairyDicFairyCRCountLabel;
        private System.Windows.Forms.Label FairyDicFairyFRCountLabel;
        private System.Windows.Forms.ProgressBar FairyDicFairyCRProgress;
        private System.Windows.Forms.ProgressBar FairyDicFairyAMProgress;
        private System.Windows.Forms.ProgressBar FairyDicFairyEVProgress;
        private System.Windows.Forms.ProgressBar FairyDicFairyACProgress;
        private System.Windows.Forms.ProgressBar FairyDicFairyFRProgress;
        private System.Windows.Forms.Label FairyDicFairyCRLabel;
        private System.Windows.Forms.Label FairyDicFairyAMLabel;
        private System.Windows.Forms.Label FairyDicFairyEVLabel;
        private System.Windows.Forms.Label FairyDicFairyACLabel;
        private System.Windows.Forms.Label FairyDicFairyFRLabel;
        private System.Windows.Forms.Label FairyDicFairyName;
        private System.Windows.Forms.GroupBox FairySkillInfoGroup;
        private System.Windows.Forms.Label FairyDicFairySkillEffect;
        private System.Windows.Forms.Label FairyDicFairySkillName;
        private System.Windows.Forms.PictureBox FairyDicFairySkillIcon;
        private System.Windows.Forms.ImageList FairySkillIconImageList;
        private System.Windows.Forms.ToolStripMenuItem 설정SToolStripMenuItem;
        private System.Windows.Forms.Label FairyDicFairySkillExplain;
        private System.Windows.Forms.ColumnHeader FreeOPRequireResource;
        private System.Windows.Forms.Button FairyProductTimeTableButton;
        private System.Windows.Forms.Button EquipmentProductTimeTableButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ImageList EnemyImageList;
        private System.Windows.Forms.ToolStripMenuItem 로그폴더열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList EffectIconList;
        private System.Windows.Forms.ImageList GradeImageList;
        private System.Windows.Forms.TabControl ProductSimulationSubTab;
        private System.Windows.Forms.TabPage ProductSimulDoll;
        private System.Windows.Forms.TabPage ProductSimulEquipment;
        private System.Windows.Forms.NumericUpDown ProductSimulDollPartsCount;
        private System.Windows.Forms.NumericUpDown ProductSimulDollAmmoCount;
        private System.Windows.Forms.NumericUpDown ProductSimulDollFoodCount;
        private System.Windows.Forms.NumericUpDown ProductSimulDollManpowerCount;
        private System.Windows.Forms.Button ProductSimulDollProductButton;
        private System.Windows.Forms.PictureBox ProductDollResultGradeStar5;
        private System.Windows.Forms.PictureBox ProductDollResultGradeStar4;
        private System.Windows.Forms.PictureBox ProductDollResultGradeStar3;
        private System.Windows.Forms.PictureBox ProductDollResultGradeStar2;
        private System.Windows.Forms.PictureBox ProductDollResultGradeStar1;
        private System.Windows.Forms.PictureBox ProductDollResultDollTypeIcon;
        private System.Windows.Forms.PictureBox ProductDollResultDollImageBox;
        private System.Windows.Forms.Label ProductDollResultDollName;
        private System.Windows.Forms.Panel ProductDollResultDollDialog;
        private System.Windows.Forms.Panel ProductDollResultBackgroundPanel;
        private System.Windows.Forms.PictureBox ProductDollResultDollGradeImageBox;
        private System.Windows.Forms.ColumnHeader MDManPowerByTime;
        private System.Windows.Forms.ColumnHeader MDAmmoByTime;
        private System.Windows.Forms.ColumnHeader MDFoodByTime;
        private System.Windows.Forms.ColumnHeader MDPartsByTime;
        private System.Windows.Forms.CheckBox ProductSimulDollVoiceEnableSetting;
        private System.Windows.Forms.GroupBox ProductSimulDollProductTypeGroup;
        private System.Windows.Forms.RadioButton ProductSimulDollProductTypeAdvance;
        private System.Windows.Forms.RadioButton ProductSimulDollProductTypeNormal;
        private System.Windows.Forms.GroupBox ProductSimulDollAdvanceProductTypeGroup;
        private System.Windows.Forms.RadioButton ProductSimulDollAdvanceProductType3;
        private System.Windows.Forms.RadioButton ProductSimulDollAdvanceProductType2;
        private System.Windows.Forms.RadioButton ProductSimulDollAdvanceProductType1;
        private System.Windows.Forms.LinkLabel FairyDicFairyDetailInfoWeb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label DollSimulationUseParts;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label DollSimulationUseFood;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label DollSimulationUseAmmo;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label DollSimulationUseManPower;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button DollSimulationResetUseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label DollSimulation5StarStatus;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label DollSimulation4StarStatus;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label DollSimulation3StarStatus;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label DollSimulation2StarStatus;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TabControl DollSubTab;
        private System.Windows.Forms.TabPage DollDIc;
        private System.Windows.Forms.GroupBox DollSearchGroup;
        private System.Windows.Forms.GroupBox VoiceSelectorGroup;
        private System.Windows.Forms.CheckBox VoiceYes;
        private System.Windows.Forms.CheckBox VoiceNo;
        private System.Windows.Forms.LinkLabel DollDetailInfoWebDDB;
        private System.Windows.Forms.Button DollProductTimeTableButton;
        private System.Windows.Forms.GroupBox GradeSelectorGroup;
        private System.Windows.Forms.CheckBox GradeExtra;
        private System.Windows.Forms.CheckBox Grade5;
        private System.Windows.Forms.CheckBox Grade4;
        private System.Windows.Forms.CheckBox Grade3;
        private System.Windows.Forms.CheckBox Grade2;
        private System.Windows.Forms.GroupBox TypeSelectorGroup;
        private System.Windows.Forms.CheckBox TypeRF;
        private System.Windows.Forms.CheckBox TypeSG;
        private System.Windows.Forms.CheckBox TypeMG;
        private System.Windows.Forms.CheckBox TypeHG;
        private System.Windows.Forms.CheckBox TypeAR;
        private System.Windows.Forms.CheckBox TypeSMG;
        private System.Windows.Forms.ListView DollListView;
        private System.Windows.Forms.ColumnHeader DollName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.ColumnHeader ProductTime;
        private System.Windows.Forms.ColumnHeader HasCostume;
        private System.Windows.Forms.TextBox DollSearchTextBox;
        private System.Windows.Forms.GroupBox DollInfoGroup;
        private System.Windows.Forms.Button DollDropEventInfoButton;
        private System.Windows.Forms.ComboBox DollVoiceList;
        private System.Windows.Forms.Button DollVoicePlayButton;
        private System.Windows.Forms.Label DollBaseDamage;
        private System.Windows.Forms.Label DollReloadTimeLabel;
        private System.Windows.Forms.PictureBox DollTypeImageBox;
        private System.Windows.Forms.Label DollBulletCountLabel;
        private System.Windows.Forms.ProgressBar DollBulletProgress;
        private System.Windows.Forms.Label DollBulletLabel;
        private System.Windows.Forms.Label DollArmorCountLabel;
        private System.Windows.Forms.ProgressBar DollArmorProgress;
        private System.Windows.Forms.Label DollArmorLabel;
        private System.Windows.Forms.GroupBox DollEffectGroup;
        private System.Windows.Forms.Label DollEffectLabel;
        private System.Windows.Forms.Label DollEffectTypeLabel;
        private System.Windows.Forms.TableLayoutPanel DollEffectFormationTable;
        private System.Windows.Forms.PictureBox DollEffectFormation9;
        private System.Windows.Forms.PictureBox DollEffectFormation8;
        private System.Windows.Forms.PictureBox DollEffectFormation7;
        private System.Windows.Forms.PictureBox DollEffectFormation6;
        private System.Windows.Forms.PictureBox DollEffectFormation5;
        private System.Windows.Forms.PictureBox DollEffectFormation4;
        private System.Windows.Forms.PictureBox DollEffectFormation3;
        private System.Windows.Forms.PictureBox DollEffectFormation2;
        private System.Windows.Forms.PictureBox DollEffectFormation1;
        private System.Windows.Forms.Label DollProductTimeLabel;
        private System.Windows.Forms.PictureBox DollImageSDBox;
        private System.Windows.Forms.Label DollFRCountLabel;
        private System.Windows.Forms.Label DollEVCountLabel;
        private System.Windows.Forms.Label DollACCountLabel;
        private System.Windows.Forms.Label DollASCountLabel;
        private System.Windows.Forms.Label DollHPCountLabel;
        private System.Windows.Forms.ProgressBar DollASProgress;
        private System.Windows.Forms.ProgressBar DollACProgress;
        private System.Windows.Forms.ProgressBar DollEVProgress;
        private System.Windows.Forms.ProgressBar DollFRProgress;
        private System.Windows.Forms.ProgressBar DollHPProgress;
        private System.Windows.Forms.Label DollASLabel;
        private System.Windows.Forms.Label DollACLabel;
        private System.Windows.Forms.Label DollEVLabel;
        private System.Windows.Forms.Label DollFRLabel;
        private System.Windows.Forms.Label DollHPLabel;
        private System.Windows.Forms.Label DollNumLabel;
        private System.Windows.Forms.Label DollNameLabel;
        private System.Windows.Forms.PictureBox DollImageBox;
        private System.Windows.Forms.TabPage EnemyDic;
        private System.Windows.Forms.GroupBox EnemyDicEnemySearchGroup;
        private System.Windows.Forms.ListView EnemyDicEnemyListView;
        private System.Windows.Forms.ColumnHeader EnemyName;
        private System.Windows.Forms.ColumnHeader EnemyType;
        private System.Windows.Forms.ColumnHeader EnemyETC;
        private System.Windows.Forms.TextBox EnemyDicEnemySearchTextBox;
        private System.Windows.Forms.GroupBox EnemyDicEnemyInfoGroup;
        private System.Windows.Forms.Label EnemyDicEnemyType;
        private System.Windows.Forms.Label EnemyDicEnemyPTCount;
        private System.Windows.Forms.ProgressBar EnemyDicEnemyPTProgress;
        private System.Windows.Forms.Label EnemyDicEnemyPTLabel;
        private System.Windows.Forms.Label EnemyDicEnemyAMCount;
        private System.Windows.Forms.ProgressBar EnemyDicEnemyAMProgress;
        private System.Windows.Forms.Label EnemyDicEnemyAMLabel;
        private System.Windows.Forms.Label EnemyDicEnemyFRCount;
        private System.Windows.Forms.Label EnemyDicEnemyEVCount;
        private System.Windows.Forms.Label EnemyDicEnemyACCount;
        private System.Windows.Forms.Label EnemyDicEnemyASCount;
        private System.Windows.Forms.Label EnemyDicEnemyHPCount;
        private System.Windows.Forms.ProgressBar EnemyDicEnemyASProgress;
        private System.Windows.Forms.ProgressBar EnemyDicEnemyACProgress;
        private System.Windows.Forms.ProgressBar EnemyDicEnemyEVProgress;
        private System.Windows.Forms.ProgressBar EnemyDicEnemyFRProgress;
        private System.Windows.Forms.ProgressBar EnemyDicEnemyHPProgress;
        private System.Windows.Forms.Label EnemyDicEnemyASLabel;
        private System.Windows.Forms.Label EnemyDicEnemyACLabel;
        private System.Windows.Forms.Label EnemyDicEnemyEVLabel;
        private System.Windows.Forms.Label EnemyDicEnemyFRLabel;
        private System.Windows.Forms.Label EnemyDicEnemyHPLabel;
        private System.Windows.Forms.Label EnemyDicEnemyName;
        private System.Windows.Forms.PictureBox EnemyDicEnemyImage;
        private System.Windows.Forms.TabPage FormationSimulator;
        private System.Windows.Forms.TabPage LevelingCalc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ExpCount_5_Leader_MVP;
        private System.Windows.Forms.Label ExpCount_4_Leader_MVP;
        private System.Windows.Forms.Label ExpCount_3_Leader_MVP;
        private System.Windows.Forms.Label ExpCount_2_Leader_MVP;
        private System.Windows.Forms.Label ExpCount_1_Leader_MVP;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label ExpCount_5_MVP;
        private System.Windows.Forms.Label ExpCount_4_MVP;
        private System.Windows.Forms.Label ExpCount_3_MVP;
        private System.Windows.Forms.Label ExpCount_2_MVP;
        private System.Windows.Forms.Label ExpCount_1_MVP;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label ExpCount_5_Leader;
        private System.Windows.Forms.Label ExpCount_4_Leader;
        private System.Windows.Forms.Label ExpCount_3_Leader;
        private System.Windows.Forms.Label ExpCount_2_Leader;
        private System.Windows.Forms.Label ExpCount_1_Leader;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label ExpCount_5_Normal;
        private System.Windows.Forms.Label ExpCount_4_Normal;
        private System.Windows.Forms.Label ExpCount_3_Normal;
        private System.Windows.Forms.Label ExpCount_2_Normal;
        private System.Windows.Forms.Label ExpCount_1_Normal;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox LevelingCalcSetMUGroup;
        private System.Windows.Forms.Button LevelingCalcCalcButton;
        private System.Windows.Forms.GroupBox LevelingCalcETCSetGroup;
        private System.Windows.Forms.CheckBox AutoAddDummySet;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.NumericUpDown RequireCountPerOnce;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.NumericUpDown RequireTimePerOnce;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.GroupBox LevelingCalcTypeSelectorGroup;
        private System.Windows.Forms.ComboBox RealWarTypeSelector;
        private System.Windows.Forms.ComboBox SimulationTypeSelector;
        private System.Windows.Forms.RadioButton RealWarType;
        private System.Windows.Forms.RadioButton SimulationType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel Doll5;
        private System.Windows.Forms.NumericUpDown DummyCount5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowLevel5;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowExp5;
        private System.Windows.Forms.NumericUpDown LevelingCalcTargetLevel5;
        private System.Windows.Forms.Panel Doll4;
        private System.Windows.Forms.NumericUpDown DummyCount4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowLevel4;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowExp4;
        private System.Windows.Forms.NumericUpDown LevelingCalcTargetLevel4;
        private System.Windows.Forms.Panel Doll3;
        private System.Windows.Forms.NumericUpDown DummyCount3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowLevel3;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowExp3;
        private System.Windows.Forms.NumericUpDown LevelingCalcTargetLevel3;
        private System.Windows.Forms.Panel Doll2;
        private System.Windows.Forms.NumericUpDown DummyCount2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowLevel2;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowExp2;
        private System.Windows.Forms.NumericUpDown LevelingCalcTargetLevel2;
        private System.Windows.Forms.Panel Doll1;
        private System.Windows.Forms.NumericUpDown DummyCount1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowLevel1;
        private System.Windows.Forms.NumericUpDown LevelingCalcNowExp1;
        private System.Windows.Forms.NumericUpDown LevelingCalcTargetLevel1;
        private System.Windows.Forms.CheckBox DollEnabler5;
        private System.Windows.Forms.CheckBox DollEnabler2;
        private System.Windows.Forms.CheckBox DollEnabler3;
        private System.Windows.Forms.CheckBox DollEnabler4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label EquipmentSimulation5StarStatus;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label EquipmentSimulation4StarStatus;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label EquipmentSimulation3StarStatus;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label EquipmentSimulation2StarStatus;
        private System.Windows.Forms.Button EquipmentSimulationResetUseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label EquipmentSimulationUseParts;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label EquipmentSimulationUseFood;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label EquipmentSimulationUseAmmo;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label EquipmentSimulationUseManPower;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.GroupBox ProductSimulEquipmentAdvanceProductTypeGroup;
        private System.Windows.Forms.RadioButton ProductSimulEquipmentAdvanceProductType3;
        private System.Windows.Forms.RadioButton ProductSimulEquipmentAdvanceProductType2;
        private System.Windows.Forms.RadioButton ProductSimulEquipmentAdvanceProductType1;
        private System.Windows.Forms.GroupBox ProductSimulEquipmentProductTypeGroup;
        private System.Windows.Forms.RadioButton ProductSimulEquipmentProductTypeAdvance;
        private System.Windows.Forms.RadioButton ProductSimulEquipmentProductTypeNormal;
        private System.Windows.Forms.Panel ProductEquipmentResultBackgroundPanel;
        private System.Windows.Forms.Panel ProductEquipmentResultDialog;
        private System.Windows.Forms.Label ProductEquipmentResultName;
        private System.Windows.Forms.PictureBox ProductEquipmentResultImageBox;
        private System.Windows.Forms.PictureBox ProductEquipmentResultGradeStar5;
        private System.Windows.Forms.PictureBox ProductEquipmentResultGradeStar4;
        private System.Windows.Forms.PictureBox ProductEquipmentResultGradeStar3;
        private System.Windows.Forms.PictureBox ProductEquipmentResultGradeStar2;
        private System.Windows.Forms.PictureBox ProductEquipmentResultGradeStar1;
        private System.Windows.Forms.Button ProductSimulEquipmentProductButton;
        private System.Windows.Forms.NumericUpDown ProductSimulEquipmentPartsCount;
        private System.Windows.Forms.NumericUpDown ProductSimulEquipmentAmmoCount;
        private System.Windows.Forms.NumericUpDown ProductSimulEquipmentFoodCount;
        private System.Windows.Forms.NumericUpDown ProductSimulEquipmentManpowerCount;
        private System.Windows.Forms.Label EquipmentSimulationFairyStatus;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label ProductEquipmentResultDialogText;
        private System.Windows.Forms.LinkLabel DollDetailInfoWebNamuWiki;
        private System.Windows.Forms.TabPage MDInfoTab;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Button DollSkillInfoButton;
        private System.Windows.Forms.PictureBox PlaceViewerBox;
        private System.Windows.Forms.GroupBox PlaceViewerSettingGroup;
        private System.Windows.Forms.Button ImageLoadButton;
        private System.Windows.Forms.GroupBox PlaceSettingGroup;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.ComboBox PlaceSelector;
        private System.Windows.Forms.GroupBox ImageSettingGroup;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.ComboBox ImageModeSelector;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.PictureBox PlaceLoadImageBox1;
        private System.Windows.Forms.PictureBox PlaceLoadImageBox2;
        private System.Windows.Forms.Panel PlaceLoadPanel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView RankMDListView;
        private System.Windows.Forms.Button PrintRecommendMDButton;
        private System.Windows.Forms.GroupBox ExceptResourceSettingGroup;
        private System.Windows.Forms.CheckBox ExceptPartsSetting;
        private System.Windows.Forms.CheckBox ExceptFoodSetting;
        private System.Windows.Forms.CheckBox ExceptAmmoSetting;
        private System.Windows.Forms.CheckBox ExceptManPowerSetting;
        private System.Windows.Forms.GroupBox ExtraSettingGroup;
        private System.Windows.Forms.CheckBox TokenSetting;
        private System.Windows.Forms.CheckBox DollTicketSetting;
        private System.Windows.Forms.CheckBox EquipTicketSetting;
        private System.Windows.Forms.CheckBox ProductTicketSetting;
        private System.Windows.Forms.CheckBox RecoveryTicketSetting;
        private System.Windows.Forms.GroupBox ResourceWeightSettingGroup;
        private System.Windows.Forms.NumericUpDown PartsWeight;
        private System.Windows.Forms.NumericUpDown FoodWeight;
        private System.Windows.Forms.NumericUpDown AmmoWeight;
        private System.Windows.Forms.NumericUpDown ManPowerWeight;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader Recommend_Place;
        private System.Windows.Forms.ColumnHeader Recommend_MinLevel;
        private System.Windows.Forms.ColumnHeader Recommend_Time;
        private System.Windows.Forms.ColumnHeader Recommend_Resource;
        private System.Windows.Forms.ColumnHeader Recommend_Extra;
        private System.Windows.Forms.ToolStripMenuItem 피드백보내기FToolStripMenuItem;
        private System.Windows.Forms.GroupBox MDCalcModeSettingGroup;
        private System.Windows.Forms.RadioButton PerTimeNo;
        private System.Windows.Forms.RadioButton PerTimeYes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DollModelLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar DollSDImageLoadProgress;
        private System.Windows.Forms.ProgressBar DollImageLoadProcess;
        private System.Windows.Forms.PictureBox DollModelCountryIcon;
        private System.Windows.Forms.ImageList ModelCountryIcons;
        private System.Windows.Forms.ToolTip CountryToolTip;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox NowResourceSettingGroup;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.NumericUpDown PartsNowCount;
        private System.Windows.Forms.NumericUpDown FoodNowCount;
        private System.Windows.Forms.NumericUpDown AmmoNowCount;
        private System.Windows.Forms.NumericUpDown ManPowerNowCount;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label AmmoWeightNow;
        private System.Windows.Forms.Label FoodWeightNow;
        private System.Windows.Forms.Label PartsWeightNow;
        private System.Windows.Forms.Label ManPowerWeightNow;
        private System.Windows.Forms.GroupBox OutputSettingGroup;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.NumericUpDown LevelRestrictOutputMax;
        private System.Windows.Forms.NumericUpDown LevelRestrictOutputMin;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown TimeRestrictOutputMax;
        private System.Windows.Forms.NumericUpDown TimeRestrictOutputMin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label DollModStatus;
        private System.Windows.Forms.Button DollModSelectorNext;
        private System.Windows.Forms.Button DollModSelectorPrevious;
        private System.Windows.Forms.CheckBox ExpItemCalcApplyVow;
        private System.Windows.Forms.CheckBox ExpItemCalcModSwitch;
        private System.Windows.Forms.GroupBox ModSelectorGroup;
        private System.Windows.Forms.CheckBox ModYes;
        private System.Windows.Forms.CheckBox ModNo;
        private System.Windows.Forms.ColumnHeader HasMod;
        private System.Windows.Forms.Button DollAbilityChartButton;
        private System.Windows.Forms.ProgressBar FSimulatorDownloadProgressBar;
        private System.Windows.Forms.Button RunFSimulatorButton;
        private System.Windows.Forms.Label FSimulatorDownloadStatus;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button LoadingComicButton;
        private System.Windows.Forms.Button ReinstallFSimulatorButton;
        private System.Windows.Forms.Button GriffinDailyLifeComicButton;
        private System.Windows.Forms.Button GriffinInformationComicButton;
    }
}
