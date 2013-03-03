#pragma once
#include <string>
#include <iostream>
using namespace std;

class Address
{
public:
	Address(string n = "", string e = "N/A", string f = "N/A", string p = "N/A", string sA = "N/A");
	virtual ~Address(void);
	const string & getName() const;
	virtual bool operator== (const Address &) const;
	virtual bool operator== (const string) const;
	static void Address::boubleSort(Address * adrss[], int size);
	friend ostream& operator<< (ostream& os, Address adrs);
protected:
	string streetAddress;
	string email;
	string phone;
	string fax;
	string name;
};
