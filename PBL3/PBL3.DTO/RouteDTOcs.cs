using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class RouteDTO
    {
        public string ID_route { get; set; }
        public string ID_Station_start { get; set; }
        public string ID_Station_end { get; set; }
        public decimal Distance { get; set; }
        public TimeSpan Time { get; set; }
        public string Name_Station_start { get; set; }
        public string Name_Station_end { get; set; }
    }

}
