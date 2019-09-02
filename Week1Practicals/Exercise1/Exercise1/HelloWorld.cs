using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Names
    {
        public Names()
        {

        }

        public void PrintName()
        {
            string name = "";

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        }
 
    }
}
