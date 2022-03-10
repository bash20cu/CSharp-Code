using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalApps
{
    internal class ForCycleFizzBuzz
    {
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                //bool fizz = false;
                //bool buzz = false;
                //if (i % 3 == 0) fizz = true;
                //if (i % 5 == 0) buzz = true;

                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine(i + " - Fizz-Buzz");
                else if (i % 3 == 0) Console.WriteLine(i + " - Fizz");
                else if (i % 5 == 0) Console.WriteLine(i + " - Buzz");
                else { Console.WriteLine(i); }
            }
        }
    }
}
