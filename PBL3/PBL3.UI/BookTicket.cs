using PBL3.BLL.Services;
using PBL3.DTO;
using PBL3.UI;
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
            cbbStartPoint.SelectedIndexChanged += StationSelectionChanged;
            cbbEndPoint.SelectedIndexChanged += StationSelectionChanged;
        }


        private void btPickSeat_Click(object sender, EventArgs e)
        {
            ShowSeats showSeats = new ShowSeats();
            showSeats.ShowDialog();
        }

        private void cbbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBusID = cbbBus.SelectedValue.ToString(); 
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

                //if (startID != endID)
                //{
                //    LoadSchedules(startID, endID); // Xem tiếp bước 3
                //}
                //else
                //{
                //    cbbSchedule.DataSource = null;
                //    panelSeats.Controls.Clear();
                //}
            }
        }

        private void LoadSchedules()
        {
            var schedules = new ScheduleService().GetAllSchedules();

            cbbSchedule.DataSource = schedules;
            cbbSchedule.DisplayMember = "start_time"; // hoặc ghép tuyến + thời gian
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



    }
}
