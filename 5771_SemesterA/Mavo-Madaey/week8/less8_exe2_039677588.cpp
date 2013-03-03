#include <time.h>
#include <iostream>
using namespace std;

#define RANDOMALY true
//#define RANDOMALY false
#define CAPACITY 201
//#define CAPACITY 5

void vecInput(int* vec,int capacity);
int vecAbouveAvg(int * vec, int capacity);
void vecCpy(int * src, int * dst, int capacity);
bool vecSorted(int * vec1, int * vec2, int capacity);
int* vecCat(int * vec1, int * vec2, int capacity);
int* vecRev(int * vec , int capacity);
void vecOutput(int * vec , int capacity);

int main() 
{
	int *a = new int[CAPACITY], *b = new int[CAPACITY], *vec1 = a, *vec2 = b, tmp1;

	vecInput(vec1, CAPACITY);

	cout << "vec1 is:" << endl;
	vecOutput(vec1 , CAPACITY);

	cout << vecAbouveAvg(vec1, CAPACITY) << " numbers are above the avarage." << endl << endl;

	vecCpy(vec1 + 2, vec2, CAPACITY);

	cout << "vec2 is:" << endl;
	vecOutput(vec2 , CAPACITY);

	cout << "Two arrays are " << (vecSorted(vec1, vec2, CAPACITY) ? "" : "not ") << "sorted in the same way" << endl << endl;

	vec1 = vecCat(vec1, vec2, CAPACITY);

	cout << "vec1 united with vec2 is:" << endl;
	vecOutput(vec1 , CAPACITY);

	vec2 = vecRev(vec1 , CAPACITY);

	cout << "and invers:" << endl;
	vecOutput(vec2 , CAPACITY);

	/*
	שורות אלו גורמות לשגיאה שלא הצלחתי להבין אותה
	delete [] a;
	delete [] b;
	delete [] vec2;
	*/

	cout << endl;
	system("pause");
	return 0;
}

/* פונקציה המקבלת את המערך ואת גודלו וקולטת לתוכו נתונים עד לקבלת מספר שלילי -מקסימום capacity-1 ערכים */
void vecInput(int* vec,int capacity) {
	int temp;
	if (RANDOMALY) {//העתקתי קוד קיים מתרגילים ישנים, בשינויים המתבקשים
		srand((unsigned)(time(NULL) * rand())); //ההכפלה במספר אקראי משפרת את האקראיות במקרה שקוראים לפונקציה כמה פעמים
		while (--capacity) {
			temp = 2 * rand() - RAND_MAX / 100;//נתתי סיכוי קטן למספר שלילי...
			*(vec++) = temp;
			if (temp < 0) break;
		}
	} else {
		cout << "insert positive numbers:" << endl 
			<< "(insert negative-number for the end. maximum " << (capacity - 1) << " numbers)" << endl;
		while (--capacity) {
			cin >> temp;
			*(vec++) = temp;
			if (temp < 0) break;
		}
	}
	*vec = -1;
}

/*פונקציה המקבלת את המערך ואת גודלו ומחזירה כמה ערכים גדולים מהממוצע קיימים במערך.
המערך ייסקר עד למספר שלילי או עד capacity איברים*/
int vecAbouveAvg(int * vec, int capacity) {
	int i, avg, above = 0;
	long sum = 0;

	//חישוב הממוצע
	for (i = 0; i < capacity; ++i) {
		if ((avg = *(vec + i)) < 0) break;
		else sum += avg;
	}
	if ((capacity = i) > 0) avg = sum / i; else return 0;

	//ספירת האיברים הגדולים מהממוצע
	for (i = 0; i < capacity; ++i)
		if (*(vec + i) > avg)
			++above;

	return above;
}

/*פונקציה המקבלת 2 מערכים בגודל שווה ואת גודלם ומעתיקה את תוכן המערך הראשון לתוך המערך השני.*/
void vecCpy(int * src, int * dst, int capacity) {
	int temp, i;
	for (i = 0; i < capacity; ++i)
		if ((temp = *(dst + i) = *(src + i)) < 0)
			break;
	*(dst + i) = -1;
}

/*פונקציה המקבלת 2 מערכים בגודל שווה ואת גודלם ובודקת האם 2 המערכים ממוינים בסדר עולה או שני המערכים ממוינים בסדר יורד*/
bool vecSorted(int * vec1, int * vec2, int capacity) {
	char sorted = 0; // 0 = not sorted, 1 = smallest --> biggest, 2 = biggest --> smallest
	for (int i = 0, temp1, temp2; i < capacity; ++i) {
		temp1 = *(vec1 + i);
		temp2 = *(vec2 + i);
		if (temp1 < 0 || temp2 < 0) break;
		if (!sorted) {
			sorted = (temp1 <= temp2) ? (temp1 < temp2) ? 1 : 0 : 2;
		} else if (sorted == 1) {
			if (temp1 > temp2) return false;
		} else {
			if (temp1 < temp2) return false;
		}
	}
	return true;
}

/*הפונקציה מקבלת 2 מערכים ואת גודלו המקסימלי של vec1
ומעתיקה את איברי vec2 
לסוף vec1.*/
int* vecCat(int * vec1, int * vec2, int capacity) {
	int i = 0, temp;
	--vec2;
	while (i < capacity && *(vec1 + i) >= 0) ++i;
	while (i < capacity && (temp = *(++vec2)) >= 0) *(vec1 + i++) = temp;
	*(vec1 + i) = -abs(*vec2);
	return vec1;
}

/*הפונקציה מקבלת מערך שלמים ואת גדלו, הופכת את סדר איבריו ומחזירה את המערך בסדר הפוך.*/
int* vecRev(int * vec , int capacity) {
	int i;
	for (i = 0; i < capacity && *(vec + i) >= 0; ++i) ;
	int * rev = new int[capacity = i];
	for (i = 0; i < capacity; ++i) *(rev + capacity - i - 1) = *(vec + i);

	return rev;
}

void vecOutput(int * vec , int capacity) {
	for (int i = 0; i < capacity && *(vec + i) >= 0; ++i)
		cout << *(vec + i) << (((i + 1) % 10) ? '\t' : '\n');
	cout << endl << endl;
}