using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PBL3
{
    public partial class StaffForm: Form
    {

        public StaffForm()
        {
            InitializeComponent();
            MainPanel.Visible = false; 
        }
        
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new ChangePassword());
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new StaffPersonalInfo());
        }
        private void LoadFormToPanel(Form frm)
        {
            MainPanel.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(frm);
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide(); 
                LoginForm loginForm = new LoginForm(); 
                loginForm.Show(); 
                this.Close(); 
            }
        }

        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
        }

        private void đặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new BookTicket());
        }
    }
}
