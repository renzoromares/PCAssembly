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
    public partial class Cpu : Form
    {
        public Cpu()
        {
            InitializeComponent();
        }

        private void lblcpuHead_MouseEnter(object sender, EventArgs e)
        {
            lblcpuHead.ForeColor = Color.FromArgb(226, 103, 35);
        }

        private void lblcpuHead_MouseLeave(object sender, EventArgs e)
        {
            lblcpuHead.ForeColor = Color.Yellow;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
