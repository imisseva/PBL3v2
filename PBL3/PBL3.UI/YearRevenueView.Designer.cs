namespace PBL3.UI
{
    partial class YearRevenueView
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.RevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // RevenueChart
            // 
            chartArea1.Name = "ChartArea1";
            this.RevenueChart.ChartAreas.Add(chartArea1);
            this.RevenueChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.RevenueChart.Legends.Add(legend1);
            this.RevenueChart.Location = new System.Drawing.Point(0, 0);
            this.RevenueChart.Name = "RevenueChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.RevenueChart.Series.Add(series1);
            this.RevenueChart.Size = new System.Drawing.Size(832, 561);
            this.RevenueChart.TabIndex = 0;
            this.RevenueChart.Text = "chart1";
            title1.Name = "Biểu đồ doanh thu năm";
            this.RevenueChart.Titles.Add(title1);
            // 
            // YearRevenueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 561);
            this.Controls.Add(this.RevenueChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YearRevenueView";
            this.Text = "YearRevenueView";
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart RevenueChart;
    }
}