#pragma once
#include "address.h"
	#include <iostream>

class SingleAddress :
	public Address
{
public:
	SingleAddress(string n = "", string e = "N/A", string f = "N/A", string p = "N/A", string sA = "N/A");
	virtual ~SingleAddress(void) { }
	virtual void print(const char level = 0) const;
protected:
	string streetAddress;
	string email;
	string phone;
	string fax;
};

