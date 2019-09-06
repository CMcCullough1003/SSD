using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practicals
{
    class WhatsTheError2
    {
        public static void whatsTheError2()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 50 && number <= 100)
            {
                Console.WriteLine("Number is more than or equal to 50 and less than or equal to 100");
            }
        }
    }
}
