#include <iostream>
using namespace std;
#define MY_PI 3.14159265358979323846 //הגדרתי בעצמי, כי הוא עשה לי בעיות בכל צורה אחרת

class circle {
private:
	float xm, ym, r;
public:
	float area() { return r * r * MY_PI; }
	float line() { return 2 * r * MY_PI; }
	bool incircle(float x0, float y0) { return ((r * r) > ((xm - x0) * (xm - x0) + (ym - y0) * (ym - y0))); }
	circle(float radius, float x_m = 0, float y_m = 0) : xm(x_m), ym(y_m), r(radius) {};
};

int main() {
	float xm, ym, r, x0, y0;
	cin >> xm >> ym >> r >> x0 >> y0;
	circle igul(r, xm, ym);
	printf("%0.2f %0.2f %s", igul.area(), igul.line(), (igul.incircle(x0, y0) ? "in" : "out"));

	return 0;
}

