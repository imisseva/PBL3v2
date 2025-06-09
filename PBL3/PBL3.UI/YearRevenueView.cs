using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.Services;    
using ScottPlot;
using ScottPlot.WinForms;

namespace PBL3.UI
{
    public partial class YearRevenueView: Form
    {
        private TicketService _ticketService = new TicketService();
        private int _year = DateTime.Now.Year;
        private FormsPlot RevenuePlot;

        public YearRevenueView()
        {
            InitializeComponent();
            SetupPlot();
            DrawChart();
        }

        private void SetupPlot()
        {
            RevenuePlot = new FormsPlot();
            RevenuePlot.Dock = DockStyle.Fill;
            this.Controls.Add(RevenuePlot);
        }

        private void DrawChart()
        {
            var revenueByMonth = _ticketService.GetMonthlyRevenueByYear(_year);

            // Clear previous plot
            RevenuePlot.Plot.Clear();

            // Prepare data
            double[] months = Enumerable.Range(1, 12).Select(x => (double)x).ToArray();
            double[] revenues = Enumerable.Range(1, 12)
                .Select(month => revenueByMonth.ContainsKey(month) ? (double)revenueByMonth[month] : 0)
                .ToArray();

            // Create bar plot
            var bars = RevenuePlot.Plot.Add.Bars(months, revenues);
            bars.Color = Colors.SteelBlue;

            // Add value labels above bars
            for (int i = 0; i < revenues.Length; i++)
            {
                var text = RevenuePlot.Plot.Add.Text(
                    x: months[i],
                    y: revenues[i],
                    text: revenues[i].ToString("N0") + " đ"
                );
                text.LabelFontColor = Colors.Black;
                text.LabelFontSize = 10;
                text.Alignment = Alignment.UpperCenter;
            }

            // Customize the plot
            RevenuePlot.Plot.Title($"Biểu đồ doanh thu năm {_year}", size: 16);
            RevenuePlot.Plot.Axes.Bottom.Label.Text = "Tháng";
            RevenuePlot.Plot.Axes.Bottom.Label.FontSize = 12;
            RevenuePlot.Plot.Axes.Left.Label.Text = "Doanh thu (VNĐ)";
            RevenuePlot.Plot.Axes.Left.Label.FontSize = 12;

            // Set x-axis ticks to show month numbers
            RevenuePlot.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                months,
                months.Select(m => $"Tháng {m}").ToArray()
            );

            // Customize axes
            RevenuePlot.Plot.Axes.Bottom.TickLabelStyle.FontSize = 10;
            RevenuePlot.Plot.Axes.Left.TickLabelStyle.FontSize = 10;

            // Refresh the plot
            RevenuePlot.Refresh();
        }
    }
}

