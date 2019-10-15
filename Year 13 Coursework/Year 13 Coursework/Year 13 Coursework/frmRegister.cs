using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_13_Coursework
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            string confirmPassword = tbxConfirmPassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword))
            {
                if (username.Length >= 6)
                {
                    if (password.Length >= 4)
                    {
                        if (confirmPassword == password)
                        {
                            MessageBox.Show("Your registration was successful", "Success");
                            this.Hide();
                            Form MoveToLogin = new frmLogin();
                            MoveToLogin.Show();
                        }
                        else
                        {
                            MessageBox.Show("Make sure the password is the same in both boxes", "Error");
                            tbxUsername.Clear();
                            tbxPassword.Clear();
                            tbxConfirmPassword.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure your password is at least 4 characters long", "Error");
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                        tbxConfirmPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure your username is at least 6 characters long", "Error");
                    tbxUsername.Clear();
                    tbxPassword.Clear();
                    tbxConfirmPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please ensure that all boxes are filled", "Failure");
                tbxUsername.Clear();
                tbxPassword.Clear();
                tbxConfirmPassword.Clear();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MoveToLogin = new frmLogin();
            MoveToLogin.Show();
        }
    }
}
