using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    /// <summary>
    /// break a string into diffferent parts and check in dictionary
    /// Example: string "thisisatest"
    /// Dictionary : {"this", "is", "a", "test"}  returns true
    ///              {"this", "is", "test"}  returns false
    ///              {"this", "is", "a", "test", "sdf"}  returns true
    ///              {"this", "is", "isa", "test"}  returns true
    ///              {"th", "isis", "a", "test"}  returns true
    /// </summary>
    internal class Facebook
    {
        private static void Main(string[] args)
        {
            string[] dict = {"this", "is", "a", "test"};
            string[] dict1 = {"this", "is", "test"};
            string[] dict2 = {"this", "is", "a", "test", "sdf"};
            string[] dict3 = {"this", "is", "isa", "test"};
            string[] dict4 = {"th", "isis", "a", "test"};

            string test = "thisisatest";
            Console.WriteLine("First: " + wordBreak(test, dict));
            Console.WriteLine("Second: " + wordBreak(test, dict1));
            Console.WriteLine("Third: " + wordBreak(test, dict2));
            Console.WriteLine("Fourth: " + wordBreak(test, dict3));
            Console.WriteLine("Fifth: " + wordBreak(test, dict4));

            Console.ReadKey();
        }

        private static bool DictionartContains(string word, string[] dictionaryString)
        {
            int size = dictionaryString.Length;
            ;
            for (int i = 0; i < size; i++)
                if (dictionaryString[i].CompareTo(word) == 0)
                    return true;
            return false;
        }


        private static bool wordBreak(string str, string[] dictionaryString)
        {
            int size = str.Length;

            // Base case
            if (size == 0)
                return true;

            // Try all prefixes of lengths from 1 to size
            for (int i = 1; i <= size; i++)
            {
                // The parameter for dictionaryContains is str.substr(0, i)
                // str.substr(0, i) which is prefix (of input string) of
                // length 'i'. We first check whether current prefix is in
                // dictionary. Then we recursively check for remaining string
                // str.substr(i, size-i) which is suffix of length size-i
                if (DictionartContains((str.Substring(0, i)), dictionaryString) &&
                                       wordBreak(str.Substring(i, size - i), dictionaryString))
                    return true;
            }

            // If we have tried all prefixes and none of them worked
            return false;
        }
    }
}

