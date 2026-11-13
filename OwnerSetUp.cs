using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Inventory_Management
{
    public partial class OwnerSetUp : Form
    {
        public OwnerSetUp()
        {
            InitializeComponent();
        }


        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.");
                txtUsername.Focus();
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Your password must contain at least 8 characters.");
                txtPassword.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("The passwords do not match.");
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                OwnerAccountService.CreateOwnerAccount(username, password);

                MessageBox.Show(
                    "Owner account created successfully!",
                    "Account Setup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
                when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show(
                    "That username already exists. Please choose another.",
                    "Account Setup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The account could not be created. Please check your database connection.\n\n" + ex.Message,
                    "Account Setup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
