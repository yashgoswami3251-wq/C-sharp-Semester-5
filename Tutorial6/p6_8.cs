using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{

    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
            
        }
    }

    class BankAcc
    {
        double balance;
        public void withdraw(double amount)
        {
            if(amount > balance)
            {
                throw new InsufficientBalanceException("Error:Amount withdraw failed");
            }
            balance += amount;
            Console.WriteLine("Current Balance:" + balance);
            Console.WriteLine("Amount withdraw successfully");
        }
    }
    internal class p6_8
    {
        public static void program()
        {
            BankAcc b = new BankAcc();
            try
            {
                Console.WriteLine("Enter Amount to withdraw");
                double amount = Convert.ToDouble(Console.ReadLine());

                b.withdraw(amount);
            }
            catch(InsufficientBalanceException ex)
            {
                Console.WriteLine("Error .."+ex);
            }
        }
    }
}
