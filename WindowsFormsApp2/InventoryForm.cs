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

        private int selectedProductId = 0; 

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


        // ==================== RETRIEVE ===================================
        private void LoadProducts()
        {
            using (var db = new DataClasses1DataContext())
            {
                dgvInventory.DataSource = db.retrieveData().ToList();
            }

            // Hide ProductID column
            if (dgvInventory.Columns["ProductID"] != null)
            {
                dgvInventory.Columns["ProductID"].Visible = false;
            }

            // Disable direct cell editing in the grid
            dgvInventory.ReadOnly = true;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
        }



        // ==================== CREATE =====================================
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



        // ==================== SEARCH =====================================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            using (var db = new DataClasses1DataContext())
            {
                // Bind search results
                dgvInventory.DataSource = db.searchProducts(txtSearch.Text).ToList();
            }

            // Hide ProductID from the user interface
            if (dgvInventory.Columns["ProductID"] != null)
            {
                dgvInventory.Columns["ProductID"].Visible = false;
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
           
        }

 

        // ==================== UPDATE =====================================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product from the list to edit.",
                                "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    db.updateProducts(selectedProductId, txtName.Text, txtCategory.Text, price, stock);
                }

                MessageBox.Show("Product updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputs();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on column headers or empty rows
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

                // Store ProductID for the Update/Delete operations
                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);

                // Populate input textboxes[cite: 3]
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtCategory.Text = row.Cells["Category"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                txtStock.Text = row.Cells["Stock"].Value?.ToString();
            }
        }

        // ==================== Hard Delete ================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product from the list to delete.",
                                "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to PERMANENTLY delete '{txtName.Text}'?",
                "Confirm Hard Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new DataClasses1DataContext())
                    {
                        db.hardDeleteProduct(selectedProductId);
                    }

                    MessageBox.Show("Product permanently deleted!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearInputs();
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
   


        // ==================== Soft Delete ================================
        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product from the list to archive.",
                                "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to archive '{txtName.Text}'?",
                "Confirm Archive",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new DataClasses1DataContext())
                    {
                        db.softDeleteProduct(selectedProductId);
                    }

                    MessageBox.Show("Product archived successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearInputs();
                    LoadProducts(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null) return;

            string selectedOption = cmbCategory.SelectedItem.ToString();

            using (var db = new DataClasses1DataContext())
            {
                if (selectedOption == "Archived Products")
                {
                    // Load soft-deleted products via your procedure
                    dgvInventory.DataSource = db.showDeletedProducts().ToList();
                }
                else
                {
                    // Load active products via your retrieve procedure
                    dgvInventory.DataSource = db.retrieveData().ToList();
                }
            }

            // Hide ProductID column from the user interface
            if (dgvInventory.Columns["ProductID"] != null)
            {
                dgvInventory.Columns["ProductID"].Visible = false;
            }
        }


        // ==================== Methods =====================================

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Active Products");
            cmbCategory.Items.Add("Archived Products");

            cmbCategory.SelectedIndex = 0; 
        }
        private void ClearInputs()
        {
            selectedProductId = 0;
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }


        // Navigate back to the HomeForm
        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm("admin");
            homeForm.Show();
            this.Hide();
        }




        // =================================================================
        // ==================== Unwanted Features ==========================
        // =================================================================
    }
}
