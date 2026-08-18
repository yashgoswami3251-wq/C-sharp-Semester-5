using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_12
    {
        class Studentdetails
        {
            public int enrollno { get; set; }
            public string name { get; set; }
        }
        public static void users()
        {
            Studentdetails s1  = new Studentdetails();
            Console.WriteLine("Enter the enrollment number:");
            s1.enrollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name:");
            s1.name = Console.ReadLine();

            Console.WriteLine("------Student Details------");
            Console.WriteLine("Enrollment Number: " + s1.enrollno);
            Console.WriteLine("Name: " + s1.name);
            Console.ReadLine();
        }
    }
}
