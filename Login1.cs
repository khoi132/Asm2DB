using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm2DB
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void Login1_Load(object sender, EventArgs e)
        {

        }
        //Button Library Staff clicked
        private void btnstaff_Click(object sender, EventArgs e)
        {
            //Hide the Choose the role window
            this.Hide();
            //Declare and show a new window: Admin's login
            stafflogin Stafflogin = new stafflogin();
            Stafflogin.Show();
        }
        //Button Student clicked
        public void btnstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Declare and show a new window: Student's login
            studentlogin studentlogin = new studentlogin();
            studentlogin.Show();
        }
        //Button Guest clicked
        public void btnguest_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Declare and show a new window: Guest interface
            guestinterf guestinterf = new guestinterf();
            guestinterf.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}