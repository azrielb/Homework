#include <iostream>
#include "exe2\\TemplateList.h"
using namespace std;

template <class T> list<T> Merging(list<T> ls1, list<T> ls2) {
	if (ls1.IsEmpty()) return ls2;
	if (ls2.IsEmpty()) return ls1;
	list<T> temp;
	T x = ls1.FirstElement(), y = ls2.FirstElement();
	do {
		if (x < y) {
			temp.addToEnd(x);
			ls1.RemoveFirst();
			x = ls1.FirstElement();
		} else {
			temp.addToEnd(y);
			ls2.RemoveFirst();
			y = ls2.FirstElement();
		}
	} while (!ls1.IsEmpty() && !ls2.IsEmpty());
	while (!ls1.IsEmpty()) {
		temp.addToEnd(x);
		ls1.RemoveFirst();
		x = ls1.FirstElement();
	}
	while (!ls2.IsEmpty()) {
		temp.addToEnd(y);
		ls2.RemoveFirst();
		y = ls2.FirstElement();
	}
	return temp;
}

template <class T> list<T> removeDuplications(list<T> ls) {
	if (ls.IsEmpty()) return ls;
	list<T> temp;
	T x = ls.FirstElement();
	ls.RemoveFirst();
	while (!ls.IsEmpty()) {
		y = ls.FirstElement();
		if (x != y) temp.addToEnd(x);
		x = y;
		ls.RemoveFirst();
	}
	temp.addToEnd(x);
	return temp;
}

template <class T> unsigned uniqueNumbersCounter(list<T> ls) {
	if (ls.IsEmpty()) return 0;
	unsigned counter = 1;
	T x = ls.FirstElement();
	ls.RemoveFirst();
	while (!ls.IsEmpty()) {
		y = ls.FirstElement();
		if (x != y) ++counter;
		x = y;
		ls.RemoveFirst();
	}
	return temp;
}

template <class T> list<T> reverse(list<T> ls) {
	if (ls.IsEmpty()) return ls;
	list<T> temp;
	do {
		temp.Add(ls.FirstElement());
		ls.RemoveFirst()
	} while (!ls.IsEmpty());
	return temp;
}

//I did not write "main" since we have no time. I am sorry.

int main() { return 0; }