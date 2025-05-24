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

            dgvStaff.Columns["ID_account"].HeaderText = "Mã tài khoản";
            dgvStaff.Columns["Name"].HeaderText = "Họ tên";
            dgvStaff.Columns["email"].HeaderText = "Email";
            dgvStaff.Columns["phone"].HeaderText = "Số điện thoại";
            dgvStaff.Columns["home_address"].HeaderText = "Địa chỉ";
            dgvStaff.Columns["Dob"].HeaderText = "Ngày sinh";
            dgvStaff.Columns["NoiSinh"].HeaderText = "Nơi sinh";
            dgvStaff.Columns["Gender"].HeaderText = "Giới tính";
            dgvStaff.Columns["CCCD"].HeaderText = "CCCD";
            dgvStaff.Columns["ID_station"].HeaderText = "Mã bến xe làm việc";
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
            if (dgvStaff.CurrentRow != null)
            {
                var dto = new StaffDTO
                {
                    ID_account = dgvStaff.CurrentRow.Cells["ID_account"].Value != null
                    ? Convert.ToInt32(dgvStaff.CurrentRow.Cells["ID_account"].Value)
                    : 0,

                    Name = dgvStaff.CurrentRow.Cells["Name"].Value?.ToString() ?? "",
                    email = dgvStaff.CurrentRow.Cells["email"].Value?.ToString() ?? "",
                    phone = dgvStaff.CurrentRow.Cells["phone"].Value?.ToString() ?? "",
                    home_address = dgvStaff.CurrentRow.Cells["home_address"].Value?.ToString() ?? "",
                    Dob = dgvStaff.CurrentRow.Cells["Dob"].Value != null
                     ? Convert.ToDateTime(dgvStaff.CurrentRow.Cells["Dob"].Value)
                     : DateTime.Today,
                    NoiSinh = dgvStaff.CurrentRow.Cells["NoiSinh"].Value?.ToString() ?? "",
                    CCCD = dgvStaff.CurrentRow.Cells["CCCD"].Value?.ToString() ?? "",
                    Gender = dgvStaff.CurrentRow.Cells["Gender"].Value?.ToString() ?? "",
                    ID_station = dgvStaff.CurrentRow.Cells["ID_station"].Value?.ToString() ?? ""
                };


                var form = new StaffDetail
                {
                    IsEditMode = true,
                    StaffID = dto.ID_account,
                    StaffName = dto.Name,
                    StaffEmail = dto.email,
                    StaffPhone = dto.phone,
                    StaffAddress = dto.home_address,
                    StaffDateOfBirth = dto.Dob,
                    StaffPlaceOfBirth = dto.NoiSinh,
                    StaffCCCD = dto.CCCD,
                    StaffGender = dto.Gender,
                    StaffStationID = dto.ID_station
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    dto.Name = form.StaffName;
                    dto.email = form.StaffEmail;
                    dto.phone = form.StaffPhone;
                    dto.home_address = form.StaffAddress;
                    dto.Dob = form.StaffDateOfBirth;
                    dto.NoiSinh = form.StaffPlaceOfBirth;
                    dto.CCCD = form.StaffCCCD;
                    dto.Gender = form.StaffGender;
                    dto.ID_station = form.StaffStationID;

                    try
                    {
                        staffService.UpdateStaff(dto);
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStaffData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (dgvStaff.CurrentRow != null)
            {
                string name = dgvStaff.CurrentRow.Cells["Name"].Value?.ToString() ?? "";
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá nhân viên \"{name}\" không?",
                                                      "Xác nhận xoá",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvStaff.CurrentRow.Cells["ID_account"].Value);
                        staffService.DeleteStaff(id);
                        LoadStaffData();
                        MessageBox.Show("Xoá nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xoá nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
