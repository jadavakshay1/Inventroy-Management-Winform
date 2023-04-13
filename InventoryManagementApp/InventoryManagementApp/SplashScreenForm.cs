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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenForm_Shown(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
            progressBar1.Maximum = 10;
            timer1.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                LoginForm mf = new LoginForm();
                mf.Show();
                this.Hide();
            }           
        }
    }
}
