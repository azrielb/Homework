#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Student {
protected:
	long id;
	string FirstName, LastName;
	short courses;
public:
	Student(long Sid, string SFN, string SLN, short Scourses = 0);
	Student(const Student & other);
	virtual ~Student() { }
	virtual bool milga() { return false; } // For "not considered students".
	virtual void print(bool end_line = true);
	friend istream& operator>> (istream& is, Student * & temp);
};

class BA : public Student {
protected:
	short * grades;
	int average();
public:
	BA(long Sid, string SFN, string SLN, short * Sgrades, short Scourses = 0);
	BA(const BA & other);
	virtual ~BA() { delete [] grades; }
	virtual bool milga() { return (courses >= 10 && average() > 95); }
	virtual void print(bool end_line  = true);
};

class MA : public BA {
protected:
	bool research;
public:
	MA(long Sid, string SFN, string SLN, short * Sgrades, short Scourses = 0, bool Sresearch = false) 
		: research(Sresearch), BA(Sid, SFN, SLN, Sgrades, Scourses) { }
	virtual bool milga() { return (research && courses >= 7 && average() > 90); }
	virtual void print(bool end_line  = true);
};

class PHD : public Student {
protected:
	short research; // Num of weekly-hours
public:
	PHD(long Sid, string SFN, string SLN, short Scourses = 0, short Sresearch = 0) 
		: research(Sresearch), Student(Sid, SFN, SLN, Scourses) { }
	virtual bool milga() { return (courses >= 2 && research > 25); }
	virtual void print(bool end_line  = true);
};

Student::Student(long Sid, string SFN, string SLN, short Scourses) : id(Sid), courses(Scourses) {
	FirstName = SFN;
	LastName = SLN;
}

Student::Student(const Student & other) 
: id(other.id), courses(other.courses) ,FirstName(other.FirstName) ,LastName(other.LastName) {}

void Student::print(bool end_line) {
	cout << "id: " << id << "\tName: " << FirstName << ' ' << LastName << ".\tCourses: " << courses;
	if (end_line) cout << endl;
}

BA::BA(long Sid, string SFN, string SLN, short * Sgrades, short Scourses) : Student(Sid, SFN, SLN, Scourses) { 
	if (Scourses) grades = new short[Scourses];
	while (Scourses) grades[--Scourses] = Sgrades[Scourses];
}

BA::BA(const BA & other) : Student(other) {
	if (courses) grades = new short[courses];
	for (int a = 0; a < courses; ++a) grades[a] = other.grades[a];
}

int BA::average() {
	int sum = 0;
	for (int a = 0; a < courses; ++a) sum += grades[a];
	return sum / courses;
}

void BA::print(bool end_line) {
	Student::print(false);
	cout << " average: " << average();
	if (end_line) cout << endl;
}

void MA::print(bool end_line) {
	Student::print(false);
	cout << " average: " << average() << " research: " << research;
	if (end_line) cout << endl;
}

void PHD::print(bool end_line) {
	Student::print(false);
	cout << " research: " << research;
	if (end_line) cout << endl;
}

istream& operator>> (istream& is, Student * &temp) {
	short type, Scourses;
	long Sid;
	string SFN;
	string SLN;
	short * Sgrades;
	int Sresearch;
	cout << "Choose which type of student you want:\nBA=1, MA = 2, PHD = 3, others = any other number.\n?";
	is >> type;
	if (type > 3) type = 0;
	cout << "id?\t";
	is >> Sid;
	cout << "Name (first & last, seperated by white-space)?\t";
	is >> SFN >> SLN;
	cout << "How much courses does the student learn?\t";
	is >> Scourses;
	if (type == 1 || type == 2) {
		Sgrades = new short[Scourses];
		cout << "Type the grades of the student in all courses (seperated by white-space):\t";
		for (int a = 0; a < Scourses; ++a)
			is >> Sgrades[a];
	}
	if (type > 1) {
		cout << "How much hours does the student make a research (if the student does not make researchs type 0)?\t";
		is >> Sresearch;
	}
	switch (type)
	{
	case 1:
		temp = new BA(Sid, SFN, SLN, Sgrades, Scourses);
		delete[] Sgrades;
		break;
	case 2:
		temp = new MA(Sid, SFN, SLN, Sgrades, Scourses, Sresearch > 0);
		delete[] Sgrades;
		break;
	case 3:
		temp = new PHD(Sid, SFN, SLN, Scourses, Sresearch);
		break;
	default:
		temp = new Student(Sid, SFN, SLN, Scourses);
	}
	return is;
}

void print_zacaim(vector<Student *> students) {
	int a = students.size();
	while (a)
		if (students[--a]->milga())
			students[a]->print();
}

int main() {
	unsigned num;
	Student * student;
	vector<Student *> students; // the "Vector" class can't declare "Student" objects, however what you say is what you get...
	cout << "How much students do you have? ";
	for (cin >> num; num; --num) {
		cin >> student;// I wrote a friend "operator>>" function for the test.
		students.push_back(student);
	}
	print_zacaim(students);
	system("pause");
	return 0;
}
