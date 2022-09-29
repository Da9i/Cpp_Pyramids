#include<iostream>
#include<iomanip>
using namespace std;
int main()
{
	int opt, range;
	cout << "option 1 : half pyramid." << endl;
	cout << "option 2 : inverted half pyramid." << endl;
	cout << "option 3 : right oriented half pyramid." << endl;
	cout << "option 4 : right oriented inverted half pyramid." << endl;
	cout << "select option 1-4 :";
	cin >> opt;
	cout << "enter range :";
	cin >> range;
	if (opt == 1)
		for (int a = 1; a <= range; a++)
		{
			for (int b = 1; b <= a; b++)
				cout << "*";
			cout << endl;
		}
	else if (opt == 2)
		for (int c = 1; c <= range; c++)
		{
			for (int d = range; d >= c; d--)
				cout << "*";
			cout << endl;
		}
	else if (opt == 3)
		for (int e = 1; e <= range; e++)
		{
			for (int f = range - e; f > 0; f--)
			{
				cout << " ";
			}

			for (int g = 1; g <= e; g++)
			{
				cout << "*";
			}
			cout << endl;
		}
	else if (opt == 4)
		for (int x = 1; x <= range; x++)
		{
			for (int s = x; s > 1; s--)
			{
				cout << " ";
			}

			for (int z = range; z >= x; z--)
			{
				cout << "*";
			}
			cout << endl;

		}
		system("pause>0");
}
