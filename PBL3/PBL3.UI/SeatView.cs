using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PBL3.BLL.Services;
using PBL3.DTO;

namespace PBL3
{
    public partial class SeatView : Form
    {
        private SeatService seatService = new SeatService();

        public SeatView()
        {
            InitializeComponent();
            LoadBusList();
        }

        private void LoadSeatData(string busId)
        {
            var list = seatService.GetSeatsByBusID(busId);
            dgv.DataSource = list;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            if (dgv.Columns.Count > 0)
            {
                dgv.Columns["ID_seat"].HeaderText = "Mã Ghế";
                dgv.Columns["ID_bus"].HeaderText = "Mã Xe";
                dgv.Columns["seat_number"].HeaderText = "Số Ghế";
                dgv.Columns["type"].HeaderText = "Loại Ghế";
            }
        }

        private void LoadBusList()
        {
            var busService = new BusService();
            var buses = busService.GetBuses();

            // Thêm dòng đầu tiên "Chọn xe"
            var busList = new List<BusDTO>(buses);
            busList.Insert(0, new BusDTO { ID_bus = "-- Chọn xe --" });

            cbbPickBus.DataSource = busList;
            cbbPickBus.DisplayMember = "ID_bus";
            cbbPickBus.ValueMember = "ID_bus";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedBusID = cbbPickBus.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedBusID) || selectedBusID == "-- Chọn xe --")
            {
                MessageBox.Show("Vui lòng chọn một xe để tìm ghế.");
                return;
            }

            LoadSeatData(selectedBusID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedBusID = cbbPickBus.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedBusID) || selectedBusID == "-- Chọn xe --")
            {
                MessageBox.Show("Vui lòng chọn xe trước khi thêm ghế.");
                return;
            }

            var form = new SeatDetail(selectedBusID)
            {
                IsEditMode = false
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                var dto = new SeatDTO
                {
                    ID_seat = form.SeatID,
                    ID_bus = form.BusID,
                    seat_number = form.SeatNumber,
                    type = form.SeatType
                };

                try
                {
                    seatService.AddSeat(dto);
                    MessageBox.Show("Thêm ghế thành công!");
                    LoadSeatData(selectedBusID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string selectedBusID = cbbPickBus.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedBusID) || selectedBusID == "-- Chọn xe --" || dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một ghế và một xe.");
                return;
            }

            DataGridViewRow selectedRow = dgv.SelectedRows[0];

            string seatID = selectedRow.Cells["ID_seat"].Value.ToString();
            int seatNumber = Convert.ToInt32(selectedRow.Cells["seat_number"].Value);
            string seatType = selectedRow.Cells["type"].Value.ToString();

            var form = new SeatDetail(selectedBusID)
            {
                IsEditMode = true,
                SeatID = seatID,
                SeatNumber = seatNumber,
                SeatType = seatType
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                var seat = new SeatDTO
                {
                    ID_seat = form.SeatID,
                    ID_bus = form.BusID,
                    seat_number = form.SeatNumber,
                    type = form.SeatType
                };

                try
                {
                    seatService.UpdateSeat(seat);
                    MessageBox.Show("Cập nhật ghế thành công!");
                    LoadSeatData(selectedBusID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                string id = dgv.CurrentRow.Cells["ID_seat"].Value.ToString();
                seatService.DeleteSeat(id);

                string selectedBusID = cbbPickBus.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(selectedBusID) && selectedBusID != "-- Chọn xe --")
                {
                    LoadSeatData(selectedBusID);
                }
            }
        }

        private void cbbPickBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBusID = cbbPickBus.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(selectedBusID) && selectedBusID != "-- Chọn xe --")
            {
                LoadSeatData(selectedBusID);
            }
        }
    }
}
