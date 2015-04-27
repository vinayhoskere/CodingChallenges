using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.SortingSearching
{
    class BinarySearch
    {
        public bool BinarySearchAlgo(int[] arr, int key)
        {
            return BSearchRecursive(arr, 0, arr.Length - 1, key);
        }

        private bool BSearchRecursive(int[] arr, int start, int end, int key)
        {
            int mid = (start + end)/2;
            if (arr[mid] == key)
                return true;
            if(arr[mid] < key)
            {
                return BSearchRecursive(arr, start, mid - 1, key);
            }

            return BSearchRecursive(arr, mid + 1, end, key);
        }

        private int BSearc(int[] arr, int n, int key)
        {
            int start = 0, end = n - 1;
            int mid = -1;
            while (start<=end)
            {
                mid = (start + end)/2;
                if (key == mid)
                    return mid;
                if (key < mid)
                    end = mid - 1;
                else
                   start = mid + 1;
                
            }
            return mid;
        }
    }
}
