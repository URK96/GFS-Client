namespace Girls_FrontierLine_Supporter
{
    partial class ProductTimeTable
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
            this.ProductTimeListView = new System.Windows.Forms.ListView();
            this.ProductTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ProductTimeListView
            // 
            this.ProductTimeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductTime,
            this.ProductItem});
            this.ProductTimeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductTimeListView.FullRowSelect = true;
            this.ProductTimeListView.GridLines = true;
            this.ProductTimeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProductTimeListView.Location = new System.Drawing.Point(0, 0);
            this.ProductTimeListView.Name = "ProductTimeListView";
            this.ProductTimeListView.Size = new System.Drawing.Size(369, 450);
            this.ProductTimeListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ProductTimeListView.TabIndex = 0;
            this.ProductTimeListView.UseCompatibleStateImageBehavior = false;
            this.ProductTimeListView.View = System.Windows.Forms.View.Details;
            // 
            // ProductTime
            // 
            this.ProductTime.Tag = "Time";
            this.ProductTime.Text = "제조 시간";
            this.ProductTime.Width = 85;
            // 
            // ProductItem
            // 
            this.ProductItem.Text = "제조 항목";
            this.ProductItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductItem.Width = 250;
            // 
            // ProductTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.ProductTimeListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductTimeTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProductTimeListView;
        private System.Windows.Forms.ColumnHeader ProductTime;
        private System.Windows.Forms.ColumnHeader ProductItem;
    }
}