using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL.Repositories;

namespace PBL3.BLL.Services
{
    public class RouteService
    {
        private RouteRepository _repo = new RouteRepository();

        public List<RouteDTO> GetRoutes(string keyword = "")
        {
            return _repo.GetAll(keyword).Select(r => new RouteDTO {
                ID_route = r.ID_route,
                Distance = r.Distance,
                Time = r.Time,
                Name_Station_start = r.Name_Station_start,
                Name_Station_end = r.Name_Station_end
            }).ToList();
        }
        public string GetIDstationStart(string idRoute)
        {
            return _repo.GetAll().FirstOrDefault(r => r.ID_route == idRoute)?.ID_Station_start;
        }
        public string GetIdStationEnd(string idRoute)
        {
            return _repo.GetAll().FirstOrDefault(r => r.ID_route == idRoute)?.ID_Station_end;
        }
        public void AddRoute(RouteDTO dto)
        {
            _repo.Add(dto);
        }

        public void UpdateRoute(RouteDTO dto)
        {
            _repo.Update(dto);
        }

        public void DeleteRoute(string id)
        {
            _repo.Delete(id);
        }
        public TimeSpan GetTime(string idRoute)
        {
            return _repo.GetAll().FirstOrDefault(r => r.ID_route == idRoute)?.Time ?? TimeSpan.Zero;
        }
        
        
    }


}
