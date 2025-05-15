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
    public partial class ShowSeats: Form
    {
        public string _busID;
        private List<SeatDTO> _seats;
        private BusService busService = new BusService();
        private SeatService seatService = new SeatService();
        public ShowSeats()
        {
            InitializeComponent();
        }

        private void LoadSeats()
        {
            

        }

        private void cbbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (cbbBus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một xe buýt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedBusID = cbbBus.SelectedValue.ToString();
        }

        //private void ShowSeats_Load(object sender, EventArgs e)
        //{
        //    var busList = BusService.GetBuses();
        //    cbbBus.DataSource = busList;
        //    cbbBus.DisplayMember = "ID_bus";
        //    cbbBus.ValueMember = "ID_bus";
        //    this.ControlBox = false;      
        //}
    }
}
