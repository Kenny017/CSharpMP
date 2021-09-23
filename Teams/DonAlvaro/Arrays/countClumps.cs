using System;
using System.Text;

namespace Arrays
{
    class countClumpsProg
     {  //Say that a "clump" in an array is a series of 2 or more adjacent elements of the same value. Return the number of clumps in the given array.
        // countClumps([1, 2, 2, 3, 4, 4]) → 2
        // countClumps([1, 1, 2, 1, 1]) → 2
        // countClumps([1, 1, 1, 1, 1]) → 1
        static void Main(string[] args)
        {
            Console.WriteLine(countClumps(new int[] { 1, 2, 2, 3, 4, 4 }));
            Console.WriteLine(countClumps(new int[] { 1, 1,2,1,1 }));
            Console.WriteLine(countClumps(new int[] { 1, 1,1,1,1 }));
            Console.WriteLine(countClumps(new int[] { 11, 11, 33, 44, 44,44,44,44,66,66 }));

        }
        public static int countClumps(int[] nums)
        {   
            int prevCount = 0;
            int currentCount = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] == nums[i + 1] && currentCount == prevCount)
                {
                    currentCount += 1;
                } else if (nums[i] != nums[i + 1] && currentCount != prevCount)
                {
                    prevCount += 1;
                }
            }
            return currentCount;

        }

    }

}