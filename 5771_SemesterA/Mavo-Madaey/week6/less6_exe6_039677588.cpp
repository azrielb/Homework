#include <iostream>
#include <time.h>
using namespace std;

/*
תכנית הקולטת 2 מטריצות, הראשונה מסדר MxN
והשניה מסדר NxK
ומדפיסה מטריצה המהווה את מכפלת המטריצות.
(כפל מטריצות ייעשה בצורה לינארית כך שערך התא ה i,j
מהווה סכום הכפלת איבר שורה i
ממטריצה ראשונה באברי עמודה j
ממטריצה שניה).
*/

int** kelet (int rows, int cols);
void pelet (int** matrix, int rows, int cols);
int** multy_matrix(int** matrixA, int** matrixB, int rowsA, int colsA, int colsB);
void del2dim(int** &matrix, int num1);

int main() {
	int m, n, k;//קבעתי מקסימום 7 כדי שבטוח הכל יכנס למסך אחד
	do {
		cout << "Insert rows-number of first-matrix (maximum: 7):";
		cin >> m;
	} while (m < 1 || m > 7);
	do {
		cout << "Insert cols-number of first-matrix (maximum: 7) " << endl
			<< "(this is also the rows-number of second-matrix):";
		cin >> n;
	} while (n < 1 || n > 7);
	do {
		cout << "Insert cols-number of second-matrix (maximum: 7):";
		cin >> k;
	} while (k < 1 || k > 7);

	int** matrixA = kelet(m, n);
	int** matrixB = kelet(n, k);
	int** matrixC = multy_matrix(matrixA, matrixB, m, n, k);
	cout << "matrixA is:" << endl;
	pelet(matrixA, m, n);
	cout << "matrixB is:" << endl;
	pelet(matrixB, n, k);
	cout << "matrixA * matrixB is:" << endl;
	pelet(matrixC, m, k);

	del2dim(matrixA, m);
	del2dim(matrixB, n);
	del2dim(matrixC, m);

	cout << endl;
	system ("pause");
	return 0;
}

int** kelet (int rows, int cols) {
	//int** matrix = new int[rows][cols]; //ככה ד"ר שטולמן כתב בשיעור, אבל זה נותן שגיאת-קימפול
	int** matrix = new int*[rows];

	srand((unsigned)(time(NULL) * rand()));
	for (int i = 0; i < rows; ++i) {
		matrix[i] = new int[cols];
		for (int j = 0; j < cols; ++j)
			matrix[i][j] = rand()/2; //החלוקה ל2 כדי למנוע גלישה
	}
	return matrix;
}
void pelet (int** matrix, int rows, int cols) {
	for (int i = 0; i < rows; ++i) {
		for (int j = 0; j < cols; ++j)
			printf ("%10i ", matrix[i][j]);
		cout << endl;
	}	
	cout << endl;
}
int** multy_matrix(int** matrixA, int** matrixB, int rowsA, int colsA, int colsB) {
	int** matrix = new int*[rowsA]; //כנ"ל...
	for (int i = 0; i < rowsA; ++i) {
		matrix[i] = new int[colsB];
		for (int j = 0, sop; j < colsB; ++j) {
			for (int k = sop = 0; k < colsA; ++k)
				sop += matrixA[i][k] * matrixB[k][j];
			matrix[i][j] = sop;
		}
	}
	return matrix;
}
void del2dim(int** &matrix, int num1) {
	for (int i = 0; i < num1; ++i) delete[] matrix[i];
	delete[] matrix;
	matrix = NULL;
}