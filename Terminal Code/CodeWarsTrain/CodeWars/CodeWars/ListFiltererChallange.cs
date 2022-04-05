using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodeWars
{
    internal class ListFiltererChallange
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> list = new List<int>();


            for (int i = 0; i < listOfItems.Count; i++)            {
                //Console.WriteLine(listOfItems[i]);
                
                //numbers = i.Where(e => e. == e.IsDigit(e))
                if(listOfItems[i].GetType() == typeof(int))
                {
                    Console.WriteLine(listOfItems[i]);
                    list.Add((int)listOfItems[i]);
                }
                
            }

        
            //foreach (Match match in Regex.Matches(listOfItems.ToString(),pattern)
            //{
            //    Console.WriteLine(match);
            //}

            return list;
        }
    }
}
