using System;

namespace CodingChallenges.CrackingTheCodingInterview
{
 /// <summary>
 /// Given 2 strings, check if they are permutation of the other 
 /// </summary>
    class Permutation_Chap1_3
    {
        //static void Main(string[] args)
        //{
        //    Permutation_Chap1_3 uc = new Permutation_Chap1_3();
        //    string str1= "Welcome to my";
        //    string str2 = "ym ot emocelW";
        //    bool c = uc.StartApplication(str1, str2);

        //    Console.WriteLine(c);
        //}
        
        //Ask the interviewer if they are case sensitive and care about whitespaces
        private bool StartApplication(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                return false;
            if (str1.Length != str2.Length)
                return false;

            int Orglength = str1.Length;
            int start = 0, length = Orglength;
            while(start< Orglength && length > 0)
            {
                if(str1[start] != str2[length -1])
                {
                    return false;
                }
                start++;
                length--;
            }

            return true;
        }
    }
}
