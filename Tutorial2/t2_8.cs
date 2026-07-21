using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_8
    {
        public static int eight(out int x, out int y, out int z)
        {
            Console.WriteLine("Enter the first value: ");

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");

            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");

            z = Convert.ToInt32(Console.ReadLine());

            int sum;
            sum = x + y + z;

            return sum;

        }

    }

    class TestOut

    {

        public static void Run()

        {
            /* local variable definition */

            int a, b, c, sum;



            /* calling a function to get the values */

            sum = t2_8.eight(out a,out b,out c);


            Console.WriteLine("After method call, value of a : {0}", a);

            Console.WriteLine("After method call, value of b : {0}", b);

            Console.WriteLine("After method call, value of c : {0}", c);

            Console.WriteLine("Sum :"+sum);
        }
    }
}
