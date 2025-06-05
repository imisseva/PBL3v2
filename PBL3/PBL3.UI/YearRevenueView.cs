using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBL3.BLL.Services;    

namespace PBL3.UI
{
    public partial class YearRevenueView: Form
    {
        private TicketService _ticketService = new TicketService();
        private int _year = DateTime.Now.Year;
        public YearRevenueView()
        {
            InitializeComponent();
            DrawChart();
        }

        private void DrawChart()
        {
            var revenueByMonth = _ticketService.GetMonthlyRevenueByYear(_year);

            RevenueChart.Series.Clear();
            RevenueChart.ChartAreas.Clear();
            RevenueChart.Titles.Clear();

            RevenueChart.ChartAreas.Add("MainArea");

            var series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue,
                IsValueShownAsLabel = true
            };

            for (int month = 1; month <= 12; month++)
            {
                int revenue = revenueByMonth.ContainsKey(month) ? revenueByMonth[month] : 0;
                series.Points.AddXY("Tháng " + month, revenue);
            }

            RevenueChart.Series.Add(series);
            RevenueChart.Titles.Add("Biểu đồ doanh thu năm " + _year);
        }
    }
}

