#include <iostream>
using namespace std;

/*
המספרים המשוכללים הראשונים הם:
6
28
496
8128
33550336
8589869056
137438691328
2305843008139952128
2658455991569831744654692615953842176
191561942608236107294793378084303638130997321548169216
מקור: http://he.wikipedia.org/wiki/מספר_מושלם
//*/

bool perfect(unsigned long number) {
	unsigned long sum = 0;
	for (unsigned long a = 1; a < number; a++) if (number % a == 0) sum += a;
	return (sum == number);
}
void check(unsigned long a) {
	for (; a > 0; a--) if (perfect(a)) cout << a << " is a perfect number" << endl;
}
int main() {
	unsigned long a;
	cout << "Do you find perfect numbers? Please insert the maximum of the numbers: ";
	cin >> a;
	check(a);

	cout << endl;
	system ("pause");
	return 0;
}