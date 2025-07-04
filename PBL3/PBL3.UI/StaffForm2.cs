﻿using PBL3.BLL.Services;
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

    public partial class StaffForm2 : Form
    {
        private StaffDTO _currentStaff;
        private StaffService _staffService = new StaffService();
        BookTicket bookTicket;
        public StaffForm2()
        {
            InitializeComponent();
            MainPanel.Visible = false;
            SetStaffName();
        }

        private void SetStaffName()
        {
            // Lấy thông tin nhân viên vừa đăng nhập
            var staff = _staffService.GetById(Session.LoggedAccountId);
            if (staff != null)
            {
                lbUser.Text = staff.Name;
            }
            else
            {
                lbUser.Text = "Không rõ";
            }
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
      
        bool bookingticketExpand = false;

        private void bookticketTransition_Tick(object sender, EventArgs e)
        {
            if (bookingticketExpand == false)
            {
                ticketBookingContainer.Height += 10;
                if (ticketBookingContainer.Height >= 125)
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
                if (PersonalinfoContainer.Height >= 125)
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
            MainPanel.Visible = true;
            LoadFormToPanel(new StaffPersonalInfo());
        }
        private void staffInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            //staffinfo = null;
        }

        private void btBookTicket_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new BookTicket());
        }
        private void bookTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            bookTicket = null;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
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
        private void btInfoTicket_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new InfoTicket());
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new ChangePassword());
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
