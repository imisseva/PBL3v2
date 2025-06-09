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
            this.btStatistical = new Guna.UI2.WinForms.Guna2Button();
            this.DateRevenuedp = new System.Windows.Forms.DateTimePicker();
            this.plotPanel = new System.Windows.Forms.Panel();
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
            this.cbbPick.Location = new System.Drawing.Point(21, 12);
            this.cbbPick.Name = "cbbPick";
            this.cbbPick.ShadowDecoration.Parent = this.cbbPick;
            this.cbbPick.Size = new System.Drawing.Size(140, 36);
            this.cbbPick.TabIndex = 0;
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
            this.btStatistical.Location = new System.Drawing.Point(658, 12);
            this.btStatistical.Name = "btStatistical";
            this.btStatistical.ShadowDecoration.Parent = this.btStatistical;
            this.btStatistical.Size = new System.Drawing.Size(180, 36);
            this.btStatistical.TabIndex = 2;
            this.btStatistical.Text = "Thống kê";
            this.btStatistical.Click += new System.EventHandler(this.btStatistical_Click);
            // 
            // DateRevenuedp
            // 
            this.DateRevenuedp.Location = new System.Drawing.Point(185, 26);
            this.DateRevenuedp.Name = "DateRevenuedp";
            this.DateRevenuedp.Size = new System.Drawing.Size(215, 22);
            this.DateRevenuedp.TabIndex = 3;
            // 
            // plotPanel
            // 
            this.plotPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plotPanel.Location = new System.Drawing.Point(21, 60);
            this.plotPanel.Name = "plotPanel";
            this.plotPanel.Size = new System.Drawing.Size(817, 538);
            this.plotPanel.TabIndex = 4;
            // 
            // RevenueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 608);
            this.Controls.Add(this.plotPanel);
            this.Controls.Add(this.DateRevenuedp);
            this.Controls.Add(this.btStatistical);
            this.Controls.Add(this.cbbPick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevenueView";
            this.Text = "RevenueView";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbbPick;
        private Guna.UI2.WinForms.Guna2Button btStatistical;
        private System.Windows.Forms.DateTimePicker DateRevenuedp;
        private System.Windows.Forms.Panel plotPanel;
    }
}