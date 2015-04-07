using System;

namespace CodingChallenges.HackerRank.WarmUp
{
    /// <summary>
    /// Convert a given string into a palindrome. See the number of passes it requires to convert it to Palindrome
    /// </summary>
    internal class ConvertToPalindrome
    {
        //private static void Main(String[] args)
        //{
        //    int i = Convert.ToInt32(Console.ReadLine());
        //    ConvertPalindrome(i);
        //}

        private static void ConvertPalindrome(int i)
        {
            while (i > 0)
            {
                string str = Console.ReadLine();
                int length = str.Length;
                int itr = 0;
                for (int j = 0; j < str.Length/2; j++)
                {
                    if (str[j] != str[length - 1])
                    {
                        itr = itr + Math.Abs((int) str[j] - (int) str[length - 1]);
                    }
                    length--;
                }
                i--;
                Console.WriteLine(itr);
            }
        }
    }
}
