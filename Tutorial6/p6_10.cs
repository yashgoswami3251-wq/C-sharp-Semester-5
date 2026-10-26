using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    internal class p6_10
    {
        public static void program()
        {
            List<int> marks = new List<int>()
            {
                45,76,34,98,34
            };

            Console.WriteLine("Marks greater than 50;");

            marks.FindAll(m => m > 50).ForEach(m => Console.WriteLine(m));

            Console.ReadLine();
        }
    }
}
