namespace Sales_Inventory_Management
{
    partial class InventoryControl
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
            lblInventoryDescription = new Label();
            lblInventoryHeading = new Label();
            pnlTotalStock = new Panel();
            lblTotalStockTitle = new Label();
            lblTotalStockValue = new Label();
            pnlLowStock = new Panel();
            lblLowStockValue = new Label();
            lblLowStockTitle = new Label();
            pnlOutOfStock = new Panel();
            lblOutOfStockTitle = new Label();
            lblOutOfStockValue = new Label();
            lblSearchInventory = new Label();
            txtSearchInventory = new TextBox();
            btnRefreshInventory = new Button();
            btnSearchInventory = new Button();
            lblStockOverview = new Label();
            dgvInventory = new DataGridView();
            colInventoryProductID = new DataGridViewTextBoxColumn();
            colInventoryProductName = new DataGridViewTextBoxColumn();
            colInventorySKU = new DataGridViewTextBoxColumn();
            colInventoryCategory = new DataGridViewTextBoxColumn();
            colInventoryQuantity = new DataGridViewTextBoxColumn();
            colInventoryThreshold = new DataGridViewTextBoxColumn();
            colInventoryStatus = new DataGridViewTextBoxColumn();
            lblStockMovementsHeading = new Label();
            dgvStockMovements = new DataGridView();
            colMovementID = new DataGridViewTextBoxColumn();
            colMovementProduct = new DataGridViewTextBoxColumn();
            colMovementType = new DataGridViewTextBoxColumn();
            colMovementQuantity = new DataGridViewTextBoxColumn();
            colQuantityAfter = new DataGridViewTextBoxColumn();
            colMovementDate = new DataGridViewTextBoxColumn();
            colMovementNotes = new DataGridViewTextBoxColumn();
            btnRecordDamage = new Button();
            btnAdjustStock = new Button();
            pnlTotalStock.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlOutOfStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockMovements).BeginInit();
            SuspendLayout();
            // 
            // lblInventoryDescription
            // 
            lblInventoryDescription.AutoSize = true;
            lblInventoryDescription.ForeColor = Color.DimGray;
            lblInventoryDescription.Location = new Point(27, 60);
            lblInventoryDescription.Name = "lblInventoryDescription";
            lblInventoryDescription.Size = new Size(287, 15);
            lblInventoryDescription.TabIndex = 0;
            lblInventoryDescription.Text = "Monitor stock levels and track inventory movements.";
            // 
            // lblInventoryHeading
            // 
            lblInventoryHeading.AutoSize = true;
            lblInventoryHeading.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventoryHeading.ForeColor = Color.MidnightBlue;
            lblInventoryHeading.Location = new Point(25, 20);
            lblInventoryHeading.Name = "lblInventoryHeading";
            lblInventoryHeading.Size = new Size(314, 32);
            lblInventoryHeading.TabIndex = 1;
            lblInventoryHeading.Text = "Inventory Management";
            // 
            // pnlTotalStock
            // 
            pnlTotalStock.BackColor = Color.White;
            pnlTotalStock.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalStock.Controls.Add(lblTotalStockTitle);
            pnlTotalStock.Controls.Add(lblTotalStockValue);
            pnlTotalStock.Location = new Point(25, 110);
            pnlTotalStock.Name = "pnlTotalStock";
            pnlTotalStock.Size = new Size(220, 130);
            pnlTotalStock.TabIndex = 2;
            // 
            // lblTotalStockTitle
            // 
            lblTotalStockTitle.AutoSize = true;
            lblTotalStockTitle.ForeColor = Color.DimGray;
            lblTotalStockTitle.Location = new Point(15, 15);
            lblTotalStockTitle.Name = "lblTotalStockTitle";
            lblTotalStockTitle.Size = new Size(94, 15);
            lblTotalStockTitle.TabIndex = 1;
            lblTotalStockTitle.Text = "Total Stock units";
            // 
            // lblTotalStockValue
            // 
            lblTotalStockValue.AutoSize = true;
            lblTotalStockValue.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalStockValue.ForeColor = Color.MidnightBlue;
            lblTotalStockValue.Location = new Point(15, 45);
            lblTotalStockValue.Name = "lblTotalStockValue";
            lblTotalStockValue.Size = new Size(39, 47);
            lblTotalStockValue.TabIndex = 0;
            lblTotalStockValue.Text = "0";
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStock.Controls.Add(lblLowStockValue);
            pnlLowStock.Controls.Add(lblLowStockTitle);
            pnlLowStock.Location = new Point(289, 110);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(220, 130);
            pnlLowStock.TabIndex = 2;
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.AutoSize = true;
            lblLowStockValue.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStockValue.ForeColor = Color.Firebrick;
            lblLowStockValue.Location = new Point(15, 45);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(39, 47);
            lblLowStockValue.TabIndex = 1;
            lblLowStockValue.Text = "0";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.ForeColor = Color.DimGray;
            lblLowStockTitle.Location = new Point(15, 15);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(111, 15);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "Low Stock Products";
            // 
            // pnlOutOfStock
            // 
            pnlOutOfStock.BackColor = Color.White;
            pnlOutOfStock.BorderStyle = BorderStyle.FixedSingle;
            pnlOutOfStock.Controls.Add(lblOutOfStockTitle);
            pnlOutOfStock.Controls.Add(lblOutOfStockValue);
            pnlOutOfStock.Location = new Point(563, 110);
            pnlOutOfStock.Name = "pnlOutOfStock";
            pnlOutOfStock.Size = new Size(220, 130);
            pnlOutOfStock.TabIndex = 2;
            // 
            // lblOutOfStockTitle
            // 
            lblOutOfStockTitle.AutoSize = true;
            lblOutOfStockTitle.ForeColor = Color.DimGray;
            lblOutOfStockTitle.Location = new Point(15, 15);
            lblOutOfStockTitle.Name = "lblOutOfStockTitle";
            lblOutOfStockTitle.Size = new Size(73, 15);
            lblOutOfStockTitle.TabIndex = 1;
            lblOutOfStockTitle.Text = "Out of Stock";
            // 
            // lblOutOfStockValue
            // 
            lblOutOfStockValue.AutoSize = true;
            lblOutOfStockValue.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutOfStockValue.ForeColor = Color.DarkRed;
            lblOutOfStockValue.Location = new Point(15, 45);
            lblOutOfStockValue.Name = "lblOutOfStockValue";
            lblOutOfStockValue.Size = new Size(39, 47);
            lblOutOfStockValue.TabIndex = 0;
            lblOutOfStockValue.Text = "0";
            // 
            // lblSearchInventory
            // 
            lblSearchInventory.AutoSize = true;
            lblSearchInventory.BackColor = Color.Transparent;
            lblSearchInventory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchInventory.ForeColor = Color.MidnightBlue;
            lblSearchInventory.Location = new Point(25, 265);
            lblSearchInventory.Name = "lblSearchInventory";
            lblSearchInventory.Size = new Size(127, 21);
            lblSearchInventory.TabIndex = 2;
            lblSearchInventory.Text = "Search Inventory";
            // 
            // txtSearchInventory
            // 
            txtSearchInventory.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchInventory.Location = new Point(25, 300);
            txtSearchInventory.Name = "txtSearchInventory";
            txtSearchInventory.Size = new Size(450, 25);
            txtSearchInventory.TabIndex = 3;
            // 
            // btnRefreshInventory
            // 
            btnRefreshInventory.BackColor = Color.ForestGreen;
            btnRefreshInventory.Cursor = Cursors.Hand;
            btnRefreshInventory.FlatStyle = FlatStyle.Flat;
            btnRefreshInventory.ForeColor = Color.White;
            btnRefreshInventory.Location = new Point(600, 297);
            btnRefreshInventory.Name = "btnRefreshInventory";
            btnRefreshInventory.RightToLeft = RightToLeft.No;
            btnRefreshInventory.Size = new Size(100, 38);
            btnRefreshInventory.TabIndex = 4;
            btnRefreshInventory.Text = "Refresh";
            btnRefreshInventory.UseVisualStyleBackColor = false;
            btnRefreshInventory.Click += btnRefreshInventory_Click;
            // 
            // btnSearchInventory
            // 
            btnSearchInventory.BackColor = Color.MidnightBlue;
            btnSearchInventory.Cursor = Cursors.Hand;
            btnSearchInventory.FlatStyle = FlatStyle.Flat;
            btnSearchInventory.ForeColor = Color.White;
            btnSearchInventory.Location = new Point(490, 297);
            btnSearchInventory.Name = "btnSearchInventory";
            btnSearchInventory.Size = new Size(100, 38);
            btnSearchInventory.TabIndex = 5;
            btnSearchInventory.Text = "Search";
            btnSearchInventory.UseVisualStyleBackColor = false;
            btnSearchInventory.Click += btnSearchInventory_Click;
            // 
            // lblStockOverview
            // 
            lblStockOverview.AutoSize = true;
            lblStockOverview.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockOverview.ForeColor = Color.MidnightBlue;
            lblStockOverview.Location = new Point(25, 355);
            lblStockOverview.Name = "lblStockOverview";
            lblStockOverview.Size = new Size(153, 22);
            lblStockOverview.TabIndex = 6;
            lblStockOverview.Text = "Stock Overview";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colInventoryProductID, colInventoryProductName, colInventorySKU, colInventoryCategory, colInventoryQuantity, colInventoryThreshold, colInventoryStatus });
            dgvInventory.Location = new Point(25, 390);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(950, 246);
            dgvInventory.TabIndex = 7;
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
            // 
            // colInventoryProductID
            // 
            colInventoryProductID.DataPropertyName = "ProductID";
            colInventoryProductID.HeaderText = "ProductID";
            colInventoryProductID.Name = "colInventoryProductID";
            colInventoryProductID.ReadOnly = true;
            // 
            // colInventoryProductName
            // 
            colInventoryProductName.DataPropertyName = "ProductName";
            colInventoryProductName.HeaderText = "Product Name";
            colInventoryProductName.Name = "colInventoryProductName";
            colInventoryProductName.ReadOnly = true;
            // 
            // colInventorySKU
            // 
            colInventorySKU.DataPropertyName = "SKU";
            colInventorySKU.HeaderText = "SKU";
            colInventorySKU.Name = "colInventorySKU";
            colInventorySKU.ReadOnly = true;
            // 
            // colInventoryCategory
            // 
            colInventoryCategory.DataPropertyName = "CategoryName";
            colInventoryCategory.HeaderText = "Category";
            colInventoryCategory.Name = "colInventoryCategory";
            colInventoryCategory.ReadOnly = true;
            // 
            // colInventoryQuantity
            // 
            colInventoryQuantity.DataPropertyName = "QuantityInStock";
            colInventoryQuantity.HeaderText = "Current Stock";
            colInventoryQuantity.Name = "colInventoryQuantity";
            colInventoryQuantity.ReadOnly = true;
            // 
            // colInventoryThreshold
            // 
            colInventoryThreshold.DataPropertyName = "LowStockThreshold";
            colInventoryThreshold.HeaderText = "Low Stock Threshold";
            colInventoryThreshold.Name = "colInventoryThreshold";
            colInventoryThreshold.ReadOnly = true;
            // 
            // colInventoryStatus
            // 
            colInventoryStatus.DataPropertyName = "StockStatus";
            colInventoryStatus.HeaderText = "Status";
            colInventoryStatus.Name = "colInventoryStatus";
            colInventoryStatus.ReadOnly = true;
            // 
            // lblStockMovementsHeading
            // 
            lblStockMovementsHeading.AutoSize = true;
            lblStockMovementsHeading.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockMovementsHeading.ForeColor = Color.MidnightBlue;
            lblStockMovementsHeading.Location = new Point(25, 650);
            lblStockMovementsHeading.Name = "lblStockMovementsHeading";
            lblStockMovementsHeading.Size = new Size(242, 22);
            lblStockMovementsHeading.TabIndex = 8;
            lblStockMovementsHeading.Text = "Recent Stock Movements";
            // 
            // dgvStockMovements
            // 
            dgvStockMovements.AllowUserToAddRows = false;
            dgvStockMovements.AllowUserToDeleteRows = false;
            dgvStockMovements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockMovements.BackgroundColor = Color.White;
            dgvStockMovements.BorderStyle = BorderStyle.None;
            dgvStockMovements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockMovements.Columns.AddRange(new DataGridViewColumn[] { colMovementID, colMovementProduct, colMovementType, colMovementQuantity, colQuantityAfter, colMovementDate, colMovementNotes });
            dgvStockMovements.Location = new Point(25, 685);
            dgvStockMovements.MultiSelect = false;
            dgvStockMovements.Name = "dgvStockMovements";
            dgvStockMovements.ReadOnly = true;
            dgvStockMovements.RowHeadersVisible = false;
            dgvStockMovements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockMovements.Size = new Size(950, 230);
            dgvStockMovements.TabIndex = 9;
            // 
            // colMovementID
            // 
            colMovementID.HeaderText = "MovementID";
            colMovementID.Name = "colMovementID";
            colMovementID.ReadOnly = true;
            // 
            // colMovementProduct
            // 
            colMovementProduct.HeaderText = "Product";
            colMovementProduct.Name = "colMovementProduct";
            colMovementProduct.ReadOnly = true;
            // 
            // colMovementType
            // 
            colMovementType.HeaderText = "Movement Type";
            colMovementType.Name = "colMovementType";
            colMovementType.ReadOnly = true;
            // 
            // colMovementQuantity
            // 
            colMovementQuantity.HeaderText = "Quantity Change";
            colMovementQuantity.Name = "colMovementQuantity";
            colMovementQuantity.ReadOnly = true;
            // 
            // colQuantityAfter
            // 
            colQuantityAfter.HeaderText = "Stock After";
            colQuantityAfter.Name = "colQuantityAfter";
            colQuantityAfter.ReadOnly = true;
            // 
            // colMovementDate
            // 
            colMovementDate.HeaderText = "Date & Time";
            colMovementDate.Name = "colMovementDate";
            colMovementDate.ReadOnly = true;
            // 
            // colMovementNotes
            // 
            colMovementNotes.HeaderText = "Notes";
            colMovementNotes.Name = "colMovementNotes";
            colMovementNotes.ReadOnly = true;
            // 
            // btnRecordDamage
            // 
            btnRecordDamage.BackColor = Color.Firebrick;
            btnRecordDamage.Cursor = Cursors.Hand;
            btnRecordDamage.FlatStyle = FlatStyle.Flat;
            btnRecordDamage.ForeColor = Color.White;
            btnRecordDamage.Location = new Point(821, 293);
            btnRecordDamage.Name = "btnRecordDamage";
            btnRecordDamage.Size = new Size(100, 41);
            btnRecordDamage.TabIndex = 10;
            btnRecordDamage.Text = "Record Damaged Goods";
            btnRecordDamage.UseVisualStyleBackColor = false;
            btnRecordDamage.Click += btnRecordDamage_Click;
            // 
            // btnAdjustStock
            // 
            btnAdjustStock.BackColor = Color.Gold;
            btnAdjustStock.Cursor = Cursors.Hand;
            btnAdjustStock.FlatStyle = FlatStyle.Flat;
            btnAdjustStock.ForeColor = Color.White;
            btnAdjustStock.Location = new Point(706, 296);
            btnAdjustStock.Name = "btnAdjustStock";
            btnAdjustStock.Size = new Size(100, 38);
            btnAdjustStock.TabIndex = 11;
            btnAdjustStock.Text = "Adjust Stock";
            btnAdjustStock.UseVisualStyleBackColor = false;
            btnAdjustStock.Click += btnAdjustStock_Click;
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btnAdjustStock);
            Controls.Add(btnRecordDamage);
            Controls.Add(dgvStockMovements);
            Controls.Add(lblStockMovementsHeading);
            Controls.Add(dgvInventory);
            Controls.Add(lblStockOverview);
            Controls.Add(btnSearchInventory);
            Controls.Add(btnRefreshInventory);
            Controls.Add(txtSearchInventory);
            Controls.Add(lblSearchInventory);
            Controls.Add(pnlOutOfStock);
            Controls.Add(pnlLowStock);
            Controls.Add(pnlTotalStock);
            Controls.Add(lblInventoryHeading);
            Controls.Add(lblInventoryDescription);
            Name = "InventoryControl";
            Size = new Size(2500, 1018);
            pnlTotalStock.ResumeLayout(false);
            pnlTotalStock.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlOutOfStock.ResumeLayout(false);
            pnlOutOfStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockMovements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventoryDescription;
        private Label lblInventoryHeading;
        private Panel pnlTotalStock;
        private Label lblTotalStockTitle;
        private Label lblTotalStockValue;
        private Panel pnlLowStock;
        private Label lblLowStockValue;
        private Label lblLowStockTitle;
        private Panel pnlOutOfStock;
        private Label lblOutOfStockTitle;
        private Label lblOutOfStockValue;
        private Label lblSearchInventory;
        private TextBox txtSearchInventory;
        private Button btnRefreshInventory;
        private Button btnSearchInventory;
        private Label lblStockOverview;
        private DataGridView dgvInventory;
        private Label lblStockMovementsHeading;
        private DataGridView dgvStockMovements;
        private DataGridViewTextBoxColumn colMovementID;
        private DataGridViewTextBoxColumn colMovementProduct;
        private DataGridViewTextBoxColumn colMovementType;
        private DataGridViewTextBoxColumn colMovementQuantity;
        private DataGridViewTextBoxColumn colQuantityAfter;
        private DataGridViewTextBoxColumn colMovementDate;
        private DataGridViewTextBoxColumn colMovementNotes;
        private DataGridViewTextBoxColumn colInventoryProductID;
        private DataGridViewTextBoxColumn colInventoryProductName;
        private DataGridViewTextBoxColumn colInventorySKU;
        private DataGridViewTextBoxColumn colInventoryCategory;
        private DataGridViewTextBoxColumn colInventoryQuantity;
        private DataGridViewTextBoxColumn colInventoryThreshold;
        private DataGridViewTextBoxColumn colInventoryStatus;
        private Button btnRecordDamage;
        private Button btnAdjustStock;
    }
}
