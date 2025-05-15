namespace PBL3
{
    partial class BookTicket
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
            this.lbTrain = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSeat = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbBookingDate = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dpBookingdate = new System.Windows.Forms.DateTimePicker();
            this.btPickSeat = new Guna.UI2.WinForms.Guna2Button();
            this.btConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.cbbStartPoint = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbEndPoint = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbBus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbSchedule = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // lbTrain
            // 
            this.lbTrain.AutoSize = true;
            this.lbTrain.Location = new System.Drawing.Point(33, 93);
            this.lbTrain.Name = "lbTrain";
            this.lbTrain.Size = new System.Drawing.Size(53, 16);
            this.lbTrain.TabIndex = 0;
            this.lbTrain.Text = "Xe/Bus:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(378, 93);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(90, 16);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Ngày đi/Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã vé/Ticket ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nơi đi/Start point:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nơi đến/End point:";
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Location = new System.Drawing.Point(33, 277);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(66, 16);
            this.lbSeat.TabIndex = 6;
            this.lbSeat.Text = "Chỗ/Seat:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(33, 397);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(49, 16);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Giá vé:";
            // 
            // lbBookingDate
            // 
            this.lbBookingDate.AutoSize = true;
            this.lbBookingDate.Location = new System.Drawing.Point(33, 362);
            this.lbBookingDate.Name = "lbBookingDate";
            this.lbBookingDate.Size = new System.Drawing.Size(167, 16);
            this.lbBookingDate.TabIndex = 8;
            this.lbBookingDate.Text = "Ngày đặt vé/Booking date:";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(171, 271);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(210, 22);
            this.txtSeat.TabIndex = 14;
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(364, 43);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(210, 22);
            this.txtTicketID.TabIndex = 17;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(33, 323);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(89, 16);
            this.lbType.TabIndex = 18;
            this.lbType.Text = "Loại xe/Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(171, 317);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(210, 22);
            this.txtType.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "400.000VND",
            "500.000VND",
            "800.000VND"});
            this.comboBox2.Location = new System.Drawing.Point(220, 394);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // dpBookingdate
            // 
            this.dpBookingdate.Location = new System.Drawing.Point(220, 359);
            this.dpBookingdate.Name = "dpBookingdate";
            this.dpBookingdate.Size = new System.Drawing.Size(210, 22);
            this.dpBookingdate.TabIndex = 24;
            // 
            // btPickSeat
            // 
            this.btPickSeat.BorderRadius = 8;
            this.btPickSeat.CheckedState.Parent = this.btPickSeat;
            this.btPickSeat.CustomImages.Parent = this.btPickSeat;
            this.btPickSeat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btPickSeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btPickSeat.ForeColor = System.Drawing.Color.White;
            this.btPickSeat.HoverState.Parent = this.btPickSeat;
            this.btPickSeat.Location = new System.Drawing.Point(180, 506);
            this.btPickSeat.Name = "btPickSeat";
            this.btPickSeat.ShadowDecoration.Parent = this.btPickSeat;
            this.btPickSeat.Size = new System.Drawing.Size(164, 37);
            this.btPickSeat.TabIndex = 27;
            this.btPickSeat.Text = "Chọn ghế";
            this.btPickSeat.Click += new System.EventHandler(this.btPickSeat_Click);
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
            this.btConfirm.Location = new System.Drawing.Point(407, 506);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.ShadowDecoration.Parent = this.btConfirm;
            this.btConfirm.Size = new System.Drawing.Size(164, 37);
            this.btConfirm.TabIndex = 28;
            this.btConfirm.Text = "Xác nhận";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // cbbStartPoint
            // 
            this.cbbStartPoint.BackColor = System.Drawing.Color.Transparent;
            this.cbbStartPoint.BorderRadius = 8;
            this.cbbStartPoint.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbStartPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStartPoint.FocusedColor = System.Drawing.Color.Empty;
            this.cbbStartPoint.FocusedState.Parent = this.cbbStartPoint;
            this.cbbStartPoint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbStartPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbStartPoint.FormattingEnabled = true;
            this.cbbStartPoint.HoverState.Parent = this.cbbStartPoint;
            this.cbbStartPoint.ItemHeight = 30;
            this.cbbStartPoint.ItemsAppearance.Parent = this.cbbStartPoint;
            this.cbbStartPoint.Location = new System.Drawing.Point(171, 159);
            this.cbbStartPoint.Name = "cbbStartPoint";
            this.cbbStartPoint.ShadowDecoration.Parent = this.cbbStartPoint;
            this.cbbStartPoint.Size = new System.Drawing.Size(355, 36);
            this.cbbStartPoint.TabIndex = 29;
            // 
            // cbbEndPoint
            // 
            this.cbbEndPoint.BackColor = System.Drawing.Color.Transparent;
            this.cbbEndPoint.BorderRadius = 8;
            this.cbbEndPoint.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbEndPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEndPoint.FocusedColor = System.Drawing.Color.Empty;
            this.cbbEndPoint.FocusedState.Parent = this.cbbEndPoint;
            this.cbbEndPoint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbEndPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbEndPoint.FormattingEnabled = true;
            this.cbbEndPoint.HoverState.Parent = this.cbbEndPoint;
            this.cbbEndPoint.ItemHeight = 30;
            this.cbbEndPoint.ItemsAppearance.Parent = this.cbbEndPoint;
            this.cbbEndPoint.Location = new System.Drawing.Point(171, 210);
            this.cbbEndPoint.Name = "cbbEndPoint";
            this.cbbEndPoint.ShadowDecoration.Parent = this.cbbEndPoint;
            this.cbbEndPoint.Size = new System.Drawing.Size(356, 36);
            this.cbbEndPoint.TabIndex = 30;
            // 
            // cbbBus
            // 
            this.cbbBus.BackColor = System.Drawing.Color.Transparent;
            this.cbbBus.BorderRadius = 8;
            this.cbbBus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBus.FocusedColor = System.Drawing.Color.Empty;
            this.cbbBus.FocusedState.Parent = this.cbbBus;
            this.cbbBus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbBus.FormattingEnabled = true;
            this.cbbBus.HoverState.Parent = this.cbbBus;
            this.cbbBus.ItemHeight = 30;
            this.cbbBus.ItemsAppearance.Parent = this.cbbBus;
            this.cbbBus.Location = new System.Drawing.Point(122, 85);
            this.cbbBus.Name = "cbbBus";
            this.cbbBus.ShadowDecoration.Parent = this.cbbBus;
            this.cbbBus.Size = new System.Drawing.Size(208, 36);
            this.cbbBus.TabIndex = 32;
            this.cbbBus.SelectedIndexChanged += new System.EventHandler(this.cbbBus_SelectedIndexChanged);
            // 
            // cbbSchedule
            // 
            this.cbbSchedule.BackColor = System.Drawing.Color.Transparent;
            this.cbbSchedule.BorderRadius = 8;
            this.cbbSchedule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSchedule.FocusedColor = System.Drawing.Color.Empty;
            this.cbbSchedule.FocusedState.Parent = this.cbbSchedule;
            this.cbbSchedule.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSchedule.FormattingEnabled = true;
            this.cbbSchedule.HoverState.Parent = this.cbbSchedule;
            this.cbbSchedule.ItemHeight = 30;
            this.cbbSchedule.ItemsAppearance.Parent = this.cbbSchedule;
            this.cbbSchedule.Location = new System.Drawing.Point(507, 81);
            this.cbbSchedule.Name = "cbbSchedule";
            this.cbbSchedule.ShadowDecoration.Parent = this.cbbSchedule;
            this.cbbSchedule.Size = new System.Drawing.Size(208, 36);
            this.cbbSchedule.TabIndex = 33;
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 566);
            this.Controls.Add(this.cbbSchedule);
            this.Controls.Add(this.cbbBus);
            this.Controls.Add(this.cbbEndPoint);
            this.Controls.Add(this.cbbStartPoint);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.btPickSeat);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpBookingdate);
            this.Controls.Add(this.lbBookingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbTrain);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbSeat);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTicketID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookTicket";
            this.Text = "BookTicket";
            this.Load += new System.EventHandler(this.BookTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTrain;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbBookingDate;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dpBookingdate;
        private System.Windows.Forms.TextBox txtType;
        private Guna.UI2.WinForms.Guna2Button btPickSeat;
        private Guna.UI2.WinForms.Guna2Button btConfirm;
        private Guna.UI2.WinForms.Guna2ComboBox cbbStartPoint;
        private Guna.UI2.WinForms.Guna2ComboBox cbbEndPoint;
        private Guna.UI2.WinForms.Guna2ComboBox cbbBus;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSchedule;
    }
}