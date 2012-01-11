#include <iostream>
#include <stack>
#include <string>
using namespace std;

bool isPalindrome (string str) {
	stack<char> stk;
	unsigned a = 0;
	// Insert a half if the string to the stack:
	for (; 2 * a < str.length(); ++a)
		stk.push(str[a]);
	// If string length is an odd number - change the value of "a"
	a = str.length() / 2;
	// Compare one by one the next character in the string with the previous character in the stack
	for (; a < str.length(); ++a) {
		if (stk.top() != str[a]) return false;
		stk.pop();
	}
	return true;
	/* 
	 * I know that this problem can be solved without a stack, but what you say is what you get ;)
	 * If you have a better function - I'll be happy to learn it.
	 *
	 */
}

int main () {
	string word;
	cout << "Enter 1 word:\t";
	cin >> word;
	cout << "The word '" << word << "' is ";
	if (!isPalindrome(word)) cout << "not ";
	cout << "a palindrome." << endl;
	system ("pause");
	return 0;
}