using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Repositories;
using PBL3.DAL.Entities;
using PBL3.DTO;


namespace PBL3.BLL.Services
{
    public class StaffService
    {
        private StaffRepository _repo = new StaffRepository();
        public List<StaffDTO> GetAllStaff(string keyword = "")
        {
            return _repo.GetAll(keyword)
                .Select(s => new StaffDTO
                {
                    ID_account = s.ID_account,
                    Name = s.Name,
                    email = s.email,
                    phone = s.phone,
                    DiaChiNha = s.home_address,
                    NgaySinh = s.DOB ?? System.DateTime.MinValue,
                    NoiSinh = s.NoiSinh,
                    Gender = s.Gender,
                    CCCD = s.CCCD,
                    ID_station = s.ID_station,
                    
                }).ToList();
        }

        public List<StaffDTO> GetAllStaffByID(int ID)
        {
            return _repo.GetByID(ID)
                 .Select(s => new StaffDTO
                 {
                     ID_account = s.ID_account,
                     Name = s.Name,
                     email = s.email,
                     phone = s.phone,
                     DiaChiNha = s.home_address,
                     NgaySinh = s.DOB ?? System.DateTime.MinValue,
                     NoiSinh = s.NoiSinh,
                     Gender = s.Gender,
                     CCCD = s.CCCD,
                     ID_station = s.ID_station,
                    
                 }).ToList();
        }

        public void AddStaff (StaffDTO staff)
        {
            _repo.Add(new Staff
            {
                ID_account = staff.ID_account,
                Name = staff.Name,
                email = staff.email,
                phone = staff.phone,
                home_address = staff.DiaChiNha,
                DOB = staff.NgaySinh,
                NoiSinh = staff.NoiSinh,
                Gender = staff.Gender,
                CCCD = staff.CCCD,
                ID_station = staff.ID_station,
            });
        }
        public void DeleteStaff(int id)
        {
            _repo.DeleteStaff(id);
        }
        public void UpdateStaff(StaffDTO dto)
        {
            _repo.Update(new Staff
            {
                ID_account = dto.ID_account,
                Name = dto.Name,
                email = dto.email,
                phone = dto.phone,
                home_address = dto.DiaChiNha,
                DOB = dto.NgaySinh,
                Gender = dto.Gender,
                NoiSinh = dto.NoiSinh,
                CCCD = dto.CCCD,
            });  
        }
    }
}
