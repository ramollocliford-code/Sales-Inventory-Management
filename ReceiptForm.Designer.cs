namespace Sales_Inventory_Management
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            lblReceiptNumb = new Label();
            lblReceiptTitle = new Label();
            lblShopName = new Label();
            lblPaymentMethod = new Label();
            lblReceiptDate = new Label();
            lblDivider = new Label();
            dgvReceiptItems = new DataGridView();
            lblTotal = new Label();
            lblSubtotal = new Label();
            lblThankYou = new Label();
            btnClose = new Button();
            btnPrint = new Button();
            printDocumentReceipt = new System.Drawing.Printing.PrintDocument();
            printPreviewDialogReceipt = new PrintPreviewDialog();
            btnPreview = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReceiptItems).BeginInit();
            SuspendLayout();
            // 
            // lblReceiptNumb
            // 
            lblReceiptNumb.AutoSize = true;
            lblReceiptNumb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptNumb.Location = new Point(50, 130);
            lblReceiptNumb.Name = "lblReceiptNumb";
            lblReceiptNumb.Size = new Size(100, 20);
            lblReceiptNumb.TabIndex = 0;
            lblReceiptNumb.Text = "Receipt No: -";
            // 
            // lblReceiptTitle
            // 
            lblReceiptTitle.AutoSize = true;
            lblReceiptTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptTitle.Location = new Point(200, 75);
            lblReceiptTitle.Name = "lblReceiptTitle";
            lblReceiptTitle.Size = new Size(122, 21);
            lblReceiptTitle.TabIndex = 1;
            lblReceiptTitle.Text = "SALES RECEIPT";
            // 
            // lblShopName
            // 
            lblShopName.AutoSize = true;
            lblShopName.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShopName.Location = new Point(175, 25);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(162, 33);
            lblShopName.TabIndex = 2;
            lblShopName.Text = "Tuck shop";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(50, 190);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(127, 17);
            lblPaymentMethod.TabIndex = 3;
            lblPaymentMethod.Text = "Payment Method: -";
            // 
            // lblReceiptDate
            // 
            lblReceiptDate.AutoSize = true;
            lblReceiptDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptDate.Location = new Point(50, 160);
            lblReceiptDate.Name = "lblReceiptDate";
            lblReceiptDate.Size = new Size(56, 20);
            lblReceiptDate.TabIndex = 4;
            lblReceiptDate.Text = "Date: -";
            // 
            // lblDivider
            // 
            lblDivider.Location = new Point(40, 230);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(550, 25);
            lblDivider.TabIndex = 5;
            lblDivider.Text = "─────────────────────────────────";
            // 
            // dgvReceiptItems
            // 
            dgvReceiptItems.AllowUserToAddRows = false;
            dgvReceiptItems.AllowUserToDeleteRows = false;
            dgvReceiptItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvReceiptItems.BackgroundColor = Color.White;
            dgvReceiptItems.BorderStyle = BorderStyle.None;
            dgvReceiptItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceiptItems.Location = new Point(40, 265);
            dgvReceiptItems.MultiSelect = false;
            dgvReceiptItems.Name = "dgvReceiptItems";
            dgvReceiptItems.ReadOnly = true;
            dgvReceiptItems.RowHeadersVisible = false;
            dgvReceiptItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceiptItems.Size = new Size(550, 260);
            dgvReceiptItems.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(331, 558);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(250, 40);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL: R0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(240, 528);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(350, 30);
            lblSubtotal.TabIndex = 9;
            lblSubtotal.Text = "Subtotal: R0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblThankYou
            // 
            lblThankYou.AutoSize = true;
            lblThankYou.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThankYou.Location = new Point(89, 571);
            lblThankYou.Name = "lblThankYou";
            lblThankYou.Size = new Size(236, 20);
            lblThankYou.TabIndex = 10;
            lblThankYou.Text = "Thank you for shopping with us!";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Firebrick;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(420, 605);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.ForestGreen;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(240, 605);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(140, 40);
            btnPrint.TabIndex = 12;
            btnPrint.Text = "Print Reciept";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // printDocumentReceipt
            // 
            printDocumentReceipt.DocumentName = "Tuck Shop Sales Receipt";
            printDocumentReceipt.PrintPage += printDocumentReceipt_PrintPage;
            // 
            // printPreviewDialogReceipt
            // 
            printPreviewDialogReceipt.AutoScrollMargin = new Size(0, 0);
            printPreviewDialogReceipt.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialogReceipt.ClientSize = new Size(400, 300);
            printPreviewDialogReceipt.Document = printDocumentReceipt;
            printPreviewDialogReceipt.Enabled = true;
            printPreviewDialogReceipt.Icon = (Icon)resources.GetObject("printPreviewDialogReceipt.Icon");
            printPreviewDialogReceipt.Name = "printPreviewDialogReceipt";
            printPreviewDialogReceipt.UseAntiAlias = true;
            printPreviewDialogReceipt.Visible = false;
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.Orange;
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(89, 605);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(140, 40);
            btnPreview.TabIndex = 13;
            btnPreview.Text = "Preview reciept";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(634, 661);
            Controls.Add(btnPreview);
            Controls.Add(btnPrint);
            Controls.Add(btnClose);
            Controls.Add(lblThankYou);
            Controls.Add(lblSubtotal);
            Controls.Add(lblTotal);
            Controls.Add(dgvReceiptItems);
            Controls.Add(lblDivider);
            Controls.Add(lblReceiptDate);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblShopName);
            Controls.Add(lblReceiptTitle);
            Controls.Add(lblReceiptNumb);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Receipt";
            ((System.ComponentModel.ISupportInitialize)dgvReceiptItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReceiptNumb;
        private Label lblReceiptTitle;
        private Label lblShopName;
        private Label lblPaymentMethod;
        private Label lblReceiptDate;
        private Label lblDivider;
        private DataGridView dgvReceiptItems;
        private Label lblTotal;
        private Label lblSubtotal;
        private Label lblThankYou;
        private Button btnClose;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocumentReceipt;
        private PrintPreviewDialog printPreviewDialogReceipt;
        private Button btnPreview;
    }
}