#include <iostream>
#include <time.h>
using namespace std;

/*
פונקציה המקבלת מערך דו-ממדי של מספרים שלמים בגודל 10 על 10, ומספר חיובי k,
ומחזירה את תשובת התנאי אם קיים ריבוע-פלוס בגודל k x k
ריבוע-פלוס הוא תת מטריצה ריבועית שסכום אבריה גדול מ0
*/

#define SIZE 10

bool efes(int matrix[][SIZE], int k);
void kelet(int matrix[][SIZE]);
void pelet(int matrix[][SIZE]);

int main() {
	int matrix[SIZE][SIZE];
	int k;
	kelet(matrix);
	pelet(matrix);
	cout << "how much is the RIBUA-size?";
	cin >> k;
	cout << "the matrix has " << (efes(matrix, k) ? "at least 1" : "no") << " RIBUA-PLUS.";

	cout << endl;
	system ("pause");
	return 0;
}

bool efes(int matrix[][SIZE], int k) {
	int i, j, a, b; // counters
	int sum;
	for (i = 0; i <= SIZE - k; ++i) {
		for (j = 0; j <= SIZE - k; ++j) {
			sum = 0;
			for (a = i; a < i + k; ++a) {
				for (b = j; b < j + k; ++b) {
					sum += matrix[a][b];
				}
			}
			if (sum > 0) return true;
		}
	}
	return false;
}
void kelet(int matrix[][SIZE]) {
	srand((unsigned)(time(NULL) * rand()));
	for (int i = 0; i < SIZE; ++i)
		for (int j = 0; j < SIZE; ++j)
			matrix[i][j] = rand() - RAND_MAX / 2;
}
void pelet(int matrix[][SIZE]) {
	for (int i = 0; i < SIZE; ++i) {
		for (int j = 0; j < SIZE; ++j)
			printf ("%6i ", matrix[i][j]);
		cout << endl;
	}	
	cout << endl;
}