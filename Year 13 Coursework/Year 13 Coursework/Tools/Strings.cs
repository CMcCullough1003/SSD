using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year_13_Coursework.Tools
{
    public class Strings
    {
        public Boolean wasCorrectAnswerEntered(string guess, string correctAnswer)
        {
            return guess.ToUpper() == correctAnswer.ToUpper();
        }
    }
}
