using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year_13_Coursework.Tools
{
    public class Strings
    {
        //Makes it so that the user can get the correct answer even with incorrect capitalisation
        public Boolean wasCorrectAnswerEntered(string guess, string correctAnswer)
        {
            return guess.ToUpper() == correctAnswer.ToUpper();
        }
    }
}
