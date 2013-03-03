#include <iostream>
using namespace std;

/*
2.	קלוט 3 ערכים ל a, b, x ובדוק אם x הוא בתחום שבין a ל b.
*/
int main() 
{
	float a, b, x;
	cout << "Please enter the 1st limit-number" << endl;
	cin >> a;
	cout << "Please enter the 2nd limit-number" << endl;
	cin >> b;
	cout << "Please enter the number for chechink" << endl;
	cin >> x;
	if (x == a || x == b) {
		cout << "The number is equal to one of the limit-numbers";
	} else if (x > a ^ x > b) {
		cout << "the number is between the limits";
	} else {
		cout << "the number is out of the limits";
	}
	cout << endl << endl;
	system("pause");
	return 1;
}
