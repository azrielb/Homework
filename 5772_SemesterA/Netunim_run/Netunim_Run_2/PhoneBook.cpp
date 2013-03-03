#include "PhoneBook.h"

PhoneBook::PhoneBook(unsigned int s) : HashTable<string, Address *>(s), table(s)
{
}

PhoneBook::~PhoneBook()
{
	for (vector<list<Address *>*>::iterator vec_it = table.begin(); vec_it != table.end(); ++vec_it)
		if ((*vec_it) != NULL)
		{
			for (list<Address *>::iterator ls_it = (*vec_it)->begin(); ls_it != (*vec_it)->end(); ++ls_it)
				delete (*ls_it);
			delete (*vec_it);
		}
}

Address * PhoneBook::find(string name) const {
	list <Address *>* ls = table[hash(name)];
	if (ls != NULL)
		for (list<Address *>::iterator ls_it = ls->begin(); ls_it != ls->end(); ++ls_it) 
			if (**ls_it == name)
				return *ls_it;
	return NULL;
}
void PhoneBook::remove(string name) {
	list <Address *>* ls = table[hash(name)];
	if (ls != NULL)
		for (list<Address *>::iterator ls_it = ls->begin(); ls_it != ls->end(); ++ls_it) 
			if ((**ls_it) == name)
			{
				ls->erase(ls_it);
				--counter;
				break;
			}
}

void PhoneBook::print(bool sorted) {
	Address ** allAddresses = new Address*[counter];
	unsigned int index = -1;

	cout << "The all people in the phone-book are:" << endl
		<< "-------------------------------------" << endl << endl;
	for (vector<list<Address *>*>::iterator vec_it = table.begin(); vec_it != table.end(); ++vec_it)
		if ((*vec_it) != NULL)
			for (list<Address *>::iterator ls_it = (*vec_it)->begin(); ls_it != (*vec_it)->end(); ++ls_it)
				if (sorted)
					allAddresses[++index] = *ls_it;
				else
					cout << **ls_it;
	if (!sorted) return;
	Address::boubleSort(allAddresses, counter);
	for (index = 0; index < counter; ++index) 
		cout << *allAddresses[index];

	delete allAddresses;
}

void PhoneBook::add(Address * item) {
	list <Address *>* ls = table[hash(item->getName())];
	if (ls == NULL) 
		table[hash(item->getName())] = new list <Address *>();
	else
		for (list<Address *>::iterator ls_it = ls->begin(); ls_it != ls->end(); ++ls_it) 
			if (**ls_it == *item) {
				**ls_it = *item;
				return;
			}
			table[hash(item->getName())]->push_back(item);
			++counter;
}

int PhoneBook::hash(string name) const {
	static string last = "";
	static int ret = 0;
	if (last != name) {
		ret = 0;
		for (unsigned index = 0; index < name.size(); ++index)
			ret = (ret * 128 + (int)name[index]) % size;
		last = name;
	}
	return ret;
}
