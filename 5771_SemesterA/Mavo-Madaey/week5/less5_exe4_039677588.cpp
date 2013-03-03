#include <iostream>
using namespace std;

float rand_plusminus(float r) {
	static bool flag = true;
	if (flag) {
		srand(rand() * (int)r);
		srand(rand() * (int)r);
		srand(rand() * (int)r);
		flag = false;
	}
	return (2 * r * rand()) / RAND_MAX - r;
}
bool randomal_dot_in_circle(float r = 1.0) {
	float x = rand_plusminus(r);
	float y = rand_plusminus(r);
	return (x * x + y * y <= r * r);
}
float area(float r, unsigned long n = 10000) {
	unsigned long num = 0;
	for (unsigned long a = 0; a < n; a++) num += randomal_dot_in_circle(r);
	return 4 * r * r * num / n;
}

//הערכת שטח מעגל
int main() {
	float r;
	unsigned long n;
	cout << "Please insert the radius of the circle: ";
	cin >> r;
	cout << "Please insert how much times to test: ";
	cin >> n;
	cout << "The area of the circle is about " << area(r, n) << endl;

	cout << endl;
	system ("pause");
	return 0;
}