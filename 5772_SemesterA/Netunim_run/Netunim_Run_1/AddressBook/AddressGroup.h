#pragma once
#include "address.h"

	#include <iostream>
	#include <list>

class AddressGroup :
	public Address
{
public:
	AddressGroup(string n = "");
	virtual ~AddressGroup(void) { }
	virtual void print(const char level = 0) const;
	// returns false if you try to mix between items and categories
	bool add(Address * item);
protected:
	list<Address *> children;
};
