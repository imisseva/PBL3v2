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
    public partial class ScheduleDetail : Form
    {
        private ScheduleService scheduleService = new ScheduleService();
        private ScheduleStopService scheduleStopService = new ScheduleStopService();
        private StationService stationService = new StationService();
        public ScheduleDetail()
        {
            InitializeComponent();
            LoadData();
            LoadDatetime();
        }
        private void LoadDatetime()
        {
            dpStartTime.Format = DateTimePickerFormat.Custom;
            dpStartTime.CustomFormat= "dd/MM/yyyy HH:mm";
            dpStartTime.ShowUpDown = true;
        }
        private void InitDGVStop(List<StationDTO> validStations)
        {
            dgvStops.Columns.Clear();
            dgvStops.AutoGenerateColumns = false;
            dgvStops.ThemeStyle.HeaderStyle.Height = 35;
            dgvStops.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStops.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // STT
            DataGridViewTextBoxColumn colIndex = new DataGridViewTextBoxColumn
            {
                HeaderText = "STT",
                Name = "colIndex",
                ReadOnly = true
            };
            dgvStops.Columns.Add(colIndex);

            // Ga dừng
            DataGridViewComboBoxColumn colStation = new DataGridViewComboBoxColumn
            {
                HeaderText = "Ga dừng",
                Name = "colStation",
                DataSource = validStations,
                DisplayMember = "Name_station",
                ValueMember = "ID_station"
            };
            dgvStops.Columns.Add(colStation);

            // Thời gian dừng
            DataGridViewTextBoxColumn colStopTime = new DataGridViewTextBoxColumn
            {
                HeaderText = "Thời gian dừng (HH:mm)",
                Name = "colStopTime"
            };
            dgvStops.Columns.Add(colStopTime);
        }
        private void LoadData()
        {
            var schedules = scheduleService.GetAllSchedules();          
            var stations1 = stationService.GetStations();
            var stations2 = stationService.GetStations();

            comboBoxStartStation.DataSource = stations1;
            comboBoxStartStation.DisplayMember = "Name_station";
            comboBoxStartStation.ValueMember = "ID_station";
            comboBoxEndStation.DataSource = stations2;
            comboBoxEndStation.DisplayMember = "Name_station";
            comboBoxEndStation.ValueMember = "ID_station";
        }
        private void btnLoadStops_Click(object sender, EventArgs e)
        {
            int startID = int.Parse(comboBoxStartStation.SelectedValue.ToString());
            int endID = int.Parse(comboBoxEndStation.SelectedValue.ToString());
            var validStations = new StationService().GetIntermediateStations(startID, endID);

            InitDGVStop(validStations);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dpStartTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
