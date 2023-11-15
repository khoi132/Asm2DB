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
using System.Net;
using System.Reflection;
using System.Security.Cryptography;


namespace Asm2DB
{
    public partial class userinfor : Form
    {
        public userinfor()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private string uname;
        public userinfor(string uname1) : this()
        {
            uname = uname1;
            lbuname.Text = uname;
        }

        //private void brtagtodgv()
        //{


        //    //string sql = "select USTGBK.TagID, Tag.BorrowedDate, Tag.ReturnDate, Book.BookName " +
        //    //    "from USTGBK, Book, Tag, (select distinct USTGBK.TagID from USTGBK where USTGBK.UserID = 'US00001') as a " +
        //    //    "where Tag.TagID = a.TagID " +
        //    //    "and Book.BookID = USTGBK.BookID " +
        //    //    "and USTGBK.TagID = Tag.TagID";
        //    string sql = "SELECT USTGBK.TagID, Tag.BorrowedDate, Tag.ReturnDate, USTGBK.BookID " +
        //       "FROM USTGBK " +
        //       "JOIN Tag ON USTGBK.TagID = Tag.TagID " +
        //       "WHERE USTGBK.TagID IN (SELECT DISTINCT USTGBK.TagID FROM USTGBK WHERE USTGBK.UserID = 'US00001')";

        //    SqlCommand cmdd = new SqlCommand(sql, conn);
        //    cmdd.CommandType = CommandType.Text;
        //    SqlDataAdapter da = new SqlDataAdapter(cmdd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvtaginfor.DataSource = dt;
        //}

        //private void DisplayBorrowedBooksForUser(string userId)
        //{

        //    string sql = "SELECT USTGBK.TagID, Tag.BorrowedDate, Tag.ReturnDate, USTGBK.BookID " +
        //                 "FROM USTGBK " +
        //                 "JOIN Tag ON USTGBK.TagID = Tag.TagID " +
        //                 "WHERE USTGBK.UserID = @UserID";

        //    using (SqlCommand command = new SqlCommand(sql, conn))
        //    {
        //        command.CommandType = CommandType.Text;
        //        command.Parameters.AddWithValue("@UserID", userId);

        //        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //        {
        //            DataTable dataTable = new DataTable();
        //            adapter.Fill(dataTable);

        //            if (dataTable.Rows.Count > 0)
        //            {
        //                dgvtaginfor.DataSource = dataTable;
        //            }
        //            else
        //            {
        //                Console.WriteLine("No data found for the given UserID.");
        //            }

        //        }
        //    }
        //}
        private void DisplayBorrowedBooksForUser(string userId)
        {
            string sql = "SELECT USTGBK.TagID, Tag.BorrowedDate, Tag.ReturnDate, USTGBK.BookID " +
                         "FROM USTGBK " +
                         "JOIN Tag ON USTGBK.TagID = Tag.TagID " +
                         "WHERE USTGBK.UserID = @UserID";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@UserID", userId);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Add a DataColumn for BookName
                        dataTable.Columns.Add("BookName", typeof(string));

                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Retrieve BookName based on BookID
                            string bookId = row["BookID"].ToString();
                            string bookName = GetBookNameById(bookId);
                            row["BookName"] = bookName;
                        }

                        // Remove the original BookID column if you don't need it anymore
                        dataTable.Columns.Remove("BookID");

