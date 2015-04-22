using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.Sorting
{
    class InsertionSort
    {
        /// <summary>
        /// Insertions the sort algo.
        /// Time Complexity : O(n) for BEST CASE
        ///                   O(n^2) for WORST CASE
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public int[] InsertionSortAlgo(int[] arr, int n)
        {
            int val = 0;
            int j = 0;
            for (int i = 1; i < n; i++)
            {
                val = arr[i];
                j = i;
                while (j > 0 && arr[j - 1] > val)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = val;
            }
            return arr;
        }
    }
}
