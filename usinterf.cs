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
    public partial class usinterf : Form
    {
        public usinterf()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private string uname;
        public usinterf(string uname1) : this()
        {
            uname = uname1;
            lbuname.Text = uname;
        }

        private void datatodgv()
        {
            string sql = "select Book.BookID,Book.BookName, b.TopicName, a.AuthorName,Book.Descriptions " +
                "from Book, (select BookAuthor.BookID, Author.AuthorName from BookAuthor, Author where BookAuthor.AuthorID = Author.AuthorID) as a " +
                ",(select BookTopic.BookID, Topic.TopicName from BookTopic,Topic where BookTopic.TopicID = Topic.TopicID) as b " +
                "where Book.BookID = a.BookID and Book.BookID = b.BookID order by BookID";
            SqlCommand cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvbookinf.DataSource = dt;
        }

        private void usinterf_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select UserID from Users where UserName = '" + lbuname.Text + "'", conn);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            lbuid.Text = myTable.Rows[0]["UserID"].ToString();

            datatodgv();
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            studentlogin studentlogin = new studentlogin();
            studentlogin.Show();
        }

        private void dgvbookinf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvbookinf.Rows[e.RowIndex];
                bookinfor bookinfor = new bookinfor(row.Cells[0].Value.ToString(), lbuid.Text);
                bookinfor.Show();
            }

        }

        private void userid_Click(object sender, EventArgs e)
        {

        }

        private void lblogin_Click(object sender, EventArgs e)
        {

        }

        private void btnmoreinf_Click_1(object sender, EventArgs e)
        {

            userinfor userinfor = new userinfor(lbuname.Text);
            userinfor.Show();
        }

        private void btncurrtag_Click_1(object sender, EventArgs e)
        {
            currenttag currenttag = new currenttag(lbuid.Text);
            currenttag.Show();
        }

        private void txtbname_TextChanged(object sender, EventArgs e)
        {
            string rowf = string.Format("{0} like '{1}'", "BookName", "*" + txtbname.Text + "*");
            (dgvbookinf.DataSource as DataTable).DefaultView.RowFilter = rowf;
        }

        private void txtauthor_TextChanged(object sender, EventArgs e)
        {
            string rowf = string.Format("{0} like '{1}'", "AuthorName", "*" + txtauthor.Text + "*");
            (dgvbookinf.DataSource as DataTable).DefaultView.RowFilter = rowf;
        }

        private void txttopic_TextChanged(object sender, EventArgs e)
        {
            string rowf = string.Format("{0} like '{1}'", "TopicName", "*" + txttopic.Text + "*");
            (dgvbookinf.DataSource as DataTable).DefaultView.RowFilter = rowf;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvbookinf.DataSource = null;
            dgvbookinf.Refresh();
            datatodgv();
        }
    }
}