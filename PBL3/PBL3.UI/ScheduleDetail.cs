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
        }
        private void InitDGVStop(List<StationDTO> validStations)
        {
            dgvStops.Columns.Clear();
            dgvStops.AutoGenerateColumns = false;

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

        private void btnLoadStops_Click(object sender, EventArgs e)
        {
            int startID = int.Parse(comboBoxStartStation.SelectedValue.ToString());
            int endID = int.Parse(comboBoxEndStation.SelectedValue.ToString());
            var validStations = new StationService().GetIntermediateStations(startID, endID);

            InitDGVStop(validStations);
        }

    }
}
