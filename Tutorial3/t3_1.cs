using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    class prog1
    {
        private int enroll_no;
        private string name;
        private string branch;

        public void Student(int e , string n, string b)
        {
            enroll_no = e;
            name = n;
            branch = b;
        }

        public void Display()
        {
            Console.WriteLine("---------Student Details---------");
            Console.WriteLine("Enrollment Number : " + enroll_no);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("branch : " + branch);
        }
    }
    internal class t3_1
    {
        public static void oop()
        {
            int enroll_no;
            string name,branch;

            Console.WriteLine("Enter Enrollment Number : ");
            enroll_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Branch : ");
            branch = Console.ReadLine();

            prog1 obj = new prog1();
            obj.Student(enroll_no, name, branch);
            obj.Display();
            Console.ReadLine();
        }
    }
}
