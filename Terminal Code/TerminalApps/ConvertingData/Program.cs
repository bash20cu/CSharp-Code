using System;
namespace ConvertingData
{
    class MyClass
    {
        public static void Main( string[] args)
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            decimal result = 0;
            string message = "";
            decimal total = 0;

            Console.WriteLine("Loop for converting data from a array: ");

            for (int i = 0; i < values.Length; ++i)
            {

                Console.WriteLine($"Array content in index : {i} : Value: {values[i]} ");

                if (decimal.TryParse(values[i], out result))
                {

                    total = total + result;
                }
                else
                {
                    message = message + values[i];
                }
            }
            
            Console.WriteLine($"Message string: {message}, Total integer: {total}");

            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            int result1 = value1 / (int)value2;
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 = value3 / (float)value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }
    }
}
