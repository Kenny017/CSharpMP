using System;
using System.Collections.Generic;
using System.Text;

namespace testingApp
{
    class helloName
    {
       public void helloName1()
        {
            StringBuilder input = new StringBuilder();
            char userInput = 'y';

            do
            {
                
                input.Clear();
                string input1;
                Console.Write("Input Name: ");
                input1 = Console.ReadLine();
                Console.Write("Output: " + "Hello " + input1 + "!");
                Console.Write("\nTry Again? (y/n): ");
                userInput = Console.ReadLine()[0] ;
                
        } while (userInput == 'y');
        } 

    }
}
