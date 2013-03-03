#include <assert.h>
#include <iostream>

using namespace std;

//--------------------------------------------------
//  class link
//  a single element for the linked list class
//--------------------------------------------------
template <class T> class link
{
public:
	// constructor
	link(T linkValue, link * nextPtr);
	link(const link &);

	// data areas
	T         value;
	link *    next;
};

//--------------------------------------------------
//  class link implementation
//--------------------------------------------------

template <class T>  
link<T>::link(T val, link<T>* nxt) : value(val), next(nxt)   {}

template <class T> 
link<T>::link(const link<T>& source) : value(source.value),next(source.next)  {}


//------------------------------------------------
//  class list
//      arbitrary size lists
//      permits insertion and removal 
//      only from the front of the list
//------------------------------------------------
template <class T> class list
{
public:
	// constructors
	list();
	list(const list<T> &);
	~list();

	// operations
	void  Add(T value);
	T     FirstElement() const;
	int	  Includes(const T &value) const;
	int   IsEmpty() const;
	void  RemoveFirst();
	void  Clear();

protected:
	// data field
	link<T> *     first;
};


//-------------------------------------------------------
//  class list implementation
//-------------------------------------------------------

template <class T> list<T>::list() : first(NULL)
{
	// no further initialization
}

template <class T> list<T>::list(const list<T> &l) 
{
	link<T> *src, *trg;
	if(l.first==NULL)
		first=NULL;
	else
	{
		first= new link<T>((l.first)->value, NULL);
		src=l.first;
		trg=first;
		while(src->next!=NULL)
		{
			trg->next= new link<T>
				((src->next)->value, NULL);
			src=src->next;
			trg=trg->next;
		}
	}
}

template <class T> list<T>::~list()
{
	Clear();
}

template <class T> void list<T>::Clear()
{
	// empty all elements from the list
	link<T> * next;

	for (link<T> * p=first; p != NULL; p=next)
	{
		// delete the element pointed to by p
		next=p->next;
		p->next=NULL;
		delete p;
	}
	// mark that the list contains no elements
	first=NULL;
}

template <class T> void list<T>::Add(T val)
{
	// Add a new value to the front of a linked list
	first=new link<T>(val, first);
	assert(first != NULL);
}


template <class T> 
T list<T>::FirstElement() const
{
	// return first value in list
	assert(first != NULL);
	return first->value;
}

template <class T> 
int list<T>::Includes(const T &val) const
{
	// loop to test each element
	for (link<T>* p=first; p!=NULL ; p=p->next)
		if (val == p->value)
			return true;
	// not found
	return false;
}

template <class T> int list<T>::IsEmpty() const
{
	// test to see if the list is empty
	// list is empty if the pointer to the first
	// link is null
	return first == NULL;
}

template <class T> void list<T>::RemoveFirst()
{
	// make sure there is a first element
	assert(first != NULL);

	// save pointer to the removed node
	link<T> * p=first;

	// reassign the first node
	first=  p->next;

	// recover memory used by the first element
	delete p;
}
