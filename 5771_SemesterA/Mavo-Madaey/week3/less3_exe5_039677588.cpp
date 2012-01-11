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

/*
תכנית המקבלת כקלט תאריך לועזי (במאה ה 20) וקובעת באיזה יום בשבוע חל אותו תאריך
השתמשתי בשיטת החישוב המוצעת בתרגיל, אך כתבתי אותה בצורה מקוצרת-יותר
כמו"כ תיקנתי טעות שגרמה לשגיאה בחודשים ינואר-פברואר בשנה שמספרה מתחלק ב4
*/
int main() {
	char
		adding[13] = {0, 1, 4, 4, 0, 2, 5, 0, 3, 6, 1, 4, 6},
		day = cin_int_minmax ("please enter the day", 31, 1),
		month = cin_int_minmax ("please enter the month", 12, 1),
		year = cin_int_minmax ("please enter the year (in the 20th century)", 99),
		dayOFweek = (year + (year / 4) + adding[month] + day - (year % 4 == 0 && month < 3)) % 7;
	char* days[7] = {"Shabat", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
	cout << "This date is " << days[dayOFweek] << endl << endl;
	system("pause");
	return 1;
}
