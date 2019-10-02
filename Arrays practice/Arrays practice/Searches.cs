using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_practice
{
    class Searches
    {
        public const int NOT_FOUND = -1; 

        int[] array = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 210 };

        public int LinearSearch( int[] arrayOfInts,  int intToFind)
        {
            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                if (arrayOfInts[i] == intToFind)
                {
                    return i;
                }
            }
            return NOT_FOUND;
        }

    }
}
