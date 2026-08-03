using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_11
    {
        public static void arr()
        {
            int n = 5;
            int[] arr = new int[n];
            int sum = 0;

            Console.WriteLine("Enter " + n + " elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum of the N elements is: " + sum);
            Console.WriteLine("\n25SOEIT13018 Yashgiri Gauswami ");

        }
    }
}
