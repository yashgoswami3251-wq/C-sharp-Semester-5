using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p6
    {
        public static void program()
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int max = arr[0];
            int min = arr[0];

            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];

                }
            }
            Console.WriteLine("Gauswami Yashgiri && 25SOEIT13018");
            Console.WriteLine("Maximum value: " + max);
            Console.WriteLine("Minimum value: " + min);
        }
    }
}
