namespace Sales_Inventory_Management
{
    partial class Dashboard
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
            Button btnSalesHistory;
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnRecordSale = new Button();
            btnInventory = new Button();
            btnReports = new Button();
            btnProducts = new Button();
            btnSettings = new Button();
            btnDashboard = new Button();
            lblAppName = new Label();
            pnlHeader = new Panel();
            label1 = new Label();
            lblPageTitle = new Label();
            pnlMainContent = new Panel();
            dgvRecentSales = new DataGridView();
            colSaleID = new DataGridViewTextBoxColumn();
            colProduct = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colSaleDate = new DataGridViewTextBoxColumn();
            lblRecentSalesHeading = new Label();
            pnlInventoryValue = new Panel();
            label2 = new Label();
            lblInventoryValueAmount = new Label();
            lblInventoryValueTitle = new Label();
            pnlTodaysSales = new Panel();
            lblTodaysSalesValue = new Label();
            lblTodayssalesTitle = new Label();
            pnlLowStoc = new Panel();
            lblLowStockValue = new Label();
            lblLowStockItemsTitle = new Label();
            pnlTotalProducts = new Panel();
            lblTotalProductsValue = new Label();
            lblTotalProductsTitle = new Label();
            lblOverviewDescription = new Label();
            lblOverviewHeading = new Label();
            btnSalesHistory = new Button();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).BeginInit();
            pnlInventoryValue.SuspendLayout();
            pnlTodaysSales.SuspendLayout();
            pnlLowStoc.SuspendLayout();
            pnlTotalProducts.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalesHistory
            // 
            btnSalesHistory.Cursor = Cursors.Hand;
            btnSalesHistory.FlatAppearance.BorderSize = 0;
            btnSalesHistory.FlatStyle = FlatStyle.Flat;
            btnSalesHistory.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalesHistory.ForeColor = SystemColors.ControlLightLight;
            btnSalesHistory.Location = new Point(0, 287);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Size = new Size(240, 45);
            btnSalesHistory.TabIndex = 5;
            btnSalesHistory.Text = "Sales History";
            btnSalesHistory.UseVisualStyleBackColor = true;
            btnSalesHistory.Click += btnSalesHistory_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.MidnightBlue;
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnRecordSale);
            pnlSidebar.Controls.Add(btnInventory);
            pnlSidebar.Controls.Add(btnSalesHistory);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnProducts);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(245, 661);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(1, 613);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(240, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRecordSale
            // 
            btnRecordSale.Cursor = Cursors.Hand;
            btnRecordSale.FlatAppearance.BorderSize = 0;
            btnRecordSale.FlatStyle = FlatStyle.Flat;
            btnRecordSale.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecordSale.ForeColor = SystemColors.ControlLightLight;
            btnRecordSale.Location = new Point(0, 236);
            btnRecordSale.Name = "btnRecordSale";
            btnRecordSale.Size = new Size(240, 45);
            btnRecordSale.TabIndex = 7;
            btnRecordSale.Text = "Record Sale";
            btnRecordSale.UseVisualStyleBackColor = true;
            btnRecordSale.Click += btnRecordSale_Click;
            // 
            // btnInventory
            // 
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = SystemColors.ControlLightLight;
            btnInventory.Location = new Point(0, 185);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(240, 45);
            btnInventory.TabIndex = 6;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = SystemColors.ControlLightLight;
            btnReports.Location = new Point(0, 338);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(240, 45);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnProducts
            // 
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = SystemColors.ControlLightLight;
            btnProducts.Location = new Point(0, 134);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(240, 45);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = SystemColors.ControlLightLight;
            btnSettings.Location = new Point(3, 389);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(240, 45);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ControlLightLight;
            btnDashboard.Location = new Point(0, 83);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(240, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblAppName
            // 
            lblAppName.Dock = DockStyle.Top;
            lblAppName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = SystemColors.ControlLightLight;
            lblAppName.Location = new Point(0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(245, 80);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "TUCK SHOP";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ControlLightLight;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(245, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1108, 70);
            pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(971, 25);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Welcome, Owner";
            // 
            // lblPageTitle
            // 
            lblPageTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.MidnightBlue;
            lblPageTitle.Location = new Point(28, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(222, 24);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard Overview";
            // 
            // pnlMainContent
            // 
            pnlMainContent.AutoScroll = true;
            pnlMainContent.Controls.Add(dgvRecentSales);
            pnlMainContent.Controls.Add(lblRecentSalesHeading);
            pnlMainContent.Controls.Add(pnlInventoryValue);
            pnlMainContent.Controls.Add(pnlTodaysSales);
            pnlMainContent.Controls.Add(pnlLowStoc);
            pnlMainContent.Controls.Add(pnlTotalProducts);
            pnlMainContent.Controls.Add(lblOverviewDescription);
            pnlMainContent.Controls.Add(lblOverviewHeading);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.ForeColor = Color.WhiteSmoke;
            pnlMainContent.Location = new Point(245, 70);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new Padding(20);
            pnlMainContent.Size = new Size(1108, 591);
            pnlMainContent.TabIndex = 2;
            pnlMainContent.Paint += pnlMainContent_Paint;
            // 
            // dgvRecentSales
            // 
            dgvRecentSales.AllowUserToAddRows = false;
            dgvRecentSales.AllowUserToDeleteRows = false;
            dgvRecentSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentSales.BackgroundColor = Color.White;
            dgvRecentSales.BorderStyle = BorderStyle.None;
            dgvRecentSales.ColumnHeadersHeight = 40;
            dgvRecentSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecentSales.Columns.AddRange(new DataGridViewColumn[] { colSaleID, colProduct, colQuantity, colTotal, colSaleDate });
            dgvRecentSales.EnableHeadersVisualStyles = false;
            dgvRecentSales.GridColor = Color.Gainsboro;
            dgvRecentSales.Location = new Point(25, 310);
            dgvRecentSales.MultiSelect = false;
            dgvRecentSales.Name = "dgvRecentSales";
            dgvRecentSales.ReadOnly = true;
            dgvRecentSales.RowHeadersVisible = false;
            dgvRecentSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentSales.Size = new Size(950, 280);
            dgvRecentSales.TabIndex = 6;
            // 
            // colSaleID
            // 
            colSaleID.HeaderText = "Sale ID";
            colSaleID.Name = "colSaleID";
            colSaleID.ReadOnly = true;
            // 
            // colProduct
            // 
            colProduct.HeaderText = "Product";
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total (R)";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colSaleDate
            // 
            colSaleDate.HeaderText = "Date & Time";
            colSaleDate.Name = "colSaleDate";
            colSaleDate.ReadOnly = true;
            // 
            // lblRecentSalesHeading
            // 
            lblRecentSalesHeading.AutoSize = true;
            lblRecentSalesHeading.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecentSalesHeading.ForeColor = Color.MidnightBlue;
            lblRecentSalesHeading.Location = new Point(25, 270);
            lblRecentSalesHeading.Name = "lblRecentSalesHeading";
            lblRecentSalesHeading.Size = new Size(130, 22);
            lblRecentSalesHeading.TabIndex = 5;
            lblRecentSalesHeading.Text = "Recent Sales";
            // 
            // pnlInventoryValue
            // 
            pnlInventoryValue.BackColor = Color.White;
            pnlInventoryValue.Controls.Add(label2);
            pnlInventoryValue.Controls.Add(lblInventoryValueAmount);
            pnlInventoryValue.Controls.Add(lblInventoryValueTitle);
            pnlInventoryValue.Location = new Point(813, 110);
            pnlInventoryValue.Name = "pnlInventoryValue";
            pnlInventoryValue.RightToLeft = RightToLeft.Yes;
            pnlInventoryValue.Size = new Size(220, 130);
            pnlInventoryValue.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // lblInventoryValueAmount
            // 
            lblInventoryValueAmount.AutoSize = true;
            lblInventoryValueAmount.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventoryValueAmount.ForeColor = Color.MidnightBlue;
            lblInventoryValueAmount.Location = new Point(15, 45);
            lblInventoryValueAmount.Name = "lblInventoryValueAmount";
            lblInventoryValueAmount.Size = new Size(115, 37);
            lblInventoryValueAmount.TabIndex = 5;
            lblInventoryValueAmount.Text = "R 0.00";
            // 
            // lblInventoryValueTitle
            // 
            lblInventoryValueTitle.AutoSize = true;
            lblInventoryValueTitle.ForeColor = Color.DimGray;
            lblInventoryValueTitle.Location = new Point(15, 15);
            lblInventoryValueTitle.Name = "lblInventoryValueTitle";
            lblInventoryValueTitle.Size = new Size(108, 15);
            lblInventoryValueTitle.TabIndex = 5;
            lblInventoryValueTitle.Text = "Inventory Value";
            // 
            // pnlTodaysSales
            // 
            pnlTodaysSales.BackColor = Color.White;
            pnlTodaysSales.BorderStyle = BorderStyle.FixedSingle;
            pnlTodaysSales.Controls.Add(lblTodaysSalesValue);
            pnlTodaysSales.Controls.Add(lblTodayssalesTitle);
            pnlTodaysSales.Location = new Point(549, 110);
            pnlTodaysSales.Name = "pnlTodaysSales";
            pnlTodaysSales.Size = new Size(220, 130);
            pnlTodaysSales.TabIndex = 4;
            // 
            // lblTodaysSalesValue
            // 
            lblTodaysSalesValue.AutoSize = true;
            lblTodaysSalesValue.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodaysSalesValue.ForeColor = Color.ForestGreen;
            lblTodaysSalesValue.Location = new Point(15, 45);
            lblTodaysSalesValue.Name = "lblTodaysSalesValue";
            lblTodaysSalesValue.Size = new Size(115, 37);
            lblTodaysSalesValue.TabIndex = 1;
            lblTodaysSalesValue.Text = "R 0.00";
            // 
            // lblTodayssalesTitle
            // 
            lblTodayssalesTitle.AutoSize = true;
            lblTodayssalesTitle.ForeColor = Color.DimGray;
            lblTodayssalesTitle.Location = new Point(15, 15);
            lblTodayssalesTitle.Name = "lblTodayssalesTitle";
            lblTodayssalesTitle.Size = new Size(95, 15);
            lblTodayssalesTitle.TabIndex = 0;
            lblTodayssalesTitle.Text = "Today's Sales";
            // 
            // pnlLowStoc
            // 
            pnlLowStoc.BackColor = Color.White;
            pnlLowStoc.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStoc.Controls.Add(lblLowStockValue);
            pnlLowStoc.Controls.Add(lblLowStockItemsTitle);
            pnlLowStoc.Location = new Point(265, 110);
            pnlLowStoc.Name = "pnlLowStoc";
            pnlLowStoc.Size = new Size(220, 130);
            pnlLowStoc.TabIndex = 3;
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.AutoSize = true;
            lblLowStockValue.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStockValue.ForeColor = Color.Firebrick;
            lblLowStockValue.Location = new Point(15, 45);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(38, 40);
            lblLowStockValue.TabIndex = 1;
            lblLowStockValue.Text = "0";
            // 
            // lblLowStockItemsTitle
            // 
            lblLowStockItemsTitle.AutoSize = true;
            lblLowStockItemsTitle.ForeColor = Color.DimGray;
            lblLowStockItemsTitle.Location = new Point(15, 15);
            lblLowStockItemsTitle.Name = "lblLowStockItemsTitle";
            lblLowStockItemsTitle.Size = new Size(113, 15);
            lblLowStockItemsTitle.TabIndex = 0;
            lblLowStockItemsTitle.Text = "Low Stock Items";
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.BackColor = SystemColors.ControlLightLight;
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(lblTotalProductsValue);
            pnlTotalProducts.Controls.Add(lblTotalProductsTitle);
            pnlTotalProducts.Location = new Point(25, 110);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Size = new Size(220, 130);
            pnlTotalProducts.TabIndex = 2;
            // 
            // lblTotalProductsValue
            // 
            lblTotalProductsValue.AutoSize = true;
            lblTotalProductsValue.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalProductsValue.ForeColor = Color.MidnightBlue;
            lblTotalProductsValue.Location = new Point(15, 45);
            lblTotalProductsValue.Name = "lblTotalProductsValue";
            lblTotalProductsValue.Size = new Size(38, 40);
            lblTotalProductsValue.TabIndex = 3;
            lblTotalProductsValue.Text = "0";
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.AutoSize = true;
            lblTotalProductsTitle.BackColor = SystemColors.ControlLightLight;
            lblTotalProductsTitle.ForeColor = Color.DimGray;
            lblTotalProductsTitle.Location = new Point(15, 15);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(102, 15);
            lblTotalProductsTitle.TabIndex = 3;
            lblTotalProductsTitle.Text = "Total Products";
            // 
            // lblOverviewDescription
            // 
            lblOverviewDescription.AutoSize = true;
            lblOverviewDescription.ForeColor = Color.DimGray;
            lblOverviewDescription.Location = new Point(27, 60);
            lblOverviewDescription.Name = "lblOverviewDescription";
            lblOverviewDescription.Size = new Size(324, 15);
            lblOverviewDescription.TabIndex = 1;
            lblOverviewDescription.Text = "Here is what's happening in your tuck shop today.";
            // 
            // lblOverviewHeading
            // 
            lblOverviewHeading.AutoSize = true;
            lblOverviewHeading.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOverviewHeading.ForeColor = Color.MidnightBlue;
            lblOverviewHeading.Location = new Point(25, 20);
            lblOverviewHeading.Name = "lblOverviewHeading";
            lblOverviewHeading.Size = new Size(212, 32);
            lblOverviewHeading.TabIndex = 0;
            lblOverviewHeading.Text = "Shop Overview";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1353, 661);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DimGray;
            MinimumSize = new Size(1364, 700);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tuck Shop Management System";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).EndInit();
            pnlInventoryValue.ResumeLayout(false);
            pnlInventoryValue.PerformLayout();
            pnlTodaysSales.ResumeLayout(false);
            pnlTodaysSales.PerformLayout();
            pnlLowStoc.ResumeLayout(false);
            pnlLowStoc.PerformLayout();
            pnlTotalProducts.ResumeLayout(false);
            pnlTotalProducts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblAppName;
        private Button btnRecordSale;
        private Button btnInventory;
        private Button btnSalesHistory;
        private Button btnReports;
        private Button btnProducts;
        private Button btnSettings;
        private Button btnDashboard;
        private Button btnLogout;
        private Panel pnlHeader;
        private Label lblPageTitle;
        private Label label1;
        private Panel pnlMainContent;
        private Label lblOverviewDescription;
        private Label lblOverviewHeading;
        private Panel pnlTotalProducts;
        private Label lblTotalProductsTitle;
        private Panel pnlLowStoc;
        private Label lblTotalProductsValue;
        private Label lblLowStockValue;
        private Label lblLowStockItemsTitle;
        private Panel pnlTodaysSales;
        private Label lblTodayssalesTitle;
        private Panel pnlInventoryValue;
        private Label lblTodaysSalesValue;
        private Label lblInventoryValueTitle;
        private Label lblRecentSalesHeading;
        private Label label2;
        private Label lblInventoryValueAmount;
        private DataGridView dgvRecentSales;
        private DataGridViewTextBoxColumn colSaleID;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colSaleDate;
    }
}