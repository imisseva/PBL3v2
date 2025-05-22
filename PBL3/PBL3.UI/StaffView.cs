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
                    ID_account = form.StaffID, // Lấy ID do người dùng nhập
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
    }
}
