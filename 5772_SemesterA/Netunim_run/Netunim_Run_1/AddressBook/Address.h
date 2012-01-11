#pragma once
#include <string>
#include <list>
#include <iostream>
using namespace std;

class Address //abstract
{
public:
	Address(string n = "") : name(n) { type = notDefined; }
	virtual ~Address(void) { }
	virtual void print(const char level = 0) const = 0;
	enum { notDefined, group, single } type;
protected:
	string name;
	// this function makes the indentation
	static void tabs(char level) { while (level--) cout << '\t'; }
};
