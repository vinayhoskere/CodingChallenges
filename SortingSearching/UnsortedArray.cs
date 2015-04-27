using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace CodingChallenges.SortingSearching
{
    /// <summary>
    /// Find a median in an unsorted array without sorting it
    /// The TIME COMPLEXITY is linear time O(n)
    /// </summary>
    class UnsortedArray
    {
        //private static void Main(string[] args)
        //{
        //    int[] arr = {6, 7, 8, 1, 2, 3, 4, 5, 9, 10};
        //    selection_algorithm(0, arr.Length-1, arr.Length/2, arr);
        //}

        static int Partition(int low, int high, int[] arr)
        {
            int pivot = arr[high];
            int index = low;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    Swap(arr, j, index);
                    index++;
                }
            }
            Swap(arr, index, high);
            return index;
        }

        static int selection_algorithm(int left, int right, int kth, int[] arr)
        {
            for (; ; )
            {
                int pivotIndex = Partition(left, right, arr);          //Select the Pivot Between Left and Right
                int len = pivotIndex - left + 1;

                if (kth == len)
                    return arr[pivotIndex];

                else if (kth < len)
                    right = pivotIndex - 1;

                else
                {
                    kth = kth - len;
                    left = pivotIndex + 1;
                }
            }
        }

        private static void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}
