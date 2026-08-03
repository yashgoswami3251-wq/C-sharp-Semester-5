using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_6
    {
        public static void six(string[] args)
        {
            Console.WriteLine("You entered the following {0} command line arguments:", args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.WriteLine("\n25SOEIT13018 Yashgiri Gauswami ");

        }
    }
}
