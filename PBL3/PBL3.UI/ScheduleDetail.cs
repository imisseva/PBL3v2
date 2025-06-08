using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private RouteService routeService = new RouteService();
        private Route_SubRouteService route_subrouteService = new Route_SubRouteService();
        public List<ScheduleDTO> schedule; // Danh sách đã được gán dữ liệu trước đó
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
            allStations = validStations;

            // Reset và cấu hình cơ bản
            dgvStops.Columns.Clear();
            dgvStops.AutoGenerateColumns = false;
            dgvStops.DefaultCellStyle.Font = new Font("Segoe UI", 10); // Font chữ mặc định
            dgvStops.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStops.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStops.ColumnHeadersHeight = 35;

            // Cột STT (Width nhỏ, căn giữa)
            dgvStops.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "STT",
                Name = "colIndex",
                ReadOnly = true,
                Width = 50,  // Đủ rộng để hiển thị số
                
            });

            // Cột Ga dừng (Width lớn, căn trái)
            var stationColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Ga dừng",
                Name = "colStation",
                DisplayMember = "Name_station",
                ValueMember = "ID_station",
                DataSource = new List<StationDTO>(allStations),
                Width = 400,  // Rộng để hiển thị tên ga
               
            };
            dgvStops.Columns.Add(stationColumn);

            // Cột Thời gian dừng (Width vừa, căn giữa)
            dgvStops.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Thời gian dừng(HH:mm)",
                Name = "colStopTime",
                Width = 150,
                
               
            });

            // Tự động co giãn cột Ga dừng nếu cần
            dgvStops.Columns["colStation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Ngăn người dùng kéo chỉnh kích thước cột
            foreach (DataGridViewColumn column in dgvStops.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
            dgvStops.RowsAdded += dgvStops_RowsAdded;
            dgvStops.RowsRemoved += dgvStops_RowsRemoved;
            dgvStops.EditingControlShowing += dgvStops_EditingControlShowing;
        }

        private void UpdateSTT()
        {
            for (int i = 0; i < dgvStops.Rows.Count; i++)
            {
                if (!dgvStops.Rows[i].IsNewRow)
                {
                    dgvStops.Rows[i].Cells["colIndex"].Value = (i + 1).ToString();
                }
            }
        }
        private void dgvStops_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSTT();
        }
        private void dgvStops_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateSTT();
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
            var routes = route_subrouteService.GetMainRoutes();

            routes.Insert(0, new RouteDTO
            {
                ID_route = "Vui lòng chọn chuyến", 
                               
            });

            cbRoute.DataSource = routes;
            cbRoute.DisplayMember = "ID_route";
            cbRoute.ValueMember = "ID_route";
            cbRoute.SelectedIndex = 0; // Hiển thị dòng "Chọn tuyến đường"
        }


        private void LoadStopsFromRoute(string routeId)
        {
            var intermediateStations = route_subrouteService.GetIntermediateStationsByRoute(routeId);
            InitDGVStop(intermediateStations); // tái sử dụng hàm cũ để load vào DataGridView
        }
        private void LoadStationsFromRoute(string routeId)
        {
            var StartStation = stationService.GetNameStation(routeService.GetIDstationStart(routeId));
            var EndStation = stationService.GetNameStation(routeService.GetIdStationEnd(routeId));
            txtStartSt.Text = StartStation;
            txtEndSt.Text = EndStation;
        }
        private void cbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoute.SelectedIndex > 0)
            {
                string routeId = cbRoute.SelectedValue.ToString();
                LoadStopsFromRoute(routeId);
                LoadStationsFromRoute(routeId);
            }
        }

        private void btnLoadStops_Click(object sender, EventArgs e)
        {
            if (cbRoute.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn tuyến đường!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRouteID = cbRoute.SelectedValue.ToString();
            txtEndTimeLoad();
            string startStationID = routeService.GetIDstationStart(selectedRouteID);
            DateTime startTime = dpStartTime.Value;
            DateTime endTime;
            // Format cố định để khớp với txtEndTime.Text
            string endTimeText = txtEndTime.Text;
            string format = "dd/MM/yyyy HH:mm";
            CultureInfo provider = CultureInfo.InvariantCulture;

            if (!DateTime.TryParseExact(endTimeText, format, provider, DateTimeStyles.None, out endTime))
            {
                MessageBox.Show("Thời gian kết thúc không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var schedules = scheduleService.GetBusesAvailableForSchedule(startStationID, startTime, endTime);
            cbBus.DataSource = schedules;      

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEndTime.Text)||string.IsNullOrEmpty(txtIDSchedule.Text)||cbRoute.SelectedIndex<=0||cbBus.SelectedIndex<0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            DateTime endTime;
            string endTimeText = txtEndTime.Text;
            string format = "dd/MM/yyyy HH:mm";
            CultureInfo provider = CultureInfo.InvariantCulture;

            if (!DateTime.TryParseExact(endTimeText, format, provider, DateTimeStyles.None, out endTime))
            {
                MessageBox.Show("Thời gian kết thúc không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ScheduleDTO schedule = new ScheduleDTO
            {
                ID_Schedule = txtIDSchedule.Text,
                ID_bus = cbBus.SelectedValue.ToString(),
                start_time = dpStartTime.Value,
                end_time = endTime,
                ID_route = cbRoute.SelectedValue.ToString()
            };
            scheduleService.AddSchedule(schedule);
            foreach (DataGridViewRow row in dgvStops.Rows)
            {
                if (row.IsNewRow) continue;

                var stationCell = row.Cells["colStation"] as DataGridViewComboBoxCell;
                var stopTimeCell = row.Cells["colStopTime"];
                var sttCell = row.Cells["colIndex"];

                if (stationCell?.Value == null || stopTimeCell?.Value == null)
                    continue;

                string idStation = stationCell.Value.ToString();
                string stopTimeText = stopTimeCell.Value.ToString();
                int stt=int.Parse(sttCell.Value.ToString());

                // Thử parse thời gian dừng (HH:mm) thành TimeSpan
                if (!TimeSpan.TryParseExact(stopTimeText, "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan stopDuration))
                {
                    MessageBox.Show($"Thời gian dừng không hợp lệ ở dòng {row.Index + 1}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                ScheduleStopDTO stopDTO = new ScheduleStopDTO
                {                 
                    ID_Schedule = txtIDSchedule.Text,
                    IDStation_stop  = idStation,
                    Stop_time = stopDuration,
                    Stop_order= stt
                };

                scheduleStopService.AddStop(stopDTO); // Gọi tới lớp BLL/DAL tương ứng
            }
            MessageBox.Show("Thêm lịch trình thành công");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void txtEndTimeLoad()
        {
            DateTime startTime = dpStartTime.Value;
            DateTime currentTime = startTime;

            string selectedRouteID = cbRoute.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedRouteID)) return;

            // Lấy thời gian chạy từ bảng Route (cột 'time')
            TimeSpan routeDuration = routeService.GetTime(selectedRouteID);
            currentTime = currentTime.Add(routeDuration);

            // Cộng thêm thời gian dừng (nếu có)
            foreach (DataGridViewRow row in dgvStops.Rows)
            {
                if (row.IsNewRow) continue;

                string stopTimeText = row.Cells["colStopTime"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(stopTimeText) &&
                    TimeSpan.TryParse(stopTimeText, out TimeSpan stopDuration))
                {
                    currentTime = currentTime.Add(stopDuration);
                }
            }

            txtEndTime.Text = currentTime.ToString("dd/MM/yyyy HH:mm");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            string inputId = txtIDSchedule.Text.Trim();

            if (string.IsNullOrEmpty(inputId))
            {
                hasShownDuplicateMessage = false;
                return;
            }

            bool isDuplicate = scheduleService.IsScheduleIdExists(inputId);

            if (isDuplicate && !hasShownDuplicateMessage)
            {
                MessageBox.Show("ID đã tồn tại trong danh sách lịch trình!", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hasShownDuplicateMessage = true;
            }
            else if (!isDuplicate)
            {
                hasShownDuplicateMessage = false;
            }
        }


    }
}
