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
    public partial class currenttag : Form
    {
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private string uid;
        public currenttag(string uid1) : this()
        {
            uid = uid1;
            lbuid.Text = uid;
        }

        public currenttag()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            try
            {
                cmdd = new SqlCommand();
                cmdd.Connection = conn;
                cmdd.CommandText = "Update Currenttag set Descriptions = 'Confirmed' where UserID = '" + lbuid.Text + "'";
                cmdd.ExecuteNonQuery();

                MessageBox.Show("Your data will be sent to the librarian for confirmation!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookidtodgv()
        {
            string sql = "select USTGBK.BookID from USTGBK where UserID = '" + lbuid.Text + "'";
            SqlCommand cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvbookinf.DataSource = dt;
        }

        private void currenttag_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();

            bookidtodgv();

        }

        int index;
        DataGridViewRow row;

        private void btndel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbbid.Text))
            {

            }
            else if (MessageBox.Show("Are you sure?", "Deletedata",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Close();
                conn.Open();
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from Currenttag where UserID = @uid and BookID = @bid";

                    cmd.Parameters.Add("@uid", SqlDbType.NChar, 7).Value = lbuid.Text;
                    cmd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = lbbid.Text;

                    cmd.ExecuteNonQuery();

                    foreach (DataGridViewRow item in this.dgvbookinf.SelectedRows)
                    {
                        dgvbookinf.Rows.RemoveAt(item.Index);
                    }
                    MessageBox.Show("Delete successful", "Delete");
                    lbbid.Text = "";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something is error");
                }


            }

            dgvbookinf.DataSource = null;
            dgvbookinf.Refresh();
            bookidtodgv();

        }

        private void dgvbookinf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            row = this.dgvbookinf.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvbookinf.Rows[e.RowIndex];

                lbbid.Text = row.Cells[0].Value.ToString();
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvbookinf.DataSource = null;
            dgvbookinf.Refresh();
            bookidtodgv();
        }
    }
}