#include <iostream>
#include <fstream>
#include <direct.h>

using namespace std;

/*
5.	כתוב תכנית, הקוראת מקובץ וקטור ערכים לא מסודר של N שלמים, כאשר כמה מהם מופיעים יותר מפעם אחת. הפלט יהיה:
•	אותו הווקטור באותו הסדר, כאשר כל ערך מופיע בדיוק פעם אחת.
•	מספר M ששווה למספר האיברים בווקטור החדש.
*/

#define MAX 100

int kelet (int maarach[], int num);
void pelet (int maarach[], int num);
void sinun(int maarach[], int num);

int main() {
	{ // במחשב שלי בלבד: משנה את התיקיה הפעילה, בגלל שתיקית שיעורי בית נפרדת מתיקית הפרוייקט
		char* buffer = _getcwd(NULL, 0);
		if(buffer[9] == 'a' && buffer[15] == 'b' && buffer[65] == 'h' && buffer[72] == 'k') _chdir("..\\week6");
	}
	int maarach[MAX];
	int num = kelet(maarach, MAX);
	sinun(maarach, num);
	pelet(maarach, num);
	cout << "Good by." << endl;

	cout << endl;
	system ("pause");
	return 0;
}

int kelet (int maarach[], int num) {
	char* ifilename = "less6_exe5_039677588.txt";
	int temp;
	cout << "how much numbers do you want to read from the file (maximum: " << num << ")?";
	cin >> temp;
	if (temp > num) {
		cout << temp << " > " << num << '!' << endl;
	} else num = temp;
	cout << endl;

	//פותח את הקובץ
	ifstream thenumbers(ifilename);
	int temp2;
	for (temp = 0; temp < num; ++temp) {
		thenumbers >> temp2;
		maarach[temp]=temp2;
		//if (maarach[temp] < 0) break;
	}
	thenumbers.close();

	return temp;
}
void pelet (int maarach[], int num) {
	char* ofilename = "less6_exe5_039677588_output.txt";
	//פותח את הקובץ
	ofstream thenumbers(ofilename);
	int first = maarach[0];
	thenumbers << first << ' ';
	for (int i = 1; i < num; ++i){
		if (*++maarach != first)
			thenumbers << *maarach << ' ';
	}
	thenumbers.close();
}
void sinun(int maarach[], int num) {
	//מסמן ערכים כפולים במערך;
	for (int i = 1, j; i < (num - 1); ++i)
		for (j = i + 1; j < num; ++j)
			if (maarach[i] == maarach[j]) maarach[j] = maarach[0];
}