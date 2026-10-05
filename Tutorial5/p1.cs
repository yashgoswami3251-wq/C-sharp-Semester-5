using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p1
    {
        public static void program()
        {
            //int[] arr = [10, 20, 30, 40, 50];

            int[] arr = new int[5];
            Console.WriteLine("Gauswami Yashgiri A && 25SOEIT13018");
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Enter the value of arr" + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
