#include "Lab301.h"

void main()
{
	int i;
	int size1 = 0, size2 = 0;

	cout << "Sizes of arrays: ";
	cin >> size1 >> size2;
	cout << endl;

	Array obj1(size1), obj2(size2), obj3;

	cout << "Array 1: ";
	for(i=0; i<size1; i++)
		cin >> obj1;
	cout << "Array 2: ";
	for(i=0; i<size2; i++)
		cin >> obj2;

	cout << endl;

	cout << setw(10) << "Crossing:";
	obj3 = obj1 - obj2;
	//obj3 = obj1.Cross(obj2);
	//obj3.Cross2(obj1, obj2);
	cout << obj3;

	cout << setw(10) << "Uniting:";
	obj3 = obj1 + obj2;
	//obj3 = obj1.Unite(obj2);
	//obj3.Unite2(obj1, obj2);
	cout << obj3;
}
