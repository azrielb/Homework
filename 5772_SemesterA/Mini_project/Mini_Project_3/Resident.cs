using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace municipalyLibraries
{
    enum Sex : byte { Male, Female }
    class Resident : LibraryClient
    {
        private readonly Sex theSex;
        bool hasJob;
        DateTime bornDate;
        ulong residentID;

        public Sex TheSex
        {
            get { return theSex; }
        }

        public Resident(string name, Sex s, bool job, DateTime born, ulong ID)
            : base(name)
        {
            theSex = s;
            hasJob = job;
            bornDate = born;
            residentID = ID;
        }
        public override string ToString()
        {
            string ret = string.Format("Client ID: {0}. Name: {1}. {2} was born in {3}. Resident ID: {4}. {2} has {5} job.",
                ClientID, ClientName, theSex == Sex.Male ? "He" : "She", bornDate.ToString(program.calendarType), residentID, hasJob ? "a" : "no");
            if (BooksPerClient > 0)
                for (uint index = 0; index < BooksPerClient; ++index)
                    ret += string.Format(" Book{0} ID: {1}", index + 1, Books(index));
            else
                ret += " This user has no books.";
            return ret;
        }

    }
}
