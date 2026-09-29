using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Paresh_Tanna_sir
{

    // Decalaration
    delegate void MyDelegate(int a, int b);
    delegate void MyDelegate1(int a, int b, int c);
    class @delegate
    {
        public static void Add(int a , int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication: " + (a * b));
        }

        public static void Divide(int a , int b)
        {
            Console.WriteLine("Division: " + (a / b));
        }

        public static void Subtract(int a, int b , int c)
        {
            Console.WriteLine("Subtraction: " + (a + b + c));
        }

        public static void delegate_example()
        {
            // Instatiation
            MyDelegate obj = new MyDelegate(Add);
            MyDelegate1 obj1 = new MyDelegate1(Subtract);

            // Invocation
            obj += Multiply;  // Multicast delegate
            obj += Divide;
            Add(10,15);
            obj(7, 8);
            obj1(15, 7,3);
        }
    }
}
    