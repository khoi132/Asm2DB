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
    public partial class forgotpass2 : Form
    {
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private string uid;

        public forgotpass2()
        {
            InitializeComponent();
        }

        public forgotpass2(string uid1) : this()
        {
            uid = uid1;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
            forgotpass1 forgotpass1 = new forgotpass1();
            forgotpass1.Show();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnewpass.Text) || string.IsNullOrWhiteSpace(txtconfpass.Text))
            {
                MessageBox.Show("Please enter all information!");
            }
            else if (txtnewpass.Text != txtconfpass.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else if (MessageBox.Show("Do you want to change the Password?", "Change Password", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand updatePassCmd = new SqlCommand("UPDATE UserPass SET UserPass = @upass WHERE UserID = @uid", conn))
                    {
                        updatePassCmd.Parameters.Add("@uid", SqlDbType.NChar, 7).Value = uid;
                        updatePassCmd.Parameters.Add("@upass", SqlDbType.NChar, 20).Value = txtnewpass.Text;

                        conn.Open();
                        updatePassCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Password changed successfully!", "Success");

                    studentlogin studentlogin = new studentlogin();
                    studentlogin.Show();
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message, "Error");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void txtverif_TextChanged(object sender, EventArgs e)
        {
            // You might want to add some functionality here if needed
        }

        private void txtconfpass_TextChanged(object sender, EventArgs e)
        {
            if (txtnewpass.Text == txtconfpass.Text)
            {
                lbcheckpass.Text = "Correct!";
                lbcheckpass.ForeColor = Color.Green;
            }
            else
            {
                lbcheckpass.Text = "Wrong!";
                lbcheckpass.ForeColor = Color.Red;
            }
        }

        private void forgotpass2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security=true");
        }

        private void txtnewpass_Leave(object sender, EventArgs e)
        {
            if (txtnewpass.Text == txtconfpass.Text)
            {
                lbcheckpass.Text = "Correct!";
                lbcheckpass.ForeColor = Color.Green;
            }
            else
            {
                lbcheckpass.Text = "Wrong!";
                lbcheckpass.ForeColor = Color.Red;
            }
        }
    }
}