﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalApps
{
    internal class DotNetDebugging
    {
        public static void NetDebugging()
        {
            int result = Fibonacci(5);
            Console.WriteLine(result);

            static int Fibonacci(int n)
            {
                int n1 = 0;
                int n2 = 1;
                int sum;

                for (int i = 2; i < n; i++)
                {
                    sum = n1 + n2;
                    n1 = n2;
                    n2 = sum;
                }

                return n == 0 ? n1 : n2;
            }
        }
    }
}
