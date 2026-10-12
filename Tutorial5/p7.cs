using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p7
    {
        public static void program()
        {
            int[] arr = { 10, 34, 56, 78, 89, 100,55,15 };
            int[] odd = new int[arr.Length];
            int[] even = new int[arr.Length];

            int e = 0, o = 0;

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[e] = arr[i];
                    e++;
                }
                else
                {
                    odd[o] = arr[i];
                    o++;
                }
            }

            Console.WriteLine("Gauswami Yashgiri && 25SOEIT13018");

            Console.WriteLine("Even elements");

            for(int i=0; i<e; i++)
            {
                Console.WriteLine(even[i] + " ");
            }

            Console.WriteLine("Odd elements");
            for (int i=0; i<o; i++)
            {
                Console.WriteLine(odd[i] + " ");
            }
            
        }
    }
}
