namespace Sales_Inventory_Management
{
    partial class LOGIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            pcbLOGO = new PictureBox();
            pnlLogin = new Panel();
            label1 = new Label();
            btnLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblAppName = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbLOGO).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pcbLOGO
            // 
            pcbLOGO.Image = (Image)resources.GetObject("pcbLOGO.Image");
            pcbLOGO.Location = new Point(89, 0);
            pcbLOGO.Name = "pcbLOGO";
            pcbLOGO.Size = new Size(218, 147);
            pcbLOGO.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLOGO.TabIndex = 0;
            pcbLOGO.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = SystemColors.ActiveCaption;
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtUserName);
            pnlLogin.Controls.Add(lblAppName);
            pnlLogin.Controls.Add(pcbLOGO);
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(400, 560);
            pnlLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 539);
            label1.Name = "label1";
            label1.Size = new Size(128, 13);
            label1.TabIndex = 6;
            label1.Text = "RAMOLLO LEGION 2026";
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(113, 347);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(76, 286);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(129, 17);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Enter Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(76, 222);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(132, 17);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Enter Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(76, 306);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(255, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(76, 242);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(255, 23);
            txtUserName.TabIndex = 2;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = SystemColors.ActiveCaptionText;
            lblAppName.Location = new Point(89, 168);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(253, 15);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "SALE AND INVENTORY MANAGEMENT";
            // 
            // LOGIN
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(959, 561);
            Controls.Add(pnlLogin);
            ForeColor = SystemColors.ActiveCaptionText;
            MinimumSize = new Size(800, 600);
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            WindowState = FormWindowState.Maximized;
            Load += LOGIN_Load;
            ((System.ComponentModel.ISupportInitialize)pcbLOGO).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbLOGO;
        private Panel pnlLogin;
        private Label lblAppName;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnLogin;
        private Label label1;
    }
}
