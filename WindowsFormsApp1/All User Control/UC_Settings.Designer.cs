namespace WindowsFormsApp1.All_User_Control
{
    partial class UC_Settings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpageCauhinh = new System.Windows.Forms.TabPage();
            this.tabpageTaikhoan = new System.Windows.Forms.TabPage();
            this.lblCaidat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabpageCauhinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpageCauhinh);
            this.tabControl1.Controls.Add(this.tabpageTaikhoan);
            this.tabControl1.Location = new System.Drawing.Point(23, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1814, 731);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpageCauhinh
            // 
            this.tabpageCauhinh.Controls.Add(this.label3);
            this.tabpageCauhinh.Controls.Add(this.label2);
            this.tabpageCauhinh.Controls.Add(this.label1);
            this.tabpageCauhinh.Location = new System.Drawing.Point(8, 39);
            this.tabpageCauhinh.Name = "tabpageCauhinh";
            this.tabpageCauhinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCauhinh.Size = new System.Drawing.Size(1798, 684);
            this.tabpageCauhinh.TabIndex = 0;
            this.tabpageCauhinh.Text = "Cấu hình";
            this.tabpageCauhinh.UseVisualStyleBackColor = true;
            // 
            // tabpageTaikhoan
            // 
            this.tabpageTaikhoan.Location = new System.Drawing.Point(8, 39);
            this.tabpageTaikhoan.Name = "tabpageTaikhoan";
            this.tabpageTaikhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageTaikhoan.Size = new System.Drawing.Size(1798, 684);
            this.tabpageTaikhoan.TabIndex = 1;
            this.tabpageTaikhoan.Text = "Tài khoản";
            this.tabpageTaikhoan.UseVisualStyleBackColor = true;
            // 
            // lblCaidat
            // 
            this.lblCaidat.BackColor = System.Drawing.Color.Transparent;
            this.lblCaidat.Font = new System.Drawing.Font("Meiryo UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaidat.Location = new System.Drawing.Point(31, 27);
            this.lblCaidat.Name = "lblCaidat";
            this.lblCaidat.Size = new System.Drawing.Size(161, 57);
            this.lblCaidat.TabIndex = 1;
            this.lblCaidat.Text = "Cài đặt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chế độ sáng/tối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngôn ngữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kiểu chữ";
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCaidat);
            this.Controls.Add(this.tabControl1);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(1882, 852);
            this.tabControl1.ResumeLayout(false);
            this.tabpageCauhinh.ResumeLayout(false);
            this.tabpageCauhinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpageCauhinh;
        private System.Windows.Forms.TabPage tabpageTaikhoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCaidat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
