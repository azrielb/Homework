#include "TemplateListQueue.h"
#include "TemplateVectorQueue.h"

int main() {
	Queue<int>* Q;
	char base[7];
	cout<<"Do you want a list base or a vector base Queue? ";
	cin>>base;
	if (!strcmp(base,"vector")) {
		cout << "Ok. It will be done by vector..." << endl;
		Q=new QueueVector<int>(5);
	} else {
		cout << "Ok. It will be done by list..." << endl;
		Q=new QueueList<int>();
	}
	for(int i=0;i<5;i++)
		Q-> enqueue (i);
	cout<<"first on Q is: "<<Q->front()<<endl;
	cout<< "take out 2 elemets:"<<endl;
	cout<< Q-> dequeue ();
	cout <<" "<<Q->dequeue()<<endl ;
	cout<<"first on Q is: "<<Q->front()<<endl;
	Q->enqueue(8);
	Q->enqueue(9);
	while(!Q->isEmpty())
		cout<< Q->dequeue() << " " ;

	cout << endl;
	system("pause");
}