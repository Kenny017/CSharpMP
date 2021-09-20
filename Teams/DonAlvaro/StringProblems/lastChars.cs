using System;
using System.Text;

namespace Program
{
    class lastCharsClass
    {
        static void main(string[] args)
        {
            Console.WriteLine(lastChars("last","chars")); ;
            Console.WriteLine(lastChars("yo", "java"));
            Console.WriteLine(lastChars("hi",""));

        }

        public static string lastChars(string word1, string word2)
        {
            if (word1.Length != 0 && word2.Length != 0)
            {
                return word1[0].ToString() + word2[word2.Length - 1].ToString();

            } else if (word1.Length != 0 && word2.Length == 0){

                return word1[0].ToString() + "@";

            } else if (word1.Length == 0 && word2.Length != 0)
            {
                return "@" + word2[word2.Length - 1].ToString();
            }
            else
            {
                return "@@";
            }

        }

    }


}