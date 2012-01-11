// Copyright (C) Azriel Berger 2011 <azrielb@gmail.com>
#include <iostream>
using namespace std;
#include "list.h"

class RoundList: public List {
public:
	// constructors
	RoundList() { last = null; };
	RoundList(const RoundList &l);
	~RoundList() { if (last != null) last->next = null; }
	// override the following methods from 	class List 
	void add(int value);
	void clear();
	void removeFirst();
	int includes(const int &value) const;
	// add a new element to the end of the List
	void addToEnd(int value);
	int search(int n) const;
private:
	Link * last;
};

RoundList::RoundList(const RoundList &l) : List()
{
	Link *src, *trg;
	if(l.first==null)
		last = first = null;
	else
	{
		first= new Link((l.first)->value, null);
		src=l.first;
		trg=first;
		do {
			trg->next= new Link((src->next)->value, null);
			src=src->next;
			trg=trg->next;
		} while(src->next != first);
		trg->next = first;
		last = trg;
	}
}

void RoundList::add( int val)
{
	//Add a new value to the front of a Linked List
	first = new Link(val, first);
	if(first == null) {
		throw "failed in memory allocation";
	} else {
		if (first->next == null) last = first;
		last->next = first;
	}
}

int RoundList::includes(const int &val) const {
	if (first == null) return false;
	// loop to test each element
	Link* p=first;
	for (; p != last ; p=p->next)
		if (val == p->value)
			return true;
	return (val == last->value);
}

void RoundList::removeFirst()
{
	// make sure there is a first element
	if(isEmpty())
		throw "the List is empty, no elements to remove";
	// save pointer to the removed node
	Link* p=first;
	// reassign the first and last nodes
	first = (first->next == first ? (last = null) : (last->next = p->next));
	p->next = null;
	// recover memory used by the first element
	delete p;
} 

void RoundList::addToEnd(int value) {
	add(value);
	first = first->next;
	last = last->next;
}

int RoundList::search(int n) const {
	if (n < 0) throw "Illegal index";
	// Make sure there is elements.
	if (isEmpty()) throw "the List is empty, no elements!";
	Link* p=first;
	for (; n > 0; --n) p=p->next;
	return p->value;
}

int main () {
	int number;
	RoundList theList;
	cout << "Insert numbers for adding to the list. Enter 0 to finish." << endl;
	cin >> number;
	while (number) {
		theList.addToEnd (number);
		cin >> number;
	}
	if (!theList.isEmpty()) {
		cout << "Insert numbers for search in the list. Enter negative-number to finish." << endl;
		cin >> number;
		while (number >= 0) {
			cout << "Your nember is " << theList.search (number) << endl;
			cin >> number;
		}
	}
	cout << endl;
	system("pause");
	return 0;
}