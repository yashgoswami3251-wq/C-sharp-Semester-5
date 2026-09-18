using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _7
    {
        class Employee
        {
            public virtual void CalculateSalary()
            {
                Console.WriteLine("Employee Salary");
            }
        }

        class Manager : Employee
        {
            public override void CalculateSalary()
            {
                Console.WriteLine("Manager Salary: 60000");
            }
        }

        class Developer : Employee
        {
            public override void CalculateSalary()
            {
                Console.WriteLine("Developer Salary: 50000");
            }
        }
        public static void seven()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            Employee e1 = new Manager();
            Employee e2 = new Developer();

            e1.CalculateSalary();
            e2.CalculateSalary();

        }
    }
}
