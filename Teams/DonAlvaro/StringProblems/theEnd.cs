using System;
using System.Text;

namespace Program
{
    class theEndClass
    {
        static void main(string[] args)
        {
            Console.WriteLine(theEnd("Hello", true));    ;
            Console.WriteLine(theEnd("Hello", false));
            Console.WriteLine(theEnd("oh", true));

        }
        public static string theEnd(string word, bool trueOrFalse)
        {
            if (trueOrFalse)
            {
                return word.Trim()[0].ToString();
            } else
            {
                return word.Trim()[word.Length - 1].ToString();
            }


        }

    }

}