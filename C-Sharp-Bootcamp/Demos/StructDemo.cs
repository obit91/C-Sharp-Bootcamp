using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Bootcamp.Demos.Structs
{

    /**
     * Main differences between structures and classes:
     * - Classes are reference type whilst structs are value type.
     * - Structures do not support inheritance.
     * - Structures have an auto-generated default constructor.
     * - Structures can be assigned without the New operator,  however they will not be accessible until all fields have been set.
     */

    struct Book
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void SetBookData(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void Display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Subject: {0}", subject);
            Console.WriteLine("Book_id: {0}", book_id);
        }
    };

    struct NoNewBook
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

        public void SetBookData(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void Display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Subject: {0}", subject);
            Console.WriteLine("Book_id: {0}", book_id);
        }
    };

    public class StructDemo
    {

        internal static void InnerMain()
        {
            Console.WriteLine("Creating a book with the New operator.");
            Book book = new Book();

            book.SetBookData("C# demo", "Ohad Beltzer", "Playing around with structs.", 12321);
            book.Display();

            Console.WriteLine();

            Console.WriteLine("Creating a book without the New operator.");
            NoNewBook noNewBook;

            // The following line doesn't compile.
            // noNewBook.Display();

            noNewBook.title = "C# demo";
            noNewBook.author = "Ohad Beltzer";
            noNewBook.subject = "Playing around with structs.";
            noNewBook.book_id = 12321;
            noNewBook.Display();
        }
    }
}
