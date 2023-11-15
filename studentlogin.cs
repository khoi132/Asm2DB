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
    public partial class studentlogin : Form
    {
        SqlConnection conn;
        SqlCommand cmdd;
        SqlDataReader rdr;

        private void studentlogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=Khoi\\SQLEXPRESS03;Database=BTECLibrary;Integrated Security = true");

        }
        public studentlogin()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void lbforgotpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgotpass1 forgotpass1 = new forgotpass1();
            forgotpass1.Show();
        }

        private void lbregister_Click(object sender, EventArgs e)
        {
            register1 register1 = new register1();
            register1.Show();
        }


        public void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtaccount1.Text) || string.IsNullOrWhiteSpace(txtpassword1.Text))
            {
                MessageBox.Show("Username or password is empty!");
                return; // Thoát khỏi sự kiện nếu tài khoản hoặc mật khẩu trống
            }

            try
            {
                conn.Open();
                cmdd = new SqlCommand();
                cmdd.Connection = conn;

                string sqlQuery = "SELECT Users.UserID, Users.UserName, UserPass.UserPass, Roles.RoleID " +
                         "FROM Users " +
                         "JOIN UserPass ON Users.UserID = UserPass.UserID " +
                         "JOIN Roles ON Users.RoleID = Roles.RoleID " +
                         "WHERE Users.UserName = @UserName AND UserPass.UserPass = @UserPass";
                cmdd.CommandText = sqlQuery;

                cmdd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar)).Value = txtaccount1.Text;
                cmdd.Parameters.Add(new SqlParameter("@UserPass", SqlDbType.VarChar)).Value = txtpassword1.Text;

                SqlDataReader rdr = cmdd.ExecuteReader();

                if (rdr.Read())
                {
                    int RoleID = Convert.ToInt32(rdr["RoleID"]);

                    MessageBox.Show("Login successful!");

                    this.Hide();

                    if (RoleID == 1)
                    {
                        // Người dùng có vai trò Admin
                        admininterf admininterf = new admininterf(txtaccount1.Text);
                        admininterf.Show();
                    }
                    else if (RoleID == 2)
                    {
                        // Người dùng có vai trò Người dùng
                        usinterf usinterf = new usinterf(txtaccount1.Text);
                        usinterf.Show();
                    }
                
                    else
                    {
                        // Xử lý trường hợp khác nếu cần thiết
                        MessageBox.Show("Không tìm thấy vai trò người dùng.");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Account or Password");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("System error: " + ex.ToString());
                conn.Close();
            }
        }

        private void txtaccount1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}