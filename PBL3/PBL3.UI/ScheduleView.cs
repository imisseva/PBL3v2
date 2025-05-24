using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBL3.UI
{
    public partial class ScheduleView : Form
    {
        private readonly ScheduleService _scheduleService = new ScheduleService();
        private readonly ScheduleStopService _scheduleStopService = new ScheduleStopService();
        private readonly StationService _stationService = new StationService();
        public ScheduleView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string keyword = "")
        {
            var schedules = _scheduleService.GetAllSchedules();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.ToLower();
                schedules = schedules.Where(s =>
                    s.ID_Schedule.ToLower().Contains(keyword) ||
                    s.ID_bus.ToLower().Contains(keyword) ||
                    s.ID_route.ToLower().Contains(keyword)).ToList();
            }

            var data = schedules.Select(s =>
            {
                // Lấy danh sách các ga dừng tương ứng với Schedule
                var stops = _scheduleStopService.GetStopsBySchedule(s.ID_Schedule);
                var stopNames = string.Join(" → ", stops
                .OrderBy(st => st.Stop_order)
                .Select(st => _stationService.GetNameStation(st.IDStation_stop)));

                return new
                {
                    ID_Schedule = s.ID_Schedule,
                    Bus = s.ID_bus,
                    Route = s.ID_route,
                    StartTime = s.start_time.ToString("dd/MM/yyyy HH:mm"),
                    EndTime = s.end_time.ToString("dd/MM/yyyy HH:mm"),
                    GaDung = stopNames
                };
            }).ToList();

            dgv.DataSource = data;
            dgv.Columns["GaDung"].Width = 500;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.ClearSelection();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new ScheduleDetail();
            form.schedule  = _scheduleService.GetAllSchedules();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
