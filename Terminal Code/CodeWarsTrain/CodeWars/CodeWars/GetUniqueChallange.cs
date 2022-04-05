using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * There is an array with some numbers. 
 * All numbers are equal except for one. Try to find it!
 *  
 */


namespace CodeWars
{
    internal class GetUniqueChallange
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {

            //numbers = numbers.Distinct();
            int[] arr = numbers.ToArray();
            int result = 0, counter=0;

            for(int i = 0; i < arr.Length; i++)
            {
                                
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                                      
                    
                }
                if (counter == 1)
                {
                    result = arr[i];
                }
                counter = 0;
            }
            Console.WriteLine(result);

            return result;

            
        }
    }
}
