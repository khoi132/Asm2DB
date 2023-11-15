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
    public partial class addaccount : Form
    {
        public addaccount()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void dataregistodgv()
        {
            string sql = "select * from Users order by UserID";
            cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvregister.DataSource = dt;
        }

        private void addaccount_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();

            dataregistodgv();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
        }

        private void btnaddu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add this account?", "Addaccount",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //SqlCommand cmdp = conn.CreateCommand();
                    //cmdp.CommandText = "addstudent";
                    //cmdp.CommandType = CommandType.StoredProcedure;

                    //cmdp.Parameters.Add("@userid", SqlDbType.NChar, 7).Value = txtuid.Text;
                    //cmdp.Parameters.Add("@username", SqlDbType.NChar, 20).Value = txtuname.Text;
                    //cmdp.Parameters.Add("@userphone", SqlDbType.NChar, 20).Value = txtuphone.Text;
                    //cmdp.Parameters.Add("@useremail", SqlDbType.NChar, 50).Value = txtuemail.Text;
                    //cmdp.Parameters.Add("@userpass", SqlDbType.NChar, 20).Value = txtupass.Text;

                    //cmdp.ExecuteNonQuery();
                    //MessageBox.Show("Successful!", "Update");
                    //add data to the Users and UserPass tables.
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "insert into Users values (@uid, @uname, @uphone, @uemail, @uroleid)";
                        cmd.Parameters.AddWithValue("@uid", txtuid.Text);
                        cmd.Parameters.AddWithValue("@uname", txtuname.Text);
                        cmd.Parameters.AddWithValue("@uphone", txtuphone.Text);
                        cmd.Parameters.AddWithValue("@uemail", txtuemail.Text);
                        cmd.Parameters.AddWithValue("@uroleid", txturoleid.Text);
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmdd = conn.CreateCommand())
                    {
                        cmdd.CommandText = "insert into UserPass values (@uid, @upass)";
                        cmdd.Parameters.AddWithValue("@uid", txtuid.Text);
                        cmdd.Parameters.AddWithValue("@upass", txtupass.Text);
                        cmdd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Add successful", "Add");

                    try
                    {
                        using (SqlCommand cmdr = conn.CreateCommand())
                        {
                            cmdr.CommandText = "delete from Users where UserID = @uid";
                            cmdr.Parameters.AddWithValue("@uid", txtuid.Text);
                            cmdr.ExecuteNonQuery();
                        }

                        foreach (DataGridViewRow item in dgvregister.SelectedRows)
                        {
                            dgvregister.Rows.RemoveAt(item.Index);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Delete from Register is error");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Insert into UserPass is error");
                }


            }
            txtuid.Text = txtuname.Text = txtuphone.Text = txtuemail.Text = txtupass.Text = txturoleid.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuid.Text = txtuname.Text = txtuphone.Text = txtuemail.Text = txtupass.Text = txturoleid.Text="";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Deletedata",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from Register where UserID = @uid";
                    cmd.Parameters.Add("@uid", SqlDbType.NChar, 7).Value = txtuid.Text;
                    cmd.ExecuteNonQuery();

                    foreach (DataGridViewRow item in this.dgvregister.SelectedRows)
                    {
                        dgvregister.Rows.RemoveAt(item.Index);
                    }
                    MessageBox.Show("Delete successful", "Delete");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something is error");
                }


            }
            txtuid.Text = txtuname.Text = txtuphone.Text = txtuemail.Text = txtupass.Text = txturoleid.Text = "";
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvregister.DataSource = null;
            dgvregister.Refresh();
            dataregistodgv();

            txtuid.Text = txtuname.Text = txtuphone.Text = txtuemail.Text = txtupass.Text = txturoleid.Text = "";
        }

        private void dgvregister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvregister.Rows[e.RowIndex];

                txtuid.Text = row.Cells[0].Value.ToString();
                txtuname.Text = row.Cells[1].Value.ToString();
                txtuphone.Text = row.Cells[2].Value.ToString();
                txtuemail.Text = row.Cells[3].Value.ToString();
                txtupass.Text = row.Cells[4].Value.ToString();
                txturoleid.Text = row.Cells[5].Value.ToString();

                txtuid.Enabled = false;
            }

        }

        private void dgvregister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}