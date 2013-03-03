#include "Address.h"

Address::Address(string n, string e, string f, string p, string sA) : name(n), email(e), fax(f), phone(p), streetAddress(sA)
{ 
}

Address::~Address(void)
{
}

const string & Address::getName() const
{
	return this->name;
}

bool Address::operator== (const Address &other) const {
	return this->name == other.name;
}

bool Address::operator== (const string other) const {
	return this->name == other;
}

ostream& operator<<(ostream& os, Address adrs) {
	os << "name: "; os.width(6); os << adrs.name 
		<< ".\temail: "; os.width(20); os << adrs.email 
		<< ".\tfax:"; os.width(11); os << right << adrs.fax 
		<< ".\tphone:"; os.width(11); os << right << adrs.phone 
		<< ".\tstreetAddress: " << adrs.streetAddress << endl;
	return os;
}

void Address::boubleSort(Address * adrss[], int size) {
	bool swaped;
	int a = 0;
	do {
		swaped = false;
		for (int i = 1; i < size; ++i)
			if ((*(adrss[i - 1])).name.compare((*(adrss[i])).name) > 0) {
				swap(adrss[i - 1], adrss[i]);
				swaped = true;
			}
	} while (swaped && ++a < size * size * 2);
}
