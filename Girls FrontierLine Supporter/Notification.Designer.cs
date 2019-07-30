namespace Girls_FrontierLine_Supporter
{
    partial class Notification
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
            this.NotificationBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NotificationCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificationBox
            // 
            this.NotificationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotificationBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NotificationBox.Font = new System.Drawing.Font("HY얕은샘물M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NotificationBox.Location = new System.Drawing.Point(0, 200);
            this.NotificationBox.Name = "NotificationBox";
            this.NotificationBox.ReadOnly = true;
            this.NotificationBox.Size = new System.Drawing.Size(668, 368);
            this.NotificationBox.TabIndex = 1;
            this.NotificationBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.notification_banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // NotificationCloseButton
            // 
            this.NotificationCloseButton.Image = global::Girls_FrontierLine_Supporter.Properties.Resources.cancel;
            this.NotificationCloseButton.Location = new System.Drawing.Point(612, 12);
            this.NotificationCloseButton.Name = "NotificationCloseButton";
            this.NotificationCloseButton.Size = new System.Drawing.Size(44, 30);
            this.NotificationCloseButton.TabIndex = 3;
            this.NotificationCloseButton.UseVisualStyleBackColor = true;
            this.NotificationCloseButton.Click += new System.EventHandler(this.NotificationCloseButton_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 568);
            this.Controls.Add(this.NotificationCloseButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NotificationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "공지사항";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NotificationBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NotificationCloseButton;
    }
}