using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class HistoryDTO
    {
        public int ID_History { get; set; }
        public string ID_bus { get; set; }
        public string ID_Station { get; set; }
        public DateTime? arrive_time { get; set; }
        public DateTime? leave_time { get; set; }
    }

}
