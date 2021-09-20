using System;
using System.Text;

namespace Program
{
    class withOutX2Prog
    {
        static void main(string[] args)
        {
            Console.WriteLine(withoutX2("xHi"));
            Console.WriteLine(withoutX2("Hxi"));
            Console.WriteLine(withoutX2("Hi"));

        }

        public static string withoutX2(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {

                if (word.Length > 2)
                {
                    if (word.Substring(0, 2).Contains('x'))
                    {
                        if (word[0] == 'x' && word[1] == 'x')
                        {
                            return word.Substring(2);
                        }
                        else if (word[0] == 'x' && word[1] != 'x')
                        {

                            return word[1].ToString() + word.Substring(2);
                        }
                        else if (word[0] != 'x' && word[1] == 'x')
                        {
                            return word[0].ToString() + word.Substring(2);
                        } else
                        {
                            return word;
                        }

                    }
                    else
                    {
                        return word;
                    }

                }
                else if (word.Length == 2)
                {
                    if (word == "xx")
                    {
                        return "";
                    }
                    else if (word[0] == 'x' && word[1] != 'x')
                    {
                        return word[1].ToString();

                    }
                    else if (word[0] != 'x' && word[1] == 'x')
                    {
                        return word[0].ToString();
                    }
                    else
                    {
                        return word;
                    }

                } else
                {
                    if (word == "x")
                    {
                        return "";
                    }
                    else
                    {
                        return word;
                    }
                }

            }
            else
            {
                return "";
            }

         }

    }

}