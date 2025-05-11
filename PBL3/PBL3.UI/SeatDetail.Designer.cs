namespace PBL3
{
    partial class SeatDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtIDSeat = new System.Windows.Forms.TextBox();
            this.numSeatNumber = new System.Windows.Forms.NumericUpDown();
            this.cbIDBus = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Ghế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Ghế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Ghế";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(128, 325);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtIDSeat
            // 
            this.txtIDSeat.Location = new System.Drawing.Point(254, 47);
            this.txtIDSeat.Name = "txtIDSeat";
            this.txtIDSeat.Size = new System.Drawing.Size(180, 22);
            this.txtIDSeat.TabIndex = 6;
            // 
            // numSeatNumber
            // 
            this.numSeatNumber.Location = new System.Drawing.Point(254, 173);
            this.numSeatNumber.Name = "numSeatNumber";
            this.numSeatNumber.Size = new System.Drawing.Size(180, 22);
            this.numSeatNumber.TabIndex = 7;
            // 
            // cbIDBus
            // 
            this.cbIDBus.FormattingEnabled = true;
            this.cbIDBus.Location = new System.Drawing.Point(254, 109);
            this.cbIDBus.Name = "cbIDBus";
            this.cbIDBus.Size = new System.Drawing.Size(180, 24);
            this.cbIDBus.TabIndex = 8;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(254, 240);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(180, 24);
            this.cbType.TabIndex = 9;
            // 
            // SeatDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbIDBus);
            this.Controls.Add(this.numSeatNumber);
            this.Controls.Add(this.txtIDSeat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SeatDetail";
            this.Text = "SeatDetail";
            ((System.ComponentModel.ISupportInitialize)(this.numSeatNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtIDSeat;
        private System.Windows.Forms.NumericUpDown numSeatNumber;
        private System.Windows.Forms.ComboBox cbIDBus;
        private System.Windows.Forms.ComboBox cbType;
    }
}