namespace Sales_Inventory_Management
{
    partial class UserManagementControl
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
            lblPageTitle = new Label();
            lblDescription = new Label();
            pnlCreateUser = new Panel();
            btnCreateUser = new Button();
            cmbRole = new ComboBox();
            lblRole = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblCreateUserHeading = new Label();
            panel1 = new Panel();
            dgvUsers = new DataGridView();
            lblUserAccountsHeading = new Label();
            btnBack = new Button();
            btnRemoveUser = new Button();
            pnlCreateUser.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.MidnightBlue;
            lblPageTitle.Location = new Point(40, 25);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(272, 33);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "User Management";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(43, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(229, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Create and manage system user accounts.";
            // 
            // pnlCreateUser
            // 
            pnlCreateUser.BackColor = SystemColors.ActiveCaption;
            pnlCreateUser.BorderStyle = BorderStyle.Fixed3D;
            pnlCreateUser.Controls.Add(btnCreateUser);
            pnlCreateUser.Controls.Add(cmbRole);
            pnlCreateUser.Controls.Add(lblRole);
            pnlCreateUser.Controls.Add(txtConfirmPassword);
            pnlCreateUser.Controls.Add(lblConfirmPassword);
            pnlCreateUser.Controls.Add(lblPassword);
            pnlCreateUser.Controls.Add(txtPassword);
            pnlCreateUser.Controls.Add(txtUsername);
            pnlCreateUser.Controls.Add(lblUsername);
            pnlCreateUser.Controls.Add(lblCreateUserHeading);
            pnlCreateUser.Location = new Point(40, 115);
            pnlCreateUser.Name = "pnlCreateUser";
            pnlCreateUser.Size = new Size(650, 350);
            pnlCreateUser.TabIndex = 2;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.ForestGreen;
            btnCreateUser.Cursor = Cursors.Hand;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateUser.ForeColor = Color.White;
            btnCreateUser.Location = new Point(25, 255);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(180, 45);
            btnCreateUser.TabIndex = 9;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = false;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(340, 180);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(280, 23);
            cmbRole.TabIndex = 8;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = SystemColors.ActiveCaptionText;
            lblRole.Location = new Point(340, 155);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(33, 14);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(25, 180);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(280, 23);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblConfirmPassword.Location = new Point(25, 155);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(115, 14);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblPassword.Location = new Point(340, 70);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 14);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(340, 95);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(25, 95);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 23);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ActiveCaptionText;
            lblUsername.Location = new Point(25, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(67, 14);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblCreateUserHeading
            // 
            lblCreateUserHeading.AutoSize = true;
            lblCreateUserHeading.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateUserHeading.ForeColor = SystemColors.ActiveCaptionText;
            lblCreateUserHeading.Location = new Point(20, 15);
            lblCreateUserHeading.Name = "lblCreateUserHeading";
            lblCreateUserHeading.Size = new Size(120, 22);
            lblCreateUserHeading.TabIndex = 0;
            lblCreateUserHeading.Text = "Create User";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dgvUsers);
            panel1.Controls.Add(lblUserAccountsHeading);
            panel1.Location = new Point(40, 485);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 300);
            panel1.TabIndex = 10;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(20, 55);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(605, 220);
            dgvUsers.TabIndex = 1;
            // 
            // lblUserAccountsHeading
            // 
            lblUserAccountsHeading.AutoSize = true;
            lblUserAccountsHeading.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserAccountsHeading.ForeColor = Color.MidnightBlue;
            lblUserAccountsHeading.Location = new Point(20, 15);
            lblUserAccountsHeading.Name = "lblUserAccountsHeading";
            lblUserAccountsHeading.Size = new Size(222, 22);
            lblUserAccountsHeading.TabIndex = 0;
            lblUserAccountsHeading.Text = "Existing User Accounts";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(40, 806);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 42);
            btnBack.TabIndex = 10;
            btnBack.Text = "EXIT";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.BackColor = Color.Maroon;
            btnRemoveUser.FlatStyle = FlatStyle.Flat;
            btnRemoveUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveUser.ForeColor = Color.White;
            btnRemoveUser.Location = new Point(575, 807);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(115, 42);
            btnRemoveUser.TabIndex = 2;
            btnRemoveUser.Text = "Remove User";
            btnRemoveUser.UseVisualStyleBackColor = false;
            // 
            // UserManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnRemoveUser);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(pnlCreateUser);
            Controls.Add(lblDescription);
            Controls.Add(lblPageTitle);
            Name = "UserManagementControl";
            Size = new Size(1122, 960);
            pnlCreateUser.ResumeLayout(false);
            pnlCreateUser.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Label lblDescription;
        private Panel pnlCreateUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblCreateUserHeading;
        private ComboBox cmbRole;
        private Label lblRole;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Button btnCreateUser;
        private Panel panel1;
        private DataGridView dgvUsers;
        private Label lblUserAccountsHeading;
        private Button btnBack;
        private Button btnRemoveUser;
    }
}
