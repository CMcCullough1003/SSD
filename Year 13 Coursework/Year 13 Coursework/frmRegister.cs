using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Year_13_Coursework.Constants;
using Year_13_Coursework.Tools;

namespace Year_13_Coursework
{
    public partial class frmRegister : Form
    {
        private Files files = new Files();
        private const int MINIMUM_PASSWORD_LENGTH = 4;
        private const int MINIMUM_USERNAME_LENGTH = 4;

        //Setting up the screen
        public frmRegister()
        {
            InitializeComponent();
            addAvatars();
        }

        private void addAvatars()
        {
            pbxAvatar1.Image = Properties.Resources.cow;
            pbxAvatar1.Tag = "cow.png";
            pbxAvatar2.Image = Properties.Resources.bee;
            pbxAvatar2.Tag = "bee.png";
            pbxAvatar3.Image = Properties.Resources.chicken;
            pbxAvatar3.Tag = "chicken.png";
            pbxAvatar4.Image = Properties.Resources.elephant;
            pbxAvatar4.Tag = "elephant.png";
            pbxAvatar5.Image = Properties.Resources.pig;
            pbxAvatar5.Tag = "pig.png";
            pbxAvatar6.Image = Properties.Resources.triceratops;
            pbxAvatar6.Tag = "triceratops.png";
            pbxAvatar7.Image = Properties.Resources.dog;
            pbxAvatar7.Tag = "dog.png";
            pbxAvatar8.Image = Properties.Resources.ghost;
            pbxAvatar8.Tag = "ghost.png";
            pbxAvatar9.Image = Properties.Resources.sheep;
            pbxAvatar9.Tag = "sheep.png";
        }

        //On click methods
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

            if (pbxSelected.Tag == null)
            {
                MessageBox.Show("Please select an avatar", "Error");
                return;
            }

            if (!File.Exists(FileConstants.USER_FILE_LOCATION))
            {
                File.Create(FileConstants.USER_FILE_LOCATION);
            }

            MessageBox.Show("Your registration was successful", "Success");
            saveUserDetailsToFile();
            saveAsCurrentUser();
            moveToStartScreen();
                        
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            moveToLoginScreen();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pbxAvatar1.Image;
            pbxSelected.Tag = pbxAvatar1.Tag;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pbxAvatar2.Image;
            pbxSelected.Tag = pbxAvatar2.Tag;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pbxAvatar3.Image;
            pbxSelected.Tag = pbxAvatar3.Tag;
        }

        private void PbxAvatar4_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pbxAvatar4.Image;
            pbxSelected.Tag = pbxAvatar4.Tag;
        }

        private void PbxAvatar5_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pbxAvatar5.Image;
            pbxSelected.Tag = pbxAvatar5.Tag;
        }

        private void PbxAvatar6_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pbxAvatar6.Image;
            pbxSelected.Tag = pbxAvatar6.Tag;
        }

        private void PbxAvatar7_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pbxAvatar7.Image;
            pbxSelected.Tag = pbxAvatar7.Tag;

        }

        private void PbxAvatar8_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pbxAvatar8.Image;
            pbxSelected.Tag = pbxAvatar8.Tag;
        }

        private void PbxAvatar9_Click(object sender, EventArgs e)
        {
            pbxSelected.Image = pbxAvatar9.Image;
            pbxSelected.Tag = pbxAvatar9.Tag;
        }

        //Move to other screens
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

        //Input fields
        private void clearPasswords()
        {
            tbxPassword.Clear();
            tbxConfirmPassword.Clear();
        }

        private Boolean checkAllInputsProvided(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username))
            {
                return true;
            }

            if (string.IsNullOrEmpty(password))
            {
                return true;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                return true;
            }

            return false;
        }

        //Saving the user inputs
        private void saveUserDetailsToFile()
        {
            string userDetails = tbxUsername.Text + FileConstants.USER_FILE_SEPARATOR + tbxPassword.Text + FileConstants.USER_FILE_SEPARATOR + pbxSelected.Tag;
            files.appendToFile(FileConstants.USER_FILE_LOCATION, userDetails);
        }

        private void saveAsCurrentUser()
        {
            Program.currentUser.currentName = tbxUsername.Text;
            Program.currentUser.currentPassword = tbxPassword.Text;
            Program.currentUser.currentAvatar = pbxSelected.Tag.ToString();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
