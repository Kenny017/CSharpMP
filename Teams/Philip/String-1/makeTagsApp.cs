using System;
using System.Collections.Generic;
using System.Text;

namespace testingApp
{
    class makeTagsApp
    {
        public void tags()
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
