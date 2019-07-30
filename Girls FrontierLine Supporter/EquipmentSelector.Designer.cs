namespace Girls_FrontierLine_Supporter
{
    partial class EquipmentSelector
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
            this.EquipmentSelectorListView = new System.Windows.Forms.ListView();
            this.EquipmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipmentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipmentCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipmentGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipmentProductTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectOK = new System.Windows.Forms.Button();
            this.SelectCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EquipmentSelectorListView
            // 
            this.EquipmentSelectorListView.AllowColumnReorder = true;
            this.EquipmentSelectorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EquipmentName,
            this.EquipmentType,
            this.EquipmentCategory,
            this.EquipmentGrade,
            this.EquipmentProductTime});
            this.EquipmentSelectorListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.EquipmentSelectorListView.FullRowSelect = true;
            this.EquipmentSelectorListView.GridLines = true;
            this.EquipmentSelectorListView.Location = new System.Drawing.Point(0, 0);
            this.EquipmentSelectorListView.Name = "EquipmentSelectorListView";
            this.EquipmentSelectorListView.Size = new System.Drawing.Size(474, 555);
            this.EquipmentSelectorListView.TabIndex = 3;
            this.EquipmentSelectorListView.UseCompatibleStateImageBehavior = false;
            this.EquipmentSelectorListView.View = System.Windows.Forms.View.Details;
            // 
            // EquipmentName
            // 
            this.EquipmentName.Text = "장비 이름";
            this.EquipmentName.Width = 110;
            // 
            // EquipmentType
            // 
            this.EquipmentType.Text = "장비 종류";
            this.EquipmentType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipmentType.Width = 100;
            // 
            // EquipmentCategory
            // 
            this.EquipmentCategory.Text = "분류";
            this.EquipmentCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipmentCategory.Width = 50;
            // 
            // EquipmentGrade
            // 
            this.EquipmentGrade.Tag = "Grade";
            this.EquipmentGrade.Text = "등급";
            this.EquipmentGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipmentGrade.Width = 75;
            // 
            // EquipmentProductTime
            // 
            this.EquipmentProductTime.Tag = "Time";
            this.EquipmentProductTime.Text = "제조 시간";
            this.EquipmentProductTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipmentProductTime.Width = 70;
            // 
            // SelectOK
            // 
            this.SelectOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SelectOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectOK.Location = new System.Drawing.Point(0, 555);
            this.SelectOK.Name = "SelectOK";
            this.SelectOK.Size = new System.Drawing.Size(264, 36);
            this.SelectOK.TabIndex = 4;
            this.SelectOK.Text = "선택";
            this.SelectOK.UseVisualStyleBackColor = true;
            this.SelectOK.Click += new System.EventHandler(this.SelectOK_Click);
            // 
            // SelectCancel
            // 
            this.SelectCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SelectCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SelectCancel.Location = new System.Drawing.Point(270, 555);
            this.SelectCancel.Name = "SelectCancel";
            this.SelectCancel.Size = new System.Drawing.Size(204, 36);
            this.SelectCancel.TabIndex = 5;
            this.SelectCancel.Text = "취소";
            this.SelectCancel.UseVisualStyleBackColor = true;
            this.SelectCancel.Click += new System.EventHandler(this.SelectCancel_Click);
            // 
            // EquipmentSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 591);
            this.Controls.Add(this.SelectCancel);
            this.Controls.Add(this.SelectOK);
            this.Controls.Add(this.EquipmentSelectorListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EquipmentSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "장비 선택창";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView EquipmentSelectorListView;
        private System.Windows.Forms.ColumnHeader EquipmentName;
        private System.Windows.Forms.ColumnHeader EquipmentType;
        private System.Windows.Forms.ColumnHeader EquipmentCategory;
        private System.Windows.Forms.ColumnHeader EquipmentGrade;
        private System.Windows.Forms.ColumnHeader EquipmentProductTime;
        private System.Windows.Forms.Button SelectOK;
        private System.Windows.Forms.Button SelectCancel;
    }
}