using System;
using System.Text;

namespace String
{
    class Anagram //Checks if both words are Anagrams.
    {   
        static string SortString(string input)
        {
            char[] characters = input.ToCharArray();
            Array.Sort(characters);
            return new string(characters);

        }
        static void main(string[] args)
        {
            string a, b;
            Console.WriteLine("Input two Strings.");

            Console.Write("String a: ");
            a = SortString(Console.ReadLine().ToLower());

            Console.Write("String b: ");
            b = SortString(Console.ReadLine().ToLower());

            if (a == b)
            {
                Console.WriteLine("Both strings are anagram.");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}