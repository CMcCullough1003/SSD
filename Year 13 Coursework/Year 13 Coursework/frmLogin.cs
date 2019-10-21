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
using Year_13_Coursework.Tools;
using Year_13_Coursework.Constants;

namespace Year_13_Coursework
{
    public partial class frmLogin : Form
    {

        private Files files = new Files();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = tbxUsername.Text;
            string passwordInput = tbxPassword.Text;

            if (checkInputsProvided(usernameInput, passwordInput))
            {
                MessageBox.Show("Username and Password must not be empty", "try again");
                return;
            }

            if (! files.checkFileExists(FileConstants.USER_FILE_LOCATION))
            {
                MessageBox.Show("Please check the file exists", "No file found");
                return;
            }

            List<string> users = getUsers();

            foreach(string element in users)
            {
                List<string> userDetails = element.Split('~').ToList();

                for(int i = 0; i<userDetails.Count; i++)
                {
                    string usernameFile = userDetails[0];
                    string passwordFile = userDetails[1];
                    
                    if(usernameFile == usernameInput && passwordFile == passwordInput)
                    {
                        moveToStartScreen();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Your username or password is incorrect", "failure");
                        clearUserInputs();
                        break;
                    }             
                }
            }
        }

        private void clearUserInputs()
        {
            tbxPassword.Clear();
            tbxUsername.Clear();
        }

        private List<string> getUsers()
        {
            return files.getFileContents(FileConstants.USER_FILE_LOCATION);
        }

        private Boolean checkInputsProvided(string name, string password) 
        {
            return string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password);
        }

        private void moveToStartScreen()
        {
            this.Hide();
            Form MoveToStartScreen = new frmStartScreen();
            MoveToStartScreen.Show();
        }

        private void moveToRegisterScreen()
        {
            this.Hide();
            Form MoveToRegister = new frmRegister();
            MoveToRegister.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            moveToRegisterScreen();
        }
    }
}
