using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeEvalChallenges.CrackingTheCodingInterview
{
    /// <summary>
    /// Returned a compressed string with the number of consecutive occurences of the same character. 
    /// If the compressed string is longer than the original, then return the original string.
    /// </summary>
    class StringCompression_Chap1_5
    {
        //static void Main(string[] args)
        //{
        //    StringCompression_Chap1_5 uc = new StringCompression_Chap1_5();
        //    string str1 = "aabccccaaab";
        //    string str2 = "abcabb";
        //    //true length

        //    string arr = uc.StartApplication(str2);
        //    Console.WriteLine(arr);

        //    Console.ReadKey();
        //}

        /// <summary>
        /// This takes O(N) TIME and O(N) SPACE
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string StartApplication(string str)
        {
            if (str.Length == 0 || str.Length == 1)
            {
                return str;
            }
            //In order to satisfy the condition that originial string has to be returned if compressed string is greater than originial string, 
            //we can either have a CountCheck method right here and return or else if the found if condition, check the length and return the shortest string. 
            bool found = false;
            int count = 1;
            
            StringBuilder sb = new StringBuilder();
            char[] arr = str.ToCharArray();
            //Need this to add the last element 
            char last = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] ==  last)
                {
                    found = true;
                    count++;
                }
                else
                {
                    sb.Append(last.ToString() + count);
                    count = 1;
                    last = arr[i];
                }
            }

            sb.Append(last.ToString() + count);

            if (found && sb.Length < str.Length)
            {
                return sb.ToString();
            }

            return str;
        }
    }
}
