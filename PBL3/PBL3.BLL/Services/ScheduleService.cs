using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Entities;
using PBL3.DAL.Repositories;
using PBL3.DTO;

namespace PBL3.BLL.Services
{
    public class ScheduleService
    {
        public List<string> GetBusesAvailableForSchedule(string stationId, DateTime startTime, DateTime endTime)
        {
            var candidateBuses = new HistoryRepository().GetAvailableBusesAtStation(stationId, startTime);
            return candidateBuses
                .Where(busId => new ScheduleRepository().IsBusFreeDuringTimeRange(busId, startTime, endTime))
                .ToList();
        }
        private ScheduleRepository repo = new ScheduleRepository();

        public void AddSchedule(ScheduleDTO dto)
        {
            Schedule entity = new Schedule
            {
                ID_Schedule = dto.ID_Schedule,
                ID_bus = dto.ID_bus,
                start_time = dto.start_time,
                end_time = dto.end_time,
                distance = dto.distance
            };
            repo.Add(entity);
        }

        public void UpdateSchedule(ScheduleDTO dto)
        {
            Schedule entity = new Schedule
            {
                ID_Schedule = dto.ID_Schedule,
                ID_bus = dto.ID_bus,
                start_time = dto.start_time,
                end_time = dto.end_time,
                distance = dto.distance
            };
            repo.Update(entity);
        }

        public void DeleteSchedule(string id) => repo.Delete(id);

        public List<ScheduleDTO> GetAllSchedules()
        {
            return repo.GetAll().Select(s => new ScheduleDTO
            {
                ID_Schedule = s.ID_Schedule,
                ID_bus = s.ID_bus,
                start_time = s.start_time,
                end_time = s.end_time,
                distance = s.distance
            }).ToList();
        }
    }
}
