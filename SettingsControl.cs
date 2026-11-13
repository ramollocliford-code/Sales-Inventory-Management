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
using System.IO;
namespace Sales_Inventory_Management
{
    public partial class SettingsControl : UserControl
    {
        private string _username;
        private string _userRole;
        private Panel _mainContentPanel;

        public SettingsControl(
     string username,
     string userRole,
     Panel mainContentPanel)
        {
            InitializeComponent();

            _username = username;
            _userRole = userRole;
            _mainContentPanel = mainContentPanel;

            txtUsername.Text = _username;

            // Cashiers cannot access Owner settings.
            if (_userRole != "Owner")
            {
                btnUserManagement.Visible = false;
                pnlBackupRestore.Visible = false;
            }

            btnUserManagement.Click += btnUserManagement_Click;
        }
        private void LoadScreen(UserControl screen)
        {
            _mainContentPanel.Controls.Clear();

            screen.Dock = DockStyle.Fill;

            _mainContentPanel.Controls.Add(screen);
            screen.BringToFront();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (_userRole != "Owner")
            {
                MessageBox.Show(
                    "Only the Owner can manage user accounts.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            LoadScreen(new UserManagementControl(
     _username,
     _userRole,
     _mainContentPanel));
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check that all fields are completed.
            if (string.IsNullOrWhiteSpace(currentPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show(
                    "Please complete all password fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Check minimum password length.
            if (newPassword.Length < 8)
            {
                MessageBox.Show(
                    "Your new password must contain at least 8 characters.",
                    "Password Too Short",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNewPassword.Focus();
                return;
            }

            // Check that both new passwords match.
            if (newPassword != confirmPassword)
            {
                MessageBox.Show(
                    "The new password and confirmation password do not match.",
                    "Password Mismatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            // Continue to password verification.
            try
            {
                bool passwordChanged = OwnerAccountService.ChangeOwnerPassword(
                    _username,
                    currentPassword,
                    newPassword);

                if (passwordChanged)
                {
                    MessageBox.Show(
                        "Your password has been changed successfully.",
                        "Password Updated",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtCurrentPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();

                    txtCurrentPassword.Focus();
                }
                else
                {
                    MessageBox.Show(
                        "Your current password is incorrect.",
                        "Password Change Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCurrentPassword.Clear();
                    txtCurrentPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to change your password.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Save Database Backup";
                saveDialog.Filter = "SQL Server Backup Files (*.bak)|*.bak";
                saveDialog.DefaultExt = "bak";
                saveDialog.FileName = "TuckShopDB_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";

                saveDialog.OverwritePrompt = true;

                if (saveDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string backupPath = saveDialog.FileName;

                try
                {
                    lblBackupStatus.Text = "Creating database backup...";
                    btnCreateBackup.Enabled = false;
                    Application.DoEvents();

                    // Escape apostrophes in the selected file path.
                    string safePath = backupPath.Replace("'", "''");

                    string backupQuery = $@"
                BACKUP DATABASE [TuckShopDB]
                TO DISK = N'{safePath}'
                WITH INIT, CHECKSUM, STATS = 10;";

                    using (SqlConnection connection =
                        DatabaseHelper.GetConnection())
                    {
                        connection.Open();

                        using (SqlCommand command =
                            new SqlCommand(backupQuery, connection))
                        {
                            command.CommandTimeout = 300;
                            command.ExecuteNonQuery();
                        }
                    }

                    // Check whether the backup file was created.
                    if (File.Exists(backupPath))
                    {
                        FileInfo backupFile = new FileInfo(backupPath);
                        // Record the successful backup in the database.
                        string historyQuery = @"
    INSERT INTO dbo.BackupHistory (BackupPath)
    VALUES (@BackupPath);";

                        using (SqlConnection historyConnection =
                            DatabaseHelper.GetConnection())
                        {
                            historyConnection.Open();

                            using (SqlCommand historyCommand =
                                new SqlCommand(historyQuery, historyConnection))
                            {
                                historyCommand.Parameters.AddWithValue(
                                    "@BackupPath", backupPath);

                                historyCommand.ExecuteNonQuery();
                            }
                        }

                        lblBackupStatus.Text =
                            "Last backup: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                        MessageBox.Show(
                            "Database backup created successfully!\n\n" +
                            "Location: " + backupPath + "\n\n" +
                            "File size: " +
                            (backupFile.Length / 1024.0).ToString("N2") + " KB",
                            "Backup Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception(
                            "The backup command completed, but the backup file could not be found.");
                    }
                }
                catch (Exception ex)
                {
                    lblBackupStatus.Text = "Backup failed.";

                    MessageBox.Show(
                        "Could not create the database backup.\n\n" +
                        ex.Message,
                        "Backup Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    btnCreateBackup.Enabled = true;
                }
            }
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Select Database Backup";
                openDialog.Filter = "SQL Server Backup Files (*.bak)|*.bak";
                openDialog.CheckFileExists = true;

                if (openDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string backupPath = openDialog.FileName;

                DialogResult confirmation = MessageBox.Show(
                    "WARNING: Restoring this backup will replace the current " +
                    "TuckShopDB database.\n\n" +
                    "Any changes made after this backup was created will be lost.\n\n" +
                    "Are you sure you want to continue?",
                    "Confirm Database Restore",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmation != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    btnRestoreBackup.Enabled = false;
                    lblBackupStatus.Text = "Restoring database...";

                    Application.DoEvents();

                    // Close pooled connections before restoring.
                    SqlConnection.ClearAllPools();

                    string safePath = backupPath.Replace("'", "''");

                    string masterConnectionString =
                        @"Data Source=(localdb)\MSSQLLocalDB;" +
                        "Initial Catalog=master;" +
                        "Integrated Security=True;";

                    using (SqlConnection connection =
                        new SqlConnection(masterConnectionString))
                    {
                        connection.Open();

                        // Make the database available exclusively for restoration.
                        string singleUserQuery = @"
                    ALTER DATABASE [TuckShopDB]
                    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";

                        using (SqlCommand command =
                            new SqlCommand(singleUserQuery, connection))
                        {
                            command.CommandTimeout = 300;
                            command.ExecuteNonQuery();
                        }

                        try
                        {
                            string restoreQuery = $@"
                        RESTORE DATABASE [TuckShopDB]
                        FROM DISK = N'{safePath}'
                        WITH REPLACE, CHECKSUM, STATS = 10;";

                            using (SqlCommand command =
                                new SqlCommand(restoreQuery, connection))
                            {
                                command.CommandTimeout = 300;
                                command.ExecuteNonQuery();
                            }
                        }
                        finally
                        {
                            // Return the database to normal multi-user access.
                            string multiUserQuery = @"
                        ALTER DATABASE [TuckShopDB]
                        SET MULTI_USER;";

                            using (SqlCommand command =
                                new SqlCommand(multiUserQuery, connection))
                            {
                                command.CommandTimeout = 300;
                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    SqlConnection.ClearAllPools();

                    lblBackupStatus.Text = "Database restored successfully.";

                    MessageBox.Show(
                        "The database has been restored successfully.\n\n" +
                        "Please log out and log back in to refresh the application.",
                        "Restore Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    lblBackupStatus.Text = "Database restoration failed.";

                    MessageBox.Show(
                        "Could not restore the database.\n\n" + ex.Message,
                        "Restore Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    btnRestoreBackup.Enabled = true;
                }
            }
        }

        private void btnUserManagement_Click_1(object sender, EventArgs e)
        {
            if (_userRole != "Owner")
            {
                MessageBox.Show(
                    "Only the Owner can manage user accounts.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            LoadScreen(new UserManagementControl(
                _username,
                _userRole,
                _mainContentPanel));
        }
    }
}




