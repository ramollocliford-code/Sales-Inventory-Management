namespace Sales_Inventory_Management
{
    partial class ReportsControl
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
            lblReportsHeading = new Label();
            lblReportsDescription = new Label();
            pnlReportFilters = new Panel();
            btnGenerateReport = new Button();
            cmbReportType = new ComboBox();
            lblReportType = new Label();
            dtpReportEndDate = new DateTimePicker();
            dtpReportStartDate = new DateTimePicker();
            lblReportEndDate = new Label();
            lblReportStartDate = new Label();
            pnlTotalRevenue = new Panel();
            lblTotalRevenueValue = new Label();
            lblTotalRevenueHeading = new Label();
            pnlTotalTransactions = new Panel();
            lblTotalTransactionsValue = new Label();
            lblTotalTransactionsHeading = new Label();
            pnlTotalItemsSold = new Panel();
            lblTotalItemsSoldValue = new Label();
            lblTotalItemsSoldHeading = new Label();
            pnlAverageSaleValue = new Panel();
            lblAverageSaleValue = new Label();
            label1 = new Label();
            lblReportResultsHeading = new Label();
            lblReportResultsDescription = new Label();
            dgvReportResults = new DataGridView();
            btnExportReport = new Button();
            btnRefreshReport = new Button();
            pnlReportFilters.SuspendLayout();
            pnlTotalRevenue.SuspendLayout();
            pnlTotalTransactions.SuspendLayout();
            pnlTotalItemsSold.SuspendLayout();
            pnlAverageSaleValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportResults).BeginInit();
            SuspendLayout();
            // 
            // lblReportsHeading
            // 
            lblReportsHeading.AutoSize = true;
            lblReportsHeading.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportsHeading.ForeColor = Color.MidnightBlue;
            lblReportsHeading.Location = new Point(20, 20);
            lblReportsHeading.Name = "lblReportsHeading";
            lblReportsHeading.Size = new Size(313, 32);
            lblReportsHeading.TabIndex = 0;
            lblReportsHeading.Text = "Reports  And Analytics";
            // 
            // lblReportsDescription
            // 
            lblReportsDescription.AutoSize = true;
            lblReportsDescription.ForeColor = Color.DimGray;
            lblReportsDescription.Location = new Point(27, 60);
            lblReportsDescription.Name = "lblReportsDescription";
            lblReportsDescription.Size = new Size(292, 15);
            lblReportsDescription.TabIndex = 1;
            lblReportsDescription.Text = "Generate and analyse your tuck shop business reports.";
            // 
            // pnlReportFilters
            // 
            pnlReportFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlReportFilters.Controls.Add(btnGenerateReport);
            pnlReportFilters.Controls.Add(cmbReportType);
            pnlReportFilters.Controls.Add(lblReportType);
            pnlReportFilters.Controls.Add(dtpReportEndDate);
            pnlReportFilters.Controls.Add(dtpReportStartDate);
            pnlReportFilters.Controls.Add(lblReportEndDate);
            pnlReportFilters.Controls.Add(lblReportStartDate);
            pnlReportFilters.Location = new Point(25, 100);
            pnlReportFilters.Name = "pnlReportFilters";
            pnlReportFilters.Size = new Size(950, 115);
            pnlReportFilters.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.MidnightBlue;
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(665, 42);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(150, 35);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(390, 43);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(220, 23);
            cmbReportType.TabIndex = 5;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportType.ForeColor = SystemColors.ActiveCaptionText;
            lblReportType.Location = new Point(388, 18);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(97, 17);
            lblReportType.TabIndex = 4;
            lblReportType.Text = "Report Type";
            // 
            // dtpReportEndDate
            // 
            dtpReportEndDate.Format = DateTimePickerFormat.Short;
            dtpReportEndDate.Location = new Point(200, 43);
            dtpReportEndDate.Name = "dtpReportEndDate";
            dtpReportEndDate.Size = new Size(150, 23);
            dtpReportEndDate.TabIndex = 3;
            // 
            // dtpReportStartDate
            // 
            dtpReportStartDate.Format = DateTimePickerFormat.Short;
            dtpReportStartDate.Location = new Point(20, 43);
            dtpReportStartDate.Name = "dtpReportStartDate";
            dtpReportStartDate.Size = new Size(150, 23);
            dtpReportStartDate.TabIndex = 2;
            // 
            // lblReportEndDate
            // 
            lblReportEndDate.AutoSize = true;
            lblReportEndDate.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportEndDate.ForeColor = SystemColors.ActiveCaptionText;
            lblReportEndDate.Location = new Point(200, 18);
            lblReportEndDate.Name = "lblReportEndDate";
            lblReportEndDate.Size = new Size(74, 17);
            lblReportEndDate.TabIndex = 1;
            lblReportEndDate.Text = "End Date";
            // 
            // lblReportStartDate
            // 
            lblReportStartDate.AutoSize = true;
            lblReportStartDate.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportStartDate.ForeColor = SystemColors.ActiveCaptionText;
            lblReportStartDate.Location = new Point(20, 18);
            lblReportStartDate.Name = "lblReportStartDate";
            lblReportStartDate.Size = new Size(84, 17);
            lblReportStartDate.TabIndex = 0;
            lblReportStartDate.Text = "From Date";
            // 
            // pnlTotalRevenue
            // 
            pnlTotalRevenue.BackColor = Color.White;
            pnlTotalRevenue.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalRevenue.Controls.Add(lblTotalRevenueValue);
            pnlTotalRevenue.Controls.Add(lblTotalRevenueHeading);
            pnlTotalRevenue.Location = new Point(25, 235);
            pnlTotalRevenue.Name = "pnlTotalRevenue";
            pnlTotalRevenue.Size = new Size(220, 115);
            pnlTotalRevenue.TabIndex = 7;
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.AutoSize = true;
            lblTotalRevenueValue.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRevenueValue.ForeColor = Color.MidnightBlue;
            lblTotalRevenueValue.Location = new Point(15, 50);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new Size(85, 28);
            lblTotalRevenueValue.TabIndex = 1;
            lblTotalRevenueValue.Text = "R 0.00";
            // 
            // lblTotalRevenueHeading
            // 
            lblTotalRevenueHeading.AutoSize = true;
            lblTotalRevenueHeading.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRevenueHeading.ForeColor = Color.DimGray;
            lblTotalRevenueHeading.Location = new Point(15, 15);
            lblTotalRevenueHeading.Name = "lblTotalRevenueHeading";
            lblTotalRevenueHeading.Size = new Size(89, 17);
            lblTotalRevenueHeading.TabIndex = 0;
            lblTotalRevenueHeading.Text = "Total Revenue";
            // 
            // pnlTotalTransactions
            // 
            pnlTotalTransactions.BackColor = Color.White;
            pnlTotalTransactions.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalTransactions.Controls.Add(lblTotalTransactionsValue);
            pnlTotalTransactions.Controls.Add(lblTotalTransactionsHeading);
            pnlTotalTransactions.Location = new Point(265, 235);
            pnlTotalTransactions.Name = "pnlTotalTransactions";
            pnlTotalTransactions.Size = new Size(220, 115);
            pnlTotalTransactions.TabIndex = 2;
            // 
            // lblTotalTransactionsValue
            // 
            lblTotalTransactionsValue.AutoSize = true;
            lblTotalTransactionsValue.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTransactionsValue.ForeColor = Color.MidnightBlue;
            lblTotalTransactionsValue.Location = new Point(15, 50);
            lblTotalTransactionsValue.Name = "lblTotalTransactionsValue";
            lblTotalTransactionsValue.Size = new Size(26, 28);
            lblTotalTransactionsValue.TabIndex = 1;
            lblTotalTransactionsValue.Text = "0";
            // 
            // lblTotalTransactionsHeading
            // 
            lblTotalTransactionsHeading.AutoSize = true;
            lblTotalTransactionsHeading.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTransactionsHeading.ForeColor = Color.DimGray;
            lblTotalTransactionsHeading.Location = new Point(15, 15);
            lblTotalTransactionsHeading.Name = "lblTotalTransactionsHeading";
            lblTotalTransactionsHeading.Size = new Size(112, 17);
            lblTotalTransactionsHeading.TabIndex = 0;
            lblTotalTransactionsHeading.Text = "Total Transactions";
            // 
            // pnlTotalItemsSold
            // 
            pnlTotalItemsSold.BackColor = Color.White;
            pnlTotalItemsSold.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalItemsSold.Controls.Add(lblTotalItemsSoldValue);
            pnlTotalItemsSold.Controls.Add(lblTotalItemsSoldHeading);
            pnlTotalItemsSold.Location = new Point(505, 235);
            pnlTotalItemsSold.Name = "pnlTotalItemsSold";
            pnlTotalItemsSold.Size = new Size(220, 115);
            pnlTotalItemsSold.TabIndex = 2;
            // 
            // lblTotalItemsSoldValue
            // 
            lblTotalItemsSoldValue.AutoSize = true;
            lblTotalItemsSoldValue.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalItemsSoldValue.ForeColor = Color.MidnightBlue;
            lblTotalItemsSoldValue.Location = new Point(15, 50);
            lblTotalItemsSoldValue.Name = "lblTotalItemsSoldValue";
            lblTotalItemsSoldValue.Size = new Size(26, 28);
            lblTotalItemsSoldValue.TabIndex = 1;
            lblTotalItemsSoldValue.Text = "0";
            // 
            // lblTotalItemsSoldHeading
            // 
            lblTotalItemsSoldHeading.AutoSize = true;
            lblTotalItemsSoldHeading.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalItemsSoldHeading.ForeColor = Color.DimGray;
            lblTotalItemsSoldHeading.Location = new Point(15, 15);
            lblTotalItemsSoldHeading.Name = "lblTotalItemsSoldHeading";
            lblTotalItemsSoldHeading.Size = new Size(101, 17);
            lblTotalItemsSoldHeading.TabIndex = 0;
            lblTotalItemsSoldHeading.Text = "Total Items Sold";
            // 
            // pnlAverageSaleValue
            // 
            pnlAverageSaleValue.BackColor = Color.White;
            pnlAverageSaleValue.BorderStyle = BorderStyle.FixedSingle;
            pnlAverageSaleValue.Controls.Add(lblAverageSaleValue);
            pnlAverageSaleValue.Controls.Add(label1);
            pnlAverageSaleValue.Location = new Point(745, 235);
            pnlAverageSaleValue.Name = "pnlAverageSaleValue";
            pnlAverageSaleValue.Size = new Size(220, 115);
            pnlAverageSaleValue.TabIndex = 2;
            // 
            // lblAverageSaleValue
            // 
            lblAverageSaleValue.AutoSize = true;
            lblAverageSaleValue.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAverageSaleValue.ForeColor = Color.MidnightBlue;
            lblAverageSaleValue.Location = new Point(15, 50);
            lblAverageSaleValue.Name = "lblAverageSaleValue";
            lblAverageSaleValue.Size = new Size(85, 28);
            lblAverageSaleValue.TabIndex = 1;
            lblAverageSaleValue.Text = "R 0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 0;
            label1.Text = "Average Sale Value";
            // 
            // lblReportResultsHeading
            // 
            lblReportResultsHeading.AutoSize = true;
            lblReportResultsHeading.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportResultsHeading.ForeColor = Color.MidnightBlue;
            lblReportResultsHeading.Location = new Point(25, 375);
            lblReportResultsHeading.Name = "lblReportResultsHeading";
            lblReportResultsHeading.Size = new Size(146, 22);
            lblReportResultsHeading.TabIndex = 2;
            lblReportResultsHeading.Text = "Report Results";
            // 
            // lblReportResultsDescription
            // 
            lblReportResultsDescription.AutoSize = true;
            lblReportResultsDescription.ForeColor = Color.DimGray;
            lblReportResultsDescription.Location = new Point(27, 410);
            lblReportResultsDescription.Name = "lblReportResultsDescription";
            lblReportResultsDescription.Size = new Size(327, 15);
            lblReportResultsDescription.TabIndex = 8;
            lblReportResultsDescription.Text = "Select a report type and click Generate Report to view results.";
            // 
            // dgvReportResults
            // 
            dgvReportResults.AllowUserToAddRows = false;
            dgvReportResults.AllowUserToDeleteRows = false;
            dgvReportResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportResults.ColumnHeadersVisible = false;
            dgvReportResults.Location = new Point(25, 445);
            dgvReportResults.MultiSelect = false;
            dgvReportResults.Name = "dgvReportResults";
            dgvReportResults.ReadOnly = true;
            dgvReportResults.RowHeadersVisible = false;
            dgvReportResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportResults.Size = new Size(950, 300);
            dgvReportResults.TabIndex = 9;
            // 
            // btnExportReport
            // 
            btnExportReport.BackColor = Color.MidnightBlue;
            btnExportReport.Cursor = Cursors.Hand;
            btnExportReport.FlatStyle = FlatStyle.Flat;
            btnExportReport.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportReport.ForeColor = Color.White;
            btnExportReport.Location = new Point(25, 765);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(150, 40);
            btnExportReport.TabIndex = 10;
            btnExportReport.Text = "Export";
            btnExportReport.UseVisualStyleBackColor = false;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // btnRefreshReport
            // 
            btnRefreshReport.BackColor = Color.Lime;
            btnRefreshReport.FlatStyle = FlatStyle.Flat;
            btnRefreshReport.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshReport.Location = new Point(825, 765);
            btnRefreshReport.Name = "btnRefreshReport";
            btnRefreshReport.Size = new Size(150, 40);
            btnRefreshReport.TabIndex = 11;
            btnRefreshReport.Text = "Refresh";
            btnRefreshReport.UseVisualStyleBackColor = false;
            btnRefreshReport.Click += btnRefreshReport_Click;
            // 
            // ReportsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btnRefreshReport);
            Controls.Add(btnExportReport);
            Controls.Add(dgvReportResults);
            Controls.Add(lblReportResultsDescription);
            Controls.Add(lblReportResultsHeading);
            Controls.Add(pnlAverageSaleValue);
            Controls.Add(pnlTotalItemsSold);
            Controls.Add(pnlTotalTransactions);
            Controls.Add(pnlTotalRevenue);
            Controls.Add(pnlReportFilters);
            Controls.Add(lblReportsDescription);
            Controls.Add(lblReportsHeading);
            Cursor = Cursors.Hand;
            Name = "ReportsControl";
            Size = new Size(1318, 812);
            pnlReportFilters.ResumeLayout(false);
            pnlReportFilters.PerformLayout();
            pnlTotalRevenue.ResumeLayout(false);
            pnlTotalRevenue.PerformLayout();
            pnlTotalTransactions.ResumeLayout(false);
            pnlTotalTransactions.PerformLayout();
            pnlTotalItemsSold.ResumeLayout(false);
            pnlTotalItemsSold.PerformLayout();
            pnlAverageSaleValue.ResumeLayout(false);
            pnlAverageSaleValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportsHeading;
        private Label lblReportsDescription;
        private Panel pnlReportFilters;
        private DateTimePicker dtpReportStartDate;
        private Label lblReportEndDate;
        private Label lblReportStartDate;
        private Label lblReportType;
        private DateTimePicker dtpReportEndDate;
        private Button btnGenerateReport;
        private ComboBox cmbReportType;
        private Panel pnlTotalRevenue;
        private Label lblTotalRevenueValue;
        private Label lblTotalRevenueHeading;
        private Panel pnlTotalTransactions;
        private Label lblTotalTransactionsHeading;
        private Label lblTotalTransactionsValue;
        private Panel pnlTotalItemsSold;
        private Label lblTotalItemsSoldHeading;
        private Label lblTotalItemsSoldValue;
        private Panel pnlAverageSaleValue;
        private Label lblAverageSaleValue;
        private Label label1;
        private Label lblReportResultsHeading;
        private Label lblReportResultsDescription;
        private DataGridView dgvReportResults;
        private Button btnExportReport;
        private Button btnRefreshReport;
    }
}
