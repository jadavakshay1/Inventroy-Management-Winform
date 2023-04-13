namespace InventoryManagementApp
{
    partial class DashboardForm
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
            btnClose = new Button();
            lblTitle = new Label();
            btnCategory = new Button();
            btnProduct = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Algerian", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(557, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Modern No. 20", 27.7499962F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 64, 64);
            lblTitle.Location = new Point(4, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(479, 38);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Inventory Management System";
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.FromArgb(128, 255, 255);
            btnCategory.FlatStyle = FlatStyle.Popup;
            btnCategory.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategory.ForeColor = Color.Teal;
            btnCategory.Location = new Point(209, 93);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(144, 63);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(128, 255, 255);
            btnProduct.FlatStyle = FlatStyle.Popup;
            btnProduct.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.Teal;
            btnProduct.Location = new Point(209, 175);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(144, 63);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Cinzel Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(209, 255);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(144, 63);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(607, 372);
            Controls.Add(btnLogout);
            Controls.Add(btnProduct);
            Controls.Add(btnCategory);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            ForeColor = Color.FromArgb(192, 255, 255);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblTitle;
        private Button btnCategory;
        private Button btnProduct;
        private Button btnLogout;
    }
}