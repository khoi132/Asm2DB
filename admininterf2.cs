using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Asm2DB
{
    public partial class admininterf2 : Form
    {

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        public admininterf2()
        {
            InitializeComponent();
        }

        public string adname2;
        public admininterf2(string adname1) : this()
        {
            adname2 = adname1;
        }

        private void datausertodgv()
        {
            string sql = "select * from Users";
            SqlCommand cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvuserinf.DataSource = dt;
        }

        private void admininterf2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();

            datausertodgv();

            if (adname2 == "admin")
            {
                btnstaffacc.Show();
            }

            SqlDataAdapter myAdapter = new SqlDataAdapter("select COUNT(*) as UserID from Users", conn);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            label5.Text = myTable.Rows[0]["UserID"].ToString();

        }

        private void btnaddacc_Click(object sender, EventArgs e)
        {
            addaccount addaccount = new addaccount();
            addaccount.Show();
        }

        private void btnmngbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            admininterf admininterf = new admininterf();
            admininterf.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            studentlogin studentlogin = new studentlogin();
            studentlogin.Show();
        }

        private void dgvuserinf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvuserinf.Rows[e.RowIndex];
                editdeleteacc editdeleteacc = new editdeleteacc(row.Cells[0].Value.ToString());
                editdeleteacc.Show();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvuserinf.DataSource = null;
            dgvuserinf.Refresh();
            datausertodgv();
        }

        private void txtuid_TextChanged(object sender, EventArgs e)
        {
            string rowf = string.Format("{0} like '{1}'", "UserID", "*" + txtuid.Text + "*");
            (dgvuserinf.DataSource as DataTable).DefaultView.RowFilter = rowf;
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {
            string rowf = string.Format("{0} like '{1}'", "UserName", "*" + txtuname.Text + "*");
            (dgvuserinf.DataSource as DataTable).DefaultView.RowFilter = rowf;
        }

        private void txtuphone_TextChanged(object sender, EventArgs e)
        {
            string rowf = string.Format("{0} like '{1}'", "UserPhone", "*" + txtuphone.Text + "*");
            (dgvuserinf.DataSource as DataTable).DefaultView.RowFilter = rowf;
        }

        private void btnstaffacc_Click(object sender, EventArgs e)
        {
            managestaffacc managestaffacc = new managestaffacc();
            managestaffacc.Show();
        }
    }
}