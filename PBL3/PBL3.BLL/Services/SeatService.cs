using PBL3.DAL.Entities;
using PBL3.DAL.Repositories;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3.BLL.Services
{
    public class SeatService
    {
        private readonly SeatRepository _repo = new SeatRepository();

        public List<SeatDTO> GetSeats(string keyword = "")
        {
            return _repo.GetAll(keyword)
                .Select(s => new SeatDTO
                {
                    ID_seat = s.ID_seat,
                    ID_bus = s.ID_bus,
                    seat_number = s.seat_number,
                    type = s.type
                }).ToList();
        }

        public void AddSeat(SeatDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            _repo.Add(new SEAT
            {
                ID_seat = dto.ID_seat,
                ID_bus = dto.ID_bus,
                seat_number = dto.seat_number,
                type = dto.type
            });
        }

        public void UpdateSeat(SeatDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            _repo.Update(new SEAT
            {
                ID_seat = dto.ID_seat,
                ID_bus = dto.ID_bus,
                seat_number = dto.seat_number,
                type = dto.type
            });
        }

        public void DeleteSeat(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException("ID không hợp lệ");

            _repo.Delete(id);
        }

        public List<SeatDTO> GetSeatsByBusID(string busID)
        {
            if (string.IsNullOrWhiteSpace(busID)) throw new ArgumentException("Bus ID không hợp lệ");
            return _repo.GetSeatsByBusID(busID)
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
