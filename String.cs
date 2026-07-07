using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace C_sharp_Language
{
    internal class String
    {
        public static void Upper()
        {
            string name, result = "";

            Console.WriteLine("Enter String value :");
            name = Console.ReadLine();

            Console.WriteLine("UpperCase Value is:" + name.ToUpper());
            Console.ReadLine();

            foreach (char c in name)
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    result += char.ToUpper(c);
                }
                else
                {
                    result += c;
                }
            }

            Console.WriteLine("Toggle case converted : " + result);
            Console.ReadLine();
        }
    }
}
