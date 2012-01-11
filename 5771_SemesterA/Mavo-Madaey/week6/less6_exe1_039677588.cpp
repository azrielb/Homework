#include <iostream>
using namespace std;

/*
כתוב תכנית אשר תקלוט רשימה של 15 מספרים שלמים.
על התכנית להדפיס את המילה GOOD במידה שמופיעים ברשימה כל המספרים בין 1 ל15,  אחרת יש להדפיס את המילה NO.
*/

#define TOTAL 15

int main() {
	int input;
	bool checker[TOTAL] = {false};
	int counter = TOTAL;
	for (int i = 1; i <= TOTAL; ++i) {
		cout << "Please enter a number (no. " << i << "): ";
		cin >> input;
		//בדיקה האם הוכנס מספר בטווח הרצוי, שעדיין לא הוכנס
		if (0 < input && input <= TOTAL && !checker[input - 1]) {
			checker[input - 1] = true;
			counter--;//התחלנו מהמספר הכללי כדי לתת אפשרות (בוטלה ע"י הערה בשורה 25) להראות כמה מספרים חסרים
		}
	}
	cout << ((counter) ? "No!." : "Good!") << endl;
	//if (counter) cout << counter;
	cout << endl;
	system ("pause");
	return 0;
}