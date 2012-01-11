#include <iostream>
using namespace std;

//מציג את שני המספרים שהמשתמש הכניס, ואח"כ מציג אותם במהופך
int main() {
	double x, y;

	cout << "Hello, what's up?" << endl << endl << "Please enter 1st number" << endl;
	cin >> x;
	cout << endl << "Please enter 2nd number" << endl;
	cin >> y;

	cout << endl << "First number is " << x << ", second number is " << y << endl;
	swap(x,y);
	cout << endl << "First number is " << x << ", second number is " << y << endl;

	system ("pause");
	return 1;
}