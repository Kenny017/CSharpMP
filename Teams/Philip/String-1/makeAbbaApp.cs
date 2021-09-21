using System;
using System.Collections.Generic;
using System.Text;

namespace testingApp
{
    class makeAbbaApp
    {
        public void makeAbba()
        {
            StringBuilder input = new StringBuilder();
            char userInput = 'y';

            do
            {
                input.Clear();
                string input1;
                string input2;
                Console.Write("Enter First Word: ");
                input1 = Console.ReadLine();
                Console.Write("Enter Second Word: ");
                input2 = Console.ReadLine();
                Console.Write("Output: " + input1 + input2 + input2 + input1);
                Console.Write("\nTry Again? (y/n): ");
                userInput = Console.ReadLine()[0];
                

            } while (userInput == 'y');
        }

    }
}
