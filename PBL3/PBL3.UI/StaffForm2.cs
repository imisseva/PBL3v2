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
    public partial class StaffForm2: Form
    {
        public StaffForm2()
        {
            InitializeComponent();
        }

        bool bookTicketExpand = false;
        private void ticketbookingTransition_Tick(object sender, EventArgs e)
        {
            if (bookTicketExpand == false)
            {
                ticketbookingContainer.Height += 10;
                if (ticketbookingContainer.Height >= 243)
                {
                    ticketbookingTransition.Stop();
                    bookTicketExpand = true;
                }
            }
            else
            {
                ticketbookingContainer.Height -= 15;
                if (ticketbookingContainer.Height <= 48)
                {
                    ticketbookingTransition.Stop();
                    bookTicketExpand= false;
                }
            }

        }

        private void btTicket_Click(object sender, EventArgs e)
        {
            ticketbookingTransition.Start();
        }


      
    }
}
