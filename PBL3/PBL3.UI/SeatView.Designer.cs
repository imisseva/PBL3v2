namespace PBL3
{
    partial class SeatView
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
            this.cbbPickBus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbPickBus
            // 
            this.cbbPickBus.BackColor = System.Drawing.Color.Transparent;
            this.cbbPickBus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPickBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPickBus.FocusedColor = System.Drawing.Color.Empty;
            this.cbbPickBus.FocusedState.Parent = this.cbbPickBus;
            this.cbbPickBus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPickBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbPickBus.FormattingEnabled = true;
            this.cbbPickBus.HoverState.Parent = this.cbbPickBus;
            this.cbbPickBus.ItemHeight = 30;
            this.cbbPickBus.ItemsAppearance.Parent = this.cbbPickBus;
            this.cbbPickBus.Location = new System.Drawing.Point(33, 25);
            this.cbbPickBus.Name = "cbbPickBus";
            this.cbbPickBus.ShadowDecoration.Parent = this.cbbPickBus;
            this.cbbPickBus.Size = new System.Drawing.Size(248, 36);
            this.cbbPickBus.TabIndex = 9;
            this.cbbPickBus.SelectedIndexChanged += new System.EventHandler(this.cbbPickBus_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(33, 87);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(763, 461);
            this.dgv.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(357, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(105, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(532, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(105, 36);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Animated = true;
            this.btnDel.BorderRadius = 8;
            this.btnDel.CheckedState.Parent = this.btnDel;
            this.btnDel.CustomImages.Parent = this.btnDel;
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.HoverState.Parent = this.btnDel;
            this.btnDel.Location = new System.Drawing.Point(691, 25);
            this.btnDel.Name = "btnDel";
            this.btnDel.ShadowDecoration.Parent = this.btnDel;
            this.btnDel.Size = new System.Drawing.Size(105, 36);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Xoá";
            // 
            // SeatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 608);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbbPickBus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeatView";
            this.Text = "SeatView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbbPickBus;
        private System.Windows.Forms.DataGridView dgv;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDel;
    }
}