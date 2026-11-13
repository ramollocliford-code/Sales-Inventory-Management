using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Sales_Inventory_Management
{
    public partial class EditProductControl : UserControl
    {
        private readonly int _productID;
        private readonly Panel _mainContentPanel;
        private readonly string _userRole;

        public EditProductControl(int productID, Panel mainContentPanel, string userRole)
        {
            InitializeComponent();

            _productID = productID;
            _mainContentPanel = mainContentPanel;
            _userRole = userRole;

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadCategories();
            LoadProductDetails();
            _userRole = userRole;
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT CategoryID, CategoryName
                        FROM dbo.Categories
                        ORDER BY CategoryName;";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable categories = new DataTable();
                        adapter.Fill(categories);

                        cmbCategory.DataSource = categories;
                        cmbCategory.DisplayMember = "CategoryName";
                        cmbCategory.ValueMember = "CategoryID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load categories.\n\n" + ex.Message,
                    "Category Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadProductDetails()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            ProductName,
                            SKU,
                            CategoryID,
                            CostPrice,
                            SellingPrice,
                            LowStockThreshold
                        FROM dbo.Products
                        WHERE ProductID = @ProductID
                          AND IsActive = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@ProductID", SqlDbType.Int)
                            .Value = _productID;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtProductName.Text =
                                    reader["ProductName"].ToString();

                                txtSKU.Text =
                                    reader["SKU"] == DBNull.Value
                                        ? ""
                                        : reader["SKU"].ToString();

                                txtCostPrice.Text =
                                    Convert.ToDecimal(reader["CostPrice"])
                                        .ToString("0.00");

                                txtSellingPrice.Text =
                                    Convert.ToDecimal(reader["SellingPrice"])
                                        .ToString("0.00");

                                txtLowStockThreshold.Text =
                                    Convert.ToInt64(reader["LowStockThreshold"])
                                        .ToString();

                                cmbCategory.SelectedValue =
                                    Convert.ToInt32(reader["CategoryID"]);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "This product could not be found or is inactive.",
                                    "Product Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load product details.\n\n" + ex.Message,
                    "Product Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private bool ValidateProductDetails(
            out decimal costPrice,
            out decimal sellingPrice,
            out long lowStockThreshold)
        {
            costPrice = 0;
            sellingPrice = 0;
            lowStockThreshold = 0;

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.");
                txtProductName.Focus();
                return false;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.");
                cmbCategory.Focus();
                return false;
            }

            if (!decimal.TryParse(txtCostPrice.Text.Trim(), out costPrice)
                || costPrice < 0)
            {
                MessageBox.Show("Enter a valid, non-negative cost price.");
                txtCostPrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSellingPrice.Text.Trim(), out sellingPrice)
                || sellingPrice < 0)
            {
                MessageBox.Show("Enter a valid, non-negative selling price.");
                txtSellingPrice.Focus();
                return false;
            }

            if (!long.TryParse(
                    txtLowStockThreshold.Text.Trim(),
                    out lowStockThreshold)
                || lowStockThreshold < 0)
            {
                MessageBox.Show(
                    "Enter a valid, non-negative whole number for the low-stock threshold.");

                txtLowStockThreshold.Focus();
                return false;
            }

            return true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            if (!ValidateProductDetails(
                    out decimal costPrice,
                    out decimal sellingPrice,
                    out long lowStockThreshold))
            {
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                UPDATE dbo.Products
                SET ProductName = @ProductName,
                    SKU = @SKU,
                    CategoryID = @CategoryID,
                    CostPrice = @CostPrice,
                    SellingPrice = @SellingPrice,
                    LowStockThreshold = @LowStockThreshold
                WHERE ProductID = @ProductID
                  AND IsActive = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@ProductName", SqlDbType.NVarChar, 150)
                            .Value = txtProductName.Text.Trim();

                        command.Parameters.Add("@SKU", SqlDbType.NVarChar, 100)
                            .Value = string.IsNullOrWhiteSpace(txtSKU.Text)
                                ? DBNull.Value
                                : txtSKU.Text.Trim();

                        command.Parameters.Add("@CategoryID", SqlDbType.Int)
                            .Value = Convert.ToInt32(cmbCategory.SelectedValue);

                        command.Parameters.Add("@CostPrice", SqlDbType.Decimal)
                            .Value = costPrice;

                        command.Parameters["@CostPrice"].Precision = 19;
                        command.Parameters["@CostPrice"].Scale = 2;

                        command.Parameters.Add("@SellingPrice", SqlDbType.Decimal)
                            .Value = sellingPrice;

                        command.Parameters["@SellingPrice"].Precision = 19;
                        command.Parameters["@SellingPrice"].Scale = 2;

                        command.Parameters.Add("@LowStockThreshold", SqlDbType.BigInt)
                            .Value = lowStockThreshold;

                        command.Parameters.Add("@ProductID", SqlDbType.Int)
                            .Value = _productID;

                        int rowsUpdated = command.ExecuteNonQuery();

                        if (rowsUpdated == 0)
                        {
                            MessageBox.Show(
                                "The product could not be updated. It may no longer be active.",
                                "Update Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "Product details updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ProductsControl products = new ProductsControl(_mainContentPanel, _userRole);

                _mainContentPanel.Controls.Clear();
                products.Dock = DockStyle.Fill;
                _mainContentPanel.Controls.Add(products);
                products.BringToFront();
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show(
                    "That SKU is already assigned to another product. Please enter a unique SKU.",
                    "Duplicate SKU",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update the product.\n\n" + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

      
private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            ProductsControl products = new ProductsControl(_mainContentPanel, _userRole );

            _mainContentPanel.Controls.Clear();

            products.Dock = DockStyle.Fill;

            _mainContentPanel.Controls.Add(products);

            products.BringToFront();
        }

        }
}


