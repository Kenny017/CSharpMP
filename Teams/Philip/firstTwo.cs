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
                string str;
                Console.Write("Enter Word: ");
                str = Console.ReadLine();

                if (str.Length >= 2)
                {
                    Console.WriteLine(str.Substring(0,2));
                }
                /* Solution notes: need an if/else structure to call substring if the length
                   is 2 or more, and otherwise returnn the string itself*/

                Console.Write("\nTry Again? (y/n): ");
                userInput = Console.ReadLine()[0];

            } while (userInput == 'y');
        }
    }
}