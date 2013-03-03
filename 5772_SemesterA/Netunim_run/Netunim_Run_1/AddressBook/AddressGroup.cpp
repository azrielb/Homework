#include "AddressGroup.h"

	#include <list>
	#include <iostream>

AddressGroup::AddressGroup(string n) : Address(n)
{
	type = group;
}

bool AddressGroup::add(Address * item)
{
	if (!this->children.empty() && (*this->children.begin())->type != item->type) return false;
	// push_back causes FIFO
	this->children.push_back(item);
	return true;
}

void AddressGroup::print(const char level) const
{
	// print the category's name
	tabs(level); //indentation
	cout << this->name << endl;
	// print the all children of category.
	for (list<Address *>::const_iterator iter = this->children.begin(); iter != this->children.end(); ++iter)
	{
		(*iter)->print(level + 1);
	}
}
