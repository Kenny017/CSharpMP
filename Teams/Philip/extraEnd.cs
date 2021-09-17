using System;
using System.Text;
namespace codingBat
{
    class Program
    {
        public static void Main(String[] args)
        {
            StringBuilder input = new StringBuilder();
            char userInput = 'y';

            do
            {
                input.Clear();
                string word;
                string end;
                Console.Write("Enter Word: ");
                word = Console.ReadLine();
                end = word.Substring(word.Length - 2);
                Console.Write("Output: "+ end + end +end);

                Console.Write("\nTry Again? (y/n): ");
                userInput = Console.ReadLine()[0];

            } while (userInput == 'y');

        }
    }
}