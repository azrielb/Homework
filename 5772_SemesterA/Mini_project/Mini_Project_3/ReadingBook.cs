using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace municipalyLibraries
{
    class ReadingBook : LibraryBook
    {
        internal enum bookCategories { Unknown, ActionAdventure, Detective, Horror, Mystery, ScienceFiction, Western, Inspirational, Comics }

        private static readonly uint BORROWING_LENGTH = 30;
        private DateTime lastBorrowing;
        private readonly ReadingBook.bookCategories bookCategory;
        private static string bookCategoriesToString;

        public ReadingBook(string name, string author = "", ReadingBook.bookCategories Category = ReadingBook.bookCategories.Unknown)
            : base(name, author)
        {
            this.bookCategory = Category;
            this.lastBorrowing = DateTime.Now;
        }

        public DateTime LastBorrowing
        {
            get { return lastBorrowing; }
        }
        private ReadingBook.bookCategories BookCategory
        {
            get { return bookCategory; }
        }
        public static string BookCategoriesToString
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ReadingBook.bookCategoriesToString))
                {
                    ReadingBook.bookCategoriesToString = "";
                    for (ReadingBook.bookCategories index = 0; index.ToString().Length > 1; ++index)
                        ReadingBook.bookCategoriesToString += string.Format("{0}. {1}\t", (int)index, index);
                }
                return bookCategoriesToString;
            }
        }


        public override bool borrow(out string message, string temp1 = "", uint temp2 = 0)
        {
            this.lastBorrowing = DateTime.Now;
            message = string.Format("OK, you have to return the book until {0}. ",
                this.lastBorrowing.AddDays(ReadingBook.BORROWING_LENGTH).ToString(program.calendarType));
            return true;
        }

        public override string ToString()
        {
            return string.Format("{0} Category: {1}. Last borrowing: {2}.", 
                base.ToString(), this.bookCategory, this.lastBorrowing.ToString(program.calendarType));
        }
    }
}
