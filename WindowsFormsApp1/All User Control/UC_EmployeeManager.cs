using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.All_User_Control
{
    public partial class UC_EmployeeManager : UserControl
    {
        function fn = new function();
        String query;

        public UC_EmployeeManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_EmployeeManager_Load(object sender, EventArgs e)
        {
            getMaxID();
        }

        //---------
        public void getMaxID()
        {
            query = "select max(staffID) from staff";
            DataSet ds = fn.getData(query);

            //if (ds.Tables[0].Rows[0][0].ToString() != "")
            //{
            //    Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            //    lblToset.Text = (num + 1).ToString();
            //}

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                string maxStaffID = ds.Tables[0].Rows[0][0].ToString();

                // Kiểm tra xem staffID có đúng định dạng không (bắt đầu bằng "ST" và có số theo sau)
                if (maxStaffID.StartsWith("ST") && int.TryParse(maxStaffID.Substring(2), out int lastNumber))
                {
                    int nextNumber = lastNumber + 1;
                    lblToset.Text = $"ST{nextNumber:000}"; // Định dạng số với đủ số 0 (ví dụ: 001)
                }
                else
                {
                    // Trường hợp ID không đúng định dạng, bạn có thể đặt một giá trị mặc định
                    lblToset.Text = "ST001";
                    MessageBox.Show("Định dạng staffID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Bảng staff trống
                lblToset.Text = "ST001";
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" && txtEmailNV.Text != "" && txtSdtNV.Text != "" && txtDiachiNV.Text != "" && txtUsernameNV.Text != "" && txtPassNV.Text != "")
            {
                String hoTen = txtTenNV.Text;
                String email = txtEmailNV.Text;
                String soDienThoai = txtSdtNV.Text;
                String diaChi = txtDiachiNV.Text;
                String staffName = txtUsernameNV.Text;
                String staffPassword = txtPassNV.Text;
                String staffID = lblToset.Text; // Lấy staffID đã tạo ở hàm getMaxID()

                try
                {
                    // Thêm dữ liệu vào bảng staff
                    query = "insert into staff (staffID, staffName, staffPassword, staffEmail) values ('" + staffID + "', N'" + staffName + "', '" + staffPassword + "', '" + email + "')";
                    fn.setData(query, "Đã thêm thông tin đăng nhập nhân viên.");

                    // Thêm dữ liệu vào bảng staffChiTiet
                    query = "insert into staffChiTiet (maStaffChiTiet, staffID, hoTen, soDienThoai, email, diaChi) values ('" + staffID + "', '" + staffID + "', N'" + hoTen + "', '" + soDienThoai + "', '" + email + "', N'" + diaChi + "')";
                    fn.setData(query, "Đã thêm thông tin chi tiết nhân viên.");

                    MessageBox.Show("Đăng ký nhân viên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi đăng ký thành công, bạn có thể muốn làm mới form hoặc clear các textbox
                    getMaxID(); // Tạo ID mới cho nhân viên tiếp theo
                    clearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Hàm để clear các textbox sau khi đăng ký thành công
        public void clearAll()
        {
            txtTenNV.Clear();
            txtEmailNV.Clear();
            txtSdtNV.Clear();
            txtDiachiNV.Clear();
            txtUsernameNV.Clear();
            txtPassNV.Clear();
        }

        private void tabctrlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabctrlEmployee.SelectedIndex ==  1)
            {
                setEmployee(DataGridViewTTNV);  
            }
            else if (tabctrlEmployee.SelectedIndex == 2)
            {
                setEmployee(DataGridViewXoaNV);
            }
        }

        public void setEmployee(DataGridView dgv)
        {
            //query = "select * from staff";
            query = "SELECT s.staffID, s.staffName, s.staffEmail, sc.hoTen, sc.soDienThoai, sc.email AS chiTietEmail, sc.diaChi " +
           "FROM staff s " +
           "INNER JOIN staffChiTiet sc ON s.staffID = sc.staffID"; // Sử dụng INNER JOIN để lấy các bản ghi có liên quan ở cả hai bảng
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtIDdlt.Text != "")
            {
                if(MessageBox.Show("Bạn có chắc chắn xóa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    String staffIDToDelete = txtIDdlt.Text;
                    try
                    {
                        // Xóa dữ liệu từ bảng staffChiTiet trước (để tránh lỗi khóa ngoại)
                        query = "delete from staffChiTiet where staffID = '" + staffIDToDelete + "'";
                        fn.setData(query, "Đã xóa thông tin chi tiết nhân viên có ID: " + staffIDToDelete);

                        // Sau đó xóa dữ liệu từ bảng staff
                        query = "delete from staff where staffID = '" + staffIDToDelete + "'";
                        fn.setData(query, "Đã xóa thông tin đăng nhập nhân viên có ID: " + staffIDToDelete);

                        MessageBox.Show("Đã xóa nhân viên có ID: " + staffIDToDelete + " thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtIDdlt.Clear(); // Xóa ID sau khi xóa thành công
                                          // Nếu bạn muốn cập nhật DataGridView sau khi xóa, bạn có thể gọi lại hàm hiển thị dữ liệu
                                          // Ví dụ: setEmployee(yourDataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_EmployeeManager_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
