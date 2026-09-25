using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial_4
{
    internal class Employee
    {
            private int emp_code;
            private string emp_name;
            private string designation;
            private double basicpay;

            public Employee(int emp_code, string emp_name, string designation, double basicpay)
            {
                this.emp_code = emp_code;
                this.emp_name = emp_name;
                this.designation = designation;
                this.basicpay = basicpay;
            }

            public void Calculatepay()
            {
                double hra = 0.10 * basicpay;
                double da = 0.45 * basicpay;

                Console.WriteLine("Employee Code: " + emp_code);
                Console.WriteLine("Employee Name: " + emp_name);
                Console.WriteLine("Employee Designation: " + designation);
                Console.WriteLine("Employee Basic Pay: " + basicpay);

            }

        public static void tutorial_4_1()
        {
            Console.WriteLine("Gauswami Yashgiri A." + "25SOEIT13018");

            Employee emp = new Employee(101, "Yash", "Software Engineer", 50000);
            emp.Calculatepay();

            Employee emp1 = new Employee(102, "Pritesh", "Project Manager", 70000);
            emp1.Calculatepay();

            Employee emp2 = new Employee(103, "Marmik", "Team Lead", 60000);
            emp2.Calculatepay();
        }
    }
}
