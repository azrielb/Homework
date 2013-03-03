#include <iostream>
using namespace std;

int main() 
{
	float a;
	int b;

	cout << "Shalom. I wish you a nice day!" << endl;
	do {
		cout << endl << "Please enter an integer number between 100 & 999" << endl;
		cin >> a;
	} while ((int)a * 1.0 != a || a < 100 || a > 999);

	cout << endl << "The summing of digits is " << (b = (int)a) / 100 + (b % 100) / 10 + (b % 10) << endl << endl;

	system("pause");
	return 1;
}
