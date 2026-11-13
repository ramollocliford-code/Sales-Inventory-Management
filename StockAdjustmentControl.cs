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
    public partial class StockAdjustmentControl : UserControl
    {
        public Action ReturnToInventory { get; set; }
        public StockAdjustmentControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadProducts();

            cmbAdjustmentType.Items.Add("Increase Stock");
            cmbAdjustmentType.Items.Add("Decrease Stock");

            cmbAdjustmentType.SelectedIndex = -1;
        }
        private void LoadProducts()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT ProductID, ProductName
                FROM dbo.Products
                WHERE IsActive = 1
                ORDER BY ProductName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        cmbProducts.DataSource = table;
                        cmbProducts.DisplayMember = "ProductName";
                        cmbProducts.ValueMember = "ProductID";
                        cmbProducts.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load products.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void StockAdjustmentControl_Load(object sender, EventArgs e)
        {

        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedValue == null)
                return;

            if (!int.TryParse(cmbProducts.SelectedValue.ToString(), out int productId))
                return;

            LoadCurrentStock(productId);
        }
        private void LoadCurrentStock(int productId)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT QuantityInStock
                FROM dbo.Products
                WHERE ProductID = @ProductID
                AND IsActive = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@ProductID", SqlDbType.Int).Value = productId;

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            long currentStock = Convert.ToInt64(result);

                            lblCurrentStockLevel.Text =
                                currentStock.ToString("N0") + " units";
                        }
                        else
                        {
                            lblCurrentStockLevel.Text = "Product not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not retrieve current stock.\n\n" + ex.Message,
                    "Inventory Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSaveAdjustment_Click(object sender, EventArgs e)
        {

            // Check whether a product was selected.
            if (cmbProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            // Check whether an adjustment type was selected.
            if (cmbAdjustmentType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an adjustment type.");
                return;
            }

            // Check whether a valid quantity was entered.
            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Please enter a valid adjustment quantity.");
                return;
            }

            // Check whether a reason was provided.
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please provide a reason for the adjustment.");
                txtReason.Focus();
                return;
            }

            // Retrieve the selected product ID.
            int productId = Convert.ToInt32(cmbProducts.SelectedValue);

            // Retrieve the adjustment quantity.
            long quantity = Convert.ToInt64(numQuantity.Value);

            // Retrieve the adjustment type.
            string adjustmentType = cmbAdjustmentType.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Get the current stock from the database.
                            string stockQuery = @"
      SELECT QuantityInStock
      FROM dbo.Products WITH (UPDLOCK, HOLDLOCK)
      WHERE ProductID = @ProductID
      AND IsActive = 1;";

                            long currentStock;

                            using (SqlCommand stockCommand =
                                new SqlCommand(stockQuery, connection, transaction))
                            {
                                stockCommand.Parameters.Add("@ProductID", SqlDbType.Int)
                                    .Value = productId;

                                object result = stockCommand.ExecuteScalar();

                                if (result == null || result == DBNull.Value)
                                {
                                    throw new Exception("The selected product could not be found.");
                                }

                                currentStock = Convert.ToInt64(result);
                            }

                            // Calculate the new stock quantity.
                            long quantityChange;

                            if (adjustmentType == "Increase Stock")
                            {
                                quantityChange = quantity;
                            }
                            else
                            {
                                quantityChange = -quantity;
                            }

                            if (quantityChange < 0 && quantity > currentStock)
                            {
                                throw new Exception(
                                    "The adjustment cannot reduce stock below zero.");
                            }

                            long newStock = checked(currentStock + quantityChange);

                            // Update the product quantity.
                            string updateQuery = @"
                    UPDATE dbo.Products
                    SET QuantityInStock = @NewStock
                    WHERE ProductID = @ProductID
                    AND IsActive = 1;";

                            using (SqlCommand updateCommand =
                                new SqlCommand(updateQuery, connection, transaction))
                            {
                                updateCommand.Parameters.Add("@NewStock", SqlDbType.BigInt)
                                    .Value = newStock;

                                updateCommand.Parameters.Add("@ProductID", SqlDbType.Int)
                                    .Value = productId;

                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected != 1)
                                {
                                    throw new Exception("The product stock could not be updated.");
                                }
                            }

                            // Record the stock adjustment.
                            string movementQuery = @"
                    INSERT INTO dbo.StockMovements
                    (
                        ProductID,
                        MovementType,
                        QuantityChange,
                        QuantityAfter,
                        Notes,
                        MovementDate
                    )
                    VALUES
                    (
                        @ProductID,
                        'Adjustment',
                        @QuantityChange,
                        @QuantityAfter,
                        @Notes,
                        GETDATE()
                    );";

                            using (SqlCommand movementCommand =
                                new SqlCommand(movementQuery, connection, transaction))
                            {
                                movementCommand.Parameters.Add("@ProductID", SqlDbType.Int)
                                    .Value = productId;

                                movementCommand.Parameters.Add("@QuantityChange", SqlDbType.BigInt)
                                    .Value = quantityChange;

                                movementCommand.Parameters.Add("@QuantityAfter", SqlDbType.BigInt)
                                    .Value = newStock;

                                movementCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 500)
                                    .Value = txtReason.Text.Trim();

                                movementCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show(
                                "Stock adjustment saved successfully!\n\n" +
                                "Previous stock: " + currentStock.ToString("N0") +
                                "\nAdjustment: " + quantityChange.ToString("+#,##0;-#,##0;0") +
                                "\nNew stock: " + newStock.ToString("N0"),
                                "Adjustment Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ReturnToInventory?.Invoke();
                            return;


                            LoadCurrentStock(productId);

                            numQuantity.Value = 1;
                            txtReason.Clear();
                            cmbAdjustmentType.SelectedIndex = -1;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "The resulting stock quantity is too large.",
                    "Adjustment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save the stock adjustment.\n\n" + ex.Message,
                    "Adjustment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToInventory?.Invoke();
        }
    }
}

