namespace Sales_Inventory_Management
{
    partial class EditProductControl
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
            lblProductName = new Label();
            lblEditTitle = new Label();
            lblSKU = new Label();
            txtProductName = new TextBox();
            txtSKU = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblCostPrice = new Label();
            txtCostPrice = new TextBox();
            lblSellingPrice = new Label();
            txtSellingPrice = new TextBox();
            lblLowStockThreshold = new Label();
            txtLowStockThreshold = new TextBox();
            btnCancelEdit = new Button();
            btnSaveChanges = new Button();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.ActiveCaptionText;
            lblProductName.Location = new Point(30, 90);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // lblEditTitle
            // 
            lblEditTitle.AutoSize = true;
            lblEditTitle.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEditTitle.Location = new Point(30, 25);
            lblEditTitle.Name = "lblEditTitle";
            lblEditTitle.Size = new Size(156, 28);
            lblEditTitle.TabIndex = 1;
            lblEditTitle.Text = "Edit Product";
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSKU.ForeColor = SystemColors.ActiveCaptionText;
            lblSKU.Location = new Point(30, 160);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(36, 15);
            lblSKU.TabIndex = 2;
            lblSKU.Text = "SKU";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(30, 115);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(176, 23);
            txtProductName.TabIndex = 3;
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(30, 185);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(123, 23);
            txtSKU.TabIndex = 4;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ActiveCaptionText;
            lblCategory.Location = new Point(30, 230);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(67, 15);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(30, 255);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(250, 23);
            cmbCategory.TabIndex = 6;
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCostPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblCostPrice.Location = new Point(30, 300);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(94, 15);
            lblCostPrice.TabIndex = 7;
            lblCostPrice.Text = "CostPrice (R)";
            // 
            // txtCostPrice
            // 
            txtCostPrice.Location = new Point(30, 325);
            txtCostPrice.Name = "txtCostPrice";
            txtCostPrice.Size = new Size(123, 23);
            txtCostPrice.TabIndex = 8;
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSellingPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblSellingPrice.Location = new Point(320, 300);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(109, 15);
            lblSellingPrice.TabIndex = 9;
            lblSellingPrice.Text = "SellingPrice (R)";
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(320, 325);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(100, 23);
            txtSellingPrice.TabIndex = 10;
            // 
            // lblLowStockThreshold
            // 
            lblLowStockThreshold.AutoSize = true;
            lblLowStockThreshold.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStockThreshold.ForeColor = SystemColors.ActiveCaptionText;
            lblLowStockThreshold.Location = new Point(30, 375);
            lblLowStockThreshold.Name = "lblLowStockThreshold";
            lblLowStockThreshold.Size = new Size(142, 15);
            lblLowStockThreshold.TabIndex = 11;
            lblLowStockThreshold.Text = "Low Stock Threshold";
            // 
            // txtLowStockThreshold
            // 
            txtLowStockThreshold.Location = new Point(30, 400);
            txtLowStockThreshold.Name = "txtLowStockThreshold";
            txtLowStockThreshold.Size = new Size(123, 23);
            txtLowStockThreshold.TabIndex = 12;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.Red;
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelEdit.ForeColor = Color.White;
            btnCancelEdit.Location = new Point(191, 468);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(150, 40);
            btnCancelEdit.TabIndex = 13;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.ForestGreen;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(3, 468);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(150, 40);
            btnSaveChanges.TabIndex = 14;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // EditProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSaveChanges);
            Controls.Add(btnCancelEdit);
            Controls.Add(txtLowStockThreshold);
            Controls.Add(lblLowStockThreshold);
            Controls.Add(txtSellingPrice);
            Controls.Add(lblSellingPrice);
            Controls.Add(txtCostPrice);
            Controls.Add(lblCostPrice);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtSKU);
            Controls.Add(txtProductName);
            Controls.Add(lblSKU);
            Controls.Add(lblEditTitle);
            Controls.Add(lblProductName);
            Name = "EditProductControl";
            Size = new Size(1314, 652);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblEditTitle;
        private Label lblSKU;
        private TextBox txtProductName;
        private TextBox txtSKU;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblCostPrice;
        private TextBox txtCostPrice;
        private Label lblSellingPrice;
        private TextBox txtSellingPrice;
        private Label lblLowStockThreshold;
        private TextBox txtLowStockThreshold;
        private Button btnCancelEdit;
        private Button btnSaveChanges;
    }
}
