#include <iostream>
#include <string.h>
#include "Vector.h"
#include "list.h"
using namespace std;

class Stack
{
public:
	virtual void clear() = 0;
	virtual int isEmpty() const = 0;
	virtual int pop() = 0;
	virtual void push(int value) = 0;
	virtual int top() const = 0;
};

class StackVector : public Stack {
protected:
	Vector data;
public:
	StackVector(unsigned int capacity = DEF_CAPACITY) : data(capacity) {}

	void clear() { data.Clear(); }
	int isEmpty() const { return data.Size() == 0; }
	int pop();
	void push(int value) { data.Insert(value); }
	int top() const;
};

int StackVector::pop() {
	if(isEmpty()) throw "Stack is empty";
	return data.DelLast();
}

int StackVector::top() const {
	if(isEmpty()) throw "Stack is empty";
	return data[data.Size() - 1];
}

class StackList : public Stack {
protected:
	List data;
public:
	void clear() { data.clear(); }
	int isEmpty() const { return data.isEmpty(); }
	int pop();
	void push(int value) { data.add(value); }
	int top() const { return data.firstElement(); }
};

int StackList::pop() {
	int temp = data.firstElement();
	data.removeFirst();
	return temp;
}

int main()
{
	try{
		Stack* st = NULL;
		char thetype;
		do {
			cout << "Please type 'l'/'L' for list or 'v'/'V' for vector and press Enter: ";
			cin >> thetype;
			switch (thetype) {
				case 'l': case 'L': st = new StackList; break;
				case 'v': case 'V': st = new StackVector(20); break;
			}
		} while (st == NULL);
		for(int i=0;i<=20;i++) {
			if (i == 5) {
				cout << st->pop() << " ";
				cout << st->top() << endl;
				st->clear();
			} else st->push(i);
		}
		while(!st->isEmpty()) cout << st->pop() << " " ;
	} catch(char* str) {
		cout << str;
	}
	system ("pause");
}
