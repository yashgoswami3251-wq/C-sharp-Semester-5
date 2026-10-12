using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p8
    {
        public static void program()
        {

            Console.WriteLine("Gauswami Yashgiri && 25SOEIT13018");
            int[] arr = {10,20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Array.Sort(arr);
            Array.Reverse(arr);

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
