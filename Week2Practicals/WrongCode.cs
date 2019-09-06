using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practicals
{
    class WrongCode
    {
        public static void wrongCode()
        {
            Console.WriteLine("Enter a number between 1 and 2");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1: Console.WriteLine("The number is one"); break;
                case 2: Console.WriteLine("The number is two"); break;
                default: Console.WriteLine("The number is not one or two"); break;
            }
            
            Console.WriteLine("A, B or C");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (b)
            {
                case 1: Console.WriteLine("A"); break;
                case 2: Console.WriteLine("B"); break;
                default: Console.WriteLine("C"); break;
            }
        }
    }
}
