using PBL3.BLL.Services;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL3.UI
{
    public partial class StaffView : Form
    {
        private readonly StaffService staffService = new StaffService();

        public StaffView()
        {
            InitializeComponent();
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            List<StaffDTO> staffList = staffService.GetAllStaff();
            dgvStaff.DataSource = staffList;


            
            dgvStaff.Columns["Name"].HeaderText = "Họ tên";
            dgvStaff.Columns["email"].HeaderText = "Email";
            dgvStaff.Columns["phone"].HeaderText = "Số điện thoại";
            dgvStaff.Columns["home_address"].HeaderText = "Địa chỉ";
            dgvStaff.Columns["Dob"].HeaderText = "Ngày sinh";
            dgvStaff.Columns["NoiSinh"].HeaderText = "Nơi sinh";
            dgvStaff.Columns["Gender"].HeaderText = "Giới tính";
            dgvStaff.Columns["CCCD"].HeaderText = "CCCD";
            dgvStaff.Columns["ID_station"].HeaderText = "Mã bến xe làm việc";
            dgvStaff.Columns["AvatarImage"].HeaderText = "Ảnh đại diện";

            if (dgvStaff.Columns.Contains("ID_account"))
            {
                dgvStaff.Columns["ID_account"].Visible = false; 
            }

            if (dgvStaff.Columns.Contains("AvatarImage"))
            {
                dgvStaff.Columns["AvatarImage"].Visible = false;
               
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            List<StaffDTO> staffList = staffService.GetAllStaff(keyword);
            dgvStaff.DataSource = staffList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new StaffDetail
            {
                IsEditMode = false
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                var dto = new StaffDTO
                {
                    ID_account = form.StaffID,
                    Name = form.StaffName,
                    email = form.StaffEmail,
                    phone = form.StaffPhone,
                    CCCD = form.StaffCCCD,
                    home_address = form.StaffAddress,
                    Dob = form.StaffDateOfBirth,
                    NoiSinh = form.StaffPlaceOfBirth,
                    Gender = form.StaffGender,
                    ID_station = form.StaffStationID
                };

                try
                {
                    staffService.AddStaff(dto);
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadStaffData();
                }
                catch (Exception ex)
                {
                    string errorMsg = ex.Message;
                    if (ex.InnerException != null)
                    {
                        errorMsg += "\nChi tiết lỗi: " + ex.InnerException.Message;
                    }
                    MessageBox.Show("Không thể thêm nhân viên: " + errorMsg);
                }

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!");
                return;
            }

            // Lấy ID nhân viên đang chọn
            int selectedId = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells["ID_account"].Value);

            // Lấy thông tin hiện tại của nhân viên từ BLL
            var staff = staffService.GetById(selectedId);
            if (staff == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên.");
                return;
            }

            // Mở form chi tiết với chế độ sửa
            var form = new StaffDetail
            {
                IsEditMode = true,
                StaffID = staff.ID_account,
                StaffName = staff.Name,
                StaffEmail = staff.email,
                StaffPhone = staff.phone,
                StaffAddress = staff.home_address,
                StaffDateOfBirth = staff.Dob,
                StaffPlaceOfBirth = staff.NoiSinh,
                StaffCCCD = staff.CCCD,
                StaffGender = staff.Gender,
                StaffStationID = staff.ID_station
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật dữ liệu
                staff.Name = form.StaffName;
                staff.email = form.StaffEmail;
                staff.phone = form.StaffPhone;
                staff.home_address = form.StaffAddress;
                staff.Dob = form.StaffDateOfBirth;
                staff.NoiSinh = form.StaffPlaceOfBirth;
                staff.CCCD = form.StaffCCCD;
                staff.Gender = form.StaffGender;
                staff.ID_station = form.StaffStationID;

                try
                {
                    staffService.UpdateStaff(staff);
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    LoadStaffData();
                }
                catch (Exception ex)
                {
                    string errorMsg = ex.Message;
                    if (ex.InnerException != null)
                    {
                        errorMsg += "\nChi tiết lỗi: " + ex.InnerException.Message;
                    }
                    MessageBox.Show("Không thể cập nhật nhân viên: " + errorMsg);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            try
            {
                // Lấy ID_account từ dòng được chọn
                int staffId = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells["ID_account"].Value);

                // Gọi service xóa
                staffService.DeleteStaff(staffId);

                MessageBox.Show("Xóa nhân viên thành công!");
                LoadStaffData();
            }
            catch (Exception ex)
            {
                string errorMsg = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMsg += "\nChi tiết lỗi: " + ex.InnerException.Message;
                }
                MessageBox.Show("Không thể xóa nhân viên: " + errorMsg);
            }
        }
    }
}
