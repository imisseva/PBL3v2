using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.UI
{
    public partial class LoginForm2: Form
    {
        public LoginForm2()
        {
            InitializeComponent();
        }

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

    }
}
