using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p9
    {
        public static void program()
        {
            Console.WriteLine("Gauswami Yashgiri && 25SOEIT13018");
            int[] arr = {10, 20, 30, 40, 50};

            Console.WriteLine("Enter Position of element to delete :");
            int pos = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<arr.Length -1; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.WriteLine("Array after deletion :");

            for(int i=0; i<arr.Length-1; i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }
        }
    }
}
