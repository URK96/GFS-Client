using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Threading.Tasks;

namespace Girls_FrontierLine_Supporter
{
    public partial class Setting : Form
    {
        RegistryKey GFSSetting = ETC.GFSRegistry.CreateSubKey("Setting");

        public Setting()
        {
            InitializeComponent();

            InitProcess();
        }

        private void InitProcess()
        {
            try
            {
                // General Tab
                // Read Update Group Setting

                RegistryKey UpdateSetting = GFSSetting.CreateSubKey(@"General\Update");

                if ((int)UpdateSetting.GetValue((string)AutoUpdateSetting.Tag, 1) == 1) AutoUpdateSetting.Checked = true;
                else AutoUpdateSetting.Checked = false;

                AutoUpdateIntervalSetting.Value = (int)UpdateSetting.GetValue((string)AutoUpdateIntervalSetting.Tag, 1);

                if ((int)UpdateSetting.GetValue((string)StartCheckUpdateSetting.Tag, 1) == 1) StartCheckUpdateSetting.Checked = true;
                else StartCheckUpdateSetting.Checked = false;

                AutoUpdateSetting_CheckedChanged(AutoUpdateSetting, new EventArgs());

                UpdateSetting.Dispose();

                // Read General Group Setting

                RegistryKey GeneralSetting = GFSSetting.CreateSubKey(@"General\General");

                if ((int)GeneralSetting.GetValue((string)StartUpNotification.Tag, 1) == 1) StartUpNotification.Checked = true;
                else StartUpNotification.Checked = false;

                GeneralSetting.Dispose();


                // Dic Tab
                // Read General SubTab Setting
                // Read ImageLoad Group Setting

                RegistryKey DicGeneralSetting = GFSSetting.CreateSubKey(@"Dic\General");

                ImagePreLoadSetting.SelectedIndex = (int)DicGeneralSetting.GetValue((string)ImagePreLoadSetting.Tag, 1); // 0 is RealTime-Load, 1 is Pre-Load

                DicGeneralSetting.Dispose();


                // Set ToolTIp

                SetToolTipProcess();
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
                Close();
            }
        }

        private void SetToolTipProcess()
        {
            try
            {
                // General Tab ToolTip

                SettingToolTip.SetToolTip(AutoUpdateSetting, "자동 업데이트를 활성화/비활성화 합니다.");
                SettingToolTip.SetToolTip(AutoUpdateIntervalSetting, "자동 업데이트의 주기를 설정합니다.");
                SettingToolTip.SetToolTip(StartCheckUpdateSetting, "프로그램 기동 시 업데이트 확인을 활성화/비활성화 합니다.");
                SettingToolTip.SetToolTip(StartUpNotification, "프로그램 기동 시 공지사항 표시를 활성화/비활성화 합니다.");

                // Dic Tab ToolTip
                // General SubTab ToolTip

                SettingToolTip.SetToolTip(ImagePreLoadLabel, "인형도감을 제외한 나머지 도감의 이미지 로드 방식을 결정합니다.");
                SettingToolTip.SetToolTip(ImagePreLoadSetting, "Realtime-Load : 파일 직접 로드 (기동 시 메모리 작음. 메모리 증감량 약간 커짐)\nPre-Load : 기동 시 미리 로드 (기동 시 메모리 큼. 메모리 증감량 작음)");
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void AutoUpdateSetting_CheckedChanged(object sender, EventArgs e)
        {
            Control[] subControls = { AutoUpdateIntervalLabel, AutoUpdateIntervalSetting, label1, StartCheckUpdateSetting };
            CheckBox cb = (CheckBox)sender;

            bool IsEnable = true;

            if (cb.Checked == true) IsEnable = true;
            else IsEnable = false;

            foreach (Control c in subControls) c.Enabled = IsEnable;
        }

        private void CancelSettingButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplySettingButton_Click(object sender, EventArgs e)
        {
            try
            {
                // General Tab
                // Set Update Setting

                RegistryKey UpdateSetting = GFSSetting.CreateSubKey(@"General\Update");

                if (AutoUpdateSetting.Checked == true) UpdateSetting.SetValue((string)AutoUpdateSetting.Tag, 1, RegistryValueKind.DWord);
                else UpdateSetting.SetValue((string)AutoUpdateSetting.Tag, 0, RegistryValueKind.DWord);

                UpdateSetting.SetValue((string)AutoUpdateIntervalSetting.Tag, Convert.ToInt32(AutoUpdateIntervalSetting.Value), RegistryValueKind.DWord);

                if (StartCheckUpdateSetting.Checked == true) UpdateSetting.SetValue((string)StartCheckUpdateSetting.Tag, 1, RegistryValueKind.DWord);
                else UpdateSetting.SetValue((string)StartCheckUpdateSetting.Tag, 0, RegistryValueKind.DWord);

                UpdateSetting.Dispose();

                // Set General Setting

                RegistryKey GeneralSetting = GFSSetting.CreateSubKey(@"General\General");

                if (StartUpNotification.Checked == true) GeneralSetting.SetValue((string)StartUpNotification.Tag, 1, RegistryValueKind.DWord);
                else GeneralSetting.SetValue((string)StartUpNotification.Tag, 0, RegistryValueKind.DWord);

                GeneralSetting.Dispose();


                // Dic Tab
                // Set General Setting
                // Set ImageLoad Group Setting

                RegistryKey DicGeneralSetting = GFSSetting.CreateSubKey(@"Dic\General");

                DicGeneralSetting.SetValue((string)ImagePreLoadSetting.Tag, ImagePreLoadSetting.SelectedIndex, RegistryValueKind.DWord);

                DicGeneralSetting.Dispose();




                Close();
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }
    }
}
