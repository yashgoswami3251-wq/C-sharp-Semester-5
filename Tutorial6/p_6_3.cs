using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    delegate int Calculate(int a, int b);

    internal class p_6_3
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
        public static void program()
        {
            
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: "); 
            int num2 = Convert.ToInt32(Console.ReadLine());

            Calculate c;

            c = Add;
            Console.WriteLine("Addition: " + c(num1, num2));
            c = Subtract;
            Console.WriteLine("Subtraction: " + c(num1, num2));
            c = Multiply;
            Console.WriteLine("Multiplication: " + c(num1, num2));
            c = Divide;
            Console.WriteLine("Division: " + c(num1, num2));

        }
    }
}
