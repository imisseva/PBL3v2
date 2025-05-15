using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ScheduleDTO
    {
        public string ID_Schedule { get; set; }
        public string ID_bus { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public string ID_route { get; set; }
    }

}
