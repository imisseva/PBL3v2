namespace PBL3.UI
{
    partial class ShowSeats
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.cbbBus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbRoute = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btTimKiem);
            this.panel2.Controls.Add(this.cbbBus);
            this.panel2.Controls.Add(this.cbbRoute);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 565);
            this.panel2.TabIndex = 23;
            // 
            // btTimKiem
            // 
            this.btTimKiem.CheckedState.Parent = this.btTimKiem;
            this.btTimKiem.CustomImages.Parent = this.btTimKiem;
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.HoverState.Parent = this.btTimKiem;
            this.btTimKiem.Location = new System.Drawing.Point(387, 47);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShadowDecoration.Parent = this.btTimKiem;
            this.btTimKiem.Size = new System.Drawing.Size(107, 36);
            this.btTimKiem.TabIndex = 5;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // cbbBus
            // 
            this.cbbBus.BackColor = System.Drawing.Color.Transparent;
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
            this.cbbBus.Location = new System.Drawing.Point(62, 47);
            this.cbbBus.Name = "cbbBus";
            this.cbbBus.ShadowDecoration.Parent = this.cbbBus;
            this.cbbBus.Size = new System.Drawing.Size(130, 36);
            this.cbbBus.TabIndex = 4;
            this.cbbBus.SelectedIndexChanged += new System.EventHandler(this.cbbtrain_SelectedIndexChanged);
            // 
            // cbbRoute
            // 
            this.cbbRoute.FormattingEnabled = true;
            this.cbbRoute.Location = new System.Drawing.Point(225, 47);
            this.cbbRoute.Name = "cbbRoute";
            this.cbbRoute.Size = new System.Drawing.Size(121, 24);
            this.cbbRoute.TabIndex = 3;
            // 
            // ShowSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 565);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowSeats";
            this.Text = "ShowSeats";
            this.Load += new System.EventHandler(this.ShowSeats_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbbBus;
        private System.Windows.Forms.ComboBox cbbRoute;
    }
}