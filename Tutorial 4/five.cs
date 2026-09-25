using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial_4
{
    internal class five
    {

public class A // This is the base class.

    {

        public A(int value)

        {

            // Executes some code in the constructor.

            Console.WriteLine("Base constructor A()");

        }

    }



    public class B : A // This class derives from the previous class.

    {

        public B(int value) : base(value)

        {

            // The base constructor is called first.

            // ... Then this code is executed.

            Console.WriteLine("Derived constructor B()");

        }

    }
        public static void fives()

        {

            // Create a new instance of class A, which is the base class.

            // ... Then create an instance of B, which executes the base constructor.

            Console.WriteLine("Gauswami Yashgiri A." + "25SOEIT13018");
            A a = new A(0);

            B b = new B(1);

        }

    
}
}
