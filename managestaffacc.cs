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
    public partial class managestaffacc : Form
    {
        public managestaffacc()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void datastaffacctodgv()
        {
            string sql = "select * from Admins order by AdminName";
            cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvstaffacc.DataSource = dt;
        }

        private void managestaffacc_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();

            datastaffacctodgv();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtacc.Text = txtpass.Text = null;
            txtacc.Enabled = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            admininterf admininterf = new admininterf();
            admininterf.Show();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtacc.Text = txtpass.Text = null;
            txtacc.Enabled = true;

            dgvstaffacc.DataSource = null;
            dgvstaffacc.Refresh();

            datastaffacctodgv();
        }

        private void dgvstaffacc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvstaffacc.Rows[e.RowIndex];

                txtacc.Text = row.Cells[0].Value.ToString();
                txtpass.Text = row.Cells[1].Value.ToString();

                txtacc.Enabled = false;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtacc.Text))
            {

            }
            else if (txtacc.Text == "admin")
            {
                MessageBox.Show("You can't delete admin root");
            }
            else if (MessageBox.Show("Are you sure?", "Deletedata",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from Admins where AdminName = @adname";
                    cmd.Parameters.Add("@adname", SqlDbType.NChar, 20).Value = txtacc.Text;
                    cmd.ExecuteNonQuery();

                    foreach (DataGridViewRow item in this.dgvstaffacc.SelectedRows)
                    {
                        dgvstaffacc.Rows.RemoveAt(item.Index);
                    }
                    MessageBox.Show("Delete successful", "Delete");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("You can't delete admin root");
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtacc.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Please enter the information");
            }
            else if (MessageBox.Show("Do you want to add this account?", "Addaccount",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into Admins values (@adname, @adpass)";

                    cmd.Parameters.Add("@adname", SqlDbType.NChar, 20).Value = txtacc.Text;
                    cmd.Parameters.Add("@adpass", SqlDbType.NChar, 20).Value = txtpass.Text;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Add successful", "Add");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("This Account already exists");
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtacc.Text) ||
                string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Please enter the information!");
            }
            else if (MessageBox.Show("Do you want to change this account", "ChangeAccount",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    cmdd = new SqlCommand();
                    cmdd.Connection = conn;
                    cmdd.CommandText = "select * from Admins where AdminName= '" + txtacc.Text + "'";

                    rdr = cmdd.ExecuteReader();

                    if (rdr.Read())
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "Update Admins set AdminPass = @adpass where AdminName=@adname";

                        cmd.Parameters.Add("@adname", SqlDbType.NChar, 20).Value = txtacc.Text;
                        cmd.Parameters.Add("@adpass", SqlDbType.NChar, 20).Value = txtpass.Text;

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successful!", "Update");
                    }
                    else
                    {
                        MessageBox.Show("This account does not exist");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something is error");
                }
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}