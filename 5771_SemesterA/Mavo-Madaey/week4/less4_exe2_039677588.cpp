#include <iostream>
#include <fstream>
using namespace std;

//תוכנית הקולטת מספר חיובי שלם ל-A ומספר חיובי שלם ל-B.
//לאחר מכן, על התוכנית  לקלוט מספרים שלמים  עד שסכומם גדול מ-A או עד שכמות המספרים שנקלטו שווה ל-B.
//על התוכנית להדפיס את סכום המספרים שנקלטו.
//הקלט יימצא בקובץ, כאשר בין ערך אחד לשני יופיע רווח אחד, והפלט ייכתב למסך.

int main() {
	int sum = 0, counter = 0, temp = 0;
	unsigned int maxs, maxc;

	//מקבל מהמשתמש את ערכי המקסימום
	cout << "Hello!" << endl << "Please insert the sum-maximum: ";
	cin >> maxs;
	cout << "Please insert the numbers-maximum: ";
	cin >> maxc;

	//פותח את הקובץ
	ifstream thenumbers("less4_exe2_039677588.txt");
	//כל זמן שהתנאים מתקיימים - קורא מהקובץ, ומסכם
	while (((sum += temp) < (int)maxs) && (counter++ < (int)maxc)) thenumbers >> temp;
	//פלט למסך
	cout << "The sum of " << counter << " numbers is " << sum << endl;

	cout << endl;
	system ("pause");
	return 0;
}
