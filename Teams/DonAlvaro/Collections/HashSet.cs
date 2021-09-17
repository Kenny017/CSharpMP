using System;
using System.Collections.Generic;

namespace Collection
{
    class HashSet
    {   //You are given N pairs of strings. Two pairs (a,b) and (c,d) are identical if a == c and b == d. That also implies
        //(a,b) is not same as (b,a). After taking each pair as input, you need to print number of unique pairs you currently have.
        //sample input 
        //5
        //john tom
        //john mary
        //john tom
        //mary anna
        //mary anna
        //Sample output
        //1
        //2
        //2
        //3
        //3

        static void Main(string[] args)
        {
            HashSet<string> pairEntries = new HashSet<string>();
            Console.Write("Enter number of entries to the HashSet: ");
            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                Console.WriteLine($"Entry No. {i + 1}");
                Console.Write("Enter a Pair: ");
                string pair = Console.ReadLine().ToLower().Trim();
                pairEntries.Add(pair);
                Console.WriteLine($"\nTOTAL No. of Entries: {pairEntries.Count}\n");
            
            }

        }

    }

}