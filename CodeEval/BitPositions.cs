using System.IO;

namespace CodingChallenges.CodeEval
{
    public class BitPositions
    {
         enum ExitCode : int
        {
            Success = 0,
            InvalidFilename = 2
        }

        //static void Main(string[] args)
        //{
        //    BitPositions fb = new BitPositions();
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

            }
            return (int)ExitCode.Success;
        }
    }
}
