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
using PBL3.DTO;

namespace PBL3.UI
{
    public partial class InfoTicket : Form
    {
        private TicketService TicketService = new TicketService();

        public InfoTicket()
        {
            InitializeComponent();
            LoadTickets();
        }
        private void LoadTickets()
        {
            dgv2.DataSource = TicketService.GetTickets();
            dgv2.Columns["ID_ticket"].HeaderText = "Mã vé";
            dgv2.Columns["ID_schedule"].HeaderText = "Lịch trình";
            dgv2.Columns["ID_seat"].HeaderText = "Ghế";
            dgv2.Columns["Price"].HeaderText = "Giá";
            dgv2.Columns["booking_date"].HeaderText = "Ngày đặt";
            dgv2.Columns["station_start"].HeaderText = "Ga đi";
            dgv2.Columns["station_end"].HeaderText = "Ga đến";
            dgv2.Columns["Status"].HeaderText = "Trạng thái";
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFind.Text.Trim(), out int ticketId))
            {
                MessageBox.Show("Vui lòng nhập ID vé hợp lệ.");
                return;
            }

            var ticket = TicketService.GetTicketByID(ticketId);
            if (ticket != null)
            {
                dgv2.DataSource = new List<TicketDTO> { ticket }; // Hiển thị vé tìm được
            }
            else
            {
                MessageBox.Show("Không tìm thấy vé với ID đã nhập.");
                dgv2.DataSource = null;
            }
        }
        private void LoadTicketData()
        {
            dgv2.DataSource = TicketService.GetTickets();
        }
    }
}
