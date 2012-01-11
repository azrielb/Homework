#include <assert.h>
#include <iostream>
using namespace std;

//--------------------------------------------------
//  class link
//  a single element for the linked list class
//--------------------------------------------------
template <class T> class link{
public:
	// constructor
	link(T linkValue, link * nextPtr) : value(linkValue), next(nextPtr) {}
	link(const link &) : value(source.value),next(source.next) {}

	// data areas
	T value;
	link * next;
};

//------------------------------------------------
//  class double ended template list
//------------------------------------------------
template <class T> class list {
public:
	// constructors
	list() : first(NULL), last(NULL) {}
	list(const list &);
	~list() { clear(); }

	// operations
	void add(T value);
	T FirstElement() const;
	bool Includes(const T &value) const;
	bool IsEmpty() const { return first == NULL; }
	T RemoveFirst();
	void clear();
	void addToEnd(T value);

protected:
	// data fields
	link<T> * first;
	link<T> * last;
};

//-------------------------------------------------------
//  class list implementation
//-------------------------------------------------------

template <class T> list<T>::list(const list<T> &l) {
	link<T> *src, *trg;
	if(l.first == NULL) {
		first = NULL;
	} else {
		first = new link<T>((l.first)->value, NULL);
		src = l.first;
		trg = first;
		while(src->next != NULL)
		{
			trg->next = new link<T>((src->next)->value, NULL);
			src = src->next;
			trg = trg->next;
		}
	}
}


template <class T> void list<T>::clear() {
	// empty all elements from the list
	link<T> * next;

	for (link<T> * p = first; p != NULL; p = next) {
		// delete the element pointed to by p
		next = p->next;
		p->next = NULL;
		delete p;
	}
	// mark that the list contains no elements
	first = last = NULL;
}

template <class T> void list<T>::add(T val) {
	// Add a new value to the front of a linked list
	first = new link<T>(val, first);
	assert(first != NULL);
	if (last == NULL) last = first; // This is the single element in the list
} 

template <class T> T list<T>::FirstElement() const {
	// return first value in list
	assert(first != NULL);
	return first->value;
}

template <class T> bool list<T>::Includes(const T &val) const {
	// loop to test each element
	for (link<T>* p=first; p!=NULL ; p=p->next)
		if (val == p->value)
			return true;
	// not found
	return false;
}

template <class T> T list<T>::RemoveFirst() {
	// make sure there is a first element
	assert(first != NULL);
	// save pointer to the removed node
	link<T> * p = first;
	T result = p->value;
	// reassign the first node
	first = p->next;
	// recover memory used by the first element
	delete p;
	if (IsEmpty()) last = NULL; // The single element was removed
	return result;
}

template <class T> void list<T>::addToEnd(T val) {
	// add a new element to end of a double ended List
	if (last != NULL) {
		last->next = new link<T>(val, NULL);
		last = last->next;
	}
	// otherwise, just add to front
	else add(val);
}
