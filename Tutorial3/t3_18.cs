using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_18
    {

        class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }

            public virtual void generatesalary(string Name, double Salary)
            {
                Console.WriteLine("Employee salary sleep");
            }
        }

        class permenentEmployee : Employee 
        {
            public override void generatesalary(string Name, double Salary)
            {
                double hra = Salary * 0.20;
                double da = Salary * 0.10;
                double netSalary = Salary + hra + da;

                Console.WriteLine("\n Permanent Employee Detaild");
                Console.WriteLine("------------------");
                Console.WriteLine("Employee Name : " + Name);
                Console.WriteLine("Basic Salary : " + Salary);
                Console.WriteLine("HRA : " + hra);
                Console.WriteLine("DA : " + da);
                Console.WriteLine("Net Salary : " + netSalary);
            }
        }

        class contractemploye : Employee
        {
            public override void generatesalary(string Name, double Salary)
            {
                double netSalary = Salary;

                Console.WriteLine("\n Contract Employee Detaild");
                Console.WriteLine("------------------");
                Console.WriteLine("Employee Name : " + Name);
                Console.WriteLine("Basic Salary : " + Salary);
            }
        }

        public static void eighteen()
        {

            permenentEmployee p = new permenentEmployee();
            p.generatesalary("Yash", 100);

            contractemploye c = new contractemploye();
            c.generatesalary("Yash", 100);
        }
    }
}
