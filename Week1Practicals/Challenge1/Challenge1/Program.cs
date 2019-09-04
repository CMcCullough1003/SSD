using System;

namespace Challenge1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your surname?");
            string surname = Console.ReadLine();

            Console.WriteLine("What age are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your hourly rate?");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());

            Wages challengeOne = new Wages();

            double grossWeeklyWage = challengeOne.grossWeeklyWage(hourlyRate);

            Console.WriteLine(challengeOne.details(firstName,surname,age));
            Console.WriteLine(challengeOne.grossWeeklyWage(hourlyRate));
            Console.WriteLine(challengeOne.netWeeklyWage(grossWeeklyWage));
        }
    }
}
