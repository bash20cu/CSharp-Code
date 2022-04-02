using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class DisemvowelTrolls
    {
        public static string Disemvowel(string str)
        {
            Console.WriteLine(str);


            char[] openSymbol = { 'a', 'e', 'i','o','u' };

            for (int i = 0; i < openSymbol.Length; i++)
            {
                string vowel = openSymbol[i].ToString();
                str = str.Replace(vowel, vowel.ToUpper());
                str = str.Replace(vowel.ToUpper(), "");
            }

            Console.WriteLine(str);

            return str;
        }
    }
    
}
