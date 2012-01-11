#include <iostream>
using namespace std;
/*
ציור פירמידה הפוכה, כמתואר בשאלה
//*/

int main() {
	float base;
	int row;
	cout << "Hello!" << endl << "Please insert the width of the base: ";
	cin >> base;
	while (((int)abs((base - 1) / 2)) * 2.0 != base - 1) {
		cout << "The width must be like 2n+1!" << endl << "Please try again: ";
		cin >> base;
	}
	for (int line = 0; line * 2 < base; line++) {
		cout << endl;
		for (row = 0; row < line; row++) cout << "  ";
		for (; row < base - line; row++) cout << "* ";
	}

	cout << endl;
	system ("pause");
	return 0;
}