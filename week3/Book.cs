using System;
using System.Collections.Generic;
using System.Text;

namespace week3
{
    internal class Book
    {
        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (!value.Any(char.IsDigit)) {
                    author = value;
                } else {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set { 
                if (value != "") {
                    isbn = value;
                } else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        // Constructor to initialize/add book properties
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
        }

        // Method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {title}");
            Console.WriteLine($"Book author: {author}");
            Console.WriteLine($"Book ISBN: {isbn}");
            Console.WriteLine();
        }



    }
}
