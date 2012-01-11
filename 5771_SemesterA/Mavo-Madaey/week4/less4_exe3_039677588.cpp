#include <iostream>
using namespace std;

//���: ���� ����� ����.
//���: ����� �� �� �� ���� ���- ������ �� �� ���� ����� ���� ��� ���� ���� ������ ���� �� �����.

int main() {
	unsigned int root1 = 1, root2, root3, square, num;
	cout << "Hello, Pythagoras..." << endl << "Please insert an positive integer number: ";
	cin >> num;
	root2 = num;
	//����� ����� ������� ���� �����
	while (root1 != root2) {
		if ((square = (root3 = (root1 + root2) / 2) * root3) == num) root1 = root2 = root3;
		else if (root1 + 1 == root2) root1 = root2; //����� ����� ��������
		else if (square > num) root2 = root3;
		else root1 = root3;
	}//�������� ���� �������, �� ���� ������ �� ����� �� ���� ���
	if (root1 * root2 == num) cout << endl << "The number " << num << " has a square root: " << root1;
	else cout << "Your number doesn't have a square root";

	cout << '.' << endl << endl;
	system ("pause");
	return 0;
}