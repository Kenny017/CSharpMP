using System;
using System.Text.RegularExpressions;

namespace Program
{
    class IPValidation
    {
        static void main(string[] args)
        {
            string ipAddresInput;
            Regex rg = new Regex(@"(\b25[0-5]|\b2[0-4][0-9]|\b[0-1]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)){3}");
            char userAnswer = 'y';
            do
            {
                Console.Write("Enter a valid I.P. address: ");
                ipAddresInput = Console.ReadLine();
                MatchCollection matchedIP = rg.Matches(ipAddresInput);
                try
                {
                    Console.WriteLine("Matched I.P: " + matchedIP[0].Value);
                }
                catch (ArgumentOutOfRangeException)
                {

                    Console.WriteLine("Invalid IP.");
                }

                Console.Write("Try Again (y/n):");
                userAnswer = Console.ReadLine()[0];

            } while (userAnswer == 'y');

        }

    }

}