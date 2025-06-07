namespace PBL3
{
    partial class RouteDetail
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStartSt = new System.Windows.Forms.ComboBox();
            this.cbEndSt = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Tuyến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ga đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ga đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoảng cách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian ";
            // 
            // cbStartSt
            // 
            this.cbStartSt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartSt.FormattingEnabled = true;
            this.cbStartSt.Location = new System.Drawing.Point(266, 118);
            this.cbStartSt.Name = "cbStartSt";
            this.cbStartSt.Size = new System.Drawing.Size(218, 24);
            this.cbStartSt.TabIndex = 1;
            // 
            // cbEndSt
            // 
            this.cbEndSt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndSt.FormattingEnabled = true;
            this.cbEndSt.Location = new System.Drawing.Point(266, 183);
            this.cbEndSt.Name = "cbEndSt";
            this.cbEndSt.Size = new System.Drawing.Size(218, 24);
            this.cbEndSt.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(266, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(218, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(266, 243);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(218, 22);
            this.txtDistance.TabIndex = 3;
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(266, 303);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(218, 22);
            this.txtTime.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(227, 392);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RouteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbEndSt);
            this.Controls.Add(this.cbStartSt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RouteDetail";
            this.Text = "RouteDetail";
            this.Load += new System.EventHandler(this.RouteDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStartSt;
        private System.Windows.Forms.ComboBox cbEndSt;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OK;
    }
}