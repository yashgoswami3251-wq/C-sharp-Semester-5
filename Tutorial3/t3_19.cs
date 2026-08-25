using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_19
    {
        class student
        {
            static int count = 0;

            public student()
            {
                count++;
            }

            public static void Displaycount()
            {
                Console.WriteLine("Total number of students :" + count);
            }
        }

        public static void ninteen()
        {
            student s = new student();
            student.Displaycount();
        }
    }
}
