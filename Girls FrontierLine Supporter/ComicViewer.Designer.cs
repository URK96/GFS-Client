namespace Girls_FrontierLine_Supporter
{
    partial class ComicViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComicViewer));
            this.ComicImageLoadProgress = new System.Windows.Forms.ProgressBar();
            this.ComicViewerComicBox = new System.Windows.Forms.PictureBox();
            this.ComicViewerComicList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComicViewerComicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ComicImageLoadProgress
            // 
            this.ComicImageLoadProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComicImageLoadProgress.Location = new System.Drawing.Point(0, 491);
            this.ComicImageLoadProgress.Name = "ComicImageLoadProgress";
            this.ComicImageLoadProgress.Size = new System.Drawing.Size(944, 10);
            this.ComicImageLoadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ComicImageLoadProgress.TabIndex = 0;
            this.ComicImageLoadProgress.Visible = false;
            // 
            // ComicViewerComicBox
            // 
            this.ComicViewerComicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComicViewerComicBox.Location = new System.Drawing.Point(0, 26);
            this.ComicViewerComicBox.Name = "ComicViewerComicBox";
            this.ComicViewerComicBox.Size = new System.Drawing.Size(944, 463);
            this.ComicViewerComicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComicViewerComicBox.TabIndex = 1;
            this.ComicViewerComicBox.TabStop = false;
            this.ComicViewerComicBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.ComicViewerComicBox_LoadCompleted);
            this.ComicViewerComicBox.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ComicViewerComicBox_LoadProgressChanged);
            // 
            // ComicViewerComicList
            // 
            this.ComicViewerComicList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComicViewerComicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComicViewerComicList.FormattingEnabled = true;
            this.ComicViewerComicList.Location = new System.Drawing.Point(0, 0);
            this.ComicViewerComicList.Name = "ComicViewerComicList";
            this.ComicViewerComicList.Size = new System.Drawing.Size(944, 20);
            this.ComicViewerComicList.TabIndex = 5;
            this.ComicViewerComicList.SelectedIndexChanged += new System.EventHandler(this.ComicViewerComicList_SelectedIndexChanged);
            // 
            // ComicViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.ComicViewerComicList);
            this.Controls.Add(this.ComicViewerComicBox);
            this.Controls.Add(this.ComicImageLoadProgress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ComicViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComicViewer";
            ((System.ComponentModel.ISupportInitialize)(this.ComicViewerComicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ComicImageLoadProgress;
        private System.Windows.Forms.PictureBox ComicViewerComicBox;
        private System.Windows.Forms.ComboBox ComicViewerComicList;
    }
}