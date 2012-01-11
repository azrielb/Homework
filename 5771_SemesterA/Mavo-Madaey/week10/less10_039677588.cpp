#include<iostream>
#include<ctime>
using namespace std;

//יש בעיה בתוכנית, שגודל המילה זהה לגודל הטבלה, אבל אני לא צריך לתקן שגיאות-לוגיות שלא ביקשו ממני לחשוב עליהן...

// מלבד זאת - התוכנית לא עובדת טוב, אבל אני גמור מעייפות, אז עכשיו העליתי את הקובץ, ואם יותר מאוחר אספיק לתקן - אתקן.
const int n=4;
struct Word
{
	char word[n];
	int x;
	int y;
};
struct Table
{
	char table[n][n];
};

void InitWordNull(Word& w)
{
	w.word[0]='\0';
	w.x=-1;
	w.y=-1;
}
void InitWord(Word& w)
{
	cin>>w.word;
	w.x=-1;
	w.y=-1;
}
void printWord(Word w)
{
	cout<<w.word<<"["<<w.x<<","<<w.y<<"]"<<endl;
}
void InitTableNull(Table& t)
{
	for(int i=0;i<n;i++)
		for(int j=0;j<n;j++)
			t.table[i][j]='\0';
}
void InitTable(Table& t)
{
	for(int i=0;i<n;i++)
		for(int j=0;j<n;j++)
			cin>>t.table[i][j];
}
void PrintTable(const Table& t)
{
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<n;j++)
			cout<<t.table[i][j]<<" ";
		cout<<endl;
	}
}
void GetWords(Word words[],int size=n)
{
	for(int i = 0; i < size; ++i) {
		cout << "Please insert a word (no. " << i + 1 << "). maximum " << size << " letters.\t";
		InitWord(words[i]);//each word's length is maximum N
	}
}
void printWords(Word words[],int size)
{
	for(int i=0;i<size;i++)
	{
		printWord(words[i]);
	}
}
bool shabetzOne(Word& w, Table& t, char x, char y, char dir) {
	// dir: 0 = ltr, 1 = up to down, 2 = up-left to down-right, 3 = down-left to up-right
	char i, j, k;
	for (i = x, j = y, k = 0; k < n; ++k) {
		if (i < 0 || i > n || k > n || (t.table[i][j] != '\0' && t.table[i][j] != w.word[k])) return false;
		if (dir == 3) --i; else if (dir % 2 == 0) ++i;
		if (dir != 1) ++j;
	}
	for (w.x = (int)(i = x), w.y = (int)(j = y), k = 0; k < n; ++k) {
		t.table[i][j] = w.word[k];
		if (dir == 3) --i; else if (dir % 2 == 0) ++i;
		if (dir != 1) ++j;
	}
}
bool putWord(Word& w, Table& t)
{
	char x,y, dir;
	srand((unsigned)(time(NULL) * rand())); //ההכפלה במספר אקראי משפרת את האקראיות במקרה שקוראים לפונקציה כמה פעמים
	for (char tries = n * n; tries; --tries) {
		x = rand() % n;
		y = rand() % n;
		dir = rand() % 4; // dir: 0 = ltr, 1 = up to down, 2 = up-left to down-right, 3 = down-left to up-right
		if (shabetzOne(w, t, x, y, dir)) return true;
	}
	return false;
}
bool ShabetzAll(Word* words,Table& t,int size)
{
	srand((unsigned)(time(NULL) * rand())); //ההכפלה במספר אקראי משפרת את האקראיות במקרה שקוראים לפונקציה כמה פעמים
	char i,j;
	for (i=0; i < size; ++i) 
		if (!putWord(words[size], t))
			return false;
	for (i=0; i < n; ++i) 
		for (j=0; j < n; ++j) 
			t.table[i][j]= 'a' + rand() % ('z' - 'a' + 1);
	return true;
}
double GetLocations(Word* words,Table& t,int size)
{
	PrintTable(t);
	int a,b;
	double tests = 0, goods = 0;
	for (char i = 0; i < size; ++tests) {
		cout << "Which a table's row begins the word \"" << words[i].word << "\"?\t";
		cin >> a;
		cout << "And which a table's column begins it?\t";
		cin >> b;
		if (a < 0 || b < 0) break;
		if (a == words[i].x && b == words[i].y) {
			cout << "Yes sir!" << endl << endl;
			++i;
		} else {
			cout << "Oh no! You made a mistake!" << endl << "Please try again..." << endl << endl;
			if (tests > size * size) break;
		}
	}
	return goods / tests;
}
void Uplay(Word* words,Table& t,int size)
{
	InitTableNull(t);
	GetWords(words, size);
	if (ShabetzAll(words, t, size)) GetLocations(words, t, size);
	else cout << "Error in SHIBUTZ";
}
int main()
{
	Word theWords[n];
	Table theTable;
	Uplay(theWords, theTable, n);

	cout << endl;
	system("pause");
	return 0;

}