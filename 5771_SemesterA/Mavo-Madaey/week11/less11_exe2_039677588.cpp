#include <iostream>
using namespace std;
/*
������� ������� ��������� ������ ���� ����� ����, ������ �� ����� ��� ���� ������ �����
�� ����� ��� ������ ������ �� ������ ��� �����, �� ���� ������ ����
��� ����� ��� ����� �� �� �� ������, �� �� ��� ����� ��� �����...
//*/
bool checkVec(int *,int);

#define MAX 10

int main() {
	int vector[MAX];

	for (char a = 0; a < MAX; a++) {
		cout << "Insert a number (no. " << (int)a + 1 << " of " << MAX << "):\t";
		cin >> vector[a];
	}
	cout << (checkVec(vector, MAX - 1) ? "yes!" : "no!") << endl;

	cout << endl;
	system ("pause");
	return 0;
}

bool checkVec(int *vector,int last) {
	if (last < 3) return true;
	return ((*vector) + (*(vector + last)) == (*(vector + 1)) + (*(vector + last - 1)) && checkVec(vector + 1, last - 2));
}