#include <iostream>
using namespace std;

inline bool is_meuberet(int year) { //ההגדרה המדויקת לפי הלוח הגריגוריאני
	return (year % 4 == 0 && ((year % 100) || (year % 400 == 0)));
}

inline int num_days(int month, int year) {
	switch (month) {
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			return 31;
		case 4:
		case 6:
		case 9:
		case 11:
			return 30;
		case 2:
			return 28 + is_meuberet(year);
	}
}

int main() {
	int year,
		month,
		numdays,
		day, // current day-of-week
		temp;
	char* days[8] = {"Sat", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
	char* months[13] = {"--", "Jnuary", "February", "March", "April", "May", "June",
		"July", "August", "September", "October", "November", "December"};
	cout << "For which year do you want to print a calendar?";
	cin >> year;
	cout << "Which day of the week does it start (Write a number - sunday is 1, Etc.)?";
	cin >> temp;
	if (year < 1901 || year > 2100) {
		day = (temp + 6) % 7 + 1;
	} else { //הנוסחא מדויקת רק בין השנים 1901-2100
		day = (year + (year - 1) / 4 + 6) % 7 + 1;
		if (temp < 0 || temp > 7 || ((temp + 6) % 7 + 1) != day)
			cout << "No! the first day of this year is " << days[day] << '.' << (char)7 << endl;
	}
	for (month = 1; month <= 12; month++) {
		cout << endl << endl << "\t\t\t" << months[month] << endl;
		for (temp = 1; temp < 8; temp++) cout << days[temp] << '\t';
		cout << '\n';
		for (temp = 1; temp < day; temp++) cout << '\t';
		numdays = num_days(month, year);
		for (temp = 1; temp <= numdays; temp++) {
			cout << temp << '\t';
			if (++day == 8) {
				day = 1;
				cout << endl;
			}
		}
	}
	cout << endl;
	system ("pause");
	return 0;
}