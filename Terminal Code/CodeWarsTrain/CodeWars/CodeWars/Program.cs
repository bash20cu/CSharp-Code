using System;

namespace CodeWars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DisemvowelTrolls.Disemvowel("Miguel Alejandro Fernandez Arteaga");
            //int[] arr = { 2, 4, 0, 100, 4, 11, 2602, 36 };
            //int[] arr2 = { 160, 3, 1719, 19, 11, 13, -21 };
            //Console.WriteLine(int_find_it.find_it(arr));


            //string[] friends = { "Ryan", "Kieran", "Mark" };             
            //FriendOrFoeChallanges.FriendOrFoe(friends);

            //int[] a = { 1, 2, 2, 2, 3,5,5,6,6,6,6,7,8,12,30 }, b = { 2,5,6,12 };
            //ArrayDiffChallanges.ArrayDiff(a, b);

            //var list = new List<object>() { 1, 2, "a", "b" };
            //ListFiltererChallange.GetIntegersFromList(list);

            //string str = "Indivisibilities";
            //DuplicateCountChallanges.DuplicateCount(str);

            //IEnumerable<int> list = new List<int>() { -2, 2, 2, 2 };
            //GetUniqueChallange.GetUnique(list);

            //Console.WriteLine(IsPrimeChallange.IsPrime(2000000000));

            //int[] vs = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //Console.WriteLine(MaxSequenceChallange.MaxSequence(vs));

            var a = new List<int>() { 5, 6, 7 };
            var b = new List<int>() { 3, 6, 10 };
            compareTripletsChallange.compareTriplets(a, b);

        }
    }
}