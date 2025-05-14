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

    public partial class StaffForm2 : Form
    {

        StaffPersonalInfo staffinfo;
        BookTicket bookTicket;
        public StaffForm2()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        bool bookingticketExpand = false;

        private void bookticketTransition_Tick(object sender, EventArgs e)
        {
            if (bookingticketExpand == false)
            {
                ticketBookingContainer.Height += 10;
                if (ticketBookingContainer.Height >= 165)
                {
                    bookticketTransition.Stop();
                    bookingticketExpand = true;
                }
            }
            else
            {
                ticketBookingContainer.Height -= 10;
                if (ticketBookingContainer.Height <= 49)
                {
                    bookticketTransition.Stop();
                    bookingticketExpand = false;

                }
            }
        }

        private void btTicket_Click(object sender, EventArgs e)
        {
            bookticketTransition.Start();
        }

        bool personalinfoExpand = false;
        private void PersonalinfoTransition_Tick(object sender, EventArgs e)
        {
            if (personalinfoExpand == false)
            {
                PersonalinfoContainer.Height += 10;
                if (PersonalinfoContainer.Height >= 165)
                {
                    PersonalinfoTransition.Stop();
                    personalinfoExpand = true;
                }
            }
            else
            {
                PersonalinfoContainer.Height -= 10;
                if (PersonalinfoContainer.Height <= 49)
                {
                    PersonalinfoTransition.Stop();
                    personalinfoExpand = false;

                }
            }
        }
        private void btStaffInfo_Click(object sender, EventArgs e)
        {
            PersonalinfoTransition.Start();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            if (staffinfo == null)
            {
                staffinfo = new StaffPersonalInfo();
                staffinfo.FormClosed += staffInfo_FormClosed;
                staffinfo.MdiParent = this;
                staffinfo.Show();
            } else
            {
                staffinfo.Activate();
            }  
        }
        private void staffInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            staffinfo = null;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm2 loginForm = new LoginForm2();
                loginForm.Show();
                this.Close();
            }
        }

        private void btBookTicket_Click(object sender, EventArgs e)
        {
            if (bookTicket == null)
            {
                bookTicket = new BookTicket();
                bookTicket.FormClosed += bookTicket_FormClosed;
                bookTicket.MdiParent = this;
                bookTicket.Show();
            }
            else
            {
                bookTicket.Activate();
            }
        }
        private void bookTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            bookTicket = null;
        }
    }
}
