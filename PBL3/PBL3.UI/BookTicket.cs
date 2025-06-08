using Microsoft.VisualBasic;
using PBL3.BLL.Services;
using PBL3.DTO;
using PBL3.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
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
        public List<SeatDTO> selectedSeats = new List<SeatDTO>();
        public ScheduleService ScheduleService = new ScheduleService();
        public BookTicket()
        {
            InitializeComponent();
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            LoadStation();
            dpBookingdate.Value = DateTime.Today;
            // Không cho chọn ngày trước hôm nay
            dtpDate.MinDate = DateTime.Today;
            cbbStartPoint.SelectedIndexChanged += StationSelectionChanged;
            cbbEndPoint.SelectedIndexChanged += StationSelectionChanged;
        }

        private void btPickSeat_Click(object sender, EventArgs e)
        {
            if (dgvBus.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một chuyến trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy BusID từ dòng đang chọn của dgvBus, giả sử cột MãXe là cột BusID
            string selectedBusID = dgvBus.CurrentRow.Cells["MãXe"].Value?.ToString();
            if (string.IsNullOrEmpty(selectedBusID))
            {
                MessageBox.Show("BusID không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy danh sách ghế của Bus
            var seats = SeatService.GetSeats().Where(s => s.ID_bus == selectedBusID).ToList();

            if (!seats.Any())
            {
                MessageBox.Show("Không có ghế nào cho xe buýt này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị form chọn ghế
            string scheduleID = dgvBus.CurrentRow.Cells["Lịch"].Value.ToString();
            ShowSeats showSeats = new ShowSeats(seats, scheduleID);
            if (showSeats.ShowDialog() == DialogResult.OK)
            {
                var selectedSeats = showSeats.selectedSeats;
                txtSeat.Text = string.Join(", ", selectedSeats.Select(s => s.seat_number));
            }
        }

        private void LoadStation()
        {
            var stations = new StationService().GetStations();
            cbbStartPoint.DataSource = stations;
            cbbStartPoint.DisplayMember = "Name_station";
            cbbStartPoint.ValueMember = "ID_station";

            cbbEndPoint.DataSource = stations.ToList(); // copy để tránh trùng DataSource
            cbbEndPoint.DisplayMember = "Name_station";
            cbbEndPoint.ValueMember = "ID_station";
        }
        private void LoadBusDataGridView(List<BusTicketDTO> buses)
        {
            if (buses == null || buses.Count == 0)
            {
                MessageBox.Show("Không có chuyến nào phù hợp.");
                dgvBus.DataSource = null;
                return;
            }

            dgvBus.DataSource = buses.Select(b => new
            {
                Lịch = b.ID_schedule,
                MãXe = b.BusID,
                LoạiGhế = b.SeatType,
                SứcChứa = b.Quantity,
                ThờiGianKhởiHành = b.StartTime.ToString("dd/MM/yyyy HH:mm"),
                ThờiGianĐến = b.EndTime.ToString("dd/MM/yyyy HH:mm")
            }).ToList();
            dgvBus.Columns["Lịch"].HeaderText = "Lịch";
            dgvBus.Columns["MãXe"].HeaderText = "Mã Xe";
            dgvBus.Columns["LoạiGhế"].HeaderText = "Loại Ghế";
            dgvBus.Columns["SứcChứa"].HeaderText = "Sức Chứa";
            dgvBus.Columns["ThờiGianKhởiHành"].HeaderText = "Thời Gian Khởi Hành";
            dgvBus.Columns["ThờiGianĐến"].HeaderText = "Thời Gian Đến";
            dgvBus.ColumnHeadersHeight = 35;
            dgvBus.AutoGenerateColumns = false;

            dgvBus.Columns["Lịch"].Visible = false;
            dgvBus.Columns["MãXe"].Width = 40;
            dgvBus.Columns["LoạiGhế"].Width = 100;
            dgvBus.Columns["SứcChứa"].Width = 70;
            dgvBus.Columns["ThờiGianKhởiHành"].Width = 150;
            dgvBus.Columns["ThờiGianĐến"].Width = 150;

            dgvBus.Columns["Lịch"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBus.Columns["MãXe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBus.Columns["SứcChứa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBus.Columns["LoạiGhế"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBus.Columns["ThờiGianKhởiHành"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBus.Columns["ThờiGianĐến"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBus.ReadOnly = true;
            dgvBus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvBus.RowTemplate.Height = 24;
            foreach (DataGridViewColumn column in dgvBus.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
            // Reset scroll lên đầu
            if (dgvBus.Rows.Count > 0)
            {
                dgvBus.FirstDisplayedScrollingRowIndex = 0;
            }
        }

        private void btn_LoaddgvBus_Click(object sender, EventArgs e)
        {
            string start = cbbStartPoint.Text.Trim();
            string end = cbbEndPoint.Text.Trim();
            DateTime date = dtpDate.Value.Date;

            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(end))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ điểm đi và điểm đến.");
                return;
            }

            var service = new ScheduleService();
            var buses = service.GetAvailableBuses(date, start, end);

            LoadBusDataGridView(buses);
        }
        private void StationSelectionChanged(object sender, EventArgs e)
        {
            // Chỉ load lịch trình khi cả 2 trạm được chọn
            if (cbbStartPoint.SelectedValue != null && cbbEndPoint.SelectedValue != null)
            {
                string startID = cbbStartPoint.SelectedValue.ToString();
                string endID = cbbEndPoint.SelectedValue.ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào
            if (dgvBus.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một chuyến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSeat.Text))
            {
                MessageBox.Show("Vui lòng chọn ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbPrice.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giá vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ngày không được trước ngày hôm nay
            DateTime selectedDate = dtpDate.Value.Date;
            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("Không thể chọn ngày trước ngày hôm nay để đặt vé.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Lấy thông tin từ form
            string selectedBusID = dgvBus.CurrentRow.Cells["MãXe"].Value.ToString();
            string IDstartStation = cbbStartPoint.SelectedValue.ToString();
            string IDendStation = cbbEndPoint.SelectedValue.ToString();

            // 3. Lấy ID ga
            var stationService = new StationService();
            string startStationID = IDstartStation;
            string endStationID = IDendStation;

            if (startStationID == null || endStationID == null)
            {
                MessageBox.Show("Không tìm thấy ID ga tương ứng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string scheduleID = dgvBus.CurrentRow.Cells["Lịch"].Value.ToString();

            // 5. Lấy danh sách ghế đã chọn
            List<int> selectedSeatNumbers = txtSeat.Text
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s))
                .ToList();

            var seatService = new SeatService();
            var allSeats = seatService.GetSeats()
                .Where(s => s.ID_bus == selectedBusID && selectedSeatNumbers.Contains(s.seat_number))
                .ToList();

            if (allSeats.Count != selectedSeatNumbers.Count)
            {
                MessageBox.Show("Không thể xác định tất cả ghế đã chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 6. Tạo và lưu vé
            var ticketService = new TicketService();

            foreach (var seat in allSeats)
            {
                var ticket = new TicketDTO
                {
                    booking_date = DateTime.Now,
                    ID_seat = seat.ID_seat,
                    ID_schedule = scheduleID,
                    Price = int.Parse(cbbPrice.Text),
                    station_start = IDstartStation,
                    station_end = IDendStation,
                };

                ticketService.BookTicket(ticket);
            }

            MessageBox.Show("Đặt vé thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}   