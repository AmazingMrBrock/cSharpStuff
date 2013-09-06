#include <iostream> 

int nResult()
int chOperation()
void CalculateResult()
int PrintResult()
int ReadNumber()
{
	using namespace std;
	cout << "Please enter an integer: ";
	int nValue;
	cin >> nValue;
	return nValue;
}
	
void WriteAnswer(int nResult)
{
	using namespace std;
	cout << "Your resault is: " << nResault << endl;
}

int main()
{
	// Get first number from the user
	int nInput1 = ReadNumber();

	// Get second number from the user
	int nInput2 = ReadNumber();

	// Calculate resault
	int nResult = CalculateResult(nInput1, chOperation, nInput2);

	// Print result
	PrintResult(nResult);
}
