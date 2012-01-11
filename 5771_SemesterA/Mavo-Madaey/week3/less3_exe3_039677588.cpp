#include <iostream>
using namespace std;

/*
3.	קלוט מספר שלם וחיובי המייצג מרחק בסנטימטרים והמר אותו לתצוגה , בעזרת פקודת switch, לפי בחירת המשתמש למילימטרים, מטרים או קילומטרים.*/
int main() 
{
	int distance, convert;
	cout << "Please enter the distance - unit: cm." << endl;
	cin >> distance;
	cout << endl << "Please enter the convert:" << endl << "1 = mm, 2 = km, 3 = m, all other - not convert (cm)" << endl;
	cin >> convert;
	cout << endl << "your distance is ";
	switch (convert) {
	case 1:
		cout << distance * 10 << "mm";
		break;
	case 2:
		cout << distance / 100000.0 << "km";
		break;
	case 3:
		cout << distance / 100.0 << "m";
		break;
	default:
		cout << distance << "cm";
		break;
	}

	cout << endl << endl;
	system("pause");
	return 1;
}
