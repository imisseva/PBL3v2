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
            this.btTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.cbbBus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbRoute = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btTimKiem
            // 
            this.btTimKiem.CheckedState.Parent = this.btTimKiem;
            this.btTimKiem.CustomImages.Parent = this.btTimKiem;
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.HoverState.Parent = this.btTimKiem;
            this.btTimKiem.Location = new System.Drawing.Point(397, 33);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShadowDecoration.Parent = this.btTimKiem;
            this.btTimKiem.Size = new System.Drawing.Size(107, 36);
            this.btTimKiem.TabIndex = 8;
            this.btTimKiem.Text = "Tìm kiếm";
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
            this.cbbBus.Location = new System.Drawing.Point(101, 33);
            this.cbbBus.Name = "cbbBus";
            this.cbbBus.ShadowDecoration.Parent = this.cbbBus;
            this.cbbBus.Size = new System.Drawing.Size(130, 36);
            this.cbbBus.TabIndex = 7;
            this.cbbBus.SelectedIndexChanged += new System.EventHandler(this.cbbBus_SelectedIndexChanged);
            // 
            // cbbRoute
            // 
            this.cbbRoute.FormattingEnabled = true;
            this.cbbRoute.Location = new System.Drawing.Point(248, 33);
            this.cbbRoute.Name = "cbbRoute";
            this.cbbRoute.Size = new System.Drawing.Size(121, 24);
            this.cbbRoute.TabIndex = 6;
            // 
            // ShowSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 501);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.cbbBus);
            this.Controls.Add(this.cbbRoute);
            this.Name = "ShowSeats";
            this.Text = "ShowSeats";
            
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbbBus;
        private System.Windows.Forms.ComboBox cbbRoute;
    }
}