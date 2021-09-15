using System;
using System.Text;

namespace DivideString
{
    class Program
    {
        /*Instructions*/
        /*Given a string of even length, return the first half.So the string "WooHoo" yields "Woo".           
        firstHalf("WooHoo") → "Woo"
        firstHalf("HelloThere") → "Hello"
        firstHalf("abcdef") → "abc"*/

        static void Main(string[] args)
        {
            /*instantiated String Builder Object sb */
            StringBuilder sb = new StringBuilder();
            /*I instantiated con to accept user input to loop*/
            var con = "y";
            while (con == "y") 
            {
                /*clear out the stringbuilder contents*/
                sb.Clear();

                /*Inputs and appends an inputted word*/
                Console.WriteLine("Choose an even letters word:");
                sb.Append(Console.ReadLine());

                /*Equation to Divide the length of sb or the inputted string*/
                var FirstHalf1 = sb.Length / 2;

                /*I use the remove method to use the firsthalf(starting point index) to remove following second half*/
                sb.Remove(FirstHalf1, FirstHalf1);

                /*Shows Output*/
                Console.WriteLine(sb);

                /*Ask the user to continue the program or not*/
                Console.WriteLine("Would you like to try another word: (y/n)");
                con = Console.ReadLine();

            }
        }
    }
}
