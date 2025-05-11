using PBL3.DAL.Entities;
using PBL3.DAL.Repositories;
using PBL3.DTO;
using System.Collections.Generic;
using System.Linq;

namespace PBL3.BLL.Services
{
    public class StationService
    {
        private StationRepository _repo = new StationRepository();

        public List<StationDTO> GetStations(string keyword = "")
        {
            return _repo.GetAll(keyword)
                .Select(s => new StationDTO
                {
                    ID_station = s.ID_station,
                    Name_station = s.Name_station,
                    Location = s.location
                }).ToList();
        }
        public List<StationDTO> GetIntermediateStations(int startID, int endID)
        {
            return _repo.GetIntermediateStations(startID, endID)
                .Select(s => new StationDTO
                {
                    ID_station = s.ID_station,
                    Name_station = s.Name_station,
                    Location = s.Location
                }).ToList();
        }

        public void AddStation(StationDTO dto)
        {
            _repo.Add(new Station
            {
                ID_station = dto.ID_station,
                Name_station = dto.Name_station,
                location = dto.Location
            });
        }

        public void UpdateStation(StationDTO dto)
        {
            _repo.Update(new Station
            {
                ID_station = dto.ID_station,
                Name_station = dto.Name_station,
                location = dto.Location
            });
        }

        public void DeleteStation(string id)
        {
            _repo.Delete(id);
        }
    }
}