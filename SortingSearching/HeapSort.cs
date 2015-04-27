using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.SortingSearching
{
    class HeapSort
    {
        public int[] HeapSortAlgo(int[] arr, int lenght)
        {
            return arr;
        }

        /// <summary>
        /// Insert a new element into the array. The new item will be added at the end of the array.
        /// Now we will have to make sure we move the item to satisfy the max heap.
        /// The parent node will always be greater than its child nodes. 
        /// </summary>
        /// <param name="arr"></param>
        private void SiftUp(int[] arr)
        {
            int k = arr.Length - 1;
            while (k > 0)
            {
                //Get the parent of the heap tree. Parent can be found using the formula 
                //(k-1)/2. 
                //Similarly children can be found using the formula
                //2k+1 and 2k+2
                int parent = (k - 1)/2;
                if (arr[parent] < arr[k])
                {
                    Swap(arr, parent, k);
                    k = parent;
                }
                else
                {
                    break;
                } 
            }
        }
        /// <summary>
        /// When the root node is deleted or taken out, then we will have to readjust the heap struture to make
        /// sure the max heap remains intact. So we will first make the last element as the parent and then 
        /// build the heap 
        /// </summary>
        /// <param name="arr"></param>
        private void SiftDown(int[] arr)
        {
            int k = arr.Length - 1;
            arr[0] = arr[k];
        }

        private void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}
