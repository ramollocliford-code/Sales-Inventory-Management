namespace Sales_Inventory_Management
{
    partial class RestockControl
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
            lblRestockTitle = new Label();
            lblRestockDescrition = new Label();
            lblSelectProduct = new Label();
            cmbProducts = new ComboBox();
            lblRestockQuantity = new Label();
            txtRestockQuantity = new TextBox();
            lblRestockNotes = new Label();
            txtRestockNotes = new TextBox();
            btnCancelRestock = new Button();
            btnRestock = new Button();
            lblCurrentStockTitle = new Label();
            lblCurrentStock = new Label();
            SuspendLayout();
            // 
            // lblRestockTitle
            // 
            lblRestockTitle.AutoSize = true;
            lblRestockTitle.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRestockTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblRestockTitle.Location = new Point(30, 25);
            lblRestockTitle.Name = "lblRestockTitle";
            lblRestockTitle.Size = new Size(217, 28);
            lblRestockTitle.TabIndex = 0;
            lblRestockTitle.Text = "Restock Products";
            // 
            // lblRestockDescrition
            // 
            lblRestockDescrition.AutoSize = true;
            lblRestockDescrition.ForeColor = Color.DimGray;
            lblRestockDescrition.Location = new Point(30, 65);
            lblRestockDescrition.Name = "lblRestockDescrition";
            lblRestockDescrition.Size = new Size(274, 15);
            lblRestockDescrition.TabIndex = 1;
            lblRestockDescrition.Text = "Add stock to an existing product in your inventory.";
            // 
            // lblSelectProduct
            // 
            lblSelectProduct.AutoSize = true;
            lblSelectProduct.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectProduct.ForeColor = SystemColors.ActiveCaptionText;
            lblSelectProduct.Location = new Point(30, 120);
            lblSelectProduct.Name = "lblSelectProduct";
            lblSelectProduct.Size = new Size(92, 14);
            lblSelectProduct.TabIndex = 2;
            lblSelectProduct.Text = "Select Product";
            // 
            // cmbProducts
            // 
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(30, 145);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(350, 23);
            cmbProducts.TabIndex = 3;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // lblRestockQuantity
            // 
            lblRestockQuantity.AutoSize = true;
            lblRestockQuantity.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRestockQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblRestockQuantity.Location = new Point(30, 210);
            lblRestockQuantity.Name = "lblRestockQuantity";
            lblRestockQuantity.Size = new Size(98, 14);
            lblRestockQuantity.TabIndex = 4;
            lblRestockQuantity.Text = "Quantity to Add";
            // 
            // txtRestockQuantity
            // 
            txtRestockQuantity.Location = new Point(30, 235);
            txtRestockQuantity.Name = "txtRestockQuantity";
            txtRestockQuantity.Size = new Size(250, 23);
            txtRestockQuantity.TabIndex = 5;
            // 
            // lblRestockNotes
            // 
            lblRestockNotes.AutoSize = true;
            lblRestockNotes.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRestockNotes.ForeColor = SystemColors.ActiveCaptionText;
            lblRestockNotes.Location = new Point(30, 295);
            lblRestockNotes.Name = "lblRestockNotes";
            lblRestockNotes.Size = new Size(101, 14);
            lblRestockNotes.TabIndex = 6;
            lblRestockNotes.Text = "Notes (Optional)";
            // 
            // txtRestockNotes
            // 
            txtRestockNotes.Location = new Point(30, 320);
            txtRestockNotes.Multiline = true;
            txtRestockNotes.Name = "txtRestockNotes";
            txtRestockNotes.ScrollBars = ScrollBars.Vertical;
            txtRestockNotes.Size = new Size(500, 80);
            txtRestockNotes.TabIndex = 7;
            // 
            // btnCancelRestock
            // 
            btnCancelRestock.BackColor = Color.Red;
            btnCancelRestock.FlatStyle = FlatStyle.Flat;
            btnCancelRestock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelRestock.ForeColor = Color.White;
            btnCancelRestock.Location = new Point(195, 435);
            btnCancelRestock.Name = "btnCancelRestock";
            btnCancelRestock.Size = new Size(100, 40);
            btnCancelRestock.TabIndex = 8;
            btnCancelRestock.Text = "Cancel";
            btnCancelRestock.UseVisualStyleBackColor = false;
            btnCancelRestock.Click += btnCancelRestock_Click;
            // 
            // btnRestock
            // 
            btnRestock.BackColor = Color.ForestGreen;
            btnRestock.FlatStyle = FlatStyle.Flat;
            btnRestock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestock.ForeColor = Color.White;
            btnRestock.Location = new Point(30, 435);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(150, 40);
            btnRestock.TabIndex = 9;
            btnRestock.Text = "Restock Stock";
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            // 
            // lblCurrentStockTitle
            // 
            lblCurrentStockTitle.AutoSize = true;
            lblCurrentStockTitle.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStockTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblCurrentStockTitle.Location = new Point(420, 120);
            lblCurrentStockTitle.Name = "lblCurrentStockTitle";
            lblCurrentStockTitle.Size = new Size(87, 14);
            lblCurrentStockTitle.TabIndex = 10;
            lblCurrentStockTitle.Text = "Current Stock";
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStock.ForeColor = SystemColors.ActiveCaptionText;
            lblCurrentStock.Location = new Point(420, 150);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(102, 14);
            lblCurrentStock.TabIndex = 11;
            lblCurrentStock.Text = "Select a product";
            // 
            // RestockControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCurrentStock);
            Controls.Add(lblCurrentStockTitle);
            Controls.Add(btnRestock);
            Controls.Add(btnCancelRestock);
            Controls.Add(txtRestockNotes);
            Controls.Add(lblRestockNotes);
            Controls.Add(txtRestockQuantity);
            Controls.Add(lblRestockQuantity);
            Controls.Add(cmbProducts);
            Controls.Add(lblSelectProduct);
            Controls.Add(lblRestockDescrition);
            Controls.Add(lblRestockTitle);
            Name = "RestockControl";
            Size = new Size(1026, 554);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRestockTitle;
        private Label lblRestockDescrition;
        private Label lblSelectProduct;
        private ComboBox cmbProducts;
        private Label lblRestockQuantity;
        private TextBox txtRestockQuantity;
        private Label lblRestockNotes;
        private TextBox txtRestockNotes;
        private Button btnCancelRestock;
        private Button btnRestock;
        private Label lblCurrentStockTitle;
        private Label lblCurrentStock;
    }
}
