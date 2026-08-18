using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_15
    {

        class Student
        {
            public string course {  get; set; }
            public string department { get; set; }

            public void Displaystudent()
            {
                Console.WriteLine("-----Student Details-----");
                Console.WriteLine("Course is :" + course);
                Console.WriteLine("Department is :" + department);
            }
        }

        class person : Student
        {
            public string name { get; set; }
            public int age { get; set; }

            public void Displayperson()
            {
                Console.WriteLine("-----Person Details-----");
                Console.WriteLine("Name is :" + name);
                Console.WriteLine("Age is :" + age);
            }
        }
        public static void inheritance()
        {
            person p1 = new person();
            
            Console.WriteLine("-----Person Detials-----");
            Console.WriteLine("Enter the name of the person:");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter the age of the person:");
            p1.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----Student Detials-----");
            Console.WriteLine("Enter the course of the student:");
            p1.course = Console.ReadLine();
            Console.WriteLine("Enter the department of the student:");
            p1.department = Console.ReadLine();

            p1.Displaystudent();
            p1.Displayperson();


        }
    }
}
