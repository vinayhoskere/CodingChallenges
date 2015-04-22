using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.Sorting
{
    class MergeSort
    {
        /// <summary>
        /// Merges the sort algo.
        /// Time Complexity : O(nlogn) 
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public int[] MergeSortAlgo(int[] arr, int n)
        {
           return MergeSrt(arr);
        }

        private int[] MergeSrt(int[] array)
        {
            int length = array.Length;
            if (length < 2)
                return array;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }
            for (int j = mid; j < length; j++)
            {
                right[j-mid] = array[j];
            }
            MergeSrt(left);
            MergeSrt(right);
            Merge(left, right, array);
            return array;
        }


        private void Merge(int[] left, int[] right, int[] arr)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int i = 0, j = 0, k=0;
            while (i < leftLength && j < rightLength)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < leftLength)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
