using System;

using System.Text;

namespace Program
{
    class NonStart
    {
        static void main(string[] args)
        {
            Console.WriteLine(nonStart("Hello","There"));
            Console.WriteLine(nonStart("java", "code"));
            Console.WriteLine(nonStart("shotl", "java"));

        }

        public static string nonStart(string firstWord, string secWord)
        {
            return new StringBuilder(firstWord.Substring(1) + secWord.Substring(1)).ToString();
        }

    }

    

}