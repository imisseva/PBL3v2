using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Context;
using PBL3.DAL.Entities;

namespace PBL3.DAL.Repositories
{
    public class ScheduleRepository
    {
        public bool IsBusFreeDuringTimeRange(string busId, DateTime start, DateTime end)
        {
            using (var context = new BusManagement())
            {
                return !context.Schedules.Any(s =>
                    s.ID_bus == busId &&
                    (
                        (s.start_time <= end && s.start_time >= start) ||
                        (s.end_time >= start && s.end_time <= end) ||
                        (s.start_time <= start && s.end_time >= end)
                    ));
            }
        }
        public void Add(Schedule schedule)
        {
            using (var context = new BusManagement())
            {
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
        }

        public void Update(Schedule schedule)
        {
            using (var context = new BusManagement())
            {
                var entity = context.Schedules.Find(schedule.ID_Schedule);
                if (entity != null)
                {
                    context.Entry(entity).CurrentValues.SetValues(schedule);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(string id)
        {
            using (var context = new BusManagement())
            {
                var entity = context.Schedules.Find(id);
                if (entity != null)
                {
                    context.Schedules.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public List<Schedule> GetAll()
        {
            using (var context = new BusManagement())
            {
                return context.Schedules.ToList();
            }
        }

    }
}
