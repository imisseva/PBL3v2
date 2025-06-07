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
using PBL3.UI;

namespace PBL3
{
    public partial class SeatView : Form
    {
        private SeatService seatService = new SeatService();

        public SeatView()
        {
            InitializeComponent();
            LoadBusList();
            //LoadSeatData();
        }

        private void LoadSeatData(string busId)
        {
            var list = seatService.GetSeatsByBusID(busId); // Hàm này bạn cần viết trong service
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
            cbbPickBus.DataSource = buses;
            cbbPickBus.DisplayMember = "ID_bus";
            cbbPickBus.ValueMember = "ID_bus";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSeatData(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new SeatDetail();
            form.IsEditMode = false;

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
                    //LoadSeatData();
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
                var dto = new SeatDTO
                {
                    ID_seat = dgv.CurrentRow.Cells["ID_seat"].Value.ToString(),
                    ID_bus = dgv.CurrentRow.Cells["ID_bus"].Value.ToString(),
                    seat_number = Convert.ToInt32(dgv.CurrentRow.Cells["seat_number"].Value),
                    type = dgv.CurrentRow.Cells["type"].Value.ToString()
                };

                var form = new SeatDetail
                {
                    IsEditMode = true,
                    SeatID = dto.ID_seat,
                    BusID = dto.ID_bus,
                    SeatNumber = dto.seat_number,
                    SeatType = dto.type
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    dto.seat_number = form.SeatNumber;
                    dto.type = form.SeatType;
                    seatService.UpdateSeat(dto);
                    //LoadSeatData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                string id = dgv.CurrentRow.Cells["ID_seat"].Value.ToString();
                seatService.DeleteSeat(id);
                //LoadSeatData();
            }
        }
    }
}