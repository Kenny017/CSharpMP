using System;
using System.Text;

namespace Program
{
    class MakeOutWord
    {
        static void main(string[] args)
        {
            Console.WriteLine(makeOutWord("<<>>", "Yay")); 
            Console.WriteLine(makeOutWord("<<>>", "WooHoo")); 
            Console.WriteLine(makeOutWord("[[]]", "word")); 

        }

        public static string makeOutWord(string out1, string word)
        {
            StringBuilder word1 = new StringBuilder(out1);
            
            if (out1.Length == 4)
            {
                word1.Insert(out1.Length / 2, word);

                return word1.ToString();

            } else
            {
                return "First parameter isn't length of 4. ";
            }
        }

    }

    

}