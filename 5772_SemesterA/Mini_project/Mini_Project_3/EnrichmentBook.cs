using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace municipalyLibraries
{
    class EnrichmentBook : LibraryBook
    {
        private static readonly uint BORROWING_LENGTH = 2;
        private static readonly double deposit = 100;
        private DateTime lastBorrowing;
        private string checkNumber;
        private uint expirationDate;

        public EnrichmentBook(string name, string author = "")
            : base(name, author)
        {
            this.lastBorrowing = DateTime.Now;
            this.checkNumber = "";
            this.expirationDate = 0;
        }

        public static double Deposit
        {
            get { return EnrichmentBook.deposit; }
        }
        public DateTime LastBorrowing
        {
            get { return lastBorrowing; }
        }

        /// <summary>
        /// This function should be called when the book is borrowed
        /// </summary>
        /// <param name="nubmer">
        /// The check's number or credit-card number
        /// </param>
        /// <param name="expiration">
        /// if the client pays with a check - 0
        /// else - the credit-card expiration date of the credit-card, in the formula: (year * 12 + month) 
        /// </param>
        /// <returns>
        /// true when success, false when the credit card is expired
        /// </returns>
        public override bool borrow(out string message, string nubmer, uint expiration)
        {
            if (expiration != 0 && DateTime.Now >= new DateTime((int)(expiration / 12), (int)(expiration % 12), 1))
            {
                message = "The credit card is expired! ";
                return false;
            }
            this.lastBorrowing = DateTime.Now;
            this.expirationDate = expiration;
            this.checkNumber = nubmer;
            message = string.Format("OK, your deposit ({0}NIS) was received and you have to return the book until {1}. ", 
                EnrichmentBook.deposit,
                this.lastBorrowing.AddDays(EnrichmentBook.BORROWING_LENGTH).ToString(program.calendarType));
            return true;
        }
        public override bool returnBook()
        {
            this.expirationDate = 0;
            this.checkNumber = "";
            return true;
        }
        public override string ToString()
        {
            string ret = string.Format("{0} Last borrowing: {1}.{2}", 
                base.ToString(),
                this.lastBorrowing.ToString(program.calendarType),
                this.checkNumber == "" ? "" : string.Format(" {0} number: {1}.{2}",
                    this.expirationDate == 0 ? "Check" : "Credit-card",
                    this.checkNumber,
                    this.expirationDate == 0 ? "" : string.Format("Expiration date {0}/{1}",
                        this.expirationDate % 12, this.expirationDate / 12
                    )
                )
            );
            return ret;
        }
    }
}
