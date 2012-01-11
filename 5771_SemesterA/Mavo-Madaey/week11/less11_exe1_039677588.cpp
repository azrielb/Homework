#include <iostream>
using namespace std;
/*
פונקציה רקורסיבית המקבלת מערך שלמים ומחזירה את האיבר המקסימלי.
//*/
int maxElem(int [],int);

//פונקציית המיין נכתבה לבדיקה בלבד, ולכן אתחלתי בה את המערך בערכים שרירותיים
int main() {
	int a[17] = {13,25,2,73,37,34,3,63,4,23,67,3,25,6,23,9,8};
	cout << maxElem(a, 17);

	cout << endl;
	system ("pause");
	return 0;
}

int maxElem(int arr[],int length) {
	if (length < 1) return 0;
	int big = maxElem(arr + 1, length - 1);
	return (big < arr[0]) ? arr[0] : big;
}