using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language
{
    internal class Factorial
    {
        public static void fact()
        {
            int number;
            Console.WriteLine("Enter a number");

            String str = Console.ReadLine();
            number = Convert.ToInt32(str);

            int fact = 1;

            for(int i = 1; i<=number; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("factorial of " + number + "is: " + fact);
            Console.ReadLine();
        }
    }
}