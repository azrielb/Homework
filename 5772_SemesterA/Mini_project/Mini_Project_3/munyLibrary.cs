using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ABClasses;

namespace municipalyLibraries
{
    class muniLibrary : Library
    {
        string name;
        public event EventHandler NewClientAdded;

        public muniLibrary(ref Municipality city, string n)
        {
            city.NewResidents += new EventHandler(muny_NewResidents);
            name = n;
        }

        void muny_NewResidents(object sender, EventArgs e)
        {
            if (!(sender is Municipality) || !(e is EventArgs<Resident[]>)) 
                return;
            foreach(Resident newResident in ((EventArgs<Resident[]>)e).Data)
                this.addClient(newResident);
        }

        public override int addClient(LibraryClient newClient)
        {
            int theNewClient = base.addClient(newClient);
            if (theNewClient > 0 && NewClientAdded != null) NewClientAdded(this, new EventArgs<string>(string.Format("The user '{0}' has been added to the library '{1}'.",
                newClient.ClientName, name)));
            return theNewClient;
        }

        public override string ToString()
        {
            return string.Format("Library name: {0}.\n{1}",name,base.ToString());
        }

    }
}
