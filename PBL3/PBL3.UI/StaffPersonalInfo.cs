using PBL3.BLL.Services;
using PBL3.DTO;
using PBL3.UI;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PBL3
{
    public partial class StaffPersonalInfo : Form
    {
        private StaffService _staffService = new StaffService();
        private int StaffID => int.TryParse(txtID.Text, out int id) ? id : 0;

        public StaffPersonalInfo()
        {
            InitializeComponent();
            LoadStaffData();
        }

        private void StaffPersonalInfo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadStaffData()
        {
            var staff = _staffService.GetAllStaffByID(Session.LoggedAccountId).FirstOrDefault();
            if (staff != null)
            {
                txtName.Text = staff.Name;
                txtEmail.Text = staff.email;
                txtPhone.Text = staff.phone;
                txtAddress.Text = staff.home_address;
                txtGender.Text = staff.Gender;
                txtDob.Text = staff.Dob.ToString("yyyy-MM-dd");
                txtNoiSinh.Text = staff.NoiSinh;
                txtCCCD.Text = staff.CCCD;
                txtID.Text = staff.ID_account.ToString();

                if (staff.AvatarImage != null && staff.AvatarImage.Length > 0)
                {
                    using (var ms = new MemoryStream(staff.AvatarImage))
                    {
                        pictureBoxAvatar.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxAvatar.Image = null; // hoặc hình mặc định
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var staff = _staffService.GetById(StaffID);

            if (staff == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            staff.Name = txtName.Text.Trim();
            staff.email = txtEmail.Text.Trim();
            staff.phone = txtPhone.Text.Trim();
            staff.home_address = txtAddress.Text.Trim();
            staff.CCCD = txtCCCD.Text.Trim();
            staff.NoiSinh = txtNoiSinh.Text.Trim();
            staff.Gender = txtGender.Text.Trim();

            // Xử lý ngày sinh
            if (DateTime.TryParse(txtDob.Text.Trim(), out DateTime dobParsed))
                staff.Dob = dobParsed;
            else
                staff.Dob = DateTime.Now; // hoặc giữ giá trị cũ: staff.Dob = staff.Dob;

            try
            {
                _staffService.UpdateStaff(staff);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh đại diện mới";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (pictureBoxAvatar.Image != null)
                    {
                        pictureBoxAvatar.Image.Dispose();
                        pictureBoxAvatar.Image = null;
                    }
                    using (var tempImage = Image.FromFile(ofd.FileName))
                    {
                        pictureBoxAvatar.Image = new Bitmap(tempImage);
                    }

                    byte[] avatarBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxAvatar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        avatarBytes = ms.ToArray();
                    }
                    var staff = _staffService.GetById(Session.LoggedAccountId);
                    if (staff != null)
                    {
                        staff.AvatarImage = avatarBytes;
                        _staffService.UpdateStaff(staff);
                        MessageBox.Show("Cập nhật ảnh đại diện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStaffData();
                    }
                }
            }
        }
    }
}