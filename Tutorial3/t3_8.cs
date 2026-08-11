using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_8
    {
       class Employee
        {
            private int empId;
            private string name;
            private double basicSalary;
            private double netSalary;

            public Employee(int id,string nm , double salary)
            {
                empId = id;
                name = nm;
                basicSalary = salary;
            }

            public void CalculateSalary()
            {
                double hra = basicSalary + 0.20;
                double da = basicSalary + 0.10;

                netSalary = basicSalary + hra + da;
            }

            public void Display()
            {
                Console.WriteLine("Employee ID : " + empId);
                Console.WriteLine("Employee Name : " + name);
                Console.WriteLine("Basic Salary : " + basicSalary);
                Console.WriteLine("Net Salary : " + netSalary);
            }
        }

        class Pro10
        {
            static void run()
            {
                Console.Write("Enter Emp ID");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Emp Name");
                string name = Console.ReadLine();

                Console.Write("Enter Basic Salary");
                int basicSalary = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter netSalary");
                int salary = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
