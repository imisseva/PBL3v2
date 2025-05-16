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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSeat = new System.Windows.Forms.Label();
            this.lbBookingDate = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.dpBookingdate = new System.Windows.Forms.DateTimePicker();
            this.btPickSeat = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.cbbStartPoint = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbEndPoint = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvBus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(387, 40);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(90, 16);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Ngày đi/Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã vé/Ticket ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nơi đi/Start point:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nơi đến/End point:";
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Location = new System.Drawing.Point(33, 415);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(66, 16);
            this.lbSeat.TabIndex = 6;
            this.lbSeat.Text = "Chỗ/Seat:";
            // 
            // lbBookingDate
            // 
            this.lbBookingDate.AutoSize = true;
            this.lbBookingDate.Location = new System.Drawing.Point(33, 447);
            this.lbBookingDate.Name = "lbBookingDate";
            this.lbBookingDate.Size = new System.Drawing.Size(167, 16);
            this.lbBookingDate.TabIndex = 8;
            this.lbBookingDate.Text = "Ngày đặt vé/Booking date:";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(171, 409);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.ReadOnly = true;
            this.txtSeat.Size = new System.Drawing.Size(210, 22);
            this.txtSeat.TabIndex = 14;
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(171, 37);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(210, 22);
            this.txtTicketID.TabIndex = 17;
            // 
            // dpBookingdate
            // 
            this.dpBookingdate.Location = new System.Drawing.Point(220, 441);
            this.dpBookingdate.Name = "dpBookingdate";
            this.dpBookingdate.Size = new System.Drawing.Size(248, 22);
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
            this.btPickSeat.Location = new System.Drawing.Point(429, 409);
            this.btPickSeat.Name = "btPickSeat";
            this.btPickSeat.ShadowDecoration.Parent = this.btPickSeat;
            this.btPickSeat.Size = new System.Drawing.Size(98, 22);
            this.btPickSeat.TabIndex = 27;
            this.btPickSeat.Text = "Chọn ghế";
            this.btPickSeat.Click += new System.EventHandler(this.btPickSeat_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 8;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(149, 479);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(164, 37);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.cbbStartPoint.Location = new System.Drawing.Point(171, 79);
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
            this.cbbEndPoint.Location = new System.Drawing.Point(170, 125);
            this.cbbEndPoint.Name = "cbbEndPoint";
            this.cbbEndPoint.ShadowDecoration.Parent = this.cbbEndPoint;
            this.cbbEndPoint.Size = new System.Drawing.Size(356, 36);
            this.cbbEndPoint.TabIndex = 30;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(493, 35);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 22);
            this.dtpDate.TabIndex = 31;
            // 
            // dgvBus
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvBus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBus.BackgroundColor = System.Drawing.Color.White;
            this.dgvBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBus.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBus.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBus.EnableHeadersVisualStyles = false;
            this.dgvBus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBus.Location = new System.Drawing.Point(36, 179);
            this.dgvBus.Name = "dgvBus";
            this.dgvBus.RowHeadersVisible = false;
            this.dgvBus.RowHeadersWidth = 51;
            this.dgvBus.RowTemplate.Height = 24;
            this.dgvBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBus.Size = new System.Drawing.Size(702, 220);
            this.dgvBus.TabIndex = 32;
            this.dgvBus.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvBus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBus.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBus.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBus.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBus.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvBus.ThemeStyle.ReadOnly = false;
            this.dgvBus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBus.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnLoad
            // 
            this.btnLoad.CheckedState.Parent = this.btnLoad;
            this.btnLoad.CustomImages.Parent = this.btnLoad;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.HoverState.Parent = this.btnLoad;
            this.btnLoad.Location = new System.Drawing.Point(587, 133);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShadowDecoration.Parent = this.btnLoad;
            this.btnLoad.Size = new System.Drawing.Size(92, 28);
            this.btnLoad.TabIndex = 33;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btn_LoaddgvBus_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(483, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(164, 37);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Thoát";
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 566);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvBus);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbbEndPoint);
            this.Controls.Add(this.cbbStartPoint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btPickSeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpBookingdate);
            this.Controls.Add(this.lbBookingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbSeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTicketID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookTicket";
            this.Text = "BookTicket";
            this.Load += new System.EventHandler(this.BookTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.Label lbBookingDate;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.DateTimePicker dpBookingdate;
        private Guna.UI2.WinForms.Guna2Button btPickSeat;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2ComboBox cbbStartPoint;
        private Guna.UI2.WinForms.Guna2ComboBox cbbEndPoint;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBus;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}