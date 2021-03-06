using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PCAssembly
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void txtusername_MouseEnter(object sender, EventArgs e)
        {
            if (string.Equals(txtusername.Text, "username"))
            {
                txtusername.Text = "";
                lblusername.Visible = true;
                txtusername.ForeColor = Color.Black;
            }


        }

        private void txtusername_MouseLeave(object sender, EventArgs e)
        {
            if (string.Equals(txtusername.Text, ""))
            {
                txtusername.Text = "username";
                lblusername.Visible = false;
                txtusername.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void txtEmail_MouseEnter(object sender, EventArgs e)
        {
            if (string.Equals(txtEmail.Text, "E - mail"))
            {
                txtEmail.Text = "";
                lblemail.Visible = true;
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            if (string.Equals(txtEmail.Text, ""))
            {
                txtEmail.Text = "E - mail";
                lblemail.Visible = false;
                txtEmail.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (string.Equals(txtPassword.Text, "Password"))
            {
                txtPassword.Text = "";
                lblpassword.Visible = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (string.Equals(txtPassword.Text, ""))
            {
                txtPassword.Text = "Password";
                lblpassword.Visible = false;
                txtPassword.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void txtConfirmPassword_MouseEnter(object sender, EventArgs e)
        {
            if (string.Equals(txtConfirmPassword.Text, "Password"))
            {
                txtConfirmPassword.Text = "";
                lblconfirmpass.Visible = true;
                txtConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void txtConfirmPassword_MouseLeave(object sender, EventArgs e)
        {

            if (string.Equals(txtConfirmPassword.Text, ""))
            {
                txtConfirmPassword.Text = "Password";
                lblconfirmpass.Visible = false;
                txtConfirmPassword.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void bntRegister_Click(object sender, EventArgs e)
        {
            if (!string.Equals(txtusername.Text, "username") && !string.Equals(txtPassword.Text, "password") &&  !string.Equals(txtEmail.Text, "E - mail") &&  !string.Equals(txtConfirmPassword.Text, "password"))
            {
                if (txtusername.Text != "username" || txtPassword.Text != "password" || txtEmail.Text != "E - mail" || txtConfirmPassword.Text != "password")
                {
                    connect();
                    refresh();
                }
                else if (txtusername.Text == "username" || txtPassword.Text == "password" || txtEmail.Text == "E - mail" || txtConfirmPassword.Text == "password")
                {
                    MessageBox.Show("Please complete Details!");
                }
                else if (string.Equals(txtPassword.Text, txtConfirmPassword.Text))
                {
                    MessageBox.Show("Password don't match!");
                }
            }
            else 
            {
                MessageBox.Show("Please complete Details");
            }         

        }

        private void connect()
        {
            //using (SqlConnection con = new SqlConnection(ConnectionString.connect))
            //{
            //    con.Open();
            //    using (SqlCommand cmd = new SqlCommand)
            //}
            MessageBox.Show("x");
        }
        private void refresh()
        {
            txtusername.Text = "username";
            lblusername.Visible = false;
            txtusername.ForeColor = Color.FromArgb(224, 224, 224);

            txtEmail.Text = "E - mail";
            lblemail.Visible = false;
            txtEmail.ForeColor = Color.FromArgb(224, 224, 224);

            txtPassword.Text = "Password";
            lblpassword.Visible = false;
            txtPassword.ForeColor = Color.FromArgb(224, 224, 224);

            txtConfirmPassword.Text = "Password";
            lblconfirmpass.Visible = false;
            txtConfirmPassword.ForeColor = Color.FromArgb(224, 224, 224);

            MessageBox.Show("Registration successful!");

        }

        private void btExit_MouseEnter(object sender, EventArgs e)
        {
            btExit.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void btExit_MouseLeave(object sender, EventArgs e)
        {
            btExit.BackColor = Color.FromArgb(17, 17, 18);
        }
    }
}
