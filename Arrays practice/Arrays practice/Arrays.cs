using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_practice
{
    class Arrays
    {

        private int[] array1 = new int[3];
        private int[] array2 = new int[] { 4, 8, 2 };
        private int[] array3 = { 4, 8, 2 };
        private int[,] multiArray1 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        public void CreateArrays()
        {
            array1[0] = 4;
            array1[1] = 8;
            array1[2] = 2;
        }

        public void PrintArrays()
        {
            Console.WriteLine("Object type: {0}", array1);
            Console.WriteLine("Single dimentional array total items: {0}", array1.Length);

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Array contents at {0}: {1}", i, array1[i]);
            }

            Console.WriteLine("Object type: {0}", multiArray1);
            Console.WriteLine("Multi dimentional array total items: {0}", multiArray1.Length);
            Console.WriteLine("Number of items in first dimension: {0}", multiArray1.GetLength(0));
            Console.WriteLine("Number of items in second dimension: {0}", multiArray1.GetLength(1));
            for (int i = 0; i < multiArray1.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray1.GetLength(1); j++)
                {
                    Console.WriteLine("Array contents at [{0},{1}]: {2}", i, j, multiArray1[i,j]);
                }
            }

            
        }
    }
}
