using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    class DijkstrasShortestPath
    {
        private static void Main(string[] args)
        {
            int[,] matrix = new int[5,5];
            int[] distance = new int[5];
            int[] visited = new int[5]; // to get the visited path from a node
            int[] preD = new int[5]; //to get the actual path
            int min = 0;
            int nextNode = 0;

            Console.WriteLine("Enter the matrix");

            for (int i = 0; i < 5; i++)
            {
                visited[i] = 0;
                preD[i] = 0;
                for (int j = 0; j < 5; j++)
                {
                    string s = Console.ReadLine();
                    matrix[i,j] = Convert.ToInt32(s);
                    if (matrix[i,j] == 0)
                        matrix[i,j] = 999;
                }
            }

            //distance = matrix[0, 0];
            distance[0] = 0;
            visited[0] = 1;

            for (int i = 0; i < 5; i++)
            {
                min = 999;
                for (int j = 0; j < 5; j++)
                {
                    if (min > distance[j] && visited[j] != 1)
                    {
                        min = distance[j];
                        nextNode = j;
                    }
                }
                visited[nextNode] = 1;

                for (int c = 0; c < 5; c++)
                {
                    if (visited[c] != 1)
                    {
                        if (min + matrix[nextNode, c] < distance[c])
                        {
                            distance[c] = min + matrix[nextNode, c];
                            preD[c] = nextNode;
                        }
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("|" + distance[i]);
            }
            Console.Write("|");

            //printing path
            for (int i = 0; i < 5; i++)
            {
                int j;
                Console.WriteLine("Path = " + i);
                j = i;
                do
                {
                    j = preD[j];
                    Console.WriteLine(" <- " + j);
                } while (j!=0);


            }
        }
    }
}
