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
    public partial class Route_SubrouteView : Form
    {
        private Route_SubRouteService routeSubRouteService = new Route_SubRouteService();
        public Route_SubrouteView()
        {
            InitializeComponent();
            LoadRouteSubRouteData();
        }
        private void LoadRouteSubRouteData(string keyword = "")
        {
            var list = routeSubRouteService.GetAll(keyword);
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
                dgv.Columns["ID_route_parent"].HeaderText = "ID Tuyến Chính";
                dgv.Columns["ID_route_child"].HeaderText = "ID Tuyến Phụ";
                dgv.Columns["StopOrder"].HeaderText = "Thứ Tự Dừng";

                // Ẩn các cột không cần nếu có
                var columnNamesToKeep = new List<string> { "ID_route_parent", "ID_route_child", "StopOrder" };
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (!columnNamesToKeep.Contains(col.Name))
                        col.Visible = false;
                }

                // Đặt thứ tự cột hiển thị
                dgv.Columns["ID_route_parent"].DisplayIndex = 0;
                dgv.Columns["ID_route_child"].DisplayIndex = 1;
                dgv.Columns["StopOrder"].DisplayIndex = 2;
            }
        }
        private void BtnAdd_Click_RouteSubRoute(object sender, EventArgs e)
        {
            var form = new Route_SubRouteDetail();
            form.IsEditMode = false;
            if (form.ShowDialog() == DialogResult.OK)
            {
                var dto = new Route_SubRouteDTO
                {
                    ID_route_parent = form.RouteParentID,
                    ID_route_child = form.RouteChildID,
                    StopOrder = form.StopOrder
                };
                try
                {
                    routeSubRouteService.Add(dto);
                    MessageBox.Show("Thêm thành công!");
                    LoadRouteSubRouteData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void BtnEdit_Click_RouteSubRoute(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                return;
            }

            var selectedRow = dgv.SelectedRows[0];
            var dto = new Route_SubRouteDTO
            {
                ID_route_parent = selectedRow.Cells["ID_route_parent"].Value.ToString(),
                ID_route_child = selectedRow.Cells["ID_route_child"].Value.ToString(),
                StopOrder = Convert.ToInt32(selectedRow.Cells["StopOrder"].Value)
            };

            var form = new Route_SubRouteDetail
            {
                IsEditMode = true,
                RouteParentID = dto.ID_route_parent,
                RouteChildID = dto.ID_route_child,
                StopOrder = dto.StopOrder
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    routeSubRouteService.Update(new Route_SubRouteDTO
                    {
                        ID_route_parent = form.RouteParentID,
                        ID_route_child = form.RouteChildID,
                        StopOrder = form.StopOrder
                    });
                    MessageBox.Show("Sửa thành công!");
                    LoadRouteSubRouteData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void BtnDelete_Click_RouteSubRoute(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                return;
            }

            var selectedRow = dgv.SelectedRows[0];
            string parentID = selectedRow.Cells["ID_route_parent"].Value.ToString();
            string childID = selectedRow.Cells["ID_route_child"].Value.ToString();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    routeSubRouteService.Delete(parentID, childID);
                    MessageBox.Show("Xóa thành công!");
                    LoadRouteSubRouteData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void txtSearchRouteSubRoute_TextChanged(object sender, EventArgs e)
        {
            LoadRouteSubRouteData(txtSearchRouteSubRoute.Text.Trim());
        }
    }
}
