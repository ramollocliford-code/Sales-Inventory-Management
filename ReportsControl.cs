using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sales_Inventory_Management
{
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
            dgvReportResults.AutoGenerateColumns = true;
            cmbReportType.Items.AddRange(new string[]
{
    "Sales Report",
    "Daily Sales Summary",
    "Best-Selling Products",
    "Inventory Report",
    "Low-Stock Report",
    "Stock Movement Report"
});

            cmbReportType.SelectedIndex = 0;
        }
        private void UpdateSummaryCardHeadings(string reportType)
        {
            switch (reportType)
            {
                case "Sales Report":
                    lblTotalRevenueHeading.Text = "Total Revenue";
                    lblTotalTransactionsHeading.Text = "Transactions";
                    lblTotalItemsSoldHeading.Text = "Items Sold";
                    lblAverageSaleValue.Text = "Average Sale";
                    break;

                case "Daily Sales Summary":
                    lblTotalRevenueHeading.Text = "Total Revenue";
                    lblTotalTransactionsHeading.Text = "Transactions";
                    lblTotalItemsSoldHeading.Text = "Items Sold";
                    lblAverageSaleValue.Text = "Average Sale";
                    break;

                case "Best-Selling Products":
                    lblTotalRevenueHeading.Text = "Revenue Generated";
                    lblTotalTransactionsHeading.Text = "Product Transactions";
                    lblTotalItemsSoldHeading.Text = "Units Sold";
                    lblAverageSaleValue.Text = "Products Sold";
                    break;

                case "Inventory Report":
                    lblTotalRevenueHeading.Text = "Total Stock Value";
                    lblTotalTransactionsHeading.Text = "Active Products";
                    lblTotalItemsSoldHeading.Text = "Units in Stock";
                    lblAverageSaleValue.Text = "Not Applicable";
                    break;

                case "Low-Stock Report":
                    lblTotalRevenueHeading.Text = "Products Requiring Attention";
                    lblTotalTransactionsHeading.Text = "Out of Stock";
                    lblTotalItemsSoldHeading.Text = "Remaining Units";
                    lblAverageSaleValue.Text = "Units Needed";
                    break;

                case "Stock Movement Report":
                    lblTotalRevenueHeading.Text = "Total Movements";
                    lblTotalTransactionsHeading.Text = "Quantity Added";
                    lblTotalItemsSoldHeading.Text = "Quantity Removed";
                    lblAverageSaleValue.Text = "Products Affected";
                    break;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)

        {
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a report type.",
                    "Report Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dtpReportStartDate.Value.Date > dtpReportEndDate.Value.Date)
            {
                MessageBox.Show(
                    "The start date cannot be later than the end date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string reportType = cmbReportType.SelectedItem.ToString();
            UpdateSummaryCardHeadings(reportType);

            if (reportType == "Sales Report")
            {
                GenerateSalesReport();
            }
            else if (reportType == "Daily Sales Summary")
            {
                GenerateDailySalesSummary();
            }
            else if (reportType == "Best-Selling Products")
            {
                GenerateBestSellingProducts();
            }
            else if (reportType == "Inventory Report")
            {
                GenerateInventoryReport();
            }
            else if (reportType == "Low-Stock Report")
            {
                GenerateLowStockReport();
            }
            else if (reportType == "Stock Movement Report")
            {
                GenerateStockMovementReport();
            }
        }
        private void GenerateSalesReport()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    s.SaleID,
                    s.SaleDate,
                    s.TotalAmount,
                    s.PaymentMethod,
                    COUNT(si.SaleItemID) AS DifferentProducts,
                    SUM(si.Quantity) AS TotalItems
                FROM dbo.Sales s
                INNER JOIN dbo.SaleItems si
                    ON s.SaleID = si.SaleID
                WHERE s.SaleDate >= @StartDate
                  AND s.SaleDate < @EndDate
                GROUP BY
                    s.SaleID,
                    s.SaleDate,
                    s.TotalAmount,
                    s.PaymentMethod
                ORDER BY s.SaleDate DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StartDate", dtpReportStartDate.Value.Date);

                        command.Parameters.AddWithValue(
                            "@EndDate", dtpReportEndDate.Value.Date.AddDays(1));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dgvReportResults.AutoGenerateColumns = true;
                            dgvReportResults.Columns.Clear();
                            dgvReportResults.DataSource = null;
                            dgvReportResults.DataSource = table;
                            StyleReportGrid();
                            // Rename column headings
                            dgvReportResults.Columns["SaleID"].HeaderText = "Sale ID";
                            dgvReportResults.Columns["SaleDate"].HeaderText = "Sale Date & Time";
                            dgvReportResults.Columns["TotalAmount"].HeaderText = "Total Amount";
                            dgvReportResults.Columns["PaymentMethod"].HeaderText = "Payment Method";
                            dgvReportResults.Columns["DifferentProducts"].HeaderText = "Different Products";
                            dgvReportResults.Columns["TotalItems"].HeaderText = "Total Items Sold";

                            // Format monetary values as South African Rand
                            dgvReportResults.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
                            dgvReportResults.Columns["TotalAmount"].DefaultCellStyle.FormatProvider =
                                new System.Globalization.CultureInfo("en-ZA");
                            // Format sale date and time
                            dgvReportResults.Columns["SaleDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                            UpdateSalesReportSummary(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not generate the sales report.\n\n" + ex.Message,
                    "Sales Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void GenerateDailySalesSummary()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    CAST(SaleDate AS DATE) AS SaleDate,
                    COUNT(SaleID) AS TotalTransactions,
                    SUM(TotalAmount) AS TotalRevenue,
                    (
                        SELECT SUM(si.Quantity)
                        FROM dbo.SaleItems si
                        INNER JOIN dbo.Sales s2
                            ON si.SaleID = s2.SaleID
                        WHERE CAST(s2.SaleDate AS DATE) = CAST(s.SaleDate AS DATE)
                    ) AS TotalItemsSold
                FROM dbo.Sales s
                WHERE s.SaleDate >= @StartDate
                  AND s.SaleDate < @EndDate
                GROUP BY CAST(SaleDate AS DATE)
                ORDER BY SaleDate DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StartDate", dtpReportStartDate.Value.Date);

                        command.Parameters.AddWithValue(
                            "@EndDate", dtpReportEndDate.Value.Date.AddDays(1));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dgvReportResults.Columns.Clear();
                            dgvReportResults.DataSource = null;
                            dgvReportResults.DataSource = table;

                            StyleReportGrid();
                            dgvReportResults.Columns["TotalRevenue"].DefaultCellStyle.Format = "C2";
                            dgvReportResults.Columns["TotalRevenue"].DefaultCellStyle.FormatProvider =
                                new System.Globalization.CultureInfo("en-ZA");

                            dgvReportResults.Columns["SaleDate"].HeaderText = "Sale Date";
                            dgvReportResults.Columns["TotalTransactions"].HeaderText = "Transactions";
                            dgvReportResults.Columns["TotalRevenue"].HeaderText = "Total Revenue";
                            dgvReportResults.Columns["TotalItemsSold"].HeaderText = "Items Sold";
                            // Format daily sales date
                            dgvReportResults.Columns["SaleDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

                            UpdateDailySalesSummary(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not generate the daily sales summary.\n\n" + ex.Message,
                    "Daily Sales Summary Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void GenerateBestSellingProducts()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    p.ProductName,
                    p.SKU,
                    SUM(si.Quantity) AS TotalQuantitySold,
                    SUM(si.Subtotal) AS TotalRevenue,
                    COUNT(DISTINCT si.SaleID) AS NumberOfTransactions
                FROM dbo.SaleItems si
                INNER JOIN dbo.Products p
                    ON si.ProductID = p.ProductID
                INNER JOIN dbo.Sales s
                    ON si.SaleID = s.SaleID
                WHERE s.SaleDate >= @StartDate
                  AND s.SaleDate < @EndDate
                GROUP BY
                    p.ProductID,
                    p.ProductName,
                    p.SKU
                ORDER BY TotalQuantitySold DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StartDate", dtpReportStartDate.Value.Date);

                        command.Parameters.AddWithValue(
                            "@EndDate", dtpReportEndDate.Value.Date.AddDays(1));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dgvReportResults.Columns.Clear();
                            dgvReportResults.DataSource = null;
                            dgvReportResults.DataSource = table;

                            StyleReportGrid();

                            dgvReportResults.Columns["ProductName"].HeaderText = "Product Name";
                            dgvReportResults.Columns["SKU"].HeaderText = "SKU";
                            dgvReportResults.Columns["TotalQuantitySold"].HeaderText = "Quantity Sold";
                            dgvReportResults.Columns["TotalRevenue"].HeaderText = "Revenue Generated";
                            dgvReportResults.Columns["TotalRevenue"].DefaultCellStyle.Format = "C2";
                            dgvReportResults.Columns["TotalRevenue"].DefaultCellStyle.FormatProvider =
                                new System.Globalization.CultureInfo("en-ZA");
                            dgvReportResults.Columns["NumberOfTransactions"].HeaderText = "Transactions";

                            UpdateBestSellingProductsSummary(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not generate the best-selling products report.\n\n" + ex.Message,
                    "Best-Selling Products Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void GenerateInventoryReport()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    p.ProductID,
                    p.ProductName,
                    p.SKU,
                    c.CategoryName,
                    p.CostPrice,
                    p.SellingPrice,
                    p.QuantityInStock,
                    p.LowStockThreshold,
                    (p.QuantityInStock * p.CostPrice) AS StockValue
                FROM dbo.Products p
                LEFT JOIN dbo.Categories c
                    ON p.CategoryID = c.CategoryID
                WHERE p.IsActive = 1
                ORDER BY p.ProductName ASC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dgvReportResults.Columns.Clear();
                            dgvReportResults.DataSource = null;
                            dgvReportResults.DataSource = table;

                            StyleReportGrid();
                            // Format monetary columns as South African Rand
                            dgvReportResults.Columns["CostPrice"].DefaultCellStyle.Format = "C2";
                            dgvReportResults.Columns["SellingPrice"].DefaultCellStyle.Format = "C2";
                            dgvReportResults.Columns["StockValue"].DefaultCellStyle.Format = "C2";

                            var zarCulture = new System.Globalization.CultureInfo("en-ZA");

                            dgvReportResults.Columns["CostPrice"].DefaultCellStyle.FormatProvider = zarCulture;
                            dgvReportResults.Columns["SellingPrice"].DefaultCellStyle.FormatProvider = zarCulture;
                            dgvReportResults.Columns["StockValue"].DefaultCellStyle.FormatProvider = zarCulture;

                            dgvReportResults.Columns["ProductID"].HeaderText = "Product ID";
                            dgvReportResults.Columns["ProductName"].HeaderText = "Product Name";
                            dgvReportResults.Columns["SKU"].HeaderText = "SKU";
                            dgvReportResults.Columns["CategoryName"].HeaderText = "Category";
                            dgvReportResults.Columns["CostPrice"].HeaderText = "Cost Price";
                            dgvReportResults.Columns["SellingPrice"].HeaderText = "Selling Price";
                            dgvReportResults.Columns["QuantityInStock"].HeaderText = "Quantity in Stock";
                            dgvReportResults.Columns["LowStockThreshold"].HeaderText = "Low-Stock Threshold";
                            dgvReportResults.Columns["StockValue"].HeaderText = "Stock Value";

                            UpdateInventoryReportSummary(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not generate the inventory report.\n\n" + ex.Message,
                    "Inventory Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void GenerateLowStockReport()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    p.ProductName,
                    p.SKU,
                    c.CategoryName,
                    p.QuantityInStock,
                    p.LowStockThreshold,
                    CASE
                        WHEN p.QuantityInStock = 0
                            THEN 0
                        ELSE p.LowStockThreshold - p.QuantityInStock
                    END AS QuantityNeeded,
                    CASE
                        WHEN p.QuantityInStock = 0
                            THEN 'Out of Stock'
                        ELSE 'Low Stock'
                    END AS StockStatus
                FROM dbo.Products p
                LEFT JOIN dbo.Categories c
                    ON p.CategoryID = c.CategoryID
                WHERE p.IsActive = 1
                  AND p.QuantityInStock <= p.LowStockThreshold
                ORDER BY
                    p.QuantityInStock ASC,
                    p.ProductName ASC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dgvReportResults.Columns.Clear();
                            dgvReportResults.DataSource = null;
                            dgvReportResults.DataSource = table;

                            StyleReportGrid();

                            dgvReportResults.Columns["ProductName"].HeaderText = "Product Name";
                            dgvReportResults.Columns["SKU"].HeaderText = "SKU";
                            dgvReportResults.Columns["CategoryName"].HeaderText = "Category";
                            dgvReportResults.Columns["QuantityInStock"].HeaderText = "Current Stock";
                            dgvReportResults.Columns["LowStockThreshold"].HeaderText = "Low-Stock Threshold";
                            dgvReportResults.Columns["QuantityNeeded"].HeaderText = "Quantity Needed";
                            dgvReportResults.Columns["StockStatus"].HeaderText = "Stock Status";

                            UpdateLowStockReportSummary(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not generate the low-stock report.\n\n" + ex.Message,
                    "Low-Stock Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void GenerateStockMovementReport()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    sm.StockMovementID,
                    p.ProductID,
                    p.ProductName,
                    p.SKU,
                    sm.MovementType,
                    sm.QuantityChange,
                    sm.QuantityAfter,
                    sm.Notes,
                    sm.MovementDate
                FROM dbo.StockMovements sm
                INNER JOIN dbo.Products p
                    ON sm.ProductID = p.ProductID
                WHERE sm.MovementDate >= @StartDate
                  AND sm.MovementDate < @EndDate
                ORDER BY sm.MovementDate DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StartDate", dtpReportStartDate.Value.Date);

                        command.Parameters.AddWithValue(
                            "@EndDate", dtpReportEndDate.Value.Date.AddDays(1));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dgvReportResults.Columns.Clear();
                            dgvReportResults.DataSource = null;
                            dgvReportResults.DataSource = table;

                            StyleReportGrid();

                            dgvReportResults.Columns["StockMovementID"].HeaderText = "Movement ID";
                            dgvReportResults.Columns["ProductName"].HeaderText = "Product Name";
                            dgvReportResults.Columns["SKU"].HeaderText = "SKU";
                            dgvReportResults.Columns["MovementType"].HeaderText = "Movement Type";
                            dgvReportResults.Columns["QuantityChange"].HeaderText = "Quantity Change";
                            dgvReportResults.Columns["QuantityAfter"].HeaderText = "Quantity After";
                            dgvReportResults.Columns["Notes"].HeaderText = "Notes";
                            dgvReportResults.Columns["MovementDate"].HeaderText = "Movement Date";
                            // Format movement date and time
                            dgvReportResults.Columns["MovementDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                            UpdateStockMovementSummary(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not generate the stock movement report.\n\n" + ex.Message,
                    "Stock Movement Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void UpdateStockMovementSummary(DataTable table)
        {
            int totalMovements = table.Rows.Count;
            long totalQuantityAdded = 0;
            long totalQuantityRemoved = 0;
            int productsAffected = 0;

            HashSet<int> productIDs = new HashSet<int>();

            foreach (DataRow row in table.Rows)
            {
                long change = Convert.ToInt64(row["QuantityChange"]);

                if (change > 0)
                {
                    totalQuantityAdded += change;
                }
                else if (change < 0)
                {
                    totalQuantityRemoved += Math.Abs(change);
                }
                productsAffected = productIDs.Count;
            }
            productsAffected = productIDs.Count;

            lblTotalRevenueValue.Text = totalMovements.ToString("N0");
            lblTotalTransactionsValue.Text = totalQuantityAdded.ToString("N0");
            lblTotalItemsSoldValue.Text = totalQuantityRemoved.ToString("N0");
            lblAverageSaleValue.Text = productsAffected.ToString("N0");
        }
        private void UpdateLowStockReportSummary(DataTable table)
        {
            int totalProducts = table.Rows.Count;
            int outOfStock = 0;
            long totalCurrentStock = 0;
            long totalQuantityNeeded = 0;

            foreach (DataRow row in table.Rows)
            {
                if (row["StockStatus"].ToString() == "Out of Stock")
                {
                    outOfStock++;
                }

                totalCurrentStock += Convert.ToInt64(row["QuantityInStock"]);
                totalQuantityNeeded += Convert.ToInt64(row["QuantityNeeded"]);
            }

            lblTotalRevenueValue.Text = totalProducts.ToString("N0");
            lblTotalTransactionsValue.Text = outOfStock.ToString("N0");
            lblTotalItemsSoldValue.Text = totalCurrentStock.ToString("N0");
            lblAverageSaleValue.Text = totalQuantityNeeded.ToString("N0");
        }
        private void UpdateInventoryReportSummary(DataTable table)
        {
            int totalProducts = table.Rows.Count;
            long totalQuantity = 0;
            decimal totalStockValue = 0;

            foreach (DataRow row in table.Rows)
            {
                totalQuantity += Convert.ToInt64(row["QuantityInStock"]);
                totalStockValue += Convert.ToDecimal(row["StockValue"]);
            }

            lblTotalRevenueValue.Text = "R " + totalStockValue.ToString("N2");
            lblTotalTransactionsValue.Text = totalProducts.ToString("N0");
            lblTotalItemsSoldValue.Text = totalQuantity.ToString("N0");
            lblAverageSaleValue.Text = "R 0.00";
        }
        private void UpdateBestSellingProductsSummary(DataTable table)
        {
            decimal totalRevenue = 0;
            long totalItemsSold = 0;
            int totalProducts = table.Rows.Count;
            int totalTransactions = 0;

            foreach (DataRow row in table.Rows)
            {
                totalRevenue += Convert.ToDecimal(row["TotalRevenue"]);
                totalItemsSold += Convert.ToInt64(row["TotalQuantitySold"]);
                totalTransactions += Convert.ToInt32(row["NumberOfTransactions"]);
            }

            lblTotalRevenueValue.Text = "R " + totalRevenue.ToString("N2");
            lblTotalTransactionsValue.Text = totalTransactions.ToString("N0");
            lblTotalItemsSoldValue.Text = totalItemsSold.ToString("N0");
            lblAverageSaleValue.Text = totalProducts.ToString("N0");
        }
        private void UpdateDailySalesSummary(DataTable table)
        {
            decimal totalRevenue = 0;
            int totalTransactions = 0;
            long totalItemsSold = 0;
            decimal averageSaleValue = 0;

            foreach (DataRow row in table.Rows)
            {
                totalRevenue += Convert.ToDecimal(row["TotalRevenue"]);
                totalTransactions += Convert.ToInt32(row["TotalTransactions"]);
                totalItemsSold += Convert.ToInt64(row["TotalItemsSold"]);
            }

            if (totalTransactions > 0)
            {
                averageSaleValue = totalRevenue / totalTransactions;
            }

            lblTotalRevenueValue.Text = "R " + totalRevenue.ToString("N2");
            lblTotalTransactionsValue.Text = totalTransactions.ToString("N0");
            lblTotalItemsSoldValue.Text = totalItemsSold.ToString("N0");
            lblAverageSaleValue.Text = "R " + averageSaleValue.ToString("N2");
        }
        private void UpdateSalesReportSummary(DataTable table)
        {
            decimal totalRevenue = 0;
            int totalTransactions = table.Rows.Count;
            long totalItemsSold = 0;
            decimal averageSaleValue = 0;

            foreach (DataRow row in table.Rows)
            {
                totalRevenue += Convert.ToDecimal(row["TotalAmount"]);

                totalItemsSold += Convert.ToInt64(row["TotalItems"]);
            }

            if (totalTransactions > 0)
            {
                averageSaleValue = totalRevenue / totalTransactions;
            }

            lblTotalRevenueValue.Text =
                "R " + totalRevenue.ToString("N2");

            lblTotalTransactionsValue.Text =
                totalTransactions.ToString("N0");

            lblTotalItemsSoldValue.Text =
                totalItemsSold.ToString("N0");

            lblAverageSaleValue.Text =
                "R " + averageSaleValue.ToString("N2");
        }
        private void StyleReportGrid()
        {
            dgvReportResults.BackgroundColor = Color.White;
            dgvReportResults.ForeColor = Color.Black;

            dgvReportResults.DefaultCellStyle.BackColor = Color.White;
            dgvReportResults.DefaultCellStyle.ForeColor = Color.Black;

            dgvReportResults.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
            dgvReportResults.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvReportResults.ColumnHeadersVisible = true;
            dgvReportResults.EnableHeadersVisualStyles = false;

            dgvReportResults.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvReportResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvReportResults.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvReportResults.RowHeadersVisible = false;
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            if (dgvReportResults.DataSource == null ||
       dgvReportResults.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Please generate a report before exporting.",
                    "No Report Available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveDialog.Title = "Export Report";
                saveDialog.FileName = cmbReportType.SelectedItem.ToString()
                    .Replace(" ", "_") + ".csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer =
                            new StreamWriter(saveDialog.FileName, false,
                            System.Text.Encoding.UTF8))
                        {
                            // Write column headings
                            for (int i = 0; i < dgvReportResults.Columns.Count; i++)
                            {
                                writer.Write("\"" +
                                    dgvReportResults.Columns[i].HeaderText.Replace("\"", "\"\"")
                                    + "\"");

                                if (i < dgvReportResults.Columns.Count - 1)
                                    writer.Write(",");
                            }

                            writer.WriteLine();

                            // Write report rows
                            foreach (DataGridViewRow row in dgvReportResults.Rows)
                            {
                                if (row.IsNewRow)
                                    continue;

                                for (int i = 0; i < dgvReportResults.Columns.Count; i++)
                                {
                                    string value = row.Cells[i].Value?.ToString() ?? "";

                                    value = value.Replace("\"", "\"\"");

                                    writer.Write("\"" + value + "\"");

                                    if (i < dgvReportResults.Columns.Count - 1)
                                        writer.Write(",");
                                }

                                writer.WriteLine();
                            }
                        }

                        MessageBox.Show(
                            "Report exported successfully!",
                            "Export Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Could not export the report.\n\n" + ex.Message,
                            "Export Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a report type.",
                    "Report Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dtpReportStartDate.Value.Date > dtpReportEndDate.Value.Date)
            {
                MessageBox.Show(
                    "The start date cannot be later than the end date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string reportType = cmbReportType.SelectedItem.ToString();

            UpdateSummaryCardHeadings(reportType);

            switch (reportType)
            {
                case "Sales Report":
                    GenerateSalesReport();
                    break;

                case "Daily Sales Summary":
                    GenerateDailySalesSummary();
                    break;

                case "Best-Selling Products":
                    GenerateBestSellingProducts();
                    break;

                case "Inventory Report":
                    GenerateInventoryReport();
                    break;

                case "Low-Stock Report":
                    GenerateLowStockReport();
                    break;

                case "Stock Movement Report":
                    GenerateStockMovementReport();
                    break;
            }
        }
    }
}
