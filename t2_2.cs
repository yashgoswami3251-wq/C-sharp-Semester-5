using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language
{
    internal class t2_2
    {
        public static void tutorial()
        {
            char firstname = 'Y';
            char lastname = 'A';

            Console.WriteLine("Name: " + firstname + " " + lastname);
            Console.WriteLine("Please enter a new first name:");

            firstname = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("New name: " +  firstname + " " + lastname);
            Console.ReadLine();
        }
    }
}
