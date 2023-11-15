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
    public partial class forgotpass1 : Form
    {
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        public forgotpass1()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            studentlogin studentlogin = new studentlogin();
            studentlogin.Show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuname.Text) ||
                string.IsNullOrWhiteSpace(txtuphone.Text) ||
                string.IsNullOrWhiteSpace(txtuemail.Text))
            {
                MessageBox.Show("Username, UserPhone, or UserEmail is empty!");
            }
            else
            {
                try
                {
                    using (conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security=true"))
                    {
                        conn.Open();

                        using (cmdd = new SqlCommand("SELECT * FROM Users WHERE UserID = @uname AND UserPhone = @uphone AND UserEmail = @uemail", conn))
                        {
                            cmdd.Parameters.AddWithValue("@uname", txtuname.Text);
                            cmdd.Parameters.AddWithValue("@uphone", txtuphone.Text);
                            cmdd.Parameters.AddWithValue("@uemail", txtuemail.Text);

                            using (rdr = cmdd.ExecuteReader())
                            {
                                if (rdr.Read())
                                {
                                    MessageBox.Show("Confirmed!");
                                    this.Hide();
                                    forgotpass2 forgotpass2 = new forgotpass2(txtuname.Text);
                                    forgotpass2.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Information does not exist");
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void forgotpass1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security=true");
            conn.Open();
        }

        private void txtuemail_TextChanged(object sender, EventArgs e)
        {
            // You might want to add some functionality here if needed
        }
    }
}
