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
using System.Security.Cryptography;
using System.Drawing.Printing;

namespace WindowsFormsApp2
{
    public partial class InventoryForm : Form
    {
        // Instantiate Database/DataClass
        DataClasses1DataContext productsData = new DataClasses1DataContext();
        
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LoadProducts();
            LoadCategories();
        }

        // Load products from the database and bind to DataGridView
        private void LoadProducts()
        {
            dgvInventory.DataSource = productsData.Products.ToList();
        }

        // Load categories from the database and bind to ComboBox
        private void LoadCategories()
        {
            var categories = productsData.getCategory().Select(c => c.Category).ToList();
            categories.Insert(0, "All Categories");
            cmbCategory.DataSource = categories;
            
        }

        // Add a new product to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text) ||
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
                    db.AddProduct(
                        txtName.Text, 
                        txtCategory.Text, 
                        price, 
                        stock);
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

        // Search products based on user input and update DataGridView
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchResults = productsData.searchProducts(txtSearch.Text).ToList();
            dgvInventory.DataSource = searchResults;
           
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
           
        }


        // Filter products based on selected category and update DataGridView
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedCategory = cmbCategory.SelectedItem.ToString();

            if (selectedCategory == "All Categories" || string.IsNullOrEmpty(selectedCategory))
            {
                LoadProducts();
            }
            else
            {
                var filteredProducts = productsData.Products.Where(p => p.Category == selectedCategory).ToList();
                dgvInventory.DataSource = filteredProducts;
            }


        }


        private void FilterProducts()
        {

            string searchText = txtSearch.Text.Trim();
            string selectedCategory = cmbCategory.SelectedItem?.ToString();

            using (var db = new DataClasses1DataContext())
            {
                var products = db.Products.ToList();

                // 1. Filter by category if a specific category is selected (and not "All Categories")
                if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "All Categories")
                {
                    products = products.Where(p => p.Category == selectedCategory).ToList();
                }

                // 2. Filter by search text in Name
                if (!string.IsNullOrEmpty(searchText))
                {
                    products = products.Where(p => p.Name.Contains(searchText)).ToList();
                }

                // 3. Bind filtered results to grid (hiding ProductID)
                dgvInventory.DataSource = products;
            }

        }





        // =================================================================
        // ==================== Unwanted Features ==========================
        // =================================================================


        // Delete the selected product from the database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["ProductID"].Value);

                using (var db = new DataClasses1DataContext())
                {
                    var itemToDelete = db.Products.FirstOrDefault(p => p.ProductID == selectedId);

                    if (itemToDelete != null)
                    {
                        db.Products.DeleteOnSubmit(itemToDelete);
                        db.SubmitChanges();
                    }
                }

                MessageBox.Show("Product deleted successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts();
            }
            else
            {
                MessageBox.Show("Please select a full row to delete.");
            }
        }

        // Navigate back to the HomeForm
        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm("admin");
            homeForm.Show();
            this.Hide();
        }

    }
}
