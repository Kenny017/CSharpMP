using System;
using System.Collections.Generic;
using System.Text;

namespace testingApp
{
    class firstHalfApp
    {
        public void firstHalf()
        {

            StringBuilder input = new StringBuilder();
            char userInput = 'y';

            do
            {
                input.Clear();
                //Solution 1
                string firstHalf;
                Console.Write("Enter Word: ");
                firstHalf = Console.ReadLine();
                Console.WriteLine(firstHalf.Substring(0, firstHalf.Length / 2));
                
                

                Console.Write("\nTry Again? (y/n): ");
                userInput = Console.ReadLine()[0];

            } while (userInput == 'y');
        }
    }
}
