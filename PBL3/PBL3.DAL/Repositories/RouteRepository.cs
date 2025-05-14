using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Context;
using PBL3.DAL.Entities;
using PBL3.DTO;
namespace PBL3.DAL.Repositories
{
    public class RouteRepository
    {
       

        public List<RouteDTO> GetAll(string keyword = "")
        {
            using (var db = new BusManagement())
            {
                return db.Routes
                    .Where(r => r.ID_route.Contains(keyword) ||
                                r.ID_Station_start.Contains(keyword) ||
                                r.ID_Station_end.Contains(keyword))
                    .Select(r => new RouteDTO
                    {
                        ID_route = r.ID_route,
                        ID_Station_start = r.ID_Station_start,
                        ID_Station_end = r.ID_Station_end,
                        Distance = r.distance,
                        Time = r.time,
                        Name_Station_start = db.Stations.FirstOrDefault(s => s.ID_station == r.ID_Station_start).Name_station,
                        Name_Station_end = db.Stations.FirstOrDefault(s => s.ID_station == r.ID_Station_end).Name_station
                    }).ToList();
            }
        }

        public void Add(RouteDTO dto)
        {
            using (var db = new BusManagement())
            {
                if (db.Routes.Any(r => r.ID_route == dto.ID_route))
                    throw new Exception("ID Route đã tồn tại.");

                db.Routes.Add(new Route
                {
                    ID_route = dto.ID_route,
                    ID_Station_start = dto.ID_Station_start,
                    ID_Station_end = dto.ID_Station_end,
                    distance = dto.Distance,
                    time = dto.Time
                });
                db.SaveChanges();
            }
        }

        public void Update(RouteDTO dto)
        {
            using (var db = new BusManagement())
            {
                var route = db.Routes.FirstOrDefault(r => r.ID_route == dto.ID_route);
                if (route == null)
                    throw new Exception("Route không tồn tại.");

                route.ID_Station_start = dto.ID_Station_start;
                route.ID_Station_end = dto.ID_Station_end;
                route.distance = dto.Distance;
                route.time = dto.Time;

                db.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            using (var db = new BusManagement())
            {
                var route = db.Routes.FirstOrDefault(r => r.ID_route == id);
                if (route == null)
                    throw new Exception("Route không tồn tại.");

                db.Routes.Remove(route);
                db.SaveChanges();
            }
        }
        public Route GetById(string id)
        {
            using (var context = new BusManagement())
            {
                return context.Routes.Find(id);
            }
        }
        
    }

}
