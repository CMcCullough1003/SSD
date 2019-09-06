using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practicals
{
    class SwitchCase2
    {
        public static void switchCase2()
        {
            Console.WriteLine("Enter a number of a day of the week");
            int weekday = Convert.ToInt32(Console.ReadLine());

            switch (weekday)
            {
                case 1: Console.WriteLine("MONDAY"); break;
                case 2: Console.WriteLine("TUESDAY"); break;
                case 3: Console.WriteLine("WEDNESDAY"); break;
                case 4: Console.WriteLine("THURSDAY"); break;
                case 5: Console.WriteLine("FRIDAY"); break;
                case 6: Console.WriteLine("SATURDAY"); break;
                case 7: Console.WriteLine("SUNDAY"); break;
                default: Console.WriteLine("Error: Not a valid day"); break;
            }
            
        }
    }
}
