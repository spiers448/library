using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
        class Book
        {
            string Title;
            string Author;
            int ISBN;

            public void displayInfo()
            {
                //output book information
                Console.WriteLine($"Book title: {Title}");
                Console.WriteLine($"Book Author: {Author}");
                Console.WriteLine($"Book ISBN: {ISBN}\n");
            }

            public Book(string bookTitle, string bookAuthor, int bookISBN)
            {
                Title = bookTitle;
                Author = bookAuthor;
                ISBN = bookISBN;
            }
        }
}
