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
        public List<Route_SubRouteDTO> GetAll(string keyword = "")
        {
            return _repo.GetAll(keyword);
        }

        public void Add(Route_SubRouteDTO dto)
        {
            _repo.Add(dto);
        }

        public void Update(Route_SubRouteDTO dto)
        {
            _repo.Update(dto);
        }

        public void Delete(string parentID, string childID)
        {
            _repo.Delete(parentID, childID);
        }

        public Route_SubRouteDTO GetById(string parentID, string childID)
        {
            var entity = _repo.GetById(parentID, childID);
            if (entity == null) return null;

            return new Route_SubRouteDTO
            {
                ID_route_parent = entity.ID_route_parent,
                ID_route_child = entity.ID_route_child,
                StopOrder = entity.StopOrder
                // Có thể bổ sung Name_route nếu cần
            };
        }
    }
}
