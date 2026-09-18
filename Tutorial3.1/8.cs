using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _8
    {
        abstract class Payment
        {
            public abstract void CalculatePayment();
        }
        class Cash : Payment
        {
            public override void CalculatePayment()
            {
                Console.WriteLine("Cash Payment: 5000");
            }
        }
        class Card : Payment
        {
            public override void CalculatePayment()
            {
                Console.WriteLine("Card Payment: 5000");
            }
        }
        class UPI : Payment
        {
            public override void CalculatePayment()
            {
                Console.WriteLine("UPI Payment: 5000");
            }
        }
        public static void eight()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            Payment p1 = new Cash();
            Payment p2 = new Card();
            Payment p3 = new UPI();
            p1.CalculatePayment();
            p2.CalculatePayment();
            p3.CalculatePayment();
        }
    }
}
