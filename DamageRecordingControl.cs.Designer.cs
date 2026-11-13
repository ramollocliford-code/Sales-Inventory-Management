namespace Sales_Inventory_Management
{
    partial class DamageRecordingControl
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
            pnlDamageForm = new Panel();
            btnCancel = new Button();
            btnSaveDamage = new Button();
            txtDamageReason = new TextBox();
            lblDamageReason = new Label();
            numDamageQuantity = new NumericUpDown();
            lblDamageQuantity = new Label();
            pnlCurrentStock = new Panel();
            lblCurrentStockLevel = new Label();
            lblCurrentStock = new Label();
            cmbProducts = new ComboBox();
            lblSelect = new Label();
            lblDescription = new Label();
            lblHeading = new Label();
            pnlDamageForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDamageQuantity).BeginInit();
            pnlCurrentStock.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDamageForm
            // 
            pnlDamageForm.BackColor = SystemColors.ActiveCaption;
            pnlDamageForm.BorderStyle = BorderStyle.FixedSingle;
            pnlDamageForm.Controls.Add(btnCancel);
            pnlDamageForm.Controls.Add(btnSaveDamage);
            pnlDamageForm.Controls.Add(txtDamageReason);
            pnlDamageForm.Controls.Add(lblDamageReason);
            pnlDamageForm.Controls.Add(numDamageQuantity);
            pnlDamageForm.Controls.Add(lblDamageQuantity);
            pnlDamageForm.Controls.Add(pnlCurrentStock);
            pnlDamageForm.Controls.Add(cmbProducts);
            pnlDamageForm.Controls.Add(lblSelect);
            pnlDamageForm.Controls.Add(lblDescription);
            pnlDamageForm.Controls.Add(lblHeading);
            pnlDamageForm.Location = new Point(30, 30);
            pnlDamageForm.Name = "pnlDamageForm";
            pnlDamageForm.Size = new Size(850, 650);
            pnlDamageForm.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(620, 545);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveDamage
            // 
            btnSaveDamage.BackColor = Color.ForestGreen;
            btnSaveDamage.Cursor = Cursors.Hand;
            btnSaveDamage.FlatAppearance.BorderSize = 0;
            btnSaveDamage.FlatStyle = FlatStyle.Flat;
            btnSaveDamage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveDamage.ForeColor = Color.White;
            btnSaveDamage.Location = new Point(435, 545);
            btnSaveDamage.Name = "btnSaveDamage";
            btnSaveDamage.Size = new Size(170, 45);
            btnSaveDamage.TabIndex = 11;
            btnSaveDamage.Text = "Save Damage Record";
            btnSaveDamage.UseVisualStyleBackColor = false;
            btnSaveDamage.Click += btnSaveDamage_Click;
            // 
            // txtDamageReason
            // 
            txtDamageReason.Location = new Point(30, 380);
            txtDamageReason.MaxLength = 500;
            txtDamageReason.Multiline = true;
            txtDamageReason.Name = "txtDamageReason";
            txtDamageReason.ScrollBars = ScrollBars.Vertical;
            txtDamageReason.Size = new Size(740, 100);
            txtDamageReason.TabIndex = 10;
            // 
            // lblDamageReason
            // 
            lblDamageReason.AutoSize = true;
            lblDamageReason.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDamageReason.ForeColor = SystemColors.ActiveCaptionText;
            lblDamageReason.Location = new Point(30, 350);
            lblDamageReason.Name = "lblDamageReason";
            lblDamageReason.Size = new Size(152, 17);
            lblDamageReason.TabIndex = 9;
            lblDamageReason.Text = "Reason for Damage";
            // 
            // numDamageQuantity
            // 
            numDamageQuantity.Location = new Point(30, 275);
            numDamageQuantity.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDamageQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDamageQuantity.Name = "numDamageQuantity";
            numDamageQuantity.Size = new Size(350, 23);
            numDamageQuantity.TabIndex = 8;
            numDamageQuantity.ThousandsSeparator = true;
            numDamageQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDamageQuantity
            // 
            lblDamageQuantity.AutoSize = true;
            lblDamageQuantity.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDamageQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblDamageQuantity.Location = new Point(30, 245);
            lblDamageQuantity.Name = "lblDamageQuantity";
            lblDamageQuantity.Size = new Size(133, 17);
            lblDamageQuantity.TabIndex = 7;
            lblDamageQuantity.Text = "Damage Quantity";
            // 
            // pnlCurrentStock
            // 
            pnlCurrentStock.BackColor = Color.FromArgb(240, 244, 248);
            pnlCurrentStock.BorderStyle = BorderStyle.FixedSingle;
            pnlCurrentStock.Controls.Add(lblCurrentStockLevel);
            pnlCurrentStock.Controls.Add(lblCurrentStock);
            pnlCurrentStock.Location = new Point(420, 125);
            pnlCurrentStock.Name = "pnlCurrentStock";
            pnlCurrentStock.Size = new Size(350, 85);
            pnlCurrentStock.TabIndex = 4;
            // 
            // lblCurrentStockLevel
            // 
            lblCurrentStockLevel.AutoSize = true;
            lblCurrentStockLevel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStockLevel.ForeColor = Color.FromArgb(35, 45, 60);
            lblCurrentStockLevel.Location = new Point(15, 38);
            lblCurrentStockLevel.Name = "lblCurrentStockLevel";
            lblCurrentStockLevel.Size = new Size(24, 30);
            lblCurrentStockLevel.TabIndex = 6;
            lblCurrentStockLevel.Text = "0";
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
            // cmbProducts
            // 
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FlatStyle = FlatStyle.Flat;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(30, 155);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(350, 23);
            cmbProducts.TabIndex = 3;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelect.ForeColor = SystemColors.ActiveCaptionText;
            lblSelect.Location = new Point(30, 125);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(104, 15);
            lblSelect.TabIndex = 2;
            lblSelect.Text = "Select Product";
            // 
            // lblDescription
            // 
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(30, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(750, 35);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Record damaged products and automatically update inventory quantities.";
            // 
            // lblHeading
            // 
            lblHeading.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = SystemColors.ActiveCaptionText;
            lblHeading.Location = new Point(30, 25);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(750, 35);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Record Damaged Goods";
            // 
            // DamageRecordingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pnlDamageForm);
            Name = "DamageRecordingControl";
            Size = new Size(1100, 750);
            pnlDamageForm.ResumeLayout(false);
            pnlDamageForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDamageQuantity).EndInit();
            pnlCurrentStock.ResumeLayout(false);
            pnlCurrentStock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDamageForm;
        private Label lblHeading;
        private Label lblSelect;
        private Label lblDescription;
        private Panel pnlCurrentStock;
        private ComboBox cmbProducts;
        private Label lblCurrentStockLevel;
        private Label lblCurrentStock;
        private NumericUpDown numDamageQuantity;
        private Label lblDamageQuantity;
        private TextBox txtDamageReason;
        private Label lblDamageReason;
        private Button btnCancel;
        private Button btnSaveDamage;
    }
}
