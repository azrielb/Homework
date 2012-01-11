#include <iostream>
using namespace std;

//קלט: מספר חיובי ושלם.
//פלט: הודעה אם יש לו שורש שלם- דהיינו אם יש מספר חיובי ושלם שאם נעלה אותו בריבוע נקבל את המספר.

int main() {
	unsigned int root1 = 1, root2, root3, square, num;
	cout << "Hello, Pythagoras..." << endl << "Please insert an positive integer number: ";
	cin >> num;
	root2 = num;
	//חיפוש השורש באמצעות שיטת החציה
	while (root1 != root2) {
		if ((square = (root3 = (root1 + root2) / 2) * root3) == num) root1 = root2 = root3;
		else if (root1 + 1 == root2) root1 = root2; //מניעת לולאה אינסופית
		else if (square > num) root2 = root3;
		else root1 = root3;
	}//הצומדיים אמנם מיותרים, אך אחרת העיצוב של הקובץ לא יהיה טוב
	if (root1 * root2 == num) cout << endl << "The number " << num << " has a square root: " << root1;
	else cout << "Your number doesn't have a square root";

	cout << '.' << endl << endl;
	system ("pause");
	return 0;
}