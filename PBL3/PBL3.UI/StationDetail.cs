using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3
{
    public partial class StationDetail : Form
    {
        public StationDetail()
        {
            InitializeComponent();
        }
        public bool IsEditMode { get; set; } = false;

        public string StationID
        {
            get => txtID.Text.Trim();
            set => txtID.Text = value;
        }

        public string StationName
        {
            get => txtName.Text.Trim();
            set => txtName.Text = value;
        }

        public string StationLocation
        {
            get => txtLocation.Text.Trim();
            set => txtLocation.Text = value;
        }

        private void StationDetail_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                txtID.Enabled = false; // không cho sửa ID
            }
            else
            {
                txtID.Enabled = true;
                txtID.Clear();
                txtName.Clear();
                txtLocation.Clear();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(StationID) ||
                string.IsNullOrWhiteSpace(StationName) ||
                string.IsNullOrWhiteSpace(StationLocation))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
