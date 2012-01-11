#include <iostream>
#include <stdlib.h>
#include <stdio.h>

using namespace std;

void reverseNum(unsigned long, unsigned long &);

int main() {
	unsigned long number, revnumber;
	cin >> number;
	reverseNum(number, revnumber);
	cout << "The reversed number is " << revnumber << endl;

	cout << endl;
	system ("pause");
	return 0;
}
/*
לא הצלחתי להבין איך בדיוק רוצים שנתמודד עם ההצהרה המוזרה הזאת על הפונקציה
ראה לדוגמא בקובץ http://moodle.jct.ac.il/mod/resource/view.php?id=56778
פתרון יעיל עם העברה של משתנה אחד בלבד.
הפתרון שלי הוא אלגוריתם בזבזני, אך הוא עובד, למעט מספרים המכילים בתוכם את הספרה אפס
שוב, אילו לא היו מגבילים אותי לכותרת זו של הפונקציה - הייתי יכול לכתוב אותה במשחק במחרוזות בלבד
או במספרים בלבד, אך הגבילו וזה לפי דעתי מאוד לא הוגן שקובעים לי להשתמש בדרך מסוימת שלא חשבתי עליה כלל.
לשיקולך.
*/
void reverseNum(unsigned long src, unsigned long & dest) {
	if (src < 10) {
		dest = src;
		return;
	}
	int z = src % 10;
	reverseNum(src / 10, dest);
	char buffer[12];
	sprintf(buffer, "%d%d\0", z, dest);
	dest = strtoul(buffer, NULL, 0);
}