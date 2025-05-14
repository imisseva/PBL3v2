using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Repositories;
using PBL3.DTO;

namespace PBL3.BLL.Services
{
    public class Route_SubRouteService
    {
        private Route_SubRouteRepository _repo = new Route_SubRouteRepository();

        public List<RouteDTO> GetMainRoutes()
        {
            return _repo.GetMainRoutes();
        }
        public List<StationDTO> GetIntermediateStationsByRoute(string routeID)
        {
            return  _repo.GetIntermediateStationsByRoute(routeID);
        }

    }
}
