using PBL3.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PBL3.StaffForm;
using PBL3.DTO;

namespace PBL3
{
    public partial class StaffPersonalInfo : Form
    {
        private StaffService _staffService = new StaffService();
        //private int _loggedInAccountId = 1008;
        public static class Session
        {
            public static int LoggedInAccountId { get; set; }
        }
        public StaffPersonalInfo()
        {
            InitializeComponent();
            LoadStaffData();
        }
          private void LoadStaffData()
        {
            var staff = _staffService.GetAllStaffByID(Session.LoggedInAccountId).FirstOrDefault();
            if (staff != null)
            {
                txtName.Text = staff.Name;
                txtEmail.Text = staff.email;
                txtPhone.Text = staff.phone;
                txtAddress.Text = staff.DiaChiNha;
                txtGender.Text = staff.Gender;
                txtDob.Text = staff.NgaySinh.ToString("yyyy-MM-dd");
                txtNoiSinh.Text = staff.NoiSinh;
                txtCCCD.Text = staff.CCCD;
                txtID.Text = staff.ID_account.ToString();
                txtStation.Text = staff.ID_station;
            }
        }
    }
}

