using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_4
    {
        class Student
        {
            private int Enroll_no;
            private string Name;
            private string Branch;

            public void AcceptDetails(int e, string n, string b)
            {
                Enroll_no = e;
                Name = n;
                Branch = b;
            }

            public void DisplayDetails()
            {
                Console.WriteLine("---------Student Details---------");
                Console.WriteLine("Enrollment Number : " + Enroll_no);
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Branch : " + Branch);
            }
        }
        public static void tutorial()
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            Student s5 = new Student();

            s1.AcceptDetails(6, "John", "CSE");
            s1.DisplayDetails();

            s2.AcceptDetails(7, "Alice", "ECE");
            s2.DisplayDetails();

            s3.AcceptDetails(8, "Yash", "IT");
            s3.DisplayDetails();

            s2.AcceptDetails(9, "Pritesh", "CE");
            s2.DisplayDetails();

            s2.AcceptDetails(10, "Jay", "Civil");
            s2.DisplayDetails();

            Console.WriteLine("25SOEIT13018 Yashgiri Gauswami");
        }
    }
}
