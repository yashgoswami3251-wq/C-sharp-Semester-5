using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language
{
    internal class table
    {
        public static void tbl()
        {
            int number;
            Console.Write("Enter a number :");

            number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number);



            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + "|" + i + "|" + i*number);
            }

        }
    }
}
