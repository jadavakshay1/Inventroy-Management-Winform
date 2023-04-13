namespace InventoryManagementApp
{
    partial class LoginForm
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
            btnClose = new Button();
            lblUserName = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Modern No. 20", 27.7499962F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 64, 64);
            lblTitle.Location = new Point(2, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(479, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Inventory Management System";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Algerian", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(555, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.Teal;
            lblUserName.Location = new Point(114, 116);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(113, 22);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Teal;
            lblPassword.Location = new Point(127, 175);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 22);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 255);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Teal;
            btnLogin.Location = new Point(254, 259);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Centaur", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(243, 119);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(173, 29);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Centaur", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(243, 178);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(173, 29);
            txtPassword.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(607, 372);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnClose;
        private Label lblUserName;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}