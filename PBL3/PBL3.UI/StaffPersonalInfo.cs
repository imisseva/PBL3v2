using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PBL3
{
    public partial class StaffPersonalInfo : Form
    {
        private StaffService _staffService = new StaffService();

        public StaffPersonalInfo()
        {
            InitializeComponent();
            LoadStaffData();
        }

        private void StaffPersonalInfo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadStaffData()
        {
            var staff = _staffService.GetAllStaffByID(Session.LoggedAccountId).FirstOrDefault();
            if (staff != null)
            {
                txtName.Text = staff.Name;
                txtEmail.Text = staff.email;
                txtPhone.Text = staff.phone;
                txtAddress.Text = staff.home_address;
                txtGender.Text = staff.Gender;
                txtDob.Text = staff.Dob.ToString("yyyy-MM-dd");
                txtNoiSinh.Text = staff.NoiSinh;
                txtCCCD.Text = staff.CCCD;
                txtID.Text = staff.ID_account.ToString();
            }
        }
    }
}
