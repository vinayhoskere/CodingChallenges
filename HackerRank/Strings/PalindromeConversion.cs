using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodingChallenges.HackerRank.Strings
{
    internal class PalindromeConversion
    {
        //private static void Main(string[] args)
        //{
        //    // input is a single line which will contain the input string
        //    var input = Console.ReadLine();

        //    // 1<=length of string <= 10^5
        //    if (input == null || input.Length < 1 || input.Length > 100000)
        //    {
        //        Console.WriteLine("NO");
        //        return;
        //    }

        //    // each character of the string is a lowercase english alphabet
        //    if (!Regex.IsMatch(input, "^[a-z]*$"))
        //    {
        //        Console.WriteLine("NO");
        //        return;
        //    }

        //    // figure out how many times each character appears
        //    var charCount = new Dictionary<char, int>();
        //    foreach (var c in input)
        //    {
        //        if (!charCount.ContainsKey(c))
        //        {
        //            charCount[c] = 0;
        //        }
        //        charCount[c]++;
        //    }

        //    // palindrome exists if there is at most 1 character that appears an odd number of times
        //    if (charCount.Count(x => x.Value%2 == 1) > 1)
        //    {
        //        Console.WriteLine("NO");
        //    }
        //    else
        //    {
        //        Console.WriteLine("YES");
        //    }
        //}
    }
}
