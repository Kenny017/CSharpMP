using System;
namespace codingBat
{
    class Program
    {
        public static void Main(String[] args)
        {
            //makeAbba
            /*Instruction
            * Given two strings, a and b, return the result of putting them together in the order abba,
            * e.g. "Hi" and "Bye" returns "HiByeByeHi".
            * makeAbba("Hi", "Bye") → "HiByeByeHi"
            * makeAbba("Yo", "Alice") → "YoAliceAliceYo"
            * makeAbba("What", "Up") → "WhatUpUpWhat"*/
            //Solution 1
            string a = "Hi";
            string b = "Bye";
            Console.WriteLine(a + b + b + a);
            string a1 = "Yo";
            string b1 = "Alice";
            Console.WriteLine(a1 + b1 + b1 + a1);
            string a2 = "What";
            string b2 = "Up";
            Console.WriteLine(a2 + b2 + b2 + a2);
            // Solution 2
            string input1;
            string input2;
            Console.WriteLine("Enter First Word: ");
            input1 = Console.ReadLine();
            Console.WriteLine("Enter Second Word: ");
            input2 = Console.ReadLine();
            Console.WriteLine("Output: "+ input1 + input2 + input2 + input1);
        }
    }
}