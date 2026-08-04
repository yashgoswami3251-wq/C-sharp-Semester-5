using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_5
    {
        public static void five()
        {
            int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of Elements : {0}", sum);
            Console.Read();
            Console.WriteLine("\n25SOECE13045 Pritesh Bharadwa");
        }
    }
}
