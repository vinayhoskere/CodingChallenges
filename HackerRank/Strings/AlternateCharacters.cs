using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.HackerRank.Strings
{
    /// <summary>
    /// Given a string with A and B as characters, find the minimum number of required deletions to get an alternate sequence
    /// Example: ABABABAB = 0
    ///          AAABBB = 4
    /// </summary>
    class AlternateCharacters
    {
        //static void Main(String[] args)
        //{
        //    int cases = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < cases; i++)
        //    {
        //        Console.WriteLine(Deletions(Console.ReadLine()));
        //    }
        //}

        static int Deletions(string str)
        {
            char temp = str[0];
            int delCount = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == temp)
                {
                    delCount++;
                }
                temp = str[i];
            }

            return delCount;
        }
    }
}
