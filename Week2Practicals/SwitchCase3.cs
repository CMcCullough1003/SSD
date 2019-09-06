using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practicals
{
    class SwitchCase3
    {
        public static void switchCase3()
        {
            Console.WriteLine("Enter a number between 1 and 7");
            int area = Convert.ToInt32(Console.ReadLine());

            switch (area)
            {
                case 1: Console.WriteLine("South Belfast, BT7"); break;
                case 2: Console.WriteLine("Armagh, BT60"); break;
                case 3: Console.WriteLine("Ballymena, BT43"); break;
                case 4: Console.WriteLine("Omagh, BT78"); break;
                case 5: Console.WriteLine("Craigavon, BT62"); break;
                case 6: Console.WriteLine("Bangor, BT19"); break;
                case 7: Console.WriteLine("Carrickfergus, BT38"); break;
            }
        }
    }
}
