/*	реализовать класс string для работы со строками символов
	перегрузить операции +, +=, =, ==, !=, >, <, [], ()
	для любой одной функции определить функцию friend */

#include "Lab303.h"

void main()
{
	String obj1("abcdefgh"), obj2("ijklmnop"), obj3(obj1);
	if(obj1 != obj2)
		cout << "obj1 != obj2" << endl;
	if(obj1 == obj3)
		cout << "obj1 == obj3" << endl;
	cout << obj1 << "\t" << obj2 << "\t" << obj3 << endl;
	for(int i=0; i<obj2.GetSize(); i++)
		cout << "[" << i << "] = " << obj2[i] << endl;
	obj3 = obj1(0,3) + obj2(4,7);
	cout << obj3 << endl;

	obj3 += obj1;
	cout << obj3 << endl;

	cout << ">> ";
	cin >> obj3;

	obj1 = obj2 = obj3;

	cout << obj1 << endl << obj2 << endl << obj3 << endl;
}
