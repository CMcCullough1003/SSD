using System;
using System.Collections.Generic;
using System.Text;

namespace FiftySeven
{
    public class CountingCharacters
    {

        public CountingCharacters()
        {
        }

        public void counting()
        {
            string input = "";

            Console.WriteLine("What is the input string?");
            input = Console.ReadLine();

            int count = characterCount(input);

            Console.WriteLine(response(input, count));
            Console.ReadLine();
        }
        public int characterCount(string input)
        {
            if (input == null)
            {
                return 0;

            }
            return input.Length;
        }

        public string response(string input, int characterCount)
        {
            if(input == null)
            {
                return "ERROR";
            }
            return input + " has " + characterCount + " characters";
        }
    }
}
