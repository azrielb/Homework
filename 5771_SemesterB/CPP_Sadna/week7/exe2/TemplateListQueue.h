#include "TemplateList.h"
#include "TemplateQueue.h"

/********************************************
/*	class QueueList							*
/*	Queue implemented using List operations	*
/********************************************/
template <class T> class QueueList : public Queue<T> {
public:
	// constructors
	QueueList() : data() {}
	QueueList(const QueueList<T> & v);

	// implement Queue protocol 
	void clear() { data.clear(); }
	T dequeue() { return data.RemoveFirst(); }
	void enqueue(T value) { data.addToEnd(value); }
	T front () const { return data.FirstElement(); }
	bool isEmpty() const { return data.IsEmpty(); }

protected:
	list<T> data;
};
