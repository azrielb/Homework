#include <iostream>
using namespace std;

//������� ����� �� �� ������� ����-������� ������ ����� �������� ���� ������ ����� 3
//�� ���� ������ ������� ����:
//100x + 10y + z == x^3 + y^3 + z^3

//�� ����� ������� �� ������ �0 - ����� ������ �� �� ������� 0,1

int main() {
	char a,b,c;
	for (int i = 100; 1000 > i; i++) 
		if ((a = i % 10) * a * a + (b = (i / 10) % 10) * b * b + (c = i / 100) * c * c == i)		
			cout << i << endl;
	cout << endl;
	system ("pause");
	return 0;
}
