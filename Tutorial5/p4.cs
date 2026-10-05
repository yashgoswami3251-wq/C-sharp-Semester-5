using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p4
    {
        public static void program()
        {
            Console.WriteLine("Gauswami Yashgiri A && 25SOEIT13018");
            int[] arr1 = [10, 20, 30, 40, 50];
            int[] arr2 = new int[arr1.Length];

            Console.WriteLine("Array Elements");
            for(int i=0; i<arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Array.Copy(arr1, arr2, arr1.Length);

            Console.WriteLine("Array 2 Element");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }

    }
}
