#pragma once
#include "Hashtable.h"
#include "Address.h"
#include <list>
#include <vector>

class PhoneBook :
	public HashTable<string, Address *>
{
public:
	PhoneBook(unsigned int s = 7);
	virtual ~PhoneBook();
	virtual Address * find(string) const;
	virtual void remove(string);
	virtual void print(bool sorted = true);
	virtual void add(Address *);
protected:
	virtual int hash(string) const;
	vector<list <Address *>*> table;
};
