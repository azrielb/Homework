#include <iostream>
#include <fstream>
using namespace std;

//������ ������ ���� ����� ��� �-A ����� ����� ��� �-B.
//���� ���, �� �������  ����� ������ �����  �� ������ ���� �-A �� �� ����� ������� ������ ���� �-B.
//�� ������� ������ �� ���� ������� ������.
//���� ����� �����, ���� ��� ��� ��� ���� ����� ���� ���, ����� ����� ����.

int main() {
	int sum = 0, counter = 0, temp = 0;
	unsigned int maxs, maxc;

	//���� ������� �� ���� ��������
	cout << "Hello!" << endl << "Please insert the sum-maximum: ";
	cin >> maxs;
	cout << "Please insert the numbers-maximum: ";
	cin >> maxc;

	//���� �� �����
	ifstream thenumbers("less4_exe2_039677588.txt");
	//�� ��� ������� �������� - ���� ������, �����
	while (((sum += temp) < (int)maxs) && (counter++ < (int)maxc)) thenumbers >> temp;
	//��� ����
	cout << "The sum of " << counter << " numbers is " << sum << endl;

	cout << endl;
	system ("pause");
	return 0;
}
