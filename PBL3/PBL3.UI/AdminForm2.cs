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
    public partial class AdminForm2: Form
    {
        public AdminForm2()
        {
            InitializeComponent();
            MainPanel.Visible = false;
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
   
        private void btStaffInfo_Click(object sender, EventArgs e)
        {
            personalContainerTransition.Start();
        }

        private void btBusStation_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new StationView());
        }
        bool busManagementExpand = false;
        private void busManagementTransition_Tick(object sender, EventArgs e)
        {
            if (busManagementExpand == false)
            {
                BusManagementContainer.Height += 10;
                if (BusManagementContainer.Height >= 125)
                {
                    busManagementTransition.Stop();
                    busManagementExpand = true;
                }
            }
            else
            {
                BusManagementContainer.Height -= 10;
                if (BusManagementContainer.Height <= 49)
                {
                    busManagementTransition.Stop();
                    busManagementExpand = false;
                }
            }
        }

        private void btBusManage_Click(object sender, EventArgs e)
        {
            busManagementTransition.Start();
        }

        private void btBus_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new BusView());
        }

        private void btSeat_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new SeatView());
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new StaffView());
        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new ScheduleView());
        }
        bool revenueExpand = false;
        private void revenueTransition_Tick(object sender, EventArgs e)
        {
            if (revenueExpand == false)
            {
                RevenueContainer.Height += 10;
                if (RevenueContainer.Height >= 125)
                {
                    RevenueTransition.Stop();
                    revenueExpand = true;
                }
            }
            else
            {
                RevenueContainer.Height -= 10;
                if (RevenueContainer.Height <= 49)
                {
                    RevenueTransition.Stop();
                    revenueExpand = false;
                }
            }
        }
        private void btRevenue_Click(object sender, EventArgs e)
        {
            RevenueTransition.Start();
        }

        bool routeExpand = false;
        private void routeTransition_Tick(object sender, EventArgs e)
        {
            if (routeExpand == false)
            {
                RouteContainer.Height += 10;
                if (RouteContainer.Height >= 125)
                {
                    routeTransition.Stop();
                    routeExpand = true;
                }
            }
            else
            {
                RouteContainer.Height -= 10;
                if (RouteContainer.Height <= 49)
                {
                    routeTransition.Stop();
                    routeExpand = false;
                }
            }
        }
        private void btRoute_Click(object sender, EventArgs e)
        {
           routeTransition.Start();
        }
        

        private void btMonthRevenue_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new RevenueView());
        }

        private void btYearRevenue_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new YearRevenueView());
        }

        private void btMainRoute_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new RouteView());
        }

        private void btSubRoute_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new Route_SubrouteView());

        }
    }
}
