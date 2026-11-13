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
    public partial class UserManagementControl : UserControl
    {
        private string _username;
        private string _userRole;
        private Panel _mainContentPanel;
        public UserManagementControl(
      string username,
      string userRole,
      Panel mainContentPanel)
        {
            InitializeComponent();

            _username = username;
            _userRole = userRole;
            _mainContentPanel = mainContentPanel;

            cmbRole.Items.Clear();
            cmbRole.Items.Add("Cashier");
            cmbRole.Items.Add("Owner");
            cmbRole.SelectedIndex = 0;

            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.RowHeadersVisible = false;
            // DataGridView appearance
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.GridColor = Color.FromArgb(230, 230, 230);

            dgvUsers.EnableHeadersVisualStyles = false;

            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(35, 45, 65);

            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvUsers.DefaultCellStyle.BackColor = Color.White;
            dgvUsers.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);

            dgvUsers.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 230, 245);

            dgvUsers.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 45, 65);

            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 247, 250);

            dgvUsers.RowTemplate.Height = 35;
            dgvUsers.ColumnHeadersHeight = 40;

            btnCreateUser.Click += btnCreateUser_Click;
            btnBack.Click += btnBack_Click;
            btnRemoveUser.Click += btnRemoveUser_Click;

            LoadUsers();
        }
        private void LoadUsers()
        {
            try
            {
                dgvUsers.DataSource = OwnerAccountService.GetAllUsers();

                // Configure column headings.
                dgvUsers.Columns["Username"].HeaderText = "Username";
                dgvUsers.Columns["Role"].HeaderText = "Account Role";

                dgvUsers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load user accounts.\n\n" + ex.Message,
                    "User Management Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show(
                    "Please complete all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "The passwords do not match.",
                    "Password Mismatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OwnerAccountService.CreateUser(username, password, role);

                MessageBox.Show(
                    "User account created successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                cmbRole.SelectedIndex = 0;

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to create the user account.\n\n" + ex.Message,
                    "Account Creation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            SettingsControl settings = new SettingsControl(
                _username,
                _userRole,
                _mainContentPanel);

            _mainContentPanel.Controls.Clear();

            settings.Dock = DockStyle.Fill;
            _mainContentPanel.Controls.Add(settings);
            settings.BringToFront();
        }
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a user account first.",
                    "No User Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string selectedUsername =
                dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

            string selectedRole =
                dgvUsers.CurrentRow.Cells["Role"].Value.ToString();

            if (selectedUsername == _username)
            {
                MessageBox.Show(
                    "You cannot remove your own account.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (selectedRole != "Cashier")
            {
                MessageBox.Show(
                    "Only Cashier accounts can be removed.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove the account belonging to "
                + selectedUsername + "?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    OwnerAccountService.RemoveUser(selectedUsername);

                    MessageBox.Show(
                        "User account removed successfully.",
                        "Account Removed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Unable to remove the account.\n\n" + ex.Message,
                        "Removal Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
