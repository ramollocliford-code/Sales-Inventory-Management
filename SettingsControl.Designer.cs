namespace Sales_Inventory_Management
{
    partial class SettingsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSettingsHeading = new Label();
            lblSettingsDescription = new Label();
            pnlAccountSettings = new Panel();
            btnChangePassword = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblCurrentPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblAccountDescription = new Label();
            lblAccountHeading = new Label();
            pnlBackupRestore = new Panel();
            lblBackupStatus = new Label();
            btnCreateBackup = new Button();
            btnRestoreBackup = new Button();
            lblBackupDescription = new Label();
            lblBackupHeading = new Label();
            btnUserManagement = new Button();
            pnlAccountSettings.SuspendLayout();
            pnlBackupRestore.SuspendLayout();
            SuspendLayout();
            // 
            // lblSettingsHeading
            // 
            lblSettingsHeading.AutoSize = true;
            lblSettingsHeading.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSettingsHeading.ForeColor = Color.MidnightBlue;
            lblSettingsHeading.Location = new Point(30, 25);
            lblSettingsHeading.Name = "lblSettingsHeading";
            lblSettingsHeading.Size = new Size(131, 33);
            lblSettingsHeading.TabIndex = 0;
            lblSettingsHeading.Text = "Settings";
            // 
            // lblSettingsDescription
            // 
            lblSettingsDescription.AutoSize = true;
            lblSettingsDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSettingsDescription.ForeColor = Color.DimGray;
            lblSettingsDescription.Location = new Point(38, 70);
            lblSettingsDescription.Name = "lblSettingsDescription";
            lblSettingsDescription.Size = new Size(305, 17);
            lblSettingsDescription.TabIndex = 1;
            lblSettingsDescription.Text = "Manage your account and application preferences.";
            // 
            // pnlAccountSettings
            // 
            pnlAccountSettings.BackColor = SystemColors.ActiveCaption;
            pnlAccountSettings.BorderStyle = BorderStyle.FixedSingle;
            pnlAccountSettings.Controls.Add(btnChangePassword);
            pnlAccountSettings.Controls.Add(txtConfirmPassword);
            pnlAccountSettings.Controls.Add(lblConfirmPassword);
            pnlAccountSettings.Controls.Add(txtNewPassword);
            pnlAccountSettings.Controls.Add(lblNewPassword);
            pnlAccountSettings.Controls.Add(txtCurrentPassword);
            pnlAccountSettings.Controls.Add(lblCurrentPassword);
            pnlAccountSettings.Controls.Add(txtUsername);
            pnlAccountSettings.Controls.Add(lblUsername);
            pnlAccountSettings.Controls.Add(lblAccountDescription);
            pnlAccountSettings.Controls.Add(lblAccountHeading);
            pnlAccountSettings.Location = new Point(35, 120);
            pnlAccountSettings.Name = "pnlAccountSettings";
            pnlAccountSettings.Size = new Size(650, 472);
            pnlAccountSettings.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.ForestGreen;
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(27, 395);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(160, 38);
            btnChangePassword.TabIndex = 10;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(27, 355);
            txtConfirmPassword.MaxLength = 100;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(570, 25);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblConfirmPassword.Location = new Point(27, 330);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(126, 15);
            lblConfirmPassword.TabIndex = 8;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(27, 280);
            txtNewPassword.MaxLength = 100;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(570, 25);
            txtNewPassword.TabIndex = 7;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblNewPassword.Location = new Point(27, 255);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(103, 15);
            lblNewPassword.TabIndex = 6;
            lblNewPassword.Text = "New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(27, 205);
            txtCurrentPassword.MaxLength = 100;
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(570, 25);
            txtCurrentPassword.TabIndex = 5;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblCurrentPassword.Location = new Point(27, 180);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(125, 15);
            lblCurrentPassword.TabIndex = 4;
            lblCurrentPassword.Text = "Current Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(27, 130);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(570, 25);
            txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ActiveCaptionText;
            lblUsername.Location = new Point(27, 105);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblAccountDescription
            // 
            lblAccountDescription.AutoSize = true;
            lblAccountDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccountDescription.ForeColor = Color.DimGray;
            lblAccountDescription.Location = new Point(27, 58);
            lblAccountDescription.Name = "lblAccountDescription";
            lblAccountDescription.Size = new Size(233, 17);
            lblAccountDescription.TabIndex = 1;
            lblAccountDescription.Text = "Update your account password below.";
            // 
            // lblAccountHeading
            // 
            lblAccountHeading.AutoSize = true;
            lblAccountHeading.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccountHeading.ForeColor = SystemColors.ActiveCaptionText;
            lblAccountHeading.Location = new Point(25, 20);
            lblAccountHeading.Name = "lblAccountHeading";
            lblAccountHeading.Size = new Size(172, 24);
            lblAccountHeading.TabIndex = 0;
            lblAccountHeading.Text = "Account Setting";
            // 
            // pnlBackupRestore
            // 
            pnlBackupRestore.BackColor = Color.LightSteelBlue;
            pnlBackupRestore.BorderStyle = BorderStyle.FixedSingle;
            pnlBackupRestore.Controls.Add(lblBackupStatus);
            pnlBackupRestore.Controls.Add(btnCreateBackup);
            pnlBackupRestore.Controls.Add(btnRestoreBackup);
            pnlBackupRestore.Controls.Add(lblBackupDescription);
            pnlBackupRestore.Controls.Add(lblBackupHeading);
            pnlBackupRestore.Location = new Point(78, 660);
            pnlBackupRestore.Name = "pnlBackupRestore";
            pnlBackupRestore.Size = new Size(650, 230);
            pnlBackupRestore.TabIndex = 3;
            // 
            // lblBackupStatus
            // 
            lblBackupStatus.AutoSize = true;
            lblBackupStatus.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBackupStatus.ForeColor = Color.DimGray;
            lblBackupStatus.Location = new Point(30, 175);
            lblBackupStatus.Name = "lblBackupStatus";
            lblBackupStatus.Size = new Size(216, 27);
            lblBackupStatus.TabIndex = 4;
            lblBackupStatus.Text = "No backup created during this session.";
            // 
            // btnCreateBackup
            // 
            btnCreateBackup.BackColor = Color.Green;
            btnCreateBackup.Cursor = Cursors.Hand;
            btnCreateBackup.FlatStyle = FlatStyle.Flat;
            btnCreateBackup.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateBackup.ForeColor = Color.White;
            btnCreateBackup.Location = new Point(30, 115);
            btnCreateBackup.Name = "btnCreateBackup";
            btnCreateBackup.Size = new Size(250, 45);
            btnCreateBackup.TabIndex = 3;
            btnCreateBackup.Text = "Create Database Backup";
            btnCreateBackup.UseVisualStyleBackColor = false;
            btnCreateBackup.Click += btnCreateBackup_Click;
            // 
            // btnRestoreBackup
            // 
            btnRestoreBackup.BackColor = Color.Firebrick;
            btnRestoreBackup.Cursor = Cursors.Hand;
            btnRestoreBackup.FlatStyle = FlatStyle.Flat;
            btnRestoreBackup.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestoreBackup.ForeColor = Color.White;
            btnRestoreBackup.Location = new Point(310, 115);
            btnRestoreBackup.Name = "btnRestoreBackup";
            btnRestoreBackup.Size = new Size(250, 45);
            btnRestoreBackup.TabIndex = 2;
            btnRestoreBackup.Text = "Restore Database Backup";
            btnRestoreBackup.UseVisualStyleBackColor = false;
            btnRestoreBackup.Click += btnRestoreBackup_Click;
            // 
            // lblBackupDescription
            // 
            lblBackupDescription.AutoSize = true;
            lblBackupDescription.ForeColor = Color.DimGray;
            lblBackupDescription.Location = new Point(30, 60);
            lblBackupDescription.Name = "lblBackupDescription";
            lblBackupDescription.Size = new Size(357, 15);
            lblBackupDescription.TabIndex = 1;
            lblBackupDescription.Text = "Protect your shop data by creating or restoring a database backup.";
            // 
            // lblBackupHeading
            // 
            lblBackupHeading.AutoSize = true;
            lblBackupHeading.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBackupHeading.ForeColor = SystemColors.ActiveCaptionText;
            lblBackupHeading.Location = new Point(30, 20);
            lblBackupHeading.Name = "lblBackupHeading";
            lblBackupHeading.Size = new Size(314, 24);
            lblBackupHeading.TabIndex = 0;
            lblBackupHeading.Text = "Database Backup and Restore";
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.MidnightBlue;
            btnUserManagement.Cursor = Cursors.Hand;
            btnUserManagement.FlatStyle = FlatStyle.Popup;
            btnUserManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Location = new Point(598, 57);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(250, 45);
            btnUserManagement.TabIndex = 4;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click_1;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btnUserManagement);
            Controls.Add(pnlBackupRestore);
            Controls.Add(pnlAccountSettings);
            Controls.Add(lblSettingsDescription);
            Controls.Add(lblSettingsHeading);
            Name = "SettingsControl";
            Size = new Size(996, 900);
            pnlAccountSettings.ResumeLayout(false);
            pnlAccountSettings.PerformLayout();
            pnlBackupRestore.ResumeLayout(false);
            pnlBackupRestore.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSettingsHeading;
        private Label lblSettingsDescription;
        private Panel pnlAccountSettings;
        private Label lblAccountDescription;
        private Label lblAccountHeading;
        private TextBox txtCurrentPassword;
        private Label lblCurrentPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private Button btnChangePassword;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Panel pnlBackupRestore;
        private Label lblBackupHeading;
        private Button btnCreateBackup;
        private Button btnRestoreBackup;
        private Label lblBackupDescription;
        private Label lblBackupStatus;
        private Button btnUserManagement;
    }
}
