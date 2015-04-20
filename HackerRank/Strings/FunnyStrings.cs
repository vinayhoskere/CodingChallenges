using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.HackerRank.Strings
{
    /// <summary>
    /// Check if strings are equal in terms of difference
    /// Example string acxz is Funny as |c-a| = |x-z| = 2 
    ///                                 |x-c| = |c-x| = 21 
    ///                                 |z-x| = |a-c| = 2
    /// and bcxz is Not Funny as |c-b| != |x-z|
    /// </summary>
    class FunnyStrings
    {
        //static void Main(String[] args)
        //{
        //    int cases = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < cases; i++)
        //    {
        //        Console.WriteLine(IsFunny(Console.ReadLine()) ? "Funny" : "Not Funny");
        //    }
        //}

        static bool IsFunny(string str)
        {
            if (str.Length == 0 || str.Length == 1)
                return true;
            int length = str.Length - 1;
            int i = 1;

            while (i <= length)
            {
                int first = Math.Abs((int)str[i] - str[i - 1]);
                int end = Math.Abs((int)str[length] - str[length - 1]);

                if (first != end)
                    return false;
                else
                {
                    length--;
                    i++;
                }
            }
            return true;
        }
    }
}
