using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCAssembly
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.Show();
        }

        private void btnCpu_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control c  in panelBrowse.Controls)
            {
                if (c is Button)
                {
                    (sender as Button).BackColor = Color.FromArgb(78, 142, 245);
                }
            }
        }

        private void btnOS_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control c in panelBrowse.Controls)
            {
                if (c is Button)
                {
                    (sender as Button).BackColor = Color.FromArgb(32, 32, 36);
                }
            }
        }

        private void btnCmpBlds_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control c in panelSide.Controls)
            {
                if (c is Button)
                {
                    (sender as Button).BackColor = Color.FromArgb(78, 142, 245);
                }
            }
        }

        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control c in panelSide.Controls)
            {
                if (c is Button)
                {
                    (sender as Button).BackColor = Color.FromArgb(32, 32, 36);
                }
            }
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control c in panelSide.Controls)
            {
                if (c is Button)
                {
                    (sender as Button).ForeColor = Color.FromArgb(223, 155, 31);
                }
            }
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control c in panelSide.Controls)
            {
                if (c is Button)
                {
                    (sender as Button).ForeColor = Color.White;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            panelBrowse.Visible = true;
        }

    }
}
