using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_4
    {
        public static void four()
        {
            // Input
            Console.Write("Enter First Number (A): ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number (B): ");
            int B = Convert.ToInt32(Console.ReadLine());

            // Arithmetic Operators
            Console.WriteLine("\n----- Arithmetic Operators -----");
            Console.WriteLine("Addition = " + (A + B));
            Console.WriteLine("Subtraction = " + (A - B));
            Console.WriteLine("Multiplication = " + (A * B));
            Console.WriteLine("Division = " + (A / B));
            Console.WriteLine("Modulus = " + (A % B));

            // Relational Operators
            Console.WriteLine("\n----- Relational Operators -----");
            Console.WriteLine("A == B : " + (A == B));
            Console.WriteLine("A != B : " + (A != B));
            Console.WriteLine("A > B : " + (A > B));
            Console.WriteLine("A < B : " + (A < B));
            Console.WriteLine("A >= B : " + (A >= B));
            Console.WriteLine("A <= B : " + (A <= B));

            // Logical Operators
            Console.WriteLine("\n----- Logical Operators -----");
            Console.WriteLine("(A > 0 && B > 0) : " + (A > 0 && B > 0));
            Console.WriteLine("(A > 0 || B > 0) : " + (A > 0 || B > 0));
            Console.WriteLine("!(A > B) : " + !(A > B));

            // Assignment Operators
            Console.WriteLine("\n----- Assignment Operators -----");
            int C = A;
            Console.WriteLine("C = " + C);
            C += B;
            Console.WriteLine("C += B : " + C);
            C -= B;
            Console.WriteLine("C -= B : " + C);

            // Increment / Decrement
            Console.WriteLine("\n----- Increment / Decrement -----");
            Console.WriteLine("A++ = " + (A++));
            Console.WriteLine("After A++ : " + A);
            Console.WriteLine("--B = " + (--B));

            // Different Data Types
            Console.WriteLine("\n----- Different Data Types -----");
            int num = 100;
            double price = 99.99;
            float marks = 85.5f;
            char grade = 'A';
            string name = "Renisha";
            bool result = true;

            Console.WriteLine("Integer : " + num);
            Console.WriteLine("Double : " + price);
            Console.WriteLine("Float : " + marks);
            Console.WriteLine("Character : " + grade);
            Console.WriteLine("String : " + name);
            Console.WriteLine("Boolean : " + result);
            Console.WriteLine("25SOECE13045 Pritesh Bharadwa");

        }
    }
}
