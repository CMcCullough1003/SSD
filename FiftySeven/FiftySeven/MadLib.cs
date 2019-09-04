using System;
using System.Collections.Generic;
using System.Text;

namespace FiftySeven
{
    public class MadLib
    {

        public MadLib()
        {
        }

        public void libbing()
        {
            Console.WriteLine("Enter a noun");
            string noun = Console.ReadLine();

            Console.WriteLine("Enter a verb");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter an adjective");
            string adjective = Console.ReadLine();

            Console.WriteLine("Enter an adverb");
            string adverb = Console.ReadLine();

            Console.WriteLine(funnyPhrase(noun, verb, adjective, adverb));
            Console.ReadLine();
        }

        public string funnyPhrase (string noun, string verb, string adjective, string adverb)
        {
            if(noun == null || verb == null || adverb == null || adjective == null)
            {
                return "ERROR";
            }

            if(noun.Trim() == "" || verb.Trim() == "" || adjective.Trim() == "" || adverb.Trim() == "")
            {
                return "ERROR";
            }

            return "Do you " + verb + " your " + adjective + " " + noun + " " + adverb + "? That's hillarious!";
        }
    }
}
