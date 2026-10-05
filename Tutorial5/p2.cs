using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p2
    {
        public static void program()
        {
            int[] arr = new int[5];
            Console.WriteLine("Gauswami Yashgiri A && 25SOEIT13018");
            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Enter the value of arr" + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Array.Sort(arr);

            for (int i=0; i<arr.Length-1; i++)
            {
              for(int j=0; j<arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
