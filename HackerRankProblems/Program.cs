using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            //1. TimeConversion
            //string result1 = Result.TimeConversion(s);
            //Console.WriteLine("24 Hour Format:");
            //Console.WriteLine(result1);

            //2. VeryBigSum
            //List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
            //long result2 = Result.VeryBigSum(ar);
            //Console.WriteLine(result2);

            //3. BigSorting
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<string> unsorted = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string unsortedItem = Console.ReadLine();
                unsorted.Add(unsortedItem);
            }
            List<string> result3 = Result.BigSorting(unsorted);
            Console.WriteLine(String.Join("\n", result3));

            Console.ReadLine();
        }
    }

    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string TimeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }

        /*
          * Complete the 'aVeryBigSum' function below.
          *
          * The function is expected to return a LONG_INTEGER.
          * The function accepts LONG_INTEGER_ARRAY ar as parameter.
          */

        public static long VeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }
            return sum;
        }

        internal static List<string> BigSorting(List<string> unsorted)
        {
            var result = unsorted.OrderBy(x => x.Length).ThenBy(s => s).ToList();
            return result;
        }
    }

}
