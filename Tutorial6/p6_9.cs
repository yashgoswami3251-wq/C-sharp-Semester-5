using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    internal class p6_9
    {
        public static void program()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> mul = (x, y) => x * y;
            Func<int, int, int> max = (x, y) => x > y ? x : y;

            Console.WriteLine("Addition is " + add(num1, num2));
            Console.WriteLine("Multiplication is " + mul(num1, num2));
            Console.WriteLine("Maximum number is " + max(num1, num2));
        }
    }
}
