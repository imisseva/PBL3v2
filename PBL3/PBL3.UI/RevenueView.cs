using Microsoft.VisualBasic;
using PBL3.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.WinForms;

namespace PBL3.UI
{
    public partial class RevenueView: Form
    {
        private TicketService _ticketService = new TicketService();
        private FormsPlot RevenuePlot;

        public RevenueView()
        {
            InitializeComponent();
            SetupPlot();
        }

        private void SetupPlot()
        {
            RevenuePlot = new FormsPlot();
            RevenuePlot.Dock = DockStyle.Fill;
            plotPanel.Controls.Add(RevenuePlot);
        }

        private void btStatistical_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateRevenuedp.Value.Date;

            if (cbbPick != null)
            {
                string selectedType = cbbPick.SelectedItem.ToString();
                var tickets = _ticketService.GetTickets();

                // Clear previous plot
                RevenuePlot.Plot.Clear();

                if (selectedType == "Theo ngày")
                {
                    var filtered = tickets
                        .Where(t => t.booking_date.Date == selectedDate)
                        .ToList();

                    // Prepare data for chart
                    var hours = Enumerable.Range(0, 24).Select(x => (double)x).ToArray();
                    var revenues = new double[24];
                    var ticketCounts = new double[24];

                    foreach (var ticket in filtered)
                    {
                        int hour = ticket.booking_date.Hour;
                        revenues[hour] += ticket.Price;
                        ticketCounts[hour]++;
                    }

                    // Create bar plot for revenue
                    var bars = RevenuePlot.Plot.Add.Bars(hours, revenues);
                    bars.Color = Colors.SteelBlue;

                    // Add value labels above bars
                    for (int i = 0; i < revenues.Length; i++)
                    {
                        if (revenues[i] > 0)
                        {
                            var text = RevenuePlot.Plot.Add.Text(
                                x: hours[i],
                                y: revenues[i],
                                text: revenues[i].ToString("N0") + " đ"
                            );
                            text.LabelFontColor = Colors.Black;
                            text.LabelFontSize = 8;
                            text.Alignment = Alignment.UpperCenter;
                        }
                    }

                    // Customize the plot
                    RevenuePlot.Plot.Title($"Doanh thu theo giờ ngày {selectedDate.ToString("dd/MM/yyyy")}", size: 14);
                    RevenuePlot.Plot.Axes.Bottom.Label.Text = "Giờ";
                    RevenuePlot.Plot.Axes.Left.Label.Text = "Doanh thu (VNĐ)";

                    // Set x-axis ticks to show hours
                    RevenuePlot.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                        hours,
                        hours.Select(h => $"{h}h").ToArray()
                    );
                }
                else if (selectedType == "Theo tháng")
                {
                    int month = selectedDate.Month;
                    int year = selectedDate.Year;
                    var monthlyData = _ticketService.GetMonthlyRevenueByYear(year);

                    // Prepare data for chart
                    var days = Enumerable.Range(1, DateTime.DaysInMonth(year, month)).Select(x => (double)x).ToArray();
                    var revenues = new double[days.Length];
                    var ticketCounts = new double[days.Length];

                    foreach (var ticket in tickets.Where(t => t.booking_date.Month == month && t.booking_date.Year == year))
                    {
                        int day = ticket.booking_date.Day - 1;
                        revenues[day] += ticket.Price;
                        ticketCounts[day]++;
                    }

                    // Create bar plot for revenue
                    var bars = RevenuePlot.Plot.Add.Bars(days, revenues);
                    bars.Color = Colors.SteelBlue;

                    // Add value labels above bars
                    for (int i = 0; i < revenues.Length; i++)
                    {
                        if (revenues[i] > 0)
                        {
                            var text = RevenuePlot.Plot.Add.Text(
                                x: days[i],
                                y: revenues[i],
                                text: revenues[i].ToString("N0") + " đ"
                            );
                            text.LabelFontColor = Colors.Black;
                            text.LabelFontSize = 8;
                            text.Alignment = Alignment.UpperCenter;
                        }
                    }

                    // Customize the plot
                    RevenuePlot.Plot.Title($"Doanh thu theo ngày tháng {month}/{year}", size: 14);
                    RevenuePlot.Plot.Axes.Bottom.Label.Text = "Ngày";
                    RevenuePlot.Plot.Axes.Left.Label.Text = "Doanh thu (VNĐ)";

                    // Set x-axis ticks to show days
                    RevenuePlot.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                        days,
                        days.Select(d => $"Ngày {(int)d}").ToArray()
                    );
                }

                // Customize axes
                RevenuePlot.Plot.Axes.Bottom.TickLabelStyle.FontSize = 10;
                RevenuePlot.Plot.Axes.Left.TickLabelStyle.FontSize = 10;

                // Refresh the plot
                RevenuePlot.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại thống kê (ngày/tháng)!");
            }
        }
    }
}
