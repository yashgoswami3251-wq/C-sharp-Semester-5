using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p3
    {
        public static void program()
        {
            Console.WriteLine("Gauswami Yashgiri A && 25SOEIT13018");
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for(int i=0; i<arr.Length-1; i++)
            {
                Console.WriteLine("Enter element " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Reversed Array");
            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
