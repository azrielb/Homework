//---------------------------------------------------------
//  class Queue 
//  abstract class - simply defines protocol for
//   Queue operations
//---------------------------------------------------------

#if (!defined QUEUE_H)
#define QUEUE_H

template <class T> class Queue {
public:
    // protocol for Queue operations
    virtual void clear() = 0;
    virtual T dequeue() = 0;
    virtual void enqueue(T value) = 0;
    virtual T front () const = 0;
    virtual bool isEmpty() const = 0;
};
#endif