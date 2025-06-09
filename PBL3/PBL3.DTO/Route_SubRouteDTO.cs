using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Route_SubRouteDTO
    {
        public string ID_route_parent { get; set; }
        public string ID_route_child { get; set; }
        public int StopOrder { get; set; }
    }
}
