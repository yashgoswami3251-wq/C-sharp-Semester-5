using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_3
    {
        public static void three()
        {
            string firstName = "Yashgiri";
            string lastName = "Gauswami";
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("New name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
