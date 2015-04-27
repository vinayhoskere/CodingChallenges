using System;
using System.Linq;

namespace CodingChallenges.HackerRank.Strings
{
    /// <summary>
    ///  Given an array of numbers, program to arrange the numbers to form the largest number
    /// Example {54, 546, 548,60} should return 6054854654 
    /// </summary>
    class BiggestNumber
    {
        //private static void Main(string[] args)
        //{
        //    string[] arr = {"54", "546", "548","60"};
        //}

        void PrintLargest(string[] arr)
        {
            Array.Sort(arr, MyCompare);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }

        int MyCompare(string x, string y)
        {
            string xy = x + y;
            string yx = y + x;
            return xy.CompareTo(yx) > 0 ? 1 : 0;
        }
    }
}