                        dgvtaginfor.DataSource = dataTable;
                    }
                    else
                    {
                        Console.WriteLine("No borrowed books found for the given UserID.");
                    }
                }
            }
        }

        private string GetBookNameById(string bookId)
        {
            string bookName = "";

            // Assuming your Book table has columns BookID and BookName
            string bookQuery = "SELECT BookName FROM Book WHERE BookID = @BookID";

            using (SqlCommand bookCommand = new SqlCommand(bookQuery, conn))
            {
                bookCommand.Parameters.AddWithValue("@BookID", bookId);
                object result = bookCommand.ExecuteScalar();

                if (result != null)
                {
                    bookName = result.ToString();
                }
            }

            return bookName;
        }


        private void userinfor_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security=true");
            conn.Open();

            // Assuming lbuname.Text contains the username of the logged-in user
            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM Users WHERE UserName = '" + lbuname.Text + "'", conn);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                lbuid.Text = myTable.Rows[0]["UserID"].ToString();
                lbuphone.Text = myTable.Rows[0]["UserPhone"].ToString();
                lbuemail.Text = myTable.Rows[0]["UserEmail"].ToString();

                // Use the actual UserID from the logged-in user
                string loggedInUserId = myTable.Rows[0]["UserID"].ToString();
                DisplayBorrowedBooksForUser(loggedInUserId);
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }




        private void lbchangeemail_Click(object sender, EventArgs e)
        {
            lbnewemail.Show();
            txtnewemail.Show();
            btnokemail.Show();
            btncalemail.Show();
        }

        private void lbchangephone_Click(object sender, EventArgs e)
        {
            lbnewphone.Show();
            txtnewphone.Show();
            btnokphone.Show();
            btncalphone.Show();
        }

        private void lbchangepass_Click(object sender, EventArgs e)
        {
            lboldpass.Show();
            lbnewpass.Show();
            lbcnewpass.Show();
            txtoldpass.Show();
            txtnewpass.Show();
            txtcnewpass.Show();
            btnoknewpass.Show();
            btncalnewpass.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
        }

        private void btnokemail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change the Email?", "ChangeEmail",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbuemail.Text = txtnewemail.Text;

                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Update Users set UserEmail = @useremail where UserID=@userid";

                    cmd.Parameters.Add("@userid", SqlDbType.NChar, 7).Value = lbuid.Text;
                    cmd.Parameters.Add("@useremail", SqlDbType.NChar, 20).Value = lbuemail.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful!", "Update");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            lbnewemail.Hide();
            txtnewemail.Hide();
            btnokemail.Hide();
            btncalemail.Hide();
        }

        private void btncalemail_Click(object sender, EventArgs e)
        {
            lbnewemail.Hide();
            txtnewemail.Hide();
            btnokemail.Hide();
            btncalemail.Hide();
        }

        private void btnokphone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change the Phone?", "Change Phone",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE Users SET UserPhone = @userphone WHERE UserID = @userid";

                    cmd.Parameters.Add("@userid", SqlDbType.NChar, 7).Value = lbuid.Text;
                    cmd.Parameters.Add("@userphone", SqlDbType.NChar, 20).Value = txtnewphone.Text;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successful!", "Success");

                    // Update the UI after a successful database update
                    lbuphone.Text = txtnewphone.Text;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error updating phone: " + ex.Message, "Error");
                }
                finally
                {
                    conn.Close(); // Ensure the connection is closed, whether an exception occurs or not.
                }
            }

            // Hide controls
            lbnewphone.Hide();
            txtnewphone.Hide();
            btnokphone.Hide();
            btncalphone.Hide();
        }

        private void btncalphone_Click(object sender, EventArgs e)
        {
            lbnewphone.Hide();
            txtnewphone.Hide();
            btnokphone.Hide();
            btncalphone.Hide();
        }

        private void btnoknewpass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtoldpass.Text) || string.IsNullOrWhiteSpace(txtnewpass.Text) || string.IsNullOrWhiteSpace(txtcnewpass.Text))
            {
                MessageBox.Show("Please enter information!");
            }
            else if (txtnewpass.Text != txtcnewpass.Text)
            {
                MessageBox.Show("Password does not match");
            }
            else if (MessageBox.Show("Do you want to change the Password?", "ChangePassword",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmdd = new SqlCommand();
                cmdd.Connection = conn;
                cmdd.CommandText = "select * from UserPass where UserID= '" + lbuid.Text + "'and UserPass='" + txtoldpass.Text + "'";

                rdr = cmdd.ExecuteReader();

                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Update UserPass set UserPass = @userpass where UserID=@userid";

                    cmd.Parameters.Add("@userid", SqlDbType.NChar, 7).Value = lbuid.Text;
                    cmd.Parameters.Add("@userpass", SqlDbType.NChar, 20).Value = txtnewpass.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful!", "Update");
                }
                else
                {
                    MessageBox.Show("Wrong Old Password");
                }
                conn.Close();
                conn.Open();
            }
            else
            {

                lboldpass.Hide();
                lbnewpass.Hide();
                lbcnewpass.Hide();
                txtoldpass.Hide();
                txtnewpass.Hide();
                txtcnewpass.Hide();
                btnoknewpass.Hide();
                btncalnewpass.Hide();
            }
        }


        private void btncalnewpass_Click(object sender, EventArgs e)
        {
            lboldpass.Hide();
            lbnewpass.Hide();
            lbcnewpass.Hide();
            txtoldpass.Hide();
            txtnewpass.Hide();
            txtcnewpass.Hide();
            btnoknewpass.Hide();
            btncalnewpass.Hide();
        }

        private void txtnewemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvtaginfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
