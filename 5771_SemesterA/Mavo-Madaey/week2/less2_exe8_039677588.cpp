#include <iostream>
using namespace std;
//����� �� "���� �������", �"� ������ �� 220 ���� ����, ���� 72%-87%
int main() 
{
	float age;

	//���
	cout << "Hello, the gymnast." << endl;
	do {
		cout << endl << "Please enter your age" << endl;
		cin >> age;
	} while (age <= 0);

	//����� ����
	age = 220 - age;
	cout << endl << "Your training-range is betwwen " << 0.72 * age << " & " << 0.87 * age << endl << endl;

	system("pause");
	return 1;
}
