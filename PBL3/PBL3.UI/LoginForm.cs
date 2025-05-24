using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.Services;
using PBL3.DTO;
using PBL3.UI;
namespace PBL3
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;    
            pnUser.BackColor = Color.White;
            pnPass.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            pnPass.BackColor = Color.White;
            pnUser.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;

        }

        // Trong form đăng nhập
        private void btLogin_Click(object sender, EventArgs e)
        {
            var accountService = new AccountService();
            var account = accountService.Authenticate(txtUsername.Text, txtPassword.Text);

            if (account != null)
            {
                if (account.Role == 1) // Admin
                {
                    AdminForm2 adminForm = new AdminForm2();
                    MessageBox.Show("Đăng nhập với quyền quản trị viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminForm.Show();
                    this.Hide();
                }
                else if (account.Role == 0) // Staff
                {
                    StaffPersonalInfo.Session.LoggedInAccountId = account.Id;
                    StaffForm2 staffForm = new StaffForm2();
                    MessageBox.Show("Đăng nhập với quyền là nhân viên", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    staffForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pnPass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void btForgot_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnUser_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
