using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.All_User_Control
{
    public partial class UC_Report : UserControl
    {
        function fn = new function();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public UC_Report()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.;Initial Catalog=boutique4;Integrated Security=True");
        }

        private void UC_Report_Load(object sender, EventArgs e)
        {
            // Load dữ liệu mặc định cho tab Tình trạng sản phẩm khi UserControl được load
            //LoadTinhTrangSanPham();

            // Đặt giá trị mặc định cho Guna2DateTimePicker trong tab Thống kê doanh thu
            dtpkStartDoanhthu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpkEndDoanhthu.Value = DateTime.Now;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpkStartDoanhthu.Value.Date;
            DateTime endDate =dtpkEndDoanhthu.Value.Date.AddDays(1).AddSeconds(-1);

            try
            {
                con.Open();
                cmd = new SqlCommand(@"SELECT dt.maDonThue, kh.tenKhachHang, dt.ngayNhan, dt.ngayTraThucTe, dt.tongTien
                                       FROM donThue dt
                                       INNER JOIN khachHang kh ON dt.maKhachHang = kh.maKhachHang
                                       WHERE dt.trangThai = N'Hoàn thành'
                                         AND dt.ngayTraThucTe >= @startDate AND dt.ngayTraThucTe <= @endDate", con);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                DataGridViewDoanhthu.DataSource = dt;

                decimal tongDoanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["tongTien"] != DBNull.Value && decimal.TryParse(row["tongTien"].ToString(), out decimal tien))
                    {
                        tongDoanhThu += tien;
                    }
                }

                lblTongDoanhthu.Text = string.Format("Tổng doanh thu: {0:N0} VNĐ", tongDoanhThu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê doanh thu: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void tabctrlBaocao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
