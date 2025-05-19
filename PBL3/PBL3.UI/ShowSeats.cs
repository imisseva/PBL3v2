using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PBL3.UI
{
    public partial class ShowSeats : Form
    {
        private SeatService SeatService = new SeatService();
        private TicketService TicketService = new TicketService();
        private List<SeatDTO> seats;
        private string idSchedule;

        public List<SeatDTO> selectedSeats = new List<SeatDTO>();

        public ShowSeats(List<SeatDTO> seats, string idSchedule)
        {
            InitializeComponent();
            this.seats = seats;
            this.idSchedule = idSchedule;
            ShowSeat(seats);
        }

        private void ShowSeat(List<SeatDTO> seats)
        {
            panel2.Controls.Clear();
            selectedSeats.Clear();

            int seatWidth = 40, seatHeight = 40;
            int margin = 10;
            int seatsPerRow = 5;

            int totalCols = seatsPerRow;
            int totalRows = (int)Math.Ceiling(seats.Count / (double)seatsPerRow);

            int totalWidth = totalCols * seatWidth + (totalCols - 1) * margin;
            int totalHeight = totalRows * seatHeight + (totalRows - 1) * margin;

            int startX = (panel2.Width - totalWidth) / 2;
            int startY = (panel2.Height - totalHeight - 50) / 2;

            // Lấy danh sách ID ghế đã được đặt cho lịch trình hiện tại
            var bookedSeatIDs = TicketService.GetTickets()
                                             .Where(t => t.ID_schedule == idSchedule)
                                             .Select(t => t.ID_seat)
                                             .ToHashSet();

            for (int i = 0; i < seats.Count; i++)
            {
                var seat = seats[i];
                Button btn = new Button
                {
                    Text = seat.seat_number.ToString(),
                    Width = seatWidth,
                    Height = seatHeight,
                    Tag = seat
                };

                bool isBooked = bookedSeatIDs.Contains(seat.ID_seat);

                if (isBooked)
                {
                    btn.BackColor = Color.Red;    // Ghế đã đặt
                    btn.Enabled = false;          // Không cho chọn
                }
                else
                {
                    btn.BackColor = Color.LightGreen; // Ghế trống
                    btn.Click += Seat_Click;
                }

                int col = i % seatsPerRow;
                int row = i / seatsPerRow;

                btn.Left = startX + col * (seatWidth + margin);
                btn.Top = startY + row * (seatHeight + margin);

                panel2.Controls.Add(btn);
            }

            // Nút Thoát
            Button btnExit = new Button
            {
                Text = "Thoát",
                Width = 80,
                Height = 30,
                BackColor = Color.LightCoral,
                Left = panel2.Width / 4 - 40,
                Top = startY + totalHeight + 15
            };
            btnExit.Click += (s, e) => { this.Close(); };
            panel2.Controls.Add(btnExit);

            // Nút OK
            Button btnOk = new Button
            {
                Text = "OK",
                Width = 80,
                Height = 30,
                BackColor = Color.LightBlue,
                Left = panel2.Width * 3 / 4 - 40,
                Top = startY + totalHeight + 15
            };
            btnOk.Click += BtnOk_Click;
            panel2.Controls.Add(btnOk);
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var seat = (SeatDTO)btn.Tag;

            if (selectedSeats.Contains(seat))
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có muốn **bỏ chọn** ghế {seat.seat_number} ({seat.ID_seat}) không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    selectedSeats.Remove(seat);
                    btn.BackColor = Color.LightGreen;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có muốn chọn ghế {seat.seat_number} ({seat.ID_seat}) không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    selectedSeats.Add(seat);
                    btn.BackColor = Color.Gold;
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!", "Thông báo");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
