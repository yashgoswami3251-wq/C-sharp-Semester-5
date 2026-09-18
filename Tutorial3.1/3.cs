using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _3
    {
        public static void three()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            Console.Write("Enter sentence: ");
            string s = Console.ReadLine();
            Console.WriteLine("Uppercase: " + s.ToUpper());
            Console.WriteLine("Replace spaces: " + s.Replace(" ", "_"));
            Console.WriteLine("Trim: " + s.Trim());
            Console.WriteLine("Length: " + s.Length);

        }
    }
}
