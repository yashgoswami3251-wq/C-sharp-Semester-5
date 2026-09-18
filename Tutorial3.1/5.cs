using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial3._1
{
    internal class _5
    {
        class Book
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public double Price { get; set; }

            public Book(int id, string title, string author, double price)
            {
                ID = id;
                Title = title;
                Author = author;
                Price = price;
            }

            public void Display()
            {
                Console.WriteLine(ID + " " + Title + " " + Author + " " + Price);
            }
        }

        public static void five()
        {
            Console.WriteLine("GAUSWAMI YASHGIRI 25SOEIT13018");
            Book b1 = new Book(1, "C# Basics", "Yashgiri", 500);
            Book b2 = new Book(2, "ASP.NET", "Pritesh", 700);

            b1.Display();
            b2.Display();

        }
    }
}
