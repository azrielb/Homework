#include "List.h"
#include <string>

template <class T> class Dlink : public link<T>
{
public:
	// data areas
	Dlink * prev;
	Dlink * next;
	// constructor
	Dlink(T linkValue, Dlink * nextPtr, Dlink * prevPtr) 
		: link(linkValue, nextPtr), next(nextPtr), prev(prevPtr) {}
	Dlink(const Dlink &other) : next(other.next), prev(other.prev) {}
	bool operator== (const Dlink<T> &other) const {
		return (value == other.value && (other.next == NULL || (next != NULL && *next == *(other.next))));
	}
};

template <class T> class TemplateList : public list<T> {
protected:
	// data field
	Dlink<T> * first;
public:
	// constructors
	TemplateList() : first(NULL) {}
	TemplateList(const TemplateList<T> &);
	TemplateList<T> operator =(const TemplateList<T> &);
	// operations
	void Add(T value);
	void RemoveFirst();
	int	Includes(const T &value) const { return list<T>::Includes(value); }
	Dlink<T> * Includes(const TemplateList<T> &other) const;
	void print();
};

template <class T> TemplateList<T>::TemplateList(const TemplateList<T> &l) : list() // Call to default list-constructor!
{
	Dlink<T> *src, *trg;
	if(l.first == NULL){
		list<T>::first = first = NULL;
	} else {
		src = l.first;
		list<T>::first = trg = first = new Dlink<T>((l.first)->value, NULL, NULL);
		while(src->next != NULL) {
			trg->link<T>::next = trg->next = new Dlink<T>((src->next)->value, NULL, trg);
			src = src->next;
			trg = trg->next;
		}
	}
}

template <class T> TemplateList<T> TemplateList<T>::operator =(const TemplateList<T> &l) // Call to default list-constructor!
{
	Dlink<T> *src, *trg;
	if(l.first == NULL){
		list<T>::first = first = NULL;
	} else {
		src = l.first;
		list<T>::first = trg = first = new Dlink<T>((l.first)->value, NULL, NULL);
		while(src->next != NULL) {
			trg->link<T>::next = trg->next = new Dlink<T>((src->next)->value, NULL, trg);
			src = src->next;
			trg = trg->next;
		}
	}
	return *this;
}

template <class T> void TemplateList<T>::Add(T val) {
	list<T>::first = first = new Dlink<T>(val, first, NULL);
	assert(first != NULL);
	if (first->next != NULL)
		first->next->prev = first;
}

template <class T> void TemplateList<T>::RemoveFirst() {
	list<T>::RemoveFirst();
	first = (Dlink<T> *)(list<T>::first);
	first->prev = NULL;
}

template <class T> Dlink<T> * TemplateList<T>::Includes(const TemplateList<T> &other) const {
	if (other.IsEmpty()) return NULL;
	Dlink<T> * item = first;
	while (item != NULL)
		if (*item == *(other.first))
			return item;
		else
			item = item->next;
	return NULL;
}

template <class T> void TemplateList<T>::print() {
	if (IsEmpty()) {
		cout << "This list is empty!" << endl;
		return;
	}
	Dlink<T> * item = first;
	while (item != NULL) {
		cout << item->value << '\t';
		item = item->next;
	}
	cout << endl;
}

class date {
private:
	short day, month, year;
public:
	date(short d = 0, short m = 0, short y = 0) : day(d), month(m), year(y) {}
	date(const date &other) : day(other.day), month(other.month), year(other.year) {}
	date operator =(const date &other) { day=other.day; month=other.month; year=other.year; }
	bool operator ==(const date &other) const { return (day==other.day&&month==other.month&&year==other.year); }
	friend ostream& operator<< (ostream& os, const date d);
	friend istream& operator>> (istream& is, date& d);
};

ostream& operator<<(ostream& os, const date d) {
	if (d.day < 10) os << '0';
	os << d.day << '/';
	if (d.month < 10) os << '0';
	os << d.month << '/';
	if (d.year < 10) os << '0';
	os << d.year;
	return os;
}

istream& operator>>(istream& is, date& d) {
	is >> d.year >> d.month >> d.day;
	return is;
}

template <class T> void test_TL(char * message) {
	T variable;
	TemplateList<T> ls1,ls2;
	for(int a = 0; a < 5; ++a) {
		cin >> variable;
		ls1.Add(variable);
	}
	ls1.RemoveFirst();
	cout << "ls1 " << ((ls1.Includes(variable))? "" : "doesn't ") << "Include " << variable << endl;
	ls1.Add(variable);
	cout << "ls1 " << ((ls1.Includes(variable))? "" : "doesn't ") << "Include " << variable << endl;
	cout << message << endl;
	for(int a = 0; a < 2; ++a) {
		cin >> variable;
		ls2.Add(variable);
	}
	cout << endl;
	cout << "ls1: " << endl;
	ls1.print();
	cout << endl;
	cout << "ls2: " << endl;
	ls2.print();
	cout << endl;
	cout << "ls1 " << ((ls1.Includes(ls2))? "" : "doesn't ") << "Include ls2." << endl << endl;
}

int main()
{
	cout << "ls1: Insert 5 integers, seperated by white-spaces:\t";
	test_TL<int>("ls2: Insert 2 integers, seperated by white-spaces:\t");
	cout << "ls1: Insert 5 words, seperated by white-spaces:\t";
	test_TL<string>("ls2: Insert 2 words, seperated by white-spaces:\t");
	cout << "ls1: Insert 5 dates (in format 'DD MM YY'), seperated by white-spaces:\t";
	test_TL<date>("ls2: Insert 2 dates (in format 'DD MM YY'), seperated by white-spaces:\t");
	cout << endl;
	system ("pause");
	return 0;
}	
