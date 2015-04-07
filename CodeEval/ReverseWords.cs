using System;
using System.IO;
using System.Text;

namespace CodingChallenges.CodeEval
{
    class ReverseWords
    {
        enum ExitCode : int
        {
            Success = 0,
            InvalidFilename = 2
        }

        //static void Main(string[] args)
        //{
        //    ReverseWords fb = new ReverseWords();
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
                if (line.Trim() != string.Empty)
                {
                    string output = RW(line);
                    line = sr.ReadLine();
                    if (line != null)
                        Console.WriteLine(output);
                    else
                        Console.Write(output);
                }
                else
                    line = sr.ReadLine();
            }
            return (int)ExitCode.Success;
        }

        private string RW(string input)
        {
            StringBuilder output = new StringBuilder();
            string[] values = input.Split(' ');

            for (int i = values.Length; i > 0; i--)
            {
                output.Append(values[i - 1].Trim() + " ");
            }
            return output.ToString().Trim();
        }

      //  unsafe
        //This is in C or C++ to reverse characters
        //private void Reverse(char *str)
        //{
        //    char* end = str;
        //    char tmp;
        //    if(str)
        //    {
        //        while (*end)
        //        {
        //            ++end;
        //        }
        //        --end;

        //        while(str<end)
        //        {
        //            tmp = *str;
        //            *str++ = *end;
        //            *end-- = tmp;
        //        }
        //    }
        //}
    }
}
