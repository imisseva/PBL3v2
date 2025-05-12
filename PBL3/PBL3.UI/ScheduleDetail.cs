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
        private List<ScheduleDTO> schedule; // Danh sách đã được gán dữ liệu trước đó
        private bool hasShownDuplicateMessage = false; // Để tránh hiện lại nhiều lần khi chưa thay đổi
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
        private List<StationDTO> allStations; // Lưu lại danh sách ban đầu

        private void InitDGVStop(List<StationDTO> validStations)
        {
            allStations = validStations; // Lưu danh sách gốc để lọc về sau

            dgvStops.Columns.Clear();
            dgvStops.AutoGenerateColumns = false;
            dgvStops.ThemeStyle.HeaderStyle.Height = 35;
            dgvStops.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStops.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // STT
            dgvStops.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "STT",
                Name = "colIndex",
                ReadOnly = true
            });

            // Ga dừng (ComboBox)
            dgvStops.Columns.Add(new DataGridViewComboBoxColumn
            {
                HeaderText = "Ga dừng",
                Name = "colStation",
                DisplayMember = "Name_station",
                ValueMember = "ID_station",
                DataSource = new List<StationDTO>(allStations) // Tạm thời set tất cả
            });

            // Thời gian dừng
            dgvStops.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Thời gian dừng (HH:mm)",
                Name = "colStopTime"
            });

            dgvStops.EditingControlShowing += dgvStops_EditingControlShowing;
        }

        private void dgvStops_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvStops.CurrentCell.ColumnIndex == dgvStops.Columns["colStation"].Index &&
                e.Control is ComboBox comboBox)
            {
                comboBox.DropDown -= ComboBox_DropDown;
                comboBox.DropDown += ComboBox_DropDown;
            }
        }

        private void ComboBox_DropDown(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                // Lấy danh sách ga đã chọn (trừ dòng hiện tại đang chỉnh sửa)
                var selectedStations = new HashSet<string>();
                foreach (DataGridViewRow row in dgvStops.Rows)
                {
                    if (row.Index == dgvStops.CurrentCell.RowIndex) continue;

                    if (row.Cells["colStation"].Value is string stationId && !string.IsNullOrEmpty(stationId))
                    {
                        selectedStations.Add(stationId);
                    }
                }

                // Lọc lại danh sách ga chưa chọn
                var availableStations = allStations
                    .Where(s => !selectedStations.Contains(s.ID_station))
                    .ToList();

                // Cập nhật lại DataSource cho ComboBox đang hiển thị
                comboBox.DataSource = availableStations;
                comboBox.DisplayMember = "Name_station";
                comboBox.ValueMember = "ID_station";
            }
        }

        private void LoadData()
        {
            var stations1 = stationService.GetStations();
            var stations2 = stationService.GetStations();
            stations1.Insert(0, new StationDTO { ID_station = "-1", Name_station = "-- Chọn ga bắt đầu --" });
            stations2.Insert(0, new StationDTO { ID_station = "-1", Name_station = "-- Chọn ga kết thúc --" });
            comboBoxStartStation.DataSource = stations1;
            comboBoxStartStation.DisplayMember = "Name_station";
            comboBoxStartStation.ValueMember = "ID_station";
            comboBoxEndStation.DataSource = stations2;
            comboBoxEndStation.DisplayMember = "Name_station";
            comboBoxEndStation.ValueMember = "ID_station";
        }
        private void btnLoadStops_Click(object sender, EventArgs e)
        {
            if (comboBoxStartStation.SelectedIndex == 0 || comboBoxEndStation.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn ga bắt đầu và ga kết thúc.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int startID = int.Parse(comboBoxStartStation.SelectedValue.ToString());
            int endID = int.Parse(comboBoxEndStation.SelectedValue.ToString());
            var validStations = new StationService().GetIntermediateStations(startID, endID);
            InitDGVStop(validStations);
            txtEndTimeLoad();
            string startStationID = comboBoxStartStation.SelectedValue.ToString();
            DateTime startTime = dpStartTime.Value;
            DateTime endTime = DateTime.Parse(txtEndTime.Text);
            var schedules = scheduleService.GetBusesAvailableForSchedule(startStationID, startTime, endTime);
            cbBus.DataSource = schedules;      

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (/*string.IsNullOrEmpty(txtDistance.Text) ||*/string.IsNullOrEmpty(txtEndTime.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            ScheduleDTO schedule = new ScheduleDTO
            {
                ID_Schedule = Guid.NewGuid().ToString(),
                ID_bus = cbBus.SelectedValue.ToString(),
                start_time = dpStartTime.Value,
                end_time = DateTime.Parse(txtEndTime.Text),
                //distance = int.Parse(txtDistance.Text)
            };
            scheduleService.AddSchedule(schedule);
            MessageBox.Show("Thêm lịch trình thành công");
        }
        private void txtEndTimeLoad()
        {
            DateTime startTime = dpStartTime.Value;
            DateTime currentTime = startTime;

            foreach (DataGridViewRow row in dgvStops.Rows)
            {
                if (row.IsNewRow) continue; // bỏ qua dòng trống cuối

                string stopTimeText = row.Cells["colStopTime"].Value?.ToString();

                if (!string.IsNullOrEmpty(stopTimeText) &&
                    TimeSpan.TryParse(stopTimeText, out TimeSpan stopDuration))
                {
                    currentTime = currentTime.Add(stopDuration);
                }
            }
            txtEndTime.Text = currentTime.ToString("dd/MM/yyyy HH:mm");

        }
        //private void btnAddStop_Click(object sender, EventArgs e)
        //{
        //    if (dgvStops.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Vui lòng thêm ga dừng");
        //        return;
        //    }
        //    foreach (DataGridViewRow row in dgvStops.Rows)
        //    {
        //        if (row.IsNewRow) continue;
        //        ScheduleStopDTO stop = new ScheduleStopDTO
        //        {
        //            ID_Stop = Guid.NewGuid().ToString(),
        //            ID_Schedule = cbBus.SelectedValue.ToString(),
        //            IDStation_stop = row.Cells["colStation"].Value.ToString(),
        //            Stop_time = DateTime.Parse(row.Cells["colStopTime"].Value.ToString()),
        //            Stop_order = int.Parse(row.Cells["colIndex"].Value.ToString())
        //        };
        //        scheduleStopService.AddStop(stop);
        //    }
        //    MessageBox.Show("Thêm ga dừng thành công");
        //}

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dpStartTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string inputId = guna2TextBox1.Text.Trim();

            if (schedule == null || string.IsNullOrEmpty(inputId))
            {
                hasShownDuplicateMessage = false;
                return;
            }

            bool isDuplicate = schedule.Any(s => s.ID_Schedule == inputId);

            if (isDuplicate && !hasShownDuplicateMessage)
            {
                MessageBox.Show("ID đã tồn tại trong danh sách lịch trình!", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hasShownDuplicateMessage = true;
                guna2TextBox1.ForeColor = Color.Red;
            }
            else if (!isDuplicate)
            {
                guna2TextBox1.ForeColor = Color.Black;
                hasShownDuplicateMessage = false;
            }
        }
    }
}
