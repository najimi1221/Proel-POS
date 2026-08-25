namespace WindowsFormsApp2
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblInventory = new System.Windows.Forms.Label();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panelStock = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.panelPrice.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelTop.Controls.Add(this.lblInventory);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(652, 64);
            this.panelTop.TabIndex = 3;
            // 
            // lblInventory
            // 
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblInventory.ForeColor = System.Drawing.Color.White;
            this.lblInventory.Location = new System.Drawing.Point(16, 16);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(400, 32);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "Inventory";
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelNav.Controls.Add(this.btnDelete);
            this.panelNav.Controls.Add(this.btnEdit);
            this.panelNav.Controls.Add(this.btnBack);
            this.panelNav.Controls.Add(this.btnAdd);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 64);
            this.panelNav.Name = "panelNav";
            this.panelNav.Padding = new System.Windows.Forms.Padding(12);
            this.panelNav.Size = new System.Drawing.Size(180, 386);
            this.panelNav.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 66);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 36);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(186, 275);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.Size = new System.Drawing.Size(458, 164);
            this.dgvInventory.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(120, 5);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(211, 26);
            this.txtPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.Location = new System.Drawing.Point(24, 8);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(203, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 13;
            // 
            // panelPrice
            // 
            this.panelPrice.Controls.Add(this.txtPrice);
            this.panelPrice.Controls.Add(this.lblPrice);
            this.panelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrice.Location = new System.Drawing.Point(180, 150);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(472, 43);
            this.panelPrice.TabIndex = 17;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.txtName);
            this.panelName.Controls.Add(this.lblName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(180, 64);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(472, 43);
            this.panelName.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(120, 5);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 26);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(24, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Item Name:";
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.txtCategory);
            this.panelCategory.Controls.Add(this.lblCategory);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategory.Location = new System.Drawing.Point(180, 107);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(472, 43);
            this.panelCategory.TabIndex = 19;
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(120, 5);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(211, 26);
            this.txtCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategory.Location = new System.Drawing.Point(24, 8);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 20);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category:";
            // 
            // panelStock
            // 
            this.panelStock.Controls.Add(this.txtStock);
            this.panelStock.Controls.Add(this.lblStock);
            this.panelStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStock.Location = new System.Drawing.Point(180, 193);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(472, 43);
            this.panelStock.TabIndex = 19;
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(120, 5);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(211, 26);
            this.txtStock.TabIndex = 6;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStock.Location = new System.Drawing.Point(24, 8);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(54, 20);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock:";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.panelStock);
            this.Controls.Add(this.panelPrice);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelTop);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelPrice;
    }
}