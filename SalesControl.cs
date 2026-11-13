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

    public partial class SalesControl : UserControl
    {
        private DataTable currentSale;
        public SalesControl()
        {
            InitializeComponent();
            StyleSalesGrid();
            SetupCurrentSale();
            LoadProducts();

            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Card");
            cmbPaymentMethod.Items.Add("Other");

            cmbPaymentMethod.SelectedIndex = 0;
        }
        private void StyleSalesGrid()
        {
            dgvCurrentSale.EnableHeadersVisualStyles = false;

            dgvCurrentSale.BackgroundColor = Color.White;
            dgvCurrentSale.GridColor = Color.LightGray;

            dgvCurrentSale.DefaultCellStyle.BackColor = Color.White;
            dgvCurrentSale.DefaultCellStyle.ForeColor = Color.Black;

            dgvCurrentSale.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvCurrentSale.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvCurrentSale.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvCurrentSale.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvCurrentSale.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvCurrentSale.RowHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvCurrentSale.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
        }
        private void LoadProducts()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT ProductID, ProductName, SellingPrice, QuantityInStock
                FROM dbo.Products
                WHERE IsActive = 1
                ORDER BY ProductName;";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable products = new DataTable();

                        adapter.Fill(products);

                        cmbSaleProduct.DataSource = products;
                        cmbSaleProduct.DisplayMember = "ProductName";
                        cmbSaleProduct.ValueMember = "ProductID";
                        cmbSaleProduct.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load products: " + ex.Message,
                    "Product Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void SetupCurrentSale()
        {
            currentSale = new DataTable();

            currentSale.Columns.Add("ProductID", typeof(int));
            currentSale.Columns.Add("ProductName", typeof(string));
            currentSale.Columns.Add("Quantity", typeof(long));
            currentSale.Columns.Add("UnitPrice", typeof(decimal));
            currentSale.Columns.Add("Subtotal", typeof(decimal));

            dgvCurrentSale.DataSource = currentSale;
        }
        private void CompleteSale()
        {
            if (currentSale.Rows.Count == 0)
            {
                MessageBox.Show("Please add products before completing the sale.");
                return;
            }

            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            decimal totalAmount = currentSale.AsEnumerable()
                .Sum(row => row.Field<decimal>("Subtotal"));

            string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            DialogResult confirmation = MessageBox.Show(
                "Complete this sale for " +
                totalAmount.ToString("C2", new System.Globalization.CultureInfo("en-ZA")) +
                "?",
                "Confirm Sale",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Save the main sale record.

                        string saleQuery = @"
                    INSERT INTO dbo.Sales
                    (Subtotal, TotalAmount, PaymentMethod)
                    OUTPUT INSERTED.SaleID
                    VALUES (@Subtotal, @TotalAmount, @PaymentMethod);";

                        long saleID;

                        using (SqlCommand command = new SqlCommand(
                            saleQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Subtotal", totalAmount);
                            command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                            command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                            saleID = Convert.ToInt64(command.ExecuteScalar());
                        }

                        // 2. Process every product in the sale.

                        foreach (DataRow row in currentSale.Rows)
                        {
                            int productID = Convert.ToInt32(row["ProductID"]);
                            long quantity = Convert.ToInt64(row["Quantity"]);
                            decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                            decimal subtotal = Convert.ToDecimal(row["Subtotal"]);

                            // Deduct stock, but only if enough stock remains.

                            string stockQuery = @"
                        UPDATE dbo.Products
                        SET QuantityInStock = QuantityInStock - @Quantity
                        WHERE ProductID = @ProductID
                        AND IsActive = 1
                        AND QuantityInStock >= @Quantity;";

                            using (SqlCommand command = new SqlCommand(
                                stockQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@ProductID", productID);

                                int affectedRows = command.ExecuteNonQuery();

                                if (affectedRows != 1)
                                {
                                    throw new Exception(
                                        "Insufficient stock or inactive product detected. " +
                                        "The sale could not be completed.");
                                }
                            }

                            // Save the individual sale item.

                            // Save the individual sale item.

                            string itemQuery = @"
    INSERT INTO dbo.SaleItems
    (SaleID, ProductID, ProductName, Quantity, UnitPrice, Subtotal)
    VALUES
    (@SaleID, @ProductID, @ProductName, @Quantity, @UnitPrice, @Subtotal);";

                            using (SqlCommand command = new SqlCommand(
                                itemQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@SaleID", saleID);
                                command.Parameters.AddWithValue("@ProductID", productID);

                                command.Parameters.Add("@ProductName", SqlDbType.NVarChar, 150).Value =
                                    row["ProductName"].ToString();

                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                command.Parameters.AddWithValue("@Subtotal", subtotal);

                                command.ExecuteNonQuery();
                            }

                            // Record the stock movement.

                            string movementQuery = @"
                        INSERT INTO dbo.StockMovements
                        (ProductID, MovementType, QuantityChange,
                         QuantityAfter, Notes, MovementDate)
                        SELECT
                            @ProductID,
                            'Sale',
                            -@Quantity,
                            QuantityInStock,
                            @Notes,
                            GETDATE()
                        FROM dbo.Products
                        WHERE ProductID = @ProductID;";

                            using (SqlCommand command = new SqlCommand(
                                movementQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ProductID", productID);
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue(
                                    "@Notes", "Sale #" + saleID);

                                command.ExecuteNonQuery();
                            }
                        }

                        // 3. Commit the complete transaction.

                        transaction.Commit();

                        // Open the receipt after the sale has been permanently saved.
                        using (ReceiptForm receipt = new ReceiptForm(saleID))
                        {
                            receipt.ShowDialog();
                        }
                        // 4. Reset the sales screen.

                        currentSale.Clear();
                        CalculateSaleTotal();

                        numSaleQuantity.Value = 1;
                        cmbSaleProduct.SelectedIndex = -1;
                        cmbPaymentMethod.SelectedIndex = 0;

                        lblAvailableStockValue.Text = "Select a product";

                        LoadProducts();
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch
                        {
                            // The transaction may already have been rolled back.
                        }

                        MessageBox.Show(
                            "The sale could not be completed.\n\n" + ex.Message,
                            "Sale Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void cmbSaleProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSaleProduct.SelectedIndex == -1)
            {
                lblAvailableStockValue.Text = "Select a product";
                return;
            }

            DataRowView selectedProduct = cmbSaleProduct.SelectedItem as DataRowView;

            if (selectedProduct != null)
            {
                long availableStock = Convert.ToInt64(selectedProduct["QuantityInStock"]);

                lblAvailableStockValue.Text = availableStock.ToString("N0") + " units";
            }
        }

        private void btnAddToSale_Click(object sender, EventArgs e)
        {
            if (cmbSaleProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            DataRowView selectedProduct = cmbSaleProduct.SelectedItem as DataRowView;

            if (selectedProduct == null)
                return;

            int productID = Convert.ToInt32(selectedProduct["ProductID"]);
            string productName = selectedProduct["ProductName"].ToString();
            decimal unitPrice = Convert.ToDecimal(selectedProduct["SellingPrice"]);
            long availableStock = Convert.ToInt64(selectedProduct["QuantityInStock"]);
            long quantity = Convert.ToInt64(numSaleQuantity.Value);

            if (quantity > availableStock)
            {
                MessageBox.Show("The requested quantity exceeds available stock.");
                return;
            }

            DataRow existingRow = currentSale.AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ProductID") == productID);

            long totalQuantity = quantity;

            if (existingRow != null)
            {
                totalQuantity += existingRow.Field<long>("Quantity");
            }

            if (totalQuantity > availableStock)
            {
                MessageBox.Show("The total quantity in this sale exceeds available stock.");
                return;
            }

            decimal subtotal = totalQuantity * unitPrice;

            if (existingRow != null)
            {
                existingRow["Quantity"] = totalQuantity;
                existingRow["Subtotal"] = subtotal;
            }
            else
            {
                currentSale.Rows.Add(
                    productID,
                    productName,
                    quantity,
                    unitPrice,
                    subtotal
                );
            }

            CalculateSaleTotal();

            numSaleQuantity.Value = 1;
        }
        private void CalculateSaleTotal()
        {
            decimal total = 0;

            foreach (DataRow row in currentSale.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }

            lblSubtotalValue.Text = total.ToString("C2", new System.Globalization.CultureInfo("en-ZA"));

            lblTotalValue.Text = total.ToString("C2", new System.Globalization.CultureInfo("en-ZA"));
        }

        private void btnRemoveSaleItem_Click(object sender, EventArgs e)
        {
            if (dgvCurrentSale.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a product to remove.",
                    "No Product Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int productID = Convert.ToInt32(
                dgvCurrentSale.SelectedRows[0].Cells["colSaleProductID"].Value);

            DataRow rowToRemove = currentSale.AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ProductID") == productID);

            if (rowToRemove != null)
            {
                currentSale.Rows.Remove(rowToRemove);
            }

            CalculateSaleTotal();
        }

        private void btnClearSale_Click(object sender, EventArgs e)
        {
            if (currentSale.Rows.Count == 0)
            {
                MessageBox.Show("There are no products to clear.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear the current sale?",
                "Clear Sale",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                currentSale.Clear();

                CalculateSaleTotal();

                cmbSaleProduct.SelectedIndex = -1;
                numSaleQuantity.Value = 1;

                lblAvailableStockValue.Text = "Select a product";

                cmbPaymentMethod.SelectedIndex = 0;
            }
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            CompleteSale();
        }
    }
}
