
// default capacity for the vector
const int DEF_CAPACITY = 100;

class Vector
{
private:
	int *data;
	int size;		//size in use
	int capacity;	//available capacity
public:
	//constructors
	Vector(int capacity = DEF_CAPACITY);
	Vector(const Vector&);
	~Vector();
	//operations
	int& operator = (const int&);
	//modify
	int& operator [](int index);
	//view
	const int&   operator [](int index) const;
	Vector &Vector::operator = (const Vector& vec);
	int	Size() const;
	int  Capacity() const;
	void Insert(int value);
	void  Clear();
	int  DelLast();
}; 


Vector::Vector(int Capacity)
{
	capacity = Capacity;
	size =0;
	data = new int[capacity];
}

Vector::Vector(const Vector& vec)
{
	capacity = vec.capacity;
	size = vec.size;
	data = new int[capacity];
	for (int index=0; index<size; index++)
		data[index] = vec.data[index];
}

Vector::~Vector()
{
	if (data != 0)    {
		delete [] data;
		data = 0;
	}
}

//view function

int& Vector::operator [](int index)
{
	return data[index];
}

//modify function

const int& Vector::operator [](int index) const
{
	return data[index];
}


Vector &Vector::operator = (const Vector& vec)
{
	size = vec.size;
	capacity = vec.capacity;

	if (data)
		delete [] data;
	data = new int[capacity];
	for (int index=0; index<size; index++)
		data[index] = vec.data[index];

	return *this;
}
int Vector::Size() const
{
	return size;
}

int Vector::Capacity() const
{
	return capacity;
}

void Vector::Insert(int value)
{
	data[size]=value;
	size++;
}
void Vector::Clear()
{
	size=0;
}
int Vector::DelLast()
{
	return data[--size];
}
