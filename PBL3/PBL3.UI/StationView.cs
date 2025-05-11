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
    public partial class StationView : Form
    {
        private StationService stationService = new StationService();

        public StationView()
        {
            
            InitializeComponent();
            LoadStationData();
        }
        private void LoadStationData(string keyword = "")
        {
            var list = stationService.GetStations(keyword);
            dgv.DataSource = list;
            // Cấu hình hiển thị
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns["ID_station"].HeaderText = "ID Bến";
                dgv.Columns["Name_station"].HeaderText = "Tên Bến Xe";
                dgv.Columns["Location"].HeaderText = "Vị Trí";
            }
        }

        private void BtnSearch_Click_Station(object sender, EventArgs e)
        {
            LoadStationData(txtSearch.Text.Trim());
        }

        private void BtnAdd_Click_Station(object sender, EventArgs e)
        {
            var form = new StationDetail();
            form.IsEditMode = false;

            if (form.ShowDialog() == DialogResult.OK)
            {
                var dto = new StationDTO
                {
                    ID_station = form.StationID,
                    Name_station = form.StationName,
                    Location = form.StationLocation
                };

                try
                {
                    stationService.AddStation(dto); // gọi vào BLL
                    MessageBox.Show("Thêm thành công!");
                    LoadStationData(); // load lại DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể thêm: " + ex.Message);
                }
            }
        }
        private void BtnEdit_Click_Station(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                var dto = new StationDTO
                {
                    ID_station = dgv.CurrentRow.Cells["ID_station"].Value.ToString(),
                    Name_station = dgv.CurrentRow.Cells["Name_Station"].Value.ToString(),
                    Location = dgv.CurrentRow.Cells["Location"].Value.ToString()
                };

                var form = new StationDetail
                {
                    IsEditMode = true,
                    StationID = dto.ID_station,
                    StationName = dto.Name_station,
                    StationLocation = dto.Location
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    dto.Name_station = form.StationName;
                    dto.Location = form.StationLocation;
                    stationService.UpdateStation(dto);
                    LoadStationData();
                }
            }
        }

        private void BtnDelete_Click_Station(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                string id = dgv.CurrentRow.Cells["ID_station"].Value.ToString();
                stationService.DeleteStation(id);
                LoadStationData();
            }
        }

        private void StationView_Load(object sender, EventArgs e)
        {

        }
    }
}
