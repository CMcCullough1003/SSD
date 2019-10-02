using System;

namespace Arrays_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays arrays = new Arrays();
            arrays.CreateArrays();
            arrays.PrintArrays();

            int[] array = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 210 };
            int intToFind = 24;


            Searches searches = new Searches();
            int position = searches.LinearSearch(array, intToFind);
            if (position == Searches.NOT_FOUND)
            {
                Console.WriteLine("The value {0} was not found", intToFind);
            }
            else
            {
                Console.WriteLine("{0} found at position {1}", intToFind, position);
            }
        }
    }
}
