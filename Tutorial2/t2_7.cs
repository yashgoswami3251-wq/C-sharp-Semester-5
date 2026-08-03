using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{

    class Number
    {
        public static void Swap(ref int x , ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
    }

    class t2_7
    {
        public static void seven() 
        {
            int x, y;
            Console.WriteLine("Enter X value");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Y value");
            y = Convert.ToInt32(Console.ReadLine());

            Number.Swap(ref x, ref y);
            Console.WriteLine("Value Of X After Swapping: "+x);
            Console.WriteLine("Value Of Y After Swapping: "+y);
            Console.WriteLine("\n25SOEIT13018 Yashgiri Gauswami ");
        }
    }
}
