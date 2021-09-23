using System;
using System.Text;

namespace Program
{
    class SumDigitsProg
    {
        //given a string, return the sum of digits 0-9 that appear in the string, ignoring all other 
        //characters. Return 0 if there are no digits in the string.
        //sumDigits("aa1bc23") -> 6
        //sumDigits("aa11b33") -> 8
        //sumDigits("Chocolate") -> 0

        static void main(string[] args)
        {
            Console.WriteLine(sumDigits("aa1bc23"));
            Console.WriteLine(sumDigits("aa11b33"));
            Console.WriteLine(sumDigits("Chocolate"));

        }

        public static int sumDigits (string word)
        {
            int Count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsDigit(word[i]))
                    {
                        Count += int.Parse(word[i].ToString());
                    }

                }

                return Count;
            }
            else
            {
                return 0;
            }

        }

    }

}