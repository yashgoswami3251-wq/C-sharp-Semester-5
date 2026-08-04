using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_12
    {
        public static void nine()
        {
            int n, search;
            int found = 0;

            Console.WriteLine("Enter size");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Enter Elements:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Element to Search:");
            search = Convert.ToInt32(Console.ReadLine());
             
            for(int i = 0; i<n; i++) {
                if (arr[i] == search)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);
            Console.WriteLine();
            Console.WriteLine("\n25SOECE13045 Pritesh Bharadwa");
        }
    }
}
