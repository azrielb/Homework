using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ABClasses;

namespace municipalyLibraries
{
    class Municipality
    {
        List<Resident> residents = new List<Resident>();
        public event EventHandler NewResidents;

        public int add(Resident newResident)
        {
            int counter = residents.Count;
            residents.Add(newResident);
            if (residents.Count % 3 == 0) newResidents(3);
            return (residents.Count == counter + 1) ? newResident.ClientID : -1;
        }

        private void newResidents(int num)
        {
            if (NewResidents == null || num <= 0) return;
            Resident[] theNewResidents = new Resident[num];
            while (--num >= 0) theNewResidents[num] = residents[residents.Count - num - 1];

            NewResidents(this, new EventArgs<Resident[]>(theNewResidents));
        }

    }
}
