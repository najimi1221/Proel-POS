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


        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        
    }
}