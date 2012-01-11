// Copyright (C) Azriel Berger 2011 <azrielb@gmail.com>
#include <iostream>
using namespace std;
#define null 0

class Polygon {
protected:
	int n;
	long * sides;
public:
	Polygon(int number = 0);
	Polygon(const Polygon& other);
	~Polygon();
	long perimeter() const; //perimeter = HEIKEF
	void sideLength(long length, int index = -1);
	bool operator == (const Polygon& other) const;
};

Polygon::Polygon(int number) {
	n = number > 2 ? number : 0;
	sides = (n ? new long[n] : null);
	for (int index = 0; index < n; ++index) sides[index] = -1;
}

Polygon::Polygon(const Polygon &other) : n(other.n) {
	sides = n ? new long[n] : null;
	for (int index = 0; index < n; ++index) sides[index] = other.sides[index];
}

Polygon::~Polygon() {
	delete [] sides;
}

long Polygon::perimeter() const {
	int perim = 0;
	for (int index = 0; index < n; ++index) {
		if (sides[index] < 0) return -1;
		else perim += sides[index];
	}
	return perim;
}

void Polygon::sideLength(long length, int index) {
	if (index < 0) 
		for (index = 0; index < n; ++index) 
			if (sides[index] < 0) 
				break;
	if (index < n) sides[index] = length;
}

bool Polygon::operator == (const Polygon& other) const {
	if (n != other.n || perimeter() != other.perimeter()) return false;
	for (int index1 = 0, index2; index1 < n; ++index1) {
		for (index2 = 0; index2 < n; ++index2) 
			if (sides[index1] == other.sides[index2])
				break;
		if (index2 == n)
			return false;
		for (index2 = 0; index2 < n; ++index2) 
			if (sides[index2] == other.sides[index1])
				break;
		if (index2 == n)
			return false;
	}
	return true;	
}

class Rectangle : public Polygon {
public:
	Rectangle(long width = -1, long height = -1) : Polygon(4) {
		sides[0] = sides[2] = width;
		sides[1] = sides[3] = height;
	}
};

class Triangle : public Polygon {
public:
	Triangle(long A = -1, long B = -1, long C = -1) : Polygon(3) {
		sides[0] = A;
		sides[1] = B;
		sides[2] = C;
	}
};

int main() {
	for (int counter = 0; counter < 2; ++counter) {
		Polygon * Polygons[2];
		int n;
		for (int index = 0; index < 2; ++index) {
			cout << "Please enter the polygon sides number:\t";
			cin >> n;
			if (n == 3) {
				long sides[3];
				cout << "Please enter the three sides length:\t";
				cin >> sides[0] >> sides[1] >> sides[2];
				Polygons[index] = new Triangle(sides[0], sides[1], sides[2]);
			} else if (n == 4) {
				long sides[2];
				cout << "Please enter the width and the height:\t";
				cin >> sides[0] >> sides[1];
				Polygons[index] = new Rectangle(sides[0], sides[1]);
			} else {
				Polygons[index] = new Polygon(n);
				if (n < 3) {
					cout << "Sorry. Polygon has at least 3 sides!" << endl;
				} else {
					cout << "Please enter the " << n << " sides length:\t";
					while (n--) {
						long sides;
						cin >> sides;
						Polygons[index]->sideLength(sides, n);
					}
				}
			}
		}
		cout << "The tow polygons are ";
		if (!((*(Polygons[0])) == (*(Polygons[1])))) cout << "not ";
		cout << "the same." << endl << endl;
	}
	system ("pause");
	return 0;
}