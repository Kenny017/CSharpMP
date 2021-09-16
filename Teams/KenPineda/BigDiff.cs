using System;

namespace CodingBat
{
    class Program
    {

        
        static void Main(string[] args)
        {

            int[] a = new int[] { 10, 7, 4, 3 };
            int[] b = { 7, 2, 10, 9 };
            int[] c = { 2, 10, 7, 2 };

            Console.WriteLine(string.Join(",", a));
            Console.WriteLine(string.Join(",", b));
            Console.WriteLine(string.Join(",", c));

            int max_value = a[0];
            int min_value = a[0];
            
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max_value )
                    {
                        max_value = a[i];
                    }
                    else if (a[i] < min_value)
                    {
                        min_value = a[i];
                    }
                }
            int diff = max_value - min_value;

                Console.WriteLine(max_value);
                Console.WriteLine(min_value);
                Console.WriteLine(diff);


        }
    }
}
