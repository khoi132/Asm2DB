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
    public partial class admininterf : Form
    {
        public admininterf()
        {
         
            InitializeComponent();
        }

        public string adname;
        public admininterf(string adname1) : this()
        {
            adname = adname1;
        }

        //SQL variable declaration
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        //create function to transfer data from SQL Server to DataGridView
        private void datatodgv()
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();
            //declare SQL command
            string sql = "SELECT    Book.BookID,  Book.BookName,  Topic.TopicName,   Author.AuthorName,   Book.Descriptions FROM   Book JOIN    BookAuthor ON Book.BookID = BookAuthor.BookID JOIN    Author ON BookAuthor.AuthorID = Author.AuthorID JOIN    BookTopic ON Book.BookID = BookTopic.BookID JOIN    Topic ON BookTopic.TopicID = Topic.TopicID;";
            cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            //get the selected data to fill in the table
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //transfer data from created table to DataGridView
            dgvbookinf.DataSource = dt;
            //conn.Close();
        }

        private void admininterf_Load(object sender, EventArgs e)
        {
            //Connect to SQL Server 
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();
            //execute the created function
            datatodgv();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select COUNT(*) as BookID from Book", conn);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            label5.Text = myTable.Rows[0]["BookID"].ToString();

            SqlDataAdapter myAdapter1 = new SqlDataAdapter("select COUNT(*) as TopicID from Topic", conn);
            DataTable myTable1 = new DataTable();
            myAdapter1.Fill(myTable1);
            label6.Text = myTable1.Rows[0]["TopicID"].ToString();

            SqlDataAdapter myAdapter2 = new SqlDataAdapter("select COUNT(*) as AuthorID from Author", conn);
            DataTable myTable2 = new DataTable();
            myAdapter2.Fill(myTable2);
            label8.Text = myTable2.Rows[0]["AuthorID"].ToString();
        }

        private void btnaddb_Click(object sender, EventArgs e)
        {
            //declare and show Addbook form
            addbook addbook = new addbook();
            addbook.Show();
        }

        private void btntaginu_Click(object sender, EventArgs e)
        {
            //declare and show Tag in use form
            taginuse taginuse = new taginuse();
            taginuse.Show();
        }

        private void btntagdated_Click(object sender, EventArgs e)
        {
            //declare and show Tag dated form
            tagdated tagdated = new tagdated();
            tagdated.Show();
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

        private void btnmngacc_Click(object sender, EventArgs e)
        {
            this.Hide();
            //declare and show Admin Interface 2 form
            admininterf2 admininterf2 = new admininterf2(adname);
            admininterf2.Show();
        }

        public void btnrefresh_Click(object sender, EventArgs e)
        {
            //Empty the DataGridView 
            dgvbookinf.DataSource = null;
            dgvbookinf.Refresh();
            //call the function to transfer data from SQL Server to DataGridView
            datatodgv();
        }

        private void txtbname_TextChanged(object sender, EventArgs e)
        {
            //Declare a variable to compare input data with DataGridView's data
            string rowf = string.Format("{0} like '{1}'", "BookName", "*" + txtbname.Text + "*");
            //show search results
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

        private void btncurtag_Click(object sender, EventArgs e)
        {
            //declare and show the Admin current tag form 
            admincurtag admincurtag = new admincurtag();
            admincurtag.Show();
        }
        
    }
}