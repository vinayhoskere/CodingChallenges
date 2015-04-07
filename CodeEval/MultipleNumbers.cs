using System;
using System.IO;

namespace CodingChallenges.CodeEval
{
    class MultipleNumbers
    {
        enum ExitCode : int
        {
            Success = 0,
            InvalidFilename = 2
        }

        //static void Main(string[] args)
        //{
        //    MultipleNumbers fb = new MultipleNumbers();
        //    fb.StartApplication(args);
        //}

        private int StartApplication(string[] args)
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
                string[] input = line.Split(',');
                int output = SmallestNum(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));
                line = sr.ReadLine();
                if (line != null)
                    Console.WriteLine(output.ToString().Trim());
                else
                    Console.Write(output.ToString().Trim());
            }
            return (int)ExitCode.Success;
        }

        private int SmallestNum(int x, int n)
        {
            for (int i = 1; i < x; i++)
            {
                if ((n * i) > x)
                    return (n * i);
            }
            return 0;
        }
    }
}
