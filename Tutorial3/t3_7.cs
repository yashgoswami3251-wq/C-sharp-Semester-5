using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_7
    {
        class Studetns
        {
            private int enroll;
            private string name;

            public Studetns(int e , string n)
            {
                enroll = e;
                name = n;
            }

            public void Display()
            {
                Console.WriteLine("Enrollement Number :" + enroll);
                Console.WriteLine("name is :" + name);
            }

        }

        public static void run()
        {
            Console.WriteLine("Enter enrollment number :");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            string n = Console.ReadLine();

            Studetns s = new Studetns(e, n);
            s.Display();

            Console.ReadLine();
        }
    }
}
