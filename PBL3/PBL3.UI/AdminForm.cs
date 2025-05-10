using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PBL3
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
            MainPanel.Visible = false; // Ẩn panel khi khởi động form
        }

        private void gaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new StationView());
        }
        private void tuyếnĐườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new RouteView());
        }
        private void tàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            //LoadFormToPanel(new BusView());
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

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            //LoadFormToPanel(new StaffView());
        }

        private void toaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            //LoadFormToPanel(new CabinView());

        }
    }
}
