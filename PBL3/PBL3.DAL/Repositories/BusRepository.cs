using PBL3.DAL.Context;
using PBL3.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3.DAL.Repositories
{
    public class BusRepository
    {
        public List<Bus> GetAll(string keyword = "")
        {
            using (var db = new BusManagement())
            {
                return db.Buses
                         .Where(b => b.ID_bus.Contains(keyword))
                         .ToList();
            }
        }

        public void Add(Bus bus)
        {
            using (var db = new BusManagement())
            {
                if (db.Buses.Any(b => b.ID_bus == bus.ID_bus))
                    throw new Exception("ID bị trùng");

                db.Buses.Add(bus);
                db.SaveChanges();
            }
        }

        public void Update(Bus bus)
        {
            using (var db = new BusManagement())
            {
                var existing = db.Buses.FirstOrDefault(b => b.ID_bus == bus.ID_bus);
                if (existing != null)
                {
                    existing.Quantity = bus.Quantity;
                    existing.Status = bus.Status;
                    db.SaveChanges();
                }
            }
        }

        public void Delete(string id)
        {
            using (var db = new BusManagement())
            {
                var bus = db.Buses.FirstOrDefault(b => b.ID_bus == id);
                if (bus != null)
                {
                    db.Buses.Remove(bus);
                    db.SaveChanges();
                }
            }
        }
    }
}