using System;

namespace CodingChallenges.CrackingTheCodingInterview
{
    /// <summary>
    /// Determine if a string has all unique characters without using any additional datastructures 
    /// </summary>
    public class UniqueCharacters_Chap1_1
    {
        //static void Main(string[] args)
        //{
        //    UniqueCharacters_Chap1_1 uc = new UniqueCharacters_Chap1_1();
        //    string unique = "lkjsdkjgwes";
        //    bool c = uc.StartApplication(unique);

        //    Console.WriteLine(c);

        //}

        /// <summary>
        /// Ask if the string is a ASCII or UniCode string. The only difference will be the length of the string.
        /// If it is an ASCII then the length cannot exceed 128 as there are only so many alphabets
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private bool StartApplication(string args)
        {
            if(String.IsNullOrEmpty(args))
            {
                return true;
            }
            if(args.Length > 128)
            {
                return false;
            }
            Boolean[] value = new Boolean[256];

            foreach (char c in args)
            {
                int i = (int)c;

                if (value[i])
                {
                    return false;
                }
                value[i] = true;
            }
            return true;
        }
    }
}
