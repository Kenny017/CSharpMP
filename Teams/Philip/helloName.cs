using System;

namespace codingBat
{
    class Program
    {
        public static void Main(String[] args)
        {
            //helloName
            //Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!".
            /*helloName("Bob") → "Hello Bob!"
            helloName("Alice") → "Hello Alice!"
            helloName("X") → "Hello X!"*/
            string[] helloName = { "Bob", "Alice", "X" };
            foreach (string item in helloName)
            {
                Console.WriteLine("Hello " + item + "!");
            }
        }
    }
}   