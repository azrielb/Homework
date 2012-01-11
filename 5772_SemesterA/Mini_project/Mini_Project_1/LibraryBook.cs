using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheLibrary
{
    class LibraryBook
    {
        private static int counter = 0;

        private readonly int bookID;
        private readonly string bookName;
        private readonly string authorName;
        private uint copies;

        public LibraryBook(string name, string author = "")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                this.bookID = 0;
                this.bookName = "";
            }
            else
            {
                this.bookID = ++LibraryBook.counter;
                this.bookName = name.Trim();
            }
            this.authorName = string.IsNullOrWhiteSpace(author) ? "Unknown" : author.Trim();
            this.copies = 1;
        }

        public int BookID
        {
            get { return bookID; }
        }
        public static int Counter
        {
            get { return LibraryBook.counter; }
        }

        public uint Copies
        {
            get { return this.copies; }
            set
            {
                if (value > this.copies)
                    this.copies = value;
            }
        }

        public string AuthorName
        {
            get { return this.authorName; }
        }

        public string BookName
        {
            get { return this.bookName; }
        }

        public virtual bool borrow(out string message, string temp1 = "", uint temp2 = 0)
        {
            message = "OK, please do not forget to return the book.";
            return true;
        }
        public virtual bool returnBook()
        {
            return true;
        }

        override public string ToString()
        {
            return string.Format("ID: {0}. Book name: {1}. Author: {2}. Copies: {3}.",
                this.bookID, this.bookName, this.authorName, this.copies);

        }
    }
}
