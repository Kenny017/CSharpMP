using System;

namespace FirstHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            //My Solution 1
            string[] myArray = { "Woohoo", "HelloThere", "abcdef" };
            foreach(string item in myArray)
            {
                Console.WriteLine(item.Substring(0, item.Length / 2));
            }
            //My Solution 2
            string firstHalf = "Woohoo";
            Console.WriteLine(firstHalf.Substring(0, firstHalf.Length / 2));
            string firstHalf1 = "HelloThere";
            Console.WriteLine(firstHalf1.Substring(0, firstHalf1.Length / 2));
            string firstHalf2 = "abcdef";
            Console.WriteLine(firstHalf2.Substring(0, firstHalf2.Length / 2));

        }
    }
}
