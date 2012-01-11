#include "SingleAddress.h"

SingleAddress::SingleAddress(string n, string e, string f, string p, string sA)
	: Address(n), email(e), fax(f), phone(p), streetAddress(sA)
{
	type = single;
}

void SingleAddress::print(const char level) const {
	tabs(level); //indentation
	cout << "name: " << this->name 
		<< ".\temail: " << this->email 
		<< ".\tfax:"; cout.width(11); cout << right << this->fax 
		<< ".\tphone:"; cout.width(11); cout << right << this->phone 
		<< ".\tstreetAddress: " << this->streetAddress << endl;
}
