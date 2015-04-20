using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.HackerRank.WarmUp
{
    /// <summary>
    /// Little Bob loves chocolate, and he goes to a store with $N in his pocket. 
    /// The price of each chocolate is $C. The store offers a discount: for every M wrappers he gives to the store, he gets one chocolate for free. How many chocolates does Bob get to eat?
    /// For every n items we get a free item so calculate the total amount
    /// </summary>
    class ChocolateFeast
    {
        //static void Main(String[] args)
        //{
        //    int m;
        //    m = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < m; i++)
        //    {
        //        string[] values = Console.ReadLine().Split(' ');
        //        int count = int.Parse(values[0]);
        //        int price = int.Parse(values[1]);
        //        int wrapper = int.Parse(values[2]);

        //        Console.WriteLine(TotalCount(count, price, wrapper));
        //    }
        //}

        static int TotalCount(int count, int price, int wrapper)
        {
            int total = count / price;
           
            total = total + NumberOfChocolates(total, wrapper);
           
            return total;
        }

        static int NumberOfChocolates(int total, int wrapper)
        {
            int count = 0;
            if (total > wrapper)
            {
                int extra = total%wrapper;
                count = count + (total/wrapper) + NumberOfChocolates((total/wrapper) + extra, wrapper);
            }
            else
            {
                count = count + (total/wrapper);
            }

            return count;
        }
    }
}
