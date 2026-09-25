using System;

namespace C_sharp_Language.Tutorial_4
{
    internal class four
    {
        class StaticVar
        {
            public static int num;

            public void count()
            {
                num++;
            }

            // Method to return num
            public static int getNum()
            {
                return num;
            }
        }

        public static void tutorial_4_4()
        {

            StaticVar s = new StaticVar();

            s.count();
            s.count();
            s.count();

            Console.WriteLine("Gauswami Yashgiri A." + "25SOEIT13018");
            Console.WriteLine("Variable num: {0}",StaticVar.getNum());
            Console.ReadKey();
        } 
    }
}