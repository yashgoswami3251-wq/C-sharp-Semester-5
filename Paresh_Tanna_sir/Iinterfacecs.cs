using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Paresh_Tanna_sir
{

    //Interface
    //what a class must do but not how it does
    //
    internal class Iinterfacecs
    {
        interface employee
        {
            void salary();
        }

        class Regularemployee : employee
        {
            public void salary()
            {
                Console.WriteLine("Show method from RegularEmployee");
            }
        }

        public static void program()
        {
            Regularemployee e1 = new Regularemployee();
            e1.salary();
        }
    }
}
