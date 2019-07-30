namespace Girls_FrontierLine_Supporter
{
    partial class DollAbilityChartViewer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DollAbilityChartBig = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DollAbilityChartBig)).BeginInit();
            this.SuspendLayout();
            // 
            // DollAbilityChartBig
            // 
            this.DollAbilityChartBig.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            customLabel1.Text = "Test";
            chartArea1.AxisY.CustomLabels.Add(customLabel1);
            chartArea1.Name = "ChartArea1";
            this.DollAbilityChartBig.ChartAreas.Add(chartArea1);
            this.DollAbilityChartBig.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.DollAbilityChartBig.Legends.Add(legend1);
            this.DollAbilityChartBig.Location = new System.Drawing.Point(0, 0);
            this.DollAbilityChartBig.Name = "DollAbilityChartBig";
            this.DollAbilityChartBig.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "인형";
            series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.None;
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "평균";
            this.DollAbilityChartBig.Series.Add(series1);
            this.DollAbilityChartBig.Series.Add(series2);
            this.DollAbilityChartBig.Size = new System.Drawing.Size(541, 423);
            this.DollAbilityChartBig.TabIndex = 45;
            this.DollAbilityChartBig.Text = "chart1";
            // 
            // DollAbilityChartViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 423);
            this.Controls.Add(this.DollAbilityChartBig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DollAbilityChartViewer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "인형 능력치 그래프";
            ((System.ComponentModel.ISupportInitialize)(this.DollAbilityChartBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DollAbilityChartBig;
    }
}