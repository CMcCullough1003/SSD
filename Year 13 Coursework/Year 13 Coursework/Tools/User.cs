using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year_13_Coursework.Tools
{
    class User
    {
        public string currentName = "";
        public string currentPassword = "";
        public string currentAvatar = "";
        public int game1Score = 0;
        public int game2Score = 0;
        public int game3Score = 0;
        public int game4Score = 0;
        public int game5Score = 0;
        public int game6Score = 0;
        public int totalScore = 0;
        public string grade = "";

        public string convertUserToString()
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

        //For when the user is changed
        public void resetUser()
        {
            currentName = "";
            currentPassword = "";
            currentAvatar = "";
            resetUserScores();
        }

        //For when the user replays the game
        public void resetUserScores()
        {
            game1Score = 0;
            game2Score = 0;
            game3Score = 0;
            game4Score = 0;
            game5Score = 0;
            game6Score = 0;
            totalScore = 0;
    }

        public void calculateTotalScore()
        {
            totalScore = game1Score +
                         game2Score +
                         game3Score +
                         game4Score +
                         game5Score +
                         game6Score;
        }
    }
}
