#include <iostream>
using namespace std;

class Rational
{
private:
	int mone;
	int mechane;
public:
	//constructor
	Rational (int myMone=1, int myMechane=1) :mone(myMone), mechane(myMechane) { }
	Rational (const Rational& num) :mone(num.getMone()), mechane(num.getMechane()) { }
	//destructor
   ~Rational () {cout << "The object of" <<this << "address is destroyed" << endl;}
	//modify functions
	void setMone(int myMone) { mone = myMone; }
	void setMechane(int myMechane) { mechane = myMechane; }

	//view functions
	int getMone() const { return mone; }
	int getMechane() const { return mechane; }

	//operations
	Rational operator+(Rational) const;
	Rational operator-(Rational) const;
	Rational operator*(Rational) const;
	Rational operator/(Rational) const;
	bool operator==(const Rational&) const;
	inline bool operator!=(const Rational& other) const { return !(*this == other); }
	bool operator>(const Rational&) const;
	inline bool operator<=(const Rational& other) const { return !(*this > other); }
	bool operator<(const Rational&) const;
	inline bool operator>=(const Rational& other) const { return !(*this < other); }
	Rational& operator=(const Rational &);
	Rational operator++();
	Rational operator++(int);
	Rational operator--();
	Rational operator--(int);

	//output
	void print() const { cout << mone << '/' << mechane << endl; }
};					

Rational Rational::operator +(Rational num) const {
	Rational tmp;
	tmp.mone = mone * num.mechane + mechane * num.mone;
	tmp.mechane = mechane * num.mechane;
	return tmp;
} 
Rational Rational::operator -(Rational num) const {
	Rational tmp;
	tmp.mone = mone * num.mechane - mechane * num.mone;
	tmp.mechane = mechane * num.mechane;
	return tmp;
} 
Rational Rational::operator *(Rational num) const {
	Rational tmp;
	tmp.mone = mone * num.mone;
	tmp.mechane = mechane * num.mechane;
	return tmp;
}
Rational Rational::operator /(Rational num) const {
	Rational tmp;
	tmp.mone = mone * num.mechane;
	tmp.mechane = mechane * num.mone;
	return tmp;
}  
Rational & Rational::operator =(const Rational & num) {
	mone = num.mone;
	mechane=num.mechane;
	return *this;
}

bool Rational::operator==(const Rational & num) const {
	return (mone * num.mechane == num.mone * mechane); // This method return TRUE also for "(-2)/(-4) == 3/6"
}
bool Rational::operator>(const Rational & num) const {
	Rational tmp = ((Rational)(*this) - num);
	return ((tmp.mone * tmp.mechane) > 0); // This method also handles negative numbers
}
bool Rational::operator<(const Rational & num) const {
	Rational tmp = ((Rational)(*this) - num);
	return ((tmp.mone * tmp.mechane) < 0); // This method also handles negative numbers
}

Rational Rational::operator++() {
	mone += mechane;
	return *this;
}

Rational Rational::operator++(int u) {
	Rational temp = *this;
	mone += mechane;
	return temp;
}

void comparing_printer(Rational num1, char type, Rational num2, bool inverse = false) {
	cout << num1.getMone() << '/' << num1.getMechane() << ' ';
	switch (type) {
		case '=':
			if (inverse) cout << (num1 != num2 ? "!=" : "==");
			else cout << (num1 == num2 ? "==" : "!=");
			break;
		case '>':
			if (inverse) cout << (num1 <= num2 ? "<=" : ">");
			else cout << (num1 > num2 ? ">" : "<=");
			break;
		case '<':
			if (inverse) cout << (num1 >= num2 ? ">=" : "<");
			else cout << (num1 < num2 ? "<" : ">=");
			break;
	}
	cout << ' ' << num2.getMone() << '/' << num2.getMechane() << endl;
}

void main()
{
	Rational num1(1,2), num2(1,4), num3;
	cout<<"num1=";		
	num1.print();

	cout<<"num2=";		
	num2.print();

	num3=num1+num2;
	cout<<"num1+num2=";	
	num3.print();

	num3=num1-num2;
	cout<<"num1-num2=";	
	num3.print();

	num3=num1*num2;
	cout<<"num1*num2=";	
	num3.print();

	num3=num1/num2;
	cout<<"num1/num2=";	
	num3.print();
	num3.setMone(2);
	num3.setMechane(1);
	comparing_printer(num1,'=',num2);
	comparing_printer(num1 + num1,'=',num1 * num3,1);
	comparing_printer(num1,'>',num2);
	comparing_printer(num2,'>',num1,1);
	comparing_printer(num1,'<',num2);
	comparing_printer(num2,'<',num1,1);
	system("pause");
}