using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.UI
{
    public partial class StaffUpdateInfo: Form
    {
        private StaffDTO _staff;

        public StaffUpdateInfo()
        {
            InitializeComponent();
        }

        public StaffUpdateInfo(StaffDTO staff)
        {
            InitializeComponent();
            _staff = staff;
            LoadStaffInfo();
        }

        private void LoadStaffInfo()
        {
            txtID.Text = _staff.ID_account.ToString();
            txtName.Text = _staff.Name;
            txtEmail.Text = _staff.email;
            txtDob.Text = _staff.Dob.ToString("yyyy-MM-dd");
            txtNoiSinh.Text = _staff.NoiSinh;
            txtAddress.Text = _staff.home_address;
            txtCCCD.Text = _staff.CCCD;
            txtPhone.Text = _staff.phone;
            txtGender.Text = _staff.Gender;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            // Cập nhật lại các trường được phép chỉnh sửa
            _staff.email = txtEmail.Text;
            _staff.home_address = txtAddress.Text;
            _staff.phone = txtPhone.Text;
            _staff.Gender = txtGender.Text;

            StaffService service = new StaffService();
            service.UpdateStaff(_staff);

            MessageBox.Show("Cập nhật thành công!");
        }

    }
}
