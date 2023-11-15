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
    public partial class guestinterf : Form
    {
        public guestinterf()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void datatodgv()
        {
            string sql = "select Book.BookID,Book.BookName, b.TopicName, a.AuthorName,Book.Descriptions " +
                "from Book, (select BookAuthor.BookID, Author.AuthorName from BookAuthor, Author where BookAuthor.AuthorID = Author.AuthorID) as a " +
                ",(select BookTopic.BookID, Topic.TopicName from BookTopic,Topic where BookTopic.TopicID = Topic.TopicID) as b " +
                "where Book.BookID = a.BookID and Book.BookID = b.BookID";
            SqlCommand cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvbookinf.DataSource = dt;
        }

        private void lblogin_Click(object sender, EventArgs e)
        {
            

            // Hiển thị lại trang studentlogin
            studentlogin loginForm = new studentlogin();
            loginForm.Show();
        }

        private void lbregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            register1 register1 = new register1();
            register1.Show();
        }

        private void dgvbookinf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvbookinf.Rows[e.RowIndex];
                    editdeletebook editdeletebook = new editdeletebook(row.Cells[0].Value.ToString());
                    editdeletebook.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnlogout_Click(object sender, EventArgs e)
        {

            conn.Close();
            this.Hide();
            studentlogin studentlogin = new studentlogin();
            studentlogin.Show();
        }

        private void guestinterf_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();

            datatodgv();
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
    }
}
