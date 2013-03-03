#include <iostream>
using namespace std;

class rational {
private:
	int a, b; // rational = a/b
	void tzimtum();
public:
	float get() { return a / (float)b; }
	void set(int m = 0, int n = 1, bool tzimtzum = true); // rational = m/n
	void printer(bool endl = true);
	rational(int a = 0, int b = 1) { set(a, b); }
	rational(rational const &other):a(other.a), b(other.b) { }
	rational operator + (rational const &other) const;
	rational operator - (rational const &other) const;
	rational operator * (rational const &other) const;
	rational operator / (rational const &other) const;
	void operator = (rational const &other) { set(other.a, other.b, false); }
	bool operator == (rational const &other) const { return (a == other.a && b == other.b); }
	bool operator > (int num) const { return (a > (num * b)); }
	bool operator < (int num) const { return (a < (num * b)); }
	bool operator > (rational const &other) const { return (a * other.b > b * other.a); }
	bool operator < (rational const &other) const { return (a * other.b < b * other.a); }
	bool operator != (rational const &other) const { return (a != other.a || b != other.b); }
	bool operator >= (rational const &other) const { return (a * other.b >= b * other.a); }
	bool operator <= (rational const &other) const { return (a * other.b <= b * other.a); }
};

inline bool mechalek(int a, int b) { return ((a / b) * b == a); }
inline void print_bool(bool the_bool, bool endline = true) { 
	cout << (the_bool ? "true" : "false");
	if (endline) cout << endl;
}

int main() {
	int a, b, c, d;
	cin >> a >> b >> c >> d;
	if 
	rational num1(a, b), num2(c, d), num3(num1 + num2);
	num3.printer();
	num3 = num1 - num2;
	num3.printer();
	num3 = num1 * num2;
	num3.printer();
	num3 = num1 / num2;
	num3.printer();
	print_bool(num1 < num2);
	print_bool(num1 <= num2);
	print_bool(num1 == num2);
	print_bool(num1 != num2);
	print_bool(num1 >= num2);
	print_bool(num1 > num2, false);

//	system("pause");
	return 0;
}

void rational::tzimtum() {
	if (b == 0) a = 0; // היה ראוי להחזיר שגיאה, אבל אין כזאת אפשרות...
	if (a == 0) { b = 1; return; } // חבל על ההשקעה...

	bool shlili = (a * b < 0);
	a = abs(a);
	b = abs(b);
	for (int i = a > b ? b : a; i > 1; --i) if (mechalek(a, i) && mechalek(b , i)) { a /= i; b /= i; }
	if (shlili) a *= -1;
}

void rational::set(int m, int n, bool tzimtzum) {
	a = m;
	b = n;
	if (tzimtzum) tzimtzum();
}
rational rational::operator + (rational const &other) const {
	rational ret(a , b);
	ret.set(a * other.b + b * other.a, other.b * b);
	return ret;
}
rational rational::operator - (rational const &other) const {
	rational ret(a , b);
	ret.set(a * other.b - b * other.a, other.b * b);
	return ret;
}
rational rational::operator * (rational const &other) const {
	rational ret(a , b);
	ret.set(a * other.a, other.b * b);
	return ret;
}
rational rational::operator / (rational const &other) const {
	rational ret(a , b);
	ret.set(a * other.b, b * other.a);
	return ret;
}
void rational::printer(bool endline) { 
	if (b == 1) cout << a; else cout << a << '/' << b; 
	if (endline) cout << endl;
}
