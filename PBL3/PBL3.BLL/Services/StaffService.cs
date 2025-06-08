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
                    home_address = s.home_address,
                    Dob = s.DOB ?? System.DateTime.MinValue,
                    NoiSinh = s.NoiSinh,
                    Gender = s.Gender,
                    CCCD = s.CCCD,
                    ID_station = s.ID_station,
                    AvatarImage = s.AvatarImage
                    
                }).ToList();
        }

        public List<StaffDTO> GetAllStaffByID(int ID)
        {
            return _repo.GetAllStaffByID(ID)
                 .Select(s => new StaffDTO
                 {
                     ID_account = s.ID_account,
                     Name = s.Name,
                     email = s.email,
                     phone = s.phone,
                     home_address = s.home_address,
                     Dob = s.DOB ?? System.DateTime.MinValue,
                     NoiSinh = s.NoiSinh,
                     Gender = s.Gender,
                     CCCD = s.CCCD,
                     ID_station = s.ID_station,
                     AvatarImage = s.AvatarImage


                 }).ToList();
        }
        public StaffDTO GetById(int id)
        {
            var staff = _repo.GetById(id);
            if (staff == null) return null;

            return new StaffDTO
            {
                ID_account = staff.ID_account,
                Name = staff.Name,
                email = staff.email,
                phone = staff.phone,
                CCCD = staff.CCCD,
                home_address = staff.home_address,
                Dob = staff.DOB ?? DateTime.MinValue,
                NoiSinh = staff.NoiSinh,
                Gender = staff.Gender,
                ID_station = staff.ID_station,
                AvatarImage = staff.AvatarImage 
            };
        }

        public void AddStaff (StaffDTO staff)
        {
            _repo.Add(new Staff
            {
                ID_account = staff.ID_account,
                Name = staff.Name,
                email = staff.email,
                phone = staff.phone,
                home_address = staff.home_address,
                DOB = staff.Dob,
                NoiSinh = staff.NoiSinh,
                Gender = staff.Gender,
                CCCD = staff.CCCD,
                ID_station = staff.ID_station,
                AvatarImage = staff.AvatarImage
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
                home_address = dto.home_address,
                DOB = dto.Dob,
                Gender = dto.Gender,
                NoiSinh = dto.NoiSinh,
                CCCD = dto.CCCD,
                AvatarImage = dto.AvatarImage
            });  
        }
       
    }
}
