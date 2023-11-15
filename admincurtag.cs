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
    public partial class admincurtag : Form
    {
        public admincurtag()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void datacurrtodgv()
        {
            string sql = "select * from Currenttag where Descriptions like '%Confirmed%' order by UserID";
            cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvcurrenttag.DataSource = dt;
        }

        private void admincurtag_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();

            datacurrtodgv();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvcurrenttag.DataSource = null;
            dgvcurrenttag.Refresh();

            datacurrtodgv();
        }

        private void dgvcurrenttag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvcurrenttag.Rows[e.RowIndex];

                txtuid.Text = row.Cells[0].Value.ToString();
                txtbid.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbid.Text = txtuid.Text = txttagid.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbid.Text)||
                string.IsNullOrWhiteSpace(txttagid.Text) ||
                string.IsNullOrWhiteSpace(txtuid.Text))
            {
                MessageBox.Show("Please enter the information");
            }
            else if (MessageBox.Show("Do you want to add this tag?", "Addtag",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Close();
                conn.Open();

                cmdd = new SqlCommand();
                cmdd.Connection = conn;

                cmdd.CommandText = "select * from (select COUNT(TagID) as CTagID from USTGBK where TagID = '" + txttagid.Text + "') as a where a.CTagID > 9";

                rdr = cmdd.ExecuteReader();
                if (rdr.HasRows)
                {
                    if (rdr.Read())
                    {
                        MessageBox.Show("This tag already contains up to 10 books");
                    }
                }
                else
                {

                    conn.Close();
                    conn.Open();

                    cmdd = new SqlCommand();
                    cmdd.Connection = conn;

                    cmdd.CommandText = "select * from (select COUNT(BookID) as CBookID from USTGBK where UserID = '" + txtuid.Text + "') as a where a.CBookID > 2";

                    rdr = cmdd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        if (rdr.Read())
                        {
                            MessageBox.Show("This User has borrowed 3 books");
                        }
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();

                        cmdd = new SqlCommand();
                        cmdd.Connection = conn;

                        cmdd.CommandText = "select * from USTGBK where BookID = '" + txtbid.Text + "'";

                        rdr = cmdd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                MessageBox.Show("This book has been borrowed");
                            }
                        }
                        else
                        {
                            conn.Close();
                            conn.Open();
                            try
                            {
                                    conn.Close();
                                    conn.Open();

                                    cmdd = new SqlCommand();
                                    cmdd.Connection = conn;

                                    cmdd.CommandText = "select * from Tag where TagID = '" + txttagid.Text + "'";

                                    rdr = cmdd.ExecuteReader();
                                if (rdr.HasRows)
                                {
                                    if (rdr.Read())
                                    {
                                        MessageBox.Show("This tag already exists, BorrowedDate and ReturnDate will be set as at tag initialization.");

                                        conn.Close();
                                        conn.Open();

                                        SqlCommand cmde = conn.CreateCommand();
                                        cmde.CommandText = "insert into USTGBK values (@uid, @tgid, @bid)";

                                        cmde.Parameters.Add("@uid", SqlDbType.NChar, 7).Value = txtuid.Text;
                                        cmde.Parameters.Add("@tgid", SqlDbType.NChar, 7).Value = txttagid.Text;
                                        cmde.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = txtbid.Text;

                                        cmde.ExecuteNonQuery();

                                        conn.Close();
                                        conn.Open();

                                        SqlCommand cmds = conn.CreateCommand();
                                        
                                        cmds.CommandText = "update Book set Descriptions = 'Borrowed' where BookID = '" + txtbid.Text + "'";
                                        cmds.Connection = conn;
                                        cmds.ExecuteNonQuery();
                                        MessageBox.Show("Add successful", "Add");
                                        conn.Close();
                                        conn.Open();
                                        try
                                        {
                                            SqlCommand cmdc = conn.CreateCommand();
                                            cmdc.CommandText = "delete from Currenttag where BookID = @bid";
                                            cmdc.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = txtbid.Text;
                                            cmdc.ExecuteNonQuery();

                                            foreach (DataGridViewRow item in this.dgvcurrenttag.SelectedRows)
                                            {
                                                dgvcurrenttag.Rows.RemoveAt(item.Index);
                                            }


                                        }
                                        catch (SqlException ex)
                                        {
                                            MessageBox.Show("Delete from Currenttag is error");
                                        }

                                    }
                                }
                                else
                                {
                                    conn.Close();
                                    conn.Open();
                                    try
                                    {
                                        cmdd = conn.CreateCommand();

                                        cmdd.CommandText = "insert into Tag values (@tgid, @tgborrow, @tgreturn, '')";
                                        cmdd.Parameters.Add("@tgid", SqlDbType.NChar, 7).Value = txttagid.Text;
                                        cmdd.Parameters.Add("@tgborrow", SqlDbType.Date).Value = timepickborrow.Value;
                                        cmdd.Parameters.Add("@tgreturn", SqlDbType.Date).Value = timepickreturn.Value;

                                        cmdd.ExecuteNonQuery();

                                        conn.Close();
                                        conn.Open();

                                        SqlCommand cmd = conn.CreateCommand();
                                        cmd.CommandText = "insert into USTGBK values (@uid, @tgid, @bid)";

                                        cmd.Parameters.Add("@uid", SqlDbType.NChar, 7).Value = txtuid.Text;
                                        cmd.Parameters.Add("@tgid", SqlDbType.NChar, 7).Value = txttagid.Text;
                                        cmd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = txtbid.Text;

                                        cmd.ExecuteNonQuery();

                                        conn.Close();
                                        conn.Open();
                                        SqlCommand cmdu = conn.CreateCommand();

                                        cmdu.CommandText = "update Book set Descriptions = 'Borrowed' where BookID = '" + txtbid.Text + "'";
                                        cmdu.Connection = conn;

                                        cmdu.ExecuteNonQuery();

                                        MessageBox.Show("Add successful", "Add");

                                        try
                                        {
                                            SqlCommand cmdc = conn.CreateCommand();
                                            cmdc.CommandText = "delete from Currenttag where BookID = @bid";
                                            cmdc.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = txtbid.Text;
                                            cmdc.ExecuteNonQuery();

                                            foreach (DataGridViewRow item in this.dgvcurrenttag.SelectedRows)
                                            {
                                                dgvcurrenttag.Rows.RemoveAt(item.Index);
                                            }

                                        }
                                        catch (SqlException ex)
                                        {
                                            //MessageBox.Show(ex.Message);
                                            MessageBox.Show("Delete from Currenttag is error");
                                        }
                                    }
                                    catch (SqlException ex)
                                    {
                                        //MessageBox.Show(ex.Message);
                                        MessageBox.Show("Syntax is Error. TagID: TGxxxxx, ReturnDate: must be greater than the BorrowDate, UserID: USxxxxx, BookID: BKxxxxx");
                                    }
                                }
                            }
                            catch (SqlException ex)
                            {
                                //MessageBox.Show(ex.Message);
                                MessageBox.Show("Syntax is Error. TagID: TGxxxxx, ReturnDate: must be greater than the BorrowDate, UserID: USxxxxx, BookID: BKxxxxx");
                            }
                        }
                    }

                }

            }


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Deletedata",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Close();
                conn.Open();
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from Currenttag where BookID = @bid";
                    cmd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = txtbid.Text;
                    cmd.ExecuteNonQuery();

                    foreach (DataGridViewRow item in this.dgvcurrenttag.SelectedRows)
                    {
                        dgvcurrenttag.Rows.RemoveAt(item.Index);
                    }
                    MessageBox.Show("Delete successful", "Delete");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something is error");
                }


            }
            txtbid.Text = txtuid.Text = txttagid.Text = "";
        }

        private void txttagid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
