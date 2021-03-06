#include <iostream>
using namespace std;

template <class T> class Set {
protected:
	T * data;
	unsigned size;
public:
	Set(unsigned theSize = 0) { if ((data = new T[size = theSize]) == NULL) throw "Error in memory alocation"; }
	Set(const Set& other);
	~Set() { if (data != NULL) delete [] data; }
	Set<T>& operator =(const Set<T>& other);
	Set<T> operator *(const Set<T>& other) const;
	Set<T> operator +(const Set<T>& other) const;
	const T& operator [](unsigned index) const;
	T& operator [](unsigned index);
	bool operator ==(const Set<T>& other) const;
	bool operator !=(const Set<T>& other) const { return !operator ==(other); }
	bool removeDuplications(bool changeMemorySize = true);
	void print();
};

template <class T> Set<T>::Set(const Set& other) {
	if (!other.size || other.data == NULL) {
		size = 0;
		data = NULL;
		return;
	}
	data = new T[size = other.size];
	if (data == NULL) throw "Error in memory alocation";
	for (unsigned index = 0; index < size; ++index) data[index] = other.data[index];
}

template <class T> Set<T>& Set<T>::operator =(const Set<T>& other) {
	if (!other.size || other.data == NULL) {
		size = 0;
		data = NULL;
		return;
	}
	if (size != other.size || data == NULL) {
		if (data != NULL) delete[] data;
		if ((data = new T[size = other.size]) == NULL) throw "Error in memory allocation";
	}
	for (unsigned index=0; index < size; index++) data[index] = vec.data[index];
	return *this;
}

template <class T> Set<T> Set<T>::operator *(const Set<T>& other) const {
	unsigned newSize = size < other.size ? other.size : size;
	Set<T> temp(newSize);
	for (unsigned index = 0; index < size; ++index) {
		for (unsigned i = 0; i < other.size; ++i) 
			if (data[index] == other.data[i]) {
				temp.data[--newSize] = data[index];
				i = other.size;
			}
	}
	if (newSize == (size < other.size ? other.size : size)) {
		temp.size = 0;
		delete [] temp.data;
		temp.data = NULL;
		return temp;
	}
	while (newSize) { temp.data[--newSize] = temp.data[newSize + 1]; }
	temp.removeDuplications(true);
	return temp;
}

template <class T> Set<T> Set<T>::operator +(const Set<T>& other) const {
	unsigned newSize = size + other.size;
	Set<T> temp(newSize);
	for (unsigned index = 0; index < size; ++index) 
		temp.data[--newSize] = data[index];
	for (unsigned index = 0; index < other.size; ++index) {
		temp.data[--newSize] = other.data[index];
	}
	temp.removeDuplications(true);
	return temp;
}

template <class T> const T& Set<T>::operator [](unsigned index) const {
	if (index >= size) throw "Undefined index";
	return data[index];
}

template <class T> T& Set<T>::operator [](unsigned index) {
	if (index >= size) throw "Undefined index";
	return data[index];
}

template <class T> bool Set<T>::operator ==(const Set<T>& other) const {
	for (unsigned index = 0, i; index < size; ++index) {
		for (i = 0; i < other.size; ++i) 
			if (data[index] == data[i])
				i = other.size + 1;
		if (i == other.size) return false;
	}
	for (unsigned index = 0, i; index < other.size; ++index) {
		for (i = 0; i < size; ++i) 
			if (data[index] == data[i])
				i = size + 1;
		if (i == size) return false;
	}
	return true;
}

template <class T> bool Set<T>::removeDuplications(bool changeMemorySize) {
	unsigned oldSize = size;
	for (unsigned index = 0; index < size - 1; ++index) {
		for (unsigned i = index + 1; i < size; ++i) 
			if (data[index] == data[i]) {
				while (data[i] == data[--size] && i < size) ;
				data[i] = data[size];
			}
	}
	if (oldSize == size) return false;
	if (!changeMemorySize) {
		size = oldSize;
		return true;
	}
	if (!size) {
		delete [] data;
		return true;
	}
	T * tempData = data;
	data = new T[size];
	for (unsigned index = 0; index < size; ++index)
		data[index] = tempData[index];
	delete [] tempData;
	return true;
}

template <class T> void Set<T>::print() {
	if (size == 0)
		cout << " Empty set."; 
	else
		for (unsigned index = 0; index < size; ++index)
			cout << '\t' << data[index];
	cout << endl;
}

int main() {
	unsigned size;
	cout << "Enter the size of first set:\t";
	cin >> size;
	Set<int> first(size);
	if (size) {
		cout << "Enter " << size << " integers, seperated by white-spaces:" << endl;
		for (unsigned index = 0; index < size; ++index)
			cin >> first[index];
	}
	cout << "Enter the size of second set:\t";
	cin >> size;
	Set<int> second(size);
	if (size) {
		cout << "Enter " << size << " integers, seperated by white-spaces:" << endl;
		for (unsigned index = 0; index < size; ++index)
			cin >> second[index];
	}
	cout << endl << "First set is:";
	first.print();

	cout << "Second set is:";
	second.print();

	cout << "First + second is:";
	Set<int> other = first + second;
	other.print();

	cout << "(First \"*\" second) is:";
	(first * second).print();

	cout << "(First \"*\" second) is ";
	if (first * second != first + second) cout << "not ";
	cout << "equal to (First + second)!" << endl << endl;

	system("pause");
	return 0;
}