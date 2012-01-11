using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using MyClasses;

namespace TheLibrary
{
    class main
    {
        internal static readonly string dateFormat = "d/M/y hh:mm:ss";
        internal static readonly CultureInfo calendarType = new CultureInfo("en-US");

        static void addClients(ref Library myLibrary)
        {
            do
            {
                Console.Write("\nPlease insert a name of a client for the library: ");
                int index = myLibrary.addClient(Console.ReadLine());
                Console.WriteLine(string.Format(index > 0 ? "Client no. {0} has been inserted successfully." : "Error in insert.", index));
                Console.Write("\nDo you want to add another client (yes/no)? ");
            } while ((Console.ReadLine() + 'n').TrimStart().StartsWith("y", true, calendarType));
        }
        static void addBooks(ref Library myLibrary)
        {
            do
            {
                string name, author;
                bookTypes bookType;
                Console.Write("\nPlease insert a name of a book for the library: ");
                if (string.IsNullOrWhiteSpace(name = Console.ReadLine()))
                    Console.WriteLine("Invalid book name! ");
                else
                {
                    Console.Write("Please insert a name of the book's author: ");
                    author = Console.ReadLine();
                    Console.WriteLine("\nThe books in our library are from this types:");
                    Console.WriteLine(Library.BookTypesTostring);
                    Console.WriteLine("Please insert the book's type number: ");
                    int theint = MyFunctions.StringToInt(Console.ReadLine());
                    bookType = (bookTypes)(theint);

                    if (bookType.ToString().Length <= 1)
                        Console.WriteLine("Invalid book type!");
                    else
                    {
                        ReadingBook.bookCategories category;
                        if (bookType == bookTypes.Reading)
                        {
                            Console.WriteLine("\nThe reading-books in our library are from this categories:");
                            Console.WriteLine(ReadingBook.BookCategoriesToString);
                            Console.WriteLine("Please insert the book's category number: ");
                            category = (ReadingBook.bookCategories)(MyFunctions.StringToInt(Console.ReadLine()));
                        }
                        else
                            category = 0;
                        if (category.ToString().Length <= 1)
                            Console.WriteLine("Invalid book category! ");
                        else
                        {
                            int BookID = myLibrary.addBook(name, author, bookType, category);
                            if (BookID > 0)
                            {
                                Console.WriteLine("Book no. {0} has been inserted successfully.", BookID);
                                Console.Write("How much copies of this book exist in the library (at least one)? ");
                                ((LibraryBook)myLibrary.Books[myLibrary.indexByBookID(BookID)]).Copies = 
                                    (uint)MyFunctions.StringToInt(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine(string.Format("Error in insert."));
                            }
                        }
                    }
                }
                Console.Write("Do you want to add another book (yes/no)? ");
            } while ((Console.ReadLine() + 'n').TrimStart().StartsWith("y", true, calendarType));
        }
        static void action(ref Library myLibrary)
        {
            while (myLibrary.Books.Count * myLibrary.Clients.Count != 0)
            {
                Console.WriteLine("\nIf you want to boroow a book - Insert 1 or \"b\".");
                Console.WriteLine("If you want to return a book - Insert 2 or \"r\".");
                Console.WriteLine("If you want to get information of the library - Insert 3 or \"i\".");
                Console.WriteLine("If you have finished - Insert 0 or \"f\".");
                char selector = (Console.ReadLine() + "0").TrimStart().ToLower()[0];
                bool taking;
                if (selector == '1' || selector == 'b')
                    taking = true;
                else if (selector == '2' || selector == 'r')
                    taking = false;
                else if (selector == '3' || selector == 'i')
                {
                    main.printLibrary(myLibrary);
                    continue;
                }
                else
                    break;
                Console.Write("Insert client-ID: ");
                int client = MyFunctions.StringToInt(Console.ReadLine());
                client = myLibrary.indexByClientID(client);
                if (client < 0)
                {
                    Console.WriteLine("This client does not exists in the library");
                    continue;
                }
                Console.Write("Insert book-ID: ");
                int book = MyFunctions.StringToInt(Console.ReadLine());
                book = myLibrary.indexByBookID(book);
                string message, number;
                uint expiration;
                if (book < 0)
                {
                    Console.WriteLine("This book does not exists in the library");
                    continue;
                }
                if (taking)
                {
                    if (myLibrary.Books[book] is EnrichmentBook)
                    {
                        Console.WriteLine("You want to borrow an enrichment-book. Therefore you have to put a deposit {0} NIS.", 
                            EnrichmentBook.Deposit);
                        Console.WriteLine("If you want to do it with a credit-card or with a check - insert its number.");
                        Console.WriteLine("If you want to cancel the borowwing - insert \"-1\".");
                        number = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(number) || number[0] == '-')
                            continue;
                        number = number.Trim();
                        if (MyFunctions.StringToInt(number) <= 0)
                        {
                            Console.WriteLine("Invalid number. You can't borrow this book without a deposit!");
                            continue;
                        }

                        Console.WriteLine("If this is a credit-card number - insert the year of expiration");
                        Console.WriteLine("If this is a check number - insert 0.");
                        expiration = (uint)MyFunctions.StringToInt(Console.ReadLine());
                        if (expiration > 0)
                        {
                            Console.Write("insert the month of expiration (only numbers): ");
                            expiration = expiration * 12 + (uint)MyFunctions.StringToInt(Console.ReadLine());
                        }
                    }
                    else
                    {
                        number = ""; 
                        expiration = 0;
                    }
                    myLibrary.borrow(out message, client, book, number, expiration);
                }
                else
                {
                    myLibrary.returnBook(out message, client, book);
                }
                Console.WriteLine(message);
            }
            if (myLibrary.Clients.Count == 0)
                Console.WriteLine("The library has no clients...");
            if (myLibrary.Books.Count == 0)
                Console.WriteLine("The library has no books...");
        }
        static void printLibrary(Library myLibrary,ConsoleColor color = ConsoleColor.Cyan)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + myLibrary);
            Console.ForegroundColor = color;
        }

        static int Main(string[] args)
        {
            Library myLibrary = new Library();
            if (myLibrary == null)
            {
                Console.WriteLine("Error in creation Library!");
                return 1;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("B.H.");
            Console.WriteLine("The time now is: {0}\n", DateTime.Now.ToString(main.calendarType));
            Console.ForegroundColor = ConsoleColor.Red;
            main.addClients(ref myLibrary);
            Console.ForegroundColor = ConsoleColor.Magenta;
            main.addBooks(ref myLibrary);
            main.printLibrary(myLibrary);
            main.action(ref myLibrary);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The time now is: {0}\n", DateTime.Now.ToString(main.calendarType));
            Console.WriteLine("Good bye...");
            Console.ResetColor();
            return 0;
        }
    }
}
