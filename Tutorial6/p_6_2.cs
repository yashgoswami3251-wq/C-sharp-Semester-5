using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    interface IpersonalDetails
    {
        void personalDetails();
        void showpersonalDetails();
    }

    interface IprofessionalDetails
    {
        void getprogessionalDetails();
        void showprofessionalDetails();
    }

    class Employee : IpersonalDetails, IprofessionalDetails
    {

        string name;
        string address;
        string gender;


        int no_of_exp;
        double s;
        string companyname;
        public void personalDetails()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter address:");
            address = Console.ReadLine();

            Console.WriteLine("Enter gender:");
            gender = Console.ReadLine();
        }

        public void showpersonalDetails()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Address :" + address);
            Console.WriteLine("Gender :" + gender);
        }

        public void getprogessionalDetails()
        {
            Console.WriteLine("Enter number of experience:");
            no_of_exp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter salary:");
            s = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter company name:");
            companyname = Console.ReadLine();


        }

        public void showprofessionalDetails()
        {
            Console.WriteLine("Number of experience :" + no_of_exp);
            Console.WriteLine("Salary :" + s);
            Console.WriteLine("Company name :" + companyname);
        }
    }
    internal class p_6_2
    {
        public static void program()
        {
            Employee emp = new Employee();
            emp.personalDetails();
            emp.showpersonalDetails();
            emp.getprogessionalDetails();
            emp.showprofessionalDetails();
        }
    }
}
