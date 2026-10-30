using System;
using System.Collections.Generic;
using System.Text;



namespace C_sharp_Language.Tutorial6
{
    delegate void Details();
    internal class p_6_4
    {

        static void Displayname()
        {
            Console.WriteLine("Student Name: John");
        }

        static void Displaycourse()
        {
            Console.WriteLine("Course: Java Programming");
        }

        static void Displaysemester()
        {
            Console.WriteLine("Semester: 6th");
        }


        public static void program()
        {

            Details dt;
            dt = Displayname;
            dt += Displaycourse;
            dt += Displaysemester;

            Console.WriteLine("Details of Student:");
            dt();


        }
    }
}
