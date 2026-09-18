using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _9
    {
        class Library
        {
            public static string name = "City Library";

            public string book;

            public Library(string book)
            {
                this.book = book;
            }

            public virtual void Display()
            {
                Console.WriteLine("Library: " + name);
                Console.WriteLine("Book: " + book);
            }
        }

        class ChildLibrary : Library
        {
            public string book = "New Book";

            public ChildLibrary(string book) : base(book)
            {
                this.book = book;
            }

            public override void Display()
            {
                base.Display();
                Console.WriteLine("Child Book: " + this.book);
            }

            public new void Show()
            {
                Console.WriteLine("new keyword: " + book);
            }
        }

        public static void nine()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            ChildLibrary l = new ChildLibrary("Python Programming");

            l.Display();
            l.Show();

            Console.WriteLine("Static: " + Library.name);
        }
    }
}
