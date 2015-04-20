using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.HackerRank.Strings
{
    /// <summary>
    /// Check if a string has all the characters from a-z used in its sentence
    /// </summary>
    internal class Pangram
    {
        //private static void Main(String[] args)
        //{
        //    string str = Console.ReadLine();
        //    if (IsPangram(str))
        //        Console.WriteLine("pangram");
        //    else
        //        Console.WriteLine("not pangram");
        //}

        private static bool IsPangram(string s)
        {
            int count = 0;
            Hashtable ht = new Hashtable();
            int j = 0;
            while (count < 26 && j < s.Length)
            {
                int val = (int) s[j];
                if (val >= 97)
                {
                    val = val - 32;
                }
                if ((val>= 65 && val<=90) && !ht.ContainsKey(val))
                {
                    count++;
                    ht.Add(val, s[j]);
                }
                j++;
            }

            if (count == 26)
                return true;
            return false;
        }
    }
}
