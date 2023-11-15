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
    public partial class editdeletebook : Form
    {
        public editdeletebook()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void editdeletebook_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from" +
                " (select Book.BookID,Book.BookName, b.TopicName, a.AuthorName,Book.Descriptions " +
                "from Book, (select BookAuthor.BookID, Author.AuthorName from BookAuthor, Author where BookAuthor.AuthorID = Author.AuthorID) as a " +
                ",(select BookTopic.BookID, Topic.TopicName from BookTopic, Topic where BookTopic.TopicID = Topic.TopicID) as b " +
                "where Book.BookID = a.BookID and Book.BookID = b.BookID) as c " +
                "where c.BookID = '" + lbbid.Text + "'", conn);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            lbbname.Text = myTable.Rows[0]["BookName"].ToString();
            lbbauthor.Text = myTable.Rows[0]["AuthorName"].ToString();
            lbbtopic.Text = myTable.Rows[0]["TopicName"].ToString();
            lbbdes.Text = myTable.Rows[0]["Descriptions"].ToString();
        }

        private string bid;
        public editdeletebook(string bid1) : this()
        {
            bid= bid1;
            lbbid.Text = bid;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtbname.Show();
            txtbtopicid.Show();
            txtbauthorid.Show();
            btncal.Show();
            btnok.Show();

            txtbname.Text = lbbname.Text;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this book?", "Deletebook",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmdd = conn.CreateCommand();
                    //delete all information related to the book
                    cmdd.CommandText = "delete from BookTopic where BookID = @bid and TopicID = (select Topic.TopicID from Topic where TopicName = @btname)";
                    cmdd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = lbbid.Text;
                    cmdd.Parameters.Add("@btname", SqlDbType.NChar, 20).Value = lbbtopic.Text;
                    cmdd.ExecuteNonQuery();
                    cmdd = conn.CreateCommand();
                    //delete book information
                    cmdd.CommandText = "delete from BookAuthor where BookID = @bid and AuthorID = (select Author.AuthorID from Author where AuthorName = @baname)";
                    cmdd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = lbbid.Text;
                    cmdd.Parameters.Add("@baname", SqlDbType.NChar, 20).Value = lbbauthor.Text;
                    cmdd.ExecuteNonQuery();
                    cmdd = conn.CreateCommand();
                    cmdd.CommandText = "delete from Book where BookID = @bid";
                    cmdd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = lbbid.Text;
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Delete successful", "Delete");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something is error. Maybe this BookID is existing in another table.");
                }


            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            admininterf admininterf = new admininterf();
            admininterf.Show();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            txtbname.Hide();
            txtbtopicid.Hide();
            txtbauthorid.Hide();
            btncal.Hide();
            btnok.Hide();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbname.Text) ||
                string.IsNullOrWhiteSpace(txtbtopicid.Text) ||
                string.IsNullOrWhiteSpace(txtbauthorid.Text))
            {
                //if the librarian has not entered the data
                MessageBox.Show("Please enter information!");
            }
            else if (MessageBox.Show("Do you want to change the information", "ChangeBook",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmdd = new SqlCommand();
                    cmdd.Connection = conn;
                    cmdd.CommandText = "select * from Book where BookID= '" + lbbid.Text + "'";
                    rdr = cmdd.ExecuteReader();
                    if (rdr.Read())
                    {
                        conn.Close();
                        conn.Open();
                        //create code to put the value to update
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "Update Book set BookName = @bname where BookID=@bid";
                        cmd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = lbbid.Text;
                        cmd.Parameters.Add("@bname", SqlDbType.NChar, 40).Value = txtbname.Text;
                        cmd.ExecuteNonQuery();
                        //Update information in other tables
                        SqlCommand cmdt = conn.CreateCommand();
                        cmdt.CommandText = "Update BookTopic set TopicID = @tid where BookID=@bid";
                        cmdt.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = lbbid.Text;
                        cmdt.Parameters.Add("@tid", SqlDbType.NChar, 7).Value = txtbtopicid.Text;
                        cmdt.ExecuteNonQuery();
                        SqlCommand cmda = conn.CreateCommand();
                        cmda.CommandText = "Update BookAuthor set AuthorID = @aid where BookID=@bid";
                        cmda.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = lbbid.Text;
                        cmda.Parameters.Add("@aid", SqlDbType.NChar, 7).Value = txtbauthorid.Text;
                        cmda.ExecuteNonQuery();
                        MessageBox.Show("Successful!", "Update");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                catch
                {
                    //if the librarian enters the wrong syntax
                    MessageBox.Show("Syntax Error. TopicID: TPxxxxx, AuthorID: ATxxxxx");
                }
                conn.Close();
                conn.Open();
            }
            else
            {
                txtbname.Hide();
                txtbtopicid.Hide();
                txtbauthorid.Hide();
                btncal.Hide();
                btnok.Hide();
            }

            
        }

        private void lbbdes_Click(object sender, EventArgs e)
        {
            
        }

        private void btncaldes_Click(object sender, EventArgs e)
        {
            txtbdes.Hide();
            btnokdes.Hide();
            btncaldes.Hide();
        }

        private void btnokdes_Click(object sender, EventArgs e)
        {
            try
            {

                cmdd = new SqlCommand();
                cmdd.Connection = conn;
                cmdd.CommandText = "select * from Book where BookID= '" + lbbid.Text + "'";

                rdr = cmdd.ExecuteReader();

                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Update Book set Descriptions = @des where BookID=@bid";

                    cmd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = lbbid.Text;
                    cmd.Parameters.Add("@des", SqlDbType.NChar, 100).Value = txtbdes.Text;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successful!", "Update");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("Something is Error");
            }


            conn.Close();
            conn.Open();

            txtbdes.Hide();
            btnokdes.Hide();
            btncaldes.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtbdes.Show();
            btnokdes.Show();
            btncaldes.Show();

            txtbdes.Text = lbbdes.Text;
        }

        private void txtbname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
