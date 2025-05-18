using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace PBL3.DTO
{
    public class BusTicketDTO
    {
        public string ID_schedule {  get; set; }
        public string BusID { get; set; }
        public string SeatType { get; set; }
        public int Quantity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
