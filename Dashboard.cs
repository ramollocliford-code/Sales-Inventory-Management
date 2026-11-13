using System;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Sales_Inventory_Management
{
    public partial class Dashboard : Form
    {
        private string _username;
        private string _userRole;
        private LOGIN _loginForm;
        public Dashboard(string username, string userRole, LOGIN loginForm)
        {
            InitializeComponent();
            _username = username;
            _userRole = userRole;
            _loginForm = loginForm;
            // Restrict navigation for Cashier accounts.
            if (_userRole == "Cashier")
            {
                btnInventory.Visible = false;
                btnReports.Visible = false;
            }
            dgvRecentSales.AutoGenerateColumns = false;
            colSaleID.DataPropertyName = "SaleID";
            colProduct.DataPropertyName = "Product";
            colQuantity.DataPropertyName = "Quantity";
            colTotal.DataPropertyName = "Total";
            colSaleDate.DataPropertyName = "Date & Time";
            StyleRecentSalesGrid();
            LoadDashboardStatistics();
            LoadRecentSales();
            btnSettings.Click += btnSettings_Click;
        }
        private void StyleRecentSalesGrid()
        {
            dgvRecentSales.EnableHeadersVisualStyles = false;

            // Grid background
            dgvRecentSales.BackgroundColor = Color.White;
            dgvRecentSales.GridColor = Color.LightGray;

            // Normal cell text
            dgvRecentSales.DefaultCellStyle.BackColor = Color.White;
            dgvRecentSales.DefaultCellStyle.ForeColor = Color.Black;

            // Row text
            dgvRecentSales.RowsDefaultCellStyle.BackColor = Color.White;
            dgvRecentSales.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Selected cells
            dgvRecentSales.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvRecentSales.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Alternating rows
            dgvRecentSales.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 247, 250);

            dgvRecentSales.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Column headers
            dgvRecentSales.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvRecentSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvRecentSales.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            // Force every individual column to use black text
            foreach (DataGridViewColumn column in dgvRecentSales.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.BackColor = Color.White;
                column.DefaultCellStyle.SelectionForeColor = Color.Black;
            }

            dgvRecentSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadDashboardStatistics()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    COUNT(*) AS TotalProducts,

                    SUM(CASE
                        WHEN QuantityInStock <= LowStockThreshold
                        THEN 1 ELSE 0
                    END) AS LowStockProducts,

                    SUM(CASE
                        WHEN QuantityInStock = 0
                        THEN 1 ELSE 0
                    END) AS OutOfStockProducts,

                    ISNULL(SUM(QuantityInStock * CostPrice), 0)
                    AS InventoryValue

                FROM dbo.Products
                WHERE IsActive = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblTotalProductsValue.Text =
                                    reader["TotalProducts"].ToString();

                                lblLowStockValue.Text =
                                    reader["LowStockProducts"].ToString();

                                lblInventoryValueAmount.Text =
                                    "R " + Convert.ToDecimal(
                                        reader["InventoryValue"]).ToString("N2");
                                lblTodaysSalesValue.Text = "R 0.00";
                            }
                        }
                        using (SqlCommand salesCommand = new SqlCommand(@"
    SELECT ISNULL(SUM(TotalAmount), 0)
    FROM dbo.Sales
    WHERE SaleDate >= @StartDate
      AND SaleDate < @EndDate;", connection))
                        {
                            salesCommand.Parameters.AddWithValue(
                                "@StartDate", DateTime.Today);

                            salesCommand.Parameters.AddWithValue(
                                "@EndDate", DateTime.Today.AddDays(1));

                            decimal todaysSales = Convert.ToDecimal(
                                salesCommand.ExecuteScalar());

                            lblTodaysSalesValue.Text =
                                "R " + todaysSales.ToString("N2");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load dashboard statistics.\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void LoadRecentSales()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    string query = @"
    SELECT TOP 50
        s.SaleID,
        p.ProductName AS Product,
        si.Quantity,
        si.Subtotal AS Total,
        s.SaleDate AS [Date & Time]
    FROM dbo.Sales s
    INNER JOIN dbo.SaleItems si
        ON s.SaleID = si.SaleID
    INNER JOIN dbo.Products p
        ON si.ProductID = p.ProductID
    ORDER BY s.SaleDate DESC, s.SaleID DESC;";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable sales = new DataTable();
                        adapter.Fill(sales);

                        dgvRecentSales.DataSource = sales;
                        StyleRecentSalesGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load recent sales.\n\n" + ex.Message,
                    "Recent Sales Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        private void LoadScreen(UserControl screen)
        {
            pnlMainContent.Controls.Clear();

            screen.Dock = DockStyle.Fill;

            pnlMainContent.Controls.Add(screen);
            screen.BringToFront();
        }

        public void ShowAddProductScreen()
        {
            ProductsControl productsScreen = new ProductsControl(pnlMainContent, _userRole);

            LoadScreen(productsScreen);

            AddProductControl addProduct = new AddProductControl(productsScreen);

            LoadScreen(addProduct);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            LoadScreen(new ProductsControl(pnlMainContent, _userRole));
        }

        private void pnlMainContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            pnlMainContent.Controls.Add(lblOverviewHeading);
            pnlMainContent.Controls.Add(lblOverviewDescription);

            pnlMainContent.Controls.Add(pnlTotalProducts);
            pnlMainContent.Controls.Add(pnlLowStoc);
            pnlMainContent.Controls.Add(pnlTodaysSales);
            pnlMainContent.Controls.Add(pnlInventoryValue);

            pnlMainContent.Controls.Add(lblRecentSalesHeading);
            pnlMainContent.Controls.Add(dgvRecentSales);

            lblPageTitle.Text = "Dashboard Overview";

            LoadDashboardStatistics();
            LoadRecentSales();


        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadScreen(new InventoryControl(pnlMainContent));
            lblPageTitle.Text = "Inventory Management";
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            LoadScreen(new SalesControl());

            lblPageTitle.Text = "Record a Sale";

        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            LoadScreen(new SalesHistoryControl());
            lblPageTitle.Text = "Sales History";
            
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadScreen(new ReportsControl());

            lblPageTitle.Text = "Reports & Analytics";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsControl settings =
                new SettingsControl(_username, _userRole, pnlMainContent);

            LoadScreen(settings);

            lblPageTitle.Text = "Settings";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Are you sure you want to log out?",
           "Confirm Logout",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _loginForm.ClearLoginPassword();

                _loginForm.Show();
                _loginForm.Activate();

                this.Close();
            }
        }
    }
}
