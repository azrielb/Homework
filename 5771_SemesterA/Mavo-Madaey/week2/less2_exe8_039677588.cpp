#include <iostream>
using namespace std;
//מגדיר את "תחום המאמנים", ע"פ ההגדרה של 220 פחות הגיל, כפול 72%-87%
int main() 
{
	float age;

	//קלט
	cout << "Hello, the gymnast." << endl;
	do {
		cout << endl << "Please enter your age" << endl;
		cin >> age;
	} while (age <= 0);

	//חישוב ופלט
	age = 220 - age;
	cout << endl << "Your training-range is betwwen " << 0.72 * age << " & " << 0.87 * age << endl << endl;

	system("pause");
	return 1;
}
