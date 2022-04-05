using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Write a function that will return the count of distinct case-insensitive alphabetic characters and 
 * numeric digits that occur more than once in the input string.The input string can be assumed to contain
 * only alphabets(both uppercase and lowercase) and numeric digits.
 */


namespace CodeWars
{
    internal class DuplicateCountChallanges
    {
        public static int DuplicateCount(string str)
        {
         
            str = str.ToLower();
            char[] chars = str.ToCharArray();            
            int counter = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                
                int count = str.Split(chars[i]).Length - 1;

                if (count <= 1)
                {
                    count = 0;
                }else
                {
                    counter++;
                    string vowel = chars[i].ToString();
                    str = str.Replace(vowel, "");
                }

                
                //str.Remove(chars[i]);
                

                Console.WriteLine(str);                
                
                Console.WriteLine(count);
            }

            Console.WriteLine(" ");
            Console.WriteLine(counter);
            return counter;
        }
    }
}
