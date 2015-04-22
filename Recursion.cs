using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    internal class Recursion
    {
        private int FibonacciRecursive(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        //Make sure to initialize arry to -1
        private int[] fib;
        /// <summary>
        /// Fibonaccis the with memoized. This is O(n)
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        private int FibonacciWithMemoized(int n)
        {
            if (fib[n] != -1)
                return fib[n];
            fib[n] = FibonacciWithMemoized(n - 1) + FibonacciWithMemoized(n - 2);

            return fib[n];
        }

        private int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// Powers the specified n. This takes O(n)
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        private int Power(int n, int x)
        {
            if (n == 0)
                return 1;
            return x * Power(n - 1, x);
        }

        /// <summary>
        /// Powers the faster. This takes O(logn)
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        private int PowerFaster(int n, int x)
        {
            if (n == 0)
                return 1;
            else if (n % 2 == 0)
            {
                int y = PowerFaster(n / 2, x);
                return y * y;
            }
            return x * PowerFaster(n - 1, x);
        }

        /// <summary>
        /// Modulars the exponentiation. This takes O(logn)
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="n">The n.</param>
        /// <param name="m">The m.</param>
        /// <returns></returns>
        private int ModularExponentiation(int x, int n, int m)
        {
            if (n == 0)
                return 1;
            else if (n % 2 == 0)
            {
                int y = ModularExponentiation(x, n / 2, m);
                return (y * y) % m;
            }
            return (x % m) * ModularExponentiation(x, n - 1, m);
        }
    }
}

