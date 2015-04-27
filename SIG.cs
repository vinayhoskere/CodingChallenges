using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    class SIG
    {
        private static void Main(string[] args)
        {
           //int[] a = { 1, 2, 3, 4, 5 };
            int a = 12;
            int b = 56;
            Solution(a, b);
            Console.WriteLine("");
        }

        private static int Solution(int a, int b)
        {
            string aStr = a.ToString();
            string bStr = b.ToString();
            int aStrLength = aStr.Length;
            int bStrLength = bStr.Length;

            if (aStr.Length + bStr.Length > 10)
                return -1;
            int maxLength = (aStrLength > bStrLength) ? aStrLength : bStrLength;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {
                if (aStrLength < i)
                {
                    sb.Append(aStr[i]);
                }
                if (bStrLength < i)
                {
                    sb.Append(bStr[i]);
                }
            }
            long returnVal = Convert.ToInt64(sb.ToString());
            if (returnVal > 100000000)
                return -1;
            return Convert.ToInt32(returnVal);

        }
    }
}
