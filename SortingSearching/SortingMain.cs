using System;
using System.Diagnostics;

namespace CodingChallenges.SortingSearching
{
    class SortingMain
    {
        //private static void Main(string[] args)
        //{
        //    int[] arr = { 3, 2, 7, 1, 6, 5, 10, 12 };
        //    int[] sortedArr = { 2, 6, 13, 21, 36, 47, 63, 81, 97 };
        //    //Random nRandom = new Random();
        //    //int[] arr = new int[100000];
        //    //for (int i = 0; i < 100000; i++)
        //    //{
        //    //    arr[i] = nRandom.Next(0, 200000);
        //    //}

        //    Stopwatch st = new Stopwatch();
        //    TimeSpan ts = new TimeSpan();

        //    //st.Start();
        //    //InsertionSort insSort = new InsertionSort();
        //    //int[] insertionSort = insSort.InsertionSortAlgo(insArr, insArr.Length);
        //    //st.Stop();
        //    //ts = st.Elapsed;
        //    //PrintArray("Insertion Sort", insertionSort, ts.Seconds.ToString());
        //    //st.Reset();

        //    //st.Start();
        //    //MergeSort mrgSort = new  MergeSort();
        //    //int[] mergeSort = mrgSort.MergeSortAlgo(arr, arr.Length);
        //    //st.Stop();
        //    //ts = st.Elapsed;
        //    //PrintArray("Merge Sort", mergeSort, ts.Seconds.ToString());
        //    //st.Reset();

        //    //st.Start();
        //    //QuickSort qikSort = new QuickSort();
        //    //int[] quickSort = qikSort.QuickSortAlgo(arr, arr.Length);
        //    //st.Stop();
        //    //ts = st.Elapsed;
        //    //PrintArray("Quick Sort", quickSort, ts.Seconds.ToString());
        //    //st.Reset();

        //    st.Start();
        //    HeapSort heapSort = new HeapSort();
        //    int[] hpSort = heapSort.HeapSortAlgo(arr, arr.Length);
        //    st.Stop();
        //    ts = st.Elapsed;
        //    PrintArray("Heap Sort", hpSort, ts.Seconds.ToString());
        //    st.Reset();
        //    Console.ReadKey();
        //}

        private static void PrintArray(string algoName, int[] arr, string timeTaken)
        {
            Console.WriteLine(string.Format("{0} : {1}", algoName, string.Join(", ", arr)));
            Console.WriteLine(string.Format("Time Taken by {0} : {1} seconds", algoName, timeTaken));
        }
    }
}
