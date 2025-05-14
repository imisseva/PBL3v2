using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ScheduleStopDTO
    {
        public int ID_Stop { get; set; }
        public string ID_Schedule { get; set; }
        public string IDStation_stop { get; set; }
        public TimeSpan Stop_time { get; set; }
        public int Stop_order { get; set; }
    }

}
