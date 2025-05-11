using System;
using System.Collections.Generic;
using System.Linq;
using PBL3.DAL.Entities;
using PBL3.DAL.Repositories;
using PBL3.DTO;

namespace PBL3.BLL.Services
{
    public class BusService
    {
        private readonly BusRepository _repo = new BusRepository();
     

        public List<BusDTO> GetBuses(string keyword = "")
        {
            return _repo.GetAll(keyword)
                .Select(b => new BusDTO
                {
                    ID_bus = b.ID_bus,
                    Quantity = b.Quantity,
                    Status = b.Status
                }).ToList();
        }

        public void AddBus(BusDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            _repo.Add(new Bus
            {
                ID_bus = dto.ID_bus,
                Quantity = dto.Quantity,
                Status = dto.Status
            });
        }

        public void UpdateBus(BusDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            _repo.Update(new Bus
            {
                ID_bus = dto.ID_bus,
                Quantity = dto.Quantity,
                Status = dto.Status
            });
        }

        public void DeleteBus(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException("ID không hợp lệ");

            _repo.Delete(id);
        }
    }
}
