using System;
using System.Collections.Generic;
using System.Text;

namespace testingApp
{
    class tryAgainClass
    {
        public void TryAgain()
        {
            char userInput = 'y';

            do
            {
                StringBuilder input = new StringBuilder();
                input.Clear();
                
                Console.Write("Invalid Input! Try Again? Y/N : ");
                
                userInput = Console.ReadLine()[0];
                Console.Clear();
            } while (userInput == 'n');
        }
    }
}
