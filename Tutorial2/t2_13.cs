using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_13
    {
        public static void notes()
        {
            int amount;

            Console.Write("Enter Amount :");
            amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in notes)
            {
                int count = amount / note;
                Console.WriteLine("Notes of" + note + " : " + count);
                amount = amount % note;
            }
            Console.ReadLine();
            Console.WriteLine("\n25SOECE13045 Pritesh Bharadwa");
        }
    }
}
