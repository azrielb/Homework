#include <iostream>
using namespace std;
/*
תכנית המוצאת את הסכום של n האיברים הראשונים בסדרות האלו:
a = 1 + 2X + 3X^2 + 4X^3 +….+nX^(n-1)
b = X + (-1/3)X^3  + (1/5)X^5 + (-1/7)X^7 + …. +((-1)^(n-1)/(2n-1))X^(2n-1)
//*/

int main() {
	float x,a=0,b=0,pow;
	int n,counter;
	cout << "Hello!" << endl << "Please insert X: ";
	cin >> x;
	cout << "Please insert N: ";
	cin >> n;
	for ( ; n; n--) {
		pow=1;
		for (counter = 1; counter < n; counter++) pow *= x;
		a += n * pow;
		pow=1;
		for (counter = 0; counter < (2 * n - 1); counter++) pow *= x;
		// (n % 2) * 2 - 1 = (-1)^(n-1)
		b += ((n % 2) * 2 - 1) * pow / (2 * n - 1);
	}
	cout << "First power-sum is " << a << ", and second power-sum is " << b << endl;

	cout << endl;
	system ("pause");
	return 0;
}