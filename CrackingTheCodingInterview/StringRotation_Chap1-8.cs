using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeEvalChallenges.CrackingTheCodingInterview
{
    class StringRotation_Chap1_8
    {
        //static void Main(string[] args)
        //{
        //    StringRotation_Chap1_8 uc= new StringRotation_Chap1_8();
        //    string str1 = "Waterbottle";
        //    string str2 = "erbottleWat";
        //    //true length

        //    bool arr = uc.StartApplication(str1, str2);
        //    Console.WriteLine(arr);

        //    Console.ReadKey();
        //}

        private bool StartApplication(string str1, string str2)
        {
            int len = str1.Length;
            if(len == str2.Length && len>0)
            {
                string s1 = str1 + str1;
                return isSubString(s1, str2);
            }
            return false;
        }

        private bool isSubString(string s1, string s2)
        {
            return s1.Contains(s2);
        }
    }
}
