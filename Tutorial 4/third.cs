using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial_4
{
    internal class third
    {
        class College
        {
            private string name;
            protected string uni_name;
            public string department;

            public College(string name, string uni_name, string department)
            {
                this.name = name;
                this.uni_name = uni_name;
                this.department = department;
            }

            public void Displayname()
            {
                Console.WriteLine("Name of the College : "+ name);

            }

            public void DisplayUniname()
            {
                Console.WriteLine("Name of the University : " + uni_name);
            }

            public void DisplayDepartment()
            {
                Console.WriteLine("Name of the Department : " + department);
            }

            public void Display()
            {
                Displayname();
                DisplayUniname();
                DisplayDepartment();
            }
        }

        // child Class
        class SOE : College
        {
            private string Event;
            protected int Cost_of_Event;
            public string cordinator;

            public SOE(string name, string uni_name, string department, string Event_name, int Cost_of_Event, string cordinator)
                       : base(name, uni_name, department)
            {
                this.Event = Event_name;
                this.Cost_of_Event = Cost_of_Event;
                this.cordinator = cordinator;
            }
            public void DisplayEvent()
            {
                Console.WriteLine("Name of the Event : " + Event);
            }

            public void DisplayCose()
            {
                Console.WriteLine("Cost of the Event : " + Cost_of_Event);
            }

            public void DisplayCordinator()
            {
                Console.WriteLine("Name of the Cordinator : " + cordinator);
            }

            public void DisplaySOE()
            {
                DisplayEvent();
                DisplayCose();
                DisplayCordinator();
            }

        }

        public static void tutorial_4_3()
        {
            Console.WriteLine("Gauswami Yashgiri A." + "25SOEIT13018");
            SOE soe1 = new SOE("Global", "RKU", "Information Techonology", "Tech fest", 10000,"Yashgiri");
            soe1.Display();
            soe1.DisplaySOE();
        }
    }
}
