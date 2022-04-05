using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class ArrayDiffChallanges
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            for(int i = 0; i < b.Length; i++)
            {
                a = a.Where(e => e !=b[i]).ToArray();
                Console.WriteLine(a[i]);
            }
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            return a;
        }
    }
}
