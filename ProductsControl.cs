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
    public partial class ProductsControl : UserControl
    {
        private Panel _mainContentPanel;
        private string _userRole;

        public ProductsControl(Panel mainContentPanel, string userRole)
        {
            InitializeComponent();

            _mainContentPanel = mainContentPanel;
            _userRole = userRole;

            this.Dock = DockStyle.Fill;
            // Restrict product management for Cashiers.
            if (_userRole == "Cashier")
            {
                btnAddProduct.Visible = false;
                btnEditProduct.Visible = false;
                btnRestock.Visible = false;
            }
            LoadProducts();
        }

        private void LoadScreen(UserControl screen)
        {
            _mainContentPanel.Controls.Clear();

            screen.Dock = DockStyle.Fill;

            _mainContentPanel.Controls.Add(screen);
            screen.BringToFront();
        }



        public void ShowAddProductScreen()
        {
            LoadScreen(new AddProductControl(this));
        }

   private void LoadProducts()
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
                    c.CategoryName,
                    p.CostPrice,
                    p.SellingPrice,
                    p.QuantityInStock,
                    p.LowStockThreshold
                FROM dbo.Products p
                INNER JOIN dbo.Categories c
                    ON p.CategoryID = c.CategoryID
                WHERE p.IsActive = 1
                  AND (
                      @LowStockOnly = 0
                      OR p.QuantityInStock <= p.LowStockThreshold
                  )
                ORDER BY p.ProductName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@LowStockOnly", SqlDbType.Bit)
                            .Value = chkLowStockOnly.Checked;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable productsTable = new DataTable();
                            adapter.Fill(productsTable);

                            dgvProducts.AutoGenerateColumns = false;
                            dgvProducts.Rows.Clear();

                            foreach (DataRow row in productsTable.Rows)
                            {
                                int rowIndex = dgvProducts.Rows.Add(
                                    row["ProductID"],
                                    row["ProductName"],
                                    row["CategoryName"],
                                    row["CostPrice"],
                                    row["SellingPrice"],
                                    row["QuantityInStock"]
                                );

                                long quantity =
                                    Convert.ToInt64(row["QuantityInStock"]);

                                long threshold =
                                    Convert.ToInt64(row["LowStockThreshold"]);

                                if (quantity <= threshold)
                                {
                                    dgvProducts.Rows[rowIndex]
                                        .DefaultCellStyle.BackColor =
                                        Color.MistyRose;

                                    dgvProducts.Rows[rowIndex]
                                        .DefaultCellStyle.ForeColor =
                                        Color.DarkRed;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load products.\n\n" + ex.Message,
                    "Products Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void RefreshProducts()
        {
            LoadProducts();
        }



        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (_userRole != "Owner")
            {
                MessageBox.Show(
                    "You are not authorized to perform this action.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            AddProductControl addProduct = new AddProductControl(this);
            LoadScreen(addProduct);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchProduct.Text.Trim();


         try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
            SELECT
                p.ProductID,
                p.ProductName,
                c.CategoryName,
                p.CostPrice,
                p.SellingPrice,
                p.QuantityInStock,
                p.LowStockThreshold
            FROM dbo.Products p
            INNER JOIN dbo.Categories c
                ON p.CategoryID = c.CategoryID
            WHERE p.IsActive = 1
              AND (
                  p.ProductName LIKE @Search
                  OR p.SKU LIKE @Search
              )
              AND (
                  @LowStockOnly = 0
                  OR p.QuantityInStock <= p.LowStockThreshold
              )
            ORDER BY p.ProductName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Search", SqlDbType.NVarChar, 150)
                            .Value = "%" + searchText + "%";

                        command.Parameters.Add("@LowStockOnly", SqlDbType.Bit)
                            .Value = chkLowStockOnly.Checked;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable productsTable = new DataTable();
                            adapter.Fill(productsTable);

                            dgvProducts.Rows.Clear();

                            foreach (DataRow row in productsTable.Rows)
                            {
                                int rowIndex = dgvProducts.Rows.Add(
                                    row["ProductID"],
                                    row["ProductName"],
                                    row["CategoryName"],
                                    row["CostPrice"],
                                    row["SellingPrice"],
                                    row["QuantityInStock"]
                                );

                                long quantity = Convert.ToInt64(row["QuantityInStock"]);
                                long threshold = Convert.ToInt64(row["LowStockThreshold"]);

                                if (quantity <= threshold)
                                {
                                    dgvProducts.Rows[rowIndex].DefaultCellStyle.BackColor =
                                        Color.MistyRose;

                                    dgvProducts.Rows[rowIndex].DefaultCellStyle.ForeColor =
                                        Color.DarkRed;
                                }
                            }
                        }
                    }
                }

                if (dgvProducts.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No products were found matching your search.",
                        "Search Results",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not search for products.\n\n" + ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

}


        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (_userRole != "Owner")
            {
                MessageBox.Show(
                    "You are not authorized to perform this action.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            RestockControl restock = new RestockControl(_mainContentPanel, _userRole); LoadScreen(restock);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (_userRole != "Owner")
            {
                MessageBox.Show(
                    "You are not authorized to perform this action.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a product to edit.",
                    "No Product Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int productID = Convert.ToInt32(
                dgvProducts.SelectedRows[0].Cells["colProductID"].Value);

            EditProductControl editProduct =
                new EditProductControl(productID, _mainContentPanel, _userRole);

            LoadScreen(editProduct);
        }

        private void chkLowStockOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}



