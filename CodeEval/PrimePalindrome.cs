using System;
using System.Text;

namespace CodingChallenges.CodeEval
{
    class PrimePalindrome
    {
        enum ExitCode : int
        {
            Success = 0,
            InvalidFilename = 2
        }

        //static void Main(string[] args)
        //{
        //    PrimePalindrome pp = new PrimePalindrome();
        //    pp.StartApplication();
        //}

        public int StartApplication()
        {
            for (int i = 1000; i > 0; i--)
            {
                string ip = i.ToString();
                string op = Reverse(ip);

                if (ip.Equals(op))
                {
                    if (CheckPrime(i))
                    {
                        Console.Write(ip);
                        return (int)ExitCode.Success;
                    }
                }
            }
            return (int)ExitCode.Success;
        }

        private string Reverse(string ip)
        {
            StringBuilder op = new StringBuilder();

            for (int i = ip.Length; i > 0; i--)
            {
                op.Append(ip[i - 1]);
            }

            return op.ToString();
        }

        private bool CheckPrime(int ip)
        {
            if (ip == 1) return false;
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