using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_13
    {

        class ProductDetaild
        {
            public int productid { get; set; }

            public string name { get; set; }

            public double price { get; set; }

            public int quantity { get; set; }


            public double Calculatebill()
            {
                return price * quantity;
            }

            public void Displaybill()
            {
                Console.WriteLine("------Product Details------");
                Console.WriteLine("Product ID: " + productid);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Price: " + price);
                Console.WriteLine("Quantity: " + quantity);
                Console.WriteLine("Total Bill: " + Calculatebill());
            }
        }

        public static void product()
        {
            ProductDetaild p1 = new ProductDetaild();
            Console.WriteLine("Enter Product ID: ");
            p1.productid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name: ");
            p1.name = Console.ReadLine();

            Console.WriteLine("Enter Product Price: ");
            p1.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Product Quantity: ");
            p1.quantity = Convert.ToInt32(Console.ReadLine());

            p1.Displaybill();
            Console.ReadLine();
        }
    }
}
