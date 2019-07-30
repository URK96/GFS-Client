namespace Girls_FrontierLine_Updater
{
    partial class Updater
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.UpdaterStatusLabel = new System.Windows.Forms.Label();
            this.UpdaterSubStatusLabel = new System.Windows.Forms.Label();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.Title = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UpdaterVersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdaterStatusLabel
            // 
            this.UpdaterStatusLabel.AutoSize = true;
            this.UpdaterStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdaterStatusLabel.ForeColor = System.Drawing.Color.White;
            this.UpdaterStatusLabel.Location = new System.Drawing.Point(25, 226);
            this.UpdaterStatusLabel.Name = "UpdaterStatusLabel";
            this.UpdaterStatusLabel.Size = new System.Drawing.Size(72, 12);
            this.UpdaterStatusLabel.TabIndex = 0;
            this.UpdaterStatusLabel.Text = "Main Status";
            // 
            // UpdaterSubStatusLabel
            // 
            this.UpdaterSubStatusLabel.AutoSize = true;
            this.UpdaterSubStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdaterSubStatusLabel.ForeColor = System.Drawing.Color.White;
            this.UpdaterSubStatusLabel.Location = new System.Drawing.Point(360, 235);
            this.UpdaterSubStatusLabel.Name = "UpdaterSubStatusLabel";
            this.UpdaterSubStatusLabel.Size = new System.Drawing.Size(66, 12);
            this.UpdaterSubStatusLabel.TabIndex = 1;
            this.UpdaterSubStatusLabel.Text = "Sub Status";
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownloadProgressBar.Location = new System.Drawing.Point(0, 357);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(665, 14);
            this.DownloadProgressBar.TabIndex = 2;
            this.DownloadProgressBar.Visible = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Title.Location = new System.Drawing.Point(234, 132);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(169, 31);
            this.Title.TabIndex = 3;
            this.Title.Text = "서포터 업데이터";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = global::Girls_FrontierLine_Updater.Properties.Resources.cancel;
            this.CloseButton.Location = new System.Drawing.Point(615, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 31);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UpdaterVersionLabel
            // 
            this.UpdaterVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdaterVersionLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdaterVersionLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UpdaterVersionLabel.Location = new System.Drawing.Point(457, 198);
            this.UpdaterVersionLabel.Name = "UpdaterVersionLabel";
            this.UpdaterVersionLabel.Size = new System.Drawing.Size(185, 24);
            this.UpdaterVersionLabel.TabIndex = 5;
            this.UpdaterVersionLabel.Text = "Version";
            this.UpdaterVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Girls_FrontierLine_Updater.Properties.Resources.Updater_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 371);
            this.Controls.Add(this.UpdaterVersionLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DownloadProgressBar);
            this.Controls.Add(this.UpdaterSubStatusLabel);
            this.Controls.Add(this.UpdaterStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Girl\'s FrontierLine Supporter Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdaterStatusLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseButton;
        internal System.Windows.Forms.ProgressBar DownloadProgressBar;
        internal System.Windows.Forms.Label UpdaterSubStatusLabel;
        private System.Windows.Forms.Label UpdaterVersionLabel;
    }
}

