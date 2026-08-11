using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{

    class Product
    {
        int pcode;
        string pname;
        string mname;

        // parameterized constructor
        public Product(int pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        // static method
        public void display()
        {
            Console.WriteLine("Product Code: " + pcode);
            Console.WriteLine("Product Name: " + pname);
            Console.WriteLine("Manufacturer Name: " + mname);
        }
    }
    class t3_5
    {
        static void run(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Syntax Error:");
            }
            else
            {
                int pcd = Convert.ToInt32(args[0]);
                string pnm = args[1];
                string mnm = args[2];

                Product p = new Product(pcd, pnm, mnm);
                p.display();

                Console.Read();
            }
        }
    }
}

