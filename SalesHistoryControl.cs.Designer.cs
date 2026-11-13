namespace Sales_Inventory_Management
{
    partial class SalesHistoryControl
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
            lblHistoryHeading = new Label();
            lblHistoryDescription = new Label();
            pnlHistoryFilters = new Panel();
            btnReprintReceipt = new Button();
            btnSearchHistory = new Button();
            btnRefreshHistory = new Button();
            dtpEndDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            txtSearchSaleID = new TextBox();
            lblSearchSaleID = new Label();
            dgvSalesHistory = new DataGridView();
            colHistorySaleID = new DataGridViewTextBoxColumn();
            colHistoryDate = new DataGridViewTextBoxColumn();
            colHistoryTotal = new DataGridViewTextBoxColumn();
            colHistoryPayment = new DataGridViewTextBoxColumn();
            colHistoryItems = new DataGridViewTextBoxColumn();
            lblTransactionDetails = new Label();
            dgvTransactionDetails = new DataGridView();
            colDetailProduct = new DataGridViewTextBoxColumn();
            colDetailQuantity = new DataGridViewTextBoxColumn();
            colDetailUnitPrice = new DataGridViewTextBoxColumn();
            colDetailSubtotal = new DataGridViewTextBoxColumn();
            colDetailProductSKU = new DataGridViewTextBoxColumn();
            pnlHistoryFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionDetails).BeginInit();
            SuspendLayout();
            // 
            // lblHistoryHeading
            // 
            lblHistoryHeading.AutoSize = true;
            lblHistoryHeading.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistoryHeading.ForeColor = Color.MidnightBlue;
            lblHistoryHeading.Location = new Point(25, 20);
            lblHistoryHeading.Name = "lblHistoryHeading";
            lblHistoryHeading.Size = new Size(189, 32);
            lblHistoryHeading.TabIndex = 0;
            lblHistoryHeading.Text = "Sales History";
            // 
            // lblHistoryDescription
            // 
            lblHistoryDescription.AutoSize = true;
            lblHistoryDescription.ForeColor = Color.DimGray;
            lblHistoryDescription.Location = new Point(27, 60);
            lblHistoryDescription.Name = "lblHistoryDescription";
            lblHistoryDescription.Size = new Size(282, 15);
            lblHistoryDescription.TabIndex = 1;
            lblHistoryDescription.Text = "View, search and inspect previous sales transactions.";
            // 
            // pnlHistoryFilters
            // 
            pnlHistoryFilters.BackColor = SystemColors.ActiveCaption;
            pnlHistoryFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlHistoryFilters.Controls.Add(btnReprintReceipt);
            pnlHistoryFilters.Controls.Add(btnSearchHistory);
            pnlHistoryFilters.Controls.Add(btnRefreshHistory);
            pnlHistoryFilters.Controls.Add(dtpEndDate);
            pnlHistoryFilters.Controls.Add(lblEndDate);
            pnlHistoryFilters.Controls.Add(dtpStartDate);
            pnlHistoryFilters.Controls.Add(lblStartDate);
            pnlHistoryFilters.Controls.Add(txtSearchSaleID);
            pnlHistoryFilters.Controls.Add(lblSearchSaleID);
            pnlHistoryFilters.Location = new Point(25, 100);
            pnlHistoryFilters.Name = "pnlHistoryFilters";
            pnlHistoryFilters.Size = new Size(950, 90);
            pnlHistoryFilters.TabIndex = 2;
            // 
            // btnReprintReceipt
            // 
            btnReprintReceipt.BackColor = Color.ForestGreen;
            btnReprintReceipt.Cursor = Cursors.Hand;
            btnReprintReceipt.FlatStyle = FlatStyle.Flat;
            btnReprintReceipt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReprintReceipt.ForeColor = Color.White;
            btnReprintReceipt.Location = new Point(815, 35);
            btnReprintReceipt.Name = "btnReprintReceipt";
            btnReprintReceipt.Size = new Size(110, 32);
            btnReprintReceipt.TabIndex = 6;
            btnReprintReceipt.Text = "Reprint Receipt";
            btnReprintReceipt.UseVisualStyleBackColor = false;
            btnReprintReceipt.Click += btnReprintReceipt_Click;
            // 
            // btnSearchHistory
            // 
            btnSearchHistory.BackColor = Color.MidnightBlue;
            btnSearchHistory.Cursor = Cursors.Hand;
            btnSearchHistory.FlatStyle = FlatStyle.Flat;
            btnSearchHistory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchHistory.ForeColor = Color.White;
            btnSearchHistory.Location = new Point(580, 35);
            btnSearchHistory.Name = "btnSearchHistory";
            btnSearchHistory.Size = new Size(100, 32);
            btnSearchHistory.TabIndex = 10;
            btnSearchHistory.Text = "Search";
            btnSearchHistory.UseVisualStyleBackColor = false;
            btnSearchHistory.Click += btnSearchHistory_Click;
            // 
            // btnRefreshHistory
            // 
            btnRefreshHistory.BackColor = Color.GreenYellow;
            btnRefreshHistory.Cursor = Cursors.Hand;
            btnRefreshHistory.FlatStyle = FlatStyle.Flat;
            btnRefreshHistory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshHistory.ForeColor = Color.White;
            btnRefreshHistory.Location = new Point(700, 35);
            btnRefreshHistory.Name = "btnRefreshHistory";
            btnRefreshHistory.Size = new Size(100, 32);
            btnRefreshHistory.TabIndex = 9;
            btnRefreshHistory.Text = "Refresh";
            btnRefreshHistory.UseVisualStyleBackColor = false;
            btnRefreshHistory.Click += btnRefreshHistory_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(390, 35);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 23);
            dtpEndDate.TabIndex = 8;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = SystemColors.ActiveCaptionText;
            lblEndDate.Location = new Point(390, 12);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(74, 17);
            lblEndDate.TabIndex = 7;
            lblEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(200, 35);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 23);
            dtpStartDate.TabIndex = 6;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = SystemColors.ActiveCaptionText;
            lblStartDate.Location = new Point(200, 12);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(84, 17);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "From Date";
            // 
            // txtSearchSaleID
            // 
            txtSearchSaleID.Location = new Point(15, 35);
            txtSearchSaleID.Name = "txtSearchSaleID";
            txtSearchSaleID.PlaceholderText = "Enter Sale ID";
            txtSearchSaleID.Size = new Size(150, 23);
            txtSearchSaleID.TabIndex = 4;
            // 
            // lblSearchSaleID
            // 
            lblSearchSaleID.AutoSize = true;
            lblSearchSaleID.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchSaleID.ForeColor = SystemColors.ActiveCaptionText;
            lblSearchSaleID.Location = new Point(15, 12);
            lblSearchSaleID.Name = "lblSearchSaleID";
            lblSearchSaleID.Size = new Size(113, 17);
            lblSearchSaleID.TabIndex = 3;
            lblSearchSaleID.Text = "Search SaleID";
            // 
            // dgvSalesHistory
            // 
            dgvSalesHistory.AllowUserToAddRows = false;
            dgvSalesHistory.AllowUserToDeleteRows = false;
            dgvSalesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesHistory.Columns.AddRange(new DataGridViewColumn[] { colHistorySaleID, colHistoryDate, colHistoryTotal, colHistoryPayment, colHistoryItems });
            dgvSalesHistory.Location = new Point(25, 215);
            dgvSalesHistory.MultiSelect = false;
            dgvSalesHistory.Name = "dgvSalesHistory";
            dgvSalesHistory.ReadOnly = true;
            dgvSalesHistory.RowHeadersVisible = false;
            dgvSalesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesHistory.Size = new Size(950, 250);
            dgvSalesHistory.TabIndex = 3;
            dgvSalesHistory.SelectionChanged += dgvSalesHistory_SelectionChanged;
            // 
            // colHistorySaleID
            // 
            colHistorySaleID.DataPropertyName = "SaleID";
            colHistorySaleID.HeaderText = "Sale ID";
            colHistorySaleID.Name = "colHistorySaleID";
            colHistorySaleID.ReadOnly = true;
            // 
            // colHistoryDate
            // 
            colHistoryDate.DataPropertyName = "SaleDate";
            colHistoryDate.HeaderText = "Date & Time";
            colHistoryDate.Name = "colHistoryDate";
            colHistoryDate.ReadOnly = true;
            // 
            // colHistoryTotal
            // 
            colHistoryTotal.DataPropertyName = "TotalAmount";
            colHistoryTotal.HeaderText = "Total (R)";
            colHistoryTotal.Name = "colHistoryTotal";
            colHistoryTotal.ReadOnly = true;
            // 
            // colHistoryPayment
            // 
            colHistoryPayment.DataPropertyName = "PaymentMethods";
            colHistoryPayment.HeaderText = "Payment Method";
            colHistoryPayment.Name = "colHistoryPayment";
            colHistoryPayment.ReadOnly = true;
            // 
            // colHistoryItems
            // 
            colHistoryItems.DataPropertyName = "TotalItems";
            colHistoryItems.HeaderText = "Items";
            colHistoryItems.Name = "colHistoryItems";
            colHistoryItems.ReadOnly = true;
            // 
            // lblTransactionDetails
            // 
            lblTransactionDetails.AutoSize = true;
            lblTransactionDetails.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionDetails.ForeColor = Color.MidnightBlue;
            lblTransactionDetails.Location = new Point(25, 480);
            lblTransactionDetails.Name = "lblTransactionDetails";
            lblTransactionDetails.Size = new Size(272, 22);
            lblTransactionDetails.TabIndex = 4;
            lblTransactionDetails.Text = "Selected Transaction Details";
            // 
            // dgvTransactionDetails
            // 
            dgvTransactionDetails.AllowUserToAddRows = false;
            dgvTransactionDetails.AllowUserToDeleteRows = false;
            dgvTransactionDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionDetails.Columns.AddRange(new DataGridViewColumn[] { colDetailProduct, colDetailQuantity, colDetailUnitPrice, colDetailSubtotal, colDetailProductSKU });
            dgvTransactionDetails.Location = new Point(25, 515);
            dgvTransactionDetails.MultiSelect = false;
            dgvTransactionDetails.Name = "dgvTransactionDetails";
            dgvTransactionDetails.ReadOnly = true;
            dgvTransactionDetails.RowHeadersVisible = false;
            dgvTransactionDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionDetails.Size = new Size(950, 220);
            dgvTransactionDetails.TabIndex = 5;
            // 
            // colDetailProduct
            // 
            colDetailProduct.DataPropertyName = "ProductName";
            colDetailProduct.HeaderText = "Product";
            colDetailProduct.Name = "colDetailProduct";
            colDetailProduct.ReadOnly = true;
            // 
            // colDetailQuantity
            // 
            colDetailQuantity.DataPropertyName = "Quantity";
            colDetailQuantity.HeaderText = "Quantity";
            colDetailQuantity.Name = "colDetailQuantity";
            colDetailQuantity.ReadOnly = true;
            // 
            // colDetailUnitPrice
            // 
            colDetailUnitPrice.DataPropertyName = "UnitPrice";
            colDetailUnitPrice.HeaderText = "Unit Price (R)";
            colDetailUnitPrice.Name = "colDetailUnitPrice";
            colDetailUnitPrice.ReadOnly = true;
            // 
            // colDetailSubtotal
            // 
            colDetailSubtotal.DataPropertyName = "Subtotal";
            colDetailSubtotal.HeaderText = "Subtotal (R)";
            colDetailSubtotal.Name = "colDetailSubtotal";
            colDetailSubtotal.ReadOnly = true;
            // 
            // colDetailProductSKU
            // 
            colDetailProductSKU.DataPropertyName = "SKU";
            colDetailProductSKU.HeaderText = "SKU";
            colDetailProductSKU.Name = "colDetailProductSKU";
            colDetailProductSKU.ReadOnly = true;
            // 
            // SalesHistoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dgvTransactionDetails);
            Controls.Add(lblTransactionDetails);
            Controls.Add(dgvSalesHistory);
            Controls.Add(pnlHistoryFilters);
            Controls.Add(lblHistoryDescription);
            Controls.Add(lblHistoryHeading);
            Name = "SalesHistoryControl";
            Size = new Size(893, 537);
            pnlHistoryFilters.ResumeLayout(false);
            pnlHistoryFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHistoryHeading;
        private Label lblHistoryDescription;
        private Panel pnlHistoryFilters;
        private Label lblStartDate;
        private TextBox txtSearchSaleID;
        private Label lblSearchSaleID;
        private DateTimePicker dtpEndDate;
        private Label lblEndDate;
        private DateTimePicker dtpStartDate;
        private Button btnSearchHistory;
        private Button btnRefreshHistory;
        private DataGridView dgvSalesHistory;
        private DataGridViewTextBoxColumn colHistorySaleID;
        private DataGridViewTextBoxColumn colHistoryDate;
        private DataGridViewTextBoxColumn colHistoryTotal;
        private DataGridViewTextBoxColumn colHistoryPayment;
        private DataGridViewTextBoxColumn colHistoryItems;
        private Label lblTransactionDetails;
        private DataGridView dgvTransactionDetails;
        private DataGridViewTextBoxColumn colDetailProduct;
        private DataGridViewTextBoxColumn colDetailQuantity;
        private DataGridViewTextBoxColumn colDetailUnitPrice;
        private DataGridViewTextBoxColumn colDetailSubtotal;
        private DataGridViewTextBoxColumn colDetailProductSKU;
        private Button btnReprintReceipt;
    }
}
