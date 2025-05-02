using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1.All_User_Control
{
    public partial class UC_AddProduct : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddProduct()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void UC_AddProduct_Load(object sender, EventArgs e)
        {
            loadProductData(); // Tải dữ liệu sản phẩm vào DataGridView
        }

        private void loadProductData()
        {
            query = "select * from sanPham";
            DataSet ds = fn.getData(query);
            DataGridViewTSP.DataSource = ds.Tables[0];
        }

        public string getMaxProductID()
        {
            query = "SELECT MAX(maSanPham) FROM sanPham";
            DataSet ds = fn.getData(query);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                string maxProductID = ds.Tables[0].Rows[0][0].ToString();

                if (maxProductID.StartsWith("SP") && int.TryParse(maxProductID.Substring(2), out int lastNumber))
                {
                    int nextNumber = lastNumber + 1;
                    return $"SP{nextNumber:000}"; // Trả về mã sản phẩm mới
                }
                else
                {
                    MessageBox.Show("Định dạng maSanPham không hợp lệ trong database.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "SP001"; // Trả về mã mặc định nếu có lỗi định dạng
                }
            }
            else
            {
                return "SP001"; // Trả về mã mặc định nếu không có sản phẩm nào
            }
        }

        private void btnThemsp_Click(object sender, EventArgs e)
        {
            if (txtLoaisp.Text != "" && txtTensp.Text != "" && txtSoluong.Text != "" && txtTrangthai.Text != "" && txtGiasp.Text != "")
            {
                string maSP = getMaxProductID(); // Lấy mã sản phẩm tự động
                string tenloaisp = txtLoaisp.Text;
                DataSet dsMaLoai = fn.getData("select maLoaiSP FROM loaiSanPham WHERE tenLoaiSP = N'" + tenloaisp + "'");

                if (dsMaLoai.Tables[0].Rows.Count > 0)
                {
                    string maLoai = dsMaLoai.Tables[0].Rows[0]["maLoaiSP"].ToString();
                    String tensp = txtTensp.Text;
                    String soluong = txtSoluong.Text;
                    String trangthai = txtTrangthai.Text;
                    Int64 gia = Int64.Parse(txtGiasp.Text);

                    query = "insert into sanPham (maSanPham, tenSanPham, giaThue, trangThai, soLuong, maLoaiSP) " +
                            "values ('" + maSP + "', N'" + tensp.Replace("'", "''") + "', " +
                            gia + ", N'" + trangthai.Replace("'", "''") + "', " +
                            soluong + ", '" + maLoai + "')";
                    fn.setData(query, "Đã thêm sản phẩm có mã: " + maSP);

                    loadProductData(); // Tải lại danh sách sản phẩm
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm với tên: " + tenloaisp);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        public void clearAll()
        {
            txtSoluong.Clear();
            txtLoaisp.SelectedIndex = -1;
            txtTrangthai.SelectedIndex = -1;
            txtGiasp.Clear();
            txtTensp.Clear();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void UC_AddProduct_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddProduct_Enter(object sender, EventArgs e)
        {
            UC_AddProduct_Load(this, null);
        }

        private void btnXoasp_Click(object sender, EventArgs e)
        {
            if (DataGridViewTSP.SelectedRows.Count > 0)
            {
                int selectedIndex = DataGridViewTSP.SelectedRows[0].Index;
                string maSanPhamToDelete = DataGridViewTSP.Rows[selectedIndex].Cells[0].Value.ToString();

                if (!int.TryParse(DataGridViewTSP.Rows[selectedIndex].Cells[4].Value.ToString(), out int soLuongHienCo))
                {
                    MessageBox.Show("Số lượng hiện có không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string soLuongXoaString = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng cần xóa:", "Xóa sản phẩm", "1");

                if (int.TryParse(soLuongXoaString, out int soLuongXoa) && soLuongXoa > 0 && soLuongXoa <= soLuongHienCo)
                {
                    int soLuongConLai = soLuongHienCo - soLuongXoa;
                    query = "update sanPham set soLuong = " + soLuongConLai + " where maSanPham = '" + maSanPhamToDelete + "'";
                    fn.setData(query, "Đã xóa " + soLuongXoa + " sản phẩm có mã: " + maSanPhamToDelete);

                    if (soLuongConLai == 0)
                    {
                        if (MessageBox.Show("Số lượng sản phẩm này đã về 0. Bạn có muốn xóa hẳn sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            query = "delete from sanPham where maSanPham = '" + maSanPhamToDelete + "'";
                            fn.setData(query, "Đã xóa sản phẩm có mã: " + maSanPhamToDelete);
                        }
                    }

                    loadProductData(); // Tải lại danh sách sản phẩm
                }
                else if (!string.IsNullOrEmpty(soLuongXoaString))
                {
                    MessageBox.Show("Số lượng xóa không hợp lệ. Vui lòng nhập số lớn hơn 0 và không lớn hơn số lượng hiện có.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}