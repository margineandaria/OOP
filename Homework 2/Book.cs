using System;

namespace LibrarySystem
{
    public class Book
    {
        // Fields
        public string title;
        public string author;
        public int pages;
        public bool isCheckedOut;

        // Constructor with title and author
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.pages = 100;      // Default value for pages
            this.isCheckedOut = false;
        }

        // Overloaded constructor with title, author, and pages
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.isCheckedOut = false;
        }

        // Method to check out the book
        public void CheckOut()
        {
            isCheckedOut = true;
        }

        // Method to return the book
        public void ReturnBook()
        {
            isCheckedOut = false;
        }

        // Override ToString() to display book details
        public override string ToString()
        {
            string status = isCheckedOut ? "Yes" : "No";
            return $"Title: {title}, Author: {author}, Pages: {pages}, Checked Out: {status}";
        }
    }
}
