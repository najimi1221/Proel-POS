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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text;


            if (string.Equals(user, "admin", StringComparison.OrdinalIgnoreCase) && pass == "password")
            {
                HomeForm homeForm = new HomeForm(user);
                homeForm.Show();

                this.Hide();

   
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Maroon;
                lblMessage.Text = "Invalid username or password.";
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            lblMessage.Text = string.Empty;
            txtUsername.Focus();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
