#include <iostream>
using namespace std;

/*
���� ����� ��� ����� ����� �� 15 ������ �����.
�� ������ ������ �� ����� GOOD ����� �������� ������ �� ������� ��� 1 �15,  ���� �� ������ �� ����� NO.
*/

#define TOTAL 15

int main() {
	int input;
	bool checker[TOTAL] = {false};
	int counter = TOTAL;
	for (int i = 1; i <= TOTAL; ++i) {
		cout << "Please enter a number (no. " << i << "): ";
		cin >> input;
		//����� ��� ����� ���� ����� �����, ������ �� �����
		if (0 < input && input <= TOTAL && !checker[input - 1]) {
			checker[input - 1] = true;
			counter--;//������ ������ ����� ��� ��� ������ (����� �"� ���� ����� 25) ������ ��� ������ �����
		}
	}
	cout << ((counter) ? "No!." : "Good!") << endl;
	//if (counter) cout << counter;
	cout << endl;
	system ("pause");
	return 0;
}