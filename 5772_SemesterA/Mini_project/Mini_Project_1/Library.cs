using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheLibrary
{
    internal enum bookTypes { Unknown, Enrichment, Reading }

    class Library
    {
        private ArrayList books;
        private ArrayList clients;
        private static string bookTypesTostring;

        public Library()
        {
            books = new ArrayList();
            clients = new ArrayList();
        }

        public ArrayList Books
        {
            get { return books; }
            set { books = value; }
        }
        public ArrayList Clients
        {
            get { return clients; }
            set { clients = value; }
        }
        public static string BookTypesTostring
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Library.bookTypesTostring))
                {
                    Library.bookTypesTostring = "";
                    for (bookTypes index = 0; index.ToString().Length > 1; ++index)
                        Library.bookTypesTostring += string.Format("{0}. {1}\t", (int)index, index);
                }
                return Library.bookTypesTostring;
            }
        }
        public int indexByBookID(int bookID)
        {
            int index = books.Count - 1;
            for (; index >= 0; --index)
            {
                if (((LibraryBook)books[index]).BookID == bookID)
                    break;
            }
            return index;
        }
        public int indexByClientID(int clientID)
        {
            int index = Clients.Count - 1;
            for (; index >= 0; --index)
            {
                if (((LibraryClient)Clients[index]).ClientID == clientID)
                    break;
            }
            return index;
        }

        public int addBook(string name, string author = "", bookTypes bookType = bookTypes.Unknown,
            ReadingBook.bookCategories Category = ReadingBook.bookCategories.Unknown)
        {
            LibraryBook newBook;
            switch (bookType)
            {
                case bookTypes.Unknown:
                    newBook = new LibraryBook(name, author);
                    break;
                case bookTypes.Enrichment:
                    newBook = new EnrichmentBook(name, author);
                    break;
                case bookTypes.Reading:
                    newBook = new ReadingBook(name, author, Category);
                    break;
                default:
                    newBook = null;
                    break;
            }
            if (newBook == null || newBook.BookID == 0)
                return -1;
            int counter = books.Count;
            books.Add(newBook);
            return (books.Count == counter + 1) ? newBook.BookID : -1;
        }
        public int addClient(string name)
        {
            LibraryClient newClient;
            newClient = new LibraryClient(name);
            if (newClient == null || newClient.ClientID == 0)
                return -1;
            int counter = clients.Count;
            clients.Add(newClient);
            return (clients.Count == counter + 1) ? newClient.ClientID : -1;
        }

        public bool borrow(out string message, int clientIndex, int bookIndex, string nubmer = "", uint expiration = 0)
        {
            LibraryBook book = (LibraryBook)books[bookIndex];
            message = book == null ? "The book does not exists! " : "";
            LibraryClient client = (LibraryClient)clients[clientIndex];
            if (client == null)
            {
                message += "The client does not exists! ";
            }
            if (message != "") return false;
            if (!client.borrow(book.BookID))
            {
                message = string.Format("You have no permission to take more than {0} books! ", client.BooksPerClient);
                return false;
            }
            if (book.borrow(out message, nubmer, expiration))
                return true;
            if (!client.returnBook(book.BookID))
                message += " We are very sorry, but your borrowing has been written, and it has not been deleted! ";
            return false;
        }
        public bool returnBook(out string message, int clientIndex, int bookIndex)
        {
            LibraryBook book = (LibraryBook)books[bookIndex];
            message = book == null ? "The book does not exists! " : "";
            LibraryClient client = (LibraryClient)clients[clientIndex];
            if (client == null)
            {
                message += "The client does not exists! ";
            }
            if (message != "") return false;
            if (!client.returnBook(book.BookID))
            {
                message = "The book was not taken by this user! ";
                return false;
            }
            if (!book.returnBook())
            {
                client.borrow(book.BookID);
                message = "Error in the book's returning! ";
                return false;
            }
            message = "The book has been returned successfully. ";
            return true;
        }

        public override string ToString()
        {
            string ret = string.Format("The library containes:\n\n{0} clients:\n", clients.Count);
            foreach (LibraryClient client in clients)
                ret += client + "\n";
            ret += string.Format("\n{1} books:\n", ret, books.Count);
            foreach (LibraryBook book in books)
                ret += book + "\n";
            return ret;
        }
    }
}
