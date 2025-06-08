using PBL3.DAL.Entities;
using PBL3.DAL.Context;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace PBL3.DAL.Repositories
{
    public class StaffRepository
    {
        //Lấy tất cả nhân viên
        public List<Staff> GetAll(string keyword = "")
        {
            using (var db = new BusManagement())
            {
                return db.Staffs
                         .Where(s => s.Name.Contains(keyword) ||
                                     s.phone.Contains(keyword) ||
                                     s.CCCD.Contains(keyword))
                         .ToList();
            }
        }
        //Lấy nhân viên theo ID
        public List<Staff> GetAllStaffByID(int ID)
        {
            using (var db = new BusManagement())
            {
               return db.Staffs
                         .Where(s => s.ID_account == ID)
                         .ToList();
            }
        }
        public Staff GetById(int id)
        {
            using (var db = new BusManagement())
            {
                return db.Staffs.FirstOrDefault(s => s.ID_account == id);
            }
        }


        public void Add(Staff staff)
        {
            using (var db = new BusManagement())
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
            }
        }
        public void DeleteStaff (int ID)
        {
            using (var db = new BusManagement())
            {
                var staff = db.Staffs.FirstOrDefault(s => s.ID_account == ID);
                if (staff != null)
                {
                    db.Staffs.Remove(staff);
                    db.SaveChanges();
                }
            }
        }
        //cập nhật thông tin nhân viên  
        public void Update(Staff staff)
        {
            using (var db = new BusManagement())
            {
                var existingStaff = db.Staffs.FirstOrDefault(s => s.ID_account == staff.ID_account);
                if (existingStaff != null)
                {
                    existingStaff.Name = staff.Name;
                    existingStaff.email = staff.email;
                    existingStaff.phone = staff.phone;
                    existingStaff.home_address = staff.home_address;
                    existingStaff.Gender = staff.Gender;
                    existingStaff.DOB = staff.DOB;
                    existingStaff.NoiSinh = staff.NoiSinh;
                    existingStaff.CCCD = staff.CCCD;
                    
                    if (staff.AvatarImage != null)
                    {
                        existingStaff.AvatarImage = staff.AvatarImage;
                    }
                    db.SaveChanges();
                }
            }
        }
    
    }
}
