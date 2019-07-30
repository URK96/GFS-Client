namespace Girls_FrontierLine_Supporter
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Setting_General = new System.Windows.Forms.TabPage();
            this.Setting_General_General = new System.Windows.Forms.GroupBox();
            this.StartUpNotification = new System.Windows.Forms.CheckBox();
            this.Setting_General_Update = new System.Windows.Forms.GroupBox();
            this.StartCheckUpdateSetting = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoUpdateIntervalSetting = new System.Windows.Forms.NumericUpDown();
            this.AutoUpdateIntervalLabel = new System.Windows.Forms.Label();
            this.AutoUpdateSetting = new System.Windows.Forms.CheckBox();
            this.Setting_Dic = new System.Windows.Forms.TabPage();
            this.Setting_DicSubTab = new System.Windows.Forms.TabControl();
            this.Setting_Dic_General = new System.Windows.Forms.TabPage();
            this.Setting_Dic_General_Image = new System.Windows.Forms.GroupBox();
            this.ImagePreLoadSetting = new System.Windows.Forms.ComboBox();
            this.ImagePreLoadLabel = new System.Windows.Forms.Label();
            this.ApplySettingButton = new System.Windows.Forms.Button();
            this.CancelSettingButton = new System.Windows.Forms.Button();
            this.SettingToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.Setting_General.SuspendLayout();
            this.Setting_General_General.SuspendLayout();
            this.Setting_General_Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoUpdateIntervalSetting)).BeginInit();
            this.Setting_Dic.SuspendLayout();
            this.Setting_DicSubTab.SuspendLayout();
            this.Setting_Dic_General.SuspendLayout();
            this.Setting_Dic_General_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Setting_General);
            this.tabControl1.Controls.Add(this.Setting_Dic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // Setting_General
            // 
            this.Setting_General.Controls.Add(this.Setting_General_General);
            this.Setting_General.Controls.Add(this.Setting_General_Update);
            this.Setting_General.Location = new System.Drawing.Point(4, 22);
            this.Setting_General.Name = "Setting_General";
            this.Setting_General.Padding = new System.Windows.Forms.Padding(3);
            this.Setting_General.Size = new System.Drawing.Size(404, 481);
            this.Setting_General.TabIndex = 0;
            this.Setting_General.Text = "일반";
            this.Setting_General.UseVisualStyleBackColor = true;
            // 
            // Setting_General_General
            // 
            this.Setting_General_General.Controls.Add(this.StartUpNotification);
            this.Setting_General_General.Location = new System.Drawing.Point(6, 106);
            this.Setting_General_General.Name = "Setting_General_General";
            this.Setting_General_General.Size = new System.Drawing.Size(392, 50);
            this.Setting_General_General.TabIndex = 1;
            this.Setting_General_General.TabStop = false;
            this.Setting_General_General.Text = "일반";
            // 
            // StartUpNotification
            // 
            this.StartUpNotification.AutoSize = true;
            this.StartUpNotification.Checked = true;
            this.StartUpNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StartUpNotification.Location = new System.Drawing.Point(7, 20);
            this.StartUpNotification.Name = "StartUpNotification";
            this.StartUpNotification.Size = new System.Drawing.Size(196, 16);
            this.StartUpNotification.TabIndex = 0;
            this.StartUpNotification.Tag = "StartUpNotification";
            this.StartUpNotification.Text = "프로그램 시작 시 공지사항 표시";
            this.StartUpNotification.UseVisualStyleBackColor = true;
            // 
            // Setting_General_Update
            // 
            this.Setting_General_Update.Controls.Add(this.StartCheckUpdateSetting);
            this.Setting_General_Update.Controls.Add(this.label1);
            this.Setting_General_Update.Controls.Add(this.AutoUpdateIntervalSetting);
            this.Setting_General_Update.Controls.Add(this.AutoUpdateIntervalLabel);
            this.Setting_General_Update.Controls.Add(this.AutoUpdateSetting);
            this.Setting_General_Update.Location = new System.Drawing.Point(6, 6);
            this.Setting_General_Update.Name = "Setting_General_Update";
            this.Setting_General_Update.Size = new System.Drawing.Size(392, 94);
            this.Setting_General_Update.TabIndex = 0;
            this.Setting_General_Update.TabStop = false;
            this.Setting_General_Update.Text = "업데이트";
            // 
            // StartCheckUpdateSetting
            // 
            this.StartCheckUpdateSetting.AutoSize = true;
            this.StartCheckUpdateSetting.Checked = true;
            this.StartCheckUpdateSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StartCheckUpdateSetting.Location = new System.Drawing.Point(32, 66);
            this.StartCheckUpdateSetting.Name = "StartCheckUpdateSetting";
            this.StartCheckUpdateSetting.Size = new System.Drawing.Size(236, 16);
            this.StartCheckUpdateSetting.TabIndex = 4;
            this.StartCheckUpdateSetting.Tag = "StartCheckUpdate";
            this.StartCheckUpdateSetting.Text = "프로그램 실행 시 바로 업데이트를 확인";
            this.StartCheckUpdateSetting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "시간";
            // 
            // AutoUpdateIntervalSetting
            // 
            this.AutoUpdateIntervalSetting.Location = new System.Drawing.Point(152, 39);
            this.AutoUpdateIntervalSetting.Name = "AutoUpdateIntervalSetting";
            this.AutoUpdateIntervalSetting.Size = new System.Drawing.Size(59, 21);
            this.AutoUpdateIntervalSetting.TabIndex = 2;
            this.AutoUpdateIntervalSetting.Tag = "AutoUpdateInterval";
            // 
            // AutoUpdateIntervalLabel
            // 
            this.AutoUpdateIntervalLabel.AutoSize = true;
            this.AutoUpdateIntervalLabel.Location = new System.Drawing.Point(30, 44);
            this.AutoUpdateIntervalLabel.Name = "AutoUpdateIntervalLabel";
            this.AutoUpdateIntervalLabel.Size = new System.Drawing.Size(121, 12);
            this.AutoUpdateIntervalLabel.TabIndex = 1;
            this.AutoUpdateIntervalLabel.Text = "업데이트 확인 간격 : ";
            // 
            // AutoUpdateSetting
            // 
            this.AutoUpdateSetting.AutoSize = true;
            this.AutoUpdateSetting.Checked = true;
            this.AutoUpdateSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoUpdateSetting.Location = new System.Drawing.Point(7, 21);
            this.AutoUpdateSetting.Name = "AutoUpdateSetting";
            this.AutoUpdateSetting.Size = new System.Drawing.Size(164, 16);
            this.AutoUpdateSetting.TabIndex = 0;
            this.AutoUpdateSetting.Tag = "AutoUpdate";
            this.AutoUpdateSetting.Text = "자동으로 업데이트를 체크";
            this.AutoUpdateSetting.UseVisualStyleBackColor = true;
            this.AutoUpdateSetting.CheckedChanged += new System.EventHandler(this.AutoUpdateSetting_CheckedChanged);
            // 
            // Setting_Dic
            // 
            this.Setting_Dic.Controls.Add(this.Setting_DicSubTab);
            this.Setting_Dic.Location = new System.Drawing.Point(4, 22);
            this.Setting_Dic.Name = "Setting_Dic";
            this.Setting_Dic.Size = new System.Drawing.Size(404, 481);
            this.Setting_Dic.TabIndex = 1;
            this.Setting_Dic.Text = "도감";
            this.Setting_Dic.UseVisualStyleBackColor = true;
            // 
            // Setting_DicSubTab
            // 
            this.Setting_DicSubTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Setting_DicSubTab.Controls.Add(this.Setting_Dic_General);
            this.Setting_DicSubTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_DicSubTab.Location = new System.Drawing.Point(0, 0);
            this.Setting_DicSubTab.Multiline = true;
            this.Setting_DicSubTab.Name = "Setting_DicSubTab";
            this.Setting_DicSubTab.SelectedIndex = 0;
            this.Setting_DicSubTab.Size = new System.Drawing.Size(404, 481);
            this.Setting_DicSubTab.TabIndex = 0;
            // 
            // Setting_Dic_General
            // 
            this.Setting_Dic_General.Controls.Add(this.Setting_Dic_General_Image);
            this.Setting_Dic_General.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Setting_Dic_General.Location = new System.Drawing.Point(22, 4);
            this.Setting_Dic_General.Name = "Setting_Dic_General";
            this.Setting_Dic_General.Padding = new System.Windows.Forms.Padding(3);
            this.Setting_Dic_General.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Setting_Dic_General.Size = new System.Drawing.Size(378, 473);
            this.Setting_Dic_General.TabIndex = 0;
            this.Setting_Dic_General.Text = "일반";
            this.Setting_Dic_General.UseVisualStyleBackColor = true;
            // 
            // Setting_Dic_General_Image
            // 
            this.Setting_Dic_General_Image.Controls.Add(this.ImagePreLoadSetting);
            this.Setting_Dic_General_Image.Controls.Add(this.ImagePreLoadLabel);
            this.Setting_Dic_General_Image.Location = new System.Drawing.Point(6, 6);
            this.Setting_Dic_General_Image.Name = "Setting_Dic_General_Image";
            this.Setting_Dic_General_Image.Size = new System.Drawing.Size(366, 54);
            this.Setting_Dic_General_Image.TabIndex = 0;
            this.Setting_Dic_General_Image.TabStop = false;
            this.Setting_Dic_General_Image.Text = "도감 이미지";
            // 
            // ImagePreLoadSetting
            // 
            this.ImagePreLoadSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImagePreLoadSetting.FormattingEnabled = true;
            this.ImagePreLoadSetting.Items.AddRange(new object[] {
            "Realtime-Load",
            "Pre-Load"});
            this.ImagePreLoadSetting.Location = new System.Drawing.Point(229, 20);
            this.ImagePreLoadSetting.Name = "ImagePreLoadSetting";
            this.ImagePreLoadSetting.Size = new System.Drawing.Size(131, 20);
            this.ImagePreLoadSetting.TabIndex = 1;
            this.ImagePreLoadSetting.Tag = "ImagePreLoad";
            // 
            // ImagePreLoadLabel
            // 
            this.ImagePreLoadLabel.AutoSize = true;
            this.ImagePreLoadLabel.Location = new System.Drawing.Point(6, 26);
            this.ImagePreLoadLabel.Name = "ImagePreLoadLabel";
            this.ImagePreLoadLabel.Size = new System.Drawing.Size(187, 12);
            this.ImagePreLoadLabel.TabIndex = 0;
            this.ImagePreLoadLabel.Text = "이미지 로드 방식 (인형도감 제외)";
            // 
            // ApplySettingButton
            // 
            this.ApplySettingButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ApplySettingButton.Location = new System.Drawing.Point(0, 507);
            this.ApplySettingButton.Name = "ApplySettingButton";
            this.ApplySettingButton.Size = new System.Drawing.Size(255, 34);
            this.ApplySettingButton.TabIndex = 1;
            this.ApplySettingButton.Text = "확인 및 적용";
            this.ApplySettingButton.UseVisualStyleBackColor = true;
            this.ApplySettingButton.Click += new System.EventHandler(this.ApplySettingButton_Click);
            // 
            // CancelSettingButton
            // 
            this.CancelSettingButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelSettingButton.Location = new System.Drawing.Point(261, 507);
            this.CancelSettingButton.Name = "CancelSettingButton";
            this.CancelSettingButton.Size = new System.Drawing.Size(151, 34);
            this.CancelSettingButton.TabIndex = 2;
            this.CancelSettingButton.Text = "취소";
            this.CancelSettingButton.UseVisualStyleBackColor = true;
            this.CancelSettingButton.Click += new System.EventHandler(this.CancelSettingButton_Click);
            // 
            // SettingToolTip
            // 
            this.SettingToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 541);
            this.Controls.Add(this.CancelSettingButton);
            this.Controls.Add(this.ApplySettingButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GFS 설정";
            this.tabControl1.ResumeLayout(false);
            this.Setting_General.ResumeLayout(false);
            this.Setting_General_General.ResumeLayout(false);
            this.Setting_General_General.PerformLayout();
            this.Setting_General_Update.ResumeLayout(false);
            this.Setting_General_Update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoUpdateIntervalSetting)).EndInit();
            this.Setting_Dic.ResumeLayout(false);
            this.Setting_DicSubTab.ResumeLayout(false);
            this.Setting_Dic_General.ResumeLayout(false);
            this.Setting_Dic_General_Image.ResumeLayout(false);
            this.Setting_Dic_General_Image.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Setting_General;
        private System.Windows.Forms.GroupBox Setting_General_Update;
        private System.Windows.Forms.CheckBox StartCheckUpdateSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AutoUpdateIntervalSetting;
        private System.Windows.Forms.Label AutoUpdateIntervalLabel;
        private System.Windows.Forms.CheckBox AutoUpdateSetting;
        private System.Windows.Forms.Button ApplySettingButton;
        private System.Windows.Forms.Button CancelSettingButton;
        private System.Windows.Forms.GroupBox Setting_General_General;
        private System.Windows.Forms.CheckBox StartUpNotification;
        private System.Windows.Forms.TabPage Setting_Dic;
        private System.Windows.Forms.TabControl Setting_DicSubTab;
        private System.Windows.Forms.TabPage Setting_Dic_General;
        private System.Windows.Forms.GroupBox Setting_Dic_General_Image;
        private System.Windows.Forms.ComboBox ImagePreLoadSetting;
        private System.Windows.Forms.Label ImagePreLoadLabel;
        private System.Windows.Forms.ToolTip SettingToolTip;
    }
}