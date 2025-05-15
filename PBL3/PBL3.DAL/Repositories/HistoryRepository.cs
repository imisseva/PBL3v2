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
    public class HistoryRepository
    {
        public List<string> GetAvailableBusesAtStation(string stationId, DateTime time)
        {
            using (var context = new BusManagement())
            {
                return context.Bus_Location_History
                    .Where(h => h.ID_Station == stationId &&
                                h.arrive_time <= time && (h.leave_time == null || h.leave_time >= time))
                    .Select(h => h.ID_bus)
                    .Distinct()
                    .ToList();
            }
        }
        public HistoryDTO GetLastHistoryWithNullLeaveTime(string busID)
        {
            using (var context = new BusManagement())
            {
                var history = context.Bus_Location_History
                    .Where(h => h.ID_bus == busID && h.leave_time == null)
                    .OrderByDescending(h => h.arrive_time)
                    .FirstOrDefault();

                return history != null ? ConvertToDTO(history) : null;
            }
        }

        public List<HistoryDTO> GetAllHistory()
        {
            using (var context = new BusManagement())
            {
                return context.Bus_Location_History
                    .Select(h => new HistoryDTO
                    {
                        ID_History = h.ID_History,
                        ID_bus = h.ID_bus,
                        ID_Station = h.ID_Station,
                        arrive_time = h.arrive_time,
                        leave_time = h.leave_time
                    }).ToList();
            }
        }

        public void AddHistory(HistoryDTO dto)
        {
            using (var context = new BusManagement())
            {
                var entity = new Bus_Location_History
                {
                    ID_bus = dto.ID_bus,
                    ID_Station = dto.ID_Station,
                    arrive_time = dto.arrive_time,
                    leave_time = dto.leave_time
                };
                context.Bus_Location_History.Add(entity);
                context.SaveChanges();
            }
        }

        public void UpdateHistory(HistoryDTO dto)
        {
            using (var context = new BusManagement())
            {
                var entity = context.Bus_Location_History.FirstOrDefault(h =>
                    h.ID_bus == dto.ID_bus &&
                    h.ID_Station == dto.ID_Station &&
                    h.arrive_time == dto.arrive_time);

                if (entity != null)
                {
                    entity.leave_time = dto.leave_time;
                    context.SaveChanges();
                }
            }
        }


        public void DeleteHistory(int id)
        {
            using (var context = new BusManagement())
            {
                var entity = context.Bus_Location_History.Find(id);
                if (entity == null) throw new Exception("History not found");

                context.Bus_Location_History.Remove(entity);
                context.SaveChanges();
            }
        }

        public HistoryDTO GetById(int id)
        {
            using (var context = new BusManagement())
            {
                var entity = context.Bus_Location_History.Find(id);
                if (entity == null) return null;

                return new HistoryDTO
                {
                    ID_History = entity.ID_History,
                    ID_bus = entity.ID_bus,
                    ID_Station = entity.ID_Station,
                    arrive_time = entity.arrive_time,
                    leave_time = entity.leave_time
                };
            }
        }
        private HistoryDTO ConvertToDTO(Bus_Location_History history)
        {
            return new HistoryDTO
            {
                ID_bus = history.ID_bus,
                ID_Station = history.ID_Station,
                arrive_time = history.arrive_time,
                leave_time = history.leave_time
            };
        }


    }
}
