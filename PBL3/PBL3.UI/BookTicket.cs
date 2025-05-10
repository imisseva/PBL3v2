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

namespace PBL3
{
    public partial class BookTicket: Form
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        private void cbbtrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTrain = cbbtrain.SelectedValue.ToString();
            
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
    }
}
