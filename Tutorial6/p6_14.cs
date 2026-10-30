using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    class Pro14
    {
        static void Display()
        {
            Console.WriteLine("Thread is running...");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Value: " + i);
                Thread.Sleep(500);
            }

            Console.WriteLine("Thread execution completed.");
        }

        internal class p6_14
        {
            public static void program()
            {
                Thread t = new Thread(Display);

                Console.WriteLine("Before Start: " + t.ThreadState);

                t.Start();

                Console.WriteLine("After Start: " + t.ThreadState);

                t.Join();

                Console.WriteLine("After Join: " + t.ThreadState);

                Console.ReadLine();
            }
        }
    }
}
