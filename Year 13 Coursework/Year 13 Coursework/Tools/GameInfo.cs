using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year_13_Coursework.Tools
{
    //Provides the information for the labels in the game info screen, menu screen and all the game screens
    public class GameInfo
    {
        public string gameName()
        {
            string response = "";
            switch (Program.currentGame)
            {
                case 1: response = "Game 1"; break;
                case 2: response = "Game 2"; break;
                case 3: response = "Game 3"; break;
                case 4: response = "Game 4"; break;
                case 5: response = "Game 5"; break;
                case 6: response = "Game 6"; break;
            }
            return response;
        }

        public string gameNumber()
        {
            string response = "";
            switch (Program.currentGame)
            {
                case 1: response = "Game 1"; break;
                case 2: response = "Game 2"; break;
                case 3: response = "Game 3"; break;
                case 4: response = "Game 4"; break;
                case 5: response = "Game 5"; break;
                case 6: response = "Game 6"; break;
            }
            return response;
        }

        public string gameDescription()
        {
            string response = "";
            switch (Program.currentGame)
            {
                case 1: response = "afhfrbdbckjfweabchjdbcajhevcmdbcjhba\n cmebjx smc jhe SXCDCDBHFBREVBJBhfvbkjdfbvkjrbe  bkr vkr fjhbjr hbrfvjh "; break;
                case 2: response = "b"; break;
                case 3: response = "c"; break;
                case 4: response = "d"; break;
                case 5: response = "e"; break;
                case 6: response = "f"; break;
            }
            return response;
        }
    }
}
