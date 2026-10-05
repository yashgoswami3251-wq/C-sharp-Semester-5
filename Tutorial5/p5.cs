using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p5
    {
        public static void program()
        {
            Console.WriteLine("Gauswami Yashgiri && 25SOEIT13018");

            int[] arr = {10, 20, 10, 30, 20, 40, 10};
            for(int i=0; i<arr.Length; i++)
            {
                int count = 0;
                for(int j=0; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if(count > 1)
                {
                    Console.WriteLine(arr[i] + "occurs " + count + "times ");
                }
            }
        }
    }
}
