using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practicals
{
    class WhatsTheError
    {
        public static void whatsTheError()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 50)
            {
                Console.WriteLine("The number is 50");
            }
            else
            {
                Console.WriteLine("The number is not 50");
            }
        }
    }
}
