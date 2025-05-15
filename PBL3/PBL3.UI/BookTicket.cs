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

        public BookTicket()
        {
            InitializeComponent();
        }
        private void btConfirm_Click(object sender, EventArgs e)
        {
            
        }
        private void LoadBus()
        {
            var buses = BusService.GetBuses();
            cbbBus.DataSource = buses;
            cbbBus.DisplayMember = "ID_bus";
            cbbBus.ValueMember = "ID_bus";
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            LoadStation();
            LoadBus();
            LoadSchedules();
            dpBookingdate.Value = DateTime.Today;
            cbbStartPoint.SelectedIndexChanged += StationSelectionChanged;
            cbbEndPoint.SelectedIndexChanged += StationSelectionChanged;
        }


        private void btPickSeat_Click(object sender, EventArgs e)
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
            ShowSeats showSeats = new ShowSeats(seats);
            if (showSeats.ShowDialog() == DialogResult.OK)
            {
                var selectedSeats = showSeats.selectedSeats;
                txtSeat.Text = string.Join(", ", selectedSeats.Select(s => s.seat_number));
            }
        }



        private void cbbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBus.SelectedValue == null)
                return;

            string selectedBusID = cbbBus.SelectedValue.ToString();
           

            var seats = SeatService.GetSeatsByBusID(selectedBusID);
            if (seats != null && seats.Count > 0)
            {
                // Lấy type của ghế đầu tiên hoặc xử lý logic riêng
                txtType.Text = seats[0].type;
            }
            else
            {
                txtType.Text = string.Empty;
            }
            txtSeat.Text = "";
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

       
        private void StationSelectionChanged(object sender, EventArgs e)
        {
            // Chỉ load lịch trình khi cả 2 trạm được chọn
            if (cbbStartPoint.SelectedValue != null && cbbEndPoint.SelectedValue != null)
            {
                string startID = cbbStartPoint.SelectedValue.ToString();
                string endID = cbbEndPoint.SelectedValue.ToString();
            }
        }

        private void LoadSchedules()
        {
            var schedules = new ScheduleService().GetAllSchedules();

            cbbSchedule.DataSource = schedules;
            cbbSchedule.DisplayMember = "start_time";
            cbbSchedule.ValueMember = "ID_schedule";

            cbbSchedule.SelectedIndexChanged += ScheduleSelectionChanged;
        }

        private void ScheduleSelectionChanged(object sender, EventArgs e)
        {
            if (cbbSchedule.SelectedValue != null)
            {
                string scheduleID = cbbSchedule.SelectedValue.ToString();
                //LoadSeats(scheduleID);
            }
        }
        public void SetSelectedSeats(List<SeatDTO> selectedSeats)
        {
            if (selectedSeats == null || selectedSeats.Count == 0)
            {
                txtSeat.Text = "";
                return;
            }
            string seatNumbers = string.Join(", ", selectedSeats.Select(s => s.seat_number));
            txtSeat.Text = seatNumbers;
        }
    }
}
