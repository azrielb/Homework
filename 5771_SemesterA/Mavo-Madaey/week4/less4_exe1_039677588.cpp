#include <iostream>
#include <math.h>
#include <time.h>
using namespace std;

//������ 10 ������ ����� ����� ������ ��� �1000, ������ ��� �� ������� ����� �����
int main() {
	int temp, myrand= -2000;
	srand(time(NULL));

	for(char a=1;a<11;a++) {
		cout << "The number No. " << (int)a << " is " << (temp = rand() % 2001 - 1000) << endl;
		if (myrand > temp) myrand = 3000; 
		else myrand = temp;
	}
	cout << endl << "The numbers are ";
	if (myrand == 3000) cout << "not ";
	cout << "sorted." << endl << endl;

	system ("pause");
	return 0;
}