using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial_4
{
    internal class six
    {
        abstract class Test

        {

            public int a;

            public abstract void A();

        }



        class Example1 : Test

        {

            public override void A()

            {

                Console.WriteLine("Example1.A");

                base.a++;

            }

        }

        class Example2 : Test

        {

            public override void A()

            {

                Console.WriteLine("Example2.A");

                base.a--;

            }

        }

            public static void sixes()

            {

            Console.WriteLine("Gauswami Yashgiri A." + "25SOEIT13018");

            // Reference Example1 through Test type.

            Test test1 = new Example1();

                test1.A();

                // Reference Example2 through Test type.

                Test test2 = new Example2();

                test2.A();

            }

    }
}
