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
            MainPanel.Visible = false; 
        }
        private void tuyếnĐườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new RouteView());
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
        private void toaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            //LoadFormToPanel(new CabinView());

        }
        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new BusView());
        }

        private void ghếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new SeatView());
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bếnXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormToPanel(new StationView());
        }
    }
}
