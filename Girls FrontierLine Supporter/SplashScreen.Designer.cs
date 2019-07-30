namespace Girls_FrontierLine_Supporter
{
    partial class SplashScreen
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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SplashCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StatusLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.StatusLabel.Location = new System.Drawing.Point(0, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(870, 28);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "프로그램 기동 중 입니다. 잠시만 기다려 주세요 :)";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(0, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(870, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "이 프로그램은 어떠한 라이센스도 따르지 않으며 자유롭게 배포 && 수정이 가능합니다.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashCloseButton
            // 
            this.SplashCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SplashCloseButton.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.cancel;
            this.SplashCloseButton.Location = new System.Drawing.Point(814, 12);
            this.SplashCloseButton.Name = "SplashCloseButton";
            this.SplashCloseButton.Size = new System.Drawing.Size(44, 30);
            this.SplashCloseButton.TabIndex = 4;
            this.SplashCloseButton.UseVisualStyleBackColor = true;
            this.SplashCloseButton.Click += new System.EventHandler(this.SplashCloseButton_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 502);
            this.Controls.Add(this.SplashCloseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SplashCloseButton;
    }
}