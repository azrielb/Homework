#include <iostream>
#include <stdlib.h>
#include <stdio.h>

using namespace std;

void reverseNum(unsigned long, unsigned long &);

int main() {
	unsigned long number, revnumber;
	cin >> number;
	reverseNum(number, revnumber);
	cout << "The reversed number is " << revnumber << endl;

	cout << endl;
	system ("pause");
	return 0;
}
/*
�� ������ ����� ��� ����� ����� ������� �� ������ ������ ���� �� ��������
��� ������ ����� http://moodle.jct.ac.il/mod/resource/view.php?id=56778
����� ���� �� ����� �� ����� ��� ����.
������ ��� ��� �������� ������, �� ��� ����, ���� ������ ������� ����� �� ����� ���
���, ���� �� ��� ������� ���� ������ �� �� �������� - ����� ���� ����� ���� ����� �������� ����
�� ������� ����, �� ������ ��� ��� ���� ���� �� ���� ������� �� ������ ���� ������ ��� ����� ���� ���.
�������.
*/
void reverseNum(unsigned long src, unsigned long & dest) {
	if (src < 10) {
		dest = src;
		return;
	}
	int z = src % 10;
	reverseNum(src / 10, dest);
	char buffer[12];
	sprintf(buffer, "%d%d\0", z, dest);
	dest = strtoul(buffer, NULL, 0);
}