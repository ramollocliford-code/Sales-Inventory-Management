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
    public partial class DamageRecordingControl : UserControl
    {
        public Action ReturnToInventory { get; set; }
        public DamageRecordingControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadProducts();
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

                        cmbProducts.DisplayMember = "ProductName";
                        cmbProducts.ValueMember = "ProductID";
                        cmbProducts.DataSource = table;

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

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedValue == null)
                return;

            if (!int.TryParse(cmbProducts.SelectedValue.ToString(), out int productId))
                return;

            LoadCurrentStock(productId);
        }

        private void btnSaveDamage_Click(object sender, EventArgs e)
        {
            // 1. Validate product selection
            if (cmbProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            // 2. Validate quantity
            if (numDamageQuantity.Value <= 0)
            {
                MessageBox.Show("Please enter a valid damaged quantity.");
                return;
            }

            // 3. Validate damage reason
            if (string.IsNullOrWhiteSpace(txtDamageReason.Text))
            {
                MessageBox.Show("Please provide a reason for the damage.");
                txtDamageReason.Focus();
                return;
            }

            int productId = Convert.ToInt32(cmbProducts.SelectedValue);
            long damagedQuantity = Convert.ToInt64(numDamageQuantity.Value);
            string reason = txtDamageReason.Text.Trim();

            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Retrieve current stock and lock the product row
                            string stockQuery = @"
                        SELECT QuantityInStock
                        FROM dbo.Products WITH (UPDLOCK, HOLDLOCK)
                        WHERE ProductID = @ProductID
                        AND IsActive = 1;";

                            long currentStock;

                            using (SqlCommand stockCommand =
                                new SqlCommand(stockQuery, connection, transaction))
                            {
                                stockCommand.Parameters.Add("@ProductID", SqlDbType.Int).Value = productId;

                                object result = stockCommand.ExecuteScalar();

                                if (result == null || result == DBNull.Value)
                                    throw new Exception("The selected product could not be found.");

                                currentStock = Convert.ToInt64(result);
                            }

                            // Prevent damage quantity from exceeding available stock
                            if (damagedQuantity > currentStock)
                            {
                                throw new Exception(
                                    "The damaged quantity cannot exceed the available stock of " +
                                    currentStock.ToString("N0") + " units.");
                            }

                            // Calculate remaining stock
                            long newStock = currentStock - damagedQuantity;

                            // Update product stock
                            string updateQuery = @"
                        UPDATE dbo.Products
                        SET QuantityInStock = @NewStock
                        WHERE ProductID = @ProductID
                        AND IsActive = 1;";

                            using (SqlCommand updateCommand =
                                new SqlCommand(updateQuery, connection, transaction))
                            {
                                updateCommand.Parameters.Add("@NewStock", SqlDbType.BigInt).Value = newStock;
                                updateCommand.Parameters.Add("@ProductID", SqlDbType.Int).Value = productId;

                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected != 1)
                                    throw new Exception("Could not update product stock.");
                            }

                            // Record damage in stock movement history
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
                            'Damage',
                            @QuantityChange,
                            @QuantityAfter,
                            @Notes,
                            GETDATE()
                        );";

                            using (SqlCommand movementCommand =
                                new SqlCommand(movementQuery, connection, transaction))
                            {
                                movementCommand.Parameters.Add("@ProductID", SqlDbType.Int).Value = productId;

                                movementCommand.Parameters.Add("@QuantityChange", SqlDbType.BigInt).Value =
                                    -damagedQuantity;

                                movementCommand.Parameters.Add("@QuantityAfter", SqlDbType.BigInt).Value = newStock;

                                movementCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value = reason;

                                movementCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show(
                                "Damage record saved successfully!\n\n" +
                                "Previous stock: " + currentStock.ToString("N0") +
                                "\nDamaged quantity: " + damagedQuantity.ToString("N0") +
                                "\nRemaining stock: " + newStock.ToString("N0"),
                                "Damage Recorded",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // Refresh the displayed stock
                            LoadCurrentStock(productId);

                            // Reset the form
                            numDamageQuantity.Value = 1;
                            txtDamageReason.Clear();

                            // Return to Inventory Management
                            ReturnToInventory?.Invoke();
                            return;
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
                    "Damage Recording Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save the damage record.\n\n" + ex.Message,
                    "Damage Recording Error",
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
