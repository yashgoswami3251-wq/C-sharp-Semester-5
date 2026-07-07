using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language
{
    internal class armstrong
    {
        public static void arm()
        {
            int number, original, reminder, result = 0;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            original = number;
            while (number != 0)
            {
                reminder = number % 10; 
                result = result + (reminder * reminder * reminder);
                number = number / 10;
            }
            if(original == result)
            {
                Console.WriteLine("this is armstrong number");
            }
            else
            {
                Console.WriteLine("This is not armstrong number");
            }
            Console.ReadLine();
    }
}
}
