using System;

namespace CodingChallenges.CodeEval
{
    class SumOfPrimes
    {
        enum ExitCode : int
        {
            Success = 0,
            InvalidFilename = 2
        }

        //static void Main(string[] args)
        //{
        //    SumOfPrimes fb = new SumOfPrimes();
        //    fb.StartApplication();
        //}

        private int StartApplication()
        {
            int sum = 0, j = 0;
            for (int i = 2; i < 999999999; i++)
            {
                if (CheckPrime(i))
                {
                    j++;
                    sum += i;
                    if (j == 1000)
                    {
                        Console.Write(sum);
                        return (int)ExitCode.Success;
                    }
                }
            }
            return (int)ExitCode.Success;
        }

        private bool CheckPrime(int ip)
        {
            if (ip == 2) return true;

            var val = Math.Floor(Math.Sqrt(ip));

            for (int i = 2; i <= val; ++i)
            {
                if (ip % i == 0)
                    return false;
            }
            return true;
        }
    }
}
