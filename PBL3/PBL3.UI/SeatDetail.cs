using System;
using System.Windows.Forms;
using PBL3.BLL.Services;

namespace PBL3
{
    public partial class SeatDetail : Form
    {
        public bool IsEditMode { get; set; } = false;
        private string preSelectedBusID = null;

        public string SeatID
        {
            get => txtIDSeat.Text.Trim();
            set => txtIDSeat.Text = value;
        }

        public string BusID
        {
            get => txtBusID.Text.Trim();
            set => txtBusID.Text = value;
        }

        public int SeatNumber
        {
            get => (int)numSeatNumber.Value;
            set => numSeatNumber.Value = value;
        }

        public string SeatType
        {
            get => cbType.SelectedValue?.ToString();
            set => cbType.SelectedValue = value;
        }

        public SeatDetail()
        {
            InitializeComponent();
        }

        public SeatDetail(string busID) : this()
        {
            preSelectedBusID = busID;
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

            txtBusID.Enabled = false;
            txtIDSeat.Enabled = false;

            if (!string.IsNullOrEmpty(preSelectedBusID))
            {
                txtBusID.Text = preSelectedBusID;
            }

            if (IsEditMode)
            {
                // Không làm gì thêm – giữ nguyên dữ liệu được truyền từ SeatView
            }
            else
            {
                // Chỉ sinh ID ghế mới nếu đang ở chế độ thêm
                if (!string.IsNullOrEmpty(preSelectedBusID))
                {
                    var seatService = new SeatService();
                    string newID = seatService.GenerateNextSeatID(preSelectedBusID);
                    txtIDSeat.Text = newID;
                }

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
