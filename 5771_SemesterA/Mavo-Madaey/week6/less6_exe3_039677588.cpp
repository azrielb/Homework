#include <iostream>
#include <time.h>
using namespace std;

/*
תכנית הקולטת מקסימום 100 ערכים שלמים חיוביים לא ממוינים למערך A,
ואת אותו מספר איברים קולטת למערך B.
התכנית תקצה מערך חדש C
המהווה הפרש בין קבוצת המספרים שבA
- לבין קבוצת המספרים שבB
C = A - B.
*/

#define TOTAL 100
//#define TOTAL 10
#define RANDOMALY true
//#define RANDOMALY false

int kelet (int maarach[]);
int miun (int maarach[], int max);
int pelet (int maarach[], int max = 0);
int hefresh(int maarachA[], int maarachB[], int maarachC[]);

int main() {
	int maarachA[TOTAL + 1], maarachB[TOTAL + 1], maarachC[TOTAL + 1];
	int a, b, c;
	a = kelet (maarachA);
	cout << "maarachA is:" << endl;
	pelet (maarachA, a + 1);
	b = kelet (maarachB);
	cout << "maarachB is:" << endl;
	pelet (maarachB, b + 1);

	miun (maarachA, a);
	cout << "maarachA (sorted) is:" << endl;
	pelet (maarachA);
	miun (maarachB, b);
	cout << "maarachB (sorted) is:" << endl;
	pelet (maarachB);

	hefresh(maarachA, maarachB, maarachC);
	cout << "maarachA - maarachB is:" << endl;
	pelet (maarachC);

	cout << endl;
	system ("pause");
	return 0;
}

int kelet (int maarach[]) {
	int i;

	if (RANDOMALY) {
		srand((unsigned)(time(NULL) * rand()));
		for (i = 0; i < TOTAL; ++i) maarach[i] = rand();
	} else {
		cout << "insert positive numbers:" << endl 
			<< "(insert negative-number for the end. maximum " << TOTAL << " numbers)" << endl;
		for (i = 0; i < TOTAL; ++i) {
			cin >> maarach[i];
			if (maarach[i] < 0) break;
		}
	}
	while(i < TOTAL) maarach[++i] = -1;

	return i;
}
int miun (int maarach[], int max) {
	int i, j;
	for (i = 0; i < max; ++i)
		for (j = i; j; --j) {
			if ((maarach[j] >= 0) && ((maarach[j] < maarach[j - 1]) || (maarach[j - 1] < 0)))
				swap (maarach[j], maarach[j - 1]);
			else if (maarach[j] != -1 && maarach[j] == maarach[j - 1]) 
				maarach[i=j] = -1;
			else break;
		}
		//pelet(maarach,max);
		return i;
}
int pelet (int maarach[], int max) {
	int i = 0;
	for (; (max == 0 && maarach[i] >= 0) || i < max; ++i)
		printf ((i % 13) ? "%5i " : "\n%5i " , maarach[i]);
	puts("");
	return i;
}
int hefresh(int maarachA[], int maarachB[], int maarachC[]) {
	//C = B - A;
	int i = 0, j = 0, k = -1;
	for (; maarachA[i] >= 0 && maarachB[j] >= 0; ++i) {
		while (maarachA[i] > maarachB[j]) j++;
		if (maarachA[i] < maarachB[j]) maarachC[++k] = maarachA[i];
	}
	for (; maarachA[i] >= 0; ++i) maarachC[++k] = maarachA[i];
	if (++k < TOTAL) maarachC[k] = -1;
	return k;
}