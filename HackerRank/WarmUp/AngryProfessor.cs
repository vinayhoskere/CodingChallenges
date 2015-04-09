using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CodingChallenges.CodeEval;

namespace CodingChallenges.HackerRank.WarmUp
{
    /// <summary>
    /// Given the arrival time of each student, your task is to find out if the class gets cancelled or not.
    /// f the arrival time of a given student is a non-positive integer, then the student enters before the class starts. 
    /// If the arrival time of a given student is a positive integer (ai>0), the student enters after the class has started.
    /// If a student enters the class exactly when it starts, the student is considered to have entered before the class has started.
    /// </summary>
    internal class AngryProfessor
    {
        //private static void Main(String[] args)
        //{
        //    int cases = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < cases; i++)
        //    {
        //        string[] total = Console.ReadLine().Split(' ');
        //        ClassRun(Convert.ToInt32(total[0]), Convert.ToInt32(total[1]));
        //    }
        //}

        private static void ClassRun(int total, int required)
        {
            string[] student = Console.ReadLine().Split(' ');
            if (total != student.Length)
                return;
            int count = 0;
            for (int i = 0; i < total; i++)
            {
                if (Convert.ToInt32(student[i]) <= 0)
                {
                    count++;
                }
            }

            if (count >= required)
            {
                Console.WriteLine("NO");
            }
            else
                Console.WriteLine("YES");
        }
    }
}
