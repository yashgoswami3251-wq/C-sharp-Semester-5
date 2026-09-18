using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _6
    {
        class Vehicle
        {
            protected string number, model;

            public Vehicle(string n, string m)
            {
                number = n;
                model = m;
            }
        }

        class Car : Vehicle
        {
            string color;

            public Car(string n, string m, string c) : base(n, m)
            {
                color = c;
            }

            public void Display()
            {
                Console.WriteLine("Vehicle No: " + number);
                Console.WriteLine("Model: " + model);
                Console.WriteLine("Color: " + color);
            }
        }
        public static void six()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            Car c = new Car("GJ04AB7856", "AUDI", "Blue");
            c.Display();
        }
    }
}
