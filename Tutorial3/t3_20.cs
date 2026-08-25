using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_20
    {
        class students
        {
            private int roll_no;
            private string name;

            public students(int roll_no, string name)
            {
                this.roll_no = roll_no;
                this.name = name;
            }

            public void display()
            {
                Console.WriteLine("Roll number is :" + roll_no);
                Console.WriteLine("Name of Studnets :" + name);
            }
        }
        public static void twenty()
        {
            students s = new students(6,"yash");
            s.display();
        }
    }
}
