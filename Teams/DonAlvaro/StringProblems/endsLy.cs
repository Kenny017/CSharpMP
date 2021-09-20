using System;
using System.Text;

namespace Program
{
    class endsLyProg
    {
        static void main(string[] args)
        {
            Console.WriteLine(endsLy("oddly")); ;
            Console.WriteLine(endsLy("y"));
            Console.WriteLine(endsLy("oddy"));

        }

        public static bool endsLy( string word)
        {
            if (string.IsNullOrEmpty(word) || word.Length < 2)
            {
                return false;

            } else if (word.Length == 2 && word == "ly")
            {
                return true;

            } else
            {
                if ( word.Substring(word.Length - 2) == "ly")
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
        }
        

    }

}