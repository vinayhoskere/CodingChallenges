using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeEvalChallenges
{
    /// <summary>
    /// The Utopian Tree goes through 2 cycles of growth every year. 
    /// The first growth cycle occurs during the spring, when it doubles in height. The second growth cycle occurs during the summer, when its height increases by 1 meter.
    /// </summary>
    internal class UtopianTree
    {
        //private static void Main(String[] args)
        //{
        //    int i = Convert.ToInt32(Console.ReadLine());
        //    int val = 1;
        //    for (int j = 0; j < i; j++)
        //    {
        //        int number = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine(UtopianTest(number, val));
        //    }

        //}

        private static int UtopianTest(int number, int val)
        {
            if (number == 0)
                return val;

            for (int i = 1; i <= number; i++)
            {
                if (i%2 == 0)
                    val = val + 1;
                else
                    val = val*2;
            }
            return val;
        }
    }
}
