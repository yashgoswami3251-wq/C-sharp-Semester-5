using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language
{
    internal class Questions
    {
        public static void Que()
        {
            string name;
            char gender;

            Console.WriteLine("Enter name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter a Gender (M/F)");
            gender = Convert.ToChar(Console.ReadLine());

            if(gender == 'M' || gender == 'm')
            {
                Console.WriteLine("Mr" + name);
            
            }
            else if(gender == 'F' || gender == 'f')
            {
                Console.WriteLine("Ms" + name);
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
        }
    }
}
