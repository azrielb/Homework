#include <iostream>
#include <fstream>
#include <time.h>
using namespace std;

/*
מאתחל מטריצה בגודל 10*5 תווים (10 שורות, 5 תווים בכל שורה) ב- 10 מילים שונות, כאשר כל מילה בת 5 אותיות, אשר יילקחו מקובץ.
ממיין את המערך לקסיקוגרפית (מילונית) בעזרת מיון בועות
*/

#define SIZE 10
#define LENGTH 5

void kelet(char matrix[][LENGTH + 1]);
void pelet(char matrix[][LENGTH + 1]);
void miun(char matrix[][LENGTH + 1]);
bool compare_strings(char* matrixL, char* matrixR);// return true if (matrixL > matrixR)

int main() {
	char matrix[SIZE][LENGTH + 1];
	kelet(matrix);
	pelet(matrix);
	miun(matrix);
	cout << endl << "The sorted words are:" << endl;
	pelet(matrix);

	cout << endl;
	system ("pause");
	return 0;
}

void kelet(char matrix[][LENGTH + 1]) {
	char* ifilename = "less7_exe2_039677588.txt";
	//פותח את הקובץ
	ifstream words(ifilename);
	for (int i = 0; i < SIZE; ++i) words >> matrix[i];
	words.close();
}
void pelet(char matrix[][LENGTH + 1]) {
	for (int i = 0; i < SIZE; ++i) {
		cout << matrix[i] << ' ' << ' ';
	}	
	cout << endl;
}
void miun(char matrix[][LENGTH + 1]) {
	bool swaped;
	int a=0;
	do {
		swaped = false;
		for (int i = 1; i < SIZE; ++i)
			if (compare_strings(matrix[i - 1], matrix[i])) {
				for (int j = 0; j < LENGTH; ++j) swap(matrix[i - 1][j], matrix[i][j]);
				swaped = true;
			}
			pelet(matrix);
	} while (swaped && ++a < 1000);
}
bool compare_strings(char matrixL[], char matrixR[]) {
	for (int i = 0; matrixL[i] && matrixR[i]; ++i)
		if (matrixL[i] > matrixR[i])
			return true;
		else if (matrixL[i] < matrixR[i])
			return false;
	return false;
}
