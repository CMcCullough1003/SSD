using System;
using System.Collections.Generic;
using System.Text;

namespace FiftySeven
{
    public class PrintingQuotes
    {

        public PrintingQuotes()
        {
        }

        public void printing()
        {
            Console.WriteLine("What is the quote?");
            string quote = Console.ReadLine();

            Console.WriteLine("Who said it?");
            string author = Console.ReadLine();

            Console.WriteLine(whoSaidWhat(quote, author));
            Console.ReadLine();
        }

        public string whoSaidWhat(string quote, string author)
        {
            if(author == null || quote == null)
            {
                return "ERROR";
            }
            if (author.Trim() == "" || quote.Trim() == "")
            {
                return "ERROR";
            }
            return author + " said \"" + quote + "\"";
        }
    }
}
