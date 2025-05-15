using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PBL3
{
    public partial class BookTicket : Form
    {
        private BusService BusService = new BusService();
        private SeatService SeatService = new SeatService();
        private List<SeatDTO> selectedSeats = new List<SeatDTO>();
        public BookTicket()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtTicketID.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập ID vé");
            //    return;
            //}

            //xử lý logic đặt vé 

            MessageBox.Show("Đặt vé thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btPickSeat_Click(object sender, EventArgs e)
        {

        }
    }
}
