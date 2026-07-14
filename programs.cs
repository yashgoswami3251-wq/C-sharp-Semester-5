using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language
{
    internal class programs
    {
        public static void prg()
        {
            int terms, number;
            int sum = 0;
            int current = 0;
            Console.WriteLine("Enter the number of terms: ");
            terms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter input number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for(int i= 1; i<=terms; i++)
            {
                current = current * 10 + number;
                Console.Write(current);
                sum += current;

                if (i < terms)
                    Console.Write("+");
            }
            Console.WriteLine("Sum is " + sum);
            Console.ReadLine();

        }
    }
}
