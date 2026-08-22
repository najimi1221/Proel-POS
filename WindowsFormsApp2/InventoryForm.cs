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

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                !decimal.TryParse(txtPrice.Text, out decimal price) ||
                !int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Please enter valid details. Price and Stock must be numbers.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    Product newProduct = new Product
                    {
                        ProductName = txtName.Text.Trim(),
                        Category = txtCategory.Text.Trim(),
                        Price = price,               
                        StockQuantity = stock       
                    };

                    db.Products.InsertOnSubmit(newProduct);
                    db.SubmitChanges();
                }

                MessageBox.Show("Product added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm("admin");
            homeForm.Show();
            this.Hide();

        }


    }
}
