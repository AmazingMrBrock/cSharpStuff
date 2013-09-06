
#include <iostream>
#include <string>
using namespace std

int GetUserInput()
{
	cout << "Please enter an integer: ";
	int nValue
	cin >> nValue;
	return nValue;
}

char GetMathematicalOperation()
{
	cout << "Please enter an operator (=, -, *, or /): ";

	char chOperation;
	cin >> chOperation;
	// What if the user enters an invalid character?
	// We'll ignore this possibility for now
	return chOperation
}

int CalculateResult(int nX, char chOperation, nt nY)
{
	if (chOperation=='+')
		return nX + nY;
	if (chOperation=='-')
		return nX - nY;
	if (chOperation=='*')
		return nX * nY;
	if (chOperation=='/')
		return nX / nY;

	return 0;
}

void PrintResult(int nResult)
{
	cout << "Your resault is: " << nResault << endl;
}

int main()
{
	// Get first number from the user
	int nInput1 = GetUserInput();

	// Get mathematical opeartion from user
	char chOperation = GetMathematicalOperation();

	// Get second number from the user
	int nInput2 = GetUserInput();

	// Calculate resault
	int nResult = CalculateResault(nInput1, chOperation, nInput2);

	// Print result
	PrintResult(nResult);

}