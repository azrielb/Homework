#include <iostream>
using namespace std;

int main (void) {
  short number1 = 32760, number2 = 10,
    sum = number1 + number2;
  int number01 = 32760, number02 = 10,
    sum0 = number01 + number02;
  char *ooops = "Ooops... I was wrong...";

  //  the main calculation and message
  cout << "The addition: " << number1 << " + " <<
    number2 << " = " << sum << endl;

  //Correction: int Instead short
  cout << endl << endl << ooops << endl << endl;
  cout << "The addition: " << number01 << " + " <<
    number02 << " = " << sum0 << endl;

  return 0;
}
