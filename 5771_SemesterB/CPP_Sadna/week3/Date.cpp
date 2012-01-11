#include <iostream>
using namespace std;

class Date {
private:
	int day;
	int month;
	int year;
public:
	Date(int d = 1, int m = 1, int y = 1);
	Date(const Date & other) : day(other.day), month(other.month), year(other.year) {}
	Date operator = (Date other) { day = other.day; month = other.month; year = other.year; return (*this); }
	Date operator ++ () { return (*this) += 1; }
	Date operator ++ (int z);
	Date operator += (int plus);
	bool operator < (Date other) const;
	bool operator > (Date other) const;
	bool operator == (Date other) const { return (day == other.day && month == other.month && year == other.year); }
	bool setDate(int d, int m, int y);
	void print(bool EndLine = true) const { cout << day << '/' << month << '/' << year << (EndLine ? '\n' : ' '); }
};

Date::Date(int d, int m, int y) {
	if (!setDate(d, m, y)) {
		day = month = year = 0; // A wrong date
	}
}
bool Date::setDate(int d, int m, int y) {
	if (1 > d || d > 30 || 1 > m || m > 12 || 1 > y) return false; // All years have 12 months. All months have 30 days.
	day = d;
	month = m;
	year = y;
	return true;
}
Date Date::operator += (int plus) {
	day += plus;
	while (day > 30) {
		++month;
		day -= 30;
	}
	while (month > 12) {
		++year;
		month -= 30;
	}
	return *this;
}
Date Date::operator ++ (int z) {
	Date temp = *this;
	(*this) += 1;
	return temp;
}
bool Date::operator < (Date other) const {
	if (year < other.year) return true;
	if (year > other.year) return false;
	if (month < other.month) return true;
	if (month > other.month) return false;
	return (day < other.day);
}
bool Date::operator > (Date other) const { // Another method for solving same problem...
	return ((day + month * 30 + year * 360) > (other.day  + other.month * 30 + other.year * 360));
}

int main () {
	Date first(1,2,4), secound;
	cout << "First - 1,2,4 :\t";
	first.print();

	cout << "Secound - Default:\t";
	secound.print();

	cout << "Resetting secound - 1,1,4 :\t";
	secound.setDate(1,1,4);
	secound.print();

	cout << "\nsecound = ++first:\n";
	secound = ++first;
	cout << "First (";
	first.print(false);
	cout << ") " << (first == secound ? "==" : "!=") << " Secound (";
	secound.print(false);
	cout << ")" << endl;

	cout << "\nsecound = first += 5:\n";
	secound = first += 5;
	cout << "First (";
	first.print(false);
	cout << ") " << (first == secound ? "==" : "!=") << " Secound (";
	secound.print(false);
	cout << ")" << endl;

	cout << "\nsecound = first++:\n";
	secound = first++;
	cout << "First (";
	first.print(false);
	cout << ") " << (first == secound ? "==" : "!=") << " Secound (";
	secound.print(false);
	cout << ")" << endl;

	cout << "\nFirst (";
	first.print(false);
	cout << ") " << (first > secound ? ">" : "<=") << " Secound (";
	secound.print(false);
	cout << ")" << endl;

	cout << "\nFirst (";
	first.print(false);
	cout << ") " << (first < secound ? "<" : ">=") << " Secound (";
	secound.print(false);
	cout << ")" << endl;

	cout << endl;
	system ("pause");
	return 0;
}