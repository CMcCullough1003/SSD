using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practicals
{
    class Program
    {
        static void Main(string[] args)
        {
            WordNumber wordNumber = new WordNumber();
            wordNumber.readNumber();

            HeatingTime heatingTime = new HeatingTime();
            heatingTime.askHeatingTime();
        }
    }
}
