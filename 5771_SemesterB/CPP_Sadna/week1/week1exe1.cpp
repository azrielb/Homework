#include <iostream>
using namespace std;

inline bool mechalek(int a, int b) { return ((a / b) * b == a); }
inline void print_equal(bool is_equal) { cout << (is_equal ? "equal" : "different"); }

class rational {
private:
	int a, b; // rational = a/b
	void tzimtum();
public:
	bool equal(rational other) { return ((a == other.a) && (b == other.b)); }
	float get() { return a / (float)b; }
	void set(int m = 0, int n = 1); // rational = m/n
	void printer() { cout << a << '/' << b << ' '; }
	rational(int a = 0, int b = 1) { set(a, b); }
};

int main() {
	int a, b, c, d;
	cin >> a >> b >> c >> d;
	rational num1(a, b), num2(c, d);
	num1.printer();
	num2.printer();
	print_equal(num1.equal(num2));
	return 0;
}

void rational::tzimtum() {
	if (b == 0) a = 0; // היה ראוי להחזיר שגיאה, אבל אין כזאת אפשרות...
	if (a == 0) { b = 1; return; } // חבל על ההשקעה...

	bool shlili = (a < 0 ^ b < 0);
	a = abs(a);
	b = abs(b);
	int i = a > b ? b : a;
	while (i > 1) {
		if (mechalek(a, i) && mechalek(b , i)) { a /= i; b /= i; }
		--i;
	}
	if (shlili) a = 0 - a;
}

void rational::set(int m, int n) {
	a = m;
	b = n;
	tzimtum();
}
