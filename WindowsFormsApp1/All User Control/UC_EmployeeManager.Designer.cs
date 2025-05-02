namespace WindowsFormsApp1.All_User_Control
{
    partial class UC_EmployeeManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNhanvien = new System.Windows.Forms.Label();
            this.tabctrlEmployee = new System.Windows.Forms.TabControl();
            this.tabpageDKNV = new System.Windows.Forms.TabPage();
            this.btnDangky = new Guna.UI2.WinForms.Guna2Button();
            this.lblPassNV = new System.Windows.Forms.Label();
            this.txtPassNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsernameNV = new System.Windows.Forms.Label();
            this.txtUsernameNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiachiNV = new System.Windows.Forms.Label();
            this.txtDiachiNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSdtNV = new System.Windows.Forms.Label();
            this.txtSdtNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmailNV = new System.Windows.Forms.Label();
            this.txtEmailNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblToset = new System.Windows.Forms.Label();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.tabpageTTNV = new System.Windows.Forms.TabPage();
            this.DataGridViewTTNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTTNV = new System.Windows.Forms.Label();
            this.tabpageXoaNV = new System.Windows.Forms.TabPage();
            this.DataGridViewXoaNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDdlt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDNVdlt = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tabctrlEmployee.SuspendLayout();
            this.tabpageDKNV.SuspendLayout();
            this.tabpageTTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTTNV)).BeginInit();
            this.tabpageXoaNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewXoaNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNhanvien
            // 
            this.lblNhanvien.AutoSize = true;
            this.lblNhanvien.Font = new System.Drawing.Font("Maiandra GD", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanvien.Location = new System.Drawing.Point(31, 46);
            this.lblNhanvien.Name = "lblNhanvien";
            this.lblNhanvien.Size = new System.Drawing.Size(268, 63);
            this.lblNhanvien.TabIndex = 0;
            this.lblNhanvien.Text = "Nhân viên";
            // 
            // tabctrlEmployee
            // 
            this.tabctrlEmployee.Controls.Add(this.tabpageDKNV);
            this.tabctrlEmployee.Controls.Add(this.tabpageTTNV);
            this.tabctrlEmployee.Controls.Add(this.tabpageXoaNV);
            this.tabctrlEmployee.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabctrlEmployee.Location = new System.Drawing.Point(35, 127);
            this.tabctrlEmployee.Name = "tabctrlEmployee";
            this.tabctrlEmployee.SelectedIndex = 0;
            this.tabctrlEmployee.Size = new System.Drawing.Size(1796, 668);
            this.tabctrlEmployee.TabIndex = 1;
            this.tabctrlEmployee.SelectedIndexChanged += new System.EventHandler(this.tabctrlEmployee_SelectedIndexChanged);
            // 
            // tabpageDKNV
            // 
            this.tabpageDKNV.Controls.Add(this.btnDangky);
            this.tabpageDKNV.Controls.Add(this.lblPassNV);
            this.tabpageDKNV.Controls.Add(this.txtPassNV);
            this.tabpageDKNV.Controls.Add(this.lblUsernameNV);
            this.tabpageDKNV.Controls.Add(this.txtUsernameNV);
            this.tabpageDKNV.Controls.Add(this.lblDiachiNV);
            this.tabpageDKNV.Controls.Add(this.txtDiachiNV);
            this.tabpageDKNV.Controls.Add(this.lblSdtNV);
            this.tabpageDKNV.Controls.Add(this.txtSdtNV);
            this.tabpageDKNV.Controls.Add(this.lblEmailNV);
            this.tabpageDKNV.Controls.Add(this.txtEmailNV);
            this.tabpageDKNV.Controls.Add(this.lblTenNV);
            this.tabpageDKNV.Controls.Add(this.lblToset);
            this.tabpageDKNV.Controls.Add(this.txtTenNV);
            this.tabpageDKNV.Controls.Add(this.lblIDNV);
            this.tabpageDKNV.Location = new System.Drawing.Point(8, 51);
            this.tabpageDKNV.Name = "tabpageDKNV";
            this.tabpageDKNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageDKNV.Size = new System.Drawing.Size(1780, 609);
            this.tabpageDKNV.TabIndex = 0;
            this.tabpageDKNV.Text = "Đăng kí nhân viên";
            this.tabpageDKNV.UseVisualStyleBackColor = true;
            // 
            // btnDangky
            // 
            this.btnDangky.BorderRadius = 18;
            this.btnDangky.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnDangky.BorderThickness = 1;
            this.btnDangky.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnDangky.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnDangky.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDangky.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangky.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangky.FillColor = System.Drawing.Color.White;
            this.btnDangky.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangky.ForeColor = System.Drawing.Color.Black;
            this.btnDangky.Location = new System.Drawing.Point(1325, 401);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(199, 74);
            this.btnDangky.TabIndex = 14;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // lblPassNV
            // 
            this.lblPassNV.AutoSize = true;
            this.lblPassNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassNV.ForeColor = System.Drawing.Color.Black;
            this.lblPassNV.Location = new System.Drawing.Point(910, 192);
            this.lblPassNV.Name = "lblPassNV";
            this.lblPassNV.Size = new System.Drawing.Size(152, 39);
            this.lblPassNV.TabIndex = 13;
            this.lblPassNV.Text = "Mật khẩu";
            // 
            // txtPassNV
            // 
            this.txtPassNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassNV.DefaultText = "";
            this.txtPassNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassNV.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtPassNV.ForeColor = System.Drawing.Color.Black;
            this.txtPassNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassNV.Location = new System.Drawing.Point(917, 249);
            this.txtPassNV.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPassNV.Name = "txtPassNV";
            this.txtPassNV.PlaceholderText = "Enter your password";
            this.txtPassNV.SelectedText = "";
            this.txtPassNV.Size = new System.Drawing.Size(606, 62);
            this.txtPassNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassNV.TabIndex = 12;
            // 
            // lblUsernameNV
            // 
            this.lblUsernameNV.AutoSize = true;
            this.lblUsernameNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameNV.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameNV.Location = new System.Drawing.Point(910, 75);
            this.lblUsernameNV.Name = "lblUsernameNV";
            this.lblUsernameNV.Size = new System.Drawing.Size(253, 39);
            this.lblUsernameNV.TabIndex = 11;
            this.lblUsernameNV.Text = "Tên người dùng";
            // 
            // txtUsernameNV
            // 
            this.txtUsernameNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameNV.DefaultText = "";
            this.txtUsernameNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameNV.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtUsernameNV.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameNV.Location = new System.Drawing.Point(918, 122);
            this.txtUsernameNV.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtUsernameNV.Name = "txtUsernameNV";
            this.txtUsernameNV.PlaceholderText = "Enter your username";
            this.txtUsernameNV.SelectedText = "";
            this.txtUsernameNV.Size = new System.Drawing.Size(606, 62);
            this.txtUsernameNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUsernameNV.TabIndex = 10;
            // 
            // lblDiachiNV
            // 
            this.lblDiachiNV.AutoSize = true;
            this.lblDiachiNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachiNV.ForeColor = System.Drawing.Color.Black;
            this.lblDiachiNV.Location = new System.Drawing.Point(16, 467);
            this.lblDiachiNV.Name = "lblDiachiNV";
            this.lblDiachiNV.Size = new System.Drawing.Size(128, 39);
            this.lblDiachiNV.TabIndex = 9;
            this.lblDiachiNV.Text = "Địa chỉ";
            // 
            // txtDiachiNV
            // 
            this.txtDiachiNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachiNV.DefaultText = "";
            this.txtDiachiNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiachiNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiachiNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachiNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachiNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachiNV.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtDiachiNV.ForeColor = System.Drawing.Color.Black;
            this.txtDiachiNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachiNV.Location = new System.Drawing.Point(23, 514);
            this.txtDiachiNV.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtDiachiNV.Name = "txtDiachiNV";
            this.txtDiachiNV.PlaceholderText = "Enter your address";
            this.txtDiachiNV.SelectedText = "";
            this.txtDiachiNV.Size = new System.Drawing.Size(606, 62);
            this.txtDiachiNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDiachiNV.TabIndex = 8;
            // 
            // lblSdtNV
            // 
            this.lblSdtNV.AutoSize = true;
            this.lblSdtNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdtNV.ForeColor = System.Drawing.Color.Black;
            this.lblSdtNV.Location = new System.Drawing.Point(16, 324);
            this.lblSdtNV.Name = "lblSdtNV";
            this.lblSdtNV.Size = new System.Drawing.Size(206, 39);
            this.lblSdtNV.TabIndex = 7;
            this.lblSdtNV.Text = "Số điện thoại";
            // 
            // txtSdtNV
            // 
            this.txtSdtNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdtNV.DefaultText = "";
            this.txtSdtNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSdtNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSdtNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdtNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdtNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdtNV.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtSdtNV.ForeColor = System.Drawing.Color.Black;
            this.txtSdtNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdtNV.Location = new System.Drawing.Point(22, 379);
            this.txtSdtNV.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtSdtNV.Name = "txtSdtNV";
            this.txtSdtNV.PlaceholderText = "Enter your phone number";
            this.txtSdtNV.SelectedText = "";
            this.txtSdtNV.Size = new System.Drawing.Size(606, 62);
            this.txtSdtNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSdtNV.TabIndex = 6;
            // 
            // lblEmailNV
            // 
            this.lblEmailNV.AutoSize = true;
            this.lblEmailNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailNV.ForeColor = System.Drawing.Color.Black;
            this.lblEmailNV.Location = new System.Drawing.Point(15, 192);
            this.lblEmailNV.Name = "lblEmailNV";
            this.lblEmailNV.Size = new System.Drawing.Size(99, 39);
            this.lblEmailNV.TabIndex = 5;
            this.lblEmailNV.Text = "Email";
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailNV.DefaultText = "";
            this.txtEmailNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailNV.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtEmailNV.ForeColor = System.Drawing.Color.Black;
            this.txtEmailNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailNV.Location = new System.Drawing.Point(22, 249);
            this.txtEmailNV.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.PlaceholderText = "Enter your email";
            this.txtEmailNV.SelectedText = "";
            this.txtEmailNV.Size = new System.Drawing.Size(606, 62);
            this.txtEmailNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmailNV.TabIndex = 4;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Black;
            this.lblTenNV.Location = new System.Drawing.Point(15, 75);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(71, 39);
            this.lblTenNV.TabIndex = 3;
            this.lblTenNV.Text = "Tên";
            // 
            // lblToset
            // 
            this.lblToset.AutoSize = true;
            this.lblToset.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblToset.ForeColor = System.Drawing.Color.Black;
            this.lblToset.Location = new System.Drawing.Point(92, 25);
            this.lblToset.Name = "lblToset";
            this.lblToset.Size = new System.Drawing.Size(97, 50);
            this.lblToset.TabIndex = 2;
            this.lblToset.Text = "-----";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(23, 122);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PlaceholderText = "Enter your name";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(606, 62);
            this.txtTenNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTenNV.TabIndex = 1;
            // 
            // lblIDNV
            // 
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNV.ForeColor = System.Drawing.Color.Black;
            this.lblIDNV.Location = new System.Drawing.Point(16, 25);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(70, 38);
            this.lblIDNV.TabIndex = 0;
            this.lblIDNV.Text = "ID -";
            // 
            // tabpageTTNV
            // 
            this.tabpageTTNV.Controls.Add(this.DataGridViewTTNV);
            this.tabpageTTNV.Controls.Add(this.lblTTNV);
            this.tabpageTTNV.Location = new System.Drawing.Point(8, 51);
            this.tabpageTTNV.Name = "tabpageTTNV";
            this.tabpageTTNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageTTNV.Size = new System.Drawing.Size(1780, 609);
            this.tabpageTTNV.TabIndex = 1;
            this.tabpageTTNV.Text = "Thông tin nhân viên";
            this.tabpageTTNV.UseVisualStyleBackColor = true;
            // 
            // DataGridViewTTNV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewTTNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewTTNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTTNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTTNV.ColumnHeadersHeight = 4;
            this.DataGridViewTTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTTNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTTNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewTTNV.Location = new System.Drawing.Point(30, 105);
            this.DataGridViewTTNV.Name = "DataGridViewTTNV";
            this.DataGridViewTTNV.RowHeadersVisible = false;
            this.DataGridViewTTNV.RowHeadersWidth = 82;
            this.DataGridViewTTNV.RowTemplate.Height = 33;
            this.DataGridViewTTNV.Size = new System.Drawing.Size(1727, 465);
            this.DataGridViewTTNV.TabIndex = 1;
            this.DataGridViewTTNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTTNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewTTNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewTTNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewTTNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewTTNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTTNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewTTNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewTTNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewTTNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewTTNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewTTNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewTTNV.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewTTNV.ThemeStyle.ReadOnly = false;
            this.DataGridViewTTNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTTNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewTTNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewTTNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewTTNV.ThemeStyle.RowsStyle.Height = 33;
            this.DataGridViewTTNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewTTNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblTTNV
            // 
            this.lblTTNV.AutoSize = true;
            this.lblTTNV.Font = new System.Drawing.Font("Maiandra GD", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTNV.Location = new System.Drawing.Point(1134, 38);
            this.lblTTNV.Name = "lblTTNV";
            this.lblTTNV.Size = new System.Drawing.Size(574, 51);
            this.lblTTNV.TabIndex = 0;
            this.lblTTNV.Text = "Thông tin chi tiết nhân viên";
            // 
            // tabpageXoaNV
            // 
            this.tabpageXoaNV.Controls.Add(this.DataGridViewXoaNV);
            this.tabpageXoaNV.Controls.Add(this.btnXoa);
            this.tabpageXoaNV.Controls.Add(this.txtIDdlt);
            this.tabpageXoaNV.Controls.Add(this.lblIDNVdlt);
            this.tabpageXoaNV.Location = new System.Drawing.Point(8, 51);
            this.tabpageXoaNV.Name = "tabpageXoaNV";
            this.tabpageXoaNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageXoaNV.Size = new System.Drawing.Size(1780, 609);
            this.tabpageXoaNV.TabIndex = 2;
            this.tabpageXoaNV.Text = "Xóa nhân viên";
            this.tabpageXoaNV.UseVisualStyleBackColor = true;
            // 
            // DataGridViewXoaNV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewXoaNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewXoaNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewXoaNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewXoaNV.ColumnHeadersHeight = 4;
            this.DataGridViewXoaNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewXoaNV.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewXoaNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewXoaNV.Location = new System.Drawing.Point(29, 249);
            this.DataGridViewXoaNV.Name = "DataGridViewXoaNV";
            this.DataGridViewXoaNV.RowHeadersVisible = false;
            this.DataGridViewXoaNV.RowHeadersWidth = 82;
            this.DataGridViewXoaNV.RowTemplate.Height = 33;
            this.DataGridViewXoaNV.Size = new System.Drawing.Size(1728, 343);
            this.DataGridViewXoaNV.TabIndex = 3;
            this.DataGridViewXoaNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewXoaNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewXoaNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewXoaNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewXoaNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewXoaNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewXoaNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewXoaNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewXoaNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewXoaNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewXoaNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewXoaNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewXoaNV.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewXoaNV.ThemeStyle.ReadOnly = false;
            this.DataGridViewXoaNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewXoaNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewXoaNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewXoaNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewXoaNV.ThemeStyle.RowsStyle.Height = 33;
            this.DataGridViewXoaNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewXoaNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 18;
            this.btnXoa.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnXoa.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnXoa.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(1462, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(253, 86);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtIDdlt
            // 
            this.txtIDdlt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDdlt.DefaultText = "";
            this.txtIDdlt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDdlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDdlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDdlt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDdlt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDdlt.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtIDdlt.ForeColor = System.Drawing.Color.Black;
            this.txtIDdlt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDdlt.Location = new System.Drawing.Point(1190, 50);
            this.txtIDdlt.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtIDdlt.Name = "txtIDdlt";
            this.txtIDdlt.PlaceholderText = "Enter ID";
            this.txtIDdlt.SelectedText = "";
            this.txtIDdlt.Size = new System.Drawing.Size(525, 96);
            this.txtIDdlt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtIDdlt.TabIndex = 1;
            // 
            // lblIDNVdlt
            // 
            this.lblIDNVdlt.AutoSize = true;
            this.lblIDNVdlt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNVdlt.ForeColor = System.Drawing.Color.Black;
            this.lblIDNVdlt.Location = new System.Drawing.Point(1183, 3);
            this.lblIDNVdlt.Name = "lblIDNVdlt";
            this.lblIDNVdlt.Size = new System.Drawing.Size(49, 39);
            this.lblIDNVdlt.TabIndex = 0;
            this.lblIDNVdlt.Text = "ID";
            this.lblIDNVdlt.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_EmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlEmployee);
            this.Controls.Add(this.lblNhanvien);
            this.Name = "UC_EmployeeManager";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_EmployeeManager_Load);
            this.Leave += new System.EventHandler(this.UC_EmployeeManager_Leave);
            this.tabctrlEmployee.ResumeLayout(false);
            this.tabpageDKNV.ResumeLayout(false);
            this.tabpageDKNV.PerformLayout();
            this.tabpageTTNV.ResumeLayout(false);
            this.tabpageTTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTTNV)).EndInit();
            this.tabpageXoaNV.ResumeLayout(false);
            this.tabpageXoaNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewXoaNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhanvien;
        private System.Windows.Forms.TabControl tabctrlEmployee;
        private System.Windows.Forms.TabPage tabpageDKNV;
        private System.Windows.Forms.TabPage tabpageTTNV;
        private System.Windows.Forms.TabPage tabpageXoaNV;
        private System.Windows.Forms.Label lblIDNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblToset;
        private System.Windows.Forms.Label lblEmailNV;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailNV;
        private System.Windows.Forms.Label lblDiachiNV;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachiNV;
        private System.Windows.Forms.Label lblSdtNV;
        private Guna.UI2.WinForms.Guna2TextBox txtSdtNV;
        private System.Windows.Forms.Label lblPassNV;
        private Guna.UI2.WinForms.Guna2TextBox txtPassNV;
        private System.Windows.Forms.Label lblUsernameNV;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameNV;
        private Guna.UI2.WinForms.Guna2Button btnDangky;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblTTNV;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewTTNV;
        private System.Windows.Forms.Label lblIDNVdlt;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewXoaNV;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2TextBox txtIDdlt;
    }
}
