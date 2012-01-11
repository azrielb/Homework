#include <iostream>
using namespace std;

class employee {
private:
	unsigned long id_num;
	float HourlyWage, hours, overtime;
	float salary() { return HourlyWage * (hours + overtime * 1.5);}
public:
	employee(unsigned long id, float HW, float h, float o) : id_num(id), HourlyWage(HW), hours(h), overtime(o) { }
	void printer() { 
		cout << "Worker #" << id_num << " earns " << HourlyWage << " NIS per hour. He worked for " << hours 
			<< " normal hours and " << overtime << " extra hours, so his total salary is " << salary() << " NIS.";
	}
};

int main() {
	unsigned long id;
	float HW, h, o;
	cin >> id >> HW >> h >> o;
	employee worker(id, HW, h, o);
	worker.printer();

	return 0;
}

