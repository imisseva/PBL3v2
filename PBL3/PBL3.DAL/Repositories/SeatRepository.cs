using PBL3.DAL.Context;
using PBL3.DAL.Entities;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3.DAL.Repositories
{
    public class SeatRepository
    {
        public List<SEAT> GetAll(string keyword = "")
        {
            using (var db = new BusManagement())
            {
                return db.SEATs
                         .Where(s => s.ID_seat.Contains(keyword) ||
                                     s.ID_bus.Contains(keyword) ||
                                     s.type.Contains(keyword))
                         .ToList();
            }
        }

        public void Add(SEAT seat)
        {
            using (var db = new BusManagement())
            {
                if (db.SEATs.Any(s => s.ID_seat == seat.ID_seat))
                    throw new Exception("ID ghế bị trùng");

                db.SEATs.Add(seat);
                db.SaveChanges();
            }
        }

        public void Update(SEAT seat)
        {
            using (var db = new BusManagement())
            {
                var existing = db.SEATs.FirstOrDefault(s => s.ID_seat == seat.ID_seat);
                if (existing != null)
                {
                    existing.ID_bus = seat.ID_bus;
                    existing.seat_number = seat.seat_number;
                    existing.type = seat.type;
                    db.SaveChanges();
                }
            }
        }

        public void Delete(string id)
        {
            using (var db = new BusManagement())
            {
                var seat = db.SEATs.FirstOrDefault(s => s.ID_seat == id);
                if (seat != null)
                {
                    db.SEATs.Remove(seat);
                    db.SaveChanges();
                }
            }
        }
        public List<SeatDTO> GetSeatsByBusID(string busID)
        {
            using (var db = new BusManagement())
            {
                return db.SEATs
                    .Where(s => s.ID_bus == busID)
                    .Select(s => new SeatDTO
                    {
                        ID_seat = s.ID_seat,
                        ID_bus = s.ID_bus,
                        seat_number = s.seat_number,
                        type = s.type
                    }).ToList();
            }
        }
    }
}
