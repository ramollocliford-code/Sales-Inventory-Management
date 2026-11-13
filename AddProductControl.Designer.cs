namespace Sales_Inventory_Management
{
    partial class AddProductControl
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
            lblAddProductHeading = new Label();
            lblAddProductDescription = new Label();
            lblProductName = new Label();
            lblSKU = new Label();
            lblCostPrice = new Label();
            txtCostPrice = new TextBox();
            txtSKU = new TextBox();
            txtProductName = new TextBox();
            txtLowStockThreshold = new TextBox();
            txtInitialQuantity = new TextBox();
            txtSellingPrice = new TextBox();
            lblLowStockThreshold = new Label();
            lblInitialQuantity = new Label();
            lblSellingPrice = new Label();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            btnCancelProduct = new Button();
            btnSaveProduct = new Button();
            SuspendLayout();
            // 
            // lblAddProductHeading
            // 
            lblAddProductHeading.AutoSize = true;
            lblAddProductHeading.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddProductHeading.ForeColor = Color.MidnightBlue;
            lblAddProductHeading.Location = new Point(25, 20);
            lblAddProductHeading.Name = "lblAddProductHeading";
            lblAddProductHeading.Size = new Size(245, 32);
            lblAddProductHeading.TabIndex = 0;
            lblAddProductHeading.Text = "Add New Product";
            // 
            // lblAddProductDescription
            // 
            lblAddProductDescription.AutoSize = true;
            lblAddProductDescription.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddProductDescription.ForeColor = Color.DimGray;
            lblAddProductDescription.Location = new Point(27, 60);
            lblAddProductDescription.Name = "lblAddProductDescription";
            lblAddProductDescription.Size = new Size(333, 15);
            lblAddProductDescription.TabIndex = 1;
            lblAddProductDescription.Text = "Enter the product details and initial stock quantity.";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.ActiveCaptionText;
            lblProductName.Location = new Point(25, 115);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(90, 14);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name";
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSKU.ForeColor = SystemColors.ActiveCaptionText;
            lblSKU.Location = new Point(25, 195);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(92, 14);
            lblSKU.TabIndex = 3;
            lblSKU.Text = "Barcode / SKU";
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCostPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblCostPrice.Location = new Point(25, 275);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(87, 14);
            lblCostPrice.TabIndex = 4;
            lblCostPrice.Text = "Cost Price (R)";
            // 
            // txtCostPrice
            // 
            txtCostPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCostPrice.Location = new Point(25, 300);
            txtCostPrice.Name = "txtCostPrice";
            txtCostPrice.Size = new Size(300, 27);
            txtCostPrice.TabIndex = 5;
            // 
            // txtSKU
            // 
            txtSKU.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSKU.Location = new Point(25, 220);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(300, 27);
            txtSKU.TabIndex = 6;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(25, 140);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 27);
            txtProductName.TabIndex = 7;
            // 
            // txtLowStockThreshold
            // 
            txtLowStockThreshold.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLowStockThreshold.Location = new Point(390, 300);
            txtLowStockThreshold.Name = "txtLowStockThreshold";
            txtLowStockThreshold.Size = new Size(300, 27);
            txtLowStockThreshold.TabIndex = 8;
            // 
            // txtInitialQuantity
            // 
            txtInitialQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInitialQuantity.Location = new Point(390, 220);
            txtInitialQuantity.Name = "txtInitialQuantity";
            txtInitialQuantity.Size = new Size(300, 27);
            txtInitialQuantity.TabIndex = 9;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSellingPrice.Location = new Point(390, 140);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(300, 27);
            txtSellingPrice.TabIndex = 10;
            // 
            // lblLowStockThreshold
            // 
            lblLowStockThreshold.AutoSize = true;
            lblLowStockThreshold.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStockThreshold.ForeColor = SystemColors.ActiveCaptionText;
            lblLowStockThreshold.Location = new Point(390, 275);
            lblLowStockThreshold.Name = "lblLowStockThreshold";
            lblLowStockThreshold.Size = new Size(130, 14);
            lblLowStockThreshold.TabIndex = 11;
            lblLowStockThreshold.Text = "Low-Stock Threshold";
            // 
            // lblInitialQuantity
            // 
            lblInitialQuantity.AutoSize = true;
            lblInitialQuantity.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInitialQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblInitialQuantity.Location = new Point(390, 195);
            lblInitialQuantity.Name = "lblInitialQuantity";
            lblInitialQuantity.Size = new Size(90, 14);
            lblInitialQuantity.TabIndex = 12;
            lblInitialQuantity.Text = "Initial Quantity";
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSellingPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblSellingPrice.Location = new Point(390, 115);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(99, 14);
            lblSellingPrice.TabIndex = 13;
            lblSellingPrice.Text = "Selling Price (R)";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ActiveCaptionText;
            lblCategory.Location = new Point(25, 355);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(61, 14);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(25, 380);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 28);
            cmbCategory.TabIndex = 15;
            // 
            // btnCancelProduct
            // 
            btnCancelProduct.BackColor = Color.Red;
            btnCancelProduct.Cursor = Cursors.Hand;
            btnCancelProduct.FlatStyle = FlatStyle.Flat;
            btnCancelProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelProduct.ForeColor = SystemColors.ControlLightLight;
            btnCancelProduct.Location = new Point(190, 450);
            btnCancelProduct.Name = "btnCancelProduct";
            btnCancelProduct.Size = new Size(120, 42);
            btnCancelProduct.TabIndex = 16;
            btnCancelProduct.Text = "Cancel";
            btnCancelProduct.UseVisualStyleBackColor = false;
            btnCancelProduct.Click += btnCancelProduct_Click;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = Color.ForestGreen;
            btnSaveProduct.Cursor = Cursors.Hand;
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.Location = new Point(25, 450);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(150, 42);
            btnSaveProduct.TabIndex = 17;
            btnSaveProduct.Text = "Save Product";
            btnSaveProduct.UseVisualStyleBackColor = false;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // AddProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSaveProduct);
            Controls.Add(btnCancelProduct);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblSellingPrice);
            Controls.Add(lblInitialQuantity);
            Controls.Add(lblLowStockThreshold);
            Controls.Add(txtSellingPrice);
            Controls.Add(txtInitialQuantity);
            Controls.Add(txtLowStockThreshold);
            Controls.Add(txtProductName);
            Controls.Add(txtSKU);
            Controls.Add(txtCostPrice);
            Controls.Add(lblCostPrice);
            Controls.Add(lblSKU);
            Controls.Add(lblProductName);
            Controls.Add(lblAddProductDescription);
            Controls.Add(lblAddProductHeading);
            Name = "AddProductControl";
            Size = new Size(1076, 636);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddProductHeading;
        private Label lblAddProductDescription;
        private Label lblProductName;
        private Label lblSKU;
        private Label lblCostPrice;
        private TextBox txtCostPrice;
        private TextBox txtSKU;
        private TextBox txtProductName;
        private TextBox txtLowStockThreshold;
        private TextBox txtInitialQuantity;
        private TextBox txtSellingPrice;
        private Label lblLowStockThreshold;
        private Label lblInitialQuantity;
        private Label lblSellingPrice;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Button btnCancelProduct;
        private Button btnSaveProduct;
    }
}
