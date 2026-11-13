namespace Sales_Inventory_Management
{
    partial class StockAdjustmentControl
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
            lblProduct = new Label();
            lblHeading = new Label();
            cmbProducts = new ComboBox();
            lblDescription = new Label();
            lblCurrentStockLevel = new Label();
            lblCurrentStock = new Label();
            pnlAdjustmentForm = new Panel();
            btnSaveAdjustment = new Button();
            btnCancel = new Button();
            txtReason = new TextBox();
            lblReason = new Label();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            cmbAdjustmentType = new ComboBox();
            lblAdjustmentType = new Label();
            pnlCurrentStock = new Panel();
            pnlAdjustmentForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            pnlCurrentStock.SuspendLayout();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduct.ForeColor = SystemColors.ActiveCaptionText;
            lblProduct.Location = new Point(30, 125);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(74, 17);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Products";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.MidnightBlue;
            lblHeading.Location = new Point(30, 17);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(261, 32);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Stock Adjustments";
            // 
            // cmbProducts
            // 
            cmbProducts.BackColor = Color.White;
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FlatStyle = FlatStyle.Flat;
            cmbProducts.ForeColor = SystemColors.InactiveCaptionText;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(30, 155);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(350, 23);
            cmbProducts.TabIndex = 2;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(30, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(413, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Correct inventory quantities when physical stock differs from system records.";
            // 
            // lblCurrentStockLevel
            // 
            lblCurrentStockLevel.AutoSize = true;
            lblCurrentStockLevel.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStockLevel.ForeColor = SystemColors.ActiveCaptionText;
            lblCurrentStockLevel.Location = new Point(15, 40);
            lblCurrentStockLevel.Name = "lblCurrentStockLevel";
            lblCurrentStockLevel.Size = new Size(190, 17);
            lblCurrentStockLevel.TabIndex = 4;
            lblCurrentStockLevel.Text = "Displays current quantity";
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStock.ForeColor = SystemColors.ActiveCaptionText;
            lblCurrentStock.Location = new Point(15, 10);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(111, 17);
            lblCurrentStock.TabIndex = 5;
            lblCurrentStock.Text = "Current Stock";
            // 
            // pnlAdjustmentForm
            // 
            pnlAdjustmentForm.AutoScroll = true;
            pnlAdjustmentForm.BackColor = SystemColors.ActiveCaption;
            pnlAdjustmentForm.BorderStyle = BorderStyle.FixedSingle;
            pnlAdjustmentForm.Controls.Add(btnSaveAdjustment);
            pnlAdjustmentForm.Controls.Add(btnCancel);
            pnlAdjustmentForm.Controls.Add(txtReason);
            pnlAdjustmentForm.Controls.Add(lblReason);
            pnlAdjustmentForm.Controls.Add(numQuantity);
            pnlAdjustmentForm.Controls.Add(lblQuantity);
            pnlAdjustmentForm.Controls.Add(cmbAdjustmentType);
            pnlAdjustmentForm.Controls.Add(lblAdjustmentType);
            pnlAdjustmentForm.Controls.Add(pnlCurrentStock);
            pnlAdjustmentForm.Controls.Add(lblHeading);
            pnlAdjustmentForm.Controls.Add(lblProduct);
            pnlAdjustmentForm.Controls.Add(lblDescription);
            pnlAdjustmentForm.Controls.Add(cmbProducts);
            pnlAdjustmentForm.Location = new Point(46, 30);
            pnlAdjustmentForm.Name = "pnlAdjustmentForm";
            pnlAdjustmentForm.Size = new Size(1091, 804);
            pnlAdjustmentForm.TabIndex = 6;
            // 
            // btnSaveAdjustment
            // 
            btnSaveAdjustment.BackColor = Color.ForestGreen;
            btnSaveAdjustment.Cursor = Cursors.Hand;
            btnSaveAdjustment.FlatStyle = FlatStyle.Flat;
            btnSaveAdjustment.ForeColor = Color.White;
            btnSaveAdjustment.Location = new Point(450, 535);
            btnSaveAdjustment.Name = "btnSaveAdjustment";
            btnSaveAdjustment.Size = new Size(170, 45);
            btnSaveAdjustment.TabIndex = 15;
            btnSaveAdjustment.Text = "Save Adjustment";
            btnSaveAdjustment.UseVisualStyleBackColor = false;
            btnSaveAdjustment.Click += btnSaveAdjustment_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(635, 535);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 45);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(30, 380);
            txtReason.MaxLength = 500;
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ScrollBars = ScrollBars.Both;
            txtReason.Size = new Size(740, 90);
            txtReason.TabIndex = 13;
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReason.ForeColor = SystemColors.ActiveCaptionText;
            lblReason.Location = new Point(30, 350);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(174, 17);
            lblReason.TabIndex = 12;
            lblReason.Text = "Reason for Adjustment";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantity.Location = new Point(420, 280);
            numQuantity.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(350, 27);
            numQuantity.TabIndex = 11;
            numQuantity.ThousandsSeparator = true;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblQuantity.Location = new Point(420, 250);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(155, 17);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Adjustment Quantity";
            // 
            // cmbAdjustmentType
            // 
            cmbAdjustmentType.BackColor = Color.White;
            cmbAdjustmentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdjustmentType.FlatStyle = FlatStyle.Flat;
            cmbAdjustmentType.FormattingEnabled = true;
            cmbAdjustmentType.Location = new Point(30, 280);
            cmbAdjustmentType.Name = "cmbAdjustmentType";
            cmbAdjustmentType.Size = new Size(350, 23);
            cmbAdjustmentType.TabIndex = 9;
            // 
            // lblAdjustmentType
            // 
            lblAdjustmentType.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdjustmentType.ForeColor = SystemColors.ActiveCaptionText;
            lblAdjustmentType.Location = new Point(30, 250);
            lblAdjustmentType.Name = "lblAdjustmentType";
            lblAdjustmentType.Size = new Size(250, 25);
            lblAdjustmentType.TabIndex = 8;
            lblAdjustmentType.Text = "Adjustment Type";
            // 
            // pnlCurrentStock
            // 
            pnlCurrentStock.Controls.Add(lblCurrentStock);
            pnlCurrentStock.Controls.Add(lblCurrentStockLevel);
            pnlCurrentStock.Location = new Point(420, 125);
            pnlCurrentStock.Name = "pnlCurrentStock";
            pnlCurrentStock.Size = new Size(350, 80);
            pnlCurrentStock.TabIndex = 6;
            // 
            // StockAdjustmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(pnlAdjustmentForm);
            Name = "StockAdjustmentControl";
            Size = new Size(1032, 699);
            Load += StockAdjustmentControl_Load;
            pnlAdjustmentForm.ResumeLayout(false);
            pnlAdjustmentForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            pnlCurrentStock.ResumeLayout(false);
            pnlCurrentStock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblProduct;
        private Label lblHeading;
        private ComboBox cmbProducts;
        private Label lblDescription;
        private Label lblCurrentStockLevel;
        private Label lblCurrentStock;
        private Panel pnlAdjustmentForm;
        private Panel pnlCurrentStock;
        private Label lblAdjustmentType;
        private Label lblQuantity;
        private ComboBox cmbAdjustmentType;
        private NumericUpDown numQuantity;
        private TextBox txtReason;
        private Label lblReason;
        private Button btnSaveAdjustment;
        private Button btnCancel;
    }
}
