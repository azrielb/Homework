#include <iostream>
using namespace std;

int main() {
	float num[3];
	cin >> num[0] >> num[1] >> num[2];
	printf ("The average is %0.2f" ,(num[0] + num[1] + num[2]) / 3.0);
	return 0;
}
