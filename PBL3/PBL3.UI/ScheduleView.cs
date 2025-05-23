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

            dgv.DataSource = schedules.Select(s => new
            {
                ID_Schedule = s.ID_Schedule,
                Bus = s.ID_bus,
                Route = s.ID_route,
                StartTime = s.start_time.ToString("dd/MM/yyyy HH:mm"),
                EndTime = s.end_time.ToString("dd/MM/yyyy HH:mm")
            }).ToList();

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
