using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PBL3.UI
{
    public partial class StaffUpdateInfo : Form
    {
        private StaffDTO _currentStaff;

        public StaffUpdateInfo()
        {
            InitializeComponent();
            LoadCurrentStaff();
        }

        private void LoadCurrentStaff()
        {
            try
            {
                var staffService = new StaffService();
                _currentStaff = staffService.GetAllStaffByID(Session.LoggedAccountId).FirstOrDefault();

                if (_currentStaff != null)
                {
                    LoadStaffInfo(_currentStaff);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStaffInfo(StaffDTO staff)
        {
            txtID.Text = staff.ID_account.ToString();
            txtName.Text = staff.Name;
            txtEmail.Text = staff.email;
            txtDob.Text = staff.Dob.ToString("yyyy-MM-dd");
            txtNoiSinh.Text = staff.NoiSinh;
            txtAddress.Text = staff.home_address;
            txtCCCD.Text = staff.CCCD;
            txtPhone.Text = staff.phone;
            txtGender.Text = staff.Gender;

            // Các trường chỉ xem
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtDob.ReadOnly = true;
            txtNoiSinh.ReadOnly = true;
            txtCCCD.ReadOnly = true;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (_currentStaff == null)
            {
                MessageBox.Show("Không có thông tin nhân viên để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentStaff.email = txtEmail.Text.Trim();
            _currentStaff.home_address = txtAddress.Text.Trim();
            _currentStaff.phone = txtPhone.Text.Trim();
            _currentStaff.Gender = txtGender.Text.Trim();

            try
            {
                var service = new StaffService();
                service.UpdateStaff(_currentStaff);

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
