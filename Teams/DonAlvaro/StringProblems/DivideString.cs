using System;
using System.Text;

namespace Program
{
    class DivideString   //Divides an Even Length String into Half.
    {
        static void main(string[] args)
        {
            string outputString;
            StringBuilder input = new StringBuilder();
            char userInput = 'y';

            do
            {
                int halfLength = 0;
                input.Clear();

                Console.Write("Input a word of even length to be divided in half: ");
                input.Append(Console.ReadLine());
                halfLength = (int)input.Length / 2;

                if (input.Length % 2 == 0)
                    input.Remove(halfLength, halfLength);
                else
                    input.Remove(halfLength, halfLength + 1);

                outputString = input.ToString();

                Console.WriteLine($"New String: {outputString}" );

                Console.Write("Try Again? (y/n): ");
                userInput = Console.ReadLine()[0];

            } while (userInput == 'y');
		//TEST FOR BRANCH
        }
    }
}
