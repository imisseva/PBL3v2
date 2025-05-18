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
    public class ScheduleRepository
    {
        public List<BusTicketDTO> GetBusTicketsByMainRoute(DateTime date, string idStart, string idEnd)
        {
            using (var context = new BusManagement())
            {
                var query = from sch in context.Schedules
                            join route in context.Routes on sch.ID_route equals route.ID_route
                            where route.ID_Station_start == idStart
                               && route.ID_Station_end == idEnd
                               && DbFunctions.TruncateTime(sch.start_time) == date.Date
                            select new BusTicketDTO
                            {   
                                ID_schedule = sch.ID_Schedule,
                                BusID = sch.ID_bus,
                                StartTime = sch.start_time,
                                EndTime = sch.end_time,
                                Quantity = context.Buses
                                           .Where(b => b.ID_bus == sch.ID_bus)
                                           .Select(b => b.Quantity)
                                           .FirstOrDefault(),
                                SeatType = context.SEATs
                                           .Where(s => s.ID_bus == sch.ID_bus)
                                           .Select(s => s.type)
                                           .FirstOrDefault()
                            };

                return query.Distinct().ToList();
            }
        }

        public List<BusTicketDTO> GetBusTicketsBySubRoute(DateTime date, string idStart, string idEnd)
        {
            using (var context = new BusManagement())
            {
                var query = from sch in context.Schedules
                            join route in context.Routes on sch.ID_route equals route.ID_route
                            join stop in context.Schedule_Stop on sch.ID_Schedule equals stop.ID_Schedule
                            where route.ID_Station_start == idStart
                                  && stop.IDStation_stop == idEnd
                                  && DbFunctions.TruncateTime(sch.start_time) == date.Date
                            select new
                            {
                                Schedule = sch,
                                Route = route,
                                Stop = stop
                            };

                var result = new List<BusTicketDTO>();

                foreach (var item in query.ToList())
                {
                    var sch = item.Schedule;
                    var stopOrder = item.Stop.Stop_order;

                    // Lấy ga chính và ga phụ
                    string mainStation = item.Route.ID_Station_start;
                    string subStation = item.Stop.IDStation_stop;

                    // Tìm thời gian di chuyển từ ga chính đến ga phụ
                    TimeSpan? travelTime = context.Routes
                        .Where(r => r.ID_Station_start == mainStation && r.ID_Station_end == subStation)
                        .Select(r => (TimeSpan?)r.time)
                        .FirstOrDefault();

                    if (travelTime == null)
                        continue; // bỏ qua nếu không tìm thấy tuyến phụ

                    // Tổng thời gian dừng tại các ga phụ trước đó
                    double totalStopTime = context.Schedule_Stop
                        .Where(s => s.ID_Schedule == sch.ID_Schedule && s.Stop_order < stopOrder)
                        .ToList()
                        .Select(s => s.Stop_time.TotalMinutes)
                        .Sum();

                    // Tính giờ đến ga phụ
                    DateTime endTime = sch.start_time
                        .AddMinutes(travelTime.Value.TotalMinutes + totalStopTime);

                    // Tạo đối tượng DTO
                    var busInfo = new BusTicketDTO
                    {
                        ID_schedule = sch.ID_Schedule,
                        BusID = sch.ID_bus,
                        StartTime = sch.start_time,
                        EndTime = endTime,
                        Quantity = context.Buses
                                   .Where(b => b.ID_bus == sch.ID_bus)
                                   .Select(b => b.Quantity)
                                   .FirstOrDefault(),
                        SeatType = context.SEATs
                                   .Where(s => s.ID_bus == sch.ID_bus)
                                   .Select(s => s.type)
                                   .FirstOrDefault()
                    };

                    result.Add(busInfo);
                }

                return result;
            }
        }


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
        public Schedule GetScheduleConditions(string busId, DateTime date, string idStart, string idEnd)
        {
            using (var context = new BusManagement())
            {
                return context.Schedules
                    .Join(context.Routes, sch => sch.ID_route, r => r.ID_route, (sch, r) => new { sch, r })
                    .Where(x =>
                        x.sch.ID_bus == busId &&
                        DbFunctions.TruncateTime(x.sch.start_time) == date.Date &&
                        x.r.ID_Station_start == idStart &&
                        x.r.ID_Station_end == idEnd)
                    .Select(x => x.sch)
                    .FirstOrDefault();
            }
        }

    }
}
