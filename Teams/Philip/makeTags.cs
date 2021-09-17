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
                string tag;
            string word;
            Console.Write("Input tag: ");
            tag = Console.ReadLine();
            Console.Write("Input word: ");
            word = Console.ReadLine();

            Console.Write("Output: " + '<' + tag + '>' + word + '<' + '/' + tag + '>');

                Console.Write("\nTry Again? (y/n): ");
                userInput = Console.ReadLine()[0];

            } while (userInput == 'y');
        }
    }
}