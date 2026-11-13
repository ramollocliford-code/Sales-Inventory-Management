namespace Sales_Inventory_Management
{
    partial class OwnerSetUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnCreateAccount = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(195, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Owner Account";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(210, 85);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(65, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "UserName:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(281, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(281, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(210, 133);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(167, 183);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(104, 15);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "ConfirmPassword:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(281, 180);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(100, 23);
            txtConfirmPassword.TabIndex = 6;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(251, 235);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(86, 29);
            btnCreateAccount.TabIndex = 7;
            btnCreateAccount.Text = "CREATE";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // OwnerSetUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "OwnerSetUp";
            Text = "OwnerSetUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnCreateAccount;
    }
}