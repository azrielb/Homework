#include <iostream>
using namespace std;
#define DEF_CAPACITY 100

class Vector
{
private:
	int * data;
	unsigned capacity;
	unsigned theSize;
public:
	Vector(unsigned theCapacity = DEF_CAPACITY);
	Vector(const Vector& vec);
	~Vector(){ if (data != NULL) delete[] data; }
	Vector operator = (const Vector& vec);
	bool operator == (const Vector& vec) const;
	int& operator [](unsigned index); // modify
	const int& operator [](unsigned index) const; // view
	int operator * (const Vector& vec); // Dot product
	Vector operator + (const Vector& vec);
	unsigned size() { return theSize; }
	void clear() { theSize = 0; }
	int delLast ();
	void insert(int val);
};

void VectorPrinter(Vector vec);

Vector::Vector(unsigned theCapacity) {
	theSize = 0;
	if ((data = new int[capacity = theCapacity]) == NULL) throw "Error in memory allocation";
}
Vector::Vector(const Vector& vec) {
	theSize = vec.theSize;
	if ((data = new int[capacity = vec.capacity]) == NULL) throw "Error in memory allocation";
	for (unsigned index=0; index < theSize; index++) data[index] = vec.data[index];
}
Vector Vector::operator = (const Vector& vec) {
	theSize = vec.theSize;
	if (capacity != vec.capacity || data == NULL) {
		if (data != NULL) delete[] data;
		if ((data = new int[capacity = vec.capacity]) == NULL) throw "Error in memory allocation";
	}
	for (unsigned index=0; index < theSize; index++) data[index] = vec.data[index];
	return *this;
}
bool Vector::operator == (const Vector& vec) const {
	if (theSize!= vec.theSize || capacity != vec.capacity || data == NULL || vec.data == NULL) return false;
	for (unsigned index=0; index < theSize; index++) if (data[index] != vec.data[index]) return false;
	return true;
}
int& Vector::operator [](unsigned index) {
	if (index < 0 || index >= theSize)
		throw "vector overflow";
	return data[index];
}
const int& Vector::operator [](unsigned index) const {
	if (index < 0 || index >= theSize)
		throw "vector overflow";
	return data[index];
}
int Vector::operator * (const Vector& vec) {
	if (theSize != vec.theSize || capacity != vec.capacity || data == NULL || vec.data == NULL) throw "Error in dot-product";
	int dot_product = 0;
	for (unsigned index=0; index < theSize; index++) dot_product += (data[index] * vec.data[index]);
	return dot_product;
}
Vector Vector::operator + (const Vector& vec) {
	Vector temp(vec.capacity + capacity);
	temp.theSize = vec.theSize + theSize;
	for (unsigned index = 0; index < theSize; ++index) temp.data[index] = data[index];
	for (unsigned index = 0; index < vec.theSize; ++index) temp.data[theSize + index] = vec.data[index];
	return temp;
}
int Vector::delLast () {
	if (!theSize) throw "vector overflow";
	return data[--theSize];
}
void Vector::insert(int val) {
	if (theSize == capacity || data == NULL) throw "vector overflow";
	data[theSize++] = val;
}

void VectorPrinter(Vector vec) {
	int theSize = vec.size();
	cout << "The data in your vector is:\t";
	for (int index = 0; index < theSize; ++index) cout << vec[index] << ' ';
	cout << endl << endl;
}

void main()
{
	Vector a,b,c,d;
	for (int index = 0; index < 5; ++index) {
		a.insert(index + 5);
		b.insert(index - 5);
		c.insert(a[index] * b[index]);
		d.insert(index);
		d[index] = a[index];
	}
	cout << "A: ";
	VectorPrinter(a);
	cout << "B: ";
	VectorPrinter(b);
	cout << "C: ";
	VectorPrinter(c);
	cout << "D: ";
	VectorPrinter(d);
	b = c;
	cout << "B = C: ";
	VectorPrinter(d);
	cout << ((a == b) ? "A == B" : "A != B") << "\t\t";
	cout << ((a == d) ? "A == D" : "A != D") << "\t\t";
	cout << "A * C = " << a * c << endl;
	d = c + a;
	cout << "D = C + A: ";
	VectorPrinter(d);

	cout << "The last item in C is: " << c.delLast() << endl << "C: ";
	VectorPrinter(c);

	d.clear();
	cout << "Clear D: ";
	VectorPrinter(d);

	cout << endl;
	system("pause");
}