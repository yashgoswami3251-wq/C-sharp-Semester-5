using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Paresh_Tanna_sir
{
    class A
    {
        public A()
        {
            Console.WriteLine("From A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("From B");
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine("From C");
        }
        
    }

    class D : C
    {
       
        public D()
        {

        }
        public D(int x)
        {
            
        }
    }
    internal class constructor
    {
        public static void program()
        {
            D obj = new D();
        }
    }
}
