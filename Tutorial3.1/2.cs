using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _2
    {
        public static void two()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            Console.Write("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum += a[i];
            }

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + (double)sum / n);

        }
    }
}
