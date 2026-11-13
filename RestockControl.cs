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
    public partial class RestockControl : UserControl
    {
        private Panel _mainContentPanel;
        private ProductsControl _productsScreenControl;
        private readonly string _userRole;

        public RestockControl(Panel mainContentPanel, string userRole)
        {
            InitializeComponent();

            _mainContentPanel = mainContentPanel;
            _userRole = userRole;

            LoadProducts();
        }


        private void LoadProducts()
        {
            try
            {
                cmbProducts.Items.Clear();

                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT ProductID, ProductName, QuantityInStock
                FROM dbo.Products
                WHERE IsActive = 1
                ORDER BY ProductName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RestockProductItem product = new RestockProductItem
                            {
                                ProductID = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                QuantityInStock = reader.GetInt64(2)
                            };

                            cmbProducts.Items.Add(product);
                        }
                    }
                }

                cmbProducts.SelectedIndex = -1;
                lblCurrentStock.Text = "Select a product";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load products for restocking.\n\n" + ex.Message,
                    "Restock Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is RestockProductItem product)
            {
                lblCurrentStock.Text = "Current stock: " +
                    product.QuantityInStock.ToString("N0");
            }
            else
            {
                lblCurrentStock.Text = "Select a product";
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            // Make sure a product has been selected.
            if (cmbProducts.SelectedItem is not RestockProductItem product)
            {
                MessageBox.Show(
                    "Please select a product to restock.",
                    "Product Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validate the quantity.
            if (!long.TryParse(txtRestockQuantity.Text.Trim(), out long quantity)
                || quantity <= 0)
            {
                MessageBox.Show(
                    "Enter a valid quantity greater than zero.",
                    "Invalid Quantity",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtRestockQuantity.Focus();
                return;
            }

            string notes = txtRestockNotes.Text.Trim();

            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Add the new quantity to the existing stock.
                            string updateQuery = @"
                        UPDATE dbo.Products
                        SET QuantityInStock = QuantityInStock + @Quantity
                        WHERE ProductID = @ProductID
                          AND IsActive = 1
                          AND QuantityInStock <= 9223372036854775807 - @Quantity;

                        SELECT @@ROWCOUNT;";

                            int rowsUpdated;

                            using (SqlCommand updateCommand =
                                   new SqlCommand(updateQuery, connection, transaction))
                            {
                                updateCommand.Parameters.Add(
                                    "@Quantity", SqlDbType.BigInt).Value = quantity;

                                updateCommand.Parameters.Add(
                                    "@ProductID", SqlDbType.Int).Value = product.ProductID;

                                rowsUpdated = Convert.ToInt32(
                                    updateCommand.ExecuteScalar());
                            }

                            if (rowsUpdated != 1)
                            {
                                throw new InvalidOperationException(
                                    "The stock could not be updated. The product may be inactive, " +
                                    "or the quantity would exceed the supported limit.");
                            }

                            // Read the new stock quantity.
                            long newStock;

                            string stockQuery = @"
                        SELECT QuantityInStock
                        FROM dbo.Products
                        WHERE ProductID = @ProductID;";

                            using (SqlCommand stockCommand =
                                   new SqlCommand(stockQuery, connection, transaction))
                            {
                                stockCommand.Parameters.Add(
                                    "@ProductID", SqlDbType.Int).Value = product.ProductID;

                                newStock = Convert.ToInt64(stockCommand.ExecuteScalar());
                            }

                            // Record the restocking in the stock movement history.
                            string movementQuery = @"
                        INSERT INTO dbo.StockMovements
                            (ProductID, MovementType, QuantityChange,
                             QuantityAfter, Notes)
                        VALUES
                            (@ProductID, 'Restock', @Quantity,
                             @QuantityAfter, @Notes);";

                            using (SqlCommand movementCommand =
                                   new SqlCommand(movementQuery, connection, transaction))
                            {
                                movementCommand.Parameters.Add(
                                    "@ProductID", SqlDbType.Int).Value = product.ProductID;

                                movementCommand.Parameters.Add(
                                    "@Quantity", SqlDbType.BigInt).Value = quantity;

                                movementCommand.Parameters.Add(
                                    "@QuantityAfter", SqlDbType.BigInt).Value = newStock;

                                movementCommand.Parameters.Add(
                                    "@Notes", SqlDbType.NVarChar, 500).Value =
                                    string.IsNullOrWhiteSpace(notes)
                                        ? DBNull.Value
                                        : notes;

                                movementCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            // Update the stock shown on the screen.
                            product.QuantityInStock = newStock;

                            lblCurrentStock.Text =
                                "Current stock: " + newStock.ToString("N0");

                            txtRestockQuantity.Clear();
                            txtRestockNotes.Clear();

                            MessageBox.Show(
                                $"Stock successfully increased by {quantity:N0} units.\n" +
                                $"New stock: {newStock:N0}",
                                "Restock Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ShowProductsScreen();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not restock the product.\n\n" + ex.Message,
                    "Restock Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ShowProductsScreen()
        {
            ProductsControl products = new ProductsControl(_mainContentPanel, _userRole);

            _mainContentPanel.Controls.Clear();

            products.Dock = DockStyle.Fill;

            _mainContentPanel.Controls.Add(products);

            products.BringToFront();
        }

        private void btnCancelRestock_Click(object sender, EventArgs e)
        {
            ShowProductsScreen();
        }
    }


}
    public class RestockProductItem
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public long QuantityInStock { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }

