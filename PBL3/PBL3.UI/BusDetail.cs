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
    public partial class BusDetail : Form
    {
        public bool IsEditMode { get; set; } = false;

        public string BusID
        {
            get => txtIDBus.Text.Trim();
            set => txtIDBus.Text = value;
        }

        public int Quantity
        {
            get => (int)numSeat.Value;
            set => numSeat.Value = value;
        }

        public int Status
        {
            get => (int)cbStatus.SelectedValue;
            set => cbStatus.SelectedValue = value;
        }

        public BusDetail()
        {
            InitializeComponent();
        }

        private void BusDetail_Load(object sender, EventArgs e)
        {
            cbStatus.DataSource = new[]
            {
                new { Text = "Hoạt động", Value = 1 },
                new { Text = "Không hoạt động", Value = 0 }
            };
            cbStatus.DisplayMember = "Text";
            cbStatus.ValueMember = "Value";

            if (IsEditMode)
                txtIDBus.Enabled = false;
            else
            {
                txtIDBus.Clear();
                numSeat.Value = 1;
                cbStatus.SelectedIndex = 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BusID))
            {
                MessageBox.Show("Mã xe không được để trống.");
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