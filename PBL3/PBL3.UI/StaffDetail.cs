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
using PBL3.UI;

namespace PBL3
{
    public partial class StaffDetail : Form
    {
        private StationService _stationService = new StationService();
        public StaffDetail()
        {
            InitializeComponent();

        }

        public bool IsEditMode { get; set; } = false;

        public int StaffID
        {
            get => int.TryParse(txtID.Text.Trim(), out int id) ? id : 0;
            set => txtID.Text = value.ToString();
        }

        public string StaffName
        {
            get => txtName.Text.Trim();
            set => txtName.Text = value;
        }

        public string StaffEmail
        {
            get => txtEmail.Text.Trim();
            set => txtEmail.Text = value;
        }

        public string StaffPhone
        {
            get => txtPhone.Text.Trim();
            set => txtPhone.Text = value;
        }

        public string StaffAddress
        {
            get => txtAddress.Text.Trim();
            set => txtAddress.Text = value;
        }

        public DateTime StaffDateOfBirth
        {
            get => dtpDob.Value;
            set => dtpDob.Value = value;
        }

        public string StaffPlaceOfBirth
        {
            get => txtNoiSinh.Text.Trim();
            set => txtNoiSinh.Text = value;
        }

        public string StaffCCCD
        {
            get => txtCCCD.Text.Trim();
            set => txtCCCD.Text = value;
        }

        public string StaffGender
        {
            get => txtGender.Text.Trim();
            set => txtGender.Text = value;
        }

        public string StaffStationID
        {
            get => cbbStation.Text.Trim();
            set => cbbStation.Text = value;
        }

        private void StaffDetail_Load(object sender, EventArgs e)
        {
            var stations = _stationService.GetStations();
            cbbStation.DataSource = stations;
            cbbStation.DisplayMember = "ID_station"; 
            cbbStation.ValueMember = "ID_station";   

            if (IsEditMode)
            {
                txtID.Enabled = false;
                cbbStation.SelectedValue = StaffStationID;
            }
            else
            {
                txtID.Enabled = false;
                txtID.Clear();
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                dtpDob.Value = DateTime.Today;
                txtNoiSinh.Clear();
                txtCCCD.Clear();
                txtGender.Clear();
                cbbStation.SelectedIndex = -1;
            }
        }


        private void btOK_Click(object sender, EventArgs e)
        {
            // Mở form tạo tài khoản
            using (var f = new AccountDetail())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Lấy ID tài khoản vừa tạo để gán cho nhân viên
                    StaffID = f.CreatedStaffID;
                }
                else
                {
                    // Nếu không tạo tài khoản thì không tiếp tục
                    MessageBox.Show("Bạn phải tạo tài khoản trước khi thêm nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(StaffName) ||
                string.IsNullOrWhiteSpace(StaffEmail) ||
                string.IsNullOrWhiteSpace(StaffPhone) ||
                string.IsNullOrWhiteSpace(StaffAddress) ||
                string.IsNullOrWhiteSpace(StaffPlaceOfBirth) ||
                string.IsNullOrWhiteSpace(StaffCCCD) ||
                string.IsNullOrWhiteSpace(StaffGender) ||
                string.IsNullOrWhiteSpace(StaffStationID))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đóng form và trả kết quả OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
