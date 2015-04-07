using System;

namespace CodingChallenges.CrackingTheCodingInterview
{
    /// <summary>
    /// Replace all spaces in a string with '%02'. The true length of the string will be given. The string can have extra whitespaces at the end.
    /// </summary>
    class ReplaceSpacesInString_Chap1_4
    {
        //static void Main(string[] args)
        //{
        //    ReplaceSpacesInString_Chap1_4 uc = new ReplaceSpacesInString_Chap1_4();
        //    string str1 = "Mr John Smith  ";
        //    //true length
        //    int length = 13;
        //    char[] arr = uc.StartApplication(str1.ToCharArray(), length);
        //    str1 = new string(arr);

        //    Console.WriteLine(str1);
        //}

        private char[] StartApplication(char[] arr, int length)
        {
            int spaceCount = 0; int newLenght = 0, i;
            for (i = 0; i < length; i++)
            {
                if (arr[i] == ' ')
                {
                    spaceCount++;
                }
            }
            //If the length is 13 as in example with 2 spaces, we need 17 for the over count, 
            //so multiple by 2 as the original count will already have 1 space 
            newLenght = length + spaceCount * 2;

            Array.Resize(ref arr, newLenght);

            for (i = length - 1; i >= 0; i--)
            {
                if (arr[i] == ' ')
                {
                    arr[newLenght - 1] = '0';
                    arr[newLenght - 2] = '2';
                    arr[newLenght - 3] = '%';
                    newLenght = newLenght - 3;
                }
                else
                {
                    arr[newLenght - 1] = arr[i];
                    newLenght--;
                }
            }
            return arr;
        }
    }
}

