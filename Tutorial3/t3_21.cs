using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_21
    {
        class student
        {
            protected int roll_no;
            protected string name;

            public student() { }
            public student(int roll_no, string name)
            {
                this.roll_no = roll_no;
                this.name = name;
            }
        }

        class studentdetails : student
        {
            private int age;
            public studentdetails(int roll_no,string name,int age) 
                : base(roll_no, name)
            {
                this.age = age;
            }

            public void display()
            {
                Console.WriteLine("Student roll_no :"+roll_no);
                Console.WriteLine("Student name :" + name);
                Console.WriteLine("Student age :" + age);
            }
        }
        public static void twentyone()
        {
            studentdetails s1 = new studentdetails(06,"Yash",20);
            s1.display();
        }
    }
}
