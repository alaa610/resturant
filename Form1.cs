using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Admin.Text = " ";
            Password.Text = " ";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Admin.Text== " " && Password.Text== " ") 
            {
                MessageBox.Show("Missing Information");
            }
            else if (Admin.Text=="admin" && Password.Text=="admin")
            {
                Home H = new Home();
                H.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username And Password");
            }
        }

        private void Admin_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Admin_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
