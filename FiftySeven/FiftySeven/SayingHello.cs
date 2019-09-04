using System;

namespace FiftySeven
{
    public class SayingHello
    {

        public SayingHello()
        {
        }

        public void hello()
        {
            string name = "";

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine(message("Hello", name));
            Console.ReadLine();

        }

        public string message(string greeting, string name)
        {
            if(greeting == null && name == null)
            {
                return "";
            }

            if(name == null || name == "")
            {
                return greeting;
            }

            if(greeting == null || greeting == "")
            {
                return name;
            }

            return greeting + " " + name;
        }
    }
}
