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

    public partial class RouteDetail : Form
    {
        private StationService stationService = new StationService();

        public RouteDetail()
        {
            InitializeComponent();
            RouteDetail_Load_1();

        }

        public bool IsEditMode { get; internal set; }
        public string RouteID {
            get => txtID.Text.Trim(); 
            set => txtID.Text = value;
        }
        public decimal RouteDistance {
            get
            {
                if (decimal.TryParse(txtDistance.Text.Trim(), out decimal distance))
                {
                    return distance;
                }
                return 0;
            }
            set => txtDistance.Text = value.ToString();
        }
        public TimeSpan RouteTime {
            get
            {
                if (TimeSpan.TryParse(txtTime.Text.Trim(), out TimeSpan time))
                {
                    return time;
                }
                return TimeSpan.Zero;
            }
            set => txtTime.Text = value.ToString(@"hh\:mm\:ss");
        }
        public string StationStartName {
            get
            {
                if (cbStartSt.SelectedItem is StationDTO station)
                {
                    return station.Name_station;
                }
                return string.Empty;
            }
            set => cbStartSt.Text = value;
        }
        public string StationEndName {
            get
            {
                if (cbEndSt.SelectedItem is StationDTO station)
                {
                    return station.Name_station;
                }
                return string.Empty;
            }
            set => cbEndSt.Text = value;
        }

        private void RouteDetail_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                txtID.Enabled = false; // không cho sửa ID
                txtTime.Enabled = false; // không cho sửa thời gian
            }
            else
            {
                txtID.Enabled = true;
                txtID.Clear();
                txtDistance.Clear();
                txtTime.Clear();
                cbStartSt.SelectedItem = null;
                cbEndSt.SelectedItem = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào 
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                errorProvider1.SetError(txtID, "Vui lòng nhập ID Tuyến");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDistance.Text))
            {
                errorProvider1.SetError(txtDistance, "Vui lòng nhập Khoảng Cách");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTime.Text))
            {
                errorProvider1.SetError(txtTime, "Vui lòng nhập Thời Gian");
                return;
            }
            if (cbStartSt.SelectedItem == null)
            {
                errorProvider1.SetError(cbStartSt, "Vui lòng chọn Ga đi");
                return;
            }
            if (cbEndSt.SelectedItem == null)
            {
                errorProvider1.SetError(cbEndSt, "Vui lòng chọn Ga đến");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Đóng form mà không trả về giá trị nào
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void RouteDetail_Load_1()
        {
            // Load danh sách ga vào ComboBox
            var stations = stationService.GetStations();
            cbStartSt.DataSource = stations;
            cbStartSt.DisplayMember = "Name_station";
            cbStartSt.ValueMember = "ID_station";
            cbEndSt.DataSource = stations;
            cbEndSt.DisplayMember = "Name_station";
            cbEndSt.ValueMember = "ID_station";
        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDistance.Text))
            {
                txtTime.Text = "";
                errorProvider1.SetError(txtDistance, ""); // Xóa thông báo lỗi cũ nếu có
                return;
            }

            if (decimal.TryParse(txtDistance.Text.Trim(), out decimal distance))
            {
                // Xóa thông báo lỗi nếu đúng định dạng
                errorProvider1.SetError(txtDistance, "");

                decimal speed = 76.58m;
                decimal hours = distance / speed;
                int totalSeconds = (int)(hours * 3600);
                TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

                txtTime.Text = time.ToString(@"hh\:mm\:ss");
            }
            else
            {
                txtTime.Text = "";
                errorProvider1.SetError(txtDistance, "Vui lòng nhập đúng định dạng số (ví dụ: 120.5)");
            }
        }

    }
}
