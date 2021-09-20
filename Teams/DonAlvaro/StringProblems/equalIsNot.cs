using System;
using System.Text;

namespace Program
{
    class EqualIsNotProg
    {
        //Given a string, return true if the number of appearances of "is" anywhere in the string
        //is equal to the number of appearances of "not" anywhere in the string.
        static void main(string[] args)
        {
            Console.WriteLine(equalIsNot("This is not"));
            Console.WriteLine(equalIsNot("This is not not"));
            Console.WriteLine(equalIsNot("noisxxnotyynotxisi"));

        }

        public static bool equalIsNot(string input)
        {
            int countIs = 0;
            int countNot = 0;

            if (!string.IsNullOrEmpty(input))
            {
                int index = 0;
                int i = 0;

                do
                {   
                    if (i < input.Length)
                     {
                        index = input.IndexOf("is", i);
                        if (index != -1)
                        {
                            i = index;
                            countIs++;
                            if (i + 2 < input.Length)
                            {
                                i += 1;
                            }

                        } else
                        {
                            break;
                        }
                     }
                    i++;
                } while (i < input.Length);

                index = 0;
                i = 0;
                do
                {
                    if (i < input.Length)
                    {
                        index = input.IndexOf("not", i);
                        if (index != -1)
                        {
                            i = index;
                            countNot++;
                            if (i + 2 < input.Length)
                            {
                                i += 2;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    i++;
                } while (i < input.Length);

                if (countIs == countNot && countIs != 0 && countNot != 0)
                {
                    return true;
                } else
                {
                    return false;
                }

            } else
            {
                return false;
            }
        }
    }

}