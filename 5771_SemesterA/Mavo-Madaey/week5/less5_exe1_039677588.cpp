#include <iostream>
using namespace std;

float square_area(float x ,float y) {
	if ((x > 0) && (y > 0)) return x * y;
	return 0;
}
float circle_area(float r) {
	if (r > 0) return r * r * 3.141592654;
	return 0;
}
inline float area_ovrld(float x ,float y) { return square_area(x ,y);};
inline float area_ovrld(float r) { return circle_area(r);};
float area_dflt(float x ,float y = -5.5) {
	if (x < 0) return 0;
	if (y < 0) return x * x * 3.141592654;
	return x * y;
}

int main() {
	float s1, s2, s3, x, y, r;
	cout << "Please insert the length of the rectangle: ";
	cin >> x;
	cout << "Please insert the width of the rectangle: ";
	cin >> y;
	cout << "Please insert the radius of the circle: ";
	cin >> r;

	s1 = square_area(x ,y);
	s2 = area_ovrld(x ,y);
	if (y < 0) y=0;
	s3 = area_dflt(x ,y);
	if ((s1 != s2) || (s1 != s3))
		cout << "Error in the functions: s1=" << s1 << ", s2=" << s2 << ", s3=" << s3 << endl;
	else {
		if (s1 == 0) cout << "Error in typing: ";
		cout << "The area of the rectangle is " << s1 << endl;
	}
	s1 = circle_area(r);
	s2 = area_ovrld(r);
	s3 = area_dflt(r);
	if ((s1 != s2) || (s1 != s3))
		cout << "Error in the functions: s1=" << s1 << ", s2=" << s2 << ", s3=" << s3 << endl;
	else {
		if (s1 == 0) cout << "Error in typing: ";
		cout << "The area of the circle is " << s1 << endl;
	}

	system ("pause");
	return 0;
}