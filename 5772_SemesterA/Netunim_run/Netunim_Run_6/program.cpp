#include <string>
#include <iostream>
#include "Graph.h"
using namespace std;

/* ID's numbers: 
** Azriel Berger 039677588
** Ya'akov Barzilay 033233222 
**/

int main() {
	Graph<string> myGraph = Graph<string>();
	cout << "storing emails with graph:" << endl << "==========================" << endl << endl;
	string typing = "9";
	while (true) {
		int menu = (typing.length() == 1) ? typing[0] - '0' : 0;
		if (menu == 1 || menu == 2) {
			string email;
			cout << "please insert email address:\t";
			cin >> email;
			cout << email << " have been ";
			if (menu == 1)
				cout << (myGraph.addVertex(email) ? "" : "not ") << "inserted successfully." << endl;
			else
				cout << (myGraph.removeVertex(email) ? "" : "not ") << "removed successfully." << endl;
		} else if (menu == 3 || menu == 4 || menu == 5) {
			string from, to;
			cout << "please insert email address \"from\":\t";
			cin >> from;
			cout << "please insert email address \"to\":\t";
			cin >> to;
			switch (menu * 1) {
			case 3:
				cout << "The email from " << from  << " to " << to << " have been ";
				cout << (myGraph.addEdge(from, to) ? "" : "not ") << "sent successfully." << endl;
				break;
			case 4:
				cout << "The email from " << from  << " to " << to << " have been ";
				cout << (myGraph.removeEdge(from, to) ? "" : "not ") << "canceled successfully." << endl;
				break;
			case 5:
				cout << "There is " << (myGraph.thereIsPath(from, to) ? "" : "not ") << "an path of emails from " << from  << " to " << to;
				break;
			}
		} else if (menu == 6) {
			myGraph.printPairs();
		} else if (menu == 9) {			
			cout << "menu:" << endl
				<< "1 - add address. 2 - remove address. 3 - send email. 4 - cancel email." << endl
				<< "5 - check wheter there is an email from an address.to another address." << endl
				<< "6 - print all the pairs that sent emails in the tow directions." << endl
				<< "9 - get this menu;" << endl
				<< "another typing - exit" << endl;
		} else {
			break;
		}
		cout << endl;
		cin >> typing;
	}
	return 0;
}
