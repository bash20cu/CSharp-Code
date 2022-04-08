using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Define a function that takes one integer argument and returns
 * logical value true or false depending on if the integer is a prime
 */

namespace CodeWars
{
    internal class IsPrimeChallange
    {
        public static bool IsPrime(int n)
        {
            bool prime = false; 

            for(int i = 1; i < n; i++)
            {
                if(n % i == 0)
                {
                    prime = true;
                }
                else
                {
                    prime = false;

                }

            }
            return prime;

            
        }
    }
}
