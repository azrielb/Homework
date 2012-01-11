#include <iostream>
#include <time.h>
using namespace std;

/*
מאתחל מערך בגודל 10*10 במספרים אקראיים.
ממיין את המשולש השמאלי התחתון ואת המשולש הימני העליון בעזרת מיון הכנסה.
האלכסון הראשי יישאר כמו במטריצה המקורית
*/

#define SIZE 10

void kelet(int matrix[][SIZE]);
void pelet(int matrix[][SIZE]);
void miun(int matrix[][SIZE]);
void meshulashTOvector(int matrix[][SIZE], int vector[], bool upper);
void vectorTOmeshulash(int vector[], int matrix[][SIZE], bool upper);
void insertsort(int vector[], int max = SIZE * (SIZE - 1) / 2);

int main() {
	int matrix[SIZE][SIZE];
	kelet(matrix);
	pelet(matrix);
	miun(matrix);
	cout << "The \"sorted\" matrix is:" << endl;
	pelet(matrix);

	cout << endl;
	system ("pause");
	return 0;
}

void kelet(int matrix[][SIZE]) {
	srand((unsigned)(time(NULL) * rand() * rand() * rand()));
	for (int i = 0; i < SIZE; ++i)
		for (int j = 0; j < SIZE; ++j)
			matrix[i][j] = rand();
}
void pelet(int matrix[][SIZE]) {
	for (int i = 0; i < SIZE; ++i) {
		for (int j = 0; j < SIZE; ++j)
			printf ("%6i ", matrix[i][j]);
		cout << endl;
	}	
	cout << endl;
}
void miun(int matrix[][SIZE]) {
	const int max = SIZE * (SIZE - 1) / 2;
	int vector[max];
	meshulashTOvector(matrix, vector, true);
	insertsort(vector, max);
	vectorTOmeshulash(vector, matrix, true);
	meshulashTOvector(matrix, vector, false);
	insertsort(vector, max);
	vectorTOmeshulash(vector, matrix, false);
}
void meshulashTOvector(int matrix[][SIZE], int vector[], bool upper) {
	int j, k = -1;
	if (upper)
		for (int i = 0; i < SIZE - 1; ++i)
			for (j = i + 1; j < SIZE; ++j)
				vector[++k] = matrix[i][j];
	else
		for (int i = 1; i < SIZE; ++i)
			for (j = 0; j < i; ++j)
				vector[++k] = matrix[i][j];
}
void vectorTOmeshulash(int vector[], int matrix[][SIZE], bool upper) {
	int j, k = -1;
	if (upper)
		for (int i = 0; i < SIZE - 1; ++i)
			for (j = i + 1; j < SIZE; ++j)
				matrix[i][j] = vector[++k];
	else
		for (int i = 1; i < SIZE; ++i)
			for (j = 0; j < i; ++j)
				matrix[i][j] = vector[++k];
}
void insertsort(int vector[], int max) {
	int j;
	for (int i = 0; i < max; ++i)
		for (j = i; j; --j)
			if (vector[j] < vector[j - 1])
				swap (vector[j], vector[j - 1]);
}