using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
        class Book
        {
            private string title;
            private string author;
            private int isbn;

            //allow title access
            public string Title
            {
                get { return title; } //get method 
                set { title = value; } //set method
            }
           //allow author access
            public string Author
            {
                get { return author; } //get method 
                set { author = value; } //set method
            }
            //allow isbn access
            public int ISBN
            {
                get { return isbn; } //get method 
                set { isbn = value; } //set method
            }

        public void displayInfo()
            {
                //output book information
                Console.WriteLine($"Book title: {Title}");
                Console.WriteLine($"Book Author: {Author}");
                Console.WriteLine($"Book ISBN: {ISBN}\n");
        }

            public Book(string bookTitle, string bookAuthor, int bookISBN)
            {
                this.title = bookTitle;
                this.author = bookAuthor;
                this.isbn = bookISBN;
            }
        }
}
