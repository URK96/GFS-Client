/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: Cyber
 * 날짜: 2017-10-13
 * 시간: 오후 7:25
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
namespace Girls_FrontierLine_Client_Updater
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ProgressBar UpdateStatusProgress;
		private System.Windows.Forms.Label UpdateStatusLabel;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UpdateStatusProgress = new System.Windows.Forms.ProgressBar();
            this.UpdateStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateStatusProgress
            // 
            this.UpdateStatusProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpdateStatusProgress.Location = new System.Drawing.Point(0, 36);
            this.UpdateStatusProgress.MarqueeAnimationSpeed = 20;
            this.UpdateStatusProgress.Name = "UpdateStatusProgress";
            this.UpdateStatusProgress.Size = new System.Drawing.Size(459, 12);
            this.UpdateStatusProgress.Step = 1;
            this.UpdateStatusProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.UpdateStatusProgress.TabIndex = 0;
            this.UpdateStatusProgress.Visible = false;
            // 
            // UpdateStatusLabel
            // 
            this.UpdateStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdateStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.UpdateStatusLabel.Name = "UpdateStatusLabel";
            this.UpdateStatusLabel.Size = new System.Drawing.Size(459, 33);
            this.UpdateStatusLabel.TabIndex = 1;
            this.UpdateStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 48);
            this.Controls.Add(this.UpdateStatusLabel);
            this.Controls.Add(this.UpdateStatusProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GFS 클라이언트 업데이터";
            this.ResumeLayout(false);

		}
	}
}
