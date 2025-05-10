using PBL3.DAL.Context;
using PBL3.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3.DAL.Repositories
{
    public class StationRepository
    {
        public List<Station> GetAll(string keyword = "")
        {
            using (var db = new BusManagement())
            {
                return db.Stations
                    .Where(s => s.ID_station.Contains(keyword) ||
                                s.Name_station.Contains(keyword) ||
                                s.location.Contains(keyword))
                    .ToList();
            }
        }

        public void Add(Station station)
        {
            using (var db = new BusManagement())
            {
                if (db.Stations.Any(s => s.ID_station == station.ID_station))
                    throw new Exception("ID bị trùng");

                db.Stations.Add(station);
                db.SaveChanges();
            }
        }

        public void Update(Station station)
        {
            using (var db = new BusManagement())
            {
                var existing = db.Stations.FirstOrDefault(s => s.ID_station == station.ID_station);
                if (existing != null)
                {
                    existing.Name_station = station.Name_station;
                    existing.location = station.location;
                    db.SaveChanges();
                }
            }
        }

        public void Delete(string id)
        {
            using (var db = new BusManagement())
            {
                var station = db.Stations.FirstOrDefault(s => s.ID_station == id);
                if (station != null)
                {
                    db.Stations.Remove(station);
                    db.SaveChanges();
                }
            }
        }
    }
}
