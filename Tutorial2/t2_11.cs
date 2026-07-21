using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_11
    {
        public static void arr()
        {
            int n, sum = 0;
            Console.WriteLine("Enter Elements in Array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Enter Elements:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i<n; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum of Array Elements: " + sum);
        }
    }
}
