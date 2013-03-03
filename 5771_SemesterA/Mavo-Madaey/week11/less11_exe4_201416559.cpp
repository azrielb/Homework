#include<iostream>
using namespace std;
void reverseNum(unsigned long int,unsigned long int&);
int main(void)
{
	unsigned long int revNum=0;
	reverseNum(955614102,revNum);
	cout<<revNum<<endl;
	system("pause");
	return 0;
}
void reverseNum(unsigned long int num,unsigned long int&revNum)
{
	revNum+=num%10;
	if(num<10)
		return;
	revNum*=10;
	reverseNum(num/10,revNum);
}