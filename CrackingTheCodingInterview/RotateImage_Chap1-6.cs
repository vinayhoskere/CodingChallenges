using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeEvalChallenges.CrackingTheCodingInterview
{
    /// <summary>
    /// NxN matrix with each pixel in image is 4 bytes, rotate it by 90 degrees
    /// </summary>
    class RotateImage_Chap1_6
    {
        //static void Main(string[] args)
        //{
        //    RotateImage_Chap1_6 uc= new RotateImage_Chap1_6();
        //    string str1 = "aabccccaaab";
        //    string str2 = "abcabb";
        //    //true length

        //    string arr = uc.StartApplication(str2);
        //    Console.WriteLine(arr);

        //    Console.ReadKey();
        //}`

        /// <summary>
        /// O(N2) TIME as it has to touch all the elements
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="n"></param>
        private void StartApplication(int[][] matrix, int n)
        { 
            for(int l =0;l<n/2;++l)
            {
                int first = l;
                int last= n-1-l;
                for(int i=first; i < last; ++i)
                {
                    int offset = i-first;
                    //save top
                    int top=matrix[first][i];
                    //left-top
                    matrix[first][i] = matrix[last - offset][first];
                    //bottom -left
                    matrix[last-offset][first] = matrix[last][last-offset];
                    //right-bottom
                    matrix[last][last-offset] = matrix[i][last];
                    //top-right
                    matrix[i][last] = top;
                }
            }
        }
    }
}
