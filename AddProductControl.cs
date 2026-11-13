using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Data.SqlClient;

namespace Sales_Inventory_Management
{
    public partial class AddProductControl : UserControl
    {
        private ProductsControl productsScreen;
        public AddProductControl(ProductsControl productsScreen)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadCategories();
            this.productsScreen = productsScreen;
        }
        private void LoadCategories()
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();


                    string query = "SELECT CategoryID, CategoryName FROM dbo.Categories ORDER BY CategoryName";

                    using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        cmbCategory.Items.Clear();

                        while (reader.Read())
                        {
                            cmbCategory.Items.Add(new CategoryItem
                            {
                                CategoryID = reader.GetInt32(0),
                                CategoryName = reader.GetString(1)
                            });
                        }
                    }
                }

                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";

                if (cmbCategory.Items.Count > 0)
                {
                    cmbCategory.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load product categories.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }


        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            // 1. Get the values entered by the owner
            string productName = txtProductName.Text.Trim();
            if (productName.Length > 150)
            {
                MessageBox.Show(
                    "Product name cannot exceed 150 characters.",
                    "Product Name Too Long",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProductName.Focus();
                return;
            }
            string sku = txtSKU.Text.Trim();
            if (sku.Length > 100)
            {
                MessageBox.Show(
                    "SKU cannot exceed 100 characters.",
                    "SKU Too Long",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSKU.Focus();
                return;
            }

            // 2. Validate the product name
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Please enter the product name.",
                    "Missing Product Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProductName.Focus();
                return;
            }

            // 3. Validate the category
            CategoryItem category = cmbCategory.SelectedItem as CategoryItem;

            if (category == null)
            {
                MessageBox.Show("Please select a product category.",
                    "Missing Category",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();
                return;
            }

            // 4. Validate the cost price
            decimal costPrice;

            if (!decimal.TryParse(
                txtCostPrice.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out costPrice) || costPrice < 0)
            {
                MessageBox.Show("Please enter a valid, non-negative cost price.",
                    "Invalid Cost Price",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCostPrice.Focus();
                return;
            }

            // 5. Validate the selling price
            decimal sellingPrice;

            if (!decimal.TryParse(
                txtSellingPrice.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out sellingPrice) || sellingPrice < 0)
            {
                MessageBox.Show("Please enter a valid, non-negative selling price.",
                    "Invalid Selling Price",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSellingPrice.Focus();
                return;
            }
            // Warn when selling price is below cost price
            if (sellingPrice < costPrice)
            {
                DialogResult result = MessageBox.Show(
                    "The selling price is lower than the cost price.\n\n" +
                    "This means the shop will make a loss on this product.\n\n" +
                    "Do you want to continue?",
                    "Selling Price Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    txtSellingPrice.Focus();
                    return;
                }
            }
            // 6. Validate the initial stock quantity
            long initialQuantity;

            if (!long.TryParse(txtInitialQuantity.Text.Trim(), out initialQuantity)
                || initialQuantity < 0)
            {
                MessageBox.Show("Enter a valid quantity of zero or more.",
                    "Invalid Initial Quantity",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtInitialQuantity.Focus();
                return;
            }

            // 7. Validate the low-stock threshold
            long lowStockThreshold;

            if (!long.TryParse(
                txtLowStockThreshold.Text.Trim(),
                out lowStockThreshold) || lowStockThreshold < 0)
            {
                MessageBox.Show("Enter a valid low-stock threshold of zero or more.",
                    "Invalid Low-Stock Threshold",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLowStockThreshold.Focus();
                return;
            }

            // 8. Save the product and its initial stock
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            int productID;

                            string insertProduct = @"
                        INSERT INTO dbo.Products
                        (
                            ProductName,
                            SKU,
                            CategoryID,
                            CostPrice,
                            SellingPrice,
                            QuantityInStock,
                            LowStockThreshold
                        )
                        VALUES
                        (
                            @ProductName,
                            @SKU,
                            @CategoryID,
                            @CostPrice,
                            @SellingPrice,
                            @QuantityInStock,
                            @LowStockThreshold
                        );

                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

                            using (SqlCommand command = new SqlCommand(
                                insertProduct, connection, transaction))
                            {
                                command.Parameters.Add(
                                    "@ProductName", System.Data.SqlDbType.NVarChar, 150)
                                    .Value = productName;

                                command.Parameters.Add(
                                    "@SKU", System.Data.SqlDbType.NVarChar, 100)
                                    .Value = string.IsNullOrWhiteSpace(sku)
                                        ? (object)DBNull.Value
                                        : sku;

                                command.Parameters.Add(
                                    "@CategoryID", System.Data.SqlDbType.Int)
                                    .Value = category.CategoryID;

                                SqlParameter costParameter =
                                    command.Parameters.Add(
                                        "@CostPrice", System.Data.SqlDbType.Decimal);

                                costParameter.Precision = 19;
                                costParameter.Scale = 2;
                                costParameter.Value = costPrice;

                                SqlParameter sellingParameter =
                                    command.Parameters.Add(
                                        "@SellingPrice", System.Data.SqlDbType.Decimal);

                                sellingParameter.Precision = 19;
                                sellingParameter.Scale = 2;
                                sellingParameter.Value = sellingPrice;

                                command.Parameters.Add(
                                    "@QuantityInStock", System.Data.SqlDbType.BigInt)
                                    .Value = initialQuantity;

                                command.Parameters.Add(
                                    "@LowStockThreshold", System.Data.SqlDbType.BigInt)
                                    .Value = lowStockThreshold;

                                productID = (int)command.ExecuteScalar();
                            }

                            // Record the initial stock only when quantity is above zero
                            if (initialQuantity > 0)
                            {
                                string insertStockMovement = @"
                            INSERT INTO dbo.StockMovements
                            (
                                ProductID,
                                MovementType,
                                QuantityChange,
                                QuantityAfter,
                                Notes
                            )
                            VALUES
                            (
                                @ProductID,
                                @MovementType,
                                @QuantityChange,
                                @QuantityAfter,
                                @Notes
                            );";

                                using (SqlCommand stockCommand =
                                    new SqlCommand(
                                        insertStockMovement,
                                        connection,
                                        transaction))
                                {
                                    stockCommand.Parameters.Add(
                                        "@ProductID", System.Data.SqlDbType.Int)
                                        .Value = productID;

                                    stockCommand.Parameters.Add(
                                        "@MovementType", System.Data.SqlDbType.NVarChar, 20)
                                        .Value = "Initial Stock";

                                    stockCommand.Parameters.Add(
                                        "@QuantityChange", System.Data.SqlDbType.BigInt)
                                        .Value = initialQuantity;

                                    stockCommand.Parameters.Add(
                                        "@QuantityAfter", System.Data.SqlDbType.BigInt)
                                        .Value = initialQuantity;

                                    stockCommand.Parameters.Add(
                                        "@Notes", System.Data.SqlDbType.NVarChar, 500)
                                        .Value = "Initial stock entered when product was created.";

                                    stockCommand.ExecuteNonQuery();
                                }
                            }

                            // Commit only when all required inserts succeed
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    "Product saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show(
                    "This SKU already exists. Please enter a different SKU.",
                    "Duplicate SKU",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSKU.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The product could not be saved.\n\nDetails: " + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            if (productsScreen != null)
            {
                Panel mainPanel = this.Parent as Panel;

                if (mainPanel != null)
                {
                    productsScreen.RefreshProducts();

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(productsScreen);

                    productsScreen.Dock = DockStyle.Fill;
                    productsScreen.BringToFront();
                }
            }
        }
    }
    public class CategoryItem
    {
        public int CategoryID { get; set; }

public string CategoryName { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }


}

}
