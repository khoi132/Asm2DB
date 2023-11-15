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
    public partial class tagdated : Form
    {
        public tagdated()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void datadatedtodgv()
        {
            string sql = "select * from USTGBKdated";
            cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvtagdated.DataSource = dt;
        }

        private void tagdated_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();

            datadatedtodgv();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select COUNT(*) as Tag from USTGBKdated", conn);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            label2.Text = myTable.Rows[0]["Tag"].ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvtagdated.DataSource = null;
            dgvtagdated.Refresh();

            datadatedtodgv();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbtgid.Text))
            {
                MessageBox.Show("Please choose a tag");
            }
            else if (MessageBox.Show("Are you sure?", "Deletedata",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from USTGBKdated where TagID = @tgid";
                    cmd.Parameters.Add("@tgid", SqlDbType.NChar, 7).Value = lbtgid.Text;
                    cmd.ExecuteNonQuery();

                    foreach (DataGridViewRow item in this.dgvtagdated.SelectedRows)
                    {
                        dgvtagdated.Rows.RemoveAt(item.Index);
                    }
                    MessageBox.Show("Delete successful", "Delete");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something is error");
                }


            }
        }

        private void dgvtagdated_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvtagdated.Rows[e.RowIndex];

                lbtgid.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dgvtagdated_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
