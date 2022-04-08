using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class compareTripletsChallange
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            
            int[] score;
            score = new int[2];

            
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    a[i] = 1;
                    b[i] = 0;
                }
                if (a[i] < b[i])
                {
                    a[i] = 0;
                    b[i] = 1;
                }
                if (a[i] == b[i])
                {
                    a[i] = 0;
                    b[i] = 0;
                }
                Console.WriteLine($"{a[i]} {b[i]}");
            }
            for (int i = 0; i <= score.Length; i++)
            {
                if (a[i] > b[i])
                {
                    score[0] += 1;

                }
                if (a[i] < b[i])
                {
                    score[1] += 1;

                }
                Console.WriteLine($"{score[0]}, {score[1]}") ;
            }
            

            List<int> scoreList = new List<int>() {score[0], score[1]};
            //scoreList.AddRange(score);
            Console.WriteLine(scoreList);
            return scoreList;
        }

    }
}
