﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Year_13_Coursework.Constants;
using Year_13_Coursework.Tools;
using Year_13_Coursework.Exceptions;
using System.Collections;

namespace Year_13_Coursework
{
    public partial class frmResults : Form
    {
        List<string> userList = new List<string>();

        private Files files = new Files();
        private string grade = "";

        public frmResults()
        {
            InitializeComponent();
        }

        private void FrmResults_Load(object sender, EventArgs e)
        {
            displayScores();
            displayGrade();
            createListOfAllUserScores();
            sortUserScores();

            //delete all rows in file

            //write list into file
            //loop through all users
            //Register file - saveUserDetailsToFile()

            string x = "";

        }

        private void displayScores() {
            label1.Text = Program.currentUser.game1Score.ToString() + "/6";
            label2.Text = Program.currentUser.game2Score.ToString() + "/3";
            label3.Text = Program.currentUser.game3Score.ToString() + "/9";
            label4.Text = Program.currentUser.game4Score.ToString() + "/6";
            label5.Text = Program.currentUser.game5Score.ToString() + "/4";
            label6.Text = Program.currentUser.game6Score.ToString() + "/16";
            lblTotal.Text = Program.currentUser.totalScore.ToString() + "/44";
        }

        private void displayGrade()
        {
            calculateGrade();
            lblGrade.Text = grade;
        }

        private void calculateGrade()
        {
            if(Program.currentUser.totalScore >= 35)
            {
                grade = "A";
            }
            else if (Program.currentUser.totalScore >= 29)
            {
                grade = "B";
            }
            else if (Program.currentUser.totalScore >= 23)
            {
                grade = "C";
            }
            else if (Program.currentUser.totalScore >= 17)
            {
                grade = "D";
            }
            else if (Program.currentUser.totalScore >= 11)
            {
                grade = "E";
            }
            else
            {
                grade = "F";
            }
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            moveToStartScreen();
            Program.currentUser.resetUserScores();
        }

        private void moveToStartScreen()
        {
            this.Close();
            Form frm = new frmStartScreen();
            frm.Show();
        }

        private void getUsers()
        {
            try
            {
                userList = files.getFileContents(FileConstants.USER_FILE_NAME);
            }
            catch (NoUsersFoundException ex)
            {
                userList = new List<string>();
            }
        }

        private void createListOfAllUserScores()
        {
            getUsers();
            checkIfUserOnList();
        }

        private string createUserString()
        {
            string userToSave = "";
            userToSave += Program.currentUser.currentName + Char.ToString(Constants.FileConstants.USER_FILE_SEPARATOR);
            userToSave += Program.currentUser.currentPassword + Char.ToString(Constants.FileConstants.USER_FILE_SEPARATOR);
            userToSave += Program.currentUser.currentAvatar + Char.ToString(Constants.FileConstants.USER_FILE_SEPARATOR);
            userToSave += Program.currentUser.game1Score + Char.ToString(Constants.FileConstants.USER_FILE_SEPARATOR);
            userToSave += Program.currentUser.game2Score + Char.ToString(Constants.FileConstants.USER_FILE_SEPARATOR);
            userToSave += Program.currentUser.game3Score + Char.ToString(Constants.FileConstants.USER_FILE_SEPARATOR);
            userToSave += Program.currentUser.game4Score + Char.ToString(Constants.FileConstants.USER_FILE_SEPARATOR);
            userToSave += Program.currentUser.game5Score + Char.ToString(Constants.FileConstants.USER_FILE_SEPARATOR);
            userToSave += Program.currentUser.game6Score + Char.ToString(Constants.FileConstants.USER_FILE_SEPARATOR);
            userToSave += Program.currentUser.totalScore;

            return userToSave;
        }


        private void checkIfUserOnList()
        {
            for(int i = 0; i < userList.Count; i++)
            {
                //Split up the user details
                List<string> userDetailsFromFile = userList[i].Split(FileConstants.USER_FILE_SEPARATOR).ToList();

                //Get the users details from the split up string
                string usernameFromFile = userDetailsFromFile[FileConstants.USER_FILE_NAME_POSITION];

                //Found current user on the list
                if (Program.currentUser.currentName == usernameFromFile)
                {
                    if (checkIfUserHasAPreviousTotal(userDetailsFromFile))
                    {
                        int oldScore = Convert.ToInt32(userDetailsFromFile[FileConstants.USER_FILE_TOTAL_SCORE]);
                        updateIfBetterScore(oldScore, i);
                    }
                    else
                    {
                        string userString = createUserString();
                        userList[i] = userString;
                    }
                }
            }
        }

        private Boolean checkIfUserHasAPreviousTotal(List<string> userDetails)
        {
            if (userDetails.Count > 3)
            {
                return true;
            }
            return false;
        }

        private void updateIfBetterScore(int oldScore, int listPosition)
        {
            int newScore = Program.currentUser.totalScore;
            
            if (newScore > oldScore)
            {
                string userString = createUserString();
                userList[listPosition] = userString;
            }
        }

        private void sortUserScores()
        {

            userList.Sort(new myTotalScoreComparer());
        }
    }

    public class myTotalScoreComparer : IComparer<string>
    {
        public int Compare(string left, string right)
        {

            try
            {
                //Splits the users by the tildas
                List<string> leftUser = left.Split(FileConstants.USER_FILE_SEPARATOR).ToList();
                List<string> rightUser = right.Split(FileConstants.USER_FILE_SEPARATOR).ToList();

                //Finds the total score for both users - string
                string leftUserScoreString = leftUser[FileConstants.USER_FILE_TOTAL_SCORE];
                string rightUserScoreString = rightUser[FileConstants.USER_FILE_TOTAL_SCORE];

                //Convert the string totals to ints
                int leftUserScore = Convert.ToInt32(leftUserScoreString);
                int rightUserScore = Convert.ToInt32(rightUserScoreString);

                //sort by total score
                return leftUserScore.CompareTo(rightUserScore);
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

    }
}
