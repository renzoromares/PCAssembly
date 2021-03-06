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
    public partial class Mobo : Form
    {
        public Mobo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        private void lblMoboHead_MouseEnter(object sender, EventArgs e)
        {
            lblMoboHead.ForeColor = Color.FromArgb(226, 103, 35);
        }

        private void lblMoboHead_MouseLeave(object sender, EventArgs e)
        {
            lblMoboHead.ForeColor = Color.Yellow;
        }
    }
}
