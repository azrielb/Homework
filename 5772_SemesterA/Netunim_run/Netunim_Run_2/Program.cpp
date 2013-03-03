#include "Address.h"
#include "PhoneBook.h"
#include <stdlib.h>
#include <time.h>
#include <sstream>

/* מספרי ת.ז.:
עזריאל ברגר 039677588
יעקב ברזילי 033233222 
*/

void print_person(HashTable<string, Address *> * PB,string name) {
	Address * person = PB->find(name);
	if (person == NULL)
		cout << name << " is not found in the phone-book!" << endl;
	else 
		cout << *person;
}

int main()
{
	PhoneBook * test = new PhoneBook(13);
	string names[12] = {
		"Reuvven", "Shim'on", "Levi", "Yehudah", "Yisachar", "Zevulun", "Gad", "Naftali", "Dan", "Asher", "Yossef", "Binyamin"
	};
	string numbers[24] = {
		"1403280397", "1909410909", "1236014011", "2039704710", "9213741032", "2809174017", "0923741070", "1093470147", 
		"0287404708", "4347120347", "1423010109", "1701270012", "0123701092", "7481270129", "0912737107", "1239481709", 
		"9827197409", "1287170912", "0981734270", "4730910021", "1230714070", "0984713270", "3487109018", "1928740914"
	};
	for (int i = 0; i < 12; ++i)
		test->add(new Address(names[i], names[i] + "@domain.com", numbers[i], numbers[i + 12], names[i] + "'s address"));
	test->print();
	string name = "Gad";
	cout << endl << "change " << name << "'s data" << endl;
	test->add(new Address(name));
	print_person(test, name);
	cout << endl << "Remove " << name << endl;
	test->remove(name);
	print_person(test, name);
	cout << endl;
	test->print();
	delete test;
	cout << endl;
	return 0;
}