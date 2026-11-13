using Microsoft.Data.SqlClient;
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
    public partial class ReceiptForm : Form
    {
        private long _saleID;
        public ReceiptForm(long saleID)
        {
            InitializeComponent();
            this.Size = new Size(650, 750);
            this.MinimumSize = new Size(650, 750);
            _saleID = saleID;

            ConfigureReceiptGrid();
            LoadReceipt();
        }
        private void ConfigureReceiptGrid()
        {
            dgvReceiptItems.AutoGenerateColumns = false;
            dgvReceiptItems.Columns.Clear();

            dgvReceiptItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProductName",
                HeaderText = "Product",
                DataPropertyName = "ProductName",
                FillWeight = 150
            });

            dgvReceiptItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuantity",
                HeaderText = "Qty",
                DataPropertyName = "Quantity",
                FillWeight = 45
            });

            dgvReceiptItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnitPrice",
                HeaderText = "Price",
                DataPropertyName = "UnitPrice",
                FillWeight = 75,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    FormatProvider = new System.Globalization.CultureInfo("en-ZA")
                }
            });

            dgvReceiptItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal",
                FillWeight = 85,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    FormatProvider = new System.Globalization.CultureInfo("en-ZA")
                }
            });
        }
        private void LoadReceipt()
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Retrieve the main sale information.
                    string saleQuery = @"
                SELECT SaleID, SaleDate, PaymentMethod,
                       Subtotal, TotalAmount
                FROM dbo.Sales
                WHERE SaleID = @SaleID;";

                    using (SqlCommand command = new SqlCommand(saleQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SaleID", _saleID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "The requested receipt could not be found.",
                                    "Receipt Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                Close();
                                return;
                            }

                            lblReceiptNumb.Text =
                                "Receipt No: " + reader["SaleID"].ToString();

                            lblReceiptDate.Text =
                                "Date: " + Convert.ToDateTime(reader["SaleDate"])
                                .ToString("dd/MM/yyyy HH:mm");

                            lblPaymentMethod.Text =
                                "Payment Method: " + reader["PaymentMethod"].ToString();

                            lblSubtotal.Text =
                                "Subtotal: " + Convert.ToDecimal(reader["Subtotal"])
                                .ToString("C2", new System.Globalization.CultureInfo("en-ZA"));

                            lblTotal.Text =
                                "TOTAL: " + Convert.ToDecimal(reader["TotalAmount"])
                                .ToString("C2", new System.Globalization.CultureInfo("en-ZA"));
                        }
                    }

                    // Retrieve the products belonging to this sale.
                    string itemsQuery = @"
                SELECT ProductName, Quantity, UnitPrice, Subtotal
                FROM dbo.SaleItems
                WHERE SaleID = @SaleID
                ORDER BY SaleItemID;";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(itemsQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@SaleID", _saleID);

                        DataTable receiptItems = new DataTable();

                        adapter.Fill(receiptItems);

                        dgvReceiptItems.DataSource = receiptItems;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load receipt: " + ex.Message,
                    "Receipt Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
            }
        }

        private void printDocumentReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headingFont = new Font("Arial", 11, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Font totalFont = new Font("Arial", 13, FontStyle.Bold);

            float x = 40;
            float y = 40;
            float pageWidth = e.MarginBounds.Width;

            StringFormat centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center
            };

            StringFormat rightFormat = new StringFormat
            {
                Alignment = StringAlignment.Far
            };

            // Shop heading.
            graphics.DrawString(
                "TUCK SHOP",
                titleFont,
                Brushes.Black,
                new RectangleF(x, y, pageWidth, 35),
                centerFormat);

            y += 40;

            graphics.DrawString(
                "SALES RECEIPT",
                headingFont,
                Brushes.Black,
                new RectangleF(x, y, pageWidth, 25),
                centerFormat);

            y += 40;

            // Receipt information.
            graphics.DrawString(lblReceiptNumb.Text, normalFont, Brushes.Black, x, y);
            y += 22;

            graphics.DrawString(lblReceiptDate.Text, normalFont, Brushes.Black, x, y);
            y += 22;

            graphics.DrawString(lblPaymentMethod.Text, normalFont, Brushes.Black, x, y);
            y += 30;

            graphics.DrawLine(Pens.Black, x, y, x + pageWidth, y);
            y += 15;

            // Table headings.
            graphics.DrawString("Product", headingFont, Brushes.Black, x, y);

            graphics.DrawString("Qty", headingFont, Brushes.Black,
                new RectangleF(x + 230, y, 45, 20), rightFormat);

            graphics.DrawString("Price", headingFont, Brushes.Black,
                new RectangleF(x + 285, y, 90, 20), rightFormat);

            graphics.DrawString("Subtotal", headingFont, Brushes.Black,
                new RectangleF(x + 385, y, 100, 20), rightFormat);

            y += 25;

            graphics.DrawLine(Pens.Black, x, y, x + pageWidth, y);
            y += 12;

            // Product rows.
            foreach (DataGridViewRow row in dgvReceiptItems.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string productName = Convert.ToString(
                    row.Cells["colProductName"].Value);

                string quantity = Convert.ToString(
                    row.Cells["colQuantity"].Value);

                string price = Convert.ToDecimal(
                    row.Cells["colUnitPrice"].Value)
                    .ToString("C2",
                    new System.Globalization.CultureInfo("en-ZA"));

                string subtotal = Convert.ToDecimal(
                    row.Cells["colSubtotal"].Value)
                    .ToString("C2",
                    new System.Globalization.CultureInfo("en-ZA"));

                graphics.DrawString(productName, normalFont, Brushes.Black, x, y);

                graphics.DrawString(quantity, normalFont, Brushes.Black,
                    new RectangleF(x + 230, y, 45, 20), rightFormat);

                graphics.DrawString(price, normalFont, Brushes.Black,
                    new RectangleF(x + 285, y, 90, 20), rightFormat);

                graphics.DrawString(subtotal, normalFont, Brushes.Black,
                    new RectangleF(x + 385, y, 100, 20), rightFormat);

                y += 25;
            }

            y += 10;

            graphics.DrawLine(Pens.Black, x, y, x + pageWidth, y);

            y += 20;

            // Totals.
            graphics.DrawString(
                lblSubtotal.Text,
                normalFont,
                Brushes.Black,
                new RectangleF(x, y, pageWidth, 25),
                rightFormat);

            y += 30;

            graphics.DrawString(
                lblTotal.Text,
                totalFont,
                Brushes.Black,
                new RectangleF(x, y, pageWidth, 30),
                rightFormat);

            y += 50;

            graphics.DrawString(
                "Thank you for shopping with us!",
                headingFont,
                Brushes.Black,
                new RectangleF(x, y, pageWidth, 25),
                centerFormat);

            // Release fonts and formatting objects.
            titleFont.Dispose();
            headingFont.Dispose();
            normalFont.Dispose();
            totalFont.Dispose();
            centerFormat.Dispose();
            rightFormat.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocumentReceipt;
                printDialog.UseEXDialog = true;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDocumentReceipt.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Unable to print receipt.\n\n" + ex.Message,
                            "Printing Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialogReceipt.Document = printDocumentReceipt;

            printPreviewDialogReceipt.ShowDialog();
        }
    }
}
