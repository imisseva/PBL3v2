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
    public partial class ShowSeats: Form
    {
        private BusService BusService = new BusService();
        private SeatService SeatService = new SeatService();
        private List<SeatDTO> selectedSeats = new List<SeatDTO>();

        public ShowSeats()
        {   
            InitializeComponent();   
        }

        private void ShowSeats_Load(object sender, EventArgs e)
        {
            var busList = BusService.GetBuses();
            cbbBus.DataSource = busList;
            cbbBus.DisplayMember = "ID_bus";
            cbbBus.ValueMember = "ID_bus";
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbBus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một xe buýt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedBusID = cbbBus.SelectedValue.ToString();
            var seats = SeatService.GetSeats().Where(s => s.ID_bus == selectedBusID).ToList();

            if (!seats.Any())
            {
                MessageBox.Show("Không có ghế nào cho xe buýt này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ShowSeat(seats);
        }

        private void cbbtrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một xe buýt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedBusID = cbbBus.SelectedValue.ToString();
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

            // Nếu ghế đã được chọn
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
                    $"Bạn có muốn **chọn** ghế {seat.seat_number} ({seat.ID_seat}) không?",
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
    }
}
