using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The maximum sum subarray problem consists in finding the maximum
 * sum of a contiguous subsequence in an array or list of integers:
 */

namespace CodeWars
{
    internal class MaxSequenceChallange
    {
        public static int MaxSequence(int[] arr)
        {
            
            foreach(var item in arr)
            {
                if(item <= 0)
                {
                    return 0;
                }
            }
            var sum = 0;
            var max = 0;
            foreach (var item in arr)
            {
                sum += item;
                
                max = Math.Max(sum, max);
                sum = Math.Max(sum, 0);
            }
            return max;
        }
    }
}
