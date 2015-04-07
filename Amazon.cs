using System;

namespace CodingChallenges
{
    /// <summary>
    /// Amazon coding challenge taken on March 22 2015. I was asked 2 questions
    /// 1. Find the odd occurrence in the array? For example [2, 2, 1, 4, 3, 4, 3, 1, 1] should return value as 1 as the rest have even number of occurences. 
    /// 2. Find the longest count of subsequences a given arrary. For example [3, 5, 2, 4, 6, 1, 8] should return 3 as [2, 4, 6] are the sequences which have sequential increase in size
    /// </summary>
    class Solution
    {
        //static void Main(string[] args)
        //{
        //    //string input = Console.ReadLine();
        //    //int[] a = {};
        //    //For question 1
        //    int[] a = { 1,1,2,2,3,4,3,4,1};
        //    //int[] a = { 2,3,2,4,3 };
        //    int usingXOR = GetOddOccurrence(a, a.Length);
        //    int oddOccurrence = GetOddOccurrence(a);
           
        //    Console.WriteLine(oddOccurrence);

        //    //For question 2
        //    int[] b = {3, 5, 2, 4, 6, 1, 8};
        //    int longest = GetLongestSubSequenceCount(b);
        //    Console.WriteLine(longest);
        //}

        //We can use XOR implementation to make it faster and simpler, but that was one of the conditions from Amazon to not use it
        private static int GetOddOccurrence(int[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }

            int count = 0;
            Array.Sort(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                count++;
                if (array[i] != array[i + 1])
                {
                    if (count%2 != 0)
                    {
                        return array[i];
                    }
                }
            }

            return array[array.Length - 1];
        }

        private static int GetOddOccurrence(int[] arr, int size)
        {
            int xor2 = arr[0]; /* Will hold XOR of two odd occurring elements */
            int set_bit_no; /* Will have only single set bit of xor2 */
            int i;
            int n = size - 2;
            int x = 0, y = 0;

            //Get the xor of all elements in arr[]. The xor will basically be xor of two odd occurring elements */
            for (i = 1; i < size; i++)
            {
                xor2 = xor2 ^ arr[i];
            }
            //This would return the odd number. But if there are 2 then it will not, and if there are none, then it will return 0
            return xor2;

            /* Get one set bit in the xor2. We get rightmost set bit
     in the following line as it is easy to get */
            set_bit_no = xor2 & ~(xor2 - 1);

            /* Now divide elements in two sets: 
    1) The elements having the corresponding bit as 1. 
    2) The elements having the corresponding bit as 0.  */
            for (i = 0; i < size; i++)
            {
                /* XOR of first set is finally going to hold one odd 
       occurring number x */
                //     if (arr[i] & set_bit_no)
                //         x = x ^ arr[i];

                //         /* XOR of second set is finally going to hold the other 
                //odd occurring number y */
                //     else
                //         y = y ^ arr[i];
            }
            return x;
        }

        public static int GetLongestSubSequenceCount(int[] arr)
        {
            if (arr.Length == 1)
            {
                return 1;
            }
            int localCount = 1;
            int globalCount = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    localCount++;
                }
                else
                {
                    localCount = 1;
                }
                if (localCount > globalCount)
                {
                    globalCount = localCount;
                }
            }
            return globalCount;
        }
    }
}
