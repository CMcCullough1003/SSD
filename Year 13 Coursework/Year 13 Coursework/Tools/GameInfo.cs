﻿using System;
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
                case 1: response = "Country Outline Quiz"; break;
                case 2: response = "Guess the Country"; break;
                case 3: response = "Uncover the Flag"; break;
                case 4: response = "The Gruesome Hangman"; break;
                case 5: response = "The Four Seas Quiz"; break;
                case 6: response = "The Falling Statements"; break;
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
                case 1: response = "An outline of a country will be shown on the next screen.\n\nYou must choose between four options the country name which matches the \noutline.\n\nA point is allocated for each correct answer."; break;
                case 2: response = "You have to guess the country.\n\nThere will be clues but the more clues you use the less points you win."; break;
                case 3: response = "Reveal the flag and guess the country.\n\nClick on the squares to reveal the flag below. Guess the country from the flag."; break;
                case 4: response = "Gruesome and horrible. Can you save our globetrotting friend?\n\n"; break;
                case 5: response = "Stop our little yacht from sinking.\n\nFour of the seas are real, the rest are made up.\n\n Select the real ones and keep the yacht afloat."; break;
                case 6: response = "Click the true facts.\n\nDont let the lies reach the mountains!"; break;
            }
            return response;
        }

        public string gamePoints() {
            string response = "";
            switch (Program.currentGame)
            {
                case 1: response = "Six globetrotter points"; break;
                case 2: response = "Three globetrotter points"; break;
                case 3: response = "Nine globetrotter points"; break;
                case 4: response = "Six globetrotter points"; break;
                case 5: response = "Four globetrotter points"; break;
                case 6: response = "Sixteen globetrotter points"; break;
            }
            return response;
        }
    }
}
