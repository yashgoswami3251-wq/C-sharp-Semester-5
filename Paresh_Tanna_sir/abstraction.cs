using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Paresh_Tanna_sir
{
    //abstract
    //highlights the features only
    //abstract keyword used within class and methods
    //you can not create an object of abstract class
    //within abstract class you can put data members , abstract methods,
    //non abstract (concreate) methods, constructors,
    //you can use abstract class as a parent class
    //All the abstract methods must be implemented by its child class
    //All the abstract methods are implecitly virtual , means not need to write virtual keyword for abstract methods
    internal class abstraction
    {
        abstract class employee
        {
            public abstract void salary();
            public void display()
            {
                Console.WriteLine("Hello from employee");
            }
        }

        class RegularEmployee : employee
        {
            public override void salary()
            {
                Console.WriteLine("Show method from RegularEmployee");
            }
        }

        public static void program()
        {
            RegularEmployee e1 = new RegularEmployee();
            e1.salary();
        }
    }
}
