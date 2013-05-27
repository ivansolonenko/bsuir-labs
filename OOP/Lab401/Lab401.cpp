#include "Lab401.h"

#define T short

void main()
{
	Stack<T> stack;
	T input = -1;
	char buffer[256] = {0};

	cout << "Input numbers into stack. Enter -1 to exit" << endl;
	do
	{
		cout << "$ ";
		cin >> buffer;
		input = atoi(buffer);
		if(input == -1)
			break;
		try
		{
			stack.Push(input);
		}
		catch(IndexException exc)
		{
			cout << "Error " << exc.GetErrorCode() << ": " << exc.PrintErrorMessage() << endl;
		}
		catch(OverflowException exc)
		{
			cout << "Error " << exc.GetErrorCode() << ": " << exc.PrintErrorMessage() << endl;
		}
		catch(RangeException exc)
		{
			cout << "Error " << exc.GetErrorCode() << ": " << exc.PrintErrorMessage() << endl;
		}
		catch(MemoryException exc)
		{
			cout << "Error " << exc.GetErrorCode() << ": " << exc.PrintErrorMessage() << endl;
		}
	} while(true);

	cout << endl;

	while(! stack.IsEmpty() )
	{
		cout << "> " << stack.Pop() << endl;
	}
}
