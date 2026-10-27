using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Paresh_Tanna_sir
{
    class Box<T>
    {
        T value;

        // 1. Set value
        public void SetValue(T value)
        {
            this.value = value;
        }

        // 2. Get value
        public T GetValue()
        {
            return value;
        }

        // 3. Display value
        public void Display()
        {
            Console.WriteLine("Value: " + value);
        }
    }
    internal class generic
    {
        public static void program()
        {
            Box<int> b1 = new Box<int>();
            b1.SetValue(100);
            b1.Display();

            // String type
            Box<string> b2 = new Box<string>();
            b2.SetValue("Yash");
            b2.Display();

            // Get value
            Console.WriteLine(b1.GetValue());
        }
    }
}
