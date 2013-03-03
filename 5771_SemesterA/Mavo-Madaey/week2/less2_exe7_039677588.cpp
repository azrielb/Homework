#include <iostream>
using namespace std;

//מבקש מספר שלם בתחום המבוקש, ומחזיר אותו. במקרה שהוכנס ערך שגוי - חוזר על הבקשה
int cin_int_minmax(char* msg = "Please enter an integer number", int max = 59, int min = 0) {
	float a;

	do {
		cout << endl << msg << " betwwen " << min << " & " << max << endl;
		cin >> a;
	} while ((int)a * 1.0 != a || a < min || a > max);

	cout << endl;

	return (int)a;
}

//מבקש זמן יציאה וזמן טיסה, ונותן זמן הגעה-ליעד
int main() 
{
	char hour, minute, second;
	char* msg = ".";

	//קלט
	cout << "Hello the tuorist..." << endl;
	hour = cin_int_minmax ("please enter the hour of leaving", 23);
	minute = cin_int_minmax ("please enter the minute of leaving");
	second = cin_int_minmax ("please enter the second of leaving");
	hour += cin_int_minmax ("please enter the hour of flight", 23);
	minute += cin_int_minmax ("please enter the minute of flight");
	second += cin_int_minmax ("please enter the second of flight");

	//חישוב
	if (second > 59) { second -= 60; minute += 1; }
	if (minute > 59) { minute -= 60; hour += 1; }
	if (hour > 23) { hour -= 24; msg = " tomorrow."; }

	//פלט
	cout << endl << "You'll arrive in " << (int)hour << ":" << (int)minute << ":" << (int)second << msg << endl << endl;

	system("pause");
	return 1;
}
