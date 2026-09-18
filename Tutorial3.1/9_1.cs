using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _9_1
    {
        private int issuedBooks;

        public void IssueBook()
        {
            issuedBooks++;
        }

        public void ReturnBook()
        {
            if (issuedBooks > 0)
                issuedBooks--;
        }

        public void Display()
        {
            Console.WriteLine("Issued Books: " + issuedBooks);
        }
    
    public static void nine_one()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            _9_1 a1 = new _9_1();
            _9_1 a2 = new _9_1();

            a1.IssueBook();
            a1.IssueBook();
            a1.ReturnBook();

            a2.IssueBook();

            Console.WriteLine("Account 1:");
            a1.Display();

            Console.WriteLine("Account 2:");
            a2.Display();

        }

    }
}
