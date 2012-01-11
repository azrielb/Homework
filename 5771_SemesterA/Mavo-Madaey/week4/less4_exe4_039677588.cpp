#include <iostream>
using namespace std;

//התוכנית מציגה את כל המספרים התלת-ספרתיים השווים לסכום ספרותיהם אחרי העלאתן בחזקת 3
//זה שקול לפתרון המשוואה הבאה:
//100x + 10y + z == x^3 + y^3 + z^3

//אם היינו מתחילים את הלולאה מ0 - היינו מקבלים גם את המספרים 0,1

int main() {
	char a,b,c;
	for (int i = 100; 1000 > i; i++) 
		if ((a = i % 10) * a * a + (b = (i / 10) % 10) * b * b + (c = i / 100) * c * c == i)		
			cout << i << endl;
	cout << endl;
	system ("pause");
	return 0;
}
