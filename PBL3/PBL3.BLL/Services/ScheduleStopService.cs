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
    public class ScheduleStopService
    {
        private ScheduleStopRepository repo = new ScheduleStopRepository();

        public void AddStop(ScheduleStopDTO dto)
        {
            Schedule_Stop stop = new Schedule_Stop
            {
                ID_Stop = dto.ID_Stop,
                ID_Schedule = dto.ID_Schedule,
                IDStation_stop = dto.IDStation_stop,
                Stop_time = dto.Stop_time,
                Stop_order = dto.Stop_order
            };
            repo.Add(stop);
        }

        public void UpdateStop(ScheduleStopDTO dto)
        {
            Schedule_Stop stop = new Schedule_Stop
            {
                ID_Stop = dto.ID_Stop,
                ID_Schedule = dto.ID_Schedule,
                IDStation_stop = dto.IDStation_stop,
                Stop_time = dto.Stop_time,
                Stop_order = dto.Stop_order
            };
            repo.Update(stop);
        }

        public void DeleteStop(string id) => repo.Delete(id);

        public List<ScheduleStopDTO> GetStopsBySchedule(string scheduleId)
        {
            return repo.GetBySchedule(scheduleId).Select(stop => new ScheduleStopDTO
            {
                ID_Stop = stop.ID_Stop,
                ID_Schedule = stop.ID_Schedule,
                IDStation_stop = stop.IDStation_stop,
                Stop_time = stop.Stop_time,
                Stop_order = stop.Stop_order
            }).ToList();
        }
    }

}
