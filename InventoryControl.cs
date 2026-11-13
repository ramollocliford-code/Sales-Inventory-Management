using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Sales_Inventory_Management
{
    public partial class InventoryControl : UserControl
    {
        private Panel _mainContentPanel;
        public InventoryControl(Panel mainContentPanel)
        {
            InitializeComponent();
            _mainContentPanel = mainContentPanel;
            this.Dock = DockStyle.Fill;
            LoadInventoryStatistics();
            LoadStockOverview();
            LoadStockMovements();
        }
        private void LoadInventoryStatistics()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    COALESCE(SUM(QuantityInStock), 0) AS TotalStockUnits,

                    COALESCE(SUM(
                        CASE
                            WHEN QuantityInStock > 0
                            AND QuantityInStock <= LowStockThreshold
                            THEN 1 ELSE 0
                        END
                    ), 0) AS LowStockProducts,

                    COALESCE(SUM(
                        CASE
                            WHEN QuantityInStock = 0
                            THEN 1 ELSE 0
                        END
                    ), 0) AS OutOfStockProducts

                FROM dbo.Products
                WHERE IsActive = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalStockValue.Text =
                                reader["TotalStockUnits"].ToString();

                            lblLowStockValue.Text =
                                reader["LowStockProducts"].ToString();

                            lblOutOfStockValue.Text =
                                reader["OutOfStockProducts"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load inventory statistics.\n\n" + ex.Message,
                    "Inventory Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void LoadStockOverview(string searchText = "")
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
                p.QuantityInStock,
                p.LowStockThreshold,
                CASE
                    WHEN p.QuantityInStock = 0 THEN 'Out of Stock'
                    WHEN p.QuantityInStock <= p.LowStockThreshold THEN 'Low Stock'
                    ELSE 'In Stock'
                END AS StockStatus
            FROM dbo.Products p
            LEFT JOIN dbo.Categories c
                ON p.CategoryID = c.CategoryID
            WHERE p.IsActive = 1
            AND (
                p.ProductName LIKE @Search
                OR p.SKU LIKE @Search
            )
            ORDER BY p.ProductName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Search", SqlDbType.NVarChar, 150)
                            .Value = "%" + searchText + "%";

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dgvInventory.DataSource = null;
                            dgvInventory.DataSource = table;
                            dgvInventory.DefaultCellStyle.ForeColor = Color.Black;
                            dgvInventory.DefaultCellStyle.BackColor = Color.White;

                            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;
                            dgvInventory.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;

                            foreach (DataGridViewRow row in dgvInventory.Rows)
                            {
                                string status = Convert.ToString(row.Cells[6].Value);
                                if (status == "Out of Stock")
                                {
                                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                                }
                                else if (status == "Low Stock")
                                {
                                    row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                                    row.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load stock overview.\n\n" + ex.Message,
                    "Inventory Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void LoadStockMovements(int? productId = null)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    dgvStockMovements.DefaultCellStyle.ForeColor = Color.Black;
                    dgvStockMovements.DefaultCellStyle.BackColor = Color.White;
                    dgvStockMovements.DefaultCellStyle.SelectionForeColor = Color.White;
                    dgvStockMovements.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                    connection.Open();
                    string query = @"
    SELECT TOP (50)
        sm.StockMovementID,
        p.ProductName,
        sm.MovementType,
        sm.QuantityChange,
        sm.QuantityAfter,
        sm.MovementDate,
        sm.Notes
    FROM dbo.StockMovements sm
    INNER JOIN dbo.Products p
        ON sm.ProductID = p.ProductID
    WHERE (@ProductID IS NULL OR sm.ProductID = @ProductID)
    ORDER BY sm.MovementDate DESC, sm.StockMovementID DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@ProductID", SqlDbType.Int).Value =
                            (object)productId ?? DBNull.Value;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dgvStockMovements.Rows.Clear();

                            while (reader.Read())
                            {
                                dgvStockMovements.Rows.Add(
                                    reader["StockMovementID"],
                                    reader["ProductName"],
                                    reader["MovementType"],
                                    reader["QuantityChange"],
                                    reader["QuantityAfter"],
                                    Convert.ToDateTime(reader["MovementDate"])
                                        .ToString("dd MMM yyyy HH:mm"),
                                    reader["Notes"] == DBNull.Value
                                        ? ""
                                        : reader["Notes"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load stock movements.\n\n" + ex.Message,
                    "Inventory Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchInventory.Text.Trim();

            LoadStockOverview(searchText);
        }

        private void btnRefreshInventory_Click(object sender, EventArgs e)
        {
            txtSearchInventory.Clear();

            LoadInventoryStatistics();
            LoadStockOverview();
            LoadStockMovements();
        }

        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
                return;

            if (dgvInventory.CurrentRow.IsNewRow)
                return;

            object productIdValue = dgvInventory.CurrentRow.Cells[0].Value;

            if (productIdValue == null || productIdValue == DBNull.Value)
                return;

            int productId = Convert.ToInt32(productIdValue);

            LoadStockMovements(productId);
        }
        private void LoadInventoryScreen()
        {
            _mainContentPanel.Controls.Clear();

            InventoryControl inventoryControl = new InventoryControl(_mainContentPanel);

            inventoryControl.Dock = DockStyle.Fill;

            _mainContentPanel.Controls.Add(inventoryControl);
        }

        private void btnAdjustStock_Click(object sender, EventArgs e)
        {
            StockAdjustmentControl adjustmentControl = new StockAdjustmentControl();

            adjustmentControl.ReturnToInventory = () =>
            {
                LoadInventoryScreen();
            };

            _mainContentPanel.Controls.Clear();

            adjustmentControl.Dock = DockStyle.Fill;

            _mainContentPanel.Controls.Add(adjustmentControl);
        }

        private void btnRecordDamage_Click(object sender, EventArgs e)
        {
            DamageRecordingControl damageControl = new DamageRecordingControl();

            damageControl.ReturnToInventory = () =>
            {
                LoadInventoryScreen();
            };

            _mainContentPanel.Controls.Clear();

            damageControl.Dock = DockStyle.Fill;

            _mainContentPanel.Controls.Add(damageControl);
        }
    }
}
