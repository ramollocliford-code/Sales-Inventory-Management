using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Sales_Inventory_Management
{
    public partial class SalesHistoryControl : UserControl
    {
        public SalesHistoryControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            StyleSalesHistoryGrid();
            StyleTransactionDetailsGrid();

            LoadSalesHistory();
        }
        private void StyleSalesHistoryGrid()
        {
            dgvSalesHistory.EnableHeadersVisualStyles = false;
            dgvSalesHistory.BackgroundColor = Color.White;
            dgvSalesHistory.GridColor = Color.LightGray;

            dgvSalesHistory.DefaultCellStyle.BackColor = Color.White;
            dgvSalesHistory.DefaultCellStyle.ForeColor = Color.Black;
            dgvSalesHistory.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvSalesHistory.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvSalesHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvSalesHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvSalesHistory.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void StyleTransactionDetailsGrid()
        {
            dgvTransactionDetails.EnableHeadersVisualStyles = false;
            dgvTransactionDetails.BackgroundColor = Color.White;
            dgvTransactionDetails.GridColor = Color.LightGray;

            dgvTransactionDetails.DefaultCellStyle.BackColor = Color.White;
            dgvTransactionDetails.DefaultCellStyle.ForeColor = Color.Black;
            dgvTransactionDetails.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvTransactionDetails.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvTransactionDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvTransactionDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvTransactionDetails.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
        }
        private void LoadSalesHistory()
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
                    ISNULL(SUM(si.Quantity), 0) AS TotalItems
                FROM dbo.Sales s
                LEFT JOIN dbo.SaleItems si
                    ON s.SaleID = si.SaleID
                GROUP BY
                    s.SaleID,
                    s.SaleDate,
                    s.TotalAmount,
                    s.PaymentMethod
                ORDER BY s.SaleDate DESC, s.SaleID DESC;";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvSalesHistory.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load sales history.\n\n" + ex.Message,
                    "Sales History Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void LoadSalesHistory(long saleID)
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
                    ISNULL(SUM(si.Quantity), 0) AS TotalItems
                FROM dbo.Sales s
                LEFT JOIN dbo.SaleItems si
                    ON s.SaleID = si.SaleID
                WHERE s.SaleID = @SaleID
                GROUP BY
                    s.SaleID,
                    s.SaleDate,
                    s.TotalAmount,
                    s.PaymentMethod
                ORDER BY s.SaleDate DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SaleID", saleID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dgvSalesHistory.DataSource = table;

                            if (table.Rows.Count == 0)
                            {
                                MessageBox.Show(
                                    "No sale was found with that ID.",
                                    "No Results",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not search sales history.\n\n" + ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void LoadSalesHistoryByDate(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                MessageBox.Show(
                    "The start date cannot be later than the end date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

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
                    ISNULL(SUM(si.Quantity), 0) AS TotalItems
                FROM dbo.Sales s
                LEFT JOIN dbo.SaleItems si
                    ON s.SaleID = si.SaleID
                WHERE s.SaleDate >= @StartDate
                  AND s.SaleDate < @EndDate
                GROUP BY
                    s.SaleID,
                    s.SaleDate,
                    s.TotalAmount,
                    s.PaymentMethod
                ORDER BY s.SaleDate DESC, s.SaleID DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate.Date);
                        command.Parameters.AddWithValue("@EndDate", endDate.Date.AddDays(1));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dgvSalesHistory.DataSource = table;

                            if (table.Rows.Count == 0)
                            {
                                MessageBox.Show(
                                    "No sales were found within the selected date range.",
                                    "No Results",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not filter sales by date.\n\n" + ex.Message,
                    "Date Filter Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void dgvSalesHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSalesHistory.CurrentRow == null)
                return;

            if (dgvSalesHistory.CurrentRow.Cells["colHistorySaleID"].Value == null)
                return;

            long saleID = Convert.ToInt64(
                dgvSalesHistory.CurrentRow.Cells["colHistorySaleID"].Value);

            LoadTransactionDetails(saleID);
        }
        private void LoadTransactionDetails(long saleID)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    p.ProductName,
                    si.Quantity,
                    si.UnitPrice,
                    si.Subtotal,
                    p.SKU
                FROM dbo.SaleItems si
                INNER JOIN dbo.Products p
                    ON si.ProductID = p.ProductID
                WHERE si.SaleID = @SaleID
                ORDER BY p.ProductName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SaleID", saleID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dgvTransactionDetails.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load transaction details.\n\n" + ex.Message,
                    "Transaction Details Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchSaleID.Text.Trim();

            // Search by Sale ID if the textbox contains a value
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                if (!long.TryParse(searchText, out long saleID))
                {
                    MessageBox.Show(
                        "Please enter a valid Sale ID.",
                        "Invalid Sale ID",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                LoadSalesHistory(saleID);
            }
            else
            {
                // Otherwise, search using the selected date range
                LoadSalesHistoryByDate(
                    dtpStartDate.Value.Date,
                    dtpEndDate.Value.Date);
            }
        }

        private void btnRefreshHistory_Click(object sender, EventArgs e)
        {
            // Clear the Sale ID search
            txtSearchSaleID.Clear();

            // Reset the date range
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

            // Reload all sales
            LoadSalesHistory();

            // Clear the transaction details grid
            dgvTransactionDetails.DataSource = null;
        }

        private void btnReprintReceipt_Click(object sender, EventArgs e)
        {
            if (dgvSalesHistory.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a sale before opening its receipt.",
                    "No Sale Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Retrieve the selected Sale ID.
            long saleID = Convert.ToInt64(
                dgvSalesHistory.CurrentRow.Cells["colHistorySaleID"].Value);

            // Open the receipt for the selected sale.
            using (ReceiptForm receipt = new ReceiptForm(saleID))
            {
                receipt.ShowDialog();
            }
        }
    }
}
