using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_2
    {
        class clock
        {
            private int hour;
            private int min;
            private int sec;

            public clock(){           // Empty Contructor
                hour = 12;
                min = 0;
                sec = 0;
            }

            public clock(int h, int m, int s)
            {
                hour = h;
                min = m;
                sec = s;
            }

            public void IncreamenTime()
            {
                sec++;
                if(sec == 60) {
                    sec = 0;
                    min++;

                    if(min == 60)
                    {
                        min = 0;
                        hour++;

                        if(hour == 24)
                        {
                            hour = 0;
                        }
                    }
                }
            }

            public void DisplayTime()
            {
                Console.WriteLine("Time: {0:D2}:{1:D2}:{2:D2}", hour, min, sec);
            }

            public int GetHour() {
                return hour;
            }

            public int getMin() {
                return min;
            }

            public int getSec() {
                return sec;
            }

        }

        public static void time()
        {
            clock c1 = new clock();
            Console.WriteLine("Default Time:");
            c1.DisplayTime();

            clock c2 = new clock(10,59,00);
            Console.WriteLine("Initial Time:");
            c2.DisplayTime();

            c2.IncreamenTime();
            Console.WriteLine("After one Second");
            c2.DisplayTime();

            c2.IncreamenTime();
            Console.WriteLine("After 2 Second");
            c2.DisplayTime();


            Console.WriteLine("Hour" + c2.GetHour());
            Console.WriteLine("Minute" + c2.getMin());
            Console.WriteLine("Second" + c2.getSec());

            Console.WriteLine("25SOEIT13018 Yashgiri Gauswami");

        }

    }
}
