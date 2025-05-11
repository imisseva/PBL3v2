using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PBL3
{
    public partial class BookTicket : Form
    {
        private BusService BusService = new BusService();
        private SeatService SeatService = new SeatService();
        private List<SeatDTO> selectedSeats = new List<SeatDTO>();
        public BookTicket()
        {
            InitializeComponent();
        }

        private void cbbtrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTrain = cbbBus.SelectedValue.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtTicketID.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập ID vé");
            //    return;
            //}

            //xử lý logic đặt vé 

            MessageBox.Show("Đặt vé thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbBus.SelectedIndex == null) return;

            string selectedBusID = cbbBus.SelectedValue.ToString();
            var seats = SeatService.GetSeats()
                                .Where(s => s.ID_bus == selectedBusID)
                                .ToList();

            ShowSeats(seats);
        }
        private void ShowSeats(List<SeatDTO> seats)
        {
            panel2.Controls.Clear();

            int seatWidth = 40, seatHeight = 40;
            int margin = 10;
            int seatsPerRow = 5;

            int totalCols = seatsPerRow;
            int totalRows = (int)Math.Ceiling(seats.Count / (double)seatsPerRow);

            int totalWidth = totalCols * seatWidth + (totalCols - 1) * margin;
            int totalHeight = totalRows * seatHeight + (totalRows - 1) * margin;

            int startX = (panel2.Width - totalWidth) / 2;
            int startY = (panel2.Height - totalHeight) / 2;

            for (int i = 0; i < seats.Count; i++)
            {
                var seat = seats[i];
                Button btn = new Button();
                btn.Text = seat.seat_number.ToString();
                btn.Width = seatWidth;
                btn.Height = seatHeight;
                btn.BackColor = Color.LightGreen;
                btn.Tag = seat;

                btn.Click += Seat_Click;

                int col = i % seatsPerRow;
                int row = i / seatsPerRow;

                btn.Left = startX + col * (seatWidth + margin);
                btn.Top = startY + row * (seatHeight + margin);

                panel2.Controls.Add(btn);
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var seat = (SeatDTO)btn.Tag;

            DialogResult result = MessageBox.Show(
                $"Bạn có muốn chọn ghế {seat.seat_number} ({seat.ID_seat}) không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Nếu đã chọn ghế khác rồi, reset màu cũ
                foreach (Control control in panel2.Controls)
                {
                    if (control is Button otherBtn && otherBtn.BackColor == Color.Gold)
                    {
                        otherBtn.BackColor = Color.LightGreen;
                    }
                }

                // Xóa ghế cũ khỏi danh sách và thêm ghế mới
                selectedSeats.Clear();
                selectedSeats.Add(seat);
                btn.BackColor = Color.Gold;

                // Hiển thị số ghế vào textbox
                txtSeat.Text = seat.seat_number.ToString();
            }
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            var busList = BusService.GetBuses();
            cbbBus.DataSource = busList;
            cbbBus.DisplayMember = "ID_bus";
            cbbBus.ValueMember = "ID_bus";
        }
    }
}
