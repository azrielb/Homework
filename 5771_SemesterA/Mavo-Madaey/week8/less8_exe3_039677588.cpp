#include <time.h>
#include <iostream>
#include <conio.h>
using namespace std;

#define LENGTH 60

void strInput(char* vec, char length);
char select3rd(char* vec);
void ordinal(char num);

int main() 
{
	char mystring[LENGTH];

	strInput(mystring, LENGTH);

	cout << endl << "The third largest character (in the string) is: " << select3rd(mystring) << endl;

	cout << endl;
	system("pause");
	return 0;
}
//* פונקציה המקבלת את המערך ואת גודלו וקולטת לתוכו תוים מהמקלדת עד להקשת אנטר -מקסימום length-1 תוים
void strInput(char* vec,char length) {
	char temp;
	cout << "insert printable-characters from the keyboard, and Enter for the end." << endl
		<< "maximum " << (length - 1) << " characters)" << endl;
	while (--length) {
		temp = (char)_getch();
		if (temp == -32) _getch();
		else if (temp < 0 || temp >= ' ') cout << (*(vec++) = temp);
		else if (temp == 13 || temp == 0) break;
	}
	cout << endl;
	*vec = NULL;
}
char select3rd(char* vec) {
	char first = -127, second = -127, third = -127;
	do {
		if (third < *vec) third = *vec;
		if (second < third) swap (second, third);
		if (first < second) swap (first, second);
	} while (*(++vec));
	return third;
}
void ordinal(char num) {//בסוף לא השתמשתי בזה
	cout << "The ";
	if (num > 99) {
		cout << num / 100;
		num %= 100;
	}
	if (num > 20) {
		cout << num / 10;
		num %= 10;
	}
	switch (num) {
		case 1: cout << "1st"; break;
		case 2: cout << "2nd"; break;
		case 3: cout << "3rd"; break;
		default: cout << (int)num << "th";
	}
}
