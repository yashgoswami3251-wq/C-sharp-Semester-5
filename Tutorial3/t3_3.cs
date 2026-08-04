using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_3
    {

        class Student
        {
            public int id;
            public string name;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Student()   // Empty Constructor
            {
                id = 0;
                name = "Unknown";
            }

            public Student(int i, string n) // Parameterized Constructor
            {
                id = i;
                name = n;
            }

            public void DisplayDetails()
            {
                Console.WriteLine("---------Student Details---------");
                Console.WriteLine("ID : " + id);
                Console.WriteLine("Name : " + name);
            }
           
        }
        public static void tutorial()
        {
            Student s1 = new Student(1,"Yash"); // Calls the empty constructor
            s1.DisplayDetails();

            Console.ReadLine();

            Console.WriteLine("25SOEIT13018 Yashgiri Gauswami");

        }
    }

}
