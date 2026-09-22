using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Paresh_Tanna_sir
{
    internal class class_object
    {
        class Employee()
        {
            public string name = "yash";
            public int age = 21;

            public virtual void Display()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
            }

            public void check()
            {
                Console.WriteLine("This is a check method in Employee class.");
            }

            public void test()
            {
                Console.WriteLine("This is a test method in Employee class.");
            }
        }

        class RegularEmployee : Employee
        {
            public int salary = 50000;
            public override void Display()
            {
                Console.WriteLine("Salary: " + salary);
            }

            public new void check()
            {
                Console.WriteLine("This is a check method in RegularEmployee class.");
            }
        }

        public static void yash()
        {
            Employee e1 = new Employee();
            e1.Display(); // Employee
            e1.check();   // Employee
            Console.WriteLine("------------------------------");

            RegularEmployee e2 = new RegularEmployee(); 
            e2.Display();  // RegularEmployee  
            e2.check();    // RegularEmployee
            Console.WriteLine("------------------------------");

            Employee e3 = new RegularEmployee();
            e3.Display(); // RegularEmployee
            e3.check();  // Employee
            Console.WriteLine("------------------------------");

        }
    }
}
