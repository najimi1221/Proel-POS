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
    public partial class InventoryForm : Form
    {

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm("admin");
            homeForm.Show();
            this.Hide();

        }


    }
}
