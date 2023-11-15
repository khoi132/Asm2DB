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
    public partial class editdeleteacc : Form
    {
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private string uid;
        public editdeleteacc(string uid1) : this()
        {
            uid = uid1;
            lbuid.Text = uid;
        }

        public editdeleteacc()
        {
            InitializeComponent();
        }

        private void editdeleteacc_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from Users where UserID = '" + lbuid.Text + "'", conn);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            lbuname.Text = myTable.Rows[0]["UserName"].ToString();
            lbuphone.Text = myTable.Rows[0]["UserPhone"].ToString();
            lbuemail.Text = myTable.Rows[0]["UserEmail"].ToString();

            SqlDataAdapter myAdapterpass = new SqlDataAdapter("select * from UserPass where UserName = '" + lbuname.Text + "'", conn);
            DataTable myTablepass = new DataTable();
            myAdapterpass.Fill(myTablepass);
            lbupass.Text = myTablepass.Rows[0]["UserPass"].ToString();
        }

        private void btneditu_Click(object sender, EventArgs e)
        {
            txtupass.Show();
            txtuphone.Show();
            txtuemail.Show();
            btncal.Show();
            btnok.Show();

            txtupass.Text = lbupass.Text;
            txtuphone.Text = lbuphone.Text;
            txtuemail.Text = lbuemail.Text;
        }

        private void btndeleteu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this account?", "Deleteaccount",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmdd = conn.CreateCommand();

                    cmdd.CommandText = "delete from UserPass where UserName = @uname";
                    cmdd.Parameters.Add("@uname", SqlDbType.NChar, 20).Value = lbuname.Text;

                    cmdd.ExecuteNonQuery();

                    cmdd = conn.CreateCommand();

                    cmdd.CommandText = "delete from Users where UserID = @uid";
                    cmdd.Parameters.Add("@uid", SqlDbType.NChar, 7).Value = lbuid.Text;

                    cmdd.ExecuteNonQuery();

                    MessageBox.Show("Delete successful", "Delete");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something is error. Maybe this UserID exists in another table.");
                }

            }
        }
            private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            admininterf admininterf = new admininterf();
            admininterf.Show();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtupass.Text) ||
                string.IsNullOrWhiteSpace(txtuphone.Text))
            {
                MessageBox.Show("Please enter information!");
            }
            else if (MessageBox.Show("Do you want to change the information", "ChangeAccount",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    cmdd = new SqlCommand();
                    cmdd.Connection = conn;
                    cmdd.CommandText = "select * from Users where UserID= '" + lbuid.Text + "'";

                    rdr = cmdd.ExecuteReader();

                    if (rdr.Read())
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "Update Users set UserPhone = @uphone, UserEmail = @uemail where UserID=@uid";

                        cmd.Parameters.Add("@uid", SqlDbType.NChar, 7).Value = lbuid.Text;
                        cmd.Parameters.Add("@uphone", SqlDbType.NChar, 20).Value = txtuphone.Text;
                        cmd.Parameters.Add("@uemail", SqlDbType.NChar, 50).Value = txtuemail.Text;

                        cmd.ExecuteNonQuery();

                        SqlCommand cmdp = conn.CreateCommand();
                        cmdp.CommandText = "Update UserPass set UserPass = @upass where UserName=@uname";

                        cmdp.Parameters.Add("@uname", SqlDbType.NChar, 20).Value = lbuname.Text;
                        cmdp.Parameters.Add("@upass", SqlDbType.NChar, 7).Value = txtupass.Text;

                        cmdp.ExecuteNonQuery();

                        MessageBox.Show("Successful!", "Update");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something is error");
                }


                conn.Close();
                conn.Open();
            }
            else
            {
                txtupass.Hide();
                txtuphone.Hide();
                txtuemail.Hide();
                btncal.Hide();
                btnok.Hide();
            }

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            txtupass.Hide();
            txtuphone.Hide();
            txtuemail.Hide();
            btncal.Hide();
            btnok.Hide();
        }

        private void txtuphone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
