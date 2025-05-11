using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL3
{
    public partial class SeatDetail : Form
    {
        public bool IsEditMode { get; set; } = false;

        public string SeatID
        {
            get => txtIDSeat.Text.Trim();
            set => txtIDSeat.Text = value;
        }

        public string BusID
        {
            get => cbIDBus.SelectedValue.ToString();
            set => cbIDBus.SelectedValue = value;
        }

        public int SeatNumber
        {
            get => (int)numSeatNumber.Value;
            set => numSeatNumber.Value = value;
        }

        public string SeatType
        {
            get => cbType.SelectedValue.ToString();
            set => cbType.SelectedValue = value;
        }

        public SeatDetail()
        {
            InitializeComponent();
        }

        private void SeatDetail_Load(object sender, EventArgs e)
        {
            cbType.DataSource = new[]
            {
        new { Text = "giường nằm", Value = "giường nằm" },
        new { Text = "giường đôi", Value = "giường đôi" }
    };
            cbType.DisplayMember = "Text";
            cbType.ValueMember = "Value";


            if (IsEditMode)
            {
                txtIDSeat.Enabled = false;
            }
            else
            {
                txtIDSeat.Clear();
                cbIDBus.SelectedIndex = -1;
                numSeatNumber.Value = 1;
                cbType.SelectedIndex = 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SeatID) || string.IsNullOrWhiteSpace(BusID))
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