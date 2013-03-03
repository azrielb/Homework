#include <iostream>
#include <time.h>
using namespace std;

/*
4.	הגדר 2 מערכים: 
האחד ייקרא V
וגודלו 500 איברים, 
השני ייקרא B
וגודלו 100 איברים. 
התכנית תקלוט את מספר הנתונים שיש להכניס למערך V, 
מספר האיברים שיש להכניס למערך B 
ואחר כך את הנתונים עצמם למערכים הנ"ל. 
בתום הקלט התכנית תבדוק כמה פעמים נמצא המערך B
במערך V
*/

#define MAXB 100
#define MAXV 500
//#define RANDOMALY true
#define RANDOMALY false

int kelet (int maarach[], int num, char* name);
void pelet (int maarach[], int num);
int find(int maarachB[], int maarachV[], int numB, int numV);

int main() {
	int maarachB[MAXB], maarachV[MAXV];
	int numV = kelet (maarachV, MAXV, "maarachV");
	cout << "maarachV is:" << endl;
	pelet (maarachV, numV);

	int numB = kelet (maarachB, MAXB, "maarachB");
	cout << "maarachB is:" << endl;
	pelet (maarachB, numB);

	cout << "maarachB exist in maarachV " << find(maarachB, maarachV, numB, numV) << " times." << endl;

	cout << endl;
	system ("pause");
	return 0;
}

int kelet (int maarach[], int num, char* name) {
	cout << "how much numbers do you want to insert into " << name << " (maximum: " << num << ")?" << endl;
	int temp;
	cin >> temp;
	if (temp > num) cout << temp << " > " << num << '!' << endl;
	else num = temp;
	cout << endl;
	if (RANDOMALY) {
		srand((unsigned)(time(NULL) * rand()));
		for (int i = 0; i < num; ++i) maarach[i] = rand();
	} else {
		cout << "insert " << num << " numbers:" << endl;
		for (int i = 0; i < num; ++i) cin >> maarach[i];
	}
	return num;
}
void pelet (int maarach[], int num) {
	for (int i = 0; i < num; ++i)
		printf ((i % 13) ? "%5i " : "\n%5i " , maarach[i]);
	puts("");
}
int find(int maarachB[], int maarachV[], int numB, int numV) {
	//finding maarachB[] in maarachV[];
	int k = 0;
	for (int i = 0, j = 0; i < numV; ++i)
		if (maarachV[i] == maarachB[j]) {
			if (++j == numB) {
				++k;
				j = 0;
			}
		} else j = 0;
	return k;
}