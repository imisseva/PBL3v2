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
        }
        private void btFind_Click(object sender, EventArgs e)
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
        private void LoadTicketData()
        {
            dgv2.DataSource = TicketService.GetTickets();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFind.Text))
            {
                LoadTicketData(); // Nếu ô tìm kiếm trống, tải lại tất cả vé
                return;
            }
            if (!int.TryParse(txtFind.Text.Trim(), out int ticketId))
            {
                return;
            }

            var ticket = TicketService.GetTicketByID(ticketId);
            if (ticket != null)
            {
                dgv2.DataSource = new List<TicketDTO> { ticket }; // Hiển thị vé tìm được
            }
            else
            {
                dgv2.DataSource = null;
            }

        }
    }
}
