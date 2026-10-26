using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    internal class p6_11
    {
        public static void program()
        {
            List<int> numbers = new List<int>()
            {
                25,10,23,54,12,67
            };

            var evennumbers = from n in numbers where n % 10 == 0 orderby n select n;

            Console.WriteLine("Evevn Numbers:");

            foreach(int n in evennumbers)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
