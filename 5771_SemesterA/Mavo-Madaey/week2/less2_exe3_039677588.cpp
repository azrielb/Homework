#include <iostream>
using namespace std;

//מקבל שני מספרים שלמים, ומציג חישוב מסוים הפועל עליהם - כפי שהוגדר בתרגיל
int main() 
{
	float a,b;

	cout << "Hello, my friend\n";
	do {
		cout << "\nPlease insert first integer\n";
		cin >> a;
	} while ((int)a * 1.0 != a);
	do {
		cout << "\nPlease insert second integer\n";
		cin >> b;
	} while ((int)b * 1.0 != b);

	cout << "\nThe result of calculation is " << (5 * a +3) / (6 * b + 2) << endl << endl;

	system("pause");
	return 1;
}
