#include <iostream>
#include <time.h>
using namespace std;

/*
מיון אינדקסים של מערך
*/

#define TOTAL 10

void kelet (double maarach[]);
void miun (double maarach1[], int maarach2[]);
void peletMemuyan (double maarach1[], int maarach2[]);
void pelet (double maarach[]);
void pelet (int maarach[]);

int main() {
	double maarach1[TOTAL];
	int maarach2[TOTAL];
	kelet (maarach1);
	miun (maarach1, maarach2);
	cout << "maarach1 is:" << endl;
	pelet (maarach1);
	cout << "maarach2 is:" << endl;
	pelet (maarach2);
	cout << "maarach1 memuyan is:" << endl;
	peletMemuyan (maarach1, maarach2);

	cout << endl;
	system ("pause");
	return 0;
}

void kelet (double maarach[]) {
	srand( (unsigned)time(NULL));
	bool flag = false;
	int j;
	for (int i = 0; i < TOTAL; ++i)
		do {
			maarach[i] = (rand() % 1000) / 1000.0;
			for (j = 0; j < i && !flag; ++j) 
				flag = (maarach[i] == maarach[j]);
		} while (flag);
}
void miun (double maarach1[], int maarach2[]) {
	int j;
	for (int i = 0; i < TOTAL; ++i)
		for (maarach2[i] = j = i; j; --j)
			if (maarach1[maarach2[j]] < maarach1[maarach2[j - 1]])
				swap (maarach2[j], maarach2[j - 1]);
}
void pelet (double maarach[]) {
	for (int i = 0; i < TOTAL; ++i)
		cout << maarach[i] << '\t';
}
void pelet (int maarach[]) {
	for (int i = 0; i < TOTAL; ++i)
		cout << maarach[i] << '\t';
}
void peletMemuyan (double maarach1[], int maarach2[]) {
	for (int i = 0; i < TOTAL; ++i)
		cout << maarach1[maarach2[i]] << '\t';
}