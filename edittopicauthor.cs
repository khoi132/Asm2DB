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
    public partial class edittopicauthor : Form
    {
        public edittopicauthor()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;


        private string lbtpau1;
        private string lbtpau2;
        private string lbtpau3;
        private string lbtpau4;

        public edittopicauthor (string gettpau1, string gettpau2, string gettpau3, string gettpau4) : this()
        {
            lbtpau1 = gettpau1;
            lbtpau2 = gettpau2;
            lbtpau3 = gettpau3;
            lbtpau4 = gettpau4;
            lbvalueid.Text = lbtpau1;
            lbvaluename.Text = lbtpau2;
            lbid.Text = lbtpau3;
            lbname.Text = lbtpau4;

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txteditname.Show();
            btncal.Show();
            btnok.Show();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            txteditname.Hide();
            btncal.Hide();
            btnok.Hide();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txteditname.Text))
            {
                MessageBox.Show("Please enter information!");
            }
            else if (MessageBox.Show("Do you want to change the '" +lbname.Text+"'", "ChangeName",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                if (lbid.Text == "TopicID")
                {
                    cmdd = new SqlCommand();
                    cmdd.Connection = conn;
                    cmdd.CommandText = "select * from Topic where TopicID= '" + lbvalueid.Text + "'";
                
                    rdr = cmdd.ExecuteReader();

                    if (rdr.Read())
                    {
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Update Topic set TopicName = @tname where TopicID=@tid";

                    cmd.Parameters.Add("@tname", SqlDbType.NChar, 20).Value = txteditname.Text;
                    cmd.Parameters.Add("@tid", SqlDbType.NChar, 7).Value = lbvalueid.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful!", "Update");
                    }
                }
                else if (lbid.Text == "AuthorID")
                {
                    cmdd = new SqlCommand();
                    cmdd.Connection = conn;
                    cmdd.CommandText = "select * from Author where AuthorID= '" + lbvalueid.Text + "'";

                    rdr = cmdd.ExecuteReader();

                    if (rdr.Read())
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "Update Author set AuthorName = @aname where AuthorID=@aid";

                        cmd.Parameters.Add("@aname", SqlDbType.NChar, 20).Value = txteditname.Text;
                        cmd.Parameters.Add("@aid", SqlDbType.NChar, 7).Value = lbvalueid.Text;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful!", "Update");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
                conn.Open();
            }
            else
            {
                txteditname.Hide();
                btncal.Hide();
                btnok.Hide();
            }
            
        }

        private void edittopicauthor_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
            conn.Open();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            admininterf admininterf = new admininterf();
            admininterf.Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Deletedata",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {


                    if (lbid.Text == "TopicID")
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "delete from Topic where TopicID = @tid";
                        cmd.Parameters.Add("@tid", SqlDbType.NChar, 7).Value = lbvalueid.Text;
                        cmd.ExecuteNonQuery();

                        this.Close();
                    }
                    else if (lbid.Text == "AuthorID")
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "delete from Author where AuthorID = @aid";
                        cmd.Parameters.Add("@aid", SqlDbType.NChar, 7).Value = lbvalueid.Text;
                        cmd.ExecuteNonQuery();

                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    if (lbid.Text == "TopicID")
                    {
                        MessageBox.Show("This Topic has at least a book. Can't delete");
                    }
                    else if (lbid.Text == "AuthorID")
                    {
                        MessageBox.Show("This Author has at least a book. Can't delete");
                    }

                    }
            }
        }

        private void txteditname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
