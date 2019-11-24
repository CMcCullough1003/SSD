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

        public void resetUser()
        {
            currentName = "";
            currentPassword = "";
            currentAvatar = "";
            resetUserScores();
        }

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
