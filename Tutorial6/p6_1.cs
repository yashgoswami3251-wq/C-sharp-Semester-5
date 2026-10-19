using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    interface Iemployee
    {
        void getemtdetails();
        void showempdetails();
    }

    class employee : Iemployee
    {
        string name;
        string designation;
        int age;

        public void getemtdetails()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter designation:");
            designation = Console.ReadLine();
            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void showempdetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Age: " + age);
        }
    }

    internal class p6_1
    {
        public static void program()
        {
            
            employee emp = new employee();
            emp.getemtdetails();
            emp.showempdetails();
        }
    }
}
