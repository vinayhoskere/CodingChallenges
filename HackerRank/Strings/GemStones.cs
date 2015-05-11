using System;
using System.Collections.Generic;
using System.IO;

namespace CodingChallenges.HackerRank.Strings
{
    internal class GemStones
    {
        //private static void Main(String[] args)
        //{
        //    int cases = Convert.ToInt32(Console.ReadLine());
        //    Dictionary<char, int> dict = new Dictionary<char, int>();
        //    int finalCount = 0;
        //    for (int i = 0; i < cases; i++)
        //    {
        //        string str = Console.ReadLine();
        //        finalCount = CommonCharacters(str, dict, i);
        //    }

        //    Console.WriteLine(finalCount);
        //}

        private static int CommonCharacters(string str, Dictionary<char, int> dict, int count)
        {
            int finalCount = 0;
            bool[] charBools = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {
                if (charBools[str[i]] == false)
                {
                    charBools[str[i]] = true;

                    if (dict.ContainsKey(str[i]))
                    {
                        int val = dict[str[i]];
                        if (val < count + 1)
                        {
                            val = val + 1;
                            dict[str[i]] = val;

                            if (val == count + 1)
                                finalCount++;
                        }
                    }
                    else
                        dict[str[i]] = 1;
                }
            }

            return finalCount;
        }
    }
}
