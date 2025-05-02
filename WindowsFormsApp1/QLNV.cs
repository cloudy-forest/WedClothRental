using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnQLSP.Left + 50;
            uC_AddProduct1.Visible = true;
            uC_AddProduct1.BringToFront();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            uC_AddProduct1.Visible = false;
            uC_Report1.Visible = false; // Đảm bảo UC_Report cũng ẩn khi form tải
            uC_EmployeeManager1.Visible = false;
            btnQLSP.PerformClick(); // Hiển thị UC_AddProduct ban đầu
        }

        private void btnBCDT_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnQLSP.Left + 275;

            // Ẩn UC_AddProduct nếu nó đang hiển thị
            uC_AddProduct1.Visible = false;
            uC_AddProduct1.SendToBack(); // Đưa UC_AddProduct ra phía sau các control khác

            // Hiển thị UC_Report
            uC_Report1.Visible = true;
            uC_Report1.BringToFront(); // Đưa UC_Report lên phía trước
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnQLSP.Left + 520;
            uC_EmployeeManager1.Visible = true;
            uC_EmployeeManager1.BringToFront();
        }

        private void btnCaidat_Click(object sender, EventArgs e)
        {

        }
    }
}
