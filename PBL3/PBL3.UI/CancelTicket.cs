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
    public partial class CancelTicket: Form
    {
        private TicketService TicketService = new TicketService();  
        public CancelTicket()
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

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgv2.SelectedRows[0];
            int ticketId = Convert.ToInt32(selectedRow.Cells["ID_ticket"].Value);

            var result = MessageBox.Show("Bạn có chắc muốn hủy vé này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    TicketService.CancelTicket(ticketId);
                    MessageBox.Show("Đã hủy vé thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTickets(); // Reload lại sau khi hủy
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hủy vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                dgv2.DataSource = new List<TicketDTO> { ticket };
            }
            else
            {
                MessageBox.Show("Không tìm thấy vé với ID đã nhập.");
                dgv2.DataSource = null;
            }
        }

        private void CancelTicket_Load(object sender, EventArgs e)
        {
            LoadTicketData();
        }

        private void LoadTicketData()
        {
            dgv2.DataSource = TicketService.GetTickets();
        }
    }
}
