namespace CodingChallenges.SortingSearching
{
    class QuickSort
    {
        /// <summary>
        /// Time Complexity : O(nlogn) average complexity
        ///                   O(n^2) worst case 
        /// In place algorithm 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] QuickSortAlgo(int[] arr, int n)
        {
            QuickSortRecursive(arr, 0, arr.Length-1);
            return arr;
        }

        private int[] QuickSortRecursive(int[] arr, int start, int end)
        {
            if (start >= end)
                return arr;

            int index = Partition(start, end, arr);

            QuickSortRecursive(arr, start, index - 1);
            QuickSortRecursive(arr, index + 1, end);
            return arr;
        }

        private int Partition(int start, int end, int[] arr)
        {
            //take a pivot as the end of the arry
            int pivot = arr[end];
            int index = start;

            for (int i = start; i < end; i++)
            {
                //if current element is less than pivot, then swap element i with the index
                //this moves the higher elements to the right and lesser elements to the left
                //For example: 7,2,1,6,8,5,3,4
                //Here the pivot will be 4 and the first element is 7, condition returns false. Moves to 2
                //2 is lesser than 4 (pivot), so we swap 2 with index (start-7) -2,7,1,6,8,5,3,4
                //1 is lesser than 4, so swap with index (incremented to 7) - 2,1,7,6,8,5,3,4
                //6 is greater than 4, so move ahead, note: index is still at 7
                if (arr[i] <= pivot)
                {
                    Swap(arr, i, index);
                    index++;
                }
            }
            Swap(arr, index, end);
            return index;
        }

        private void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}
