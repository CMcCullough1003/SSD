using System;
using System.Collections.Generic;
using DataStore;

namespace JDDogCare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClassModel> list = new ClassTable().readAll();
            Console.WriteLine( "Class" + list[0].startTime);
        }
    }
}
