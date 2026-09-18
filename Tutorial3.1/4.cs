using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _4
    {
        class Product
        {
            private int code;
            private string name;
            private double price;

            public Product(int c, string n, double p)
            {
                code = c;
                name = n;
                price = p;
            }

            public double Discount()
            {
                return price * 0.10;
            }

            public void Display()
            {
                Console.WriteLine("Code: " + code);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Price: " + price);
                Console.WriteLine("Discount: " + Discount());
                Console.WriteLine("Final Price: " + (price - Discount()));
            }
        }

        public static void four()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            Product p = new Product(101, "Laptop", 50000);
            p.Display();
        }

    }
}
