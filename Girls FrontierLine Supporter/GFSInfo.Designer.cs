namespace Girls_FrontierLine_Supporter
{
    partial class GFSInfo
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
            this.InfoTitle = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.DBResetButton = new System.Windows.Forms.Button();
            this.GFSInfoClose = new System.Windows.Forms.Button();
            this.DonateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoTitle
            // 
            this.InfoTitle.BackColor = System.Drawing.Color.Transparent;
            this.InfoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InfoTitle.ForeColor = System.Drawing.Color.Crimson;
            this.InfoTitle.Location = new System.Drawing.Point(0, 0);
            this.InfoTitle.Name = "InfoTitle";
            this.InfoTitle.Size = new System.Drawing.Size(645, 91);
            this.InfoTitle.TabIndex = 0;
            this.InfoTitle.Text = "\r\n\r\n소녀전선 서포터\r\nGFS (Girl\'s FrontierLine Supporter)";
            this.InfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VersionLabel
            // 
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VersionLabel.ForeColor = System.Drawing.Color.Crimson;
            this.VersionLabel.Location = new System.Drawing.Point(0, 91);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(645, 24);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Version";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.SlateBlue;
            this.linkLabel1.Location = new System.Drawing.Point(0, 180);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(645, 23);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "chlwlsgur96@hotmail.com";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Bisque;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(0, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(645, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "# 버그 신고 && 기능 제안 #";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.Color.SlateBlue;
            this.linkLabel2.Location = new System.Drawing.Point(2, 203);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(645, 23);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "제작자 블로그";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Bisque;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // DBResetButton
            // 
            this.DBResetButton.Location = new System.Drawing.Point(283, 313);
            this.DBResetButton.Name = "DBResetButton";
            this.DBResetButton.Size = new System.Drawing.Size(75, 23);
            this.DBResetButton.TabIndex = 5;
            this.DBResetButton.Text = "DB 재설정";
            this.DBResetButton.UseVisualStyleBackColor = true;
            this.DBResetButton.Click += new System.EventHandler(this.DBResetButton_Click);
            // 
            // GFSInfoClose
            // 
            this.GFSInfoClose.BackColor = System.Drawing.Color.Transparent;
            this.GFSInfoClose.BackgroundImage = global::Girls_FrontierLine_Supporter.Properties.Resources.cancel;
            this.GFSInfoClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GFSInfoClose.Location = new System.Drawing.Point(592, 12);
            this.GFSInfoClose.Name = "GFSInfoClose";
            this.GFSInfoClose.Size = new System.Drawing.Size(41, 31);
            this.GFSInfoClose.TabIndex = 6;
            this.GFSInfoClose.UseVisualStyleBackColor = false;
            this.GFSInfoClose.Click += new System.EventHandler(this.GFSInfoClose_Click);
            // 
            // DonateButton
            // 
            this.DonateButton.Location = new System.Drawing.Point(263, 246);
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(114, 23);
            this.DonateButton.TabIndex = 7;
            this.DonateButton.Text = "제작자 후원하기";
            this.DonateButton.UseVisualStyleBackColor = true;
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // GFSInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 348);
            this.Controls.Add(this.DonateButton);
            this.Controls.Add(this.GFSInfoClose);
            this.Controls.Add(this.DBResetButton);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.InfoTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GFSInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GFS 정보";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InfoTitle;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button DBResetButton;
        private System.Windows.Forms.Button GFSInfoClose;
        private System.Windows.Forms.Button DonateButton;
    }
}