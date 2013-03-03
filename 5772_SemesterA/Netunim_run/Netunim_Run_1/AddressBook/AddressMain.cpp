#include "AddressGroup.h"
#include "SingleAddress.h"

int main(void)
{
	//the tree's root
	AddressGroup * addressBook = new AddressGroup("My Adderss Book");
	AddressGroup * categories[2] = { new AddressGroup("1st category"), new AddressGroup("2nd category")};
	SingleAddress * child[4] = { 
		new SingleAddress("1st child"), 
		new SingleAddress("2nd child"), 
		new SingleAddress("3rd child"), 
		new SingleAddress("4th child"),
	};

	//Insert items to the tree
	addressBook->add(categories[0]);
	addressBook->add(categories[1]);
	categories[0]->add(child[0]);
	categories[0]->add(child[1]);
	categories[0]->add(child[2]);
	categories[1]->add(child[3]);
	categories[1]->add(new SingleAddress("5th child", "a@b.com", "0721234567", "0731234567", "21 Havaad haleumi St., Jerusalem - The holy city."));

	//Print the tree
	addressBook->print();

	cout << "Please press any key to continue...";
	system("pause >> nul");
}
