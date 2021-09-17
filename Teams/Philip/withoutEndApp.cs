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
                string s;
                Console.Write("Enter Word: ");
                s = Console.ReadLine();
                string result = s.Substring(1, s.Length - 2);
                Console.Write("Output: "+result);

                Console.Write("\nTry Again? (y/n): ");
                userInput = Console.ReadLine()[0];

            } while (userInput == 'y');
        }
    }
}