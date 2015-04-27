using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    /// <summary>
    ///  Is a number prime number
    /// </summary>
    class PrimeNumber
    {
        //private static void Main(string[] args)
        //{
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    IsPrimeNumber(number);
        //}

        private static void IsPrimeNumber(int number)
        {
            bool isPrime = true;

            if(number < 2)
                return;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number%i == 0)
                    isPrime = false;
            }

            if (isPrime)
            {
                Console.WriteLine("Number " + number + "is Prime");
            }
            else
            {
                Console.WriteLine("Number " + number + "is not Prime");
            }
        }
    }
}
