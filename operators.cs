using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language
{
    internal class operators
    {
        public static void opr()
        {
            int a, b;
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------Arithmatic Operators-------");
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));

            Console.WriteLine("-------Relational Operators-------");
            Console.WriteLine("a<b: " + (a < b));
            Console.WriteLine("a>b: " + (a > b));
            Console.WriteLine("a==b: " + (a == b));
            Console.WriteLine("a!=b: " + (a != b));


            Console.WriteLine("-------Logical Operators-------");
            Console.WriteLine("a>b && a<b: " + (a > b && a < b));
            Console.WriteLine("a>b || a<b: " + (a > b || a < b));
            Console.WriteLine("!(a==b): " + (!(a == b)));


            Console.ReadLine();
        }
    }
}
