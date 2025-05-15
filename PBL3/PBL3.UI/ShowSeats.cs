using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.UI
{
    public partial class ShowSeats : Form
    {
        private BusService BusService = new BusService();
        private SeatService SeatService = new SeatService();
        private List<SeatDTO> seats;
        public List<SeatDTO> selectedSeats = new List<SeatDTO>();

        public ShowSeats(List<SeatDTO> seats)
        {
            InitializeComponent();
            this.seats = seats;
            ShowSeat(seats); // hàm hiển thị ghế trên form ShowSeats
        }

        private void ShowSeat(List<SeatDTO> seats)
        {
            panel2.Controls.Clear();
            selectedSeats.Clear(); // reset danh sách ghế đã chọn khi tìm mới

            int seatWidth = 40, seatHeight = 40;
            int margin = 10;
            int seatsPerRow = 5;

            int totalCols = seatsPerRow;
            int totalRows = (int)Math.Ceiling(seats.Count / (double)seatsPerRow);

            int totalWidth = totalCols * seatWidth + (totalCols - 1) * margin;
            int totalHeight = totalRows * seatHeight + (totalRows - 1) * margin;

            // Căn giữa các ghế trong panel2
            int startX = (panel2.Width - totalWidth) / 2;
            int startY = (panel2.Height - totalHeight - 50) / 2;
            // trừ 50 để tạo khoảng trống cho 2 nút bên dưới

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

            // Nút Thoát ở bên trái dưới
            Button btnExit = new Button();
            btnExit.Text = "Thoát";
            btnExit.Width = 80;
            btnExit.Height = 30;
            btnExit.BackColor = Color.LightCoral;
            btnExit.Left = panel2.Width / 4 - btnExit.Width / 2;
            btnExit.Top = startY + totalHeight + 15;

            btnExit.Click += (s, e) =>
            {
                this.Close();
            };

            panel2.Controls.Add(btnExit);

            // Nút OK ở bên phải dưới
            Button btnOk = new Button();
            btnOk.Text = "OK";
            btnOk.Width = 80;
            btnOk.Height = 30;
            btnOk.BackColor = Color.LightBlue;
            btnOk.Left = panel2.Width * 3 / 4 - btnOk.Width / 2;
            btnOk.Top = startY + totalHeight + 15;

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
                    MessageBoxIcon.Question
                );

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
                    MessageBoxIcon.Question
                );

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

            selectedSeats = new List<SeatDTO>(selectedSeats);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
