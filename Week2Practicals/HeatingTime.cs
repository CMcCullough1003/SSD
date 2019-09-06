using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practicals
{
    class HeatingTime
    {
        public static void heatingTimes()
        {
            Console.WriteLine("How many item are you heating?");
            int numOfItems = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the recommend heating time for the items in minutes?");
            int heatingTime = Convert.ToInt32(Console.ReadLine());

            if (numOfItems == 1)
            {
                Console.WriteLine("We reccomend you heat for {0} minutes", heatingTime);
            }
            else if (numOfItems == 2)
            {
                Console.WriteLine("We reccomend you heat for {0} minutes", heatingTime * .5);
            }
            else if (numOfItems == 3)
            {
                Console.WriteLine("We reccomend you heat for {0} minutes", heatingTime * 2);
            }
            else
            {
                Console.WriteLine("Hetaing more than 3 items at once is not reccomended");
            }
        }
    }
}
