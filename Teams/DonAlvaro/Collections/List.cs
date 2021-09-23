using System;
using System.Collections.Generic;

namespace Collection
{
    class ListProgram
    {
            //You are given n lines. In each line there zero or more integers. You need to answer  a few queries 
            //INPUT: The first line has an integer N. 
            //In each the next N lines there will be an integer D denoting number of integers on that line
            //and then there will be D space-separated integers. In the next line there will be an integer q denoting the number of queries. 
            //Each query will consist of one integer.
            //OUTPUT: In each line, give the output of the query if it exist, if there is no such number, just print "ERROR!"
            //input: 2 //no of entries
            //12 44 54 78 comma-separated integers 
            //42 34 35
            //3 //number of queries
            //42
            //present in the list
            //1 
            //not present
            //3 
            //not present
        static void main(string[] args)
        {
            Console.WriteLine("Input N: ");
            int nInput = int.Parse(Console.ReadLine());
            string[] dInput;
            List<int> Integers = new List<int>();

            for (int i = 0; i < nInput; i++)
            {
                dInput = Console.ReadLine().Split(' ');

                for (int j = 0; j < dInput.Length; j++)
                {
                    Integers.Add(int.Parse(dInput[j]));
                }

            }
            Console.WriteLine("No. of Queries");
            int noOfQueries = int.Parse(Console.ReadLine());

            for (int i = 0; i < noOfQueries; i++)
            {
                int itemQuery = int.Parse(Console.ReadLine());
                if (Integers.Contains(itemQuery))
                {
                    Console.WriteLine($"Number {itemQuery} is present in the List.");

                }
                else
                {
                    Console.WriteLine($"ERROR. Number {itemQuery} is Not present in the List.");
                }

            }
        }

    }

}