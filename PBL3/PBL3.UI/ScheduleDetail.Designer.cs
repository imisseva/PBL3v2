﻿using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ADD = new Guna.UI2.WinForms.Guna2Button();
            this.cbBus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtIDSchedule = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.dpStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtEndTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbRoute = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtStartSt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEndSt = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvStops = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStops)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tuyến đường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 26);
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
            this.ADD.Location = new System.Drawing.Point(408, 157);
            this.ADD.Name = "ADD";
            this.ADD.ShadowDecoration.Parent = this.ADD;
            this.ADD.Size = new System.Drawing.Size(86, 32);
            this.ADD.TabIndex = 10;
            this.ADD.Text = "LOAD";
            this.ADD.Click += new System.EventHandler(this.btnLoadStops_Click);
            // 
            // cbBus
            // 
            this.cbBus.BackColor = System.Drawing.Color.Transparent;
            this.cbBus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBus.FocusedColor = System.Drawing.Color.Empty;
            this.cbBus.FocusedState.Parent = this.cbBus;
            this.cbBus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBus.FormattingEnabled = true;
            this.cbBus.HoverState.Parent = this.cbBus;
            this.cbBus.ItemHeight = 30;
            this.cbBus.ItemsAppearance.Parent = this.cbBus;
            this.cbBus.Location = new System.Drawing.Point(130, 149);
            this.cbBus.Name = "cbBus";
            this.cbBus.ShadowDecoration.Parent = this.cbBus;
            this.cbBus.Size = new System.Drawing.Size(171, 36);
            this.cbBus.TabIndex = 14;
            // 
            // txtIDSchedule
            // 
            this.txtIDSchedule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDSchedule.DefaultText = "";
            this.txtIDSchedule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDSchedule.DisabledState.Parent = this.txtIDSchedule;
            this.txtIDSchedule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDSchedule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDSchedule.FocusedState.Parent = this.txtIDSchedule;
            this.txtIDSchedule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDSchedule.HoverState.Parent = this.txtIDSchedule;
            this.txtIDSchedule.Location = new System.Drawing.Point(130, 15);
            this.txtIDSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDSchedule.Name = "txtIDSchedule";
            this.txtIDSchedule.PasswordChar = '\0';
            this.txtIDSchedule.PlaceholderText = "";
            this.txtIDSchedule.SelectedText = "";
            this.txtIDSchedule.ShadowDecoration.Parent = this.txtIDSchedule;
            this.txtIDSchedule.Size = new System.Drawing.Size(171, 27);
            this.txtIDSchedule.TabIndex = 15;
            this.txtIDSchedule.Leave += new System.EventHandler(this.guna2TextBox1_Leave);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(209, 442);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(92, 33);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(490, 442);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(94, 36);
            this.guna2Button2.TabIndex = 17;
            this.guna2Button2.Text = "Cancel";
            this.guna2Button2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dpStartTime
            // 
            this.dpStartTime.Location = new System.Drawing.Point(130, 111);
            this.dpStartTime.Name = "dpStartTime";
            this.dpStartTime.Size = new System.Drawing.Size(240, 22);
            this.dpStartTime.TabIndex = 19;
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
            this.txtEndTime.Location = new System.Drawing.Point(523, 111);
            this.txtEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.PasswordChar = '\0';
            this.txtEndTime.PlaceholderText = "";
            this.txtEndTime.ReadOnly = true;
            this.txtEndTime.SelectedText = "";
            this.txtEndTime.ShadowDecoration.Parent = this.txtEndTime;
            this.txtEndTime.Size = new System.Drawing.Size(240, 22);
            this.txtEndTime.TabIndex = 20;
            // 
            // cbRoute
            // 
            this.cbRoute.BackColor = System.Drawing.Color.Transparent;
            this.cbRoute.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoute.FocusedColor = System.Drawing.Color.Empty;
            this.cbRoute.FocusedState.Parent = this.cbRoute;
            this.cbRoute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.HoverState.Parent = this.cbRoute;
            this.cbRoute.ItemHeight = 30;
            this.cbRoute.ItemsAppearance.Parent = this.cbRoute;
            this.cbRoute.Location = new System.Drawing.Point(523, 6);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.ShadowDecoration.Parent = this.cbRoute;
            this.cbRoute.Size = new System.Drawing.Size(240, 36);
            this.cbRoute.TabIndex = 21;
            this.cbRoute.SelectedIndexChanged += new System.EventHandler(this.cbRoute_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(41, 75);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(0, 0);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = null;
            // 
            // txtStartSt
            // 
            this.txtStartSt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartSt.DefaultText = "";
            this.txtStartSt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStartSt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStartSt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartSt.DisabledState.Parent = this.txtStartSt;
            this.txtStartSt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartSt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartSt.FocusedState.Parent = this.txtStartSt;
            this.txtStartSt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartSt.HoverState.Parent = this.txtStartSt;
            this.txtStartSt.Location = new System.Drawing.Point(130, 63);
            this.txtStartSt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStartSt.Name = "txtStartSt";
            this.txtStartSt.PasswordChar = '\0';
            this.txtStartSt.PlaceholderText = "";
            this.txtStartSt.ReadOnly = true;
            this.txtStartSt.SelectedText = "";
            this.txtStartSt.ShadowDecoration.Parent = this.txtStartSt;
            this.txtStartSt.Size = new System.Drawing.Size(240, 30);
            this.txtStartSt.TabIndex = 23;
            // 
            // txtEndSt
            // 
            this.txtEndSt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndSt.DefaultText = "";
            this.txtEndSt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEndSt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEndSt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndSt.DisabledState.Parent = this.txtEndSt;
            this.txtEndSt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndSt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndSt.FocusedState.Parent = this.txtEndSt;
            this.txtEndSt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndSt.HoverState.Parent = this.txtEndSt;
            this.txtEndSt.Location = new System.Drawing.Point(523, 63);
            this.txtEndSt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndSt.Name = "txtEndSt";
            this.txtEndSt.PasswordChar = '\0';
            this.txtEndSt.PlaceholderText = "";
            this.txtEndSt.ReadOnly = true;
            this.txtEndSt.SelectedText = "";
            this.txtEndSt.ShadowDecoration.Parent = this.txtEndSt;
            this.txtEndSt.Size = new System.Drawing.Size(240, 30);
            this.txtEndSt.TabIndex = 23;
            // 
            // dgvStops
            // 
            this.dgvStops.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvStops.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStops.BackgroundColor = System.Drawing.Color.White;
            this.dgvStops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStops.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStops.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStops.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStops.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStops.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStops.EnableHeadersVisualStyles = false;
            this.dgvStops.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStops.Location = new System.Drawing.Point(60, 213);
            this.dgvStops.Name = "dgvStops";
            this.dgvStops.RowHeadersVisible = false;
            this.dgvStops.RowHeadersWidth = 51;
            this.dgvStops.RowTemplate.Height = 24;
            this.dgvStops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStops.Size = new System.Drawing.Size(700, 200);
            this.dgvStops.TabIndex = 24;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ga đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ga đi";
            // 
            // ScheduleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStops);
            this.Controls.Add(this.txtEndSt);
            this.Controls.Add(this.txtStartSt);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cbRoute);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.dpStartTime);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtIDSchedule);
            this.Controls.Add(this.cbBus);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button ADD;
        private Guna.UI2.WinForms.Guna2ComboBox cbBus;
        private Guna.UI2.WinForms.Guna2TextBox txtIDSchedule;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DateTimePicker dpStartTime;
        private Guna.UI2.WinForms.Guna2TextBox txtEndTime;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoute;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtStartSt;
        private Guna.UI2.WinForms.Guna2TextBox txtEndSt;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStops;
        private Label label2;
        private Label label7;
    }
}