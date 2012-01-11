#include <iostream>
#include <stack>
#include <stdlib.h>
#include <time.h>
using namespace std;

int main () {
	srand((unsigned) time(NULL));
	stack<int> stk, ezer;
	int toRemove;
	cout << "The stack contains these numbers:" << endl;
	for (int a = 0; a < 20; ++a) {
		int temp = rand() % 10;
		cout << temp << '\t';
		stk.push(temp);
	}
	while (!stk.empty()) {
		ezer.push(stk.top());
		stk.pop();
	}
	cout << endl << "Please select the number that you want remove its duplicates from stack: ";
	cin >> toRemove;
	cout << endl << "The number " << toRemove << " has been removed. Now the stack contains these numbers:" << endl;
	while (!ezer.empty() && ezer.top() != toRemove) {
		stk.push(ezer.top());
		cout << ezer.top() << '\t';
		ezer.pop();
	}
	while (!ezer.empty()) {
		if(ezer.top() != toRemove) {
			stk.push(ezer.top());
			cout << ezer.top() << '\t';
		}
		ezer.pop();
	}
	cout << endl;
	system ("pause");
	return 0;
}