#include <iostream>
using namespace std;

/*
1.	���� ���� ��� ��� � 100. �� �� ������ �������� ���� ���� �� ������, ���� �� ���� ������ �������� ���� ����� ����� ������. �� �� ������ �������� ���� ��  ������ ���� �� ������ ����� ����� ������. ���� ���� "���� ������".
*/
int main() 
{
	int num, sum, multiple;
	do {
		cout << "Please enter a number between 0 & 99" << endl;
		cin >> num;
		cout << endl;
	} while (num < 0 || num > 99);

	sum = num / 10 + num % 10;
	multiple = (num / 10) * (num % 10);

	if (sum % 2) {
		cout << "The number " << num << " is a mixed number!";
	} else if (multiple % 2) {
		cout << "The number that you have entered is " << num << ", and the sum of its digits is " << sum;
	} else {
		cout << "The number that you have entered is " << num << ", and the multiple of its digits is " << multiple;
	}
	cout << endl << endl;
	system("pause");
	return 1;
}
