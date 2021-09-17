using System;

namespace ActivityTest
{
    class Program
    {
        public static void Main(String[] args)
        {
            //Solution 1
            string firstHalf = "Woohoo";
            Console.WriteLine(firstHalf.Substring(0,firstHalf.Length / 2));
            string firstHalf1 = "HelloWorld";
            Console.WriteLine(firstHalf1.Substring(0, firstHalf1.Length / 2));
            string firstHalf2 = "abcdef";
            Console.WriteLine(firstHalf2.Substring(0, firstHalf2.Length / 2));
            //Solution 2
            string firstHalfArray = {"Woohoo", "HelloThere", "abcdef"};
            foreach (string item in firstHalfArray)
            {
                Console.WriteLine(item.Substring(0,item.Length / 2));
            }
            

        }


    }
}
