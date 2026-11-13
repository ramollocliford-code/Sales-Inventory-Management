namespace Sales_Inventory_Management
{
    partial class ProductsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProductsHeading = new Label();
            lblProductsDescription = new Label();
            txtSearchProduct = new TextBox();
            btnSearchProduct = new Button();
            btnAddProduct = new Button();
            dgvProducts = new DataGridView();
            colProductID = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colCostPrice = new DataGridViewTextBoxColumn();
            colSellingPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            btnRestock = new Button();
            btnEditProduct = new Button();
            chkLowStockOnly = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblProductsHeading
            // 
            lblProductsHeading.AutoSize = true;
            lblProductsHeading.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductsHeading.Location = new Point(0, 0);
            lblProductsHeading.Name = "lblProductsHeading";
            lblProductsHeading.Size = new Size(295, 32);
            lblProductsHeading.TabIndex = 0;
            lblProductsHeading.Text = "Product Management";
            // 
            // lblProductsDescription
            // 
            lblProductsDescription.AutoSize = true;
            lblProductsDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductsDescription.ForeColor = Color.DimGray;
            lblProductsDescription.Location = new Point(27, 60);
            lblProductsDescription.Name = "lblProductsDescription";
            lblProductsDescription.Size = new Size(358, 17);
            lblProductsDescription.TabIndex = 1;
            lblProductsDescription.Text = "Add products, manage prices, and maintain product details.";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchProduct.Location = new Point(25, 105);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.PlaceholderText = "Search by product name or SKU...";
            txtSearchProduct.Size = new Size(350, 23);
            txtSearchProduct.TabIndex = 2;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.MidnightBlue;
            btnSearchProduct.Cursor = Cursors.Hand;
            btnSearchProduct.FlatStyle = FlatStyle.Flat;
            btnSearchProduct.ForeColor = Color.White;
            btnSearchProduct.Location = new Point(390, 104);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(90, 32);
            btnSearchProduct.TabIndex = 3;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.ForestGreen;
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(800, 100);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(140, 38);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "+ Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductID, colProductName, colCategory, colCostPrice, colSellingPrice, colQuantity });
            dgvProducts.Location = new Point(25, 160);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ShowRowErrors = false;
            dgvProducts.Size = new Size(950, 400);
            dgvProducts.TabIndex = 5;
            // 
            // colProductID
            // 
            colProductID.HeaderText = "Product ID";
            colProductID.Name = "colProductID";
            colProductID.ReadOnly = true;
            // 
            // colProductName
            // 
            colProductName.HeaderText = "Product Name";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colCostPrice
            // 
            colCostPrice.HeaderText = "Cost Price (R)";
            colCostPrice.Name = "colCostPrice";
            colCostPrice.ReadOnly = true;
            // 
            // colSellingPrice
            // 
            colSellingPrice.HeaderText = "Selling Price (R)";
            colSellingPrice.Name = "colSellingPrice";
            colSellingPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity in Stock";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // btnRestock
            // 
            btnRestock.BackColor = Color.White;
            btnRestock.FlatStyle = FlatStyle.Flat;
            btnRestock.Location = new Point(628, 101);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(150, 35);
            btnRestock.TabIndex = 6;
            btnRestock.Text = "Restock Products";
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.White;
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Location = new Point(502, 100);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(120, 35);
            btnEditProduct.TabIndex = 7;
            btnEditProduct.Text = "Edit Product";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // chkLowStockOnly
            // 
            chkLowStockOnly.AutoSize = true;
            chkLowStockOnly.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLowStockOnly.Location = new Point(502, 61);
            chkLowStockOnly.Name = "chkLowStockOnly";
            chkLowStockOnly.Size = new Size(171, 24);
            chkLowStockOnly.TabIndex = 8;
            chkLowStockOnly.Text = "Show Low-Stock Only";
            chkLowStockOnly.UseVisualStyleBackColor = true;
            chkLowStockOnly.CheckedChanged += chkLowStockOnly_CheckedChanged;
            // 
            // ProductsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(chkLowStockOnly);
            Controls.Add(btnEditProduct);
            Controls.Add(btnRestock);
            Controls.Add(dgvProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(btnSearchProduct);
            Controls.Add(txtSearchProduct);
            Controls.Add(lblProductsDescription);
            Controls.Add(lblProductsHeading);
            ForeColor = Color.MidnightBlue;
            Location = new Point(25, 20);
            Name = "ProductsControl";
            Size = new Size(998, 564);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductsHeading;
        private Label lblProductsDescription;
        private TextBox txtSearchProduct;
        private Button btnSearchProduct;
        private Button btnAddProduct;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductID;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colCostPrice;
        private DataGridViewTextBoxColumn colSellingPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private Button btnRestock;
        private Button btnEditProduct;
        private CheckBox chkLowStockOnly;
    }
}
