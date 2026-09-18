using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _1
    {
        public static void one()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not a Leap Year");
        }

    }
}
