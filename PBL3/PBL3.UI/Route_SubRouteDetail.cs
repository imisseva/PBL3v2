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
    public partial class Route_SubRouteDetail : Form
    {
        public bool IsEditMode { get; set; } = false;
        public string RouteParentID
        {
            get => txtParentID.Text.Trim();
            set => txtParentID.Text = value;
        }

        public string RouteChildID
        {
            get => txtChildID.Text.Trim();
            set => txtChildID.Text = value;
        }

        public int StopOrder
        {
            get => int.TryParse(txtStopOrder.Text.Trim(), out int result) ? result : 0;
            set => txtStopOrder.Text = value.ToString();
        }

        public Route_SubRouteDetail()
        {
            InitializeComponent();
        }

        private void RouteSubRouteDetail_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                txtParentID.Enabled = false;
                txtChildID.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RouteParentID) || string.IsNullOrWhiteSpace(RouteChildID))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!int.TryParse(txtStopOrder.Text.Trim(), out _))
            {
                MessageBox.Show("Stop Order phải là số nguyên.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

}
