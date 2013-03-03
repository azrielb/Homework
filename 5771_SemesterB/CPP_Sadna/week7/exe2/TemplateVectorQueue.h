#include "TemplateVector.h"
#include "TemplateQueue.h"

//-------------------------------------------------------
//  class QueueVector
//  Queue implemented using vector operations
//-------------------------------------------------------

template <class T> class QueueVector : public Queue<T> {
public:
	// constructor requires a starting size
	QueueVector(unsigned size) : data(size + 1) /* one extra slot */ { clear(); }
	QueueVector(const QueueVector<T>&) : data(v.data), nextSlot(v.nextSlot), firstUse(v.firstUse) {}

	// implement Queue protocol
	void clear();
	T dequeue();
	void enqueue(T value);
	T front() const;
	bool isEmpty() const { return nextSlot == firstUse; }

protected:
	Vector<T> data;
	unsigned nextSlot;
	unsigned firstUse;
}; 

//== class QueueVector implementation ==
template <class T> void QueueVector<T>::clear() {
	nextSlot = 0;
	firstUse = 0;
	data.clear();
}

template <class T> T QueueVector<T>::dequeue() {
	if(isEmpty()) throw "Queue is empty"; // can not dequeue from an empty queue
	unsigned dataloc = firstUse;
	++firstUse %= data.Capacity();
	return data[dataloc];
}

template <class T> void QueueVector<T>::enqueue(T val) { 
	if ((nextSlot + 1) % data.Capacity() == firstUse) throw "the Queue is full"; // make sure Queue has not overflowed
	if (data.Size() < data.Capacity()) data.Insert(val);
	else data[nextSlot] = val;
	++nextSlot %= data.Capacity();
}

template <class T> T QueueVector<T>::front() const {
	if(isEmpty()) throw "Queue is empty"; // can not return a value from an empty Queue
	return data[firstUse]; 
}
