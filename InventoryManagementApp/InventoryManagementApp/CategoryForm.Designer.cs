namespace InventoryManagementApp
{
    partial class CategoryForm
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
            lblCode = new Label();
            txtCode = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            button1 = new Button();
            btnClear = new Button();
            lstCategory = new ListView();
            btnDelete = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Algerian", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(555, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 38);
            btnClose.TabIndex = 6;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Modern No. 20", 27.7499962F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 64, 64);
            lblTitle.Location = new Point(2, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(479, 38);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Inventory Management System";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCode.ForeColor = Color.Teal;
            lblCode.Location = new Point(28, 82);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(161, 22);
            lblCode.TabIndex = 4;
            lblCode.Text = "Category Code:";
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Centaur", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.ForeColor = Color.Teal;
            txtCode.Location = new Point(26, 108);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(163, 29);
            txtCode.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Teal;
            lblName.Location = new Point(28, 163);
            lblName.Name = "lblName";
            lblName.Size = new Size(165, 22);
            lblName.TabIndex = 4;
            lblName.Text = "Category Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Centaur", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.Teal;
            txtName.Location = new Point(26, 189);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 29);
            txtName.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(26, 243);
            button1.Name = "button1";
            button1.Size = new Size(74, 37);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 255, 255);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(118, 243);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 37);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lstCategory
            // 
            lstCategory.Location = new Point(250, 82);
            lstCategory.Name = "lstCategory";
            lstCategory.Size = new Size(326, 198);
            lstCategory.TabIndex = 8;
            lstCategory.UseCompatibleStateImageBehavior = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 255, 255);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(497, 304);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 37);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(128, 255, 255);
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Teal;
            btnEdit.Location = new Point(407, 304);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(74, 37);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(607, 372);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lstCategory);
            Controls.Add(btnClear);
            Controls.Add(button1);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtCode);
            Controls.Add(lblCode);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblTitle;
        private Label lblCode;
        private TextBox txtCode;
        private Label lblName;
        private TextBox txtName;
        private Button button1;
        private Button btnClear;
        private ListView lstCategory;
        private Button btnDelete;
        private Button btnEdit;
    }
}