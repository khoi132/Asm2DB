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
    public partial class addbook : Form
    {
        public addbook()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void dataauthortodgv()
        {
            string sql = "select * from Author order by AuthorID";
            cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvauthor.DataSource = dt;
        }
        private void datatopictodgv()
        {
            string sql = "select * from Topic order by TopicID";
            cmdd = new SqlCommand(sql, conn);
            cmdd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvtopic.DataSource = dt;
        }

        private void addbook_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();

        }

        private void btnaddb_Click(object sender, EventArgs e)
        {
            try
            {
                cmdd = conn.CreateCommand();

                cmdd.CommandText = "insert into Book values (@bid, @bname, @bdes)";
                cmdd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = txtbid.Text;
                cmdd.Parameters.Add("@bname", SqlDbType.NChar, 40).Value = txtbname.Text;
                cmdd.Parameters.Add("@bdes", SqlDbType.NChar, 100).Value = txtbdes.Text;

                cmdd.ExecuteNonQuery();

                cmdd = conn.CreateCommand();

                cmdd.CommandText = "insert into BookTopic values (@bid, @btid)";
                cmdd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = txtbid.Text;
                cmdd.Parameters.Add("@btid", SqlDbType.NChar, 7).Value = txtbtopicid.Text;
                
                cmdd.ExecuteNonQuery();

                cmdd = conn.CreateCommand();
                cmdd.CommandText = "insert into BookAuthor values (@bid, @baid)";
                cmdd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = txtbid.Text;
                cmdd.Parameters.Add("@baid", SqlDbType.NChar, 7).Value = txtbauthorid.Text;

                cmdd.ExecuteNonQuery();

                MessageBox.Show("Succesful!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Syntax error. " +
                    "The syntax is: " +
                    "Book ID: BKxxxxx, " +
                    "Topic ID: TPxxxxx, " +
                    "AuthorID: ATxxxxx, " +
                    "BookName is not null");
            }
        }

        private void lbaddtopic_Click(object sender, EventArgs e)
        {
            label3.Show();
            label6.Show();
            txttopicid.Show();
            txttopicname.Show();
            dgvtopic.Show();
            btnaddtopic.Show();
            btnbacktopic.Show();
            btnrefreshtp.Show();

            dgvtopic.DataSource = null;
            dgvtopic.Refresh();
            datatopictodgv();
        }

        private void lbaddauthor_Click(object sender, EventArgs e)
        {
            label4.Show();
            label7.Show();
            txtauthorid.Show();
            txtauthorname.Show();
            dgvauthor.Show();
            btnaddauthor.Show();
            btnbackauthor.Show();
            btnrefreshau.Show();

            dgvauthor.DataSource = null;
            dgvauthor.Refresh();
            dataauthortodgv();
        }

        private void btnaddtopic_Click(object sender, EventArgs e)
        {
            try
            {
                cmdd = conn.CreateCommand();

                cmdd.CommandText = "insert into Topic values (@tid, @tname)";
                cmdd.Parameters.Add("@tid", SqlDbType.NChar, 7).Value = txttopicid.Text;
                cmdd.Parameters.Add("@tname", SqlDbType.NChar, 20).Value = txttopicname.Text;

                cmdd.ExecuteNonQuery();

                MessageBox.Show("Succesful!");
                txttopicid.Text = "";
                txttopicname.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Syntax error. (TopicID: TPxxxxx)");
            }
        }

        private void btnaddauthor_Click(object sender, EventArgs e)
        {
            try
            {
                cmdd = conn.CreateCommand();

                cmdd.CommandText = "insert into Author values (@aid, @aname)";
                cmdd.Parameters.Add("@aid", SqlDbType.NChar, 7).Value = txtauthorid.Text;
                cmdd.Parameters.Add("@aname", SqlDbType.NChar, 20).Value = txtauthorname.Text;

                cmdd.ExecuteNonQuery();

                MessageBox.Show("Succesful!");

                txttopicid.Text = "";
                txttopicname.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Syntax error. (AuthorID: ATxxxxx)");
            }
        }

        private void btnbacktopic_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label6.Hide();
            txttopicid.Hide();
            txttopicname.Hide();
            dgvtopic.Hide();
            btnaddtopic.Hide();
            btnbacktopic.Hide();
            btnrefreshtp.Hide();

        }

        private void btnbackauthor_Click(object sender, EventArgs e)
        {
            label4.Hide();
            label7.Hide();
            txtauthorid.Hide();
            txtauthorname.Hide();
            dgvauthor.Hide();
            btnaddauthor.Hide();
            btnbackauthor.Hide();
            btnrefreshau.Hide();

        }

        private void txtbid_Leave(object sender, EventArgs e)
        {
            cmdd = conn.CreateCommand();
            cmdd.CommandText = "select * from Book where BookID=@bid";
            cmdd.Parameters.Add("@bid", SqlDbType.NChar, 7).Value = txtbid.Text;
            rdr = cmdd.ExecuteReader();

            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    MessageBox.Show("This BookID has been used");
                    
                    txtbid.ForeColor = Color.Red;
                    btnaddb.Enabled = false;
                    
                }
            }
            else
            {
                txtbid.ForeColor = Color.Green;
                btnaddb.Enabled = true;
            }
            rdr.Close();
        }

        private void txttopicid_Leave(object sender, EventArgs e)
        {
            cmdd = conn.CreateCommand();
            cmdd.CommandText = "select * from Topic where TopicID=@tid";
            cmdd.Parameters.Add("@tid", SqlDbType.NChar, 7).Value = txttopicid.Text;
            rdr = cmdd.ExecuteReader();

            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    MessageBox.Show("This TopicID has been used");

                    txttopicid.ForeColor = Color.Red;
                    btnaddtopic.Enabled = false;

                }
            }
            else
            {
                txttopicid.ForeColor = Color.Green;
                btnaddtopic.Enabled = true;
            }
            rdr.Close();
        }

        private void txtauthorid_Leave(object sender, EventArgs e)
        {
            cmdd = conn.CreateCommand();
            cmdd.CommandText = "select * from Author where AuthorID=@aid";
            cmdd.Parameters.Add("@aid", SqlDbType.NChar, 7).Value = txtauthorid.Text;
            rdr = cmdd.ExecuteReader();

            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    MessageBox.Show("This AuthorID has been used");

                    txtauthorid.ForeColor = Color.Red;
                    btnaddauthor.Enabled = false;

                }
            }
            else
            {
                txtauthorid.ForeColor = Color.Green;
                btnaddauthor.Enabled = true;
            }
            rdr.Close();
        }

        private void txttopicname_Leave(object sender, EventArgs e)
        {
            cmdd = conn.CreateCommand();
            cmdd.CommandText = "select * from Topic where TopicName=@tname";
            cmdd.Parameters.Add("@tname", SqlDbType.NChar, 20).Value = txttopicname.Text;
            rdr = cmdd.ExecuteReader();

            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    MessageBox.Show("This TopicName has been used");

                    txttopicid.ForeColor = Color.Red;
                    btnaddtopic.Enabled = false;

                }
            }
            else
            {
                txttopicid.ForeColor = Color.Green;
                btnaddtopic.Enabled = true;
            }
            rdr.Close();
        }

        private void txtauthorname_Leave(object sender, EventArgs e)
        {
            cmdd = conn.CreateCommand();
            cmdd.CommandText = "select * from Author where AuthorName=@aname";
            cmdd.Parameters.Add("@aname", SqlDbType.NChar, 7).Value = txtauthorname.Text;
            rdr = cmdd.ExecuteReader();

            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    MessageBox.Show("This AuthorName has been used");

                    txtauthorid.ForeColor = Color.Red;
                    btnaddauthor.Enabled = false;

                }
            }
            else
            {
                txtauthorid.ForeColor = Color.Green;
                btnaddauthor.Enabled = true;
            }
            rdr.Close();
        }

        private void txtbtopicid_Leave(object sender, EventArgs e)
        {
            cmdd = conn.CreateCommand();
            cmdd.CommandText = "select * from Topic where TopicID=@tid";
            cmdd.Parameters.Add("@tid", SqlDbType.NChar, 7).Value = txtbtopicid.Text;
            rdr = cmdd.ExecuteReader();

            if (string.IsNullOrWhiteSpace(txtbtopicid.Text))
            {

            }
            else if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();

                    txtbtopicid.ForeColor = Color.Green;
                    btnaddb.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("This TopicID is not found");

                txtbtopicid.ForeColor = Color.Red;
                btnaddb.Enabled = false;
            }
            rdr.Close();
        }

        private void txtbauthorid_Leave(object sender, EventArgs e)
        {
            cmdd = conn.CreateCommand();
            cmdd.CommandText = "select * from Author where AuthorID=@aid";
            cmdd.Parameters.Add("@aid", SqlDbType.NChar, 7).Value = txtbauthorid.Text;
            rdr = cmdd.ExecuteReader();
            if (string.IsNullOrWhiteSpace(txtbauthorid.Text))
            {

            }
            else if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();

                    txtbauthorid.ForeColor = Color.Green;
                    btnaddb.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("This AuthorID is not found");

                txtbauthorid.ForeColor = Color.Red;
                btnaddb.Enabled = false;
            }
            rdr.Close();
        }

        private void txtbname_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnrefreshtp_Click(object sender, EventArgs e)
        {
            dgvtopic.DataSource = null;
            dgvtopic.Refresh();
            datatopictodgv();
        }

        private void btnrefreshau_Click(object sender, EventArgs e)
        {
            dgvauthor.DataSource = null;
            dgvauthor.Refresh();
            dataauthortodgv();
        }

        private void dgvtopic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvtopic.Rows[e.RowIndex];
                    edittopicauthor edittopicauthor = new edittopicauthor(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(),"TopicID", "TopicName");
                    edittopicauthor.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvauthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvauthor.Rows[e.RowIndex];
                    edittopicauthor edittopicauthor = new edittopicauthor(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), "AuthorID", "AuthorName");
                    edittopicauthor.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txttopicid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtauthorid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
