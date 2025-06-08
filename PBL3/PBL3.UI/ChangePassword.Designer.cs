namespace PBL3
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbOldPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbOldPass
            // 
            this.lbOldPass.AutoSize = true;
            this.lbOldPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPass.Location = new System.Drawing.Point(157, 174);
            this.lbOldPass.Name = "lbOldPass";
            this.lbOldPass.Size = new System.Drawing.Size(156, 23);
            this.lbOldPass.TabIndex = 20;
            this.lbOldPass.Text = "Nhập mật khẩu cũ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nhập mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Xác nhận mật khẩu mới:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(347, 176);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(277, 22);
            this.txtOldPass.TabIndex = 28;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(347, 236);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(277, 22);
            this.txtNewPass.TabIndex = 29;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(347, 296);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(277, 22);
            this.txtConfirmPass.TabIndex = 30;
            // 
            // btConfirm
            // 
            this.btConfirm.BorderRadius = 8;
            this.btConfirm.CheckedState.Parent = this.btConfirm;
            this.btConfirm.CustomImages.Parent = this.btConfirm;
            this.btConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btConfirm.ForeColor = System.Drawing.Color.White;
            this.btConfirm.HoverState.Parent = this.btConfirm;
            this.btConfirm.Location = new System.Drawing.Point(330, 412);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.ShadowDecoration.Parent = this.btConfirm;
            this.btConfirm.Size = new System.Drawing.Size(180, 45);
            this.btConfirm.TabIndex = 31;
            this.btConfirm.Text = "Đổi mật khẩu";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 566);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOldPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private Guna.UI2.WinForms.Guna2Button btConfirm;
    }
}