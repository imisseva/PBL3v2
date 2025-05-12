namespace PBL3.UI
{
    partial class ScheduleDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ADD = new Guna.UI2.WinForms.Guna2Button();
            this.dgvStops = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboBoxStartStation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxEndStation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtEndTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.dpStartTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStops)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bến bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bến kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID_Lịch";
            // 
            // ADD
            // 
            this.ADD.CheckedState.Parent = this.ADD;
            this.ADD.CustomImages.Parent = this.ADD;
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ADD.ForeColor = System.Drawing.Color.White;
            this.ADD.HoverState.Parent = this.ADD;
            this.ADD.Location = new System.Drawing.Point(678, 100);
            this.ADD.Name = "ADD";
            this.ADD.ShadowDecoration.Parent = this.ADD;
            this.ADD.Size = new System.Drawing.Size(86, 32);
            this.ADD.TabIndex = 10;
            this.ADD.Text = "ADD";
            this.ADD.Click += new System.EventHandler(this.btnLoadStops_Click);
            // 
            // dgvStops
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvStops.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStops.BackgroundColor = System.Drawing.Color.White;
            this.dgvStops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStops.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStops.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStops.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStops.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStops.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStops.EnableHeadersVisualStyles = false;
            this.dgvStops.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStops.Location = new System.Drawing.Point(60, 100);
            this.dgvStops.Name = "dgvStops";
            this.dgvStops.RowHeadersVisible = false;
            this.dgvStops.RowHeadersWidth = 51;
            this.dgvStops.RowTemplate.Height = 24;
            this.dgvStops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStops.Size = new System.Drawing.Size(594, 238);
            this.dgvStops.TabIndex = 11;
            this.dgvStops.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvStops.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStops.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStops.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStops.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStops.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStops.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStops.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStops.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvStops.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStops.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStops.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStops.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStops.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvStops.ThemeStyle.ReadOnly = false;
            this.dgvStops.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStops.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStops.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStops.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStops.ThemeStyle.RowsStyle.Height = 24;
            this.dgvStops.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStops.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // comboBoxStartStation
            // 
            this.comboBoxStartStation.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxStartStation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxStartStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartStation.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxStartStation.FocusedState.Parent = this.comboBoxStartStation;
            this.comboBoxStartStation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxStartStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxStartStation.FormattingEnabled = true;
            this.comboBoxStartStation.HoverState.Parent = this.comboBoxStartStation;
            this.comboBoxStartStation.ItemHeight = 30;
            this.comboBoxStartStation.ItemsAppearance.Parent = this.comboBoxStartStation;
            this.comboBoxStartStation.Location = new System.Drawing.Point(155, 62);
            this.comboBoxStartStation.Name = "comboBoxStartStation";
            this.comboBoxStartStation.ShadowDecoration.Parent = this.comboBoxStartStation;
            this.comboBoxStartStation.Size = new System.Drawing.Size(121, 36);
            this.comboBoxStartStation.TabIndex = 12;
            // 
            // comboBoxEndStation
            // 
            this.comboBoxEndStation.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEndStation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEndStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndStation.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxEndStation.FocusedState.Parent = this.comboBoxEndStation;
            this.comboBoxEndStation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEndStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxEndStation.FormattingEnabled = true;
            this.comboBoxEndStation.HoverState.Parent = this.comboBoxEndStation;
            this.comboBoxEndStation.ItemHeight = 30;
            this.comboBoxEndStation.ItemsAppearance.Parent = this.comboBoxEndStation;
            this.comboBoxEndStation.Location = new System.Drawing.Point(155, 348);
            this.comboBoxEndStation.Name = "comboBoxEndStation";
            this.comboBoxEndStation.ShadowDecoration.Parent = this.comboBoxEndStation;
            this.comboBoxEndStation.Size = new System.Drawing.Size(121, 36);
            this.comboBoxEndStation.TabIndex = 13;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(417, 14);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox1.TabIndex = 14;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(155, 15);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(121, 27);
            this.guna2TextBox1.TabIndex = 15;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(184, 402);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(92, 33);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Save";
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(417, 402);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(94, 36);
            this.guna2Button2.TabIndex = 17;
            this.guna2Button2.Text = "Cancel";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndTime.DefaultText = "";
            this.txtEndTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEndTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEndTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndTime.DisabledState.Parent = this.txtEndTime;
            this.txtEndTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndTime.FocusedState.Parent = this.txtEndTime;
            this.txtEndTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndTime.HoverState.Parent = this.txtEndTime;
            this.txtEndTime.Location = new System.Drawing.Point(417, 349);
            this.txtEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.PasswordChar = '\0';
            this.txtEndTime.PlaceholderText = "";
            this.txtEndTime.SelectedText = "";
            this.txtEndTime.ShadowDecoration.Parent = this.txtEndTime;
            this.txtEndTime.Size = new System.Drawing.Size(200, 35);
            this.txtEndTime.TabIndex = 18;
            // 
            // dpStartTime
            // 
            this.dpStartTime.Location = new System.Drawing.Point(417, 75);
            this.dpStartTime.Name = "dpStartTime";
            this.dpStartTime.Size = new System.Drawing.Size(347, 22);
            this.dpStartTime.TabIndex = 19;
            // 
            // ScheduleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dpStartTime);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.comboBoxEndStation);
            this.Controls.Add(this.comboBoxStartStation);
            this.Controls.Add(this.dgvStops);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleDetail";
            this.Text = "ScheduleDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button ADD;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStops;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxStartStation;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxEndStation;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox txtEndTime;
        private System.Windows.Forms.DateTimePicker dpStartTime;
    }
}