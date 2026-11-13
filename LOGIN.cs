namespace Sales_Inventory_Management
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            CenterLoginPanel();
            txtUserName.Focus();
            this.Shown += LOGIN_Shown;

        }
        private void LOGIN_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Authenticate the user and retrieve their role.
                string role = OwnerAccountService.GetUserRole(
                    username, password);

                if (role != null)
                {
                    Dashboard dashboard = new Dashboard(username, role, this);

                    dashboard.Show();

                    this.Hide();

                    // Only remind the Owner about database backups.
                    if (role == "Owner")
                    {
                        try
                        {
                            if (BackupReminderService.IsBackupDue())
                            {
                                MessageBox.Show(
                                    "Database Backup Reminder\n\n" +
                                    "It has been 7 days or more since your last database backup.\n\n" +
                                    "Please visit Settings → Database Backup & Restore " +
                                    "to protect your shop data.",
                                    "Backup Reminder",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                "Unable to check the database backup status.\n\n" +
                                ex.Message,
                                "Backup Reminder Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Unable to verify your login. Please check the database connection.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
        }
        public void ClearLoginPassword()
        {
            txtPassword.Clear();
            txtUserName.Focus();
        }
        private void CenterLoginPanel()
        {
            pnlLogin.Left = (this.ClientSize.Width - pnlLogin.Width) / 2;
            pnlLogin.Top = (this.ClientSize.Height - pnlLogin.Height) / 2;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterLoginPanel();
        }


    }
}

