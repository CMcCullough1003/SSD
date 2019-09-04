using System;
using System.Collections.Generic;
using System.Text;

namespace FiftySeven
{
    class Launch
    {
        static void Main(string[] args)
        {

            var sayingHello = new SayingHello();
            sayingHello.hello();

            var countingCharacters = new CountingCharacters();
            countingCharacters.counting();

            var printingQuotes = new PrintingQuotes();
            printingQuotes.printing();

            var madLib = new MadLib();
            madLib.libbing();

            var simpleMath = new SimpleMath();
            simpleMath.maths();

            var retirementCalculator = new RetirementCalculator();
            retirementCalculator.retirement();
        }

    }
}
