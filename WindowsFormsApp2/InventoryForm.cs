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
using System.Data.Linq;
using WindowsFormsApp2.Database;

namespace WindowsFormsApp2
{
    public partial class InventoryForm : Form
    {
        DataClasses1DataContext productsData = new DataClasses1DataContext();
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
            productsData = new DataClasses1DataContext();

            dgvInventory.DataSource = productsData.Products;

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
