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

        string connectionString =
            "Data Source=JEBBY\\SQLEXPRESS;Initial Catalog=PosDatabase;Integrated Security=True;TrustServerCertificate=True";
        public InventoryForm()
        {
            InitializeComponent();
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

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvInventory.DataSource = table;
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
