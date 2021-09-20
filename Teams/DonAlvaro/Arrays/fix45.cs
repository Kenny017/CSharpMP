using System;
using System.Text;

namespace Arrays
{
    class fix45Prog
    {   //Return an array that contains exactly the same numbers as the given array, but rearranged
        //so that every 4 is immediately followed by a 5. Do not move the 4's, but every other number
        //may move. The array contains the same number of 4's and 5's, and every 4 has a number after it
        //that is not a 4. In this version, 5's may appear anywhere in the original array.
        //fix45([5, 4, 9, 4, 9, 5]) → [9, 4, 5, 4, 5, 9]
        //fix45([1, 4, 1, 5]) → [1, 4, 5, 1]
        //fix45([1, 4, 1, 5, 5, 4, 1]) → [1, 4, 5, 1, 1, 4, 5]
        
        static void main(string[] args)
        {
            Console.WriteLine(string.Join("," ,fix45(new int[] { 5, 4, 9, 4, 9, 5 })));
            Console.WriteLine(string.Join(",", fix45(new int[] { 1, 4, 1, 5 })));
            Console.WriteLine(string.Join(",", fix45(new int[] { 1, 4, 1, 5, 5, 4, 1 })));

        }

        public static int[] fix45 (int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 4)
                {
                    if (!(nums[i+1] == 5))
                    {
                        for (j = 0; j < nums.Length; j++)
                        {
                            if (nums[j] == 5)
                            {   
                                int temp = 0;
                                temp = nums[i + 1];
                                nums[i + 1] = nums[j];
                                nums[j] = temp;
                                //j = i + 1;
                                i = i + 2;
                                break;
                            }
                        }
                    }
                }
            }

            return nums;

        }

    }

}