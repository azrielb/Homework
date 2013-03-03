using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheLibrary
{

    class LibraryClient
    {
        private static int counter = 0;
        private static readonly uint MAX_BOOKS_PER_CLIENT = 2;

        private readonly string clientName;
        private readonly int clientID;
        private uint booksPerClient;
        private int[] books = new int[LibraryClient.MAX_BOOKS_PER_CLIENT];

        public LibraryClient(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                this.clientID = 0;
                this.clientName = "";
            }
            else
            {
                this.clientID = ++LibraryClient.counter;
                this.clientName = name.Trim();
            }
            for (uint index = 0; index < this.booksPerClient; ++index) this.books[index] = 0;
            this.booksPerClient = 0;
        }

        public static int Counter
        {
            get { return LibraryClient.counter; }
        }

        public int ClientID
        {
            get { return clientID; }
        }
        public string ClientName
        {
            get { return clientName; }
        }
        public uint BooksPerClient
        {
            get { return booksPerClient; }
        }

        public bool permission()
        {
            return (numBooksPermission() > 0);
        }
        private uint numBooksPermission()
        {
            return LibraryClient.MAX_BOOKS_PER_CLIENT - this.booksPerClient;
        }
        public bool borrow(int bookID)
        {
            if (!permission()) 
                return false;
            this.books[(this.booksPerClient)++] = bookID;
            return true;
        }
        /// <summary>
        /// This function is called when the client returns a book
        /// </summary>
        /// <param name="bookID">
        /// The book's ID
        /// </param>
        /// <returns>
        /// TRUE on success, FALSE when this book is not borrowed by this client.
        /// </returns>
        public bool returnBook(int bookID)
        {
            for (uint index = 0; index < this.booksPerClient; ++index) if (this.books[index] == bookID)
                {
                    // this line place the last-item in the current place.
                    this.books[index] = this.books[--this.booksPerClient];
                    return true;
                }
            return false;
        }

        public override string ToString()
        {
            string ret = string.Format("Client ID: {0}. Client name: {1}.", this.clientID, this.clientName);
            if (booksPerClient > 0) for (uint index = 0; index < booksPerClient; ++index)
                    ret += string.Format(" Book{0} ID: {1}", index + 1, books[index]);
            else
                ret += " This user has no books.";
            return ret;
        }
    }
}
