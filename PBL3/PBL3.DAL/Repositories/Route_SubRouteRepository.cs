using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Context;
using PBL3.DTO;

namespace PBL3.DAL.Repositories
{
    public class Route_SubRouteRepository
    {
        public List<RouteDTO> GetMainRoutes()
        {
            try
            {
                using (var context = new BusManagement())
                {
                    // Lấy danh sách ID của các tuyến chính (ID_route_parent)
                    var mainRouteIds = context.Route_SubRoute
                        .Select(rs => rs.ID_route_parent)
                        .Distinct()
                        .ToList();

                    // Lấy các tuyến có ID nằm trong danh sách mainRouteIds
                    var mainRoutes = context.Routes
                        .Where(r => mainRouteIds.Contains(r.ID_route))
                        .Select(r => new RouteDTO
                        {
                            ID_route = r.ID_route,
                        })
                        .ToList();

                    return mainRoutes;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy tuyến chính: " + ex.Message);
            }
        }
        public List<StationDTO> GetIntermediateStationsByRoute(string routeID)
        {
            try
            {
                using (var context = new BusManagement())
                {
                    // Lấy danh sách tuyến phụ theo route cha
                    var childRoutes = context.Route_SubRoute
                        .Where(rs => rs.ID_route_parent == routeID)
                        .OrderBy(rs => rs.StopOrder)
                        .Select(rs => rs.ID_route_child)
                        .ToList();

                    // Lấy danh sách ID_station_end từ các tuyến phụ
                    var stationIDs = context.Routes
                        .Where(r => childRoutes.Contains(r.ID_route))
                        .Select(r => r.ID_Station_end)
                        .ToList();

                    // Truy tên ga theo ID
                    var stations = context.Stations
                        .Where(s => stationIDs.Contains(s.ID_station))
                        .Select(s => new StationDTO
                        {
                            ID_station = s.ID_station,
                            Name_station = s.Name_station,
                        })
                        .ToList();

                    return stations;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy ga trung gian từ tuyến chính", ex);
            }
        }
    }
}
