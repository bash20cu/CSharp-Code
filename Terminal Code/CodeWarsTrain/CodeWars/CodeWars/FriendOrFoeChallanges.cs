using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class FriendOrFoeChallanges
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> list = new List<string>();
            
            for (int i = 0; i < names.Length; i++)
            {
                list.Add(names[i]);
            }

            for (int i = 0; i < names.Length; i++)
            {
                if(names[i].Length <= 4)
                {
                    Console.WriteLine($"{names[i]}");
                }
                else
                {
                    list.Remove(names[i]);
                }   
            }

            //for (int i=0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            return list;
        }
    }
}
