using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_14
    {

        class Employee
        {
            private double salary;

            public void setSalary(double amount)
            {
                if(amount > 0)
                {
                    salary = amount;
                }
                else
                {
                    Console.WriteLine("Salary must be greater than 0");
                }
            }

            public double getSalary()
            {
                return salary;
            }
        }
        public static void employee()
        {
            Employee e1 = new Employee();
            
            Console.WriteLine("Enter the salary of the employee: ");
            double amount  = Convert.ToDouble(Console.ReadLine());

            //
            e1.setSalary(amount);
            Console.WriteLine("The salary of the employee is: " + e1.getSalary());
        }
    }
}
