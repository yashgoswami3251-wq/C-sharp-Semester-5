using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_16
    {
       class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        class PermanentEmployee : Employee
        {
            public void CalculateSalary()
            {
                double hra = Salary * 0.20;
                double da = Salary * 0.10;
                double netSalary = Salary + hra + da;

                Console.WriteLine("\n Permanent Employee Detaild");
                Console.WriteLine("------------------");
                Console.WriteLine("Employee ID : " + EmployeeId);
                Console.WriteLine("Employee Name : " + Name);
                Console.WriteLine("Basic Salary : " + Salary);
                Console.WriteLine("HRA : " + hra);
                Console.WriteLine("DA : " + da);
                Console.WriteLine("Net Salary : " + netSalary);

            }
        }

        class ContractEmployee : Employee
        {
            public void CalculateSalary()
            {
                double netSalary = Salary;

                Console.WriteLine("\n Contract Employee Detaild");
                Console.WriteLine("------------------");
                Console.WriteLine("Employee ID : " + EmployeeId);
                Console.WriteLine("Employee Name : " + Name);
                Console.WriteLine("Basic Salary : " + Salary);
            }
        }
        public static void employee()
        {
            PermanentEmployee p = new PermanentEmployee();
            p.EmployeeId = 101;
            p.Name = "Yash";
            p.Salary = 50000;

            p.CalculateSalary();

            ContractEmployee c = new ContractEmployee();
            c.EmployeeId = 102;
            c.Name = "Pritesh";
            c.Salary = 30000;

            c.CalculateSalary();
        }
    }
}
