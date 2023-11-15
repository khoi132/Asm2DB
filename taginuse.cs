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
    public partial class taginuse : Form
    {
        public taginuse()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void datainusetodgv()
        {
            string sql = "select Tag.TagID, USTGBK.UserID, USTGBK.BookID, Tag.BorrowedDate, Tag.ReturnDate from USTGBK, Tag where USTGBK.TagID = Tag.TagID";
            cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvtaginuse.DataSource = dt;
        }

        private void taginuse_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();

            datainusetodgv();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvtaginuse.DataSource = null;
            dgvtaginuse.Refresh();

            datainusetodgv();
        }

        private void btnmovetag_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbtid.Text))
            {
                MessageBox.Show("Please choose a tag");
            }
            else if (MessageBox.Show("Does this tag dated?", "Datedtag",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Close();
                conn.Open();
                try
                {
                    //add data to table USTGBKdated
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into USTGBKdated " +
                        "select USTGBK.UserID, Tag.TagID, USTGBK.BookID, Tag.ReturnDate, Tag.Description " +
                        "from USTGBK, Tag " +
                        "where USTGBK.TagID = @tgid and Tag.TagID = @tgid";

                    cmd.Parameters.Add("@tgid", SqlDbType.NChar, 7).Value = lbtid.Text;

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    conn.Open();
                    //remove the description borrowed from the books
                    SqlCommand cmdb = conn.CreateCommand();
                    cmdb.CommandText = "update Book set Descriptions = '' from (select USTGBK.BookID from USTGBK where USTGBK.TagID = @tgid) as t where Book.BookID = t.BookID";
                    
                    cmdb.Parameters.Add("@tgid", SqlDbType.NChar, 7).Value = lbtid.Text;

                    cmdb.ExecuteNonQuery();
                    MessageBox.Show("Successful", "Data Transfer");
                    conn.Close();
                    conn.Open();
                    try
                    {
                        //Delete the information about the borrowed tag.
                        SqlCommand cmdu = conn.CreateCommand();
                        cmdu.CommandText = "delete from USTGBK where TagID = @tgid";
                        cmdu.Parameters.Add("@tgid", SqlDbType.NChar, 7).Value = lbtid.Text;
                        cmdu.ExecuteNonQuery();

                        conn.Close();
                        conn.Open();

                        SqlCommand cmdt = conn.CreateCommand();
                        cmdt.CommandText = "delete from Tag where TagID = @tgid";
                        cmdt.Parameters.Add("@tgid", SqlDbType.NChar, 7).Value = lbtid.Text;
                        cmdt.ExecuteNonQuery();

                        foreach (DataGridViewRow item in this.dgvtaginuse.SelectedRows)
                        {
                            dgvtaginuse.Rows.RemoveAt(item.Index);
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Delete from Tag is error");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("Insert into USTGBKdated is error");
                }
            }
        }

        private void dgvtaginuse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvtaginuse.Rows[e.RowIndex];

                lbtid.Text = row.Cells[0].Value.ToString();
            }
        }

        private void dgvtaginuse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
