using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language
{
    internal class Fibonacci
    {
        public static void fib()
        {
            int num;
            Console.WriteLine("Enter Fibnacci range");
            num = Convert.ToInt32(Console.ReadLine());

            int n1 = 0, n2 = 1, n3;

            Console.Write(n1 + " " + n2 + " ");

            for (int i = 2; i<=num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
 