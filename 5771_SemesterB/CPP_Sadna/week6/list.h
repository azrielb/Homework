//------------------------------------------------
//  class List
//      arbitrary size Lists
//      permits insertion and removal 
//      only from the front of the List
//------------------------------------------------
#define NULL 0

class List
{
protected:
	//--------------------------------------------
	//  inner class link
	//  a single element for the linked List 
	//--------------------------------------------
	class Link
	{
	public:
		// constructor
		Link( int linkValue, Link * nextPtr);
		Link (const Link &);
		// data areas
		int value;
		Link * next;
	};	//end of class Link
public:
	// constructors
	List();
	List(const List&);
	~List();

	// operations
	void add( int value);
	int firstElement() const;
	int includes(const int &value) const;
	bool isEmpty() const;
	void removeFirst();
	void clear();

protected:
	// data field
	Link* first;
};
//------------------------------------------------
//  class Link implementation
//------------------------------------------------
List::Link::Link( int val, Link* nxt) : 
value(val), next(nxt)   {}

List::Link::Link(const Link& source) : 
value(source.value),next(source.next)  {}
//--------------------------------------------
//  class List implementation
//--------------------------------------------
List::List(): first(NULL)
{
	// no further initialization
}

List::List(const List &l) 
{
	Link *src, *trg;
	if(l.first==NULL)
		first=NULL;
	else
	{
		first= new Link((l.first)->value, NULL);
		src=l.first;
		trg=first;
		while(src->next!=NULL)
		{
			trg->next= new Link
				((src->next)->value, NULL);
			src=src->next;
			trg=trg->next;
		}
	}
}
List::~List()
{
	clear();
}

void List::clear()
{
	// empty all elements from the List
	Link* next;
	for (Link * p=first; p != NULL; p=next)
	{
		// delete the element pointed to by p
		next=p->next;
		p->next=NULL;
		delete p;
	}
	// mark that the List contains no elements
	first=NULL;
}

bool List::isEmpty() const
{
	// test to see if the List is empty
	// List is empty if the pointer to the first
	// Link is null

	return first == NULL;
}
void List::add( int val)
{
	//Add a new value to the front of a Linked List
	first=new Link(val, first);
	if(first==NULL) 
		throw "failed in memory allocation";
}

int List::firstElement() const
{
	// return first value in List
	if (isEmpty())
		throw "the List is empty, no first Element";
	return first->value;
}

int List::includes(const  int &val) const
{
	// loop to test each element
	for (Link* p=first; p!=NULL ; p=p->next)
		if (val == p->value)
			return true;
	// not found
	return false;
}

void List::removeFirst()
{
	// make sure there is a first element
	if(isEmpty())
		throw "the List is empty, no Elements to move";
	// save pointer to the removed node
	Link* p=first;
	// reassign the first node
	first=  p->next;
	p->next = NULL;
	// recover memory used by the first element
	delete p;
} 