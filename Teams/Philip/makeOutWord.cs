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
            string out1;
            string word;
            Console.Write("Enter Out String: ");
            out1 = Console.ReadLine();
            Console.Write("Enter Word: ");
            word = Console.ReadLine();
            Console.Write("Output: " + out1.Substring(0,2) + word + out1.Substring(2));
            Console.Write("\nTry Again? (y/n): ");
            userInput = Console.ReadLine()[0];

            } while (userInput == 'y');
        }
    }
}