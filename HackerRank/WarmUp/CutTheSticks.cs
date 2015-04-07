using System;

namespace CodingChallenges.HackerRank.WarmUp
{
    internal class CutTheSticks
    {
        /// <summary>
        /// Not correct
        /// </summary>
        /// <param name="args"></param>
        //private static void Main(String[] args)
        //{
        //    int numcases = Convert.ToInt32(Console.ReadLine());
        //    string[] sticks = Console.ReadLine().Split(' ');
        //    CutTheStick(numcases, Array.ConvertAll(sticks, int.Parse));
        //}

        private static void CutTheStick(int numcases, int[] cases)
        {
            if (numcases != cases.Length)
                return;

            bool present = true;
            Array.Sort(cases);
            while (present)
            {
                int count = 0;
                present = false;
                int smallest = 0;
                for (int j = 0; j < cases.Length; j++)
                {
                    if (cases[j] > 0)
                    {
                        count++;
                        present = true;
                        cases[j] = cases[j] - smallest;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine(count);
                }
            }
        }
    }
}
