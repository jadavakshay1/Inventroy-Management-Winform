using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pwd = txtPassword.Text;

            if (username.Equals("Admin") && pwd.Equals("Admin123"))
            {
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User Name and Password");
            }

        }
    }
}
