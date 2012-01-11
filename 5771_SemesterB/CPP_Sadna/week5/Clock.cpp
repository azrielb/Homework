#include <iostream>
#include <time.h>

using namespace std;

class Clock {
private:
	short second;
	short minute;
	short hour;
	void validate();
	bool validator;
public:
	Clock(short s = -1, short m = -1, short h = -1) : second(s), minute(m), hour(h) { validate(); }
	bool setSecond(short s) { second = s; validate(); return validator; }
	bool setMinute(short m) { minute = m; validate(); return validator; }
	bool setHour(short h) { hour = h; validate(); return validator; }
	short getSecond() { return second; }
	short getMinute() { return minute; }
	short getHour() { return hour; }
	bool isvalid() { return validator; }
	friend ostream& operator<< (ostream& os, const Clock c);
	friend istream& operator>> (istream& is, Clock& c);
};

void Clock::validate() {
	validator = (0 <= hour && hour < 24 && 0 <= minute && minute < 60 && 0 <= second && second < 60);
	if (validator) return;
	char tbuffer[9];
	_strtime_s(tbuffer);
	hour = (tbuffer[0] - '0') * 10 + tbuffer[1] - '0';
	minute = (tbuffer[3] - '0') * 10 + tbuffer[4] - '0';
	second = (tbuffer[6] - '0') * 10 + tbuffer[7] - '0';
}

ostream& operator<<(ostream& os, const Clock c) {
	if (c.hour < 10) os << '0';
	os << c.hour << ':';
	if (c.minute < 10) os << '0';
	os << c.minute << ':';
	if (c.second < 10) os << '0';
	os << c.second;
	return os;
}

istream& operator>>(istream& is, Clock& c) {
	is >> c.hour >> c.minute >> c.second;
	c.validate();
	return is;
}

int main () {
	Clock clk1;
	cout << "the time now is: " << clk1 << endl;
	cout << "\n\nPlease insert your time (hours, minute, seconds - seperated by white-spaces):\n";
	cin >> clk1;
	cout << "Your time ";
	if (!clk1.isvalid()) cout << "is invalid. the time now ";
	cout << "is: " << clk1;

	short temp[3];
	cout << "\n\nPlease enter your time (hours, minute, seconds - seperated by white-spaces):\n";
	cin >> temp[0] >> temp[1] >> temp[2];

	cout << "Your time ";
	if (!clk1.setHour(temp[0]) || !clk1.setMinute(temp[1]) || !clk1.setSecond(temp[2])) {
		clk1.setHour(-1); //Invalid argument for setting the current time (now).
		cout << "is invalid. the time now ";
		temp[0] = clk1.getHour();
		temp[1] = clk1.getMinute();
		temp[2] = clk1.getSecond();
	}
	cout << "is: ";
	if (temp[0] < 10) cout << '0';
	cout << temp[0] << ':';
	if (temp[1] < 10) cout << '0';
	cout << temp[1] << ':';
	if (temp[2] < 10) cout << '0';
	cout << temp[2] << endl;
	system ("pause");
}