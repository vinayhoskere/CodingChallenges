using System;
using System.IO;

namespace CodingChallenges.CodeEval
{
    class FizzBuzz
    {
        enum ExitCode : int
        {
            Success = 0,
            InvalidFilename = 2
        }

        //static void Main(string[] args)
        //{
        //    FizzBuzz fb = new FizzBuzz();
        //    fb.StartApplication(args);
        //}

        public int StartApplication(string[] args)
        {
            string inputPath = string.Empty;

            inputPath = args[0];

            if (inputPath == string.Empty || !File.Exists(inputPath))
            {
                return (int)ExitCode.InvalidFilename;
            }

            StreamReader sr = new StreamReader(inputPath);

            string line = sr.ReadLine();
            while (line != null)
            {
                string[] values = line.Split(' ');

                string output = ProcessFizzBuzz(Convert.ToInt32(values[0]), Convert.ToInt32(values[1]), Convert.ToInt32(values[2]));

                line = sr.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(output);
                }
                else
                {
                    Console.Write(output);
                }
            }

            return (int)ExitCode.Success;
        }

        private static string ProcessFizzBuzz(int first, int second, int end)
        {
            string outputString = string.Empty;

            for (int i = 1; i <= end; i++)
            {
                bool firstNumber, secondNumber;

                firstNumber = NumberDivisble(i, first);
                secondNumber = NumberDivisble(i, second);

                if (firstNumber && secondNumber)
                    outputString = outputString + "FB ";
                else if (firstNumber)
                    outputString = outputString + "F ";
                else if (secondNumber)
                    outputString = outputString + "B ";
                else
                    outputString = outputString + i.ToString() + " ";
            }

            return outputString.TrimEnd();
        }

        private static bool NumberDivisble(int numerator, int divisor)
        {
            if (numerator % divisor == 0)
                return true;

            return false;
        }
    }
}
