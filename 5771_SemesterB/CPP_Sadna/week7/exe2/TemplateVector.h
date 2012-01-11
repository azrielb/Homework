#include <assert.h>
#include <iostream>
using namespace std;

// default capacity for the vector
#define DEF_CAPACITY 100

template <class T> class Vector {
private:
	T * data;
	unsigned size;		//size in use
	unsigned capacity;	//available capacity
public:
	//constructors
	Vector(unsigned theCapacity = DEF_CAPACITY);
	Vector(const Vector<T>&);
	~Vector();
	//operations
	Vector<T>& operator = (const Vector<T>&);
	//modify
	T& operator [](unsigned index);
	//view
	const T& operator [](unsigned index) const;
	unsigned Size() const { return size; }
	unsigned Capacity() const { return capacity; }
	void Insert(T value);
	void clear() { size = 0; }
	T DelLast();
};

template <class T> Vector<T>::Vector(unsigned theCapacity) {
	capacity = theCapacity;
	size = 0;
	data = new T[capacity];
	assert(data != NULL);
}

template <class T> Vector<T>::Vector(const Vector<T>& vec) {
	capacity = vec.capacity;
	size = vec.size;
	data = new T[capacity];
	assert(data != NULL);
	for (unsigned index = 0; index < size; ++index)
		data[index] = vec.data[index];
}

template <class T> Vector<T>::~Vector() {
	if (data != NULL) {
		delete [] data;
		data = NULL;
	}
}

//view function
template <class T> T& Vector<T>::operator [](unsigned index) {
	assert(index >=0 && index < size);
	return data[index];
}

//modify function
template <class T> const T& Vector<T>::operator [](unsigned index) const {
	assert(index >=0 && index < size);
	return data[index];
}

template <class T> Vector<T>& Vector<T>::operator = (const Vector<T>& vec) {
	size = vec.size;
	capacity = vec.capacity;
	if (data) delete [] data;
	data = new T[capacity];
	assert(data != NULL);
	for (unsigned index = 0; index < size; ++index)
		data[index] = vec.data[index];
	return *this;
}

template <class T> void Vector<T>::Insert(T value) {
	assert(size < capacity);
	data[size] = value;
	++size;
}

template <class T> T Vector<T>::DelLast() {
	assert(size > 0);
	return data[--size];
}
