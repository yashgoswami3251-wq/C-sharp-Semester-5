using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language
{
    internal class Switch
    {
        public static void sw()
        {
            string number;
            Console.WriteLine("Enter a number : ");
            number = Console.ReadLine();

            foreach(char ch in number)
            {
                switch (ch)
                {
                    case '0':
                        Console.WriteLine("Zero");
                        break;
                    case '1':
                        Console.WriteLine("ONE");
                        break;
                    case '2':
                        Console.WriteLine("TWO");
                        break;
                    case '3':
                        Console.WriteLine("Three");
                        break;;;
                    case '4':
                        Console.WriteLine("FOUR");
                        break;
                    case '5':
                        Console.WriteLine("FIVE");
                        break;
                    case '6':
                        Console.WriteLine("SIX");
                        break;
                    case '7':
                        Console.WriteLine("SEVEN");
                        break;
                    case '8':
                        Console.WriteLine("EIGHT");
                        break;
                    case '9':
                        Console.WriteLine("NINE");
                        break;
                }
            }
        }
    }
}
