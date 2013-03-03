#include <iostream>
using namespace std;

/*
ממיין 3 מספרים
*/
int main() {
	float a,b,c;
	cout << "Please enter 1st number" << endl;
	cin >> a;
	cout << "Please enter 2nd number" << endl;
	cin >> b;
	cout << "Please enter 3rd number" << endl;
	cin >> c;
	if (a < b) swap (a, b);
	if (c > b) swap (c, b);
	if (a < b) swap (a, b);

	cout << endl << "The sorted numbrts are: " << a << ",\t" << b << ",\t" << c << endl << endl;
	system("pause");
	return 1;
}
