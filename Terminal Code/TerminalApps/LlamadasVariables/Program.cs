using System;
using MyNewApp.Utilities;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Miguel Alejandro";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");

            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            bool found = false;
            int total = 0;
            foreach (int number in numbers)
            {                
                total += number;
                if (number == 42)
                {
                    found = true;
                }
            }
            if (found)
            {
                Console.WriteLine("Set contains 42");
            }
            Console.WriteLine($"Total: {total}");

        }
        
    }    
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

