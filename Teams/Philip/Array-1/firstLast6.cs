using System;

namespace Array_1
{
    class firstLast6
    {
        static void Main(string[] args)
        {
            int[] a = { 13,6,1,2,6 };
            
            if (a[0] == 6)
            {
                Console.WriteLine("True");
            }
            else if (a[a.Length -1] ==6)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
            
            
        }
    }
}
