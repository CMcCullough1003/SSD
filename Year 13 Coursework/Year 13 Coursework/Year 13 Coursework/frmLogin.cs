﻿using System;
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


            //Get the list of all the users 
            List<string> userList = getUsers();

            //Loop through all of the users from the file
            foreach (string user in userList)
            {
                //Split up the user details
                List<string> userDetails = user.Split(FileConstants.USER_FILE_SEPARATOR).ToList();

                //Get the users details from the split up string
                string usernameFromFile = userDetails[FileConstants.USER_FILE_NAME_POSITION];
                string passwordFromFile = userDetails[FileConstants.USER_FILE_PASSWORD_POSITION];
                string avatarFromFile = userDetails[FileConstants.USER_FILE_AVATAR_POSITION];

                //Check if the details from the file are the same as entered on screen
                if (usernameFromFile == usernameInput && passwordFromFile == passwordInput)
                {
                    //We have found a match - Set the global user details
                    Program.currentUser.currentName = usernameFromFile;
                    Program.currentUser.currentPassword = passwordFromFile;
                    Program.currentUser.currentAvatar = avatarFromFile;
                    break;
                }   
            }

            //Did we find a match?
            if (Program.currentUser.currentName == "")
            {
                MessageBox.Show("Your username or password is incorrect", "failure");
                clearUserInputs();
            }
            else
            {
                moveToStartScreen();
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Program.currentUser.resetUser();
        }
    }
}