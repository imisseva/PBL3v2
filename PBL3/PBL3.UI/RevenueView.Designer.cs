namespace PBL3.UI
{
    partial class RevenueView
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
            this.cbbPick = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DateRevenuedp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btStatistical = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotalTicket = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalRevenue = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTotalTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbPick
            // 
            this.cbbPick.BackColor = System.Drawing.Color.Transparent;
            this.cbbPick.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPick.FocusedColor = System.Drawing.Color.Empty;
            this.cbbPick.FocusedState.Parent = this.cbbPick;
            this.cbbPick.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbPick.FormattingEnabled = true;
            this.cbbPick.HoverState.Parent = this.cbbPick;
            this.cbbPick.ItemHeight = 30;
            this.cbbPick.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tháng"});
            this.cbbPick.ItemsAppearance.Parent = this.cbbPick;
            this.cbbPick.Location = new System.Drawing.Point(136, 72);
            this.cbbPick.Name = "cbbPick";
            this.cbbPick.ShadowDecoration.Parent = this.cbbPick;
            this.cbbPick.Size = new System.Drawing.Size(140, 36);
            this.cbbPick.TabIndex = 0;
            // 
            // DateRevenuedp
            // 
            this.DateRevenuedp.CheckedState.Parent = this.DateRevenuedp;
            this.DateRevenuedp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateRevenuedp.HoverState.Parent = this.DateRevenuedp;
            this.DateRevenuedp.Location = new System.Drawing.Point(326, 72);
            this.DateRevenuedp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateRevenuedp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateRevenuedp.Name = "DateRevenuedp";
            this.DateRevenuedp.ShadowDecoration.Parent = this.DateRevenuedp;
            this.DateRevenuedp.Size = new System.Drawing.Size(200, 36);
            this.DateRevenuedp.TabIndex = 1;
            this.DateRevenuedp.Value = new System.DateTime(2025, 5, 27, 5, 49, 48, 536);
            // 
            // btStatistical
            // 
            this.btStatistical.Animated = true;
            this.btStatistical.BorderRadius = 8;
            this.btStatistical.CheckedState.Parent = this.btStatistical;
            this.btStatistical.CustomImages.Parent = this.btStatistical;
            this.btStatistical.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btStatistical.ForeColor = System.Drawing.Color.White;
            this.btStatistical.HoverState.Parent = this.btStatistical;
            this.btStatistical.Location = new System.Drawing.Point(562, 72);
            this.btStatistical.Name = "btStatistical";
            this.btStatistical.ShadowDecoration.Parent = this.btStatistical;
            this.btStatistical.Size = new System.Drawing.Size(180, 36);
            this.btStatistical.TabIndex = 2;
            this.btStatistical.Text = "Thống kê";
            this.btStatistical.Click += new System.EventHandler(this.btStatistical_Click);
            // 
            // txtTotalTicket
            // 
            this.txtTotalTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalTicket.DefaultText = "";
            this.txtTotalTicket.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalTicket.DisabledState.Parent = this.txtTotalTicket;
            this.txtTotalTicket.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalTicket.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalTicket.FocusedState.Parent = this.txtTotalTicket;
            this.txtTotalTicket.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalTicket.HoverState.Parent = this.txtTotalTicket;
            this.txtTotalTicket.Location = new System.Drawing.Point(326, 210);
            this.txtTotalTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalTicket.Name = "txtTotalTicket";
            this.txtTotalTicket.PasswordChar = '\0';
            this.txtTotalTicket.PlaceholderText = "";
            this.txtTotalTicket.SelectedText = "";
            this.txtTotalTicket.ShadowDecoration.Parent = this.txtTotalTicket;
            this.txtTotalTicket.Size = new System.Drawing.Size(200, 44);
            this.txtTotalTicket.TabIndex = 3;
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalRevenue.DefaultText = "";
            this.txtTotalRevenue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRevenue.DisabledState.Parent = this.txtTotalRevenue;
            this.txtTotalRevenue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRevenue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRevenue.FocusedState.Parent = this.txtTotalRevenue;
            this.txtTotalRevenue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRevenue.HoverState.Parent = this.txtTotalRevenue;
            this.txtTotalRevenue.Location = new System.Drawing.Point(325, 315);
            this.txtTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.PasswordChar = '\0';
            this.txtTotalRevenue.PlaceholderText = "";
            this.txtTotalRevenue.SelectedText = "";
            this.txtTotalRevenue.ShadowDecoration.Parent = this.txtTotalRevenue;
            this.txtTotalRevenue.Size = new System.Drawing.Size(200, 44);
            this.txtTotalRevenue.TabIndex = 4;
            // 
            // lbTotalTicket
            // 
            this.lbTotalTicket.AutoSize = true;
            this.lbTotalTicket.Location = new System.Drawing.Point(198, 228);
            this.lbTotalTicket.Name = "lbTotalTicket";
            this.lbTotalTicket.Size = new System.Drawing.Size(78, 16);
            this.lbTotalTicket.TabIndex = 5;
            this.lbTotalTicket.Text = "Tổng số vé:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng doanh thu:";
            // 
            // RevenueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTotalTicket);
            this.Controls.Add(this.txtTotalRevenue);
            this.Controls.Add(this.txtTotalTicket);
            this.Controls.Add(this.btStatistical);
            this.Controls.Add(this.DateRevenuedp);
            this.Controls.Add(this.cbbPick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevenueView";
            this.Text = "RevenueView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbbPick;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateRevenuedp;
        private Guna.UI2.WinForms.Guna2Button btStatistical;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalTicket;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalRevenue;
        private System.Windows.Forms.Label lbTotalTicket;
        private System.Windows.Forms.Label label1;
    }
}