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
            this.lbTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSeat = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbBookingDate = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtStartPoint = new System.Windows.Forms.TextBox();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbCabin = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbRoute = new System.Windows.Forms.ComboBox();
            this.cbbBus = new System.Windows.Forms.ComboBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTrain
            // 
            this.lbTrain.AutoSize = true;
            this.lbTrain.Location = new System.Drawing.Point(27, 155);
            this.lbTrain.Name = "lbTrain";
            this.lbTrain.Size = new System.Drawing.Size(53, 16);
            this.lbTrain.TabIndex = 0;
            this.lbTrain.Text = "Xe/Bus:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(27, 183);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(90, 16);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Ngày đi/Date:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(27, 210);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(80, 16);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Giờ đi/Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã vé/Ticket ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nơi đi/Start point:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nơi đến/End point:";
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Location = new System.Drawing.Point(27, 294);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(66, 16);
            this.lbSeat.TabIndex = 6;
            this.lbSeat.Text = "Chỗ/Seat:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(27, 378);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(49, 16);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Giá vé:";
            // 
            // lbBookingDate
            // 
            this.lbBookingDate.AutoSize = true;
            this.lbBookingDate.Location = new System.Drawing.Point(27, 350);
            this.lbBookingDate.Name = "lbBookingDate";
            this.lbBookingDate.Size = new System.Drawing.Size(167, 16);
            this.lbBookingDate.TabIndex = 8;
            this.lbBookingDate.Text = "Ngày đặt vé/Booking date:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(211, 207);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(210, 22);
            this.txtTime.TabIndex = 11;
            // 
            // txtStartPoint
            // 
            this.txtStartPoint.Location = new System.Drawing.Point(211, 235);
            this.txtStartPoint.Name = "txtStartPoint";
            this.txtStartPoint.Size = new System.Drawing.Size(210, 22);
            this.txtStartPoint.TabIndex = 12;
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(211, 263);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(210, 22);
            this.txtEndPoint.TabIndex = 13;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(211, 291);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(210, 22);
            this.txtSeat.TabIndex = 14;
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(211, 100);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(210, 22);
            this.txtTicketID.TabIndex = 17;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(27, 322);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(89, 16);
            this.lbType.TabIndex = 18;
            this.lbType.Text = "Loại xe/Type:";
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(320, 451);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(101, 23);
            this.btConfirm.TabIndex = 20;
            this.btConfirm.Text = "Xác nhận";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cbbCabin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btConfirm);
            this.panel1.Controls.Add(this.lbTrain);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbType);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.txtTicketID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbSeat);
            this.panel1.Controls.Add(this.txtSeat);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.txtEndPoint);
            this.panel1.Controls.Add(this.lbBookingDate);
            this.panel1.Controls.Add(this.txtStartPoint);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 504);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(211, 375);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 347);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(210, 22);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // cbbCabin
            // 
            this.cbbCabin.FormattingEnabled = true;
            this.cbbCabin.Location = new System.Drawing.Point(211, 150);
            this.cbbCabin.Name = "cbbCabin";
            this.cbbCabin.Size = new System.Drawing.Size(210, 24);
            this.cbbCabin.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbRoute);
            this.panel2.Controls.Add(this.cbbBus);
            this.panel2.Controls.Add(this.btTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(453, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 504);
            this.panel2.TabIndex = 22;
            // 
            // cbbRoute
            // 
            this.cbbRoute.FormattingEnabled = true;
            this.cbbRoute.Location = new System.Drawing.Point(181, 47);
            this.cbbRoute.Name = "cbbRoute";
            this.cbbRoute.Size = new System.Drawing.Size(121, 24);
            this.cbbRoute.TabIndex = 3;
            // 
            // cbbBus
            // 
            this.cbbBus.FormattingEnabled = true;
            this.cbbBus.Location = new System.Drawing.Point(37, 47);
            this.cbbBus.Name = "cbbBus";
            this.cbbBus.Size = new System.Drawing.Size(138, 24);
            this.cbbBus.TabIndex = 2;
            this.cbbBus.SelectedIndexChanged += new System.EventHandler(this.cbbtrain_SelectedIndexChanged);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(320, 41);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(89, 34);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 26;
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookTicket";
            this.Text = "BookTicket";
            this.Load += new System.EventHandler(this.BookTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTrain;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbBookingDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbCabin;
        private System.Windows.Forms.ComboBox cbbBus;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.ComboBox cbbRoute;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
    }
}