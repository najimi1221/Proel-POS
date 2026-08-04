using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HomeForm : Form
    {
        private readonly string _username;

        public HomeForm(string username)
        {
            _username = username;
            InitializeComponent();
            lblWelcome.Text = $"Welcome, {_username}";
            lblStatus.Text = $"Signed in: {DateTime.Now:G}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close dashboard to return to login form
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Sales module (not implemented)", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Inventory module (not implemented)", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Reports module (not implemented)", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}