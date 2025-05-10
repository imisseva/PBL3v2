using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.Services;
using PBL3.DTO;

namespace PBL3
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string OldPass = txtOldPass.Text;
            string NewPass = txtNewPass.Text;
            string ConfirmPass = txtConfirmPass.Text;
            if (NewPass != ConfirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }
            var service = new AccountService();
            bool result = service.ChangePassword(StaffPersonalInfo.Session.LoggedInAccountId, OldPass, NewPass);
            if (result)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
        }
    }
}
