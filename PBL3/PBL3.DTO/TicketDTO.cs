    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace PBL3.DTO
    {
        public class TicketDTO
        {
            public int ID_ticket { get; set; }
            public string ID_schedule { get; set; }
            public string ID_seat { get; set; }
            public int Price { get; set; }
            public DateTime booking_date { get; set; }
            public string station_start { get; set; }
            public string station_end { get; set; }
        }
    }
