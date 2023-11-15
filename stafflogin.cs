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
    public partial class stafflogin : Form
    {
        //SQL variable declaration
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void stafflogin_Load(object sender, EventArgs e)
        {
            //Connect to SQL Server
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");
        }
        public stafflogin()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Check if the user has entered the information or not
            if (string.IsNullOrWhiteSpace(txtaccount1.Text)
                || string.IsNullOrWhiteSpace(txtpassword1.Text))
            {
                //Notify if there is no information
                MessageBox.Show("Account or password is empty!");
            }
            else
            {
                //create SQL command
                cmdd = new SqlCommand();
                conn.Open();
                cmdd.Connection = conn;
                cmdd.CommandText = "select * from Admins where AdminName='"
                    + txtaccount1.Text + "'AND AdminPass='" + txtpassword1.Text + "'";

                //Check data stored in SQL Server
                rdr = cmdd.ExecuteReader();
                if (rdr.Read())
                {
                    //show success if entered correctly
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    //declare and display the Admin Interface window
                    admininterf admininterf = new admininterf(txtaccount1.Text);
                    admininterf.Show();
                }
                else
                {
                    //show failed if entered wrongly 
                    MessageBox.Show("Wrong Account or Password");
                }
                conn.Close();
            }

        }

        private void txtpassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaccount1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}