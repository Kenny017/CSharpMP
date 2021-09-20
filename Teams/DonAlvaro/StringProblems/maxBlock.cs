using System;
using System.Text;

namespace Program
{
    class maxBlockProg
    {
        //Given a sring, return the length of the largest "block" in the string.
        //a block is a run of adjacent chars that are the same.
        static void main(string[] args)
        {
            Console.WriteLine(maxBlock("hoopla"));
            Console.WriteLine(maxBlock("abbCCCddBBBxx"));
            Console.WriteLine(maxBlock(""));

        }

        public static int maxBlock (string word)
        {
            int prevCount = 0;
            int currentCount = 0;
            char charChecker;
            if (!string.IsNullOrEmpty(word))
            {
                charChecker = word[0];
                for (int i = 0; i < word.Length; i++)
                {
                    if (charChecker == word[i])
                    {
                        currentCount++;
                    } else
                    {
                        charChecker = word[i];
                        currentCount = 1;

                    }
                    if (currentCount > prevCount)
                    {
                        prevCount = currentCount;
                    }

                }
                return prevCount > currentCount ? prevCount : currentCount;
            } else
            {
                return 0;
            }
                
        }

    }

}