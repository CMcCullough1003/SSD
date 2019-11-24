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
            pbxAvatar1.Image = Properties.Resources._18camp_115462;
            pbxAvatar1.Tag = "cow.png";
            pbxAvatar2.Image = Properties.Resources.signs;
            pbxAvatar2.Tag = "bee.png";
            pbxAvatar3.Image = Properties.Resources.camera;
            pbxAvatar3.Tag = "chicken.png";
            pbxAvatar5.Image = Properties.Resources.cocktail;
            pbxAvatar5.Tag = "pig.png";
            pbxAvatar6.Image = Properties.Resources.globe;
            pbxAvatar6.Tag = "triceratops.png";
            pbxAvatar9.Image = Properties.Resources.icecream;
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
                lblError.Text = "Please fill all fields";
                return;
            }

            if(username.Length < MINIMUM_USERNAME_LENGTH)
            {
                lblError.Text = "Username must be " + MINIMUM_USERNAME_LENGTH + " characters long";
                return;
            }

            if (password.Length < MINIMUM_PASSWORD_LENGTH)
            {
                lblError.Text = "Password must be " + MINIMUM_PASSWORD_LENGTH + " characters long";
                clearPasswords();
                return;
            }

            if (password != confirmPassword)
            {
                lblError.Text = "Password must be the same in both feilds";
                clearPasswords();
                return;
            }

            if (pbxSelected.Tag == null)
            {
                lblError.Text = "Please select an avatar";
                return;
            }

            //MessageBox.Show("Your registration was successful", "Success");
            saveUserDetailsToFile();
            saveAsCurrentUser();
            moveToStartScreen();
                        
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            avatarSelected(pbxAvatar1);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            avatarSelected(pbxAvatar2);
        }

        private void PbxAvatar3_Click(object sender, EventArgs e)
        {
            avatarSelected(pbxAvatar3);
        }

        private void PbxAvatar5_Click(object sender, EventArgs e)
        {
            avatarSelected(pbxAvatar5);
        }

        private void PbxAvatar6_Click(object sender, EventArgs e)
        {
            avatarSelected(pbxAvatar6);
        }

        private void PbxAvatar9_Click(object sender, EventArgs e)
        {
            avatarSelected(pbxAvatar9);
        }

        //Move to other screens
        private void moveToStartScreen()
        {
            this.Close();
            Form MoveToStartScreen = new frmStartScreen();
            MoveToStartScreen.Show();
        }

        private void moveToLoginScreen()
        {
            this.Close();
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
            using (StreamWriter writer = File.AppendText(FileConstants.USER_FILE_NAME))
            {
                writer.WriteLine(userDetails);
            }
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

        private void avatarSelected(PictureBox avatar)
        {
            clearAllBorders();
            avatar.BorderStyle = BorderStyle.FixedSingle;
            pbxSelected.Image = avatar.Image;
            pbxSelected.Tag = avatar.Tag;
        }

        private void clearAllBorders()
        {
            pbxAvatar1.BorderStyle = BorderStyle.None;
            pbxAvatar2.BorderStyle = BorderStyle.None;
            pbxAvatar3.BorderStyle = BorderStyle.None;
            pbxAvatar5.BorderStyle = BorderStyle.None;
            pbxAvatar9.BorderStyle = BorderStyle.None;
            pbxAvatar6.BorderStyle = BorderStyle.None;

        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            moveToLoginScreen();
        }
    }
}
