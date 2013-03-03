#pragma once

// K: type of keys. T: type of elements.
template <class K, class T>
class HashTable
{
public:
	HashTable(unsigned int s = 7) : size(s), counter(0) {}
	virtual ~HashTable(void) {}
	virtual void add(T) = 0;
	virtual T find(K) const = 0;
	virtual void remove(K) = 0;
	virtual void print(bool sorted = true) = 0;
protected:
	virtual int hash(K key) const = 0;
	unsigned int size;
	unsigned int counter;
};

