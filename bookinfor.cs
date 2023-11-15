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
    public partial class bookinfor : Form
    {
        public bookinfor()
        {
            InitializeComponent();
            listaddedbook = new List<int>();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        List<int> listaddedbook;

        private string bid;
        private string uid;
        public bookinfor(string bid1, string uid1) : this()
        {

            bid = bid1;
            uid = uid1;
            lbbid.Text = bid;
        }

        private void bookinfor_Load(object sender, EventArgs e)
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

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            try
            {
                conn.Close();
                cmdd = new SqlCommand();
                conn.Open();
                
                cmdd.Connection = conn;
                cmdd.CommandText = "select * from Book where Descriptions like '%Borrowed%' and BookID = '"+ lbbid.Text +"'";

                rdr = cmdd.ExecuteReader();
                if (rdr.HasRows)
                {
                    if (rdr.Read())
                    {
                        MessageBox.Show("This book has been borrowed");
                        this.Close();
                    }

                }
                else
                {
                    conn.Close();
                    cmdd = new SqlCommand();
                    conn.Open();

                    cmdd.Connection = conn;
                    cmdd.CommandText = "select * from Currenttag where UserID ='" + uid + "' and BookID = '" + lbbid.Text + "'";

                    rdr = cmdd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        MessageBox.Show("This book is already on your tag");
                        this.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();

                        cmdd = new SqlCommand();
                        cmdd.Connection = conn;

                        cmdd.CommandText = "select * from " +
                            "(select COUNT(BookID) as CBookID from Currenttag where UserID = '" + uid + "') as a " +
                            "where a.CBookID > 2";

                        rdr = cmdd.ExecuteReader();

                        if (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                MessageBox.Show("You can only apply to borrow 3 books at the same time");
                            }
                        }
                        else
                        {
                            conn.Close();
                            conn.Open();

                            cmdd = new SqlCommand();
                            cmdd.Connection = conn;

                            cmdd.CommandText = "select * from (select COUNT(BookID) as CBookID from USTGBK where UserID = '"+uid+"') as a where a.CBookID > 2";

                            rdr = cmdd.ExecuteReader();
                            if (rdr.HasRows)
                            {
                                if (rdr.Read())
                                {
                                    MessageBox.Show("You are borrowing 3 books. Please return books before borrowing more.");
                                }
                            }
                            else
                            {
                                conn.Close();
                                conn.Open();
                                cmdd = new SqlCommand();
                                cmdd.Connection = conn;

                                cmdd.CommandText = "insert into Currenttag values ('" + uid + "','" + lbbid.Text + "','')";
                                cmdd.ExecuteReader();

                                MessageBox.Show("This book has been added to the Current Tags");
                            }
                        }
                        this.Hide();
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lbbname_Click(object sender, EventArgs e)
        {

        }
    }
}
