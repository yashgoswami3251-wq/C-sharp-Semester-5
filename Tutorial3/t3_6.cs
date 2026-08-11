using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_6
    {
        private double length;   // Length of a line

        public t3_6()

        {

            //………………………………Missing statement-1……………………………….// 
            setLength(10);
            //………………………………Missing statement-2……………………………….// 
            Console.WriteLine("Object created length:" + getLength());

        }
        public void setLength(double len)

        {

            //………………………………Missing statement-3……………………………….//      
            length = len;



        }

        public double getLength()

        {

            //………………………………Missing statement-4……………………………….//
            return length;

        }

    }



    class TestLine

    {

        public static void LineRun(string[] args)

        {

            t3_6 line = new t3_6();

            // set line length
            line.setLength(10);

            Console.WriteLine("Length of line : {0}", line.getLength());

            // set line length
            line.setLength(6);

            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.Read();
        }


    }
}
