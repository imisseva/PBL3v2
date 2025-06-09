using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Context;
using PBL3.DAL.Entities;
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
    public List<Route_SubRouteDTO> GetAll(string keyword = "")
        {
            using (var db = new BusManagement())
            {
                return db.Route_SubRoute
                    .Where(rs =>
                        rs.ID_route_parent.Contains(keyword) ||
                        rs.ID_route_child.Contains(keyword))
                    .Select(rs => new Route_SubRouteDTO
                    {
                        ID_route_parent = rs.ID_route_parent,
                        ID_route_child = rs.ID_route_child,
                        StopOrder = rs.StopOrder,
                    })
                    .ToList();
            }
        }

        public void Add(Route_SubRouteDTO dto)
        {
            using (var db = new BusManagement())
            {
                bool exists = db.Route_SubRoute.Any(rs =>
                    rs.ID_route_parent == dto.ID_route_parent &&
                    rs.ID_route_child == dto.ID_route_child);

                if (exists)
                    throw new Exception("Quan hệ Route_SubRoute đã tồn tại.");

                db.Route_SubRoute.Add(new Route_SubRoute
                {
                    ID_route_parent = dto.ID_route_parent,
                    ID_route_child = dto.ID_route_child,
                    StopOrder = dto.StopOrder
                });

                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Console.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" has the following validation errors:");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                    }
                    throw;
                }
            }
        }

        public void Update(Route_SubRouteDTO dto)
        {
            using (var db = new BusManagement())
            {
                var entity = db.Route_SubRoute
                    .FirstOrDefault(rs => rs.ID_route_parent == dto.ID_route_parent &&
                                          rs.ID_route_child == dto.ID_route_child);

                if (entity == null)
                    throw new Exception("Không tìm thấy Route_SubRoute để cập nhật.");

                entity.StopOrder = dto.StopOrder;

                db.SaveChanges();
            }
        }

        public void Delete(string parentID, string childID)
        {
            using (var db = new BusManagement())
            {
                var entity = db.Route_SubRoute
                    .FirstOrDefault(rs => rs.ID_route_parent == parentID &&
                                          rs.ID_route_child == childID);

                if (entity == null)
                    throw new Exception("Không tìm thấy Route_SubRoute để xóa.");

                db.Route_SubRoute.Remove(entity);
                db.SaveChanges();
            }
        }

        public Route_SubRoute GetById(string parentID, string childID)
        {
            using (var db = new BusManagement())
            {
                return db.Route_SubRoute
                    .FirstOrDefault(rs => rs.ID_route_parent == parentID &&
                                          rs.ID_route_child == childID);
            }
        }
    }
}
