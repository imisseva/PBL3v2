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

namespace PBL3.UI
{
    public partial class RevenueView: Form
    {
        private TicketService _ticketService = new TicketService();
        public RevenueView()
        {
            InitializeComponent();
        }

        private void btStatistical_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateRevenuedp.Value.Date;

            int totalTickets = 0;
            int totalRevenue = 0;  

            if (cbbPick != null)
            {
                string selectedType = cbbPick.SelectedItem.ToString();
                var tickets = _ticketService.GetTickets();

                if (selectedType == "Theo ngày")
                {
                        var filtered = tickets
                     .Where(t => t.booking_date.Date == selectedDate)
                     .ToList();

                        totalTickets = filtered.Count;
                        totalRevenue = filtered.Sum(t => t.Price);
                    txtTotalTicket.Text = totalTickets.ToString();
                    txtTotalRevenue.Text = totalRevenue.ToString("N0") + " VND";
                }

                else if (selectedType == "Theo tháng")
                {
                    //code
                    
                    int month = selectedDate.Month;
                    int year = selectedDate.Year;
                    int revenue = _ticketService.GetRevenueByMonth(month, year);
                    int ticketsCount = tickets
                        .Where(t => t.booking_date.Month == month && t.booking_date.Year == year)
                        .Count();
                    txtTotalTicket.Text = ticketsCount.ToString();
                    txtTotalRevenue.Text = revenue.ToString("N0") + " VND";
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại thống kê (ngày/tháng)!");
            }

        }
    }
}
