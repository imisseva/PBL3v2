using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Context;

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
                                h.arrive_time <= time && h.leave_time >= time)
                    .Select(h => h.ID_bus)
                    .Distinct()
                    .ToList();
            }
        }

    }
}
