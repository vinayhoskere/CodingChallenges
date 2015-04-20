using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges.HackerRank.WarmUp
{
    internal class ACMICPCTeam
    {
        //static void Main(String[] args)
        //{
        //    string[] input = Console.ReadLine().Split(' ');
        //    int numOfPpl = Convert.ToInt32(input[0]);
        //    int numOfSubs = Convert.ToInt32(input[1]);

        //    int[,] pplToSub = new int[numOfPpl, numOfSubs];
        //    for (int i = 0; i < numOfPpl; i++)
        //    {
        //        string str = Console.ReadLine();
        //        for (int j = 0; j < numOfSubs; j++)
        //        {
        //            pplToSub[i, j] = (int)str[j] - 48;
        //        }
        //    }
        //    int maxTopics = 0, maxTeams = 0;

        //    for (int i = 0; i < numOfPpl - 1; i++)
        //    {
        //        for (int j = i + 1; j < numOfPpl; j++)
        //        {
        //            int topics = 0;
        //            for (int k = 0; k < numOfSubs; k++)
        //            {
        //                if (pplToSub[j, k] == 1 || pplToSub[i, k] == 1)
        //                {
        //                    topics++;
        //                }
        //            }
        //            if (maxTopics <= topics)
        //            {
        //                if (topics == maxTopics)
        //                    maxTeams++;
        //                else
        //                {
        //                    maxTopics = topics;
        //                    maxTeams = 1;
        //                }
        //            }
        //        }
        //    }

        //    Console.WriteLine(maxTopics);
        //    Console.WriteLine(maxTeams);
        //}
    }
}
