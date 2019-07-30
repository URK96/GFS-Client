namespace Girls_FrontierLine_Supporter
{
    partial class DollImageView
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
            this.DollImageSelector = new System.Windows.Forms.ComboBox();
            this.DollImageLargeBox = new System.Windows.Forms.PictureBox();
            this.DollImageViewStatus = new System.Windows.Forms.StatusStrip();
            this.DollImageModeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DollImageLoadProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DollImageLargeBox)).BeginInit();
            this.DollImageViewStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // DollImageSelector
            // 
            this.DollImageSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.DollImageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DollImageSelector.FormattingEnabled = true;
            this.DollImageSelector.Location = new System.Drawing.Point(0, 0);
            this.DollImageSelector.Name = "DollImageSelector";
            this.DollImageSelector.Size = new System.Drawing.Size(455, 20);
            this.DollImageSelector.TabIndex = 1;
            this.DollImageSelector.SelectedIndexChanged += new System.EventHandler(this.DollImageSelector_SelectedIndexChanged);
            // 
            // DollImageLargeBox
            // 
            this.DollImageLargeBox.Location = new System.Drawing.Point(0, 26);
            this.DollImageLargeBox.Name = "DollImageLargeBox";
            this.DollImageLargeBox.Size = new System.Drawing.Size(455, 543);
            this.DollImageLargeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DollImageLargeBox.TabIndex = 0;
            this.DollImageLargeBox.TabStop = false;
            this.DollImageLargeBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.DollImageLargeBox_LoadCompleted);
            this.DollImageLargeBox.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DollImageLargeBox_LoadProgressChanged);
            this.DollImageLargeBox.Click += new System.EventHandler(this.DollImageLargeBox_Click);
            // 
            // DollImageViewStatus
            // 
            this.DollImageViewStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DollImageModeLabel});
            this.DollImageViewStatus.Location = new System.Drawing.Point(0, 572);
            this.DollImageViewStatus.Name = "DollImageViewStatus";
            this.DollImageViewStatus.Size = new System.Drawing.Size(455, 22);
            this.DollImageViewStatus.SizingGrip = false;
            this.DollImageViewStatus.TabIndex = 2;
            // 
            // DollImageModeLabel
            // 
            this.DollImageModeLabel.Name = "DollImageModeLabel";
            this.DollImageModeLabel.Size = new System.Drawing.Size(71, 17);
            this.DollImageModeLabel.Text = "이미지 모드";
            // 
            // DollImageLoadProgress
            // 
            this.DollImageLoadProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DollImageLoadProgress.Location = new System.Drawing.Point(0, 562);
            this.DollImageLoadProgress.Name = "DollImageLoadProgress";
            this.DollImageLoadProgress.Size = new System.Drawing.Size(455, 10);
            this.DollImageLoadProgress.TabIndex = 3;
            this.DollImageLoadProgress.Visible = false;
            // 
            // DollImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 594);
            this.Controls.Add(this.DollImageLoadProgress);
            this.Controls.Add(this.DollImageViewStatus);
            this.Controls.Add(this.DollImageSelector);
            this.Controls.Add(this.DollImageLargeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DollImageView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "인형 이미지 뷰어";
            ((System.ComponentModel.ISupportInitialize)(this.DollImageLargeBox)).EndInit();
            this.DollImageViewStatus.ResumeLayout(false);
            this.DollImageViewStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DollImageLargeBox;
        private System.Windows.Forms.ComboBox DollImageSelector;
        private System.Windows.Forms.StatusStrip DollImageViewStatus;
        private System.Windows.Forms.ToolStripStatusLabel DollImageModeLabel;
        private System.Windows.Forms.ProgressBar DollImageLoadProgress;
    }
}