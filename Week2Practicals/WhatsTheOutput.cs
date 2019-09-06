using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practicals
{
    class WhatsTheOutput
    {
        public static void whatsTheOutput()
        {
            int height = 13;

            if (height <= 12)
            {
                Console.WriteLine("Low bridges\nProceed with cation");
            }

            int sum = 21;

            if (sum != 20)
            {
                Console.WriteLine("You lose\nthe prize");
            }

            int number = 7;

            if (number > 20)
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("You lose\nthe prize");
            }
        }

    }
}
