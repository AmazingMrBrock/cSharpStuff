#include <iostream>
	
int doublenumber(int x)
{
	return 2 * x;
}

int main()
{
	using namespace std;
	int x;
	cin >> x;
	cout << doublenumber(x) << endl;
	return 0;
}

