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
    public partial class register1 : Form
    {
        public register1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            studentlogin studentlogin = new studentlogin();
            studentlogin.Show();
        }

        private void register1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            conn.Close();
            this.Hide();
        }

        private void txtconfpass_Leave(object sender, EventArgs e)
        {
            if (txtupass.Text != txtconfpass.Text)
            {
                lbcheck.Text = "Wrong Confirm password";
            }
            else
            {
                lbcheck.Text = "";
                btnok.Enabled = true;
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (rdrobot2.Checked == true)
            {
                conn.Close();
                this.Hide();
            }
            else if (string.IsNullOrWhiteSpace(txtuid.Text) ||
                string.IsNullOrWhiteSpace(txtuname.Text) ||
                string.IsNullOrWhiteSpace(txtuphone.Text) ||
                string.IsNullOrWhiteSpace(txtupass.Text)
                )
            {
                MessageBox.Show("Please enter the information");
            }
            else if (txtupass.Text != txtconfpass.Text)
            {
                lbcheck.Text = "Wrong Confirm password";

            }
            else
            {
                cmdd = conn.CreateCommand();
                cmdd.CommandText = "select * from Users where UserName=@uname";
                cmdd.Parameters.Add("@uname", SqlDbType.NChar, 20).Value = txtuname.Text;
                rdr = cmdd.ExecuteReader();

                if (rdr.HasRows)
                {
                    if (rdr.Read())
                    {
                        conn.Close();
                        conn.Open();
                        MessageBox.Show("This UserName has been used");

                        txtuname.ForeColor = Color.Red;

                    }

                }

                else
                {
                    rdr.Close();
                    conn.Close();
                    conn.Open();
                    cmdd = conn.CreateCommand();
                    cmdd.CommandText = "select * from Users where UserID=@uid";
                    cmdd.Parameters.Add("@uid", SqlDbType.NChar, 7).Value = txtuid.Text;
                    rdr = cmdd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        if (rdr.Read())
                        {
                            conn.Close();
                            conn.Open();
                            MessageBox.Show("This UserID has been used");

                            txtuid.ForeColor = Color.Red;

                        }
                    }
                    else
                    {

                        rdr.Close();
                        txtuid.ForeColor = Color.Green;
                        btnok.Enabled = true;


                        txtuname.ForeColor = Color.Green;
                        btnok.Enabled = true;


                        try
                        {
                            using (SqlCommand cmd = conn.CreateCommand())
                            {
                                cmd.CommandText = "INSERT INTO Users (UserID, UserName, UserPhone, UserEmail, RoleID) VALUES (@uid, @uname, @uphone, @uemail, 2)";

                                cmd.Parameters.AddWithValue("@uid", txtuid.Text);
                                cmd.Parameters.AddWithValue("@uname", txtuname.Text);
                                cmd.Parameters.AddWithValue("@uphone", txtuphone.Text);
                                cmd.Parameters.AddWithValue("@uemail", txtuemail.Text);
                                cmd.ExecuteNonQuery();
                            }

                            using (SqlCommand cmdd = conn.CreateCommand())
                            {
                                cmdd.CommandText = "insert into UserPass values (@uid, @upass)";
                                cmdd.Parameters.AddWithValue("@uid", txtuid.Text);
                                cmdd.Parameters.AddWithValue("@upass", txtupass.Text);
                                cmdd.ExecuteNonQuery();
                            }
                            if (txtupass.Text != txtconfpass.Text)
                            {
                                MessageBox.Show("Password and Confirm Password do not match.");
                                return;
                            }

                            MessageBox.Show("Add successful", "Add");
                        }



                        catch (SqlException ex)
                        {

                            MessageBox.Show(ex.Message);
                            txtuid.ForeColor = Color.Red;
                            btnok.Enabled = false;
                        }
                    }
                }
            }
        }

        private void txtuid_Leave(object sender, EventArgs e)
        {
            cmdd = conn.CreateCommand();
            cmdd.CommandText = "select * from Users where UserID=@uid";
            cmdd.Parameters.Add("@uid", SqlDbType.NChar, 7).Value = txtuid.Text;
            rdr = cmdd.ExecuteReader();

            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    MessageBox.Show("This UserID has been used");

                    txtuid.ForeColor = Color.Red;
                    btnok.Enabled = false;

                }
            }
            else
            {
                txtuid.ForeColor = Color.Green;
                btnok.Enabled = true;
            }
            rdr.Close();
        }

        private void txtuname_Leave(object sender, EventArgs e)
        {
            cmdd = conn.CreateCommand();
            cmdd.CommandText = "select * from Users where UserName=@uname";
            cmdd.Parameters.Add("@uname", SqlDbType.NChar, 20).Value = txtuname.Text;
            rdr = cmdd.ExecuteReader();

            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    MessageBox.Show("This UserName has been used");

                    txtuname.ForeColor = Color.Red;
                    btnok.Enabled = false;

                }
            }
            else
            {
                txtuname.ForeColor = Color.Green;
                btnok.Enabled = true;
            }
            rdr.Close();
        }
    }
}