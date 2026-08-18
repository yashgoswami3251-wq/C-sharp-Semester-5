using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3
{
    internal class t3_11
    {
        class bankaccount
        {
            private int accno;
            private string accholdername;
            private double bankbalance;

            public bankaccount(int ano, string name, double balance) {
                accno = ano;
                accholdername = name;
                bankbalance = balance;
            }

            // custom method

           public void Deposit(double amount) 
            {
                bankbalance += amount;
                Console.WriteLine("Amount deposit Successfully."+amount );
            }

            public void withdrwa(double amout)
            {
                if(amout > bankbalance)
                {
                    Console.WriteLine("Insufficient Balance.");
                }
                else
                {
                    bankbalance -= amout;
                    Console.WriteLine("Amount withdraw Successfully."+amout);

                }
            }

            public void balanceenquery()
            {
                Console.WriteLine("--------Balance Enquiry--------");
                Console.WriteLine("Account Number : " + accno);
                Console.WriteLine("Account Holder Name : " + accholdername);
                Console.WriteLine("Account Balance : " + bankbalance);
            }
        }

        public static void bank()
        {
            Console.WriteLine("Enter Accno.");
            int accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Acc holder name.");
            string accHOLDER = Console.ReadLine();
            
            Console.WriteLine("Enter bank balance.");
            double bankblance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Deposit.");
            double deposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter withdraw.");
            double withdraw = Convert.ToDouble(Console.ReadLine());

            bankaccount b1 = new bankaccount(accno, accHOLDER, bankblance);
            Console.WriteLine("1st User Details");
            b1.Deposit(deposit);
            b1.withdrwa(withdraw);
            b1.balanceenquery();

            
        }
    }
}
