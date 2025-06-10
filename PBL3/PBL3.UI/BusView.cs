using PBL3.BLL.Services;
using PBL3.DTO;
using PBL3.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PBL3
{
    public partial class BusView : Form
    {
        private BusService busService = new BusService();

        public BusView()
        {
            InitializeComponent();
            LoadBusData();
        }

        private void LoadBusData(string keyword = "")
        {
            var list = busService.GetBuses(keyword)
                .Select(bus => new
                {
                    ID_bus = bus.ID_bus,
                    Quantity = bus.Quantity,
                    Status = bus.Status == "1" ? "Hoạt động" :
                             bus.Status == "0" ? "Không hoạt động" : "Không rõ"
                }).ToList();

            dgv.DataSource = list;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            if (dgv.Columns.Count > 0)
            {
                dgv.Columns["ID_bus"].HeaderText = "Mã Xe";
                dgv.Columns["Quantity"].HeaderText = "Số Lượng Ghế";
                dgv.Columns["Status"].HeaderText = "Trạng Thái";
            }
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new BusDetail();
            form.IsEditMode = false;

            if (form.ShowDialog() == DialogResult.OK)
            {
                var dto = new BusDTO
                {
                    ID_bus = form.BusID,
                    Quantity = form.Quantity,
                    Status = form.Status.ToString()
                };

                try
                {
                    busService.AddBus(dto);
                    MessageBox.Show("Thêm xe thành công!");
                    LoadBusData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                string id = dgv.CurrentRow.Cells["ID_bus"].Value.ToString();
                int quantity = Convert.ToInt32(dgv.CurrentRow.Cells["Quantity"].Value);
                string statusText = dgv.CurrentRow.Cells["Status"].Value.ToString();

                int status = statusText == "Hoạt động" ? 1 :
                             statusText == "Không hoạt động" ? 0 : -1;

                if (status == -1)
                {
                    MessageBox.Show("Trạng thái không hợp lệ.");
                    return;
                }

                var form = new BusDetail
                {
                    IsEditMode = true,
                    BusID = id,
                    Quantity = quantity,
                    Status = status
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var dto = new BusDTO
                    {
                        ID_bus = form.BusID,
                        Quantity = form.Quantity,
                        Status = form.Status.ToString() // Status là int, cần ToString() để khớp với DTO
                    };

                    try
                    {
                        busService.UpdateBus(dto);
                        LoadBusData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật: " + ex.Message);
                    }
                }
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                string id = dgv.CurrentRow.Cells["ID_bus"].Value.ToString();
                busService.DeleteBus(id);
                LoadBusData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBusData(txtSearch.Text.Trim());
        }
    }
}
