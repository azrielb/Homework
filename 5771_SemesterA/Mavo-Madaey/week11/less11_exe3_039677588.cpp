#include <iostream>
#include <math.h>
using namespace std;

//פונקציית העצרת
int factorial(int);
//חישוב האקספוננט של מספר כלשהו
double exponent(double x, double d, int &n) ;

int main() {
	double x,d;
	int n = 1;
	cout << "Please enter the 'x':\t";
	cin >> x;
	cout << "Please enter the 'd':\t";
	cin >> d;
	cout << endl << "The exponent of " << x << " is " << exponent(x,d,n) << '.' << endl;
	cout << "The sum contains " << n << " numbers.";

	cout << endl;
	system ("pause");
	return 0;
}

double exponent(double x, double d, int &n) {
	double num = pow(x, n - 1.0) / factorial(n - 1);
	if (num < d) return 0;
	else return num + exponent(x,d,++n);	
}

int factorial(int n) { 
	if (n < 0) return 0;
	if (n == 0) return 1;
	return n * factorial(n - 1);
}