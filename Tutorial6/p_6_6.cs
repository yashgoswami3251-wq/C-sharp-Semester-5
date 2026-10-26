using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    internal class p_6_6
    {
        public static void program()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another number:");
                int b = Convert.ToInt32(Console.ReadLine());


                int resule = a / b;

                Console.WriteLine("Result " + resule);
            }
            catch
            {
                Console.WriteLine("Error : Cannot divided by Zero ");
            }
        }
    }
}
