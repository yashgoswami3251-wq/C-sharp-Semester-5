using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_17
    {
        // Base class

        class shape
        {
            private double area;

            public virtual void calculateArea()
            {
                Console.WriteLine("Calculating area of shape");
            }

        }

        class circle : shape
        {
            public override void calculateArea()
            {
                Console.WriteLine("Enter Radius of Circle");
                double radius = Convert.ToDouble(Console.ReadLine());

                double area = Math.PI * radius * radius;
                Console.WriteLine("Area of Circle is : " + area);
            }
        }

        class rectangle : shape
        {
            public override void calculateArea()
            {
                Console.WriteLine("Enter Length of Rectangle");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Width of Rectangle");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = length * width;
                Console.WriteLine("Area of Rectangle is : " + area);
            }

        }

        class triangle : shape
        {
            public void calculateArea()
            {
                Console.WriteLine("Enter Base of Triangle");
                double baseLength = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Height of Triangle");
                double baseHeight = Convert.ToDouble(Console.ReadLine());

                double area = 0.5 * baseLength * baseHeight;
                Console.WriteLine("Area of Triangle is : " + area);
            }
        }

        public static void method()
        {

            circle c = new circle();
            c.calculateArea();

            rectangle r = new rectangle();
            r.calculateArea();

            triangle t = new triangle();
            t.calculateArea();

        }
    }
}
