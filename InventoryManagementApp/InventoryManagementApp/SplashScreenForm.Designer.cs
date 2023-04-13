namespace InventoryManagementApp
{
    partial class SplashScreenForm
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblDeveloper = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Modern No. 20", 27.7499962F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 64, 64);
            lblTitle.Location = new Point(12, 86);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(479, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management System";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Font = new Font("Cabin Sketch", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeveloper.ForeColor = Color.Teal;
            lblDeveloper.Location = new Point(225, 124);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(266, 32);
            lblDeveloper.TabIndex = 0;
            lblDeveloper.Text = "Developer By: Akshay";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(0, 64, 64);
            progressBar1.Location = new Point(129, 207);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(227, 23);
            progressBar1.TabIndex = 1;
            // 
            // SplashScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(492, 287);
            Controls.Add(progressBar1);
            Controls.Add(lblDeveloper);
            Controls.Add(lblTitle);
            ForeColor = Color.FromArgb(192, 255, 255);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreenForm";
            Shown += SplashScreenForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDeveloper;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
    }
}