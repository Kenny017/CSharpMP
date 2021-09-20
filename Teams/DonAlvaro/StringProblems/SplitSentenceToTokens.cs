using System;
using System.Text;

namespace Program
{
    class SplitWordsToToken
    {   //Split the String Into Word Tokens. Then output total length and print each item
        static void main(string[] args)
        {
            string[] input_tokens;
            char[] splitters = new char[] { '!', '?', '.', '_', '\'', '@', ' ', ',' };
            Console.Write("Enter a String: ");
            input_tokens = Console.ReadLine().Split(splitters, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Token Length: {input_tokens.Length}");
            foreach (string item in input_tokens)
            {
                Console.WriteLine(item);
            }

        }

    }

}