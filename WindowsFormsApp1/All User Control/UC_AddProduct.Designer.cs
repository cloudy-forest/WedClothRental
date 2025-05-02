namespace WindowsFormsApp1.All_User_Control
{
    partial class UC_AddProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaisp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiasp = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemsp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtTrangthai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DataGridViewTSP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTensp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoasp = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif JP", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif JP", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1023, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoluong.DefaultText = "";
            this.txtSoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoluong.ForeColor = System.Drawing.Color.Black;
            this.txtSoluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.Location = new System.Drawing.Point(1021, 369);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.PlaceholderText = "";
            this.txtSoluong.SelectedText = "";
            this.txtSoluong.Size = new System.Drawing.Size(665, 96);
            this.txtSoluong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Serif JP", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1013, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLoaisp
            // 
            this.txtLoaisp.BackColor = System.Drawing.Color.Transparent;
            this.txtLoaisp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtLoaisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLoaisp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaisp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaisp.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtLoaisp.ForeColor = System.Drawing.Color.Black;
            this.txtLoaisp.ItemHeight = 30;
            this.txtLoaisp.Items.AddRange(new object[] {
            "Vest",
            "Váy cưới"});
            this.txtLoaisp.Location = new System.Drawing.Point(1019, 99);
            this.txtLoaisp.Name = "txtLoaisp";
            this.txtLoaisp.Size = new System.Drawing.Size(665, 36);
            this.txtLoaisp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Serif JP", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1023, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trạng thái";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtGiasp
            // 
            this.txtGiasp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiasp.DefaultText = "";
            this.txtGiasp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiasp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiasp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiasp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiasp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiasp.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiasp.ForeColor = System.Drawing.Color.Black;
            this.txtGiasp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiasp.Location = new System.Drawing.Point(1021, 677);
            this.txtGiasp.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtGiasp.Name = "txtGiasp";
            this.txtGiasp.PlaceholderText = "";
            this.txtGiasp.SelectedText = "";
            this.txtGiasp.Size = new System.Drawing.Size(665, 43);
            this.txtGiasp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Serif JP", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1013, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá sản phẩm";
            // 
            // btnThemsp
            // 
            this.btnThemsp.BorderRadius = 18;
            this.btnThemsp.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnThemsp.BorderThickness = 1;
            this.btnThemsp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnThemsp.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnThemsp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemsp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemsp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemsp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemsp.FillColor = System.Drawing.Color.White;
            this.btnThemsp.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemsp.ForeColor = System.Drawing.Color.Black;
            this.btnThemsp.Location = new System.Drawing.Point(1233, 759);
            this.btnThemsp.Name = "btnThemsp";
            this.btnThemsp.Size = new System.Drawing.Size(292, 72);
            this.btnThemsp.TabIndex = 10;
            this.btnThemsp.Text = "Thêm sản phẩm";
            this.btnThemsp.Click += new System.EventHandler(this.btnThemsp_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.BackColor = System.Drawing.Color.Transparent;
            this.txtTrangthai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTrangthai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangthai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangthai.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtTrangthai.ForeColor = System.Drawing.Color.Black;
            this.txtTrangthai.ItemHeight = 30;
            this.txtTrangthai.Items.AddRange(new object[] {
            "Nguyên vẹn",
            "Hư hỏng"});
            this.txtTrangthai.Location = new System.Drawing.Point(1020, 560);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(665, 36);
            this.txtTrangthai.TabIndex = 11;
            // 
            // DataGridViewTSP
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewTSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewTSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewTSP.ColumnHeadersHeight = 4;
            this.DataGridViewTSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTSP.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewTSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewTSP.Location = new System.Drawing.Point(22, 158);
            this.DataGridViewTSP.Name = "DataGridViewTSP";
            this.DataGridViewTSP.RowHeadersVisible = false;
            this.DataGridViewTSP.RowHeadersWidth = 82;
            this.DataGridViewTSP.RowTemplate.Height = 33;
            this.DataGridViewTSP.Size = new System.Drawing.Size(846, 563);
            this.DataGridViewTSP.TabIndex = 12;
            this.DataGridViewTSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewTSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewTSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewTSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewTSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewTSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewTSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewTSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewTSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewTSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewTSP.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewTSP.ThemeStyle.ReadOnly = false;
            this.DataGridViewTSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewTSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewTSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewTSP.ThemeStyle.RowsStyle.Height = 33;
            this.DataGridViewTSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewTSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewTSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Serif JP", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1015, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên sản phẩm";
            // 
            // txtTensp
            // 
            this.txtTensp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTensp.DefaultText = "";
            this.txtTensp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTensp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTensp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTensp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTensp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTensp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTensp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTensp.Location = new System.Drawing.Point(1020, 230);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.PlaceholderText = "";
            this.txtTensp.SelectedText = "";
            this.txtTensp.Size = new System.Drawing.Size(666, 77);
            this.txtTensp.TabIndex = 14;
            // 
            // btnXoasp
            // 
            this.btnXoasp.BorderRadius = 18;
            this.btnXoasp.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnXoasp.BorderThickness = 1;
            this.btnXoasp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnXoasp.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnXoasp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoasp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoasp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoasp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoasp.FillColor = System.Drawing.Color.White;
            this.btnXoasp.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoasp.ForeColor = System.Drawing.Color.Black;
            this.btnXoasp.Location = new System.Drawing.Point(308, 746);
            this.btnXoasp.Name = "btnXoasp";
            this.btnXoasp.Size = new System.Drawing.Size(292, 72);
            this.btnXoasp.TabIndex = 15;
            this.btnXoasp.Text = "Xóa sản phẩm";
            this.btnXoasp.Click += new System.EventHandler(this.btnXoasp_Click);
            // 
            // UC_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoasp);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataGridViewTSP);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.btnThemsp);
            this.Controls.Add(this.txtGiasp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoaisp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddProduct";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_AddProduct_Load);
            this.Enter += new System.EventHandler(this.UC_AddProduct_Enter);
            this.Leave += new System.EventHandler(this.UC_AddProduct_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSoluong;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox txtLoaisp;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtGiasp;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnThemsp;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox txtTrangthai;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewTSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTensp;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnXoasp;
    }
}
