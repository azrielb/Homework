#include <iostream>
using namespace std;

//פונקציית קלט למשתנה מסוג נקודה צפה
double cin_d(int counter) {
	double a;
	cout << "Insert number no. " << counter << endl;
	cin >> a;
	return a;
}

/*
בודק האם המספרים יכולים להרכיב משולש, והאם זהו משולש מיוחד
חלק מהפלט הוא בעברית באותיות לטיניות, וחלק באנגלית
*/
int main(){
	double a, b, c;
	while (1) {
		a = cin_d(1);
		b = cin_d(2);
		c = cin_d(3);
		if (c >= a+b) cout << "c >= a+b";
		else if (a >= c+b) cout << "a >= c+b";
		else if (b >= a+c) cout << "b >= a+c";
		else break;
		cout << endl << "This is not a triangle!" << endl << "Please try again." << endl << endl;
	}
	switch ((a==b) + (b==c) + (a==c)) {
	case 0:		cout << "Meshulash shone tzelaot";	break;
	case 1:		cout << "Meshulash sheve shokaim";	break;
	default:	cout << "Meshulash sheve tzelaot";
	}
	if (c*c == a*a + b*b ||a*a == b*b + c*c || b*b == a*a + c*c) cout << endl << "Meshulash yeshar zavit";
	cout << endl << endl;
	system("pause");
	return 0;
}