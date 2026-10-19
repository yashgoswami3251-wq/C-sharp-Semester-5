using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    class BankAccount
    {
        public delegate void DepositeHandler();
        public event DepositeHandler DepositeEvent;

        public void Deposite(double amount)
        {
            Console.WriteLine("Amount Deposited:" + amount);
            if (DepositeEvent != null)
            {
                DepositeEvent();
            }
        }
    }

    internal class p_6_5
    {
        static void DepositMessage()
        {
            Console.WriteLine("Event: Amount has been deposited successfully.");
        }


        public static void program()
        {
            BankAccount account = new BankAccount();
            account.DepositeEvent += DepositMessage;
            account.Deposite(5000);
        }
    }
}
