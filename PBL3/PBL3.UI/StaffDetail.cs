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
    public partial class StaffDetail : Form
    {
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
            get => txtStationID.Text.Trim();
            set => txtStationID.Text = value;
        }

        private void StaffDetail_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                txtID.Enabled = false;
            }
            else
            {
                txtID.Enabled = true;
                txtID.Clear();
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                dtpDob.Value = DateTime.Today;
                txtNoiSinh.Clear();
                txtCCCD.Clear();
                txtGender.Clear();
                txtStationID.Clear();
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
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
