using System;
using System.Collections.Generic;
using System.Text;

namespace FiftySeven
{
    class RetirementCalculator
    {
        public RetirementCalculator()
        {
        }

        public void retirement()
        {
            Console.WriteLine("What is your current age?");
            int currentAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the age you wish to retire at?");
            int retirementAge = Convert.ToInt32(Console.ReadLine());

            int until = yearsUntilRetirement(currentAge, retirementAge);
            int year = currentYear();
            int retirementYear = yearOfRetirement(currentYear(), until);

            Console.WriteLine(calculation(year,until,retirementYear));
            Console.ReadLine();
        }

        public int currentYear()
        {
            return DateTime.Now.Year;
        }

        public int yearsUntilRetirement (int currentAge, int retirementAge)
        {
            return retirementAge - currentAge;
        }

        public int yearOfRetirement (int currentYear, int yearsUntilRetirement)
        {
            return currentYear + yearsUntilRetirement;
        }

        public string calculation (int currentYear, int yearsUntilRetirement, int yearOfRetirement)
        {
            return "You have " + yearsUntilRetirement + " years left until you can retire.\nIt's " + currentYear + " so you can retire in " + yearOfRetirement + ".";
        }
    }
}
