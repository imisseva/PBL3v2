using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Context;
using PBL3.DAL.Entities;

namespace PBL3.DAL.Repositories
{
    public class ScheduleStopRepository
    {
        public void Add(Schedule_Stop stop)
        {
            using (var context = new BusManagement())
            {
                context.Schedule_Stop.Add(stop);
                context.SaveChanges();
            }
        }

        public void Update(Schedule_Stop stop)
        {
            using (var context = new BusManagement())
            {
                var entity = context.Schedule_Stop.Find(stop.ID_Stop);
                if (entity != null)
                {
                    context.Entry(entity).CurrentValues.SetValues(stop);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(string id)
        {
            using (var context = new BusManagement())
            {
                var entity = context.Schedule_Stop.Find(id);
                if (entity != null)
                {
                    context.Schedule_Stop.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public List<Schedule_Stop> GetBySchedule(string scheduleId)
        {
            using (var context = new BusManagement())
            {
                return context.Schedule_Stop.Where(s => s.ID_Schedule == scheduleId).ToList();
            }
        }
    }

}
