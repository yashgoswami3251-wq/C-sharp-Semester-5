using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    internal class p_6_7
    {
        public static void progra()
        {
            try
            {
                Console.WriteLine("Enter a number ");
                int a = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Error :" + ex);
            }
            finally
            {
                Console.WriteLine("Formate Exception inmplemented");
            }
        }
    }
}
