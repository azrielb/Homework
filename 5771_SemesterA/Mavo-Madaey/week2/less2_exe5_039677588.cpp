#include <iostream>
using namespace std;

//���� �� 4 ������ ������ �� ��� ������ ������� �������
int main() 
{
	float a, b;

	cout << "Hello, are you a scientist?" << endl << endl << "Please enter 1st number" << endl;
	cin >> a;
	cout << endl << "Please enter 2nd number" << endl;
	cin >> b;

	cout << endl
		<< a << " + " << b << " = " << a + b << endl
		<< a << " - " << b << " = " << a - b << endl
		<< a << " * " << b << " = " << a * b << endl
		<< a << " / " << b;
	//����� �� �� ����� ����, ���� �����
	if (b == 0 ) cout << " is divisin by zero!\n\n"; else cout << " = " << a / b << endl << endl;

	system("pause");
	return 1;
}
