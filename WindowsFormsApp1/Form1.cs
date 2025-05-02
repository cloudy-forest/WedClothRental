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
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select adminName, adminPassword from admin where adminName = '" + txtUsername.Text + "' and adminPassword = '" + txtPassword.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                QLNV q = new QLNV();
                this.Hide();
                q.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
