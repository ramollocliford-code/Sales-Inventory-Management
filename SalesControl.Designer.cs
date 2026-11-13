namespace Sales_Inventory_Management
{
    partial class SalesControl
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblSalesHeading = new Label();
            lblSalesDescription = new Label();
            pnlProductSelection = new Panel();
            btnAddToSale = new Button();
            numSaleQuantity = new NumericUpDown();
            lblSaleQuantity = new Label();
            lblAvailableStockValue = new Label();
            lblAvailableStock = new Label();
            cmbSaleProduct = new ComboBox();
            lblSelectProduct = new Label();
            pnlCurrentSale = new Panel();
            btnRemoveSaleItem = new Button();
            dgvCurrentSale = new DataGridView();
            colSaleProductID = new DataGridViewTextBoxColumn();
            colSaleProductName = new DataGridViewTextBoxColumn();
            colSaleQuantity = new DataGridViewTextBoxColumn();
            colSaleUnitPrice = new DataGridViewTextBoxColumn();
            colSaleSubtotal = new DataGridViewTextBoxColumn();
            lblCurrentSaleHeading = new Label();
            pnlSaleSummary = new Panel();
            btnClearSale = new Button();
            btnCompleteSale = new Button();
            cmbPaymentMethod = new ComboBox();
            lblPaymentMethod = new Label();
            lblTotalValue = new Label();
            lblTotal = new Label();
            lblSubtotalValue = new Label();
            lblSubtotal = new Label();
            lblSaleSummaryHeading = new Label();
            pnlProductSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSaleQuantity).BeginInit();
            pnlCurrentSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentSale).BeginInit();
            pnlSaleSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblSalesHeading
            // 
            lblSalesHeading.AutoSize = true;
            lblSalesHeading.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesHeading.ForeColor = Color.MidnightBlue;
            lblSalesHeading.Location = new Point(30, 25);
            lblSalesHeading.Name = "lblSalesHeading";
            lblSalesHeading.Size = new Size(174, 28);
            lblSalesHeading.TabIndex = 0;
            lblSalesHeading.Text = "Record a Sale";
            // 
            // lblSalesDescription
            // 
            lblSalesDescription.AutoSize = true;
            lblSalesDescription.ForeColor = Color.DimGray;
            lblSalesDescription.Location = new Point(30, 65);
            lblSalesDescription.Name = "lblSalesDescription";
            lblSalesDescription.Size = new Size(354, 15);
            lblSalesDescription.TabIndex = 1;
            lblSalesDescription.Text = "Select products, enter quantities and complete a sales transaction.";
            // 
            // pnlProductSelection
            // 
            pnlProductSelection.BorderStyle = BorderStyle.FixedSingle;
            pnlProductSelection.Controls.Add(btnAddToSale);
            pnlProductSelection.Controls.Add(numSaleQuantity);
            pnlProductSelection.Controls.Add(lblSaleQuantity);
            pnlProductSelection.Controls.Add(lblAvailableStockValue);
            pnlProductSelection.Controls.Add(lblAvailableStock);
            pnlProductSelection.Controls.Add(cmbSaleProduct);
            pnlProductSelection.Controls.Add(lblSelectProduct);
            pnlProductSelection.Location = new Point(30, 115);
            pnlProductSelection.Name = "pnlProductSelection";
            pnlProductSelection.Size = new Size(1000, 155);
            pnlProductSelection.TabIndex = 2;
            // 
            // btnAddToSale
            // 
            btnAddToSale.BackColor = Color.ForestGreen;
            btnAddToSale.FlatStyle = FlatStyle.Flat;
            btnAddToSale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddToSale.ForeColor = Color.White;
            btnAddToSale.Location = new Point(800, 42);
            btnAddToSale.Name = "btnAddToSale";
            btnAddToSale.Size = new Size(160, 42);
            btnAddToSale.TabIndex = 6;
            btnAddToSale.Text = "Add Product";
            btnAddToSale.UseVisualStyleBackColor = false;
            btnAddToSale.Click += btnAddToSale_Click;
            // 
            // numSaleQuantity
            // 
            numSaleQuantity.Location = new Point(590, 45);
            numSaleQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSaleQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSaleQuantity.Name = "numSaleQuantity";
            numSaleQuantity.Size = new Size(150, 23);
            numSaleQuantity.TabIndex = 5;
            numSaleQuantity.ThousandsSeparator = true;
            numSaleQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSaleQuantity
            // 
            lblSaleQuantity.AutoSize = true;
            lblSaleQuantity.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaleQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblSaleQuantity.Location = new Point(590, 15);
            lblSaleQuantity.Name = "lblSaleQuantity";
            lblSaleQuantity.Size = new Size(105, 17);
            lblSaleQuantity.TabIndex = 4;
            lblSaleQuantity.Text = "Sale Quantity";
            // 
            // lblAvailableStockValue
            // 
            lblAvailableStockValue.AutoSize = true;
            lblAvailableStockValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableStockValue.ForeColor = Color.ForestGreen;
            lblAvailableStockValue.Location = new Point(393, 45);
            lblAvailableStockValue.Name = "lblAvailableStockValue";
            lblAvailableStockValue.Size = new Size(20, 25);
            lblAvailableStockValue.TabIndex = 3;
            lblAvailableStockValue.Text = "-";
            // 
            // lblAvailableStock
            // 
            lblAvailableStock.AutoSize = true;
            lblAvailableStock.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableStock.ForeColor = SystemColors.ActiveCaptionText;
            lblAvailableStock.Location = new Point(379, 15);
            lblAvailableStock.Name = "lblAvailableStock";
            lblAvailableStock.Size = new Size(121, 17);
            lblAvailableStock.TabIndex = 2;
            lblAvailableStock.Text = "Available Stock";
            // 
            // cmbSaleProduct
            // 
            cmbSaleProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaleProduct.FlatStyle = FlatStyle.Flat;
            cmbSaleProduct.FormattingEnabled = true;
            cmbSaleProduct.Location = new Point(20, 45);
            cmbSaleProduct.Name = "cmbSaleProduct";
            cmbSaleProduct.Size = new Size(300, 23);
            cmbSaleProduct.TabIndex = 1;
            cmbSaleProduct.SelectedIndexChanged += cmbSaleProduct_SelectedIndexChanged;
            // 
            // lblSelectProduct
            // 
            lblSelectProduct.AutoSize = true;
            lblSelectProduct.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectProduct.ForeColor = SystemColors.ActiveCaptionText;
            lblSelectProduct.Location = new Point(20, 15);
            lblSelectProduct.Name = "lblSelectProduct";
            lblSelectProduct.Size = new Size(116, 17);
            lblSelectProduct.TabIndex = 0;
            lblSelectProduct.Text = "Select Product";
            // 
            // pnlCurrentSale
            // 
            pnlCurrentSale.BackColor = SystemColors.ActiveCaption;
            pnlCurrentSale.BorderStyle = BorderStyle.FixedSingle;
            pnlCurrentSale.Controls.Add(btnRemoveSaleItem);
            pnlCurrentSale.Controls.Add(dgvCurrentSale);
            pnlCurrentSale.Controls.Add(lblCurrentSaleHeading);
            pnlCurrentSale.Location = new Point(30, 290);
            pnlCurrentSale.Name = "pnlCurrentSale";
            pnlCurrentSale.Size = new Size(650, 390);
            pnlCurrentSale.TabIndex = 3;
            // 
            // btnRemoveSaleItem
            // 
            btnRemoveSaleItem.BackColor = Color.Firebrick;
            btnRemoveSaleItem.FlatStyle = FlatStyle.Flat;
            btnRemoveSaleItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveSaleItem.ForeColor = Color.White;
            btnRemoveSaleItem.Location = new Point(20, 335);
            btnRemoveSaleItem.Name = "btnRemoveSaleItem";
            btnRemoveSaleItem.Size = new Size(190, 35);
            btnRemoveSaleItem.TabIndex = 2;
            btnRemoveSaleItem.Text = "Remove Sale Item";
            btnRemoveSaleItem.UseVisualStyleBackColor = false;
            btnRemoveSaleItem.Click += btnRemoveSaleItem_Click;
            // 
            // dgvCurrentSale
            // 
            dgvCurrentSale.AllowUserToAddRows = false;
            dgvCurrentSale.AllowUserToDeleteRows = false;
            dgvCurrentSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCurrentSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCurrentSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentSale.Columns.AddRange(new DataGridViewColumn[] { colSaleProductID, colSaleProductName, colSaleQuantity, colSaleUnitPrice, colSaleSubtotal });
            dgvCurrentSale.GridColor = SystemColors.MenuText;
            dgvCurrentSale.Location = new Point(20, 60);
            dgvCurrentSale.MultiSelect = false;
            dgvCurrentSale.Name = "dgvCurrentSale";
            dgvCurrentSale.ReadOnly = true;
            dgvCurrentSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrentSale.Size = new Size(610, 260);
            dgvCurrentSale.TabIndex = 1;
            // 
            // colSaleProductID
            // 
            colSaleProductID.DataPropertyName = "ProductID";
            colSaleProductID.HeaderText = "ProductID";
            colSaleProductID.Name = "colSaleProductID";
            colSaleProductID.ReadOnly = true;
            // 
            // colSaleProductName
            // 
            colSaleProductName.DataPropertyName = "ProductName";
            colSaleProductName.HeaderText = "ProductName";
            colSaleProductName.Name = "colSaleProductName";
            colSaleProductName.ReadOnly = true;
            // 
            // colSaleQuantity
            // 
            colSaleQuantity.DataPropertyName = "Quantity";
            colSaleQuantity.HeaderText = "Quantity";
            colSaleQuantity.Name = "colSaleQuantity";
            colSaleQuantity.ReadOnly = true;
            // 
            // colSaleUnitPrice
            // 
            colSaleUnitPrice.DataPropertyName = "UnitPrice";
            colSaleUnitPrice.HeaderText = "Unit Price";
            colSaleUnitPrice.Name = "colSaleUnitPrice";
            colSaleUnitPrice.ReadOnly = true;
            // 
            // colSaleSubtotal
            // 
            colSaleSubtotal.DataPropertyName = "Subtotal";
            colSaleSubtotal.HeaderText = "Subtotal";
            colSaleSubtotal.Name = "colSaleSubtotal";
            colSaleSubtotal.ReadOnly = true;
            // 
            // lblCurrentSaleHeading
            // 
            lblCurrentSaleHeading.AutoSize = true;
            lblCurrentSaleHeading.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentSaleHeading.ForeColor = SystemColors.ActiveCaptionText;
            lblCurrentSaleHeading.Location = new Point(20, 15);
            lblCurrentSaleHeading.Name = "lblCurrentSaleHeading";
            lblCurrentSaleHeading.Size = new Size(125, 22);
            lblCurrentSaleHeading.TabIndex = 0;
            lblCurrentSaleHeading.Text = "Current Sale";
            // 
            // pnlSaleSummary
            // 
            pnlSaleSummary.BackColor = SystemColors.ActiveCaption;
            pnlSaleSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSaleSummary.Controls.Add(btnClearSale);
            pnlSaleSummary.Controls.Add(btnCompleteSale);
            pnlSaleSummary.Controls.Add(cmbPaymentMethod);
            pnlSaleSummary.Controls.Add(lblPaymentMethod);
            pnlSaleSummary.Controls.Add(lblTotalValue);
            pnlSaleSummary.Controls.Add(lblTotal);
            pnlSaleSummary.Controls.Add(lblSubtotalValue);
            pnlSaleSummary.Controls.Add(lblSubtotal);
            pnlSaleSummary.Controls.Add(lblSaleSummaryHeading);
            pnlSaleSummary.Location = new Point(700, 290);
            pnlSaleSummary.Name = "pnlSaleSummary";
            pnlSaleSummary.Size = new Size(330, 390);
            pnlSaleSummary.TabIndex = 4;
            // 
            // btnClearSale
            // 
            btnClearSale.BackColor = Color.DimGray;
            btnClearSale.FlatAppearance.BorderSize = 0;
            btnClearSale.FlatStyle = FlatStyle.Flat;
            btnClearSale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSale.ForeColor = Color.White;
            btnClearSale.Location = new Point(20, 336);
            btnClearSale.Name = "btnClearSale";
            btnClearSale.Size = new Size(290, 35);
            btnClearSale.TabIndex = 8;
            btnClearSale.Text = "Clear Sale";
            btnClearSale.UseVisualStyleBackColor = false;
            btnClearSale.Click += btnClearSale_Click;
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.BackColor = Color.ForestGreen;
            btnCompleteSale.FlatAppearance.BorderSize = 0;
            btnCompleteSale.FlatStyle = FlatStyle.Flat;
            btnCompleteSale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompleteSale.ForeColor = Color.White;
            btnCompleteSale.Location = new Point(20, 285);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(290, 45);
            btnCompleteSale.TabIndex = 7;
            btnCompleteSale.Text = "Complete Sale";
            btnCompleteSale.UseVisualStyleBackColor = false;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.BackColor = SystemColors.InactiveCaption;
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.FlatStyle = FlatStyle.Flat;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(20, 220);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(280, 23);
            cmbPaymentMethod.TabIndex = 6;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.ForeColor = SystemColors.ActiveCaptionText;
            lblPaymentMethod.Location = new Point(20, 190);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(128, 21);
            lblPaymentMethod.TabIndex = 5;
            lblPaymentMethod.Text = "Payment Method";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalValue.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalValue.Location = new Point(150, 125);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(70, 30);
            lblTotalValue.TabIndex = 4;
            lblTotalValue.Text = "R 0.00";
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ActiveCaptionText;
            lblTotal.Location = new Point(20, 125);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 21);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotalValue.ForeColor = SystemColors.ActiveCaptionText;
            lblSubtotalValue.Location = new Point(170, 75);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(54, 21);
            lblSubtotalValue.TabIndex = 2;
            lblSubtotalValue.Text = "R 0.00";
            lblSubtotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = SystemColors.ActiveCaptionText;
            lblSubtotal.Location = new Point(20, 75);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(68, 21);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "Subtotal";
            // 
            // lblSaleSummaryHeading
            // 
            lblSaleSummaryHeading.AutoSize = true;
            lblSaleSummaryHeading.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaleSummaryHeading.ForeColor = SystemColors.ActiveCaptionText;
            lblSaleSummaryHeading.Location = new Point(20, 15);
            lblSaleSummaryHeading.Name = "lblSaleSummaryHeading";
            lblSaleSummaryHeading.Size = new Size(147, 22);
            lblSaleSummaryHeading.TabIndex = 0;
            lblSaleSummaryHeading.Text = "Sale Summary ";
            // 
            // SalesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pnlSaleSummary);
            Controls.Add(pnlCurrentSale);
            Controls.Add(pnlProductSelection);
            Controls.Add(lblSalesDescription);
            Controls.Add(lblSalesHeading);
            Cursor = Cursors.Hand;
            Name = "SalesControl";
            Size = new Size(1100, 750);
            pnlProductSelection.ResumeLayout(false);
            pnlProductSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSaleQuantity).EndInit();
            pnlCurrentSale.ResumeLayout(false);
            pnlCurrentSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentSale).EndInit();
            pnlSaleSummary.ResumeLayout(false);
            pnlSaleSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalesHeading;
        private Label lblSalesDescription;
        private Panel pnlProductSelection;
        private ComboBox cmbSaleProduct;
        private Label lblSelectProduct;
        private Label lblAvailableStockValue;
        private Label lblAvailableStock;
        private Button btnAddToSale;
        private NumericUpDown numSaleQuantity;
        private Label lblSaleQuantity;
        private Panel pnlCurrentSale;
        private DataGridView dgvCurrentSale;
        private Label lblCurrentSaleHeading;
        private Button btnRemoveSaleItem;
        private DataGridViewTextBoxColumn colSaleProductID;
        private DataGridViewTextBoxColumn colSaleProductName;
        private DataGridViewTextBoxColumn colSaleQuantity;
        private DataGridViewTextBoxColumn colSaleUnitPrice;
        private DataGridViewTextBoxColumn colSaleSubtotal;
        private Panel pnlSaleSummary;
        private Label lblSubtotalValue;
        private Label lblSubtotal;
        private Label lblSaleSummaryHeading;
        private Label lblPaymentMethod;
        private Label lblTotalValue;
        private Label lblTotal;
        private Button btnCompleteSale;
        private ComboBox cmbPaymentMethod;
        private Button btnClearSale;
    }
}
