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
            addAvatars();
        }

        private void addAvatars()
        {
            pictureBox1.Image = Properties.Resources.cow;
            pictureBox1.Tag = "cow.png";
            pictureBox2.Image = Properties.Resources.cow;
            pictureBox2.Tag = "cow.png";
        }

        private const int MINIMUM_PASSWORD_LENGTH = 4;
        private const int MINIMUM_USERNAME_LENGTH = 4;

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            string confirmPassword = tbxConfirmPassword.Text;

            if(checkAllInputsProvided(username, password, confirmPassword))
            {
                MessageBox.Show("Please ensure that all boxes are filled", "Failure");
                return;
            }

            if(username.Length < MINIMUM_USERNAME_LENGTH)
            {
                MessageBox.Show("Please ensure your username is at least " + MINIMUM_USERNAME_LENGTH + " characters long", "Error");
                return;
            }

            if (password.Length < MINIMUM_PASSWORD_LENGTH)
            {
                MessageBox.Show("Please ensure your password is at least " + MINIMUM_PASSWORD_LENGTH + " characters long", "Error");
                clearPasswords();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Make sure the password is the same in both boxes", "Error");
                clearPasswords();
                return;
            }

            MessageBox.Show("Your registration was successful", "Success");
            moveToStartScreen();
                        
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            moveToLoginScreen();
        }

        private void moveToStartScreen()
        {
            this.Hide();
            Form MoveToStartScreen = new frmStartScreen();
            MoveToStartScreen.Show();
        }

        private void moveToLoginScreen()
        {
            this.Hide();
            Form MoveToLogin = new frmLogin();
            MoveToLogin.Show();
        }

        private void clearPasswords()
        {
            tbxPassword.Clear();
            tbxConfirmPassword.Clear();
        }

        private Boolean checkAllInputsProvided(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                return false;
            }

            return true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pictureBox1.Image;
            pbxSelected.Tag = pictureBox1.Tag;
        }
    }
}
