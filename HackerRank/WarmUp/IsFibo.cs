using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.HackerRank.WarmUp
{
    internal class IsFibo
    {
        //private static void Main(String[] args)
        //{
        //    int cases = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < cases; i++)
        //    {
        //        if (IsFibonacci((long) Convert.ToUInt64(Console.ReadLine())))
        //            Console.WriteLine("IsFibo");
        //        else
        //            Console.WriteLine("IsNotFibo");
        //    }
        //}

        private static bool IsFibonacci(long n)
        {
            if (n == 0 || n == 1)
                return true;
            long i = 1, j = 1;
            long sum = 1;
            while (sum < n)
            {
                sum = j + i;
                if (sum == n)
                    return true;
                j = i;
                i = sum;
            }
            return false;
        }
    }
}
    

