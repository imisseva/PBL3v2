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

namespace PBL3
{
    public partial class RouteView : Form
    {
        private RouteService routeService = new RouteService();
        public RouteView()
        {
            InitializeComponent();
            LoadRouteData();
        }
        private void LoadRouteData(string keyword = "")
        {
            var list = routeService.GetRoutes(keyword);
            dgv.DataSource = list;
            // Cấu hình hiển thị
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ScrollBars = ScrollBars.Both;
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns["ID_route"].HeaderText = "ID Tuyến";
                dgv.Columns["Distance"].HeaderText = "Khoảng Cách";
                dgv.Columns["Time"].HeaderText = "Thời Gian";
                dgv.Columns["Name_Station_start"].HeaderText = "Tên Ga Bắt Đầu";
                dgv.Columns["Name_Station_end"].HeaderText = "Tên Ga Kết Thúc";
                if (dgv.Columns.Contains("ID_Station_start"))
                    dgv.Columns["ID_Station_start"].Visible = false;

                if (dgv.Columns.Contains("ID_Station_end"))
                    dgv.Columns["ID_Station_end"].Visible = false;
                dgv.Columns["Name_Station_start"].DisplayIndex = 1;
                dgv.Columns["Name_Station_end"].DisplayIndex = 2;
                dgv.Columns["Distance"].DisplayIndex = 3;
                dgv.Columns["Time"].DisplayIndex = 4;
                dgv.Columns["ID_route"].DisplayIndex = 0;
            }
        }
        private void BtnAdd_Click_Route(object sender, EventArgs e)
        {
            var form = new RouteDetail();
            form.IsEditMode = false;
            if (form.ShowDialog() == DialogResult.OK)
            {
                var dto = new RouteDTO
                {
                    ID_route = form.RouteID,
                    Distance = form.RouteDistance,
                    Time = form.RouteTime,
                    ID_Station_start = form.StationStartName,
                    ID_Station_end = form.StationEndName
                };
                try
                {
                    routeService.AddRoute(dto); // gọi vào BLL
                    MessageBox.Show("Thêm thành công!");
                    LoadRouteData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void BtnEdit_Click_Route(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tuyến để sửa.");
                return;
            }
            var selectedRow = dgv.SelectedRows[0];
            var dto = new RouteDTO
            {
                ID_route = selectedRow.Cells["ID_route"].Value.ToString(),
                Distance = Convert.ToDecimal(selectedRow.Cells["Distance"].Value),
                Time = TimeSpan.Parse(selectedRow.Cells["Time"].Value.ToString()),
                Name_Station_start = selectedRow.Cells["Name_Station_start"].Value.ToString(),
                Name_Station_end = selectedRow.Cells["Name_Station_end"].Value.ToString()
            };
            var form = new RouteDetail()
            {
                IsEditMode = true,
                RouteID = dto.ID_route,
                RouteDistance = dto.Distance,
                RouteTime = dto.Time,
                StationStartName = dto.Name_Station_start,
                StationEndName = dto.Name_Station_end,
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                dto.ID_route = form.RouteID;
                dto.Distance = form.RouteDistance;
                dto.Time = form.RouteTime;
                dto.ID_Station_start = form.StationStartName;
                dto.ID_Station_end = form.StationEndName;
                try
                {
                    routeService.UpdateRoute(dto);
                    MessageBox.Show("Sửa thành công!");
                    LoadRouteData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void BtnDelete_Click_Route(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tuyến để xóa.");
                return;
            }
            var selectedRow = dgv.SelectedRows[0];
            var routeID = selectedRow.Cells["ID_route"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tuyến này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    routeService.DeleteRoute(routeID);
                    MessageBox.Show("Xóa thành công!");
                    LoadRouteData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRouteData(txtSearch.Text.Trim());
        }
    }
}
